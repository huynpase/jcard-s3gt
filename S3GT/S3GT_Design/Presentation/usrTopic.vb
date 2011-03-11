Public Class usrTopic
    Private topic As New TopicsBO
    Private list, table As Data.DataTable
    Private curr_row As Data.DataRow
    Private topicentry As TopicsEntity

    Private bFastMode As Boolean
    Public Property FastMode() As Boolean
        Get
            Return bFastMode
        End Get
        Set(ByVal value As Boolean)
            bFastMode = value
        End Set
    End Property

    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Try
            Me.Dock = DockStyle.Fill
            table = topic.GetTopicsTable
            list = topic.GetCob_TopicGroup
            Me.cboTopicGroup.DataSource = list
            Me.cboTopicGroup.DisplayMember = list.Columns.Item(Constants_HaoLT.TOPIC_GROUP_NAME).ToString
            Me.GirdTopic.DataSource = table
            Me.GirdTopic.Columns(Constants_HaoLT.TOPIC_ID).Visible = False
            Me.GirdTopic.Columns(Constants_HaoLT.TOPIC_GROUP_ID).Visible = False
            Me.GirdTopic.Columns(Constants_HaoLT.TOPIC_NAME).AutoSizeMode() = DataGridViewAutoSizeColumnMode.Fill
            Me.GirdTopic.Columns(Constants_HaoLT.TOPIC_NAME).HeaderText = "Topic Name"
            Me.GirdTopic.Columns(Constants_HaoLT.TOPIC_DESCRIPTION).AutoSizeMode() = DataGridViewAutoSizeColumnMode.Fill
            Me.GirdTopic.Columns(Constants_HaoLT.TOPIC_DESCRIPTION).HeaderText = "Topic Description"
            Me.GirdTopic.Columns(Constants_HaoLT.TOPIC_GROUP_NAME).AutoSizeMode() = DataGridViewAutoSizeColumnMode.Fill
            Me.GirdTopic.Columns(Constants_HaoLT.TOPIC_GROUP_NAME).HeaderText = "Topic Group Name"
            Me.GirdTopic.ReadOnly = True
            Me.cboTopicGroup.SelectedIndex = Me.cboTopicGroup.FindString(Constants_HaoLT.DEFAULT_TOPICGROUP_NAME)
        Catch ex As Exception
            MessageBox.Show(Constants_HaoLT.CAPTION_MESS)
        End Try
    End Sub
    Public Sub New(ByVal topicgroup As String)
        Me.New()
        Me.cboTopicGroup.SelectedIndex = Me.cboTopicGroup.FindString(topicgroup)
    End Sub
    Public Sub New(ByVal topicgroup As String, ByVal topicname As String)
        Me.New()
        Me.cboTopicGroup.SelectedIndex = Me.cboTopicGroup.FindString(topicgroup)
        Me.txtTopicName.Text = topicname
        Me.topicentry = Me.topic.GetTopicByName(topicname, topicgroup)
        Me.txtTopicDescription.Text = Me.topicentry.TopicDescription
        Me.cmdUpdate.Enabled = True
        'prevent user to add a new Topic
        Me.cmdSubmit.Enabled = False
        Me.setLink()
        Me.topicentry = Me.topic.GetTopicByName(topicname, topicgroup)
        Me.curr_row = Me.find(topicname, topicgroup, Me.table.Rows)
    End Sub
    Public Sub New(ByVal strTopicGroup As String, ByVal pFastMode As Boolean)
        Me.New()
        Me.bFastMode = pFastMode
        Me.cboTopicGroup.SelectedIndex = Me.cboTopicGroup.FindString(strTopicGroup)
    End Sub
    Private Function find(ByVal topic As String, ByVal group As String, ByVal rows As Data.DataRowCollection) As Data.DataRow
        For Each Item As Data.DataRow In rows
            If (Item.Item(Constants_HaoLT.TOPIC_NAME).ToString = topic And Item.Item(Constants_HaoLT.TOPIC_GROUP_NAME).ToString = group) Then
                Return Item
            End If
        Next
        Return Nothing
    End Function
  
    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Parent.Controls.Remove(Me)
        Me.Finalize()
    End Sub

    Private Sub cmdReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReset.Click
        Me.txtTopicName.Text = Constants_HaoLT.NULLSTRING
        Me.txtTopicDescription.Text = Constants_HaoLT.NULLSTRING
        Me.curr_row = Nothing
        Me.cmdDelete.Enabled = False
        Me.cmdUpdate.Enabled = False
    End Sub

    Private Sub cmdSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSubmit.Click
        Try
            Dim strTopicName As String

            If (Me.topic.is_BLANK(Me.txtTopicName.Text)) Then
                MessageBox.Show(Constants_PhatLS.STR_MSG_ERR_001)
                Exit Sub
            Else

                Dim cbxtext = Me.cboTopicGroup.Items.Item(0).ToString
                If (Me.topic.is_BLANK(cbxtext) Or cbxtext = Constants_HaoLT.NULLSTRING) Then
                    MessageBox.Show(Constants_PhatLS.STR_MSG_ERR_013)

                Else
                    Dim row As Data.DataRow = table.NewRow()
                    Dim row_Group As Data.DataRowView = Me.cboTopicGroup.SelectedItem
                    row(Constants_HaoLT.TOPIC_GROUP_ID) = row_Group.Row.Item(Constants_HaoLT.TOPIC_GROUP_ID)
                    row.Item(Constants_HaoLT.TOPIC_NAME) = Me.txtTopicName.Text
                    'db can be null
                    If (Me.txtTopicDescription.Text = Nothing) Then
                        Me.txtTopicDescription.Text = Constants_HaoLT.BLANK
                    End If
                    row(Constants_HaoLT.TOPIC_DESCRIPTION) = Me.txtTopicDescription.Text
                    row(Constants_HaoLT.TOPIC_GROUP_NAME) = Me.cboTopicGroup.Text
                    If (topic.is_DupcateTopic(table, row)) Then
                        MessageBox.Show(Constants_PhatLS.STR_MSG_ERR_002)
                    Else
                        topicentry = New TopicsEntity()
                        Me.topicentry.TopicGroupName = row.Item(Constants_HaoLT.TOPIC_GROUP_NAME)
                        Me.topicentry.TopicName = row.Item(Constants_HaoLT.TOPIC_NAME)
                        Me.topicentry.TopicGroupID = row(Constants_HaoLT.TOPIC_GROUP_ID)
                        Me.topicentry.TopicDescription = row(Constants_HaoLT.TOPIC_DESCRIPTION)

                        topic.AddNew(topicentry)
                        MessageBox.Show(Constants_PhatLS.STR_MSG_INFO_001, "New Topic Created")
                        'Begin NguyenNB comment: update topic ID before add row
                        row(Constants_HaoLT.TOPIC_ID) = topicentry.TopicID
                        'End NguyenNB comment
                        table.Rows.Add(row)

                        frmMainForm.AddNewTopicToTree(cboTopicGroup.Text, txtTopicName.Text)
                        strTopicName = txtTopicName.Text
                        'reset to first state
                        Me.txtTopicName.Text = Constants_HaoLT.NULLSTRING
                        Me.txtTopicDescription.Text = Constants_HaoLT.NULLSTRING
                        If Not bFastMode Then
                            If (MessageBox.Show(Constants_PhatLS.STR_MSG_INFO_023, Constants_HaoLT.CAPTION_MESS, MessageBoxButtons.YesNo) = MsgBoxResult.Yes) Then
                                Dim objUsrTopic As usrVocabularies
                                objUsrTopic = New usrVocabularies(Me.topicentry.TopicGroupName, Me.topicentry.TopicName, Utils.ModeUpdate.Add)
                                'QuanTDA
                                objUsrTopic.Dock = DockStyle.Fill
                                'end QuanTDA code
                                frmMainForm.panContain.Controls.Add(objUsrTopic)
                                Me.SendToBack()
                            End If

                            Dim usrVoc As usrVocabularies
                            If Not frmMainForm.panContain.Controls.Item(Constants_LanhVC.STR_USR_VOCABULARIES) Is Nothing Then
                                usrVoc = frmMainForm.panContain.Controls.Item(Constants_LanhVC.STR_USR_VOCABULARIES)
                                usrVoc.UpdateTopic(strTopicName)
                            End If
                        Else
                            Me.Parent.Controls.Remove(Me)

                        End If
                    End If
                End If
            End If
        Catch ex As ApplicationException
            MessageBox.Show(ex.ToString)
        Finally
            'LanhVC - start
            'frmMainForm.AddNewTopicToTree(cboTopicGroup.Text, txtTopicName.Text)
            'Dim usrVoc As usrVocabularies
            'If Not frmMainForm.panContain.Controls.Item(Constants_LanhVC.STR_USR_VOCABULARIES) Is Nothing Then
            'usrVoc = frmMainForm.panContain.Controls.Item(Constants_LanhVC.STR_USR_VOCABULARIES)
            'usrVoc.UpdateTopic(txtTopicName.Text)
            'Else
            'usrVoc = New usrVocabularies("", "")
            'End If
            'LanhVC - end
            Me.curr_row = Nothing
            Me.cmdDelete.Enabled = False
            Me.cmdUpdate.Enabled = False
            Me.topicentry = Nothing

        End Try
    End Sub

    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click
        Me.Parent.Controls.Remove(Me)
        Me.Finalize()
    End Sub

    Private Sub GirdTopic_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GirdTopic.RowHeaderMouseClick
        Me.cmdDelete.Enabled = True
        Me.cmdUpdate.Enabled = True
        Me.cmdSubmit.Enabled = True
        Me.curr_row = table.Rows.Item(e.RowIndex)
        Me.cboTopicGroup.SelectedIndex = Me.cboTopicGroup.FindString(Me.curr_row.Item(Constants_HaoLT.TOPIC_GROUP_NAME))
        Me.txtTopicName.Text = Me.curr_row.Item(Constants_HaoLT.TOPIC_NAME)
        Me.txtTopicDescription.Text = Me.curr_row.Item(Constants_HaoLT.TOPIC_DESCRIPTION)
        Me.curr_row = find(Me.txtTopicName.Text, Me.cboTopicGroup.Text, Me.table.Rows)
        Me.topicentry = Me.topic.GetTopicByName(Me.txtTopicName.Text, Me.cboTopicGroup.Text)
    End Sub
    Public Sub delete(ByVal topicgroup As String, ByVal topicname As String)
        'Me.Visible = False ==> this row does not affect anything
        If IsDefaultTopic(topicgroup, topicname) Then
            MessageBox.Show(Constants_PhatLS.STR_MSG_ERR_022)
        Else
            Me.topicentry = Me.topic.GetTopicByName(topicname, topicgroup)
            If (MessageBox.Show(Constants_PhatLS.STR_MSG_INFO_012, Constants_HaoLT.CAPTION_MESS, MessageBoxButtons.YesNo) = MsgBoxResult.Yes) Then
                If (MessageBox.Show(Constants_HaoLT.STR_MSG_ERR_023, Constants_HaoLT.CAPTION_MESS, MessageBoxButtons.YesNo) = MsgBoxResult.Yes) Then
                    topic.DeleteTopicMoveVOC(Me.topicentry)
                Else
                    topic.DeleteTopicVOC(Me.topicentry)
                End If
                frmMainForm.DeleteTopicNote(Me.topicentry.TopicGroupName, Me.topicentry.TopicName)
                Me.Finalize()
            End If
        End If
    End Sub
    Private Sub delete()
        If IsDefaultTopic(Me.curr_row(Constants_HaoLT.TOPIC_GROUP_NAME).ToString, Me.curr_row(Constants_HaoLT.TOPIC_NAME).ToString) Then
            MessageBox.Show(Constants_PhatLS.STR_MSG_ERR_022)
        Else
            If (MessageBox.Show(Constants_PhatLS.STR_MSG_INFO_012, Constants_HaoLT.CAPTION_MESS, MessageBoxButtons.YesNo) = MsgBoxResult.Yes) Then
                If (MessageBox.Show(Constants_HaoLT.STR_MSG_ERR_023, Constants_HaoLT.CAPTION_MESS, MessageBoxButtons.YesNo) = MsgBoxResult.Yes) Then
                    
                    topic.DeleteTopicMoveVOC(Me.topicentry)
                    table.Rows.Remove(Me.curr_row)
                Else
                    topic.DeleteTopicVOC(Me.topicentry)
                    table.Rows.Remove(Me.curr_row)
                End If
                MessageBox.Show(Constants_PhatLS.STR_MSG_INFO_013, "Topic Deleted")
                frmMainForm.DeleteTopicNote(cboTopicGroup.Text, txtTopicName.Text)
                Try
                    Dim usrVoc As usrVocabularies = frmMainForm.panContain.Controls.Item(Constants_LanhVC.STR_USR_VOCABULARIES)
                    usrVoc.UpdateTopic(txtTopicName.Text)
                Catch ex As Exception

                End Try
                
            End If
        End If
    End Sub
    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        delete()
        Me.txtTopicName.Text = Constants_HaoLT.NULLSTRING
        Me.txtTopicDescription.Text = Constants_HaoLT.NULLSTRING
        Me.curr_row = Nothing
        Me.topicentry = Nothing
        Me.cmdDelete.Enabled = False
        Me.cmdUpdate.Enabled = False
    End Sub

    Private Sub cmdUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        'LanhVC - start
        Dim strOldTopic As String

        'init
        strOldTopic = Constants_LanhVC.STR_BLANK_VALUE
        'LanhVC - end 
        Try
            If IsDefaultTopic(Me.curr_row(Constants_HaoLT.TOPIC_GROUP_NAME).ToString, Me.curr_row(Constants_HaoLT.TOPIC_NAME).ToString) Then
                MessageBox.Show(Constants_PhatLS.STR_MSG_ERR_021)
            Else
                Dim row As Data.DataRow = table.NewRow()
                Dim row_Group As Data.DataRowView = Me.cboTopicGroup.SelectedItem
                row(Constants_HaoLT.TOPIC_GROUP_ID) = row_Group.Row.Item(Constants_HaoLT.TOPIC_GROUP_ID)
                row.Item(Constants_HaoLT.TOPIC_NAME) = Me.txtTopicName.Text
                'db can be null
                If (Me.txtTopicDescription.Text = Nothing) Then
                    Me.txtTopicDescription.Text = Constants_HaoLT.BLANK
                End If
                row(Constants_HaoLT.TOPIC_DESCRIPTION) = Me.txtTopicDescription.Text
                row(Constants_HaoLT.TOPIC_GROUP_NAME) = Me.cboTopicGroup.Text
                If (topic.is_DupcateTopic(table, row)) Then
                    MessageBox.Show(Constants_PhatLS.STR_MSG_ERR_002)
                Else

                    If (Not row.Equals(Me.curr_row)) Then
                        topicentry = New TopicsEntity()
                        Me.topicentry.TopicID = Me.curr_row.Item(Constants_HaoLT.TOPIC_ID)
                        Me.topicentry.TopicName = row.Item(Constants_HaoLT.TOPIC_NAME)
                        Me.topicentry.TopicDescription = row.Item(Constants_HaoLT.TOPIC_DESCRIPTION)
                        Me.topicentry.TopicGroupID = row.Item(Constants_HaoLT.TOPIC_GROUP_ID)
                        Me.topicentry.TopicGroupName = row.Item(Constants_HaoLT.TOPIC_GROUP_NAME)
                        topic.UpdateTopic(Me.topicentry)
                        MessageBox.Show(Constants_PhatLS.STR_MSG_INFO_002, "Topic Updated")
                        'MessageBox.Show(Constants_PhatLS.STR_MSG_ERR_002)

                        'GiangNVT modified
                        strOldTopic = table.Rows.Item(table.Rows.IndexOf(Me.curr_row)).Item(Constants_HaoLT.TOPIC_NAME)
                        Dim strOldTopicGroup As String = table.Rows.Item(table.Rows.IndexOf(Me.curr_row)).Item(Constants_HaoLT.TOPIC_GROUP_NAME)

                        frmMainForm.UpdateTopicToTree(strOldTopicGroup, cboTopicGroup.Text, strOldTopic, txtTopicName.Text)

                        table.Rows.Item(table.Rows.IndexOf(Me.curr_row)).BeginEdit()
                        table.Rows.Item(table.Rows.IndexOf(Me.curr_row)).Item(Constants_HaoLT.TOPIC_NAME) = row.Item(Constants_HaoLT.TOPIC_NAME)
                        table.Rows.Item(table.Rows.IndexOf(Me.curr_row)).Item(Constants_HaoLT.TOPIC_DESCRIPTION) = row.Item(Constants_HaoLT.TOPIC_DESCRIPTION)
                        table.Rows.Item(table.Rows.IndexOf(Me.curr_row)).Item(Constants_HaoLT.TOPIC_GROUP_NAME) = row.Item(Constants_HaoLT.TOPIC_GROUP_NAME)
                        table.Rows.Item(table.Rows.IndexOf(Me.curr_row)).Item(Constants_HaoLT.TOPIC_GROUP_ID) = row.Item(Constants_HaoLT.TOPIC_GROUP_ID)
                        table.Rows.Item(table.Rows.IndexOf(Me.curr_row)).EndEdit()

                        'LanhVC - start
                        'frmMainForm.UpdateTopicToTree(cboTopicGroup.Text, strOldTopic, txtTopicName.Text)
                        Dim usrVoc As usrVocabularies = frmMainForm.panContain.Controls.Item(Constants_LanhVC.STR_USR_VOCABULARIES)
                        usrVoc.UpdateTopic(txtTopicName.Text)
                    End If
                End If
            End If

            'LanhVC- end
        Catch ex As Exception
            'Do nothing
        Finally
            Me.curr_row = Nothing
            Me.topicentry = Nothing
            Me.cmdDelete.Enabled = False
            Me.cmdUpdate.Enabled = False
        End Try

    End Sub
    Public Function IsDefaultTopic(ByVal pTopicGroup As String, ByVal pTopicName As String) As Boolean
        Dim isDefault As Boolean = False
        If Constants_HaoLT.DEFAULT_TOPICNAME = pTopicName Then
            isDefault = True
        End If
        Return isDefault
    End Function

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If (Not Me.topicentry Is Nothing) Then
            Dim objUsrTopic As usrVocabularies
            objUsrTopic = New usrVocabularies(Me.topicentry.TopicGroupName, Me.topicentry.TopicName, Utils.ModeUpdate.Add)
            objUsrTopic.Dock = DockStyle.Fill
            frmMainForm.panContain.Controls.Add(objUsrTopic)
            Me.SendToBack()
        End If
    End Sub
    Private Sub setLink()
        If (Me.topicentry Is Nothing) Then
            Me.LinkLabel1.Enabled = False
        Else
            Me.LinkLabel1.Enabled = True
        End If
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class

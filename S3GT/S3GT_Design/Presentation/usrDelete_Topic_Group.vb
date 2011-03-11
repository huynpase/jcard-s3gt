Public Class usrDelete_Topic_Group
    Const FILTER_BY_TOPIC_GROUP_NAME As String = "Topic_Group_Name = '{0}'"

    Dim objTopicGroupsBO As New TopicGroupsBO
    Dim objTopicGroupsEntity As New TopicGroupsEntity
    Public id_topicgroup As Integer
    Dim tableTopicGroups As DataTable
    Private Sub usrDelete_Topic_Group_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '////////////////////////////////////
        tableTopicGroups = objTopicGroupsBO.GetTopicGroupsTable
        DataGridView_Add_TG.DataSource = tableTopicGroups
        DataGridView_Add_TG.Columns(0).Visible = False
        DataGridView_Add_TG.Visible() = True

        'QuanTDA's code
        'If a topic group name is passed in,
        'then retrieve the corresponding topic group and set it as defaultly selected topic group
        If Not objTopicGroupsEntity Is Nothing AndAlso Not Constants_LanhVC.STR_BLANK_VALUE.Equals(objTopicGroupsEntity.TopicGroupName) Then
            Dim selectedTopicGroupRows As DataRow()
            'because the Topic Group Name is unique in the table of Topic Groups
            'use the first row returned as the desired Topic Group
            Dim strFilter As String
            strFilter = String.Format(FILTER_BY_TOPIC_GROUP_NAME, objTopicGroupsEntity.TopicGroupName)
            selectedTopicGroupRows = tableTopicGroups.Select(strFilter)
            If selectedTopicGroupRows.Length > 0 Then
                Dim rowTopicGroup As DataRow
                rowTopicGroup = selectedTopicGroupRows(0)
                objTopicGroupsEntity.TopicGroupID = rowTopicGroup("Topic_Group_ID")
                objTopicGroupsEntity.TopicGroupName = rowTopicGroup("Topic_Group_Name")
                objTopicGroupsEntity.TopicGroupDescription = rowTopicGroup("Topic_Group_Description")
                For Each row As DataGridViewRow In DataGridView_Add_TG.Rows
                    If objTopicGroupsEntity.TopicGroupName.Equals(row.Cells(1).Value.ToString) Then
                        DataGridView_Add_TG.CurrentCell = row.Cells(1)
                        Exit For
                    End If
                Next
                'DataGridView_Add_TG.CurrentCell = DataGridView_Add_TG.Rows(2).Cells(1)
            End If
        End If
    End Sub
    Public Function Reset()
        tableTopicGroups = objTopicGroupsBO.GetTopicGroupsTable
        DataGridView_Add_TG.DataSource = tableTopicGroups
        DataGridView_Add_TG.Columns(0).Visible = False
        DataGridView_Add_TG.Visible() = True
        Return 0
    End Function
    Private Sub Button_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Delete.Click
        Dim strThong_bao As String = "You must select a Topic Group"

        If Constants_LanhVC.STR_BLANK_VALUE.Equals(objTopicGroupsEntity.TopicGroupName) Then
            MessageBox.Show(strThong_bao, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Constants_HaoLT.DEFAULT_TOPICGROUP_NAME.Equals(objTopicGroupsEntity.TopicGroupName) Then
            strThong_bao = Constants_PhatLS.STR_MSG_ERR_022
            MessageBox.Show(strThong_bao, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            strThong_bao = "Are you sure you want to delete a Topic Group?"
            If (MessageBox.Show(strThong_bao, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                Try
                    objTopicGroupsBO.DeleteTopicGroup(objTopicGroupsEntity)
                    strThong_bao = "A Topic Group has been deleted."
                    MessageBox.Show(strThong_bao, "Message!")
                    Reset()
                    frmMainForm.LoadDataToTree()
                Catch ex As Exception
                    strThong_bao = Constants_LanhVC.STR_MSG_TOPIC_GROUP_HAS_CHILD
                    If (MessageBox.Show(strThong_bao, "Message!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                        Dim dlgDelTopic_Voc As New dlgDeleteTopic_Vocabulary(objTopicGroupsEntity.TopicGroupID, objTopicGroupsEntity.TopicGroupName)
                        dlgDelTopic_Voc.ShowDialog()
                        Reset()
                        If dlgDelTopic_Voc.HasDeletedSuccessfully Then
                            frmMainForm.LoadDataToTree()
                        End If
                    Else
                        'MessageBox.Show("Xu ly khong xoa")
                        Reset()
                    End If
                End Try
            End If
        End If

    End Sub
    Private Sub Button_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Cancel.Click
        'QuanTDA code
        frmMainForm.panContain.Controls.Remove(Me)
        Me.Dispose()
        'End QuanTDA code
    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        objTopicGroupsEntity = New TopicGroupsEntity
        objTopicGroupsEntity.TopicGroupName = Constants_HaoLT.DEFAULT_TOPICGROUP_NAME
        DataGridView_Add_TG.CurrentCell = DataGridView_Add_TG.Rows(0).Cells(1)
    End Sub
    Public Sub New(ByVal pTopicGroupName As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ' Add any initialization after the InitializeComponent() call.
        objTopicGroupsEntity = New TopicGroupsEntity
        'set the topic group name passed in as default selected topic group
        If Not Constants_LanhVC.STR_BLANK_VALUE.Equals(pTopicGroupName) Then
            objTopicGroupsEntity.TopicGroupName = pTopicGroupName
        Else
            objTopicGroupsEntity.TopicGroupName = Constants_HaoLT.DEFAULT_TOPICGROUP_NAME
        End If

    End Sub
    Public Shared Sub DeleteTopicGroupFromTree(ByVal pTopicGroupName As String)
        Dim strThong_bao As String
        Try
            Dim deletedTopicGroupEntity As TopicGroupsEntity
            Dim deleteTopicGroupBO As New TopicGroupsBO
            Dim deleteTopicGroupTable As DataTable = deleteTopicGroupBO.GetTopicGroupsTable()
            Dim selectedTopicGroupRows As DataRow()
            'because the Topic Group Name is unique in the table of Topic Groups
            'use the first row returned as the desired Topic Group
            Dim strFilter As String
            strFilter = String.Format(FILTER_BY_TOPIC_GROUP_NAME, pTopicGroupName)
            selectedTopicGroupRows = deleteTopicGroupTable.Select(strFilter)
            deletedTopicGroupEntity = Nothing

            If selectedTopicGroupRows.Length > 0 Then
                Dim rowTopicGroup As DataRow
                rowTopicGroup = selectedTopicGroupRows(0)
                deletedTopicGroupEntity = New TopicGroupsEntity
                deletedTopicGroupEntity.TopicGroupID = rowTopicGroup("Topic_Group_ID")
                deletedTopicGroupEntity.TopicGroupName = rowTopicGroup("Topic_Group_Name")
                deletedTopicGroupEntity.TopicGroupDescription = rowTopicGroup("Topic_Group_Description")
            End If
            If deletedTopicGroupEntity Is Nothing Then
                Throw New Exception
            ElseIf Constants_HaoLT.DEFAULT_TOPICGROUP_NAME.Equals(deletedTopicGroupEntity.TopicGroupName) _
                   Or Constants_HaoLT.DEFAULT_TOPICGROUP_ID = deletedTopicGroupEntity.TopicGroupID Then
                strThong_bao = Constants_PhatLS.STR_MSG_ERR_022
                MessageBox.Show(strThong_bao, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Throw New Exception
            Else
                strThong_bao = "Are you sure want to delete Topic Group?"
                If (MessageBox.Show(strThong_bao, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                    Try
                        deleteTopicGroupBO.DeleteTopicGroup(deletedTopicGroupEntity)
                        strThong_bao = "A Topic Group has been deleted."
                        MessageBox.Show(strThong_bao, "Message!")
                    Catch ex As Exception
                        strThong_bao = Constants_LanhVC.STR_MSG_TOPIC_GROUP_HAS_CHILD
                        If (MessageBox.Show(strThong_bao, "Message!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                            'Dim id_topicgroup As Integer = deletedTopicGroupEntity.TopicGroupID
                            Dim dlgDelTopic_Voc As New dlgDeleteTopic_Vocabulary(deletedTopicGroupEntity.TopicGroupID, deletedTopicGroupEntity.TopicGroupName)
                            dlgDelTopic_Voc.ShowDialog()
                            If Not dlgDelTopic_Voc.HasDeletedSuccessfully Then
                                Throw New Exception
                            End If
                        Else
                            Throw New Exception
                        End If
                    End Try
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Private Sub DataGridView_Add_TG_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView_Add_TG.CellClick
        'MessageBox.Show(e.RowIndex.ToString)
        If e.ColumnIndex = 1 And e.RowIndex > -1 And e.RowIndex < DataGridView_Add_TG.Rows.Count - 1 Then
            objTopicGroupsEntity.TopicGroupID = DataGridView_Add_TG.Item(e.ColumnIndex - 1, e.RowIndex).Value.ToString
            objTopicGroupsEntity.TopicGroupName = DataGridView_Add_TG.Item(e.ColumnIndex, e.RowIndex).Value.ToString
            objTopicGroupsEntity.TopicGroupDescription = DataGridView_Add_TG.Item(e.ColumnIndex + 1, e.RowIndex).Value.ToString
        Else
            If (e.ColumnIndex > 1 And e.RowIndex > -1 And e.RowIndex < DataGridView_Add_TG.Rows.Count - 1) Then
                objTopicGroupsEntity.TopicGroupID = DataGridView_Add_TG.Item(e.ColumnIndex - 2, e.RowIndex).Value.ToString
                objTopicGroupsEntity.TopicGroupName = DataGridView_Add_TG.Item(e.ColumnIndex - 1, e.RowIndex).Value.ToString
                objTopicGroupsEntity.TopicGroupDescription = DataGridView_Add_TG.Item(e.ColumnIndex, e.RowIndex).Value.ToString
            Else
                MessageBox.Show(" Please select Rows have data", "Message!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub


    ' Private Sub DataGridView_Add_TG_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView_Add_TG.CellMouseClick
    '    MessageBox.Show("cell click")
    'End Sub
End Class

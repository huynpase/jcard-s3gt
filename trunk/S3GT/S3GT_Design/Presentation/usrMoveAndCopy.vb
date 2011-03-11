Public Class usrMoveAndCopy
    Dim objTopicGroupBO As TopicGroupsBO
    Dim objTopicGroupTable As DataTable
    Dim objTopicBO As TopicsBO
    Dim objTopicTable As DataTable
    Public Sub FillDataToTopicControl(ByVal strTopicGroupName As String)
        
        Dim i As Integer

        'init
        cboTopicName.Items.Clear()
        objTopicBO = New TopicsBO()
        objTopicTable = Nothing

        objTopicTable = objTopicBO.GetTopicListByTopicGroupName(strTopicGroupName)

        For i = 0 To objTopicTable.Rows.Count - 1
            cboTopicName.Items.Add(objTopicTable.Rows(i)(Constants_LanhVC.STR_TPC_COLUMN_NAME_TOPIC_NAME).ToString())
        Next
    End Sub

    Public Sub SetTopicGroupValue(ByVal arrValue As ArrayList)
        Dim i As Int16
        For i = 0 To arrValue.Count - 1
            cboTopicGroupName.Items.Add(arrValue.Item(i))
        Next
    End Sub
    Public Sub SetTopicValue(ByVal arrValue As ArrayList)
        Dim i As Int16
        For i = 0 To arrValue.Count - 1
            cboTopicName.Items.Add(arrValue.Item(i))
        Next
    End Sub

    Public Sub New(ByVal dataSourceVocabulary As DataGridViewRowCollection, ByVal strTopicGroup As String, _
    ByVal strTopicName As String)
        Dim i As Integer
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        FillDataToTopicGroupControl()

        cboTopicGroupName.Text = strTopicGroup

        FillDataToTopicControl(strTopicGroup)
        cboTopicName.Text = strTopicName

        'dataSourceVocabulary.Clear()
        For i = 0 To dataSourceVocabulary.Count - 1
            If dataSourceVocabulary.Item(i).Cells(0).Value = True Then


                'dataVocabulary.Rows.Add(dataSourceVocabulary.Item(i).Cells(0).Value, _
                dataVocabulary.Rows.Add(True, _
                                    dataSourceVocabulary.Item(i).Cells(1).Value, _
                                    dataSourceVocabulary.Item(i).Cells(2).Value, _
                                    dataSourceVocabulary.Item(i).Cells(3).Value, _
                                    dataSourceVocabulary.Item(i).Cells(4).Value, _
                                    dataSourceVocabulary.Item(i).Cells(5).Value, _
                                    dataSourceVocabulary.Item(i).Cells(6).Value, _
                                    dataSourceVocabulary.Item(i).Cells(7).Value)
            End If
        Next
    End Sub

    Public Function GetSameVocabulary()
        Dim arrSameVocabulary As New ArrayList
        Dim i, j As Int32

        For i = 0 To dataVocabulary.RowCount - 1
            For j = i + 1 To dataVocabulary.RowCount - 2
                If dataVocabulary.Item(1, i).Value = dataVocabulary.Item(1, j).Value Then
                    arrSameVocabulary.Add(i)
                    arrSameVocabulary.Add(j)
                End If
            Next
        Next

        Return arrSameVocabulary
    End Function

    Private Sub btnMove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMove.Click
        'Dim arrSameVocabulary As ArrayList
        'Dim i As Int32

        'arrSameVocabulary = GetSameVocabulary()
        ''if have Same vocabulary
        'If arrSameVocabulary.Count > 0 Then

        '    'set text color is red
        '    'For i = 0 To arrSameVocabulary.Count - 1
        '    '    dataVocabulary.Rows(arrSameVocabulary.Item(i)).DefaultCellStyle.ForeColor = Color.Red

        '    '    dataSourceSameVocabulary = dataVocabulary.Rows
        '    '    MessageBox.Show(dataVocabulary.Rows(0).Cells(1).Value)
        '    'Next               


        'Else
        '    MessageBox.Show("Moved")
        'End If
        Dim objVocEntity As VocabulariesEntity
        Dim objVocBO As VocabulariesBO
        Dim objTopicBO As TopicsBO
        Dim i As Integer
        Dim objVocTable As DataTable
        Dim dlgSameVocabulary As dlgSameVocabulary

        'init
        objVocEntity = Nothing
        objVocBO = Nothing

        If cboTopicName.Text = "" Or cboTopicGroupName.Text = "" Then
            MessageBox.Show(Constants_LanhVC.STR_MSG_ERR_007)

        ElseIf dataVocabulary.RowCount = 1 And dataVocabulary.AllowUserToAddRows = True Then
            MessageBox.Show(Constants_LanhVC.STR_MSG_ERR_001)

        Else
            objVocEntity = New VocabulariesEntity()
            objVocBO = New VocabulariesBO()
            objTopicBO = New TopicsBO()

            For i = 0 To dataVocabulary.Rows.Count - 1
                If dataVocabulary.Rows(i).Cells(0).Value = True Then
                    objVocEntity = objVocBO.CopyDataToEntityFromDataGrid(dataVocabulary, i)
                    'get TopicID
                    'objVocEntity.TopicID = 2 'example
                    objVocEntity.TopicID = objTopicBO.GetTopicID(cboTopicGroupName.Text, cboTopicName.Text)
                    objVocTable = objVocBO.CheckExist(objVocEntity.Hiragana, objVocEntity.Kanji, objVocEntity.TopicID)
                    If objVocTable.Rows.Count > 0 Then
                        dlgSameVocabulary = New dlgSameVocabulary(dataVocabulary.Rows, i, objVocTable)
                        dlgSameVocabulary.TopicName = cboTopicName.Text
                        dlgSameVocabulary.TopicGroupName = cboTopicGroupName.Text
                        If dlgSameVocabulary.ShowDialog() <> Constants_LanhVC.INT_SKIP Then
                            objVocBO.DeleteVocabulary(objVocEntity)
                        End If
                    Else 'Move thuong thoi
                        objVocBO.UpdateVocabulary(objVocEntity)
                    End If

                End If
            Next
            Dim dataVoc As usrVocabularies = frmMainForm.panContain.Controls.Item(Constants_LanhVC.STR_USR_VOCABULARIES)
            dataVoc.UpdateDataGrid()

            Me.ParentForm.Close()

            MessageBox.Show(Constants_LanhVC.STR_MSG_INFO_007, Constants_LanhVC.STR_MESS_TYPE_WARRING, MessageBoxButtons.OK)
        End If

    End Sub

    Private Sub cmbTopicGroupName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTopicGroupName.SelectedIndexChanged
        FillDataToTopicControl(cboTopicGroupName.Text)
    End Sub

    Private Sub btnCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopy.Click
        'Dim arrSameVocabulary As ArrayList
        'Dim i As Int32

        'arrSameVocabulary = GetSameVocabulary()
        ''if have Same vocabulary
        'If arrSameVocabulary.Count > 0 Then

        '    'set text color is red
        '    For i = 0 To arrSameVocabulary.Count - 1
        '        dataVocabulary.Rows(arrSameVocabulary.Item(i)).DefaultCellStyle.ForeColor = Color.Red

        '        'dataSourceSameVocabulary = dataVocabulary.Rows
        '        'MessageBox.Show(dataVocabulary.Rows(0).Cells(1).Value)
        '    Next

        '    'Show message box
        '    'Dim dlgSameVocabulary As New dlgSameVocabulary(dataVocabulary.Rows)
        '    'Select Case dlgSameVocabulary.ShowDialog()
        '    '    Case Constants_LanhVC.INT_OVERRIDE
        '    '        MessageBox.Show("Selete Override")
        '    '    Case Constants_LanhVC.INT_MERGE_KANJI
        '    '        MessageBox.Show("Selete Merge Kanji")
        '    '    Case Constants_LanhVC.INT_MERGE_MEANING
        '    '        MessageBox.Show("Selete Merge Meaning")
        '    '    Case Constants_LanhVC.INT_CREATE_NEW
        '    '        MessageBox.Show("Selete Create New")
        '    '    Case Constants_LanhVC.INT_SKIP
        '    '        MessageBox.Show("Selete Skip")

        '    'End Select

        'Else
        '    MessageBox.Show("Copied")
        'End If

        Dim objVocEntity As VocabulariesEntity
        Dim objVocBO As VocabulariesBO
        Dim objTopicBO As TopicsBO
        Dim i As Integer
        Dim objVocTable As DataTable
        Dim dlgSameVocabulary As dlgSameVocabulary

        'init
        objVocEntity = Nothing
        objVocBO = Nothing

        If cboTopicGroupName.Text = Constants_LanhVC.STR_BLANK_VALUE Then
            MessageBox.Show(Constants_LanhVC.STR_MSG_ERR_007, Constants_LanhVC.STR_MESS_TYPE_WARRING, MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf cboTopicName.Text = Constants_LanhVC.STR_BLANK_VALUE Then
            MessageBox.Show(Constants_LanhVC.STR_MSG_ERR_001, Constants_LanhVC.STR_MESS_TYPE_WARRING, MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf dataVocabulary.RowCount = 1 And dataVocabulary.AllowUserToAddRows = True Then
            MessageBox.Show(Constants_LanhVC.STR_MSG_ERR_001, Constants_LanhVC.STR_MESS_TYPE_WARRING, MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            objVocEntity = New VocabulariesEntity()
            objVocBO = New VocabulariesBO()
            objTopicBO = New TopicsBO()

            For i = 0 To dataVocabulary.Rows.Count - 1
                If dataVocabulary.Rows(i).Cells(0).Value = True Then
                    objVocEntity = objVocBO.CopyDataToEntityFromDataGrid(dataVocabulary, i)
                    'get TopicID
                    'objVocEntity.TopicID = 2 'example
                    objVocEntity.TopicID = objTopicBO.GetTopicID(cboTopicGroupName.Text, cboTopicName.Text)
                    objVocTable = objVocBO.CheckExist(objVocEntity.Hiragana, objVocEntity.Kanji, objVocEntity.TopicID)
                    If objVocTable.Rows.Count > 0 Then
                        dlgSameVocabulary = New dlgSameVocabulary(dataVocabulary.Rows, i, objVocTable)
                        dlgSameVocabulary.TopicName = cboTopicName.Text
                        dlgSameVocabulary.TopicGroupName = cboTopicGroupName.Text
                        dlgSameVocabulary.ShowDialog()

                        'objVocBO.DeleteVocabulary(objVocEntity)
                    Else 'Move thuong thoi
                        'objVocBO.UpdateVocabulary(objVocEntity)
                        objVocBO.AddNew(objVocEntity)
                    End If

                End If
            Next
            MessageBox.Show(Constants_LanhVC.STR_MSG_INFO_007, Constants_LanhVC.STR_MESS_TYPE_WARRING, MessageBoxButtons.OK)
            Me.ParentForm.Close()
        End If
    End Sub

    Private Sub lnkCreateTopic_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkCreateTopic.LinkClicked
        Dim dlgCreateTopic As New dlgCreateTopic(cboTopicGroupName.Text)
        dlgCreateTopic.ShowDialog()
        'reload Topic Groups and Topics list
        FillDataToTopicGroupControl()
        'FillDataToTopicControl()
        'display the newest Topic and Topic Group
        'retrieve the Topic Group ID of the newest Topic in table
        Dim intTopicGroupID As Integer
        objTopicTable = objTopicBO.GetTopicsTable
        intTopicGroupID = CInt(objTopicTable.Rows(objTopicTable.Rows.Count - 1)(Constants_LanhVC.STR_TPC_COLUMN_NAME_TOPIC_GROUP_ID).ToString)
        Dim strTopicGroupName As String = objTopicGroupBO.GetTopicGroupByID(intTopicGroupID).TopicGroupName
        Dim strTopicName As String = Utils.ObjectToString(objTopicTable.Rows(objTopicTable.Rows.Count - 1)(Constants_LanhVC.STR_TPC_COLUMN_NAME_TOPIC_NAME))
        cboTopicGroupName.Text = strTopicGroupName
        'retrieve the newest Topic's ID
        cboTopicName.Text = strTopicName
    End Sub
    Public Sub FillDataToTopicGroupControl()
        ' Add any initialization after the InitializeComponent() call.
        'fill data top combobox

        Dim i As Integer
        Dim strTopicGroupName As String

        'init
        objTopicGroupBO = New TopicGroupsBO()
        objTopicGroupTable = Nothing
        strTopicGroupName = Constants_LanhVC.STR_BLANK_VALUE

        objTopicGroupTable = objTopicGroupBO.GetTopicGroupsTable()
        For i = 0 To objTopicGroupTable.Rows.Count - 1
            strTopicGroupName = objTopicGroupTable.Rows(i)(Constants_LanhVC.STR_TPG_COLUMN_NAME_TOPIC_GROUP_NAME).ToString()
            cboTopicGroupName.Items.Add(strTopicGroupName)
        Next
    End Sub
End Class

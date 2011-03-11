Public Class usrSearchVocabularies
    Dim ToolTipWasShown As Boolean
    Dim WhenShownToolTip As Int16
    Dim TopicIDisSet As Int32
    Dim searchToolTip As ToolTip
    Dim sCellValue As String
    Dim strType
    'Code for datagrid
    Dim TableName As String
    'End

    ''' <summary>
    ''' Set value for Topic value into combobox
    ''' </summary>
    ''' <param name="arrValue">array topic name</param>
    ''' <remarks></remarks>
    Public Sub SetTopicValue(ByVal arrValue As ArrayList)
        Dim i As Int16
        For i = 0 To arrValue.Count - 1
            cboTopicName.Items.Add(arrValue.Item(i))
        Next
    End Sub

    ''' <summary>
    ''' Set text for topic group combobox 
    ''' </summary>
    ''' <param name="value">value of topic group</param>
    ''' <remarks></remarks>
    Public Sub SetTextTopicGroupControl(ByVal value As String)
        cboTopicGroupName.Text = value
        FillDataToTopicControl(cboTopicGroupName.Text)
    End Sub

    Public Sub SetTextTopicControl(ByVal value As String)
        cboTopicName.Text = value
    End Sub

    Public Sub FillDataToTopicControl(ByVal strTopicGroupName As String)
        Dim objTopicBO As TopicsBO
        Dim objTopicTable As DataTable
        Dim i As Integer

        'init
        cboTopicName.Items.Clear()
        objTopicBO = New TopicsBO()
        objTopicTable = Nothing

        objTopicTable = objTopicBO.GetTopicListByTopicGroupName(strTopicGroupName)
        cboTopicName.Items.Add("")
        For i = 0 To objTopicTable.Rows.Count - 1
            cboTopicName.Items.Add(objTopicTable.Rows(i)(Constants_LanhVC.STR_TPC_COLUMN_NAME_TOPIC_NAME).ToString())
            TopicIDisSet = objTopicTable.Rows(i)(Constants_LanhVC.STR_TPC_COLUMN_NAME_TOPIC_GROUP_ID)
        Next
    End Sub
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        btnSearch.Enabled() = False
        TopicIDisSet = 0
        WhenShownToolTip = 0
        ToolTipWasShown = False

        ' Add any initialization after the InitializeComponent() call.
        Dim objTopicGroupBO As TopicGroupsBO
        Dim objTopicGroupTable As DataTable
        Dim i As Integer
        Dim strTopicGroupName As String
        'init
        objTopicGroupBO = New TopicGroupsBO()
        objTopicGroupTable = Nothing
        strTopicGroupName = Constants_LanhVC.STR_BLANK_VALUE

        objTopicGroupTable = objTopicGroupBO.GetTopicGroupsTable()
        cboTopicGroupName.Items.Add("All group")
        For i = 0 To objTopicGroupTable.Rows.Count - 1
            strTopicGroupName = objTopicGroupTable.Rows(i)(Constants_LanhVC.STR_TPG_COLUMN_NAME_TOPIC_GROUP_NAME).ToString()
            cboTopicGroupName.Items.Add(strTopicGroupName)
        Next

        searchToolTip = New ToolTip()
        searchToolTip.ReshowDelay = 300
        searchToolTip.InitialDelay = 300
    End Sub
    Private Sub cboTopicGroupName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTopicGroupName.SelectedIndexChanged
        cboTopicName.Text = "All topic"
        TopicIDisSet = 0
        FillDataToTopicControl(cboTopicGroupName.Text)
    End Sub
    Private Sub txtInputKeyword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtInputKeyword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSearch_Click(sender, e)
        End If
    End Sub

    Private Sub txtInputKeyword_TextChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInputKeyword.TextChanged
        If Not (txtInputKeyword.Text = "") Then
            btnSearch.Enabled() = True
        Else
            btnSearch.Enabled() = False
        End If
    End Sub
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim SearchVocBO As SearchVocBO
        Dim objVocTable As DataTable
        Dim i As Int32
        strType = Constants_LanhVC.STR_TYPE_VIEW
        'Code for datagrid1
        dataVocabulary.ResetText()
        SearchVocBO = New SearchVocBO()
        objVocTable = New DataTable()
        objVocTable = SearchVocBO.SearchVocabulary(cboSearchBy.Text, cmbSourceForm.Text, TopicIDisSet, txtInputKeyword.Text, cboTopicName.Text)
        TableName = objVocTable.TableName
        dataVocabulary.Rows.Clear()
        'End cdoe for datagrid1
        For i = 0 To objVocTable.Rows.Count - 1
            'copy data from table to datagrid
            dataVocabulary.Rows.Add()
            dataVocabulary.Rows(i).Cells(0).Value = Constants_LanhVC.STR_CHK_UNCHECK
            dataVocabulary.Rows(i).Cells(Constants_LanhVC.INT_VOC_SEARCH_COLUMN_TOPICGROUPNAME).Value = objVocTable.Rows(i)(Constants_LanhVC.INT_VOC_DB_SEARCH_COLUMN_TOPICGROUPNAME)
            dataVocabulary.Rows(i).Cells(Constants_LanhVC.INT_VOC_SEARCH_COLUMN_TOPICNAME).Value = objVocTable.Rows(i)(Constants_LanhVC.INT_VOC_DB_SEARCH_COLUMN_TOPICNAME)
            dataVocabulary.Rows(i).Cells(Constants_LanhVC.INT_VOC_SEARCH_COLUMN_KANJI).Value = objVocTable.Rows(i)(Constants_LanhVC.INT_VOC_DB_SEARCH_COLUMN_KANJI)
            dataVocabulary.Rows(i).Cells(Constants_LanhVC.INT_VOC_SEARCH_COLUMN_HIGARANA).Value = objVocTable.Rows(i)(Constants_LanhVC.INT_VOC_DB_SEARCH_COLUMN_HIGARANA)
            dataVocabulary.Rows(i).Cells(Constants_LanhVC.INT_VOC_SEARCH_COLUMN_HANNOM).Value = objVocTable.Rows(i)(Constants_LanhVC.INT_VOC_DB_SEARCH_COLUMN_HANNOM)
            dataVocabulary.Rows(i).Cells(Constants_LanhVC.INT_VOC_SEARCH_COLUMN_MEANING).Value = objVocTable.Rows(i)(Constants_LanhVC.INT_VOC_DB_SEARCH_COLUMN_MEANING)
            dataVocabulary.Rows(i).Cells(Constants_LanhVC.INT_VOC_SEARCH_COLUMN_TYPE).Value = Utils.GetType_TextFromInt(objVocTable.Rows(i)(Constants_LanhVC.INT_VOC_DB_SEARCH_COLUMN_TYPE))
            dataVocabulary.Rows(i).Cells(Constants_LanhVC.INT_VOC_SEARCH_COLUMN_VOCID).Value = objVocTable.Rows(i)(Constants_LanhVC.INT_VOC_DB_SEARCH_COLUMN_VOCID)
            dataVocabulary.Rows(i).Cells(Constants_LanhVC.INT_VOC_SEARCH_COLUMN_EXAMPLE).Value = objVocTable.Rows(i)(Constants_LanhVC.INT_VOC_DB_SEARCH_COLUMN_EXAMPLE)
            dataVocabulary.Rows(i).Cells(Constants_LanhVC.INT_VOC_SEARCH_COLUMN_TOPICID).Value = objVocTable.Rows(i)(Constants_LanhVC.INT_VOC_DB_SEARCH_COLUMN_TOPICID)
            dataVocabulary.Rows(i).Cells("modified").Value = False
        Next
        btnSubmit.Enabled = False
    End Sub


    Private Sub usrSearchVoc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtInputKeyword.Focus()
    End Sub


    Private Sub dataGrid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.MouseEventArgs)
        'Set time to show ToolTip
        If ToolTipWasShown = True And Not WhenShownToolTip = 100 Then
            WhenShownToolTip = WhenShownToolTip + 1
            Return
        Else
            ToolTipWasShown = False
            WhenShownToolTip = 0
        End If

        searchToolTip.InitializeLifetimeService()
        searchToolTip.SetToolTip(dataVocabulary, Constants_PhatLS.STR_MSG_TOOLTIP)
        ToolTipWasShown = True
    End Sub

    Private Sub cmbSourceForm_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSourceForm.SelectedIndexChanged

    End Sub

    'code for datavacabulary - add by Minhln2
    Private Sub dataVocabulary_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataVocabulary.CellClick
        dataVocabulary.BeginEdit(True)
        If e.ColumnIndex = Constants_LanhVC.INT_VOC_COLUMN_TYPE Then 'if the column in action is the Type column
            SendKeys.SendWait("{F4}") 'expand the list of Type for selection
        End If
    End Sub

    Private Sub dataVocabulary_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataVocabulary.CellContentClick
        Dim i As Int32

        Try
            ' if it's Checkbox column
            If e.ColumnIndex = 0 And (strType = Constants_LanhVC.STR_TYPE_UPDATE Or strType = Constants_LanhVC.STR_TYPE_VIEW) Then
                'set checkbox is change before check
                Try
                    dataVocabulary.Rows(e.RowIndex).Cells(0).Value = Not dataVocabulary.Rows(e.RowIndex).Cells(0).Value
                    If dataVocabulary.Rows(e.RowIndex).Cells(0).Value = Constants_LanhVC.STR_CHK_CHECK Then
                        btnDelete.Enabled = True
                        'btnMoveAndCopy.Enabled = True
                        Return
                    End If

                    For i = 0 To dataVocabulary.RowCount - 1

                        If dataVocabulary.Rows(i).Cells(0).Value = Constants_LanhVC.STR_CHK_CHECK Then
                            btnDelete.Enabled = True
                            'btnMoveAndCopy.Enabled = True

                            Return
                        End If
                    Next

                    btnDelete.Enabled = False
                    'btnMoveAndCopy.Enabled = False

                Catch ex As Exception
                    MessageBox.Show(ex.ToString())
                End Try
                'set checkbox like old value
                'dataVocabulary.Item(0, e.RowIndex).Value = Not dataVocabulary.Item(0, e.RowIndex).Value
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dataVocabulary_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dataVocabulary.CellMouseClick
        Dim complex As PopupControl.Popup
        Dim exam As String
        'dim exam la gia tri cua cell Example nam cell so 7
        Try
            If e.ColumnIndex = Constants_LanhVC.INT_VOC_SEARCH_COLUMN_EXAMPLE AndAlso e.RowIndex >= 0 AndAlso (strType = Constants_LanhVC.STR_TYPE_UPDATE OrElse strType = Constants_LanhVC.STR_TYPE_VIEW) Then
                If (dataVocabulary.Rows(e.RowIndex).Cells(1).Value.ToString()) <> "" Then
                    exam = dataVocabulary.Rows(e.RowIndex).Cells(Constants_LanhVC.INT_VOC_SEARCH_COLUMN_EXAMPLE).Value.ToString()
                    If exam <> Constants_LanhVC.STR_BLANK_VALUE And exam <> " " Then
                        complex = New PopupControl.Popup(New MoreComplexPopup.ComplexPopup(exam))
                        complex.Resizable = True
                        Dim mousePos As Point = PointToClient(MousePosition)
                        complex.Show(mousePos)
                    End If
                End If
            End If
            ' End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
        If e.RowIndex >= 0 Then
            dataVocabulary.Rows(e.RowIndex).Cells("modified").Value = True
        End If
    End Sub

    Private Sub dataVocabulary_CellValidating(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles dataVocabulary.CellValidating
        Dim cellValue As String = Constants_LanhVC.STR_BLANK_VALUE
        Dim cell As DataGridViewCell = dataVocabulary.Rows(e.RowIndex).Cells(e.ColumnIndex)
        If e.ColumnIndex > 0 AndAlso cell.IsInEditMode Then
            Dim editingControl As Control = dataVocabulary.EditingControl
            cellValue = editingControl.Text
        End If
        'do not check blank string
        If Not Trim(Utils.ObjectToString(cellValue)).Equals(Constants_LanhVC.STR_BLANK_VALUE) Then
            If e.ColumnIndex = Constants_LanhVC.INT_VOC_SEARCH_COLUMN_KANJI Then
                If Not Utils.isKanji(Utils.ObjectToString(Utils.ObjectToString(cellValue))) Then
                    MessageBox.Show("Value in this column must have as least 1 Kanji characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    e.Cancel = True
                End If
                Dim Han_nom_cell As DataGridViewCell = dataVocabulary.Rows(e.RowIndex).Cells(Constants_LanhVC.INT_VOC_SEARCH_COLUMN_HANNOM)
                Dim strSQL As String
                Dim strHanNom As String = ""
                Dim charArray() As Char = cellValue.ToCharArray
                ''PhongNT
                Dim objKanTable As DataTable
                Dim objKanBO As SingleKanjiBO
                For i As Integer = 0 To charArray.Length - 1
                    strSQL = Constants_PhatLS.STR_SQL_SINGLE_KANJI_Kanji + charArray(i) + """"
                    Try
                        objKanBO = New SingleKanjiBO()
                        objKanTable = objKanBO.GetKanjiTable(strSQL)
                        If Not (objKanTable.Rows.Count = 0) Then
                            For j As Integer = 0 To objKanTable.Rows.Count - 1
                                If i < 1 Then
                                    strHanNom += objKanTable.Rows(j)(Constants_PhatLS.STR_HanNom)
                                Else
                                    strHanNom += " " + objKanTable.Rows(j)(Constants_PhatLS.STR_HanNom)
                                End If
                            Next
                        End If
                    Catch ex As Exception
                    End Try
                Next
                Han_nom_cell.Value = strHanNom
            ElseIf e.ColumnIndex = Constants_LanhVC.INT_VOC_SEARCH_COLUMN_HIGARANA Then
                If Not Utils.IsStringHiraganaKatakana(Utils.ObjectToString(Utils.ObjectToString(cellValue))) Then
                    MessageBox.Show("Value in this column must be in Hiragana/Katakana characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    e.Cancel = True
                End If
            End If
        End If
        btnSubmit.Enabled = True
    End Sub

    Private Sub dataVocabulary_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataVocabulary.CellValueChanged
        If strType = Constants_LanhVC.STR_TYPE_VIEW Then
            strType = Constants_LanhVC.STR_TYPE_UPDATE
            DisplayButton()
        End If


    End Sub

    Public Sub DisplayButton()
        Select Case strType
            Case Constants_LanhVC.STR_TYPE_NEW
                btnSubmit.Enabled = True
                btnDelete.Enabled = False
                dataVocabulary.AllowUserToAddRows = True

            Case Constants_LanhVC.STR_TYPE_UPDATE
                btnSubmit.Enabled = True
                btnDelete.Enabled = False
                dataVocabulary.AllowUserToAddRows = False

            Case Constants_LanhVC.STR_TYPE_VIEW
                btnSubmit.Enabled = False
                btnDelete.Enabled = False
                dataVocabulary.AllowUserToAddRows = False

        End Select
    End Sub

    Private Sub dataVocabulary_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dataVocabulary.KeyDown
        Dim temp = dataVocabulary.CurrentCell.OwningColumn.Index
        If temp = Constants_LanhVC.INT_VOC_SEARCH_COLUMN_EXAMPLE Then
            If e.Control = True And e.KeyCode = Keys.Enter Then
                dataVocabulary.CurrentCell.Value += ControlChars.NewLine
            End If
        End If
    End Sub

    Private Sub dataVocabulary_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dataVocabulary.Leave
        Dim arrBlankRows As ArrayList = New ArrayList
        Dim row As DataGridViewRow = New DataGridViewRow
        For index As Integer = 0 To dataVocabulary.Rows.Count - 2
            row = dataVocabulary.Rows(index)
            If Constants_LanhVC.STR_BLANK_VALUE.Equals(Trim(Utils.ObjectToString(row.Cells(Constants_LanhVC.INT_VOC_SEARCH_COLUMN_KANJI).Value))) _
            And Constants_LanhVC.STR_BLANK_VALUE.Equals(Trim(Utils.ObjectToString(row.Cells(Constants_LanhVC.INT_VOC_SEARCH_COLUMN_HIGARANA).Value))) _
            And Constants_LanhVC.STR_BLANK_VALUE.Equals(Trim(Utils.ObjectToString(row.Cells(Constants_LanhVC.INT_VOC_SEARCH_COLUMN_HANNOM).Value))) _
            And Constants_LanhVC.STR_BLANK_VALUE.Equals(Trim(Utils.ObjectToString(row.Cells(Constants_LanhVC.INT_VOC_SEARCH_COLUMN_MEANING).Value))) _
            And Constants_LanhVC.STR_BLANK_VALUE.Equals(Trim(Utils.ObjectToString(row.Cells(Constants_LanhVC.INT_VOC_SEARCH_COLUMN_EXAMPLE).Value))) Then
                arrBlankRows.Add(row)
            End If
        Next

        For index As Integer = 0 To arrBlankRows.Count - 1
            If dataVocabulary.Rows.Count >= 2 Then
                row = CType(arrBlankRows(index), DataGridViewRow)
                dataVocabulary.Rows.Remove(row)
            End If
        Next
    End Sub

    'Private Sub dataVocabulary_RowValidated(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataVocabulary.RowValidated
    '    If Trim(dataVocabulary.Rows(e.RowIndex).Cells(2).Value) = Constants_LanhVC.STR_BLANK_VALUE And _
    '                 e.RowIndex <> dataVocabulary.Rows.Count - 1 Then
    '        dataVocabulary.Rows(e.RowIndex).ErrorText = Constants_LanhVC.STR_MSG_ERR_004
    '    Else
    '        dataVocabulary.Rows(e.RowIndex).ErrorText = Constants_LanhVC.STR_BLANK_VALUE
    '    End If
    'End Sub


    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        Dim objVocBO As VocabulariesBO
        Dim objVocTable As DataTable
        Dim i, intTopicID As Integer
        Dim objVocEntity As VocabulariesEntity
        Dim objTopicBO As TopicsBO
        Dim bSameVocExist As Boolean
        Dim dlgSameVocabulary As dlgSameVocabulary
        Try
            If cboTopicGroupName.Text = Constants_LanhVC.STR_BLANK_VALUE Then
                MessageBox.Show(Constants_LanhVC.STR_MSG_ERR_007, Constants_LanhVC.STR_MESS_TYPE_WARRING, MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf cboTopicName.Text = Constants_LanhVC.STR_BLANK_VALUE Then
                MessageBox.Show(Constants_LanhVC.STR_MSG_ERR_001, Constants_LanhVC.STR_MESS_TYPE_WARRING, MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf dataVocabulary.RowCount = 1 And dataVocabulary.AllowUserToAddRows = True Then
                MessageBox.Show(Constants_LanhVC.STR_VOC_NO_VOCABULARY_IN_GRID, Constants_LanhVC.STR_MESS_TYPE_WARRING, MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf ValidateDataGrid() = False Then
                MessageBox.Show(Constants_LanhVC.STR_MSG_ERR_004, Constants_LanhVC.STR_MESS_TYPE_WARRING, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                objVocBO = New VocabulariesBO()
                objVocTable = New DataTable()
                objTopicBO = New TopicsBO()
                bSameVocExist = False
                'Duyet wa cac phan tu cua List
                For i = 0 To dataVocabulary.Rows.Count - 1
                    If dataVocabulary.Rows(i).Cells("modified").Value Then
                        intTopicID = dataVocabulary.Rows(i).Cells(Constants_LanhVC.INT_VOC_SEARCH_COLUMN_TOPICID).Value
                        objVocEntity = objVocBO.CopyDataToEntityFromDataGrid_SearchForm(dataVocabulary, i)
                        objVocEntity.TopicID = intTopicID
                        bSameVocExist = objVocBO.CheckExistUpdate_SearchForm(objVocEntity)
                        If bSameVocExist = True Then
                            'Dim objDlgUpdate As New dlgUpdate()
                            'objDlgUpdate.SetTextMessageContent(Constants_LanhVC.STR_MSG_ERR_005)
                            dlgSameVocabulary = New dlgSameVocabulary(objVocEntity, objVocBO.GetExistingVoc(objVocEntity))
                            dlgSameVocabulary.TopicName = dataVocabulary.Rows(i).Cells(Constants_LanhVC.INT_VOC_SEARCH_COLUMN_TOPICNAME).Value
                            dlgSameVocabulary.TopicGroupName = dataVocabulary.Rows(i).Cells(Constants_LanhVC.INT_VOC_SEARCH_COLUMN_TOPICGROUPNAME).Value
                            Dim result = dlgSameVocabulary.ShowDialog()
                            If result <> Constants_LanhVC.INT_SKIP Then
                                MessageBox.Show(Constants_LanhVC.STR_MSG_INFO_004, "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                objVocBO.DeleteVocabulary(objVocEntity)
                                btnSearch_Click(sender, e)
                            End If
                        Else
                            objVocBO.UpdateVocabulary(objVocEntity)
                            If dataVocabulary.Rows.Count > 0 Then
                                MessageBox.Show(Constants_LanhVC.STR_MSG_INFO_004, "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        End If
                    End If
                Next
            End If
        Catch ex As Exception
            MessageBox.Show("Error")
        End Try
    End Sub

    Private Function ValidateDataGrid()
        Dim bResult As Boolean
        Dim i As Integer
        Dim n As Integer

        'init
        bResult = True
        n = dataVocabulary.Rows.Count - 1
        If strType = Constants_LanhVC.STR_TYPE_NEW Then
            n = n - 1
        End If
        For i = 0 To n
            If dataVocabulary.Rows(i).ErrorText <> Constants_LanhVC.STR_BLANK_VALUE Then
                bResult = False
            Else
                ' when Hiragana column have no value
                If Constants_LanhVC.STR_BLANK_VALUE.Equals(Trim(dataVocabulary.Rows(i).Cells(Constants_LanhVC.INT_VOC_COLUMN_HIGARANA).Value)) Then
                    'if this row is not a blank row
                    If Not Constants_LanhVC.STR_BLANK_VALUE.Equals(Trim(Utils.ObjectToString(dataVocabulary.Rows(i).Cells(Constants_LanhVC.INT_VOC_COLUMN_KANJI).Value))) _
                    Or Not Constants_LanhVC.STR_BLANK_VALUE.Equals(Trim(Utils.ObjectToString(dataVocabulary.Rows(i).Cells(Constants_LanhVC.INT_VOC_COLUMN_HANNOM).Value))) _
                    Or Not Constants_LanhVC.STR_BLANK_VALUE.Equals(Trim(Utils.ObjectToString(dataVocabulary.Rows(i).Cells(Constants_LanhVC.INT_VOC_COLUMN_MEANING).Value))) Then
                        bResult = False
                    End If
                End If
            End If
        Next

        Return bResult
    End Function

    'code for button delete - add by minhln2
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If MessageBox.Show(Constants_LanhVC.STR_MSG_INFO_005, Constants_LanhVC.STR_MESS_TYPE_WARRING, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                Dim i As Integer
                Dim objVocBO As VocabulariesBO
                Dim objVocEntity As VocabulariesEntity

                'init
                objVocBO = New VocabulariesBO
                objVocEntity = New VocabulariesEntity

                For i = dataVocabulary.Rows.Count - 1 To 0 Step -1
                    If dataVocabulary.Rows(i).Cells(0).Value = True Then
                        objVocEntity.VocID = dataVocabulary.Rows(i).Cells(Constants_LanhVC.INT_GRID_COLUMN_VOCID).Value
                        objVocBO.DeleteVocabulary(objVocEntity)
                        dataVocabulary.Rows.RemoveAt(i)
                    End If
                Next
                MessageBox.Show(Constants_LanhVC.STR_MSG_INFO_006)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    'end code for button delete - add by minhln2

    Private Sub ExampleCellMouseEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataVocabulary.CellMouseEnter
        If e.ColumnIndex = Constants_LanhVC.INT_VOC_SEARCH_COLUMN_EXAMPLE AndAlso e.RowIndex >= 0 _
                AndAlso dataVocabulary.Rows(e.RowIndex).Cells(Constants_LanhVC.INT_VOC_SEARCH_COLUMN_EXAMPLE).Value IsNot Nothing _
                AndAlso Trim(dataVocabulary.Rows(e.RowIndex).Cells(Constants_LanhVC.INT_VOC_SEARCH_COLUMN_EXAMPLE).Value.ToString).Length > 0 Then
            'dataVocabulary.Rows(e.RowIndex).Cells(7).ToolTipText = "Click to view full text."

            searchToolTip.Show("Click to view full text.", dataVocabulary, 1000)
        End If
    End Sub

End Class
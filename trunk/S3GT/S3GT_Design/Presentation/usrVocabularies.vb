Public Class usrVocabularies

    Dim strType
    Dim objTopicGroupBO As TopicGroupsBO

    Dim objTopicBO As TopicsBO
    Dim objTopicTable As DataTable

    Dim blnHasNext, blnHasPrevious As Boolean
    Dim intOrder As Integer

    Dim tooltip As ToolTip

    Public mode As Utils.ModeUpdate


    Public Property TypeVovabirary() As String
        Get
            Return strType
        End Get
        Set(ByVal value As String)
            strType = value
        End Set
    End Property

    Public Sub DisplayButton()
        GroupBox1.SendToBack()
        Select Case strType
            Case Constants_LanhVC.STR_TYPE_NEW
                btnSubmit.Enabled = True
                btnReset.Enabled = True
                btnCancel.Enabled = True
                btnDelete.Enabled = False
                btnMoveAndCopy.Enabled = False
                dataVocabulary.AllowUserToAddRows = True

            Case Constants_LanhVC.STR_TYPE_UPDATE
                btnSubmit.Enabled = True
                btnReset.Enabled = True
                btnCancel.Enabled = True
                btnDelete.Enabled = False
                btnMoveAndCopy.Enabled = False
                dataVocabulary.AllowUserToAddRows = False

            Case Constants_LanhVC.STR_TYPE_VIEW
                btnSubmit.Enabled = False
                btnReset.Enabled = False
                btnCancel.Enabled = False
                btnDelete.Enabled = False
                btnMoveAndCopy.Enabled = False
                dataVocabulary.AllowUserToAddRows = False

        End Select
    End Sub


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

        Dim i As Integer

        'init
        cboTopicName.Items.Clear()
        objTopicTable = Nothing

        objTopicTable = objTopicBO.GetTopicListByTopicGroupName(strTopicGroupName)

        For i = 0 To objTopicTable.Rows.Count - 1
            cboTopicName.Items.Add(objTopicTable.Rows(i)(Constants_LanhVC.STR_TPC_COLUMN_NAME_TOPIC_NAME).ToString())
        Next
        If cboTopicName.Items.Count > 0 Then
            cboTopicName.SelectedIndex = Constants_LanhVC.INT_FIRST_TOPIC_INDEX_IN_TOPIC_GROUP
        End If
    End Sub

    ''' <summary>
    ''' Fill data to Datagrid
    ''' </summary>
    ''' <param name="strType">strType = '' => get datatable from Topic ID
    '''                       strType = 'Kanji' => get datatable from Topic Group Name, Topic Name, Kanji
    '''                               and strType is kanji character
    ''' </param>
    ''' <remarks></remarks>
    Public Sub FillDataToUserControl(ByVal strType As String)
        Dim objVocBO As VocabulariesBO
        Dim objVocTable As DataTable
        Dim objTopicBO As TopicsBO
        Dim i As Integer
        Dim intTopicID As Integer

        'init
        Try
            objVocBO = New VocabulariesBO()
            objVocTable = New DataTable()
            objTopicBO = New TopicsBO()
            intTopicID = -1

            If strType <> Constants_LanhVC.STR_BLANK_VALUE Then
                objVocTable = objVocBO.GetVocTableByKanji(cboTopicGroupName.Text, cboTopicName.Text, strType)
            Else
                intTopicID = objTopicBO.GetTopicID(cboTopicGroupName.Text, cboTopicName.Text)
                objVocTable = objVocBO.GetVocTableByTopic(intTopicID, blnHasNext, blnHasPrevious, 0)
            End If


            'copy data from table to datagrid
            For i = 0 To objVocTable.Rows.Count - 1
                dataVocabulary.Rows.Add()
                dataVocabulary.Rows(i).Cells(0).Value = Constants_LanhVC.STR_CHK_UNCHECK
                dataVocabulary.Rows(i).Cells(1).Value = objVocTable.Rows(i)(Constants_LanhVC.INT_VOC_DB_COLUMN_KANJI)
                dataVocabulary.Rows(i).Cells(2).Value = objVocTable.Rows(i)(Constants_LanhVC.INT_VOC_DB_COLUMN_HIGARANA)
                dataVocabulary.Rows(i).Cells(3).Value = objVocTable.Rows(i)(Constants_LanhVC.INT_VOC_DB_COLUMN_HANNOM)
                dataVocabulary.Rows(i).Cells(4).Value = objVocTable.Rows(i)(Constants_LanhVC.INT_VOC_DB_COLUMN_MEANING)
                dataVocabulary.Rows(i).Cells(7).Value = objVocTable.Rows(i)(Constants_LanhVC.INT_VOC_DB_COLUMN_EXAMPLE)

                dataVocabulary.Rows(i).Cells(5).Value = Utils.GetType_TextFromInt(objVocTable.Rows(i)(Constants_LanhVC.INT_VOC_DB_COLUMN_TYPE))
                'Select Case objVocTable.Rows(i)(Constants_LanhVC.INT_VOC_COLUMN_TYPE)
                '    Case 1
                '        dataVocabulary.Rows(i).Cells(4).Value = Constants_LanhVC.STR_VOC_TYPE_NOUN
                '    Case 2
                '        dataVocabulary.Rows(i).Cells(4).Value = Constants_LanhVC.STR_VOC_TYPE_PRO
                '    Case 3
                '        dataVocabulary.Rows(i).Cells(4).Value = Constants_LanhVC.STR_VOC_TYPE_VI
                '    Case 4
                '        dataVocabulary.Rows(i).Cells(4).Value = Constants_LanhVC.STR_VOC_TYPE_VT
                '    Case 5
                '        dataVocabulary.Rows(i).Cells(4).Value = Constants_LanhVC.STR_VOC_TYPE_I
                '    Case 6
                '        dataVocabulary.Rows(i).Cells(4).Value = Constants_LanhVC.STR_VOC_TYPE_NA
                '    Case 7
                '        dataVocabulary.Rows(i).Cells(4).Value = Constants_LanhVC.STR_VOC_TYPE_PREP
                'End Select
                dataVocabulary.Rows(i).Cells(6).Value = objVocTable.Rows(i)(Constants_LanhVC.INT_VOC_DB_COLUMN_VOCID)
                dataVocabulary.Rows(i).Cells("modified").Value = False
                dataVocabulary.Rows(i).Cells(Constants_LanhVC.STR_COLUMN_CHECK_DUPLICATED).Value = False
            Next

        Catch ex As Exception
            MessageBox.Show(ex.ToString(), Constants_LanhVC.STR_MSG_ERR_CODING, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Public Sub ClearDataGrid()
        dataVocabulary.Rows.Clear()
    End Sub

    Public Sub SetCheckAllRecord()
        Dim i As Integer

        For i = 0 To dataVocabulary.Rows.Count - 1
            dataVocabulary.Rows(i).Cells(0).Value = True
        Next
    End Sub

    'Public Function GetSameVocabulary()
    '    Dim arrSameVocabulary As New ArrayList
    '    Dim i, j As Int32

    '    For i = 0 To dataVocabulary.RowCount - 1
    '        For j = i + 1 To dataVocabulary.RowCount - 2
    '            If dataVocabulary.Item(1, i).Value = dataVocabulary.Item(1, j).Value Then
    '                arrSameVocabulary.Add(i)
    '                arrSameVocabulary.Add(j)
    '            End If
    '        Next
    '    Next

    '    Return arrSameVocabulary
    'End Function

    Public Sub SetStatusForButton(ByVal strButtonName As String, ByVal iStatus As Int16)
        Dim btn As New Button

        Try
            'set type button
            Select Case strButtonName
                Case Constants_LanhVC.STR_DELETE
                    btn = btnDelete
                Case Constants_LanhVC.STR_CANCEL
                    btn = btnCancel
                Case Constants_LanhVC.STR_MOVE_COPY
                    btn = btnMoveAndCopy
                Case Constants_LanhVC.STR_SUBMIT
                    btn = btnSubmit
            End Select

            'set status for buton
            Select Case iStatus
                Case Constants_LanhVC.INT_ENABLE_FALSE
                    btn.Enabled = False
                Case Constants_LanhVC.INT_ENABLE_TRUE
                    btn.Enabled = True
                Case Constants_LanhVC.INT_VISIBLE_FALSE
                    btn.Visible = False
                Case Constants_LanhVC.INT_VISIBLE_TRUE
                    btn.Visible = False
            End Select
        Catch ex As Exception

        End Try

    End Sub

    Public Sub SetTextForButton(ByVal btnButtonName As String, ByVal strText As String)
        Dim btn As New Button

        Try
            'set type button
            Select Case btnButtonName
                Case Constants_LanhVC.STR_DELETE
                    btn = btnDelete
                Case Constants_LanhVC.STR_CANCEL
                    btn = btnCancel
                Case Constants_LanhVC.STR_MOVE_COPY
                    btn = btnMoveAndCopy
                Case Constants_LanhVC.STR_SUBMIT
                    btn = btnSubmit
            End Select

            btn.Text = strText
        Catch ex As Exception

        End Try
    End Sub

    Public Sub New(ByVal pStrTopicGroupName As String, ByVal pStrTopicName As String, ByVal mode As Utils.ModeUpdate)
        Dim objTopicGroupTable As DataTable

        Me.mode = mode

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        tooltip = New ToolTip
        tooltip.ReshowDelay = 300
        tooltip.InitialDelay = 300

        ' Add any initialization after the InitializeComponent() call.
        'Dim arrValue As New ArrayList()
        'arrValue.Add("Group1")
        'arrValue.Add("Group2")
        'arrValue.Add("Group3")
        'SetTopicGroupValue(arrValue)

        Dim i As Integer
        Dim strTopicGroupName As String

        'init
        objTopicGroupBO = New TopicGroupsBO()
        objTopicGroupTable = New DataTable()
        objTopicBO = New TopicsBO()

        strTopicGroupName = Constants_LanhVC.STR_BLANK_VALUE

        objTopicGroupTable = objTopicGroupBO.GetTopicGroupsTable()
        For i = 0 To objTopicGroupTable.Rows.Count - 1
            strTopicGroupName = objTopicGroupTable.Rows(i)(Constants_LanhVC.STR_TPG_COLUMN_NAME_TOPIC_GROUP_NAME).ToString()
            cboTopicGroupName.Items.Add(strTopicGroupName)
        Next

        cboTopicGroupName.Text = pStrTopicGroupName

        FillDataToTopicControl(pStrTopicGroupName)
        cboTopicName.Text = pStrTopicName

    End Sub

    Private Sub cmbTopicGroupName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTopicGroupName.SelectedIndexChanged
        FillDataToTopicControl(cboTopicGroupName.Text) 'cboTopicGroupName.SelectedIndex 
        UpdateDataGrid()
        ' QuanTDA modified
    End Sub

    Private Sub lnkCreateTopic_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkCreateTopic.LinkClicked

        Dim objUsrTopic As usrTopic
        objUsrTopic = New usrTopic(cboTopicGroupName.Text)
        objUsrTopic.Dock = DockStyle.Fill
        frmMainForm.panContain.Controls.Add(objUsrTopic)
        Me.SendToBack()

    End Sub

    Private Sub BtnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        Dim objVocBO As VocabulariesBO
        Dim objVocTable As DataTable
        Dim dlgSameVocabulary As dlgSameVocabulary
        Dim i, intTopicID As Integer
        Dim objVocEntity As VocabulariesEntity
        Dim objTopicBO As TopicsBO
        Dim bSuccessful As Boolean = True
        Dim bSameVocExist As Boolean
        Dim applyToAll As Boolean = False
        Dim updateCount As Integer

        Try
            If cboTopicGroupName.Text = Constants_LanhVC.STR_BLANK_VALUE Then
                MessageBox.Show(Constants_LanhVC.STR_MSG_ERR_007, Constants_LanhVC.STR_MESS_TYPE_WARRING, MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf cboTopicName.Text = Constants_LanhVC.STR_BLANK_VALUE Then
                MessageBox.Show(Constants_LanhVC.STR_MSG_ERR_001, Constants_LanhVC.STR_MESS_TYPE_WARRING, MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf dataVocabulary.RowCount = 1 And dataVocabulary.AllowUserToAddRows = True Then
                MessageBox.Show(Constants_LanhVC.STR_VOC_NO_VOCABULARY_IN_GRID, Constants_LanhVC.STR_MESS_TYPE_WARRING, MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf Not ValidateDataGrid() = -1 Then
                MessageBox.Show(String.Format(Constants_LanhVC.STR_MSG_ERR_004, i + 1), Constants_LanhVC.STR_MESS_TYPE_WARRING, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                'if button is Update
                'If btnSubmit.Text = Constants_LanhVC.STR_SUBMIT_UPDATE Then
                If (mode = Utils.ModeUpdate.Update) Then

                    objVocBO = New VocabulariesBO()
                    objVocTable = New DataTable()
                    objTopicBO = New TopicsBO()
                    bSameVocExist = False
                    objVocEntity = New VocabulariesEntity()

                    intTopicID = objTopicBO.GetTopicID(cboTopicGroupName.Text, cboTopicName.Text)

                    applyToAll = False
                    updateCount = 0
                    For i = 0 To dataVocabulary.Rows.Count - 1
                        If dataVocabulary.Rows(i).Cells("modified").Value Then

                            objVocEntity = objVocBO.CopyDataToEntityFromDataGrid(dataVocabulary, i)
                            objVocEntity.TopicID = intTopicID
                            objVocTable = objVocBO.CheckExist(dataVocabulary, i, intTopicID)

                            If dataVocabulary.Rows(i).Cells(Constants_LanhVC.STR_COLUMN_CHECK_DUPLICATED).Value Then
                                If objVocTable.Rows.Count > 0 Then
                                    dlgSameVocabulary = New dlgSameVocabulary(objVocEntity, objVocTable)
                                    dlgSameVocabulary.TopicName = cboTopicName.Text
                                    dlgSameVocabulary.TopicGroupName = cboTopicGroupName.Text
                                    Dim result = dlgSameVocabulary.ShowDialog()
                                    If result <> Constants_LanhVC.INT_SKIP Then
                                        'MessageBox.Show(Constants_LanhVC.STR_MSG_INFO_004, "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    End If
                                    dlgSameVocabulary.Dispose()
                                    objVocBO.DeleteVocabulary(objVocEntity)
                                Else
                                    objVocBO.UpdateVocabulary(objVocEntity)
                                    'MessageBox.Show(Constants_LanhVC.STR_MSG_INFO_004, "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                End If
                            Else
                                objVocBO.UpdateVocabulary(objVocEntity)
                                'MessageBox.Show(Constants_LanhVC.STR_MSG_INFO_004, "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        End If
                    Next
                    MessageBox.Show("Updating vocabularies finished", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else    'Mode New
                    objVocBO = New VocabulariesBO()
                    objVocTable = New DataTable()
                    objTopicBO = New TopicsBO()

                    intTopicID = objTopicBO.GetTopicID(cboTopicGroupName.Text, cboTopicName.Text)


                    For i = 0 To dataVocabulary.Rows.Count - 2
                        'Xu ly trung nhau
                        objVocTable = objVocBO.CheckExist(dataVocabulary.Rows(i).Cells(Constants_LanhVC.INT_VOC_COLUMN_HIGARANA).Value, dataVocabulary.Rows(i).Cells(Constants_LanhVC.INT_VOC_COLUMN_KANJI).Value, intTopicID)

                        'Neu co phan tu trung nhau
                        If objVocTable.Rows.Count > 0 Then
                            'If applyToAll Then
                            'Else

                            dlgSameVocabulary = New dlgSameVocabulary(dataVocabulary.Rows, i, objVocTable)
                            dlgSameVocabulary.TopicName = cboTopicName.Text
                            dlgSameVocabulary.TopicGroupName = cboTopicGroupName.Text
                            Dim result = dlgSameVocabulary.ShowDialog()
                            If result = Constants_LanhVC.INT_SKIP Then
                                bSuccessful = False
                            Else
                                bSuccessful = True
                            End If
                            dlgSameVocabulary.Dispose()
                            'End If
                        Else
                            'Ket thuc xu ly trung nhau
                            objVocEntity = objVocBO.CopyDataToEntityFromDataGrid(dataVocabulary, i)

                            'get topic ID (lay tu file TopicBO)
                            'set cung lam vi du
                            objTopicBO = New TopicsBO()
                            objVocEntity.TopicID = objTopicBO.GetTopicID(cboTopicGroupName.Text, cboTopicName.Text)

                            objVocBO.AddNew(objVocEntity)
                            bSuccessful = True
                        End If

                    Next
                    If bSuccessful Then
                        MessageBox.Show("Adding new vocabularies finished", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mode = Utils.ModeUpdate.Update
                        btnSubmit.Text = Constants_PhatLS.STR_TYPE_SUBMIT
                    End If
                End If
                'after updating or add Vocabularies
                'display all Vocabularies in the relating Topic Group and Topic
                ' for modifying
                DisplayDataForModification()
            End If

        Catch ex As Exception
            MessageBox.Show("Error")
            bSuccessful = False
        End Try

    End Sub
    ''' <summary> Start chen show Example
    ''' CellMouseClick - show Example
    ''' Click chuot vao cell kanji nao thi exam cua kanji do (neu co) se duoc show ra
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub dataVocabulary_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dataVocabulary.CellMouseClick

        Dim complex As PopupControl.Popup
        Dim exam As String
        'dim exam la gia tri cua cell Example nam cell so 7
        Try
            'If e.ColumnIndex = 1 And e.RowIndex >= 0 And (strType = Constants_LanhVC.STR_TYPE_UPDATE Or strType = Constants_LanhVC.STR_TYPE_VIEW) Then
            '    If (dataVocabulary.Rows(e.RowIndex).Cells(1).Value.ToString()) <> "" Then
            '        exam = dataVocabulary.Rows(e.RowIndex).Cells(7).Value.ToString()
            '        If exam <> Constants_LanhVC.STR_BLANK_VALUE And exam <> " " Then
            '            complex = New PopupControl.Popup(New MoreComplexPopup.ComplexPopup(exam))
            '            complex.Resizable = True
            '            Dim mousePos As Point = PointToClient(MousePosition)
            '            complex.Show(mousePos)
            '        End If
            '    End If
            'End If

            If e.ColumnIndex = 7 AndAlso e.RowIndex >= 0 AndAlso (strType = Constants_LanhVC.STR_TYPE_UPDATE OrElse strType = Constants_LanhVC.STR_TYPE_VIEW) Then
                exam = dataVocabulary.Rows(e.RowIndex).Cells(7).Value.ToString()
                If (Trim(exam) <> "") Then
                    complex = New PopupControl.Popup(New MoreComplexPopup.ComplexPopup(exam))
                    complex.Resizable = True
                    Dim mousePos As Point = PointToClient(MousePosition)
                    complex.Show(mousePos)
                End If
            End If
            ' End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

        'GiangNVT modified
        'If e.RowIndex >= 0 Then
        '    dataVocabulary.Rows(e.RowIndex).Cells("modified").Value = True
        'End If

    End Sub
    '''Ket thuc chen showExample
    ''' End sub

    Private Sub dataVocabulary_CellMouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
        'MessageBox.Show(dataVocabulary.Rows(0).Cells(0).Value)
        Dim i As Int32
        Try
            ' if it's Checkbox column
            If e.ColumnIndex = 0 And (strType = Constants_LanhVC.STR_TYPE_UPDATE Or strType = Constants_LanhVC.STR_TYPE_VIEW) Then
                'set checkbox is change before check
                dataVocabulary.Rows(e.RowIndex).Cells(0).Value = Not dataVocabulary.Rows(e.RowIndex).Cells(0).Value

                Try
                    If dataVocabulary.Rows(e.RowIndex).Cells(0).Value = Constants_LanhVC.STR_CHK_CHECK Then
                        btnDelete.Enabled = True
                        btnMoveAndCopy.Enabled = True
                        Return
                    End If

                    For i = 0 To dataVocabulary.RowCount - 1

                        If dataVocabulary.Rows(i).Cells(0).Value = Constants_LanhVC.STR_CHK_CHECK Then
                            btnDelete.Enabled = True
                            btnMoveAndCopy.Enabled = True

                            Return
                        End If
                    Next

                    btnDelete.Enabled = False
                    btnMoveAndCopy.Enabled = False

                Catch ex As Exception
                    MessageBox.Show(ex.ToString())
                End Try
                'set checkbox like old value
                'dataVocabulary.Item(0, e.RowIndex).Value = Not dataVocabulary.Item(0, e.RowIndex).Value
            End If
        Catch ex As Exception

        End Try
        'dataVocabulary.Item(0, 0).Value = -1
        'MessageBox.Show(dataVocabulary.Rows(0).Cells(0).Value)

    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        'cboTopicGroupName.SelectedIndex = Constants_LanhVC.INT_COMBOBOX_FIRST_VALUE
        'cboTopicName.SelectedIndex = Constants_LanhVC.INT_COMBOBOX_FIRST_VALUE


        If strType = Constants_LanhVC.STR_TYPE_NEW Then
            'cboTopicGroupName.Text = Constants_LanhVC.STR_GROUP_TEXT
            'FillDataToTopicControl(cboTopicGroupName.Text)
            'cboTopicName.Text = Constants_LanhVC.STR_TOPIC_TEXT
            dataVocabulary.Rows.Clear()
        Else
            dataVocabulary.Rows.Clear()
            FillDataToUserControl(Constants_LanhVC.STR_BLANK_VALUE)
        End If


    End Sub


    'Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
    '    'cboTopicGroupName.SelectedIndex = Constants_LanhVC.INT_COMBOBOX_FIRST_VALUE
    '    'cboTopicName.SelectedIndex = Constants_LanhVC.INT_COMBOBOX_FIRST_VALUE


    '    If strType = Constants_LanhVC.STR_TYPE_NEW Then
    '        'cboTopicGroupName.Text = Constants_LanhVC.STR_GROUP_TEXT
    '        'FillDataToTopicControl(cboTopicGroupName.Text)
    '        'cboTopicName.Text = Constants_LanhVC.STR_TOPIC_TEXT
    '        dataVocabulary.Rows.Clear()
    '    Else
    '        dataVocabulary.Rows.Clear()
    '        FillDataToUserControl(Constants_LanhVC.STR_BLANK_VALUE)
    '    End If

    'End Sub

    Public Sub btnMoveAndCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoveAndCopy.Click

        'Show form Move&Copy
        'If MessageBox.Show(Constants_LanhVC.STR_MSG_INFO_007, Constants_LanhVC.STR_MESS_TYPE_WARRING, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
        Dim frmMove_Copy As New frmMoveAndCopy(dataVocabulary.Rows, cboTopicGroupName.Text, cboTopicName.Text)
        frmMove_Copy.Show()
        ' End If

        'Panel1.Controls.Add(frmSameVocabulary)

    End Sub

    Private Sub dataVocabulary_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles dataVocabulary.CellValidating

        Dim cellValue As String = Constants_LanhVC.STR_BLANK_VALUE
        Dim cell As DataGridViewCell = dataVocabulary.Rows(e.RowIndex).Cells(e.ColumnIndex)
        If e.ColumnIndex > 0 AndAlso cell.IsInEditMode Then
            Dim editingControl As Control = dataVocabulary.EditingControl
            cellValue = editingControl.Text
        End If

        dataVocabulary.Rows(e.RowIndex).Cells("modified").Value = True

        'do not check blank string
        If Not Trim(Utils.ObjectToString(cellValue)).Equals(Constants_LanhVC.STR_BLANK_VALUE) Then

            'dataVocabulary.Rows(e.RowIndex).Cells("modified").Value = True
            If e.ColumnIndex = Constants_LanhVC.INT_VOC_COLUMN_KANJI OrElse _
                    e.ColumnIndex = Constants_LanhVC.INT_VOC_DB_COLUMN_HIGARANA Then
                dataVocabulary.Rows(e.RowIndex).Cells(Constants_LanhVC.STR_COLUMN_CHECK_DUPLICATED).Value = True
            End If

            If e.ColumnIndex = Constants_LanhVC.INT_VOC_COLUMN_KANJI Then
                'If Not Utils.isKanji(Utils.ObjectToString(Utils.ObjectToString(cellValue))) Then
                '    MessageBox.Show("Value in this column must have as least 1 Kanji characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                '    e.Cancel = True
                'End If

                If e.ColumnIndex = Constants_LanhVC.INT_VOC_COLUMN_KANJI And e.RowIndex >= 0 Then
                    Dim hanNomCell As DataGridViewCell = dataVocabulary.Rows(e.RowIndex).Cells(Constants_LanhVC.INT_VOC_COLUMN_HANNOM)
                    Dim hiraganaCell As DataGridViewCell = dataVocabulary.Rows(e.RowIndex).Cells(Constants_LanhVC.INT_VOC_COLUMN_HIGARANA)

                    'Auto fill Han Nom
                    If hanNomCell.Value Is Nothing OrElse hanNomCell.Value.ToString.Trim.Length = 0 Then
                        hanNomCell.Value = Utils.GetHanNom(cellValue)
                    End If

                    'Auto fill Hiragana
                    If hiraganaCell.Value Is Nothing OrElse hiraganaCell.Value.ToString.Trim.Length = 0 Then
                        hiraganaCell.Value = Utils.GetJPhonetic(cellValue)
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub dataVocabulary_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataVocabulary.CellValueChanged
        If strType = Constants_LanhVC.STR_TYPE_VIEW Then
            strType = Constants_LanhVC.STR_TYPE_UPDATE
            DisplayButton()
        End If
    End Sub

    Public Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
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

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Parent.Controls.Remove(Me)
        'MessageBox.Show("aaa")
        'dataVocabulary.Rows.RemoveAt(0)
        Me.Finalize()
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
                        btnMoveAndCopy.Enabled = True
                        Return
                    End If

                    For i = 0 To dataVocabulary.RowCount - 1

                        If dataVocabulary.Rows(i).Cells(0).Value = Constants_LanhVC.STR_CHK_CHECK Then
                            btnDelete.Enabled = True
                            btnMoveAndCopy.Enabled = True

                            Return
                        End If
                    Next

                    btnDelete.Enabled = False
                    btnMoveAndCopy.Enabled = False

                Catch ex As Exception
                    MessageBox.Show(ex.ToString())
                End Try
                'set checkbox like old value
                'dataVocabulary.Item(0, e.RowIndex).Value = Not dataVocabulary.Item(0, e.RowIndex).Value
            End If

        Catch ex As Exception

        End Try
    End Sub

    'Private Sub dataVocabulary_RowValidating(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs)
    '    'If Trim(dataVocabulary.Rows(e.RowIndex).Cells(2).Value) = Constants_LanhVC.STR_BLANK_VALUE And _
    '    '      e.RowIndex <> dataVocabulary.Rows.Count - 1 Then
    '    '    MessageBox.Show(Constants_LanhVC.STR_MSG_ERR_004, Constants_LanhVC.STR_MESS_TYPE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    '    dataVocabulary.Rows(e.RowIndex).Cells(e.ColumnIndex).Selected = True

    '    'End If

    'End Sub

    'Private Sub dataVocabulary_RowLeave(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataVocabulary.RowValidated


    '    If Trim(dataVocabulary.Rows(e.RowIndex).Cells(2).Value) = Constants_LanhVC.STR_BLANK_VALUE And _
    '                 e.RowIndex <> dataVocabulary.Rows.Count - 1 Then
    '        dataVocabulary.Rows(e.RowIndex).ErrorText = Constants_LanhVC.STR_MSG_ERR_004
    '        'MessageBox.Show(Constants_LanhVC.STR_MSG_ERR_004, Constants_LanhVC.STR_MESS_TYPE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        'btnCancel_Click(sender, e)
    '    Else
    '        dataVocabulary.Rows(e.RowIndex).ErrorText = Constants_LanhVC.STR_BLANK_VALUE
    '    End If
    'End Sub

    Private Function ValidateDataGrid()
        'Dim bResult As Boolean
        Dim i As Integer
        Dim n As Integer

        'init
        n = dataVocabulary.Rows.Count - 1
        If strType = Constants_LanhVC.STR_TYPE_NEW Then
            n = n - 1
        End If
        For i = 0 To n
            If (dataVocabulary.Rows(i).Cells("modified").Value) Then
                ' when Hiragana column have no value
                If Constants_LanhVC.STR_BLANK_VALUE.Equals(Trim(dataVocabulary.Rows(i).Cells(Constants_LanhVC.INT_VOC_COLUMN_KANJI).Value)) _
                        OrElse Constants_LanhVC.STR_BLANK_VALUE.Equals(Trim(Utils.ObjectToString(dataVocabulary.Rows(i).Cells(Constants_LanhVC.INT_VOC_COLUMN_HIGARANA).Value))) Then
                    Return i
                End If
            End If
        Next
        Return -1
    End Function

    ''' <summary>
    ''' Update dataGird after change move
    ''' Is Called by another form
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub UpdateDataGrid()
        dataVocabulary.Rows.Clear()
        FillDataToUserControl(Constants_LanhVC.STR_BLANK_VALUE)
    End Sub

    ''' <summary>
    ''' Update topic combobox after create new topic or update topic
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub UpdateTopic(ByVal strNewTopic As String)
        cboTopicName.Items.Clear()
        FillDataToTopicControl(cboTopicGroupName.Text)
        cboTopicName.Text = strNewTopic
    End Sub

    Private Sub cboTopicName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTopicName.SelectedIndexChanged
        'Dim intTopicID As Integer
        'Dim objTopicBO As TopicsBO
        'Dim objVocTable As DataTable
        'Dim objVocBO As VocabulariesBO

        ''init 
        'objTopicBO = New TopicsBO()
        'objVocBO = New VocabulariesBO()

        'If strType = Constants_LanhVC.STR_TYPE_UPDATE Then
        '    intTopicID = objTopicBO.GetTopicID(cboTopicGroupName.Text, cboTopicName.Text)
        '    objVocTable = objVocBO.GetVocTableByTopic(intTopicID)
        'End If

        'only update grid when the form is in Update mode
        If Constants_LanhVC.STR_TYPE_UPDATE.Equals(strType) Then
            UpdateDataGrid()
        End If

    End Sub

    Private Sub dataVocabulary_RowValidating(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub dataVocabulary_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataVocabulary.CellClick
        'If e.ColumnIndex = 1 Then
        'dataVocabulary_CellContentClick(sender, e)
        'test combobox auto-expand
        If (e.RowIndex >= 0) Then
            dataVocabulary.BeginEdit(True)
            If e.ColumnIndex = Constants_LanhVC.INT_VOC_COLUMN_TYPE Then 'if the column in action is the Type column
                SendKeys.SendWait("{F4}") 'expand the list of Type for selection
            End If
            'End If
        End If
    End Sub

    Private Sub dataVocabulary_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dataVocabulary.Leave
        Dim arrBlankRows As ArrayList = New ArrayList
        Dim row As DataGridViewRow = New DataGridViewRow
        For index As Integer = 0 To dataVocabulary.Rows.Count - 2
            row = dataVocabulary.Rows(index)
            If Constants_LanhVC.STR_BLANK_VALUE.Equals(Trim(Utils.ObjectToString(row.Cells(Constants_LanhVC.INT_VOC_COLUMN_KANJI).Value))) _
            And Constants_LanhVC.STR_BLANK_VALUE.Equals(Trim(Utils.ObjectToString(row.Cells(Constants_LanhVC.INT_VOC_COLUMN_HIGARANA).Value))) _
            And Constants_LanhVC.STR_BLANK_VALUE.Equals(Trim(Utils.ObjectToString(row.Cells(Constants_LanhVC.INT_VOC_COLUMN_HANNOM).Value))) _
            And Constants_LanhVC.STR_BLANK_VALUE.Equals(Trim(Utils.ObjectToString(row.Cells(Constants_LanhVC.INT_VOC_COLUMN_MEANING).Value))) _
            And Constants_LanhVC.STR_BLANK_VALUE.Equals(Trim(Utils.ObjectToString(row.Cells(Constants_LanhVC.INT_VOC_COLUMN_EXAMPLE).Value))) Then
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
    Public Sub DisplayDataForModification()
        'Me.SetTextTopicGroupControl(cboTopicGroupName.Text)
        'Me.SetTextTopicControl(cboTopicName.Text)
        'Me.SetTextForButton(Constants_LanhVC.STR_SUBMIT, Constants_LanhVC.STR_SUBMIT_UPDATE)
        Me.TypeVovabirary = Constants_LanhVC.STR_TYPE_UPDATE
        Me.DisplayButton()
        Me.ClearDataGrid()
        Me.FillDataToUserControl(Constants_LanhVC.STR_BLANK_VALUE)
    End Sub

    Private Sub label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles label2.Click

    End Sub

    Private Sub label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles label1.Click

    End Sub

    Private Sub btn_DeSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_DeSelectAll.Click
        Dim i As Integer
        For i = 0 To dataVocabulary.RowCount - 1
            dataVocabulary.Item(0, i).Value = False
        Next
    End Sub

    Private Sub btn_SelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SelectAll.Click
        Dim i As Integer
        For i = 0 To dataVocabulary.RowCount - 1
            dataVocabulary.Item(0, i).Value = True
        Next
        btnDelete.Enabled = True
        'btnCancel.Enabled = True
        btnMoveAndCopy.Enabled = True
    End Sub

    Private Sub dataVocabulary_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dataVocabulary.KeyDown
        Try
            Dim temp = dataVocabulary.CurrentCell.OwningColumn.Index
            If temp = Constants_LanhVC.INT_VOC_COLUMN_EXAMPLE Then
                If e.Control = True And e.KeyCode = Keys.Enter Then
                    dataVocabulary.CurrentCell.Value += ControlChars.NewLine
                End If
            End If
        Catch ex As Exception
            'Table is blank -> Do nothing
        End Try
    End Sub


    Private Sub btnFillHiragana_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFillHiragana.Click
        Dim index As Integer
        Dim currentKanji As String
        For index = 0 To dataVocabulary.RowCount - 1
            currentKanji = dataVocabulary.Rows(index).Cells(1).Value
            If Not currentKanji Is Nothing AndAlso currentKanji.Length > 0 Then
                If (dataVocabulary.Rows(index).Cells(2).Value Is Nothing OrElse _
                        dataVocabulary.Rows(index).Cells(2).Value.ToString.Trim.Length = 0) Then
                    dataVocabulary.Rows(index).Cells(2).Value = Utils.GetJPhonetic(currentKanji)
                    dataVocabulary.Rows(index).Cells("modified").Value = True
                    dataVocabulary.Rows(index).Cells(Constants_LanhVC.STR_COLUMN_CHECK_DUPLICATED).Value = True
                End If
            End If
        Next

    End Sub


    Private Sub btnFillHanNom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFillHanNom.Click
        Dim index As Integer
        Dim currentKanji As String
        For index = 0 To dataVocabulary.RowCount - 1
            currentKanji = dataVocabulary.Rows(index).Cells(1).Value
            If Not currentKanji Is Nothing AndAlso currentKanji.Length > 0 Then
                If (dataVocabulary.Rows(index).Cells(3).Value Is Nothing OrElse _
                        dataVocabulary.Rows(index).Cells(3).Value.ToString.Trim.Length = 0) Then
                    dataVocabulary.Rows(index).Cells(3).Value = Utils.GetHanNom(currentKanji)
                    dataVocabulary.Rows(index).Cells("modified").Value = True
                End If
            End If
        Next

    End Sub

    Private Sub ExampleCellMouseEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataVocabulary.CellMouseEnter
        If e.ColumnIndex = 7 AndAlso e.RowIndex >= 0 AndAlso dataVocabulary.Rows(e.RowIndex).Cells(7).Value IsNot Nothing AndAlso Trim(dataVocabulary.Rows(e.RowIndex).Cells(7).Value.ToString).Length > 0 Then
            'dataVocabulary.Rows(e.RowIndex).Cells(7).ToolTipText = "Click to view full text."

            tooltip.Show("Click to view full text.", dataVocabulary, 1000)
        End If
    End Sub

    'Private Sub ExampleCellMouseLeave(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataVocabulary.CellMouseLeave
    '    tooltip.Hide(dataVocabulary)
    'End Sub
End Class

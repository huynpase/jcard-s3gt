Public Class usrAddSingleKanji
    Dim objKanTable As DataTable
    Dim NumberOfChecked As Int32
    Dim LastCheckToUpdate As Int32
    Dim RowLastChecked As Int32

    Public Sub New(ByVal strSingleKanji As String, ByVal strAmHan As String, ByVal strKun As String _
        , ByVal strOn As String, ByVal strMeaning As String, ByVal strKaki As String)


        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        NumberOfChecked = 0
        LastCheckToUpdate = 0
        SingleKanjiData()
        If strSingleKanji <> Constants_PhatLS.STR_BLANK_VALUE Then
            Dim MaxRow As Integer
            Dim i As Integer

            MaxRow = DataKanji.Rows.Count

            'init
            'btnSubmit.Text = Constants_PhatLS.STR_TYPE_UPDATE
            'txtKanji.Enabled = Constants_PhatLS.STR_TYPE_ENABLE_FALSE
            'txtKanji.Text = strSingleKanji
            'txtAmHan.Text = strAmHan
            'txtKun.Text = strKun
            'txtOn.Text = strOn
            'txtMeaning.Text = strMeaning
            'txtKaki.Text = strKaki

            'Find lasted Single Kanji_ID is checked
            'For i = 0 To MaxRow - 1
            '    If DataKanji.Rows(i).Cells(1).Value = txtKanji.Text Then
            '        LastCheckToUpdate = DataKanji.Rows(i).Cells(Constants_PhatLS.STR_CREATE_UPDATE_SINGLE_KANJI_COLUMN_ID).Value
            '        RowLastChecked = i
            '    End If
            'Next
        End If
    End Sub

    ''' <summary>
    ''' Fist view in datagrid when starts Create/Update Single_Kanji
    ''' </summary>
    Public Sub SingleKanjiData()
        Dim objKanBO As SingleKanjiBO
        Dim i As Integer
        Dim strSearch As String

        'init
        Try
            objKanBO = New SingleKanjiBO()
            objKanTable = objKanBO.GetKanjiTable(Constants_PhatLS.STR_SQL_SINGLE_KANJI)
            If Not (objKanTable.Rows.Count = 0) Then
                For i = 0 To objKanTable.Rows.Count - 1
                    'Fist view in datagrid when starts Create/Update Single_Kanji
                    DataKanji.Rows.Add()
                    DataKanji.Rows(i).Cells(Constants_PhatLS.STR_CREATE_UPDATE_SINGLE_KANJI_COLUMN_CHECKBOX).Value = Constants_PhatLS.STR_TYPE_UNCHECKED
                    DataKanji.Rows(i).Cells(Constants_PhatLS.STR_CREATE_UPDATE_SINGLE_KANJI_COLUMN_KANJI).Value = objKanTable.Rows(i)(Constants_PhatLS.STR_Kanji)
                    DataKanji.Rows(i).Cells(Constants_PhatLS.STR_CREATE_UPDATE_SINGLE_KANJI_COLUMN_HANNOM).Value = objKanTable.Rows(i)(Constants_PhatLS.STR_HanNom)
                    DataKanji.Rows(i).Cells(Constants_PhatLS.STR_CREATE_UPDATE_SINGLE_KANJI_COLUMN_KUNYOMI).Value = objKanTable.Rows(i)(Constants_PhatLS.STR_Kunyomi)
                    DataKanji.Rows(i).Cells(Constants_PhatLS.STR_CREATE_UPDATE_SINGLE_KANJI_COLUMN_ONYOMI).Value = objKanTable.Rows(i)(Constants_PhatLS.STR_Onyomi)
                    DataKanji.Rows(i).Cells(Constants_PhatLS.STR_CREATE_UPDATE_SINGLE_KANJI_COLUMN_MEANING).Value = objKanTable.Rows(i)(Constants_PhatLS.STR_Meaning)
                    DataKanji.Rows(i).Cells(Constants_PhatLS.STR_CREATE_UPDATE_SINGLE_KANJI_COLUMN_ID).Value = objKanTable.Rows(i)(Constants_PhatLS.STR_Kanji_ID)

                    'Display Kakikata
                    strSearch = DataKanji.Rows(i).Cells(1).Value
                    strSearch = strSearch & Constants_PhatLS.STR_TYPE_IMAGE
                    If CheckFile(strSearch, CurDir()) Then
                        DataKanji.Rows(i).Cells(Constants_PhatLS.STR_CREATE_UPDATE_SINGLE_KANJI_COLUMN_KAKIKATA).Value = CurDir() + Constants_PhatLS.STR_SOURCE_KANJI_IMAGE & strSearch
                    End If
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString(), Constants_PhatLS.STR_MSG_ERR_CODING, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    ''' <summary>
    ''' Check file name is existed or not in a place
    ''' </summary>
    ''' <param name="sFileName">file name wants to check</param>
    ''' <param name="sDir">Place where to checks file</param>
    ''' <returns>boolean of existing file</returns>
    Function CheckFile(ByVal sFileName As String, ByVal sDir As String) As Boolean
        Dim sTmp As String
        sTmp = Dir(sDir & Constants_PhatLS.STR_SOURCE_KANJI_IMAGE & sFileName)
        If sTmp = sFileName Then
            CheckFile = Constants_PhatLS.STR_EXISTED_IMAGE
        Else
            CheckFile = Constants_PhatLS.STR_UNEXISTED_IMAGE
        End If
        Return CheckFile
    End Function


    'Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim MaxRow As Integer
    '    Dim i As Integer
    '    Dim ExistSingleKanji As Boolean = Constants_PhatLS.STR_UNEXISTED_SINGLE_KANJI
    '    Dim strSearch As String
    '    Dim objSingleKanjiBO As SingleKanjiBO
    '    Dim objVocEntity As SingleKanjiEntity


    '    MaxRow = DataKanji.Rows.Count
    '    If txtKanji.Text = Constants_PhatLS.STR_BLANK_VALUE Then
    '        MessageBox.Show(Constants_PhatLS.STR_MSG_ERR_009)
    '    ElseIf ValidInputData() Then
    '        'Add new Single Kanji
    '        If btnSubmit.Text = Constants_PhatLS.STR_TYPE_SUBMIT Then
    '            For i = 0 To MaxRow - 1
    '                If DataKanji.Rows(i).Cells(1).Value = txtKanji.Text Then
    '                    ExistSingleKanji = Constants_PhatLS.STR_EXISTED_SINGLE_KANJI
    '                End If
    '            Next
    '            If ExistSingleKanji = Constants_PhatLS.STR_EXISTED_SINGLE_KANJI Then
    '                MessageBox.Show(Constants_PhatLS.STR_MSG_ERR_010)
    '            Else
    '                DataKanji.Rows.Add()
    '                DataKanji.Rows(MaxRow).Cells(Constants_PhatLS.STR_CREATE_UPDATE_SINGLE_KANJI_COLUMN_CHECKBOX).Value = Constants_PhatLS.STR_TYPE_UNCHECKED
    '                DataKanji.Rows(MaxRow).Cells(Constants_PhatLS.STR_CREATE_UPDATE_SINGLE_KANJI_COLUMN_KANJI).Value = txtKanji.Text
    '                DataKanji.Rows(MaxRow).Cells(Constants_PhatLS.STR_CREATE_UPDATE_SINGLE_KANJI_COLUMN_HANNOM).Value = txtAmHan.Text
    '                DataKanji.Rows(MaxRow).Cells(Constants_PhatLS.STR_CREATE_UPDATE_SINGLE_KANJI_COLUMN_KUNYOMI).Value = txtKun.Text
    '                DataKanji.Rows(MaxRow).Cells(Constants_PhatLS.STR_CREATE_UPDATE_SINGLE_KANJI_COLUMN_ONYOMI).Value = txtOn.Text

    '                'Process to copy source file to resource
    '                If txtKaki.Text <> Constants_PhatLS.STR_BLANK_VALUE Then
    '                    CopyImageToResource(txtKaki.Text, txtKanji.Text)
    '                End If

    '                'Display Kakikata
    '                strSearch = DataKanji.Rows(i).Cells(Constants_PhatLS.STR_CREATE_UPDATE_SINGLE_KANJI_COLUMN_KANJI).Value
    '                strSearch = strSearch & Constants_PhatLS.STR_TYPE_IMAGE
    '                If CheckFile(strSearch, CurDir()) Then
    '                    DataKanji.Rows(MaxRow).Cells(Constants_PhatLS.STR_CREATE_UPDATE_SINGLE_KANJI_COLUMN_KAKIKATA).Value = CurDir() + Constants_PhatLS.STR_SOURCE_KANJI_IMAGE & strSearch
    '                End If
    '            End If

    '            If ExistSingleKanji = Constants_PhatLS.STR_UNEXISTED_SINGLE_KANJI Then
    '                objSingleKanjiBO = New SingleKanjiBO()
    '                objVocEntity = objSingleKanjiBO.CopyDataToEntityFromDataGrid(txtKanji.Text, txtAmHan.Text, txtKun.Text, txtOn.Text, txtMeaning.Text)
    '                objSingleKanjiBO.AddNew(objVocEntity)
    '                DataKanji.Rows(MaxRow).Cells(Constants_PhatLS.STR_CREATE_UPDATE_SINGLE_KANJI_COLUMN_MEANING).Value = txtMeaning.Text
    '                DataKanji.Rows(MaxRow).Cells(Constants_PhatLS.STR_CREATE_UPDATE_SINGLE_KANJI_COLUMN_ID).Value = objVocEntity.SingleKanjiID
    '                Reset()
    '            End If
    '        Else 'Update DataKanji
    '            objSingleKanjiBO = New SingleKanjiBO()

    '            objVocEntity = objSingleKanjiBO.CopyDataToEntityFromDataGrid(txtKanji.Text, txtAmHan.Text, txtKun.Text, txtOn.Text, txtMeaning.Text)
    '            objVocEntity.SingleKanjiID = LastCheckToUpdate
    '            objSingleKanjiBO.UpdateSingleKanji(objVocEntity)

    '            'Update Data Kanji
    '            DataKanji.Rows(RowLastChecked).Cells(Constants_PhatLS.STR_CREATE_UPDATE_SINGLE_KANJI_COLUMN_KANJI).Value = txtKanji.Text
    '            DataKanji.Rows(RowLastChecked).Cells(Constants_PhatLS.STR_CREATE_UPDATE_SINGLE_KANJI_COLUMN_HANNOM).Value = txtAmHan.Text
    '            DataKanji.Rows(RowLastChecked).Cells(Constants_PhatLS.STR_CREATE_UPDATE_SINGLE_KANJI_COLUMN_KUNYOMI).Value = txtKun.Text
    '            DataKanji.Rows(RowLastChecked).Cells(Constants_PhatLS.STR_CREATE_UPDATE_SINGLE_KANJI_COLUMN_ONYOMI).Value = txtOn.Text
    '            DataKanji.Rows(RowLastChecked).Cells(Constants_PhatLS.STR_CREATE_UPDATE_SINGLE_KANJI_COLUMN_MEANING).Value = txtMeaning.Text

    '            If txtKaki.Text <> "" Then
    '                CopyImageToResource(txtKaki.Text, txtKanji.Text)
    '            End If

    '            'Display Kakikata
    '            strSearch = DataKanji.Rows(RowLastChecked).Cells(Constants_PhatLS.STR_CREATE_UPDATE_SINGLE_KANJI_COLUMN_KANJI).Value
    '            strSearch = strSearch & Constants_PhatLS.STR_TYPE_IMAGE
    '            If CheckFile(strSearch, CurDir()) Then
    '                DataKanji.Rows(RowLastChecked).Cells(Constants_PhatLS.STR_CREATE_UPDATE_SINGLE_KANJI_COLUMN_KAKIKATA).Value = CurDir() + Constants_PhatLS.STR_SOURCE_KANJI_IMAGE & strSearch
    '            End If
    '            MessageBox.Show(Constants_PhatLS.STR_MSG_INFO_015)
    '        End If
    '    End If
    'End Sub


    ''' <summary>
    ''' Check input Kanji is in right format
    ''' </summary>
    Private Function CheckIsNotJapanese(ByVal kanji As String) As Boolean
        Dim checkVal As Boolean = False
        If kanji.Length = Constants_PhatLS.NUM_LENGTH_KANJI Then

            If (AscW(kanji) >= Constants_PhatLS.NUM_MIN_LIMIT_KANJI And AscW(kanji) <= Constants_PhatLS.NUM_MAX_LIMIT_KANJI) Then 'is single kanji
                checkVal = True
            Else
                MessageBox.Show(Constants_PhatLS.STR_MSG_ERR_011, Constants_PhatLS.STR_MESS_TYPE_ERORR, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show(Constants_PhatLS.STR_MSG_ERR_011, Constants_PhatLS.STR_MESS_TYPE_ERORR, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Return checkVal
    End Function
    ''' <summary>
    ''' Copy Image To Local Resource
    ''' </summary>
    ''' <param name="PathImageFile">Path of image file name</param>
    ''' <param name="NewImageFileName">New Image File Name</param>
    Private Sub CopyImageToResource(ByVal PathImageFile As String, ByVal NewImageFileName As String)
        If Not PathImageFile.Contains(CurDir() + Constants_PhatLS.STR_SOURCE_KANJI_IMAGE + NewImageFileName + ".gif") Then
            FileSystem.FileCopy(PathImageFile, CurDir() + Constants_PhatLS.STR_SOURCE_KANJI_IMAGE + NewImageFileName + ".gif")
        End If
    End Sub
    'Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    ofdKaki.InitialDirectory = CurDir() + Constants_PhatLS.STR_SOURCE_KANJI_IMAGE
    '    ofdKaki.Filter = Constants_PhatLS.STR_BROWSER_FOLDER
    '    ofdKaki.FilterIndex = 2
    '    ofdKaki.RestoreDirectory = True

    '    If ofdKaki.ShowDialog() = DialogResult.OK Then
    '        txtKaki.Text = ofdKaki.FileName
    '    End If
    'End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Reset()
    End Sub
    'Private Sub Reset()
    '    txtKanji.Text = Constants_PhatLS.STR_BLANK_VALUE
    '    txtAmHan.Text = Constants_PhatLS.STR_BLANK_VALUE
    '    txtKun.Text = Constants_PhatLS.STR_BLANK_VALUE
    '    txtOn.Text = Constants_PhatLS.STR_BLANK_VALUE
    '    txtMeaning.Text = Constants_PhatLS.STR_BLANK_VALUE
    '    txtKaki.Text = Constants_PhatLS.STR_BLANK_VALUE
    '    btnSubmit.Text = Constants_PhatLS.STR_TYPE_SUBMIT
    '    txtKanji.Enabled = Constants_PhatLS.STR_TYPE_ENABLE_TRUE
    'End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmMainForm.panContain.Controls.Clear()
    End Sub

    Private Sub DataKanji_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataKanji.CellContentClick
        Dim strSearch As String

        Select Case e.ColumnIndex()
            Case Constants_PhatLS.STR_CREATE_UPDATE_SINGLE_KANJI_COLUMN_KAKIKATA
                Dim Found As Boolean
                Dim InputImage As String
                InputImage = DataKanji.Rows(e.RowIndex).Cells(0).Value
                Found = Constants_PhatLS.STR_UNEXISTED_SINGLE_KANJI
                Dim frmDisplaySingleKanji As New frmDisplaySingleKanji(DataKanji.Rows(e.RowIndex).Cells(1).Value, Found)
                If Found = Constants_PhatLS.STR_EXISTED_SINGLE_KANJI Then
                    frmDisplaySingleKanji.ShowDialog(Me)
                End If
                'Case Constants_PhatLS.STR_CREATE_UPDATE_SINGLE_KANJI_COLUMN_CHECKBOX
                '    Select Case DataKanji.Rows(e.RowIndex).Cells(Constants_PhatLS.STR_CREATE_UPDATE_SINGLE_KANJI_COLUMN_CHECKBOX).Value
                '        Case Constants_PhatLS.STR_TYPE_UNCHECKED
                '            LastCheckToUpdate = DataKanji.Rows(e.RowIndex).Cells(Constants_PhatLS.STR_CREATE_UPDATE_SINGLE_KANJI_COLUMN_ID).Value
                '            RowLastChecked = e.RowIndex
                '            'Set value to update
                '            txtKanji.Text = DataKanji.Rows(e.RowIndex).Cells(Constants_PhatLS.STR_CREATE_UPDATE_SINGLE_KANJI_COLUMN_KANJI).Value.ToString
                '            txtAmHan.Text = DataKanji.Rows(e.RowIndex).Cells(Constants_PhatLS.STR_CREATE_UPDATE_SINGLE_KANJI_COLUMN_HANNOM).Value.ToString
                '            txtKun.Text = DataKanji.Rows(e.RowIndex).Cells(Constants_PhatLS.STR_CREATE_UPDATE_SINGLE_KANJI_COLUMN_KUNYOMI).Value.ToString
                '            txtOn.Text = DataKanji.Rows(e.RowIndex).Cells(Constants_PhatLS.STR_CREATE_UPDATE_SINGLE_KANJI_COLUMN_ONYOMI).Value.ToString
                '            If (DataKanji.Rows(e.RowIndex).Cells(Constants_PhatLS.STR_CREATE_UPDATE_SINGLE_KANJI_COLUMN_MEANING).Value.Equals(System.DBNull.Value)) Then
                '                txtMeaning.Text = ""
                '            Else
                '                txtMeaning.Text = DataKanji.Rows(e.RowIndex).Cells(Constants_PhatLS.STR_CREATE_UPDATE_SINGLE_KANJI_COLUMN_MEANING).Value
                '            End If
                '            'Kakikata path
                '            strSearch = txtKanji.Text
                '            strSearch = strSearch & Constants_PhatLS.STR_TYPE_IMAGE
                '            If CheckFile(strSearch, CurDir()) Then
                '                txtKaki.Text = CurDir() + Constants_PhatLS.STR_SOURCE_KANJI_IMAGE & strSearch
                '            Else
                '                txtKaki.Text = Constants_PhatLS.STR_BLANK_VALUE
                '            End If 'End of kakikata path   

                '            'Set value checkbox again
                '            DataKanji.Rows(e.RowIndex).Cells(Constants_PhatLS.STR_CREATE_UPDATE_SINGLE_KANJI_COLUMN_CHECKBOX).Value = Constants_PhatLS.STR_TYPE_CHECKED
                '            NumberOfChecked = NumberOfChecked + 1
                '            'Set text for SUBMIT button
                '            btnSubmit.Text = Constants_PhatLS.STR_TYPE_UPDATE
                '            txtKanji.Enabled = Constants_PhatLS.STR_TYPE_ENABLE_FALSE
                '        Case Constants_PhatLS.STR_TYPE_CHECKED
                '            If NumberOfChecked > 1 Then
                '                NumberOfChecked = NumberOfChecked - 1
                '                DataKanji.Rows(e.RowIndex).Cells(Constants_PhatLS.STR_CREATE_UPDATE_SINGLE_KANJI_COLUMN_CHECKBOX).Value = Constants_PhatLS.STR_TYPE_UNCHECKED
                '            Else
                '                If NumberOfChecked = 1 Then
                '                    NumberOfChecked = NumberOfChecked - 1
                '                    DataKanji.Rows(e.RowIndex).Cells(Constants_PhatLS.STR_CREATE_UPDATE_SINGLE_KANJI_COLUMN_CHECKBOX).Value = Constants_PhatLS.STR_TYPE_UNCHECKED
                '                    btnSubmit.Text = Constants_PhatLS.STR_TYPE_SUBMIT
                '                    txtKanji.Enabled = Constants_PhatLS.STR_TYPE_ENABLE_TRUE
                '                End If
                '            End If
                '    End Select
        End Select
    End Sub

    'Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim i As Integer
    '    Dim objSingleKanjiBO As SingleKanjiBO
    '    Dim objSingleKanjiEntity As SingleKanjiEntity

    '    Try
    '        NumberOfChecked = 0
    '        btnSubmit.Text = Constants_PhatLS.STR_TYPE_SUBMIT
    '        txtKanji.Enabled = Constants_PhatLS.STR_TYPE_ENABLE_TRUE
    '        objSingleKanjiBO = New SingleKanjiBO
    '        objSingleKanjiEntity = New SingleKanjiEntity
    '        If MessageBox.Show(Constants_PhatLS.STR_MSG_SINGLE_KANJI_DELETE, Constants_PhatLS.STR_MESS_TYPE_WARRING, MessageBoxButtons.YesNo) = DialogResult.Yes Then
    '            For i = DataKanji.RowCount - 1 To 0 Step -1
    '                If DataKanji.Rows(i).Cells(Constants_PhatLS.STR_CREATE_UPDATE_SINGLE_KANJI_COLUMN_CHECKBOX).Value = Constants_PhatLS.STR_TYPE_CHECKED Then
    '                    objSingleKanjiEntity.SingleKanjiID = DataKanji.Rows(i).Cells(Constants_PhatLS.STR_CREATE_UPDATE_SINGLE_KANJI_COLUMN_ID).Value
    '                    objSingleKanjiBO.DeleteSingleKanji(objSingleKanjiEntity)
    '                    DataKanji.Rows.RemoveAt(i)
    '                End If
    '            Next
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.ToString())
    '    End Try
    '    'QuanTDA's code
    '    Reset()
    '    'QuanTDA's code
    'End Sub

    'Private Function ValidInputData() As Boolean
    '    Dim strErrorMsgBuilder As System.Text.StringBuilder = New System.Text.StringBuilder
    '    Dim strErrorMsg As String = Constants_LanhVC.STR_BLANK_VALUE
    '    Dim isValid As Boolean = True

    '    If Not Constants_LanhVC.STR_BLANK_VALUE.Equals(txtKanji.Text) AndAlso Not Utils.isKanji(txtKanji.Text) Then
    '        strErrorMsgBuilder.Append("Value in Kanji form of the single Kanji character must be in Kanji character")
    '        strErrorMsgBuilder.AppendLine()
    '    End If
    '    If Not Constants_LanhVC.STR_BLANK_VALUE.Equals(txtKun.Text) _
    '       AndAlso Not (Utils.IsStringHiragana(txtKun.Text)) Then
    '        strErrorMsgBuilder.Append("Value in Kunyomi form of the single Kanji character must be in Hiragana characters")
    '        strErrorMsgBuilder.AppendLine()
    '    End If

    '    If Not Constants_LanhVC.STR_BLANK_VALUE.Equals(txtOn.Text) _
    '       AndAlso Not (Utils.IsStringKatakana(txtOn.Text)) Then
    '        strErrorMsgBuilder.Append("Value in Onyomi form of the single Kanji character must be in Katakana characters")
    '        strErrorMsgBuilder.AppendLine()
    '    End If

    '    If Not Constants_LanhVC.STR_BLANK_VALUE.Equals(txtAmHan.Text) Then
    '        If (Utils.IsStringKatakana(txtAmHan.Text)) _
    '           Or (Utils.IsStringHiragana(txtAmHan.Text)) _
    '           Or (Utils.isKanji(txtAmHan.Text)) Then
    '            strErrorMsgBuilder.Append("Han Nom value of the Vocabulary must not be in Japanese characters")
    '            strErrorMsgBuilder.AppendLine()
    '        End If
    '    End If

    '    If Not Constants_LanhVC.STR_BLANK_VALUE.Equals(txtMeaning.Text) Then
    '        If (Utils.IsStringKatakana(txtMeaning.Text)) _
    '           Or (Utils.IsStringHiragana(txtMeaning.Text)) _
    '           Or (Utils.isKanji(txtMeaning.Text)) Then
    '            strErrorMsgBuilder.Append("Meaning value of the Vocabulary must not be in Japanese characters")
    '            strErrorMsgBuilder.AppendLine()
    '        End If
    '    End If

    '    strErrorMsg = strErrorMsgBuilder.ToString
    '    If strErrorMsg.Length > 0 Then
    '        MessageBox.Show(strErrorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '        isValid = False
    '    End If
    '    Return isValid

    'End Function

    Private Sub btn_CheckAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim i As Integer
        For i = 0 To DataKanji.RowCount - 1
            DataKanji.Item(0, i).Value = True
        Next


    End Sub

    Private Sub btn_UncheckAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim i As Integer
        For i = 0 To DataKanji.RowCount - 1
            DataKanji.Item(0, i).Value = False
        Next
    End Sub

    'Private Sub txtKanji_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    txtOn.Text = Utils.GetJPhonetic(txtKanji.Text)
    'End Sub
End Class

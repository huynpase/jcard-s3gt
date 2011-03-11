Public Class usrSearchSingleKanji
    Dim objKanTable As DataTable
    Dim objKanBO As SingleKanjiBO

    Public Sub New()
        InitializeComponent()

        Dim arrValue As New ArrayList()
        arrValue.Add("Kanji")
        arrValue.Add("Onyomi")
        arrValue.Add("Kunyomi")
        arrValue.Add("HanNom")
        arrValue.Add("Meaning")
        SetSearchByValue(arrValue)
        cmbSearchSingleKanji.Text = "Kanji"
    End Sub

    ''' <summary>
    ''' Set value for into combobox
    ''' </summary>
    ''' <param name="arrValue">Key search</param>
    ''' <remarks></remarks>
    Public Sub SetSearchByValue(ByVal arrValue As ArrayList)
        Dim i As Int16
        For i = 0 To arrValue.Count - 1
            cmbSearchSingleKanji.Items.Add(arrValue.Item(i))
        Next
    End Sub
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If txtSingleKanji.Text = "" Then
            MessageBox.Show(Constants_PhatLS.STR_MSG_ERR_012)
            Return
        End If
        objKanTable = New DataTable()
        DataKanji.Rows.Clear()
        objKanTable.Rows.Clear()
        FillDataToUserControl(txtSingleKanji.Text, cmbSearchSingleKanji.Text)
    End Sub
    Public Sub FillDataToUserControl(ByVal strSearch As String, ByVal SearchBy As String)
        Dim strSQL As String
        Select Case SearchBy
            Case "Kanji"
                strSQL = Constants_PhatLS.STR_SQL_SINGLE_KANJI_Kanji + strSearch + """"
                DataAfterSearch(strSQL)
            Case "HanNom"
                strSQL = Constants_PhatLS.STR_SQL_SINGLE_KANJI_HanNom + strSearch + "%" + "'"
                DataAfterSearch(strSQL)
            Case "Onyomi"
                strSQL = Constants_PhatLS.STR_SQL_SINGLE_KANJI_Onyomi + strSearch + "%" + """"
                DataAfterSearch(strSQL)
            Case "Kunyomi"
                strSQL = Constants_PhatLS.STR_SQL_SINGLE_KANJI_Kunyomi + strSearch + "%" + """"
                DataAfterSearch(strSQL)
            Case "Meaning"
                strSQL = Constants_PhatLS.STR_SQL_SINGLE_KANJI_Meaning + strSearch + "%" + """"
                DataAfterSearch(strSQL)
        End Select
    End Sub
    Public Sub DataAfterSearch(ByVal strSQL As String)
        Dim i As Integer
        Dim strSearch As String
        'init
        Try
            objKanBO = New SingleKanjiBO()
            objKanTable = objKanBO.GetKanjiTable(strSQL)
            If Not (objKanTable.Rows.Count = 0) Then
                For i = 0 To objKanTable.Rows.Count - 1
                    DataKanji.Rows.Add()
                    DataKanji.Rows(i).Cells(0).Value = objKanTable.Rows(i)(Constants_PhatLS.STR_Kanji)
                    DataKanji.Rows(i).Cells(1).Value = objKanTable.Rows(i)(Constants_PhatLS.STR_HanNom)
                    DataKanji.Rows(i).Cells(2).Value = objKanTable.Rows(i)(Constants_PhatLS.STR_Kunyomi)
                    DataKanji.Rows(i).Cells(3).Value = objKanTable.Rows(i)(Constants_PhatLS.STR_Onyomi)
                    DataKanji.Rows(i).Cells(4).Value = objKanTable.Rows(i)(Constants_PhatLS.STR_Meaning)

                    'Display Kakikata
                    strSearch = DataKanji.Rows(i).Cells(0).Value
                    strSearch = strSearch & ".gif"
                    If CheckFile(strSearch, CurDir()) Then
                        DataKanji.Rows(i).Cells(5).Value = CurDir() + Constants_PhatLS.STR_SOURCE_KANJI_IMAGE & strSearch
                    End If
                    'DataKanji.Rows(i).Cells(6).Value = "Edit"

                Next

            End If
        Catch ex As Exception
            'MessageBox.Show(ex.ToString(), Constants_LanhVC.STR_MSG_ERR_CODING, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Function CheckFile(ByVal sFileName As String, ByVal sDir As String) As Boolean
        Dim sTmp As String
        sTmp = Dir(sDir & Constants_PhatLS.STR_SOURCE_KANJI_IMAGE & sFileName)
        If sTmp = sFileName Then
            CheckFile = True
        Else
            CheckFile = False
        End If
    End Function

    Private Sub DataKanji_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataKanji.CellContentClick
        Dim strSearch As String
        If e.ColumnIndex() = 5 Then
            Dim Found As Boolean
            Dim InputImage As String
            InputImage = DataKanji.Rows(e.RowIndex).Cells(0).Value
            Found = False
            Dim frmDisplaySingleKanji As New frmDisplaySingleKanji(DataKanji.Rows(e.RowIndex).Cells(0).Value, Found)
            If Found = True Then
                frmDisplaySingleKanji.ShowDialog(Me)
            End If
        End If
        If e.ColumnIndex() = 6 Then
            Dim i As Int32
            For i = 0 To 5
                If DataKanji.Rows(e.RowIndex).Cells(0).Value = "" Then
                    DataKanji.Rows(e.RowIndex).Cells(0).Value = " "
                End If
            Next
            'Check Kakikata
            strSearch = DataKanji.Rows(e.RowIndex).Cells(0).Value.ToString
            strSearch = strSearch & ".gif"
            If Not CheckFile(strSearch, CurDir()) Then
                DataKanji.Rows(e.RowIndex).Cells(5).Value = ""
            End If

            Dim UpdateSingleKanji As New usrAddSingleKanji(DataKanji.Rows(e.RowIndex).Cells(0).Value.ToString, _
                                                            DataKanji.Rows(e.RowIndex).Cells(1).Value.ToString, _
                                                            DataKanji.Rows(e.RowIndex).Cells(2).Value.ToString, _
                                                            DataKanji.Rows(e.RowIndex).Cells(3).Value.ToString, _
                                                            DataKanji.Rows(e.RowIndex).Cells(4).Value.ToString, _
                                                            DataKanji.Rows(e.RowIndex).Cells(5).Value.ToString)
            frmMainForm.panContain.Controls.Clear()
            frmMainForm.panContain.Controls.Add(UpdateSingleKanji)
            UpdateSingleKanji.Dock = DockStyle.Fill
        End If
    End Sub


    Private Sub txtSingleKanji_TextChanged(ByVal sender As System.Object, ByVal e As KeyPressEventArgs) Handles txtSingleKanji.KeyPress
        If (e.KeyChar = ChrW(13)) Then
            If txtSingleKanji.Text = "" Then
                MessageBox.Show(Constants_PhatLS.STR_MSG_ERR_012)
                Return
            End If
            objKanTable = New DataTable()
            objKanTable.Rows.Clear()
            DataKanji.Rows.Clear()
            FillDataToUserControl(txtSingleKanji.Text, cmbSearchSingleKanji.Text)
        End If
    End Sub

End Class


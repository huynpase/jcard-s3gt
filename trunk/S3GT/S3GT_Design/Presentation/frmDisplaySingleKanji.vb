Public Class frmDisplaySingleKanji

    Public Sub New(ByVal strSingleKanji As String, ByRef Found As Boolean)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        FillDataToUserControl(strSingleKanji, Found)
    End Sub
    Public Sub FillDataToUserControl(ByVal strSingleKanji As String, ByRef Found As Boolean)
        Dim objKanBO As SingleKanjiBO
        Dim objKanTable As DataTable
        Dim strSQL As String

        'init
        Try
            objKanBO = New SingleKanjiBO()
            objKanTable = New DataTable()
            Found = True

            'SQL
            strSQL = Constants_PhatLS.STR_SQL_SINGLE_KANJI_Kanji + strSingleKanji + """"
            'Set data
            objKanTable = objKanBO.GetKanjiTable(strSQL)
            If objKanTable.Rows.Count = 0 Then
                Found = False
                Return
            End If
            'copy data to text box

            lblAmHan.Text = objKanTable.Rows(0)(Constants_PhatLS.STR_HanNom).ToString
            lbldsMeaning.Text = objKanTable.Rows(0)(Constants_PhatLS.STR_Meaning).ToString
            lbldsKun.Text = objKanTable.Rows(0)(Constants_PhatLS.STR_Kunyomi).ToString
            lbldsOn.Text = objKanTable.Rows(0)(Constants_PhatLS.STR_Onyomi).ToString


            'Display Kakikata
            strSingleKanji = strSingleKanji & ".gif"
            If CheckFile(strSingleKanji, CurDir()) Then
                picKaki.Image = New System.Drawing.Bitmap(CurDir() & Constants_PhatLS.STR_SOURCE_KANJI_IMAGE & strSingleKanji)
            Else
                picKaki.Image = Nothing 'New System.Drawing.Bitmap(Constants_PhatLS.STR_SOURCE_KANJI_IMAGE & "blank.gif")
            End If

        Catch ex As Exception
            Found = False
            MessageBox.Show(ex.ToString(), Constants_LanhVC.STR_MSG_ERR_CODING, MessageBoxButtons.OK, MessageBoxIcon.Information)
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

End Class
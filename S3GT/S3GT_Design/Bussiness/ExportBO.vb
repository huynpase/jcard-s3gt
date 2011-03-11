Imports System.IO
Imports S3GT.Constants_NguyenNB
Public Class ExportBO
    'Dim excelApp As Excel.Application
    ' Dim wb As Excel.Workbook
    Dim dao As New ExportDAO
    Private strLogFileName As String
    Private strLog As String
    'minhln2 - dim to interupt export process
    Dim cont As Boolean = True

    'minhln1 - function to set interupt value
    Public Sub SetCancel(ByVal cancel As Boolean)
        cont = cancel
    End Sub

    Public Sub New()
        strLog = ""
    End Sub
    Public Sub CreateLog()
        Dim strPath
        strPath = Utils.GetPath(Application.ExecutablePath) + "\Log"
        If Not System.IO.Directory.Exists(strPath) Then
            System.IO.Directory.CreateDirectory(strPath)
        End If

        strLogFileName = strPath + "\Log_import_" + _
                       Date.Today.Year.ToString("####") + Date.Today.Month.ToString("0#") + Date.Today.Day.ToString("0#") + _
                       Now.Hour.ToString("0#") + Now.Minute.ToString("0#") + Now.Second.ToString("0#") + ".txt"
        Utils.SaveTextToFile("", strLogFileName, False)
    End Sub
    Public Sub DeleteLog()
        Try
            System.IO.File.Delete(strLogFileName)
        Catch ex As Exception

        End Try
    End Sub
    Public ReadOnly Property LogFileName() As String
        Get
            Return strLogFileName
        End Get
        'Set(ByVal value As String)
        '    strLogFileName = value
        'End Set
    End Property
    Function GetToppic() As DataTable
        Return dao.GetToppic()
    End Function

    Function GetSubToppic(ByVal strTopicID As String) As DataTable
        Return dao.GetSubToppic(strTopicID)
    End Function

    Function GetKanji() As DataTable
        Return dao.GetKanji
    End Function

    Function GetFileName(ByVal strFileName As String) As String
        Return strFileName.Split("\")(0)
    End Function

    Function GetCellValue(ByVal ws As Excel.Worksheet, ByVal intRow As Int16, ByVal intCol As Int16)
        Try
            Return CType(ws.Range(ws.Cells(intRow, intCol), ws.Cells(intRow, intCol)).Value, String)
        Catch ex As Exception
            Return ""
        End Try
    End Function
    Sub SetCellValue(ByRef ws As Excel.Worksheet, ByVal intRow As Int16, ByVal intCol As Int16, ByVal strValue As String)
        Dim range As Excel.Range

        If Not strValue Is Nothing Then
            range = ws.Range(ws.Cells(intRow, intCol), ws.Cells(intRow, intCol))
            range.Value = strValue
        End If
    End Sub
    Private Sub ReleaseComObject(ByRef Reference As Object)
        Try
            Do Until _
             System.Runtime.InteropServices.Marshal.ReleaseComObject(Reference) <= 0
            Loop
        Catch
        Finally
            Reference = Nothing
        End Try
    End Sub

    'minhln2
    'add progressbar
    Function ExportVocExcel(ByVal strFolderPath As String, ByVal dtTopic As DataTable, _
    ByVal d_pgrMax As usrExport.SetPgrMaxValue, ByVal d_pgrValue As usrExport.SetPgrValue) As Boolean
        Dim excelApp As Excel.Application
        Dim ws As Excel.Worksheet
        Dim row As DataRow
        Dim wb As Excel.Workbook
        Dim nVoc As Integer
        excelApp = New Excel.Application
        Dim dtVoc As DataTable
        Dim strFilePath As String

        Try
            If Not (strFolderPath.Trim.EndsWith("/") OrElse strFolderPath.Trim.EndsWith("\")) Then
                strFolderPath += Path.DirectorySeparatorChar
            End If

            For Each row In dtTopic.Rows
                dtVoc = dao.GetVoc(row(2))
                nVoc += dtVoc.Rows.Count
            Next
            dtVoc.Dispose()
            d_pgrMax(nVoc)

            For Each row In dtTopic.Rows

                strFilePath = strFolderPath + row(1) + "_" + row(3) + "_" + Format(System.DateTime.Now, "yyyMMdd_HHmmss") + ".xls"



                'check if file read only or is opening
                If Utils.IsFileCannotAccess(strFilePath) Then
                    Return False
                End If

                wb = excelApp.Workbooks.Add()

                'add sheet topic group
                ws = wb.Sheets(1)
                ws.Name = EXP_PREFIX_SHEET_TOPIC_GROUP

                'add sheet topic
                ws = wb.Sheets(2)
                ws.Name = EXP_PREFIX_SHEET_TOPIC

                ws = wb.Sheets(3)
                ws.Delete()


                'For Each row In dtTopic.Rows
                '    dtVoc = dao.GetVoc(row(2))
                '    nVoc += dtVoc.Rows.Count
                'Next
                'dtVoc.Dispose()
                'd_pgrMax(nVoc)

                'For Each row In dtTopic.Rows
                '    ExportLineToExcel(excelApp, wb, strFileName, row(0), row(1), row(2), row(3), d_pgrValue)
                '    'when user press cancel button => interupt the function

                '    If Not cont Then
                '        Exit For
                '    End If
                'Next
                ExportLineToExcel(excelApp, wb, row(0), row(1), row(2), row(3), d_pgrValue)
                If Not cont Then
                    Exit For
                End If

                wb.SaveAs(strFilePath)
                wb.Close()
            Next

            excelApp.Quit()
            ReleaseComObject(excelApp)
            Return True

        Catch ex As Exception
            If ex.Message.Substring(0, ERR_MESS_REGION.Length) = ERR_MESS_REGION Then
                MessageBox.Show(MESS_REGION, "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

            If excelApp.Workbooks.Count > 0 Then
                For Each wb In excelApp.Workbooks
                    wb.RejectAllChanges()
                    wb.Close(False)
                Next
            End If
            excelApp.Quit()
            ReleaseComObject(excelApp)

            Return False
        End Try
    End Function
    'minhln2
    'add progressbar
    Sub ExportLineToExcel(ByVal excelApp As Excel.Application, _
                    ByVal wb As Excel.Workbook, _
                    ByVal strNodeId As String, _
                    ByVal strNodeName As String, _
                    ByVal strSubNodeId As String, _
                    ByVal strSubNodeName As String, _
                    ByVal d_pgrValue As usrExport.SetPgrValue)

        Dim ws As Excel.Worksheet
        Dim range1, range2 As Excel.Range
        Dim dtVoc As DataTable
        Dim row As DataRow
        Dim currRowIdx As Int32
        'Dim strLog As String = ""
        Dim intLastRow As Integer
        Try
            'reset strLog
            strLog = ""
            'add sheet topic group
            ws = excelApp.Workbooks(1).Sheets(EXP_PREFIX_SHEET_TOPIC_GROUP)

            range1 = CType(ws.Cells(1, 1), Excel.Range)

            If GetCellValue(ws, 1, 1) = "" Then
                SetCellValue(ws, 1, 1, strNodeId)
                SetCellValue(ws, 1, 2, strNodeName)
            ElseIf GetCellValue(ws, 2, 1) = "" Then
                SetCellValue(ws, 2, 1, strNodeId)
                SetCellValue(ws, 2, 2, strNodeName)
            Else
                intLastRow = range1.End(Excel.XlDirection.xlDown).Row
                SetCellValue(ws, intLastRow + 1, 1, strNodeId)
                SetCellValue(ws, intLastRow + 1, 2, strNodeName)
            End If

            'add sheet topic
            ws = excelApp.Workbooks(1).Sheets(EXP_PREFIX_SHEET_TOPIC)
            range1 = CType(ws.Cells(1, 1), Excel.Range)
            range2 = CType(ws.Cells(1, 3), Excel.Range)
            If GetCellValue(ws, 1, 1) = "" Then
                SetCellValue(ws, 1, 1, strNodeId)
                SetCellValue(ws, 1, 2, strNodeName)
                SetCellValue(ws, 1, 3, strSubNodeId)
                SetCellValue(ws, 1, 4, strSubNodeName)
            ElseIf GetCellValue(ws, 2, 1) = "" Then
                SetCellValue(ws, 2, 1, strNodeId)
                SetCellValue(ws, 2, 2, strNodeName)
                SetCellValue(ws, 2, 3, strSubNodeId)
                SetCellValue(ws, 2, 4, strSubNodeName)
            Else
                intLastRow = range1.End(Excel.XlDirection.xlDown).Row
                SetCellValue(ws, intLastRow + 1, 1, strNodeId)
                SetCellValue(ws, intLastRow + 1, 2, strNodeName)
                intLastRow = range2.End(Excel.XlDirection.xlDown).Row
                SetCellValue(ws, intLastRow + 1, 3, strSubNodeId)
                SetCellValue(ws, intLastRow + 1, 4, strSubNodeName)
            End If
            'get all vocabulary relate to topic
            dtVoc = dao.GetVoc(strSubNodeId)
            'create new sheet contains vocabulary
            ws = wb.Worksheets.Add()
            ws.Move(After:=wb.Sheets(wb.Sheets.Count))
            ws.Name = EXP_PREFIX_SHEET_VOC + strNodeId + "-" + strSubNodeId
            'topic group information
            SetCellValue(ws, 1, 1, EXP_ITEM_TOPIC_GROUP)
            SetCellValue(ws, 1, 2, strNodeId)
            SetCellValue(ws, 1, 2, strNodeName)
            strLog += EXP_ITEM_TOPIC_GROUP + strNodeName + EXP_SUCCESS_MESS + vbCrLf
            'topic information
            SetCellValue(ws, 2, 1, EXP_ITEM_TOPIC)
            SetCellValue(ws, 2, 2, strSubNodeId)
            SetCellValue(ws, 2, 2, strSubNodeName)
            strLog += EXP_ITEM_TOPIC + strSubNodeName + EXP_SUCCESS_MESS + vbCrLf
            'set header text
            SetCellValue(ws, 3, 1, Constants_NguyenNB.S3GT_VOC_KANJI)
            SetCellValue(ws, 3, 2, Constants_NguyenNB.S3GT_VOC_HIRAGANA)
            SetCellValue(ws, 3, 3, Constants_NguyenNB.S3GT_VOC_MEANING)
            SetCellValue(ws, 3, 4, Constants_NguyenNB.S3GT_VOC_HANNOM)
            SetCellValue(ws, 3, 5, Constants_NguyenNB.S3GT_VOC_EXAMPLE)
            currRowIdx = 4
            For Each row In dtVoc.Rows
                SetCellValue(ws, currRowIdx, 1, row(Constants_NguyenNB.S3GT_VOC_KANJI).ToString)
                SetCellValue(ws, currRowIdx, 2, row(Constants_NguyenNB.S3GT_VOC_HIRAGANA).ToString)
                SetCellValue(ws, currRowIdx, 3, row(Constants_NguyenNB.S3GT_VOC_MEANING).ToString)
                SetCellValue(ws, currRowIdx, 4, row(Constants_NguyenNB.S3GT_VOC_HANNOM).ToString)
                SetCellValue(ws, currRowIdx, 5, row(Constants_NguyenNB.S3GT_VOC_EXAMPLE).ToString)
                strLog += EXP_ITEM_VOC + row(S3GT_KAN_KANJI).ToString + EXP_SUCCESS_MESS + vbCrLf
                currRowIdx += 1
                d_pgrValue(1)
                Application.DoEvents()
                'when user press cancel button => interupt the function
                If Not cont Then
                    Utils.SaveTextToFile(strLog, strLogFileName, True)
                    Exit For
                End If
            Next
            Utils.SaveTextToFile(strLog, strLogFileName, True)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            excelApp.Quit()
            ReleaseComObject(excelApp)
            Throw ex
        End Try
    End Sub
    'minhln2
    'add progressbar
    Function ExportVocText(ByVal strFolderPath As String, ByVal dtTopic As DataTable, _
    ByVal d_pgrMax As usrExport.SetPgrMaxValue, ByVal d_pgrValue As usrExport.SetPgrValue) As Boolean
        Dim row As DataRow
        Dim strFilePath As String

        Try

            If Not (strFolderPath.Trim.EndsWith("/") OrElse strFolderPath.Trim.EndsWith("\")) Then
                strFolderPath += Path.DirectorySeparatorChar
            End If

            d_pgrMax(dtTopic.Rows.Count)
            d_pgrValue(0)

            For Each row In dtTopic.Rows

                strFilePath = strFolderPath + row(1) + "_" + row(3) + "_" + Format(System.DateTime.Now, "yyyMMdd_HHmmss") + ".txt"

                SaveTextToFile("", strFilePath, False)
                ExportLineToText(strFilePath, row(0), row(1), row(2), row(3))
                d_pgrValue(1)
                Application.DoEvents()
                'when user press cancel button => interupt the function
                If Not cont Then
                    Return True
                End If
            Next
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End Try
    End Function
    Sub ExportLineToText(ByVal strFileName As String, _
                    ByVal strTopicGroupId As String, _
                    ByVal strTopicGroupName As String, _
                    ByVal strTopicId As String, _
                    ByVal strTopicName As String)
        Dim row As DataRow
        Dim strLine As String
        Dim dtVoc As DataTable
        Try
            strLog = ""
            row = dao.GetTopicById(strTopicGroupId)
            strLine = ""
            strLine = strLine + EXP_PREFIX_SHEET_TOPIC_GROUP + strTopicGroupId + Constants_NguyenNB.SEPERATOR
            strLine = strLine + row(S3GT_TPG_NAME) + Constants_NguyenNB.SEPERATOR
            strLine = strLine + row(S3GT_TPG_DESCRIPTION)
            strLine = strLine + vbCrLf
            strLog += EXP_ITEM_TOPIC_GROUP + row(S3GT_TPG_NAME) + EXP_SUCCESS_MESS + vbCrLf

            row = dao.GetSubTopicById(strTopicId)
            strLine = strLine + EXP_PREFIX_SHEET_TOPIC + strTopicId + Constants_NguyenNB.SEPERATOR
            strLine = strLine + row(S3GT_TPC_NAME) + Constants_NguyenNB.SEPERATOR
            strLine = strLine + row(S3GT_TPC_DESCRIPTION)
            strLine = strLine + vbCrLf
            strLog += EXP_ITEM_TOPIC + row(S3GT_TPC_NAME) + EXP_SUCCESS_MESS + vbCrLf

            dtVoc = dao.GetVoc(strTopicId)
            For Each row In dtVoc.Rows
                strLine += EXP_PREFIX_SHEET_VOC + row(S3GT_VOC_ID).ToString + Constants_NguyenNB.SEPERATOR
                strLine += strTopicId + Constants_NguyenNB.SEPERATOR
                strLine += strTopicName + Constants_NguyenNB.SEPERATOR
                strLine += row(S3GT_VOC_HIRAGANA) + Constants_NguyenNB.SEPERATOR
                strLine += row(S3GT_VOC_KANJI) + Constants_NguyenNB.SEPERATOR
                strLine += row(S3GT_VOC_HANNOM) + Constants_NguyenNB.SEPERATOR
                strLine += row(S3GT_VOC_MEANING) + Constants_NguyenNB.SEPERATOR
                strLine += row(S3GT_VOC_TYPE).ToString
                strLine += row(S3GT_VOC_EXAMPLE) + Constants_NguyenNB.SEPERATOR
                strLine += vbCrLf
                strLog += EXP_ITEM_VOC + row(S3GT_VOC_KANJI) + EXP_SUCCESS_MESS + vbCrLf
            Next
            SaveTextToFile(strLine, strFileName, True)
            Utils.SaveTextToFile(strLog, strLogFileName, True)
        Catch ex As Exception
            Throw ex
        End Try

    End Sub


    'minhln2
    'add progressbar
    Function ExportKanjiExcel(ByVal strFolderPath As String, ByVal dt As DataTable, _
    ByVal strKanjiImgFrom As String, ByVal strKanjiImgTo As String, ByVal d_pgrMax As usrExport.SetPgrMaxValue, _
    ByVal d_pgrValue As usrExport.SetPgrValue) As Boolean
        Dim excelApp As Excel.Application
        Dim wb As Excel.Workbook
        Dim ws As Excel.Worksheet
        Dim row As DataRow
        Dim rowKanji As DataRow
        Dim intCurrRowIdx As Integer
        Dim strImage As String
        Dim strFilePath As String

        Try
            'check if file read only
            If Utils.IsFileCannotAccess(strFolderPath) Then
                Return False
            End If

            If Not (strFolderPath.Trim.EndsWith("/") OrElse strFolderPath.Trim.EndsWith("\")) Then
                strFolderPath += Path.DirectorySeparatorChar
            End If

            strFilePath = strFolderPath + "Kanji_" + Format(System.DateTime.Now, "yyyMMdd_HHmmss") + ".xls"

            excelApp = New Excel.Application

            wb = excelApp.Workbooks.Add
            ws = wb.Sheets(1)
            ws.Name = EXP_SHEET_KANJI

            SetCellValue(ws, 1, 1, Constants_NguyenNB.STR_Kanji)
            SetCellValue(ws, 1, 2, Constants_NguyenNB.STR_HanNom)
            SetCellValue(ws, 1, 3, Constants_NguyenNB.STR_Kunyomi)
            SetCellValue(ws, 1, 4, Constants_NguyenNB.STR_Onyomi)
            SetCellValue(ws, 1, 5, Constants_NguyenNB.STR_Meaning)

            intCurrRowIdx = 2
            'set ProgressBar maximun value = the number of words
            d_pgrMax(dt.Rows.Count)
            'set ProgressBar Value = 0 
            d_pgrValue(0)
            For Each row In dt.Rows
                rowKanji = dao.GetKanjiById(row(Constants_NguyenNB.STR_Kanji_ID))
                If Not rowKanji(Constants_NguyenNB.STR_Kanji).Equals(DBNull.Value) Then
                    SetCellValue(ws, intCurrRowIdx, 1, rowKanji(Constants_NguyenNB.STR_Kanji))
                End If

                If Not rowKanji(Constants_NguyenNB.STR_HanNom).Equals(DBNull.Value) Then
                    SetCellValue(ws, intCurrRowIdx, 2, rowKanji(Constants_NguyenNB.STR_HanNom))
                End If

                If Not rowKanji(Constants_NguyenNB.STR_Kunyomi).Equals(DBNull.Value) Then
                    SetCellValue(ws, intCurrRowIdx, 3, rowKanji(Constants_NguyenNB.STR_Kunyomi))
                End If

                If Not rowKanji(Constants_NguyenNB.STR_Onyomi).Equals(DBNull.Value) Then
                    SetCellValue(ws, intCurrRowIdx, 4, rowKanji(Constants_NguyenNB.STR_Onyomi))
                End If

                If Not rowKanji(Constants_NguyenNB.STR_Meaning).Equals(DBNull.Value) Then
                    SetCellValue(ws, intCurrRowIdx, 5, rowKanji(Constants_NguyenNB.STR_Meaning))
                End If

                strImage = strKanjiImgFrom + "\" + rowKanji(Constants_NguyenNB.STR_Kanji) + IMG_EXTENSION

                strLog = rowKanji(Constants_NguyenNB.STR_Kanji).ToString() + EXP_SUCCESS_MESS + vbCrLf
                If strKanjiImgFrom <> "" Then
                    If File.Exists(strImage) Then
                        File.Copy(strImage, strKanjiImgTo + "\" + rowKanji(Constants_NguyenNB.STR_Kanji) + IMG_EXTENSION, True)
                        strLog += " - " + rowKanji(Constants_NguyenNB.STR_Kanji) + IMG_EXTENSION + EXP_SUCCESS_MESS + vbCrLf
                    Else
                        strLog += " - " + rowKanji(Constants_NguyenNB.STR_Kanji) + IMG_EXTENSION + EXP_IMG_FAIL + vbCrLf
                    End If
                End If

                SaveTextToFile(strLog, strLogFileName, True)
                'increase the value of ProgressBar.
                d_pgrValue(1)
                intCurrRowIdx += 1
                Application.DoEvents()
                'when user press cancel button => interupt the function
                If Not cont Then
                    wb.SaveAs(strFilePath)
                    wb.Close()
                    excelApp.Quit()
                    ReleaseComObject(excelApp)
                    Return True
                End If
                Application.DoEvents()
            Next

            wb.SaveAs(strFilePath)
            wb.Close()
            excelApp.Quit()
            ReleaseComObject(excelApp)
            Process.Start("taskkill", " /f /im EXCEL.EXE")

            Return True
        Catch ex As Exception
            If ex.Message.Substring(0, ERR_MESS_REGION.Length) = ERR_MESS_REGION Then
                MessageBox.Show(MESS_REGION, "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show(ex.Message + "Export kanji excel")
            End If

            If excelApp.Workbooks.Count > 0 Then
                For Each wb In excelApp.Workbooks
                    wb.RejectAllChanges()
                    wb.Close(False)
                Next
            End If
            excelApp.Quit()
            ReleaseComObject(excelApp)
            Return False
        End Try

    End Function

    'minhln2
    'add progress bar
    Function ExportKanjiText(ByVal strFolderPath As String, ByVal dt As DataTable, _
    ByVal strKanjiImgFrom As String, ByVal strKanjiImgTo As String, ByVal d_pgrMax As usrExport.SetPgrMaxValue, _
    ByVal d_pgrValue As usrExport.SetPgrValue) As Boolean
        Dim row As DataRow
        Dim rowKanji As DataRow
        Dim strLine As String = ""
        Dim strImage As String
        Dim strFilePath As String

        'Set Maximum value of progressbar = the number of words
        d_pgrMax(dt.Rows.Count)
        d_pgrValue(0)

        Try

            If Not (strFolderPath.Trim.EndsWith("/") OrElse strFolderPath.Trim.EndsWith("\")) Then
                strFolderPath += Path.DirectorySeparatorChar
            End If

            strFilePath = strFolderPath + "Kanji_" + Format(System.DateTime.Now, "yyyMMdd_HHmmss") + ".txt"


            SaveTextToFile("", strFilePath, False)
            For Each row In dt.Rows
                strLine = ""
                rowKanji = dao.GetKanjiById(row(Constants_NguyenNB.STR_Kanji_ID))
                strLine = strLine + EXP_PREFIX_SHEET_KANJI + row(Constants_NguyenNB.STR_Kanji_ID) + Constants_NguyenNB.SEPERATOR
                If Not rowKanji(Constants_NguyenNB.STR_Kanji).Equals(DBNull.Value) Then
                    strLine = strLine + rowKanji(Constants_NguyenNB.STR_Kanji) + Constants_NguyenNB.SEPERATOR
                Else
                    strLine = strLine + Constants_NguyenNB.SEPERATOR
                End If

                If Not rowKanji(Constants_NguyenNB.STR_HanNom).Equals(DBNull.Value) Then
                    strLine = strLine + rowKanji(Constants_NguyenNB.STR_HanNom) + Constants_NguyenNB.SEPERATOR
                Else
                    strLine = strLine + Constants_NguyenNB.SEPERATOR
                End If

                If Not rowKanji(Constants_NguyenNB.STR_Kunyomi).Equals(DBNull.Value) Then
                    strLine = strLine + rowKanji(Constants_NguyenNB.STR_Kunyomi) + Constants_NguyenNB.SEPERATOR
                Else
                    strLine = strLine + Constants_NguyenNB.SEPERATOR
                End If

                If Not rowKanji(Constants_NguyenNB.STR_Onyomi).Equals(DBNull.Value) Then
                    strLine = strLine + rowKanji(Constants_NguyenNB.STR_Onyomi) + Constants_NguyenNB.SEPERATOR
                Else
                    strLine = strLine + Constants_NguyenNB.SEPERATOR
                End If

                If Not rowKanji(Constants_NguyenNB.STR_Meaning).Equals(DBNull.Value) Then
                    strLine = strLine + rowKanji(Constants_NguyenNB.STR_Meaning) + vbCrLf
                Else
                    strLine = strLine + vbCrLf
                End If

                strLog = rowKanji(Constants_NguyenNB.STR_Kanji).ToString() + EXP_SUCCESS_MESS + vbCrLf

                If strKanjiImgFrom <> "" Then
                    strImage = strKanjiImgFrom + "\" + rowKanji(Constants_NguyenNB.STR_Kanji) + IMG_EXTENSION
                    If File.Exists(strImage) Then
                        File.Copy(strImage, strKanjiImgTo + "\" + rowKanji(Constants_NguyenNB.STR_Kanji) + IMG_EXTENSION, True)
                        strLog += " - " + rowKanji(Constants_NguyenNB.STR_Kanji) + IMG_EXTENSION + EXP_SUCCESS_MESS
                    Else
                        strLog += " - " + rowKanji(Constants_NguyenNB.STR_Kanji) + IMG_EXTENSION + EXP_IMG_FAIL + vbCrLf
                    End If
                End If
                SaveTextToFile(strLine, strFilePath, True)
                SaveTextToFile(strLog, strLogFileName, True)
                'increase progressbar's value.
                d_pgrValue(1)
                Application.DoEvents()
                'when user press cancel button => interupt the function
                If Not cont Then
                    Return True
                End If
            Next
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try

    End Function
    Public Function GetFileContents(ByVal FullPath As String, _
       Optional ByRef ErrInfo As String = "") As String

        Dim strContents As String
        Dim objReader As StreamReader
        Try

            objReader = New StreamReader(FullPath)
            strContents = objReader.ReadToEnd()
            objReader.Close()
            Return strContents
        Catch Ex As Exception
            ErrInfo = Ex.Message
            Return ErrInfo
        End Try
    End Function

    Public Function SaveTextToFile(ByVal strData As String, _
     ByVal FullPath As String, ByVal blnAppend As Boolean, _
       Optional ByVal ErrInfo As String = "") As Boolean

        Dim bAns As Boolean = False
        Dim objReader As StreamWriter
        Try
            objReader = New StreamWriter(FullPath, blnAppend)
            objReader.Write(strData)
            objReader.Close()
            bAns = True
        Catch Ex As Exception
            ErrInfo = Ex.Message

        End Try
        Return bAns
    End Function


End Class

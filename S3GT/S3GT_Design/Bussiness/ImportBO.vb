Imports System.IO
Imports S3GT.Constants_NguyenNB
Public Class ImportBO
    '    Dim excelApp As Excel.Application
    Dim dao As ImportDAO = New ImportDAO
    Dim objTopicGroup As TopicGroupsEntity = New TopicGroupsEntity
    Dim objTopic As TopicsEntity = New TopicsEntity
    Dim objVoc As VocabulariesEntity = New VocabulariesEntity
    'minhln2 - dim to interupt import process
    Dim cont As Boolean = True
    '---------------
    Private strLogFileName As String
    Private strLog As String

    Public Sub SetCancel(ByVal cancel As Boolean)
        cont = cancel
    End Sub

    Public Property LogFileName() As String
        Get
            Return strLogFileName
        End Get
        Set(ByVal value As String)
            strLogFileName = value
        End Set
    End Property
    Public Property LogContent() As String
        Get
            Return strLog
        End Get
        Set(ByVal value As String)
            strLog = value
        End Set
    End Property
    Public Sub New()
        strLog = ""
    End Sub
    Public Sub CreateLog()
        Dim strPath
        strPath = GetPath(Application.ExecutablePath) + "\Log"
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

    Function GetPath(ByVal strPath As String) As String

        strPath.LastIndexOf("\")
        Return strPath.Substring(0, strPath.LastIndexOf("\"))
    End Function
    Function ImportVocText(ByVal strFileName As String, ByVal d_text As usrImport.SetTextCallback, _
    ByVal d_pgrValue As usrImport.SetPgrValue, ByVal d_pgrMax As usrImport.SetPgrMaxValue) As Boolean
        Dim srFileReader As System.IO.StreamReader
        Dim sInputLine As String
        Try

            srFileReader = System.IO.File.OpenText(strFileName)
            'minhln2
            'calculate the maximum value of progressbar
            d_pgrMax(System.Text.RegularExpressions.Regex.Split(srFileReader.ReadToEnd(), Environment.NewLine).Length)
            d_pgrValue(0)
            srFileReader.BaseStream.Seek(0, SeekOrigin.Begin)
            'end
            d_text("Importing...")
            sInputLine = srFileReader.ReadLine()
            ImportLineVocabularyText(sInputLine)
            d_pgrValue(1)
            Do Until sInputLine Is Nothing
                sInputLine = srFileReader.ReadLine()
                If sInputLine <> "" Then
                    ImportLineVocabularyText(sInputLine)
                    d_pgrValue(1)
                    Application.DoEvents()
                End If
            Loop
            srFileReader.Close()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try

    End Function

    Sub ImportLineVocabularyText(ByVal strLine As String)

        Dim arr As String()
        Dim dtTopicGroup As DataTable = New DataTable
        Dim strLog As String

        arr = strLine.Split(Constants_NguyenNB.SEPERATOR)
        If arr.Length >= 3 Then
            'Neu dong lien quan den Topic Group
            If arr(0).ToString.Substring(0, 3).ToUpper = "TPG" Then
                SetTopicGroupEntity(arr, objTopicGroup)
            End If

            'lien quan den topic
            If arr(0).ToString.Substring(0, 3).ToUpper = "TPC" Then
                SetTopicEntity(arr, objTopicGroup, objTopic)
            End If

            'lien quan den vocabulary
            If arr(0).ToString.Substring(0, 3).ToUpper = "VOC" Then
                If arr.Length = 8 Then
                    objVoc.Hiragana = arr(3)
                    objVoc.Kanji = arr(4)
                    objVoc.Hannom = arr(5)
                    objVoc.Meaning = arr(6)
                    objVoc.Type = arr(7)
                    objVoc.Example = arr(8)
                    If Not dao.CheckVocExist(objTopic, objVoc) Then
                        dao.InsertVoc(objTopic, objVoc)
                        strLog = objVoc.Hiragana + " was imported" + vbCrLf
                    Else
                        strLog = objVoc.Hiragana + " existed !" + vbCrLf
                    End If
                    Utils.SaveTextToFile(strLog, strLogFileName, True)
                Else
                    strLog = "Invalid line format, can not import this line" + vbCrLf
                    Utils.SaveTextToFile(strLog, strLogFileName, True)
                End If

            End If
        End If

    End Sub
    'BINHNC1 Recover 
    Function ImportVocExcel(ByVal strFileName As String) As Boolean
        Dim excelApp As Excel.Application = New Excel.Application
        Dim wb As Excel.Workbook
        Dim ws As Excel.Worksheet
        Dim blnResult As Boolean
        Try
            wb = excelApp.Workbooks.Open(strFileName)
            For Each ws In wb.Sheets
                If ws.Name <> Constants_NguyenNB.SHEET_TOPIC_GROUP And _
                ws.Name <> Constants_NguyenNB.SHEET_TOPIC Then
                    strLog = "START READ SHEET: " + ws.Name + vbCrLf
                    blnResult = ImportVoc(ws)
                    Utils.SaveTextToFile(strLog, strLogFileName, True)
                End If
            Next
            excelApp.Quit()
            ReleaseComObject(excelApp)
            Return True
        Catch ex As Exception
            excelApp.Quit()
            ReleaseComObject(excelApp)
            If ex.Message.Substring(0, ERR_MESS_REGION.Length) = ERR_MESS_REGION Then
                MessageBox.Show("Please change regional setting (standard and format) to English")
            Else
                MessageBox.Show(ex.Message + " ImportVocExcel")
            End If
            Return False
        End Try

    End Function

    'BINHNC1
    Function ImportVoc(ByVal ws As Excel.Worksheet) As Boolean
        Dim strTopicGroupName As String
        Dim strTopicGroupDesc As String
        Dim strTopicName As String
        Dim strTopicDesc As String
        Dim dtTopicGroup As DataTable
        Dim dtTopic As DataTable
        ' Dim strLog As String = ""
        Dim objTopicGroup As TopicGroupsEntity = New TopicGroupsEntity
        Dim objTopic As TopicsEntity = New TopicsEntity
        Dim objVoc As VocabulariesEntity = New VocabulariesEntity
        Dim blnOK As Boolean
        Dim intCurrRow As Integer
        Try
            strTopicGroupName = GetCellValue(ws, 1, 2)
            strTopicGroupDesc = GetCellValue(ws, 1, 3)
            If strTopicGroupName = "" Then
                strLog += "Sheet " + ws.Name + ": blank topic group name, skip this sheet  " + vbCrLf
                blnOK = False
            End If

            strTopicName = GetCellValue(ws, 2, 2)
            strTopicDesc = GetCellValue(ws, 2, 3)
            If strTopicName = "" Then
                strLog += "Sheet " + ws.Name + ": blank topic name, skip this sheet " + vbCrLf
                Return False
            End If
            If GetCellValue(ws, 4, 1) = "" And GetCellValue(ws, 4, 2) = "" Then
                strLog += "Sheet " + ws.Name + ": blank vocabulary, stop reading this sheet" + vbCrLf
                Return False
            End If
            If ws.Name.Substring(0, 3).ToUpper <> "VOC" Then
                strLog += "Sheet " + ws.Name + ": invalid name, skip this sheet" + vbCrLf
                Return False
            End If

            dtTopicGroup = dao.GetTopicGroupIdByName(strTopicGroupName.Trim)
            If dtTopicGroup.Rows.Count = 0 Then
                objTopicGroup.TopicGroupName = strTopicGroupName
                objTopicGroup.TopicGroupDescription = strTopicGroupDesc
                If objTopicGroup.TopicGroupName = "" Then
                    ' blnOK = False
                    strLog += "Sheet " + ws.Name + ": Topic group name blank, skip this sheet" + vbCrLf
                    Return False
                End If
            Else
                objTopicGroup.TopicGroupID = dtTopicGroup.Rows(0)(Constants_NguyenNB.S3GT_TPC_GROUP_ID)
            End If
            dtTopic = dao.GetTopicIdByName(objTopicGroup, strTopicName)
            If dtTopic.Rows.Count = 0 Then
                objTopic.TopicGroupID = objTopicGroup.TopicGroupID
                objTopic.TopicName = strTopicName
                objTopic.TopicDescription = strTopicDesc
                If objTopic.TopicName <> "" And objTopic.TopicGroupID.ToString <> "" Then
                    'neu topic group id = 0 co nghia la topic group chua ton tai => tao topic group
                    If objTopic.TopicGroupID = 0 Then
                        dao.InsertTopicGroup(objTopicGroup)
                        'gan topic group id moi tao cho topic entity
                        objTopic.TopicGroupID = objTopicGroup.TopicGroupID
                    End If
                    dao.InsertTopic(objTopic)
                Else
                    'blnOK = False
                    strLog += "Sheet " + ws.Name + ": Topic name blank, skip this sheet" + vbCrLf
                    Return False
                End If
            Else
                objTopic.TopicID = dtTopic.Rows(0)(Constants_NguyenNB.S3GT_TPC_ID)
            End If

            'Neu header ok, xu ly noi dung ben duoi
            intCurrRow = 4

            dao.applyToAll = False
            While GetCellValue(ws, intCurrRow, 1) <> "" Or GetCellValue(ws, intCurrRow, 2) <> ""
                objVoc.Kanji = GetCellValue(ws, intCurrRow, 1)
                objVoc.Hiragana = GetCellValue(ws, intCurrRow, 2)
                objVoc.Meaning = GetCellValue(ws, intCurrRow, 3)
                objVoc.Hannom = GetCellValue(ws, intCurrRow, 4)
                strLog += dao.MergeVoc(objTopic, objVoc)
                intCurrRow += 1
                Application.DoEvents()
            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message + "ImportVoc")
            Return False
        End Try

    End Function


    'minhln2
    'add delegate to manipulate processs bar
    Function ImportVocExcel(ByVal strFileName As String, ByVal d_text As usrImport.SetTextCallback, _
    ByVal d_pgrValue As usrImport.SetPgrValue, ByVal d_pgrMax As usrImport.SetPgrMaxValue) As Boolean
        Dim excelApp As Excel.Application = New Excel.Application
        Dim wb As Excel.Workbook
        Dim ws As Excel.Worksheet
        Dim blnResult As Boolean
        Dim sheetCount As Integer = 0
        Try
            wb = excelApp.Workbooks.Open(strFileName)
            'minhln2
            'calculate the maximum value of progressbar
            For Each ws In wb.Sheets
                If ws.Name <> Constants_NguyenNB.SHEET_TOPIC_GROUP And _
                ws.Name <> Constants_NguyenNB.SHEET_TOPIC Then
                    sheetCount += 1
                End If
            Next
            d_pgrMax(sheetCount * 100)
            For Each ws In wb.Sheets
                If Not cont Then
                    Continue For
                End If
                If ws.Name <> Constants_NguyenNB.SHEET_TOPIC_GROUP And _
                ws.Name <> Constants_NguyenNB.SHEET_TOPIC Then
                    d_text("reading sheet" + ws.Name)
                    strLog = "START READ SHEET: " + ws.Name + vbCrLf
                    blnResult = ImportVoc(ws, d_text, d_pgrValue, d_pgrMax)
                    Utils.SaveTextToFile(strLog, strLogFileName, True)
                End If
            Next
            excelApp.Quit()
            ReleaseComObject(excelApp)
            Return True
        Catch ex As Exception
            excelApp.Quit()
            ReleaseComObject(excelApp)
            If ex.Message.Substring(0, ERR_MESS_REGION.Length) = ERR_MESS_REGION Then
                MessageBox.Show("Please change regional setting (standard and format) to English")
            Else
                MessageBox.Show(ex.Message + " ImportVocExcel")
            End If
            Return False
        End Try

    End Function

    'minhln2
    'add delegate to manipulate process bar
    Function ImportVoc(ByVal ws As Excel.Worksheet, ByVal d_text As usrImport.SetTextCallback, _
    ByVal d_pgrValue As usrImport.SetPgrValue, ByVal d_pgrMax As usrImport.SetPgrMaxValue) As Boolean
        Dim strTopicGroupName As String
        Dim strTopicGroupDesc As String
        Dim strTopicName As String
        Dim strTopicDesc As String
        Dim dtTopicGroup As DataTable
        Dim dtTopic As DataTable
        ' Dim strLog As String = ""
        Dim objTopicGroup As TopicGroupsEntity = New TopicGroupsEntity
        Dim objTopic As TopicsEntity = New TopicsEntity
        Dim objVoc As VocabulariesEntity = New VocabulariesEntity
        Dim blnOK As Boolean = True
        Dim intCurrRow As Integer
        'minhln2
        'Dim count: decide when increase value of progress bar
        Dim count As Single
        Dim dis As Single
        Try
            strTopicGroupName = GetCellValue(ws, 1, 2)
            strTopicGroupDesc = GetCellValue(ws, 1, 3)
            If strTopicGroupName = "" Then
                strLog += "Sheet " + ws.Name + ": blank topic group name, skip this sheet  " + vbCrLf
                blnOK = False
            End If

            strTopicName = GetCellValue(ws, 2, 2)
            strTopicDesc = GetCellValue(ws, 2, 3)
            If strTopicName = "" Then
                strLog += "Sheet " + ws.Name + ": blank topic name, skip this sheet " + vbCrLf
                blnOK = False
            End If
            If GetCellValue(ws, 4, 1) = "" And GetCellValue(ws, 4, 2) = "" Then
                strLog += "Sheet " + ws.Name + ": blank vocabulary, stop reading this sheet" + vbCrLf
                blnOK = False
            End If
            If ws.Name.Substring(0, 3).ToUpper <> "VOC" Then
                strLog += "Sheet " + ws.Name + ": invalid name, skip this sheet" + vbCrLf
                blnOK = False
            End If

            dtTopicGroup = dao.GetTopicGroupIdByName(strTopicGroupName.Trim)
            If dtTopicGroup.Rows.Count = 0 Then
                objTopicGroup.TopicGroupName = strTopicGroupName
                objTopicGroup.TopicGroupDescription = strTopicGroupDesc
                If objTopicGroup.TopicGroupName = "" Then
                    strLog += "Sheet " + ws.Name + ": Topic group name blank, skip this sheet" + vbCrLf
                    blnOK = False
                End If
            Else
                objTopicGroup.TopicGroupID = dtTopicGroup.Rows(0)(Constants_NguyenNB.S3GT_TPC_GROUP_ID)
            End If
            dtTopic = dao.GetTopicIdByName(objTopicGroup, strTopicName)
            If dtTopic.Rows.Count = 0 Then
                objTopic.TopicGroupID = objTopicGroup.TopicGroupID
                objTopic.TopicName = strTopicName
                objTopic.TopicDescription = strTopicDesc
                If objTopic.TopicName <> "" And objTopic.TopicGroupID.ToString <> "" Then
                    'neu topic group id = 0 co nghia la topic group chua ton tai => tao topic group
                    If objTopic.TopicGroupID = 0 Then
                        dao.InsertTopicGroup(objTopicGroup)
                        'gan topic group id moi tao cho topic entity
                        objTopic.TopicGroupID = objTopicGroup.TopicGroupID
                    End If
                    dao.InsertTopic(objTopic)
                Else
                    strLog += "Sheet " + ws.Name + ": Topic name blank, skip this sheet" + vbCrLf
                    blnOK = False
                End If
            Else
                objTopic.TopicID = dtTopic.Rows(0)(Constants_NguyenNB.S3GT_TPC_ID)
            End If

            'Neu header ok, xu ly noi dung ben duoi
            If blnOK Then
                intCurrRow = 4
                While GetCellValue(ws, intCurrRow, 1) <> "" Or GetCellValue(ws, intCurrRow, 2) <> ""
                    intCurrRow += 1
                End While
                dis = 100 / (intCurrRow - 4)

                intCurrRow = 4

                dao.applyToAll = False
                While GetCellValue(ws, intCurrRow, 1) <> "" Or GetCellValue(ws, intCurrRow, 2) <> "" And cont
                    objVoc.Kanji = GetCellValue(ws, intCurrRow, 1)
                    objVoc.Hiragana = GetCellValue(ws, intCurrRow, 2)
                    objVoc.Meaning = GetCellValue(ws, intCurrRow, 3)
                    objVoc.Hannom = GetCellValue(ws, intCurrRow, 4)
                    objVoc.Example = GetCellValue(ws, intCurrRow, 5)
                    strLog += dao.MergeVoc(objTopic, objVoc)
                    intCurrRow += 1
                    count += dis
                    If (count >= 1) Then
                        d_pgrValue(Math.Floor(count))
                        count = count - Math.Floor(count)
                    End If
                    Application.DoEvents()
                End While
                d_pgrValue(1)
            Else
                d_pgrValue(100)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message + "ImportVoc")
            Return False
        End Try

    End Function
    Sub SetTopicGroupEntity(ByVal arr As String(), ByRef objTopicGroup As TopicGroupsEntity)
        Dim dtTopicGroup As DataTable
        'neu khac 3 phan tu hoac khong co Topic group name thi gan topic group ID = 0
        If arr.Length <> 3 Or arr(1).ToString = "" Then
            objTopicGroup.TopicGroupID = 0
        Else
            dtTopicGroup = dao.GetTopicGroupIdByName(arr(1).ToString)
            If dtTopicGroup.Rows.Count > 0 Then
                objTopicGroup.TopicGroupID = dtTopicGroup.Rows(0)(Constants_NguyenNB.S3GT_TPG_ID)
                objTopicGroup.TopicGroupName = dtTopicGroup.Rows(0)(Constants_NguyenNB.S3GT_TPG_NAME)
                objTopicGroup.TopicGroupDescription = dtTopicGroup.Rows(0)(Constants_NguyenNB.S3GT_TPG_DESCRIPTION)
            Else
                objTopicGroup.TopicGroupName = arr(1)
                objTopicGroup.TopicGroupDescription = arr(2)
                dao.InsertTopicGroup(objTopicGroup)
                'dtTopicGroup = dao.GetTopicGroupIdByName(objTopicGroup.TopicGroupName)
                'lay du lieu vua insert vao bang Topic Group gan vao entity
                If dtTopicGroup.Rows.Count > 0 Then
                    objTopicGroup.TopicGroupID = dtTopicGroup.Rows(0)(Constants_NguyenNB.S3GT_TPG_ID)
                    objTopicGroup.TopicGroupName = dtTopicGroup.Rows(0)(Constants_NguyenNB.S3GT_TPG_NAME)
                    objTopicGroup.TopicGroupDescription = dtTopicGroup.Rows(0)(Constants_NguyenNB.S3GT_TPG_DESCRIPTION)
                End If
            End If

        End If

    End Sub

    Sub SetTopicEntity(ByVal arr As String(), _
                        ByVal objTopicGroup As TopicGroupsEntity, _
                        ByRef objTopic As TopicsEntity)
        Dim dtTopic As DataTable

        If arr.Length <> 3 Or arr(1).ToString = "" Then
            objTopic.TopicGroupID = 0
        Else
            dtTopic = dao.GetTopicIdByName(objTopicGroup, arr(1).ToString)
            If dtTopic.Rows.Count > 0 Then
                objTopic.TopicGroupID = dtTopic.Rows(0)(Constants_NguyenNB.S3GT_TPC_GROUP_ID)
                objTopic.TopicName = dtTopic.Rows(0)(Constants_NguyenNB.S3GT_TPC_NAME)
                objTopic.TopicDescription = dtTopic.Rows(0)(Constants_NguyenNB.S3GT_TPC_DESCRIPTION)
                objTopic.TopicID = dtTopic.Rows(0)(Constants_NguyenNB.S3GT_TPC_ID)
            Else
                objTopic.TopicGroupID = objTopicGroup.TopicGroupID
                objTopic.TopicName = arr(1)
                objTopic.TopicDescription = arr(2)
                dao.InsertTopic(objTopic)
                'dtTopic = dao.GetTopicGroupIdByName(objTopic.TopicGroupName)
            End If
        End If
    End Sub

    Function GetCellValue(ByVal ws As Excel.Worksheet, ByVal intRow As Int16, ByVal intCol As Int16)
        'Try
        Return CType(ws.Range(ws.Cells(intRow, intCol), ws.Cells(intRow, intCol)).Value, String)
        'Catch ex As Exception
        'Return ""
        'End Try
    End Function

    'minhln2
    'add progressbar
    Function ImportKanjiExcel(ByVal strFileName As String, _
    ByVal strImgKanjiFrom As String, ByVal d_text As usrImport.SetTextCallback, _
    ByVal d_pgrValue As usrImport.SetPgrValue, ByVal d_pgrMax As usrImport.SetPgrMaxValue)
        Dim excelApp As Excel.Application = New Excel.Application
        Dim wb As Excel.Workbook
        Dim ws As Excel.Worksheet
        Dim objKanji As SingleKanjiEntity = New SingleKanjiEntity
        Dim intCurrRow As Integer
        'Dim strLog As String = ""
        Dim strImage As String = ""
        Dim strImgKanjiTo As String
        Dim blnOk As Boolean = False
        Dim intCount As Integer
        Try

            strLog = ""
            strImgKanjiTo = Utils.GetPath(Application.ExecutablePath) + "\" + Constants_NguyenNB.KANJI_FOLDER
            wb = excelApp.Workbooks.Open(strFileName)
            For Each ws In wb.Sheets
                If ws.Name = "KANJI" Then
                    blnOk = True
                End If
            Next
            If Not blnOk Then
                strLog += "Have no sheet Kanji, can not import." + vbCrLf
                Utils.SaveTextToFile(strLog, strLogFileName, True)
                Return False
            End If
            ws = wb.Sheets("KANJI")
            intCurrRow = 2
            'calculate value of progress bar
            While GetCellValue(ws, intCurrRow, 1) <> ""
                intCurrRow += 1
            End While
            d_pgrMax(intCurrRow - 2)
            d_pgrValue(0) 'ProgressBar.Value = 0
            intCurrRow = 2
            'begin import
            d_text("Importing...")

            While GetCellValue(ws, intCurrRow, 1) <> "" And cont
                objKanji.Kanji = GetCellValue(ws, intCurrRow, 1)
                objKanji.HanNom = GetCellValue(ws, intCurrRow, 2)
                objKanji.Kunyomi = GetCellValue(ws, intCurrRow, 3)
                objKanji.Onyomi = GetCellValue(ws, intCurrRow, 4)
                objKanji.Meaning = GetCellValue(ws, intCurrRow, 5)

                'If Utils.isKanji(objKanji.Kanji.ToString) Then
                If dao.CheckKanjiExist(objKanji.Kanji) Then
                    strLog += objKanji.Kanji + " already existed." + vbCrLf
                Else
                    If dao.InsertKanji(objKanji) Then
                        strLog += objKanji.Kanji + " import succesfull." + vbCrLf
                    Else
                        strLog += objKanji.Kanji + " fail to import." + vbCrLf
                    End If
                End If

                If strImgKanjiFrom <> "" Then
                    strImage = strImgKanjiFrom + "\" + objKanji.Kanji + IMG_EXTENSION
                    If File.Exists(strImage) Then
                        File.Copy(strImage, strImgKanjiTo + "\" + objKanji.Kanji + IMG_EXTENSION, True)
                        strLog += objKanji.Kanji + IMG_EXTENSION + " imported successfully" + vbCrLf
                        'update so ky tu import thanh cong
                        intCount += 1
                    Else
                        strLog += objKanji.Kanji + IMG_EXTENSION + " is not exists, failed to import image " + vbCrLf
                    End If
                End If
                'Else
                'strLog += objKanji.Kanji.ToString + " is not a valid Kanji character." + vbCrLf
                'End If
                'increase value of progress bar
                d_pgrValue(1)
                intCurrRow += 1
                Application.DoEvents()
            End While
            cont = True

            strLog += intCount.ToString + " kanji character(s) was imported."
            wb.Close()
            excelApp.Quit()
            ReleaseComObject(excelApp)
            Utils.SaveTextToFile(strLog, strLogFileName, True)
            Return True
        Catch ex As Exception
            excelApp.Quit()
            ReleaseComObject(excelApp)
            If ex.Message.Substring(0, ERR_MESS_REGION.Length) = ERR_MESS_REGION Then
                MessageBox.Show("Please change regional setting (standard and format) to English")
            Else
                MessageBox.Show(ex.Message + " ImportKanjiExcel")
            End If
            Return False
        End Try

    End Function

    Function ImportKanjiText(ByVal strFileName As String, _
    ByVal strImgKanjiFrom As String, ByVal d_text As usrImport.SetTextCallback, _
    ByVal d_pgrValue As usrImport.SetPgrValue, ByVal d_pgrMax As usrImport.SetPgrMaxValue) As Boolean
        Dim srFileReader As System.IO.StreamReader
        Dim sInputLine As String
        Dim strImgKanjiTo As String
        Dim blnResult As Boolean = True
        Dim intCount As Integer = 0
        Try
            'xoa noi dung file log
            Utils.SaveTextToFile("", strLogFileName, False)
            strImgKanjiTo = Utils.GetPath(Application.ExecutablePath) + "\" + Constants_NguyenNB.KANJI_FOLDER
            srFileReader = System.IO.File.OpenText(strFileName)
            'set Maximum value of progressbar = the number of line in file.
            d_pgrMax(System.Text.RegularExpressions.Regex.Split(srFileReader.ReadToEnd(), Environment.NewLine).Length)
            srFileReader.BaseStream.Seek(0, SeekOrigin.Begin)
            d_pgrValue(0)
            sInputLine = srFileReader.ReadLine()
            d_text("Importing...")
            If sInputLine <> "" Then
                If ImportLineKanjiText(sInputLine, strImgKanjiFrom, strImgKanjiTo) Then
                    intCount += 1
                End If
                d_pgrValue(1)
            End If
            Do Until sInputLine Is Nothing And cont
                sInputLine = srFileReader.ReadLine()
                If sInputLine <> "" Then
                    If ImportLineKanjiText(sInputLine, strImgKanjiFrom, strImgKanjiTo) Then
                        intCount += 1
                    End If
                    d_pgrValue(1)
                    Application.DoEvents()
                End If
            Loop
            strLog = intCount.ToString + " kanji character(s) was imported."
            Utils.SaveTextToFile(strLog, strLogFileName, True)
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    Function ImportLineKanjiText(ByVal strLine As String, ByVal strImgKanjiFrom As String, ByVal strImgKanjiTo As String) As Boolean
        Dim arr As String()
        ' Dim strLog As String
        Dim strImage As String
        Dim blnResult As Boolean = True
        Dim objKanji As SingleKanjiEntity = New SingleKanjiEntity
        Try
            'reset strLog
            strLog = ""
            arr = strLine.Split(Constants_NguyenNB.SEPERATOR)
            If CheckKanjiToImport(arr) Then

                If dao.CheckKanjiExist(arr(1)) Then
                    strLog = arr(1).ToString + " already existed" + vbCrLf
                    blnResult = False
                Else
                    objKanji.Kanji = arr(1)
                    objKanji.HanNom = arr(2)
                    objKanji.Kunyomi = arr(3)
                    objKanji.Onyomi = arr(4)
                    objKanji.Meaning = arr(5)
                    If dao.InsertKanji(objKanji) Then
                        strLog = arr(1).ToString + " imported successful" + vbCrLf
                    Else
                        strLog = arr(1).ToString + " fail to import" + vbCrLf
                    End If

                End If

                If strImgKanjiFrom <> "" Then
                    strImage = strImgKanjiFrom + "\" + arr(1).ToString + IMG_EXTENSION
                    If File.Exists(strImage) Then
                        File.Copy(strImage, strImgKanjiTo + "\" + arr(1).ToString + IMG_EXTENSION, True)
                        strLog += " - " + arr(1).ToString + IMG_EXTENSION + " imported successfully"
                    Else
                        strLog += " - " + arr(1).ToString + IMG_EXTENSION + " is not exists, failed to import image " + vbCrLf
                    End If
                End If
                Utils.SaveTextToFile(strLog, strLogFileName, True)
            Else
                blnResult = False
                Utils.SaveTextToFile(strLog, strLogFileName, True)
            End If
            Return blnResult
        Catch ex As Exception
            MessageBox.Show(ex.Message + " ImportLineKanjiText")
            Return False
        End Try
    End Function
    Function CheckKanjiToImport(ByVal arr As String()) As Boolean
        If arr.Length <> 6 Then
            strLog += "Invalid content" + vbCrLf
            Return False
        End If

        If arr(1).ToString.Trim() = "" Then
            strLog += "Invalid content" + vbCrLf
            Return False
        End If

        If arr(1).IndexOf(" ") > 0 Then
            strLog += "Invalid content" + vbCrLf
            Return False
        End If

        If Not Utils.isKanji(arr(1).ToString) Then
            strLog += arr(1).ToString + ": Invalid kanji character" + vbCrLf
            Return False
        End If

        Return True
    End Function
    Public Function GetFileContents(ByVal strFullPath As String, _
           Optional ByRef ErrInfo As String = "") As String
        Return Utils.GetFileContents(strFullPath)
    End Function
    Public Shared Sub ReleaseComObject(ByRef Reference As Object)
        Try
            Do Until _
             System.Runtime.InteropServices.Marshal.ReleaseComObject(Reference) <= 0
            Loop
        Catch
        Finally
            Reference = Nothing
        End Try
    End Sub
End Class

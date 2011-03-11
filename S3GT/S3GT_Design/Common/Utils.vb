Imports System.IO
Public Class Utils


    Public Enum ModeUpdate As Integer
        Update = 0
        Add = 1
    End Enum

    Public Shared Function GetSameVocabulary(ByVal dataSourceSameVocabulary As DataGridViewRowCollection)
        Dim arrSameVocabulary As New ArrayList
        Dim arrDelete As New ArrayList 'Content delete value
        Dim bFirst As Boolean = True

        Dim i, j As Int32

        For i = 0 To dataSourceSameVocabulary.Count - 1
            For j = i + 1 To dataSourceSameVocabulary.Count - 2
                If dataSourceSameVocabulary.Item(i).Cells(1).Value = dataSourceSameVocabulary.Item(j).Cells(1).Value Then
                    arrSameVocabulary.Add(i)
                    arrSameVocabulary.Add(j)
                End If
            Next
        Next

        'arrSameVocabulary.Sort()
        Dim arrResult As New ArrayList(arrSameVocabulary)
        'i = 0
        'Do While i < arrSameVocabulary.Count - 1
        '    If arrSameVocabulary.Item(i) = arrSameVocabulary.Item(i + 1) Then
        '        arrSameVocabulary.RemoveAt(i)
        '        i = i - 1
        '    End If
        '    i = i + 1
        'Loop
        'Find same value
        For i = 0 To arrSameVocabulary.Count - 1
            For j = i + 1 To arrSameVocabulary.Count - 1
                If arrSameVocabulary.Item(i) = arrSameVocabulary.Item(j) Then
                    arrDelete.Add(j)
                End If
            Next
        Next

        'Remove 
        For i = arrDelete.Count - 1 To 0 Step -1
            arrResult.RemoveAt(arrDelete.Item(i))
        Next

        Return arrResult
    End Function




    ''' <summary>
    ''' Merge cac dong trung nhau
    ''' </summary>
    ''' <param name="arrSameVocabulary">List so thu tu cac hang trung higarana/katagara</param>
    ''' <param name="dataGrid">Grid data user input</param>
    ''' <param name="intType">
    ''' intType = 2: Merge Kanji
    ''' intType = 3: Merge Meaning    ''' 
    ''' </param>
    ''' <returns>Gird data after merge</returns>
    ''' <remarks></remarks>
    Public Shared Function Merge(ByVal arrSameVocabulary As ArrayList, _
                                        ByVal dataGrid As DataGridViewRowCollection, _
                                        ByVal intType As Int32)

        Dim bFirst As Boolean = True ' Gia tri dong dau tien de copy
        Dim i As Int32
        Dim intFirstValue, intSecondValue As Int32
        Dim intMergeRow As Int32 = arrSameVocabulary.Item(0)
        Dim arrDelete As New ArrayList


        'arrSameVocabulary.Sort()
        For i = 0 To arrSameVocabulary.Count - 2
            intFirstValue = GetIntValueInArrayList(arrSameVocabulary, i)
            intSecondValue = GetIntValueInArrayList(arrSameVocabulary, i + 1)

            ' Khong co dong trung nhau
            If dataGrid.Item(intFirstValue).Cells(1).Value <> dataGrid.Item(intSecondValue).Cells(1).Value Then
                bFirst = False ' thay doi gia tri cua dong Merge
                intMergeRow = intSecondValue
            End If

            ''Neu la loai trung nhau moi
            'If bFirst = True Then
            '    bFirst = False
            '    intMergeRow = intFirstValue
            'End If            

            If bFirst = True Then
                arrDelete.Add(intSecondValue)
                dataGrid.Item(intMergeRow).Cells(intType).Value += Constants_LanhVC.STR_COMMA_VALUE + _
                       dataGrid.Item(intSecondValue).Cells(intType).Value
            End If
            bFirst = True

        Next

        'delete row merged
        For i = arrDelete.Count - 1 To 0 Step -1
            dataGrid.RemoveAt(GetIntValueInArrayList(arrDelete, i))
        Next

        Return dataGrid
    End Function

    Public Shared Function GetIntValueInArrayList(ByVal arr As ArrayList, ByVal i As Int32)
        Dim intResult As Int32

        intResult = Int32.Parse(arr.Item(i).ToString)

        Return intResult
    End Function

    Public Shared Function GetType_TextFromInt(ByVal intTypeValue As Integer)
        Dim strResult As String = Constants_LanhVC.STR_BLANK_VALUE

        Select Case intTypeValue
            Case 1
                strResult = Constants_LanhVC.STR_VOC_TYPE_NOUN
            Case 2
                strResult = Constants_LanhVC.STR_VOC_TYPE_PRO
            Case 3
                strResult = Constants_LanhVC.STR_VOC_TYPE_VI
            Case 4
                strResult = Constants_LanhVC.STR_VOC_TYPE_VT
            Case 5
                strResult = Constants_LanhVC.STR_VOC_TYPE_I
            Case 6
                strResult = Constants_LanhVC.STR_VOC_TYPE_NA
            Case 7
                strResult = Constants_LanhVC.STR_VOC_TYPE_PREP
        End Select

        Return strResult

    End Function

    Public Shared Function GetType_IntFromText(ByVal strTypeText As String)
        Dim intResult As Integer = -1

        If strTypeText = Nothing Then
            Return 1
        End If

        Select Case strTypeText
            Case Constants_LanhVC.STR_VOC_TYPE_NOUN
                intResult = 1
            Case Constants_LanhVC.STR_VOC_TYPE_PRO
                intResult = 2
            Case Constants_LanhVC.STR_VOC_TYPE_VI
                intResult = 3
            Case Constants_LanhVC.STR_VOC_TYPE_VT
                intResult = 4
            Case Constants_LanhVC.STR_VOC_TYPE_I
                intResult = 5
            Case Constants_LanhVC.STR_VOC_TYPE_NA
                intResult = 6
            Case Constants_LanhVC.STR_VOC_TYPE_PREP
                intResult = 7
            Case Constants_LanhVC.STR_TEST_ANY
                intResult = 0
            Case Else
                intResult = -1
        End Select

        Return intResult

    End Function
    Public Shared Function Replace(ByVal str As Object)
        Dim temp As String
        Try
            temp = CType(str, String)
            If temp <> Nothing Then
                Return temp.Replace("'", "''")
            Else : Return ""
            End If
        Catch ex As Exception
            Return ""
        End Try

    End Function

    Public Shared Function GetFileContents(ByVal FullPath As String, _
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

    Public Shared Function SaveTextToFile(ByVal strData As String, _
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
    Public Shared Function GetPath(ByVal strPath As String) As String

        strPath.LastIndexOf("\")
        Return strPath.Substring(0, strPath.LastIndexOf("\"))
    End Function

    Public Shared Function IsStringHiragana(ByVal stringTest As String) As Boolean
        Dim checkVal As Boolean
        Dim i As Int32
        'Dim j, k As Int32

        'For i = 0 To stringTest.Length - 1
        'If stringTest(i) = "," Or stringTest(i) = "、" Then
        'k = i
        '
        'For j = i + 1 To stringTest.Length - 1
        'stringTest(k) = stringTest(j)
        'k = k + 1
        'Next
        'End If
        'Next

        stringTest = TrimPunctuation(stringTest)

        For i = 0 To stringTest.Length - 1
            If AscW(stringTest(i)) >= Constants_Kanji_MinhVV1.INT_NUM_MIN_LIMIT_HIRAGANA And AscW(stringTest(i)) <= Constants_Kanji_MinhVV1.INT_NUM_MAX_LIMIT_HIRAGANA Then
                checkVal = True
            Else
                checkVal = False
                Exit For
            End If
        Next

        Return checkVal

    End Function

    Public Shared Function IsStringKatakana(ByVal stringTest As String) As Boolean
        Dim checkVal As Boolean
        Dim i As Int32

        stringTest = TrimPunctuation(stringTest)
        For i = 0 To stringTest.Length - 1
            If AscW(stringTest(i)) >= Constants_Kanji_MinhVV1.INT_NUM_MIN_LIMIT_KATAKANA And AscW(stringTest(i)) <= Constants_Kanji_MinhVV1.INT_NUM_MAX_LIMIT_KATAKANA Then
                checkVal = True
            Else
                checkVal = False
                Exit For
            End If
        Next

        Return checkVal

    End Function

    Public Shared Function IsStringHiraganaKatakana(ByVal stringTest As String) As Boolean
        'GiangNVT modified
        Return True

        'Dim checkVal As Boolean
        'Dim i As Int32
        ''Dim j, k As Int32

        ''For i = 0 To stringTest.Length - 1
        ''If stringTest(i) = "," Or stringTest(i) = "、" Then
        ''k = i
        ''
        ''For j = i + 1 To stringTest.Length - 1
        ''stringTest(k) = stringTest(j)
        ''k = k + 1
        ''Next
        ''End If
        ''Next

        'stringTest = TrimPunctuation(stringTest)
        'For i = 0 To stringTest.Length - 1
        '    If (AscW(stringTest(i)) >= Constants_Kanji_MinhVV1.INT_NUM_MIN_LIMIT_HIRAGANA And AscW(stringTest(i)) <= Constants_Kanji_MinhVV1.INT_NUM_MAX_LIMIT_HIRAGANA) _
        '       Or (AscW(stringTest(i)) >= Constants_Kanji_MinhVV1.INT_NUM_MIN_LIMIT_KATAKANA And AscW(stringTest(i)) <= Constants_Kanji_MinhVV1.INT_NUM_MAX_LIMIT_KATAKANA) Then
        '        checkVal = True

        '    Else
        '        checkVal = False
        '        Exit For
        '    End If
        'Next

        'Return checkVal

    End Function
    Public Shared Function isKanji(ByVal stringTest As String) As Boolean

        'GiangNVT modified
        Return True

        'Dim checkVal1 As Boolean = False 'dam bao ha`m du'ng khi chuoi rong 
        'Dim checkVal2 As Boolean = True 'dam bao ham du'ng trong truong hop toan bo ky tu trong chuoi deu la kanji
        'Dim temp As Int32
        'Dim i As Int32

        ''<<QuanTDA modified on 27/04/2009: change the way to check Kanji string>>
        ''<<a Kanji string is valid when there is at least 1 Kanji character>>
        ''stringTest = Trim(stringTest)
        'stringTest = TrimPunctuation(stringTest)
        ''<<QuanTDA modified on 27/04/2009: change the way to check Kanji string>>
        ''<<a Kanji string is valid when there is at least 1 Kanji character>>

        'For i = 0 To stringTest.Length - 1
        '    temp = AscW(stringTest(i))
        '    If temp >= Constants_Kanji_MinhVV1.INT_NUM_MIN_LIMIT_KANJI And temp <= Constants_Kanji_MinhVV1.INT_NUM_MAX_LIMIT_KANJI Then 'kiem tra kanji don
        '        checkVal1 = True
        '    Else

        '        If (temp >= Constants_Kanji_MinhVV1.INT_NUM_MIN_LIMIT_HIRAGANA And temp <= Constants_Kanji_MinhVV1.INT_NUM_MAX_LIMIT_HIRAGANA) _
        '            Or (temp >= Constants_Kanji_MinhVV1.INT_NUM_MIN_LIMIT_KATAKANA And temp <= Constants_Kanji_MinhVV1.INT_NUM_MAX_LIMIT_KATAKANA) _
        '            Or (temp >= Constants_Kanji_MinhVV1.INT_NUM_MIN_LIMIT_NUM And temp <= Constants_Kanji_MinhVV1.INT_NUM_MAX_LIMIT_NUM) _
        '            Or (temp >= Constants_Kanji_MinhVV1.INT_NUM_MIN_LIMIT_NUM_K And temp <= Constants_Kanji_MinhVV1.INT_NUM_MAX_LIMIT_NUM_K) Then 'chi co the la Hiragana hoac Katakana 
        '            checkVal2 = True
        '        Else
        '            checkVal2 = False
        '            Exit For
        '        End If

        '    End If

        'Next

        'Return checkVal1 And checkVal2

    End Function


    Public Shared Function TrimPunctuation(ByVal strToTrim As String) As String
        Dim arrPunctuation() As String '= {"."_ "/"_ "?"_ ","_ "'"_ ":"_ "("_ ")"_ "["_ "]"_ "。"_ "．"_ "・"_ "？"_ "?"_ "「"_ "」"_ "’"_ "、"_ "（"_ "）"_"~"_"～"}
        Dim strReturn As String

        strReturn = Trim(strToTrim)

        arrPunctuation = CStr(My.Settings.PunctuationList.ToString()).Split(CStr(My.Settings.PunctuationListDelimiter))

        For Each strChar As String In arrPunctuation
            If (strReturn = "" OrElse strReturn = strChar) Then
                Return ""
            End If

            strReturn = Strings.Replace(strReturn, strChar, "")
        Next

        Return strReturn
    End Function


    Public Shared Function ObjectToString(ByVal pObject As Object) As String
        Dim retString As String = Constants_LanhVC.STR_BLANK_VALUE
        If Not pObject Is Nothing AndAlso Not TypeOf (pObject) Is DBNull Then
            retString = pObject.ToString
        End If
        Return retString
    End Function
    Public Shared Function CheckValidLanguage(ByVal strLanguage As String) As Boolean
        Dim isValid As Boolean
        Select Case strLanguage
            Case "Hiragana"
                isValid = True
            Case "Hiragana/Katakana"
                isValid = True
            Case "Han Nom"
                isValid = True
            Case "HanNom"
                isValid = True
            Case "Hannom"
                isValid = True
            Case "Kanji"
                isValid = True
            Case "Meaning"
                isValid = True
            Case "Example"
                isValid = True
            Case Else
                isValid = False
        End Select
        Return isValid
    End Function
    Public Shared Function IsFileCannotAccess(ByVal strFileName As String) As Boolean
        Dim blnOK As Boolean = False
        If File.Exists(strFileName) Then
            If (File.GetAttributes(strFileName) And FileAttributes.ReadOnly) = FileAttributes.ReadOnly Then
                MessageBox.Show(Constants_NguyenNB.ERR_MESS_READONLY, "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                blnOK = True
            Else
                blnOK = False
            End If
        Else
            blnOK = False
        End If
        Return blnOK
    End Function
    Public Shared Function IsFileOpen(ByVal strFilename As String) As Boolean
        Try
            System.IO.File.Open(strFilename, IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.None)
            Return False
        Catch ex As Exception
            Return True
        End Try
    End Function

    Public Shared Function GetJPhonetic(ByVal strInput As String) As String

        If (strInput Is Nothing Or strInput.Length = 0) Then
            Return ""
        End If

        'Dim imeClass As ImeLib.ImeClass = DirectCast(1, ImeLib.ImeClass) 'Japanse case
        Dim imeClass As ImeLib.ImeClass = ImeLib.ImeClass.Japan

        Using ime As New ImeLib.MsImeFacade(imeClass)
            ' Show conversion mode capabilities.
            'txtConvModeCaps.Text = ime.ConversionModeCaps

            Dim req As ImeLib.WinApi.MsIme.Req
            Dim cmodes As ImeLib.WinApi.MsIme.Cmodes

            Select Case imeClass
                Case ImeLib.ImeClass.China
                    req = ImeLib.WinApi.MsIme.Req.Rev
                    cmodes = ImeLib.WinApi.MsIme.Cmodes.PinYin Or ImeLib.WinApi.MsIme.Cmodes.NoInvisibleChar
                    Exit Select
                Case ImeLib.ImeClass.Japan
                    req = ImeLib.WinApi.MsIme.Req.Rev
                    cmodes = ImeLib.WinApi.MsIme.Cmodes.Hangul
                    Exit Select
                Case Else
                    Return strInput
            End Select

            Dim result As String = ""
            Dim index As Integer
            Dim strArray As String()
            strArray = SplitKanjiKatakana(strInput)
            For index = 0 To strArray.Length - 1
                If IsStringKatakana(strArray(index)) Then
                    result += strArray(index)
                Else
                    result += ime.GetJMorphResultString(strArray(index), req, cmodes)
                End If
            Next

            Return result
        End Using
    End Function

    Shared Function SplitKanjiKatakana(ByVal strInput As String) As String()
        Dim result As New ArrayList
        Dim index1 As Integer

        index1 = 0
        While index1 < strInput.Length
            If IsStringKatakana(strInput(index1)) Then
                result.Add(FindKatakana(strInput, index1))
            Else
                result.Add(FindNotKatakana(strInput, index1))
            End If
        End While

        Return DirectCast(result.ToArray(GetType(String)), String())

    End Function

    Shared Function FindNotKatakana(ByVal strInput As String, ByRef index As Integer) As String
        Dim startIndex As Integer = index

        While index < strInput.Length AndAlso Not IsStringKatakana(strInput(index))
            index = index + 1
        End While

        Return strInput.Substring(startIndex, index - startIndex)

    End Function

    Shared Function FindKatakana(ByVal strInput As String, ByRef index As Integer) As String
        Dim startIndex As Integer = index

        While index < strInput.Length AndAlso IsStringKatakana(strInput(index))
            index = index + 1
        End While

        Return strInput.Substring(startIndex, index - startIndex)

    End Function



    Public Shared Function GetHanNom(ByVal strInput As String) As String

        If (strInput Is Nothing Or strInput.Length = 0) Then
            Return ""
        End If

        Dim objKanBO As SingleKanjiBO
        Dim objKanTable As DataTable

        Dim strSQL As String
        Dim strHanNom As String = ""
        Dim charArray() As Char = strInput.ToCharArray
        For i As Integer = 0 To charArray.Length - 1
            If isKanjiCharacter(charArray(i)) Then
                strSQL = Constants_PhatLS.STR_SQL_SINGLE_KANJI_Kanji + charArray(i) + """"
                Try
                    objKanBO = New SingleKanjiBO()
                    objKanTable = objKanBO.GetKanjiTable(strSQL)
                    If Not (objKanTable.Rows.Count = 0) Then
                        If strHanNom.Length > 0 Then
                            strHanNom += " "
                        End If
                        For j As Integer = 0 To objKanTable.Rows.Count - 1
                            If j = 0 Then
                                strHanNom += objKanTable.Rows(j)(Constants_PhatLS.STR_HanNom)
                            Else
                                strHanNom += "(" + objKanTable.Rows(j)(Constants_PhatLS.STR_HanNom) + ")"
                            End If
                        Next
                    End If
                Catch ex As Exception
                    Return "Can't be found"
                    'MessageBox.Show(ex.ToString(), Constants_LanhVC.STR_MSG_ERR_CODING, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            End If
        Next
        Return strHanNom
    End Function

    Public Shared Function isKanjiCharacter(ByVal inputChar As Char) As Boolean
        Dim code As Int32

        code = AscW(inputChar)
        If code >= Constants_Kanji_MinhVV1.INT_NUM_MIN_LIMIT_KANJI And _
                code <= Constants_Kanji_MinhVV1.INT_NUM_MAX_LIMIT_KANJI Then
            Return True
        Else
            Return False
        End If
    End Function

End Class

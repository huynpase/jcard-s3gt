Imports System.IO
Public Class PerformTestBO

    'Property
    Private selectedTopics As ArrayList
    Private strTestLanguage As String
    Private strAnswerLanguage As String
    Private intVocType As Integer
    Private strTestName As String
    Private currTestMode As Integer
    Private listVocabularies As DataTable 'ArrayList
    Private objCurrentQuestion As QuestionEntity
    Private objCurrentTestResult As TestResultEntity
    Private objTestEngine As TestEngine
    Private intTotalTimeLeft As Integer


    Public Property TotalTimeLeft() As String
        Get
            Return intTotalTimeLeft
        End Get
        Set(ByVal value As String)
            intTotalTimeLeft = value
        End Set
    End Property
    Public Property TestLanguage() As String
        Get
            Return strTestLanguage
        End Get
        Set(ByVal value As String)
            strTestLanguage = value
        End Set
    End Property
    Public Property AnswerLanguage() As String
        Get
            Return strAnswerLanguage
        End Get
        Set(ByVal value As String)
            strAnswerLanguage = value
        End Set
    End Property
    Public Property TestMode() As Integer
        Get
            Return currTestMode
        End Get
        Set(ByVal value As Integer)
            currTestMode = value
        End Set
    End Property

    Public Property TopicsList() As ArrayList
        Get
            Return selectedTopics
        End Get
        Set(ByVal value As ArrayList)
            selectedTopics = value
        End Set
    End Property

    Public Property TestVocabularyType() As Integer
        Get
            Return intVocType
        End Get
        Set(ByVal value As Integer)
            intVocType = value
        End Set
    End Property

    Public Property TestName() As String
        Get
            Return strTestName
        End Get
        Set(ByVal value As String)
            strTestName = value
        End Set
    End Property

    Public Function checkAnswer(ByVal answerString As String) As TestResultEntity
        Dim resultIndex As Integer
        resultIndex = objTestEngine.checkAnswer(answerString)
        objCurrentTestResult.updateResultFromLastAnswerCheck(resultIndex)
        Return objCurrentTestResult
    End Function
    'load all word to test for a dictionary
    'only load a word if it have values for test and answer
    Public Function loadVocabulariesFromTopics(ByVal pSelectedTopics As ArrayList) As DataTable
        Dim listGlossaries As DataTable 'ArrayList
        Dim listTempVocabularies As DataTable
        Dim objPerformTestDAO As PerformTestDAO
        objPerformTestDAO = New PerformTestDAO
        'temporary list of testing vocabularies to check the values
        listGlossaries = objPerformTestDAO.loadVocabulariesFromTopics(pSelectedTopics, intVocType)
        'copy both the structure and data of the temporary list of testing vocabularies
        'to the destination list.
        'after checking a word, invalid word will be removed.
        listTempVocabularies = listGlossaries.Copy()
        'just copy the structure
        listTempVocabularies.Rows.Clear()
        For Each rowTestVoc As DataRow In listGlossaries.Rows
            'check if a vocabulary to test have values for test and for answer
            Dim tmpTestVocEntity As TestVocabularyEntity = New TestVocabularyEntity
            tmpTestVocEntity.VocID = CInt(rowTestVoc(Constants_LanhVC.STR_VOC_COLUMN_NAME_VOCABULARY_ID).ToString)
            tmpTestVocEntity.TopicID = CInt(rowTestVoc(Constants_LanhVC.STR_VOC_COLUMN_NAME_TOPIC_ID).ToString)
            tmpTestVocEntity.Hiragana = CStr(rowTestVoc(Constants_LanhVC.STR_VOC_COLUMN_NAME_HIRAGANA).ToString)
            tmpTestVocEntity.Kanji = CStr(rowTestVoc(Constants_LanhVC.STR_VOC_COLUMN_NAME_KANJI).ToString)
            tmpTestVocEntity.Hannom = CStr(rowTestVoc(Constants_LanhVC.STR_VOC_COLUMN_NAME_HANNOM).ToString)
            tmpTestVocEntity.Meaning = CStr(rowTestVoc(Constants_LanhVC.STR_VOC_COLUMN_NAME_MEANING).ToString)
            tmpTestVocEntity.Type = CStr(rowTestVoc(Constants_LanhVC.STR_VOC_COLUMN_NAME_TYPE).ToString)

            If Not Constants_LanhVC.STR_BLANK_VALUE.Equals(tmpTestVocEntity.getDefinitionByLang(strTestLanguage)) _
               AndAlso Not Constants_LanhVC.STR_BLANK_VALUE.Equals(tmpTestVocEntity.getDefinitionByLang(strAnswerLanguage)) Then
                'if value to test is null or value for the correct answer is null
                'remove it from the list of vocabularies to test.
                'Otherwise, take it.
                listTempVocabularies.ImportRow(rowTestVoc)
            End If
        Next
        If listTempVocabularies Is Nothing Then
            'MessageBox.Show(GLOSSARY_LOADING_ERROR_MSG, GLOSSARY_LOADING_ERROR_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Throw New Exception(Constants_LanhVC.STR_TEST_GLOSSARY_LOADING_ERROR_MSG)
        ElseIf listTempVocabularies.Rows.Count < Constants_LanhVC.INT_TEST_MIN_WORD_COUNT Then
            'MessageBox.Show(BELOW_MIN_WORD_COUNT_MSG, WARNING_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Throw New Exception(Constants_LanhVC.STR_TEST_BELOW_MIN_WORD_COUNT_MSG)
            'Else
            'Me.listVocabularies = listGlossaries
            'MessageBox.Show(SUCCESFULLY_LOADING_MSG, LOAD_OK_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return listTempVocabularies
    End Function
    'get the next question
    'must contact a specified TestEngine
    Public Function getNextQuestion() As QuestionEntity
        objCurrentQuestion = New QuestionEntity
        objCurrentQuestion = objTestEngine.getNextQuestion
        Return objCurrentQuestion
    End Function
    'start a new test
    'define new test result
    'and create new test engine base on test mode, test language and transfer current list of words to the test engine
    Public Function startTest() As TestResultEntity
        Try
            listVocabularies = loadVocabulariesFromTopics(selectedTopics)
            objCurrentTestResult = New TestResultEntity
            If currTestMode = 0 Then 'Random Mode
                objTestEngine = New RandomTestEngine(listVocabularies, strTestLanguage, strAnswerLanguage, intVocType)
            Else
                objTestEngine = New FromTopTestEngine(listVocabularies, strTestLanguage, strAnswerLanguage, intVocType)
            End If
        Catch ex As Exception
            Throw ex
        End Try

        Return objCurrentTestResult
    End Function

    Public Sub New(ByVal p_selectedTopics As ArrayList, ByVal p_strTestLanguage As String, ByVal p_strAnswerLanguage As String, ByVal p_strVocType As String, ByVal p_intTestMode As Integer)
        selectedTopics = p_selectedTopics
        strTestLanguage = p_strTestLanguage
        strAnswerLanguage = p_strAnswerLanguage
        intVocType = Utils.GetType_IntFromText(p_strVocType)
        currTestMode = p_intTestMode
        listVocabularies = New DataTable()
    End Sub
    Public Sub New()
        selectedTopics = New ArrayList()
        strTestLanguage = Constants_LanhVC.STR_VOC_COLUMN_NAME_HIRAGANA
        strAnswerLanguage = Constants_LanhVC.STR_VOC_COLUMN_NAME_MEANING
        intVocType = 0 'any type of Vocabulary
        currTestMode = 0 ' Random Mode
        listVocabularies = New DataTable()
    End Sub

    Public Function saveCurrentTest(ByVal pTestName As String, Optional ByVal totalTimeLeft As Integer = -1) As Boolean
        Dim strTestSavedPath As String
        Dim strTestSavedFilePath As String
        Dim saveFile As StreamWriter

        Try
            'get the path of the application
            strTestSavedPath = Directory.GetCurrentDirectory & Constants_LanhVC.STR_TEST_FOLDER_PATH_SEPARATOR & Constants_LanhVC.STR_TEST_SAVED_FOLDER_PATH
            'find the TestSaved folder in the application path
            'if this folder is not created, create it.
            If Not Directory.Exists(strTestSavedPath) Then
                Directory.CreateDirectory(strTestSavedPath)
            End If
            strTestSavedFilePath = strTestSavedPath & Constants_LanhVC.STR_TEST_FOLDER_PATH_SEPARATOR & pTestName & Constants_LanhVC.STR_TEST_SAVED_FILE_EXTENSION
            'If Not File.Exists(strTestSavedFilePath) Then
            'File.Create(strTestSavedFilePath)
            'End If
            'open a file to write with test name as file name
            Dim testInfo As String
            testInfo = saveTestInfoString(totalTimeLeft)
            saveFile = New StreamWriter(strTestSavedFilePath, False)
            saveFile.Write(testInfo)
            saveFile.Close()
            MessageBox.Show("Test has been successfully saved.")
        Catch ex As Exception
            MessageBox.Show("Error in saving Test")
        Finally
        End Try
    End Function
    Public Function loadTest(ByVal pTestName As String) As TestResultEntity
        Dim hashTestInfo As Hashtable
        Dim strLineContent As String
        Dim arrContentInArray As String()
        Dim tempTopicsList As ArrayList
        Dim arrPassedVocIDs As ArrayList
        hashTestInfo = New Hashtable

        Try
            hashTestInfo = loadTestInfo(pTestName)
            ValidTestLoading(hashTestInfo)
            'if no error occurs
            'retrieve saved Topics
            strLineContent = Utils.ObjectToString(hashTestInfo.Item(Constants_LanhVC.STR_TEST_INFO_TOPICS))
            arrContentInArray = strLineContent.Split(Trim(Constants_LanhVC.STR_COMMA_VALUE))
            tempTopicsList = New ArrayList
            For index As Integer = 0 To arrContentInArray.Length - 1
                tempTopicsList.Add(arrContentInArray(index))
            Next
            'retrieve other test information
            strTestLanguage = Utils.ObjectToString(hashTestInfo.Item(Constants_LanhVC.STR_TEST_INFO_TEST_LANGUAGE))
            strAnswerLanguage = Utils.ObjectToString(hashTestInfo.Item(Constants_LanhVC.STR_TEST_INFO_ANSWER_LANGUAGE))
            intVocType = CInt(Utils.ObjectToString(hashTestInfo.Item(Constants_LanhVC.STR_TEST_INFO_VOC_TYPE)))
            currTestMode = CInt(Utils.ObjectToString(hashTestInfo.Item(Constants_LanhVC.STR_TEST_INFO_TEST_MODE)))
            'passed vocabularies
            arrPassedVocIDs = New ArrayList
            strLineContent = Utils.ObjectToString(hashTestInfo.Item(Constants_LanhVC.STR_TEST_INFO_PASSED_VOC_IDS))
            arrContentInArray = strLineContent.Split(Trim(Constants_LanhVC.STR_COMMA_VALUE))
            For index As Integer = 0 To arrContentInArray.Length - 1
                arrPassedVocIDs.Add(arrContentInArray(index))
            Next

            'total time left
            arrPassedVocIDs = New ArrayList
            intTotalTimeLeft = CInt(Utils.ObjectToString(hashTestInfo.Item(Constants_LanhVC.STR_TEST_INFO_TOTAL_TIME_LEFT)))

            'loading vocabularies
            listVocabularies = loadVocabulariesFromTopics(tempTopicsList)
            'check whether the list of Vocabulaires to test has been changed
            strLineContent = Utils.ObjectToString(hashTestInfo.Item(Constants_LanhVC.STR_TEST_INFO_VOC_IDS))
            arrContentInArray = strLineContent.Split(Trim(Constants_LanhVC.STR_COMMA_VALUE))
            Dim isChanged As Boolean = False
            For index As Integer = 0 To arrContentInArray.Length - 1
                Dim strFilter As String = String.Format(Constants_LanhVC.STR_TEST_CHECK_BY_VOCABULARY_ID, arrContentInArray(index))
                If listVocabularies.Select(strFilter).Length <= 0 Then
                    isChanged = True
                    Exit For
                End If
            Next
            'end check


            If isChanged = False Then
                'not change anything
                'get correct selected Topics
                selectedTopics = tempTopicsList
                'the reload retrieved test information
                objCurrentTestResult = New TestResultEntity
                objCurrentTestResult.PassedQuestionNumber = CInt(Utils.ObjectToString(hashTestInfo.Item(Constants_LanhVC.STR_TEST_INFO_NUM_PASSED_QUEST)))
                objCurrentTestResult.RightAnswerNumber = CInt(Utils.ObjectToString(hashTestInfo.Item(Constants_LanhVC.STR_TEST_INFO_NUM_RIGHT_ANS)))
                objCurrentTestResult.WrongAnswerNumber = CInt(Utils.ObjectToString(hashTestInfo.Item(Constants_LanhVC.STR_TEST_INFO_NUM_WRONG_ANS)))
                objCurrentTestResult.UnansweredQuestionNumber = CInt(Utils.ObjectToString(hashTestInfo.Item(Constants_LanhVC.STR_TEST_INFO_NUM_UNANS_QUEST)))
                objCurrentTestResult.calculateResult()

                If currTestMode = 0 Then 'Random Mode
                    objTestEngine = New RandomTestEngine(listVocabularies, strTestLanguage, strAnswerLanguage, intVocType, arrPassedVocIDs)
                Else
                    objTestEngine = New FromTopTestEngine(listVocabularies, strTestLanguage, strAnswerLanguage, intVocType, arrPassedVocIDs)
                End If
            Else
                Dim strWarningMsg As String = "The test question was changed. So that, the test must be restarted."
                strWarningMsg = strWarningMsg & vbCrLf & "You want to do the test from the beginning?"
                If (MessageBox.Show(strWarningMsg, "Warning") = DialogResult.OK) Then
                    'get correct new Topics
                    Dim strFilter As String
                    For Each topicID As Integer In tempTopicsList
                        strFilter = String.Format(Constants_LanhVC.STR_TEST_INFO_FILTER_BY_TOPIC_ID, topicID)
                        If listVocabularies.Select(strFilter).Length > 0 Then 'the corresponding topic is in vocabularies list
                            selectedTopics.Add(topicID)
                        End If
                    Next
                    objCurrentTestResult = New TestResultEntity
                    If currTestMode = 0 Then 'Random Mode
                        objTestEngine = New RandomTestEngine(listVocabularies, strTestLanguage, strAnswerLanguage, intVocType)
                    Else
                        objTestEngine = New FromTopTestEngine(listVocabularies, strTestLanguage, strAnswerLanguage, intVocType)
                    End If
                Else
                    Throw New Exception
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
        Return objCurrentTestResult
    End Function

    Private Function saveTestInfoString(ByVal totalTimeLeft As Integer) As String
        Dim strSaveTestInfoBuilder As System.Text.StringBuilder
        Dim index As Integer
        Dim limitCount As Integer
        Dim VocID As Integer
        Dim arrPassedVocabulariesID As ArrayList
        'save Test information
        '1. selected Topics
        '2. Test language
        '3. Answer language
        '4. Vocabulary Type
        '5. Test mode
        '6. Test Vocabularies ID
        '7. current Test result
        '   5.1 Number of Passed Question
        '   5.2 Number of Right Answer
        '   5.3 Number of Wrong Answer
        '   5.4 Number of Unanswered Question
        'Percentage and Grade will be calculated from the above informationS
        '8. Passed Vocabularies ID

        strSaveTestInfoBuilder = New System.Text.StringBuilder
        'save selected Topics
        strSaveTestInfoBuilder.Append(Constants_LanhVC.STR_TEST_INFO_TOPICS)
        limitCount = selectedTopics.Count - 1
        For index = 0 To limitCount
            strSaveTestInfoBuilder.Append(CInt(selectedTopics(index)))
            If index < limitCount Then
                strSaveTestInfoBuilder.Append(Trim(Constants_LanhVC.STR_COMMA_VALUE))
            End If
        Next
        strSaveTestInfoBuilder.AppendLine()
        'save Test language
        strSaveTestInfoBuilder.Append(Constants_LanhVC.STR_TEST_INFO_TEST_LANGUAGE & strTestLanguage)
        strSaveTestInfoBuilder.AppendLine()
        'save answer language
        strSaveTestInfoBuilder.Append(Constants_LanhVC.STR_TEST_INFO_ANSWER_LANGUAGE & strAnswerLanguage)
        strSaveTestInfoBuilder.AppendLine()
        'save vocabulary type
        strSaveTestInfoBuilder.Append(Constants_LanhVC.STR_TEST_INFO_VOC_TYPE & intVocType)
        strSaveTestInfoBuilder.AppendLine()
        'save test mode
        strSaveTestInfoBuilder.Append(Constants_LanhVC.STR_TEST_INFO_TEST_MODE & currTestMode)
        strSaveTestInfoBuilder.AppendLine()
        'save test vocabularies ID
        strSaveTestInfoBuilder.Append(Constants_LanhVC.STR_TEST_INFO_VOC_IDS)
        limitCount = listVocabularies.Rows.Count - 1
        For index = 0 To limitCount
            VocID = CInt(listVocabularies.Rows(index)(Constants_LanhVC.INT_VOC_DB_COLUMN_VOCID))
            strSaveTestInfoBuilder.Append(VocID)
            If index < limitCount Then
                strSaveTestInfoBuilder.Append(Trim(Constants_LanhVC.STR_COMMA_VALUE))
            End If
        Next
        strSaveTestInfoBuilder.AppendLine()
        'save current test result
        strSaveTestInfoBuilder.Append(Constants_LanhVC.STR_TEST_INFO_NUM_PASSED_QUEST & objCurrentTestResult.PassedQuestionNumber)
        strSaveTestInfoBuilder.AppendLine()
        strSaveTestInfoBuilder.Append(Constants_LanhVC.STR_TEST_INFO_NUM_RIGHT_ANS & objCurrentTestResult.RightAnswerNumber)
        strSaveTestInfoBuilder.AppendLine()
        strSaveTestInfoBuilder.Append(Constants_LanhVC.STR_TEST_INFO_NUM_WRONG_ANS & objCurrentTestResult.WrongAnswerNumber)
        strSaveTestInfoBuilder.AppendLine()
        strSaveTestInfoBuilder.Append(Constants_LanhVC.STR_TEST_INFO_NUM_UNANS_QUEST & objCurrentTestResult.UnansweredQuestionNumber)
        strSaveTestInfoBuilder.AppendLine()
        'save passed vocabulary IDs
        strSaveTestInfoBuilder.Append(Constants_LanhVC.STR_TEST_INFO_PASSED_VOC_IDS)
        arrPassedVocabulariesID = objTestEngine.PassedVocabulariesID
        limitCount = arrPassedVocabulariesID.Count - 1
        For index = 0 To limitCount
            VocID = CInt(arrPassedVocabulariesID(index))
            strSaveTestInfoBuilder.Append(VocID)
            If index < limitCount Then
                strSaveTestInfoBuilder.Append(Trim(Constants_LanhVC.STR_COMMA_VALUE))
            End If
        Next
        strSaveTestInfoBuilder.AppendLine()

        'save total time left
        strSaveTestInfoBuilder.Append(Constants_LanhVC.STR_TEST_INFO_TOTAL_TIME_LEFT & CStr(totalTimeLeft))
        strSaveTestInfoBuilder.AppendLine()

        Return strSaveTestInfoBuilder.ToString
    End Function
    Public Function loadTestInfo(ByVal pTestName As String) As Hashtable
        Dim strTestSavedPath As String
        Dim strTestSavedFilePath As String
        Dim readFile As StreamReader
        Dim strLineContent As String
        Dim strHeader As String
        Dim strContent As String
        Dim hashTestInfo As Hashtable
        hashTestInfo = New Hashtable()
        Try
            'get the path of the application
            strTestSavedPath = Directory.GetCurrentDirectory & Constants_LanhVC.STR_TEST_FOLDER_PATH_SEPARATOR & Constants_LanhVC.STR_TEST_SAVED_FOLDER_PATH
            strTestSavedFilePath = strTestSavedPath & Constants_LanhVC.STR_TEST_FOLDER_PATH_SEPARATOR & pTestName & Constants_LanhVC.STR_TEST_SAVED_FILE_EXTENSION

            'open a file to read with test name as file name
            readFile = New StreamReader(strTestSavedFilePath)
            'read test information
            'read first line
            strLineContent = Utils.ObjectToString(readFile.ReadLine)
            While (Not strLineContent.Equals(Constants_LanhVC.STR_BLANK_VALUE)) 'read until the end of file
                Dim lastIndex As Integer = strLineContent.LastIndexOf(":")
                If lastIndex > 1 Then
                    strHeader = strLineContent.Substring(0, lastIndex + 1)
                    strContent = strLineContent.Substring(lastIndex + 1, strLineContent.Length - lastIndex - 1)
                    hashTestInfo.Add(strHeader, strContent)
                End If
                'read next line
                strLineContent = Utils.ObjectToString(readFile.ReadLine)
            End While
            'MessageBox.Show("Test has been successfully loaded.Please continue the test now.")
        Catch ex As Exception
            Throw ex
        End Try
        Return hashTestInfo
    End Function

    Public Sub ValidTestLoading(ByVal pHashTestInfo As Hashtable)
        Dim strLineContent As String
        Dim arrContentInArray As String()
        'retrieve test information

        If pHashTestInfo Is Nothing Or pHashTestInfo.Count = 0 Then
            Throw New Exception("Error in loading the Test. You must start another Test again.")
        End If

        'check selected Topics
        strLineContent = Utils.ObjectToString(pHashTestInfo.Item(Constants_LanhVC.STR_TEST_INFO_TOPICS))
        arrContentInArray = strLineContent.Split(Trim(Constants_LanhVC.STR_COMMA_VALUE))
        If arrContentInArray.Length <= 0 Then
            Throw New Exception("Error in loading the Test. You must start another Test again.")
        End If

        'check test language
        strLineContent = Utils.ObjectToString(pHashTestInfo.Item(Constants_LanhVC.STR_TEST_INFO_TEST_LANGUAGE))
        If strLineContent.Equals(Constants_LanhVC.STR_BLANK_VALUE) _
           Or Not Utils.CheckValidLanguage(strLineContent) Then
            Throw New Exception("Error in loading the Test. You must start another Test again.")
        End If

        'check test language
        strLineContent = Utils.ObjectToString(pHashTestInfo.Item(Constants_LanhVC.STR_TEST_INFO_ANSWER_LANGUAGE))
        If strLineContent.Equals(Constants_LanhVC.STR_BLANK_VALUE) _
           Or Not Utils.CheckValidLanguage(strLineContent) Then
            Throw New Exception("Error in loading the Test. You must start another Test again.")
        End If

        'check vocabulary type to test
        strLineContent = Utils.ObjectToString(pHashTestInfo.Item(Constants_LanhVC.STR_TEST_INFO_VOC_TYPE))
        If strLineContent.Equals(Constants_LanhVC.STR_BLANK_VALUE) Then
            Throw New Exception("Error in loading the Test. You must start another Test again.")
        Else
            Try
                Dim intTempVocType As Integer = CInt(strLineContent) 'number indicating vocabulary type
                If intTempVocType > 7 Then 'invalid vocabulary type
                    Throw New Exception("Error in loading the Test. You must start another Test again.")
                End If
            Catch ex As Exception
                Throw New Exception("Error in loading the Test. You must start another Test again.")
            End Try
        End If

        'check test mode
        strLineContent = Utils.ObjectToString(pHashTestInfo.Item(Constants_LanhVC.STR_TEST_INFO_VOC_TYPE))
        If strLineContent.Equals(Constants_LanhVC.STR_BLANK_VALUE) Then
            Throw New Exception("Error in loading the Test. You must start another Test again.")
        Else
            Try
                Dim intTestMode As Integer = CInt(strLineContent) 'number indicating test mode
                If intTestMode <> 0 And intTestMode <> 1 Then 'invalid test mode
                    Throw New Exception("Error in loading the Test. You must start another Test again.")
                End If
            Catch ex As Exception
                Throw New Exception("Error in loading the Test. You must start another Test again.")
            End Try
        End If

        'check number of passed question
        Dim intQuestNum As Integer
        Dim intRightAnsNum As Integer
        Dim intWrongAnsNum As Integer
        Dim intUnansQuestNum As Integer
        strLineContent = Utils.ObjectToString(pHashTestInfo.Item(Constants_LanhVC.STR_TEST_INFO_NUM_PASSED_QUEST))
        If strLineContent.Equals(Constants_LanhVC.STR_BLANK_VALUE) Then
            Throw New Exception("Error in loading the Test. You must start another Test again.")
        Else
            Try
                intQuestNum = CInt(strLineContent) 'number indicating vocabulary type
                If intQuestNum < 1 Then 'invalid vocabulary type
                    Throw New Exception("Error in loading the Test. You must start another Test again.")
                End If
            Catch ex As Exception
                Throw New Exception("Error in loading the Test. You must start another Test again.")
            End Try
        End If

        'check number of right answer
        strLineContent = Utils.ObjectToString(pHashTestInfo.Item(Constants_LanhVC.STR_TEST_INFO_NUM_RIGHT_ANS))
        If strLineContent.Equals(Constants_LanhVC.STR_BLANK_VALUE) Then
            Throw New Exception("Error in loading the Test. You must start another Test again.")
        Else
            Try
                intRightAnsNum = CInt(strLineContent)
                If intRightAnsNum < 0 Or intRightAnsNum > intQuestNum Then
                    Throw New Exception("Error in loading the Test. You must start another Test again.")
                End If
            Catch ex As Exception
                Throw New Exception("Error in loading the Test. You must start another Test again.")
            End Try
        End If

        'check number of wrong answer
        strLineContent = Utils.ObjectToString(pHashTestInfo.Item(Constants_LanhVC.STR_TEST_INFO_NUM_WRONG_ANS))
        If strLineContent.Equals(Constants_LanhVC.STR_BLANK_VALUE) Then
            Throw New Exception("Error in loading the Test. You must start another Test again.")
        Else
            Try
                intWrongAnsNum = CInt(strLineContent)
                If intWrongAnsNum < 0 Or intWrongAnsNum > intQuestNum Then
                    Throw New Exception("Error in loading the Test. You must start another Test again.")
                End If
            Catch ex As Exception
                Throw New Exception("Error in loading the Test. You must start another Test again.")
            End Try
        End If
        'check number of unanswered question
        strLineContent = Utils.ObjectToString(pHashTestInfo.Item(Constants_LanhVC.STR_TEST_INFO_NUM_UNANS_QUEST))
        If strLineContent.Equals(Constants_LanhVC.STR_BLANK_VALUE) Then
            Throw New Exception("Error in loading the Test. You must start another Test again.")
        Else
            Try
                intUnansQuestNum = CInt(strLineContent)
                If intUnansQuestNum < 0 Or intUnansQuestNum > intQuestNum Then
                    Throw New Exception("Error in loading the Test. You must start another Test again.")
                End If
            Catch ex As Exception
                Throw New Exception("Error in loading the Test. You must start another Test again.")
            End Try
        End If

        If intQuestNum <> (intRightAnsNum + intWrongAnsNum + intUnansQuestNum) Then
            Throw New Exception("Error in loading the Test. You must start another Test again.")
        End If

        'check selected Vocabularies
        strLineContent = Utils.ObjectToString(pHashTestInfo.Item(Constants_LanhVC.STR_TEST_INFO_VOC_IDS))
        If strLineContent.Equals(Constants_LanhVC.STR_BLANK_VALUE) Then
            Throw New Exception("Error in loading the Test. You must start another Test again.")
        Else
            Dim arrTempVocIDs As String() = strLineContent.Split(Trim(Constants_LanhVC.STR_COMMA_VALUE))
            If arrTempVocIDs.Length <= 0 Then
                Throw New Exception("Error in loading the Test. You must start another Test again.")
            End If
        End If

        'check passed vocabularies
        strLineContent = Utils.ObjectToString(pHashTestInfo.Item(Constants_LanhVC.STR_TEST_INFO_PASSED_VOC_IDS))
        If strLineContent.Equals(Constants_LanhVC.STR_BLANK_VALUE) Then
            Throw New Exception("Error in loading the Test. You must start another Test again.")
        Else
            Dim arrTempPassedVocIDs As String() = strLineContent.Split(Trim(Constants_LanhVC.STR_COMMA_VALUE))
            If arrTempPassedVocIDs.Length <= 0 Then
                Throw New Exception("Error in loading the Test. You must start another Test again.")
            End If
        End If
    End Sub
End Class

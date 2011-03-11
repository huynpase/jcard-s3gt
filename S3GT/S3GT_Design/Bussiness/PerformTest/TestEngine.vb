Public MustInherit Class TestEngine
    Protected tableVocabulariesToTest As DataTable 'ArrayList
    Protected strTestLanguage As String
    Protected strAnswerLanguage As String
    Protected intTestVocabulariesType As Integer

    Protected arrPassedVocabulariesID As ArrayList
    Protected currTestVocabularyEntity As TestVocabularyEntity

    Protected randomEngine As Random
    Protected currQuestionIndex As Integer
    Public Property PassedVocabulariesID() As ArrayList
        Get
            Return arrPassedVocabulariesID
        End Get
        Set(ByVal value As ArrayList)
            arrPassedVocabulariesID = value
        End Set
    End Property

    Public Sub New(ByVal listVocabularies As DataTable, ByVal pTestLanguage As String, ByVal pAnswerLanguage As String, ByVal pTestVocType As Integer)
        tableVocabulariesToTest = listVocabularies
        strTestLanguage = pTestLanguage
        strAnswerLanguage = pAnswerLanguage
        intTestVocabulariesType = pTestVocType

        'initialize all entities marking test status
        arrPassedVocabulariesID = New ArrayList()
        currTestVocabularyEntity = New TestVocabularyEntity
        currQuestionIndex = 0
        randomEngine = New Random()
    End Sub
    Public Property CurrentVocabulary() As TestVocabularyEntity
        Get
            Return currTestVocabularyEntity
        End Get
        Set(ByVal value As TestVocabularyEntity)
            currTestVocabularyEntity = value
        End Set
    End Property
    'MustOverridable procedures
    Public MustOverride Function getNextQuestion() As QuestionEntity

    Public Function checkAnswer(ByVal answerString As String) As Integer
        Dim responseString As String
        Dim checkResultIndex As Integer

        responseString = currTestVocabularyEntity.getDefinitionByLang(strAnswerLanguage)
        If Constants_LanhVC.STR_BLANK_VALUE.Equals(answerString) Then
            checkResultIndex = Constants_LanhVC.INT_TEST_NO_ANSWER_INDEX
        ElseIf answerString.Equals(responseString) Then
            checkResultIndex = Constants_LanhVC.INT_TEST_RIGHT_ANSWER_INDEX
        Else
            checkResultIndex = Constants_LanhVC.INT_TEST_WRONG_ANSWER_INDEX
        End If
        Return checkResultIndex
    End Function

    Protected Function getAnswers() As String()
        Dim answerList(5) As String
        Dim arrChoosenVocabulariesIDs As ArrayList  'one question and 5 answer

        Dim CountOfVocInSameTypeWithTestVoc As Integer  'number of vocabularies in same type with vocabulary choosen as question
        Dim possibleAnswerCount As Integer
        Dim sameTypeFilterView As DataView = tableVocabulariesToTest.DefaultView


        Dim rightAnwerIndex As Integer

        sameTypeFilterView.RowFilter = String.Format(Constants_LanhVC.STR_TEST_FILTER_BY_TYPE, currTestVocabularyEntity.Type)
        If sameTypeFilterView.Count < Constants_LanhVC.INT_TEST_MIN_NUMBER_OF_ANSWER_FOR_A_VOC Then
            'do not get answers based on question vocabulary type
            sameTypeFilterView.RowFilter = Constants_LanhVC.STR_BLANK_VALUE
        End If

        CountOfVocInSameTypeWithTestVoc = sameTypeFilterView.Count
        If CountOfVocInSameTypeWithTestVoc < Constants_LanhVC.INT_TEST_MAX_ANSWER_BY_QUESTION_INDEX Then
            possibleAnswerCount = CountOfVocInSameTypeWithTestVoc
        Else
            possibleAnswerCount = Constants_LanhVC.INT_TEST_MAX_ANSWER_BY_QUESTION_INDEX
        End If
        arrChoosenVocabulariesIDs = New ArrayList()
        arrChoosenVocabulariesIDs.Add(currTestVocabularyEntity.VocID)

        'get 5 answers for this question
        rightAnwerIndex = randomEngine.Next(Constants_LanhVC.INT_TEST_FIRST_ANSWER_OF_QUESTION_INDEX, possibleAnswerCount) 'MAX_ANSWER_BY_QUESTION_INDEX

        For i As Integer = Constants_LanhVC.INT_TEST_FIRST_ANSWER_OF_QUESTION_INDEX To Constants_LanhVC.INT_TEST_MAX_ANSWER_BY_QUESTION_INDEX
            If i = rightAnwerIndex Then
                'this answer is right answer of the question
                answerList(i - 1) = currTestVocabularyEntity.getDefinitionByLang(strAnswerLanguage)
            Else
                If i <= possibleAnswerCount Then
                    'other answer
                    Dim isDuplicateWord As Boolean 'newly defined word to get answer was not got before
                    Dim currAnsWordIndex As Integer
                    Dim tmpWordObj As TestVocabularyEntity = New TestVocabularyEntity  '= arrVocabulariesToTest.Item(currAnsWordIndex)
                    Do
                        isDuplicateWord = False 'newly defined word to get answer was not get before
                        currAnsWordIndex = randomEngine.Next(CountOfVocInSameTypeWithTestVoc - 1) 'among the vocabularies of same type with the question only 'tableVocabulariesToTest.Rows.Count - 1
                        tmpWordObj = GetVocabularyByIndex(sameTypeFilterView, currAnsWordIndex)
                        If Not tmpWordObj Is Nothing AndAlso (arrChoosenVocabulariesIDs.IndexOf(tmpWordObj.VocID) >= 0) Then
                            isDuplicateWord = True
                        End If
                    Loop While isDuplicateWord = True

                    answerList(i - 1) = tmpWordObj.getDefinitionByLang(strAnswerLanguage)
                    'index in the answerList is the same as choosenWordIndex array's minus by 1
                    'because choosenWordIndex array involves current question index
                    arrChoosenVocabulariesIDs.Add(tmpWordObj.VocID)
                Else
                    answerList(i - 1) = Constants_LanhVC.STR_BLANK_VALUE
                End If
            End If
        Next
        Return answerList
    End Function

    Protected Function GetTestVocabularyByIndex(ByVal testVocIndex As Integer) As TestVocabularyEntity
        Dim TestVocEntity As TestVocabularyEntity
        TestVocEntity = New TestVocabularyEntity
        Try
            Dim rowTestVoc As DataRow = tableVocabulariesToTest.Rows(testVocIndex)
            If Not rowTestVoc Is Nothing Then
                TestVocEntity.VocID = CInt(rowTestVoc.Item(Constants_LanhVC.STR_VOC_COLUMN_NAME_VOCABULARY_ID).ToString)
                TestVocEntity.TopicID = CInt(rowTestVoc.Item(Constants_LanhVC.STR_VOC_COLUMN_NAME_TOPIC_ID).ToString)
                TestVocEntity.Hiragana = CStr(rowTestVoc.Item(Constants_LanhVC.STR_VOC_COLUMN_NAME_HIRAGANA).ToString)
                TestVocEntity.Kanji = CStr(rowTestVoc.Item(Constants_LanhVC.STR_VOC_COLUMN_NAME_KANJI).ToString)
                TestVocEntity.Hannom = CStr(rowTestVoc.Item(Constants_LanhVC.STR_VOC_COLUMN_NAME_HANNOM).ToString)
                TestVocEntity.Meaning = CStr(rowTestVoc.Item(Constants_LanhVC.STR_VOC_COLUMN_NAME_MEANING).ToString)
                TestVocEntity.Type = CInt(rowTestVoc.Item(Constants_LanhVC.STR_VOC_COLUMN_NAME_TYPE).ToString)
            End If
        Catch ex As Exception
            TestVocEntity = Nothing
        End Try
        Return TestVocEntity
    End Function

    Protected Function GetVocabularyByIndex(ByVal sameTypeView As DataView, ByVal currAnsWordIndex As Integer) As TestVocabularyEntity
        Dim TestVocEntity As TestVocabularyEntity
        TestVocEntity = New TestVocabularyEntity
        Try
            Dim rowTestVoc As DataRowView = sameTypeView.Item(currAnsWordIndex) 'tableVocabulariesToTest.Rows(currAnsWordIndex)
            If Not rowTestVoc Is Nothing Then
                TestVocEntity.VocID = CInt(rowTestVoc.Item(Constants_LanhVC.STR_VOC_COLUMN_NAME_VOCABULARY_ID).ToString)
                TestVocEntity.TopicID = CInt(rowTestVoc.Item(Constants_LanhVC.STR_VOC_COLUMN_NAME_TOPIC_ID).ToString)
                TestVocEntity.Hiragana = CStr(rowTestVoc.Item(Constants_LanhVC.STR_VOC_COLUMN_NAME_HIRAGANA).ToString)
                TestVocEntity.Kanji = CStr(rowTestVoc.Item(Constants_LanhVC.STR_VOC_COLUMN_NAME_KANJI).ToString)
                TestVocEntity.Hannom = CStr(rowTestVoc.Item(Constants_LanhVC.STR_VOC_COLUMN_NAME_HANNOM).ToString)
                TestVocEntity.Meaning = CStr(rowTestVoc.Item(Constants_LanhVC.STR_VOC_COLUMN_NAME_MEANING).ToString)
                TestVocEntity.Type = CInt(rowTestVoc.Item(Constants_LanhVC.STR_VOC_COLUMN_NAME_TYPE).ToString)
            End If
        Catch ex As Exception
            TestVocEntity = Nothing
        End Try
        Return TestVocEntity
    End Function

End Class


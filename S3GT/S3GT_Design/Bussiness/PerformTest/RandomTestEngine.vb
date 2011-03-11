Public Class RandomTestEngine
    Inherits TestEngine
    Dim remainTestVocabularies As DataTable
    'Property and method declarations
    Public Sub New(ByVal listVocabularies As DataTable, ByVal pTestLanaguage As String, ByVal pAnswerLanguage As String, ByVal pTestVocType As Integer)
        MyBase.New(listVocabularies, pTestLanaguage, pAnswerLanguage, pTestVocType)
        remainTestVocabularies = tableVocabulariesToTest.Copy
    End Sub
    Public Sub New(ByVal listVocabularies As DataTable, ByVal pTestLanaguage As String, ByVal pAnswerLanguage As String, ByVal pTestVocType As Integer, ByVal pArrPassedVocIDs As ArrayList)
        MyBase.New(listVocabularies, pTestLanaguage, pAnswerLanguage, pTestVocType)
        remainTestVocabularies = tableVocabulariesToTest.Copy
        arrPassedVocabulariesID = pArrPassedVocIDs
        removePassedVocabulariesFromTest()
    End Sub
    Public Sub removePassedVocabulariesFromTest() 'from list of passed Vocabularies ID
        Dim strFilter As String
        Dim currRow As DataRow
        For Each vocID As Integer In arrPassedVocabulariesID
            strFilter = String.Format(Constants_LanhVC.STR_TEST_CHECK_BY_VOCABULARY_ID, vocID)
            currRow = remainTestVocabularies.Select(strFilter)(0)
            remainTestVocabularies.Rows.Remove(currRow)
        Next
    End Sub
    Public Overrides Function getNextQuestion() As QuestionEntity
        Dim questWordObj As TestVocabularyEntity = New TestVocabularyEntity
        Dim questionIndex As Integer
        Dim questObj As QuestionEntity = New QuestionEntity
        'get a random word to ask
        If remainTestVocabularies.Rows.Count >= 1 Then 'arrPassedVocabulariesID.Count <= tableVocabulariesToTest.Rows.Count
            If remainTestVocabularies.Rows.Count = 1 Then
                questWordObj = GetVocabularyByIndex(remainTestVocabularies.DefaultView, 0)
            Else
                'Do
                questionIndex = randomEngine.Next(remainTestVocabularies.Rows.Count - 1) 'tableVocabulariesToTest.Rows.Count - 1
                questWordObj = GetVocabularyByIndex(remainTestVocabularies.DefaultView, questionIndex) 'arrVocabulariesToTest.Item(questionIndex)
                'Loop While (Not questWordObj Is Nothing AndAlso arrPassedVocabulariesID.IndexOf(questWordObj.VocID) >= 0)
            End If

            'if the vocabulary to test is found
            If Not questWordObj Is Nothing Then
                'store the current word to test
                currTestVocabularyEntity = questWordObj 'arrVocabulariesToTest.Item(questionIndex)

                'create the question object including question word and its answers
                questObj.Question = questWordObj.getDefinitionByLang(strTestLanguage)
                questObj.CorrectAnswer = questWordObj.getDefinitionByLang(strAnswerLanguage)
                'get 5 answers for this question
                Dim answerList As String() = getAnswers()
                questObj.setListOfAnswers(answerList)
                'record this question as passed question
                arrPassedVocabulariesID.Add(questWordObj.VocID)
                remainTestVocabularies.Rows.RemoveAt(questionIndex)
            Else
                questObj = Nothing
            End If
        Else
            questObj = Nothing
        End If
            Return questObj
    End Function
    'Other code

End Class

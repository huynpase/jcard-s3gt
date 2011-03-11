Public Class FromTopTestEngine
    Inherits TestEngine
    Public Sub New(ByVal listVocabularies As DataTable, ByVal pTestLanguage As String, ByVal pAnswerLanguage As String, ByVal pTestVocType As Integer)
        MyBase.New(listVocabularies, pTestLanguage, pAnswerLanguage, pTestVocType)
    End Sub
    Public Sub New(ByVal listVocabularies As DataTable, ByVal pTestLanguage As String, ByVal pAnswerLanguage As String, ByVal pTestVocType As Integer, ByVal pArrVocIDs As ArrayList)
        MyBase.New(listVocabularies, pTestLanguage, pAnswerLanguage, pTestVocType)
        arrPassedVocabulariesID = pArrVocIDs
        currQuestionIndex = arrPassedVocabulariesID.Count - 1
    End Sub
    Public Overrides Function getNextQuestion() As QuestionEntity
        Dim questObj As QuestionEntity
        'get next word to ask
        If currQuestionIndex < (tableVocabulariesToTest.Rows.Count) Then
            Dim questWordObj As TestVocabularyEntity = New TestVocabularyEntity  'arrVocabulariesToTest.Rows(currQuestionIndex)
            questWordObj = GetTestVocabularyByIndex(currQuestionIndex)
            If Not questWordObj Is Nothing Then
                'store the current word to test
                currTestVocabularyEntity = questWordObj
                currQuestionIndex += 1 'switch to next question

                'create the question object including question word and its answers
                questObj = New QuestionEntity
                questObj.Question = questWordObj.getDefinitionByLang(strTestLanguage)
                questObj.CorrectAnswer = questWordObj.getDefinitionByLang(strAnswerLanguage)
                'get 5 answers for this questions
                Dim answerList As String() = getAnswers()
                questObj.setListOfAnswers(answerList)
            Else
                questObj = Nothing
            End If
        Else
            questObj = Nothing
        End If
            Return questObj
    End Function
End Class


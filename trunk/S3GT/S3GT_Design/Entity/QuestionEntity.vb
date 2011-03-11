Public Class QuestionEntity
    Private questionString As String
    Public Property Question() As String
        Get
            Return questionString
        End Get
        Set(ByVal value As String)
            questionString = value
        End Set
    End Property
    Private ReadOnly answerList(5) As String
    Public ReadOnly Property ListOfAnswers() As String()
        Get
            Return answerList
        End Get
    End Property
    Public Sub setListOfAnswers(ByVal answerArray() As String)
        Dim i As Integer
        For i = 0 To answerList.Length - 1
            answerList(i) = answerArray(i)
        Next
    End Sub
    Private correctAnswerString As String
    Public Property CorrectAnswer() As String
        Get
            Return correctAnswerString
        End Get
        Set(ByVal value As String)
            correctAnswerString = value
        End Set
    End Property

End Class


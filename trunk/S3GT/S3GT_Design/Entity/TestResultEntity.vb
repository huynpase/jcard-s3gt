Public Class TestResultEntity
    'Constants
    'Const MISSED As Integer = 3
    'Const RIGHT_ANSWER As Integer = 1
    'Const WRONG_ANSWER As Integer = 2
    'Const NULL_ANSWER As Integer = 0
    Const PERFECT_GRADE As String = "Perfect"
    Const EXCELLENT_GRADE As String = "Excellent"
    Const GOOD_GRADE As String = "Good"
    Const RATHER_GOOD_GRADE As String = "Rather"
    Const AVERAGE_GRADE As String = "Average"
    Const FAIL_GRADE As String = "Fail"

    Private passedQuestionNo As Integer
    Public Property PassedQuestionNumber() As Integer
        Get
            Return passedQuestionNo
        End Get
        Set(ByVal value As Integer)
            passedQuestionNo = value
        End Set
    End Property
    Private rightAnswerNo As Integer
    Public Property RightAnswerNumber() As Integer
        Get
            Return rightAnswerNo
        End Get
        Set(ByVal value As Integer)
            rightAnswerNo = value
        End Set
    End Property
    Private wrongAnswerNo As Integer
    Public Property WrongAnswerNumber() As Integer
        Get
            Return wrongAnswerNo
        End Get
        Set(ByVal value As Integer)
            wrongAnswerNo = value
        End Set
    End Property
    Private unansweredQuestNumber As Integer
    Public Property UnansweredQuestionNumber() As Integer
        Get
            Return unansweredQuestNumber
        End Get
        Set(ByVal value As Integer)
            unansweredQuestNumber = value
        End Set
    End Property
    Private percentageNumber As Integer
    Public Property Percentage() As Integer
        Get
            Return percentageNumber
        End Get
        Set(ByVal value As Integer)
            percentageNumber = value
        End Set
    End Property
    Private currGradeString As String
    Public Property Grade() As String
        Get
            Return currGradeString
        End Get
        Set(ByVal value As String)
            currGradeString = value
        End Set
    End Property
    Private lastAnswerStatus As Integer
    Public Property LastAnswerResult() As Integer
        Get
            Return lastAnswerStatus
        End Get
        Set(ByVal value As Integer)
            lastAnswerStatus = value
        End Set
    End Property
    Private intMarkPerQuestion As Integer
    Public Property MarkPerQuestion() As Integer
        Get
            Return intMarkPerQuestion
        End Get
        Set(ByVal value As Integer)
            intMarkPerQuestion = value
        End Set
    End Property
    Private intCurrentMark As Integer
    Public Property CurrentMark() As Integer
        Get
            Return intCurrentMark
        End Get
        Set(ByVal value As Integer)
            intCurrentMark = value
        End Set
    End Property

    'Private totalTimeLeft As Integer
    'Public Property TotalTimeLeftValue() As Integer
    '    Get
    '        Return TotalTimeLeft
    '    End Get
    '    Set(ByVal value As Integer)
    '        totalTimeLeft = value
    '    End Set
    'End Property

    Public Sub New()
        passedQuestionNo = 0
        rightAnswerNo = 0
        wrongAnswerNo = 0
        unansweredQuestNumber = 0
        percentageNumber = 0
        currGradeString = ""
        intCurrentMark = 1000
    End Sub
    Public Sub updateResultFromLastAnswerCheck(ByVal result As Integer) '0: unanswered, 1: right, 2:wrong
        lastAnswerStatus = result
        passedQuestionNo += 1
        Select Case result
            Case Constants_LanhVC.INT_TEST_NO_ANSWER_RESULT : unansweredQuestNumber += 1
            Case Constants_LanhVC.INT_TEST_RIGHT_RESULT : rightAnswerNo += 1
            Case Constants_LanhVC.INT_TEST_WRONG_RESULT : wrongAnswerNo += 1
        End Select
        calculateResult()
    End Sub
    Public Sub calculateResult()
        'update Percentage quotient
        percentageNumber = CInt((rightAnswerNo / passedQuestionNo) * 100)

        'update Grade
        Select Case percentageNumber
            Case 100 : currGradeString = PERFECT_GRADE
            Case Is >= 90 : currGradeString = EXCELLENT_GRADE
            Case Is >= 80 : currGradeString = GOOD_GRADE
            Case Is >= 70 : currGradeString = RATHER_GOOD_GRADE
            Case Is >= 60 : currGradeString = AVERAGE_GRADE
            Case Else : currGradeString = FAIL_GRADE
        End Select
    End Sub

    Public Sub updateResultSpecial(ByVal result As Integer) '0: unanswered, 1: right, 2:wrong
        lastAnswerStatus = result
        passedQuestionNo += 1
        Select Case result
            Case Constants_LanhVC.INT_TEST_MISSED_RESULT : rightAnswerNo += 1
                wrongAnswerNo -= 1
                intCurrentMark += intMarkPerQuestion
            Case Constants_LanhVC.INT_TEST_RIGHT_RESULT : rightAnswerNo += 1
            Case Constants_LanhVC.INT_TEST_WRONG_RESULT : wrongAnswerNo += 1
                intCurrentMark -= intMarkPerQuestion
        End Select
    End Sub
End Class


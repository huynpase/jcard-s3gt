Public Class usrPerformSpecialTest
    Dim performTestBO As PerformTestBO
    Dim objTestResult As TestResultEntity
    Dim objQuestion As QuestionEntity
    Dim arrCharacterForm As ArrayList
    Dim arrQuestionSize As ArrayList
    Dim intQuestionRemainSecond As Integer
    Dim intTotalRemainSecond As Integer
    Dim intInitTimeInteval As Integer
    Dim selectedTopics As ArrayList
    Dim strTestLanguage As String
    Dim strAnswerLanguage As String
    Dim strVocType As String
    Dim intTestMode As Integer
    Dim boolHaveUserOptionForAnswer As Boolean
    Dim radioCurrSelAnswer As RadioButton
    Dim blnTestWithTotalTime As Boolean

    Dim colorDialog As ColorDialog

    Dim blnTotalTimerPaused As Boolean
    Dim blnQuestionTimerPaused As Boolean

    Dim intCurrentMark As Integer
    Dim blnWaitingForDecision As Boolean
    Dim blnWaitingForDecisionPassed As Boolean
    Dim intWaitingForDecisionTime As Integer = 3

    Dim wrongSplash As SplashWrong
    Dim correctSplash As SplashCorrect

    Public blnTesting As Boolean


    Private Sub usrPerformTest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        performTestBO = Nothing
        DisplayControlsInitialStatus()
        LoadTopicsToTree()
        BindDataToCombo()
    End Sub


    Private Sub finishTest()
        performTestBO = Nothing

        'enable controls
        TableLayoutPanel4.Enabled = True
        btnStartTest.Enabled = True

        'disabled controls
        btnRestart.Enabled = False
        btnFinishTest.Enabled = False
        btnPause.Enabled = False
        'TableLayoutPanel3.Enabled = False

        'Hide total timer
        If (Not blnTestWithTotalTime) Then
            lblTotalTimeLeftLabel.Visible = False
            lblTotalTimeLeftValue.Visible = False
        Else
            timerTotalAnswerTime.Stop()
            lblTotalTimeLeftValue.Text = "0:00"
        End If
        lblClockDisplay.Text = "0"

        blnTesting = False
    End Sub

    Private Sub DisplayControlsInitialStatus()
        'enabled controls
        'grbTopicsTree.Enabled = True
        'grbTestLang.Enabled = True
        'grbAnswerLang.Enabled = True
        'grbVocType.Enabled = True
        'grbTestMode.Enabled = True
        'grbControls.Enabled = True
        'btnStartTest.Enabled = True
        'grpboxQuestionTime.Enabled = True
        'gbTotalTime.Enabled = True

        'disabled controls
        btnRestart.Enabled = False
        btnFinishTest.Enabled = False
        btnPause.Enabled = False

        grbAnswers.Enabled = False
        grbAnswers.Enabled = False

        txtTotalTime.Text = "5"
        txtQuestTime.Text = "8"
        txtMarkPerQuestion.Text = "25"
        If (chkboxTotalTime.Checked) Then
            txtTotalTime.Enabled = True
        Else
            txtTotalTime.Enabled = False
        End If

        'Hide total timer
        lblTotalTimeLeftLabel.Visible = False
        lblTotalTimeLeftValue.Visible = False
        lblClockDisplay.Text = "0"

        'reset timer
        timerAnswerTime.Interval = Constants_LanhVC.INT_TEST_TIMER_ONE_SECOND  'change status after 1 second
        timerTotalAnswerTime.Interval = Constants_LanhVC.INT_TEST_TIMER_ONE_SECOND

    End Sub
    Private Sub LoadTopicsToTree()
        Dim tableTopicGroup As DataTable ' to get Topic Group list
        Dim tableTopic As DataTable 'to get Topic list
        Dim topicGroupsBO As TopicGroupsBO
        Dim topicBO As TopicsBO

        'init
        topicGroupsBO = New TopicGroupsBO
        topicBO = New TopicsBO
        'clear old items
        treeTopics.Nodes.Clear()
        'get list of Topic Groups
        tableTopicGroup = topicGroupsBO.GetTopicGroupsTable
        'get list of topics
        tableTopic = topicBO.GetTopicsTable


        If tableTopicGroup.Rows.Count > Constants_LanhVC.INT_NO_RECORD Then
            'bind Topic Groups list with TreeView
            Dim rowTopicGroup As DataRow
            Dim nodeTopicGroup As TreeNode
            For Each rowTopicGroup In tableTopicGroup.Rows
                nodeTopicGroup = New TreeNode
                nodeTopicGroup.Name = CStr(rowTopicGroup(Constants_LanhVC.STR_TPG_COLUMN_NAME_TOPIC_GROUP_ID))
                Dim nodeText As String = Constants_LanhVC.STR_TEST_NO_TOPIC_GROUP_NAME
                If CStr(rowTopicGroup(Constants_LanhVC.STR_TPG_COLUMN_NAME_TOPIC_GROUP_NAME)) <> Constants_LanhVC.STR_BLANK_VALUE Then
                    nodeText = CStr(rowTopicGroup(Constants_LanhVC.STR_TPG_COLUMN_NAME_TOPIC_GROUP_NAME))
                End If
                nodeTopicGroup.Text = nodeText
                'bind Topics belonging to this Topic Group with it
                tableTopic.DefaultView.RowFilter = String.Format(Constants_LanhVC.STR_TPC_FILTER_BY_TOPIC_GROUP_ID, _
                                                                 rowTopicGroup(Constants_LanhVC.STR_TPG_COLUMN_NAME_TOPIC_GROUP_ID))
                If tableTopic.DefaultView.Count > Constants_LanhVC.INT_NO_RECORD Then
                    Dim rowTopicView As DataRowView
                    Dim nodeTopic As TreeNode
                    For i As Integer = 0 To tableTopic.DefaultView.Count - 1
                        rowTopicView = tableTopic.DefaultView.Item(i)
                        nodeTopic = New TreeNode
                        nodeTopic.Name = rowTopicView.Row(Constants_LanhVC.STR_TPC_COLUMN_NAME_TOPIC_ID)
                        nodeTopic.Text = rowTopicView.Row(Constants_LanhVC.STR_TPC_COLUMN_NAME_TOPIC_NAME)
                        nodeTopicGroup.Nodes.Add(nodeTopic)
                    Next
                End If
                treeTopics.Nodes.Add(nodeTopicGroup)
            Next
            treeTopics.ExpandAll()
        End If

    End Sub
    Private Sub BindDataToCombo()

        arrQuestionSize = New ArrayList()
        arrQuestionSize.Add("12")
        arrQuestionSize.Add("16")
        arrQuestionSize.Add("20")
        arrQuestionSize.Add("24")
        arrQuestionSize.Add("28")
        arrQuestionSize.Add("32")
        cboxQuestionSize.Items.Clear()
        cboxQuestionSize.Items.AddRange(arrQuestionSize.ToArray)
        cboxQuestionSize.SelectedIndex = 4

        arrCharacterForm = New ArrayList()
        arrCharacterForm.Add("Kanji")
        arrCharacterForm.Add("Hiragana/Katakana")
        arrCharacterForm.Add("Han Nom")
        arrCharacterForm.Add("Meaning")

        cmbTestLang.Items.Clear()
        cmbTestLang.Items.AddRange(arrCharacterForm.ToArray())
        cmbTestLang.SelectedIndex = 0 'default Kanji

        cmbAnswerLang.Items.Clear()
        cmbAnswerLang.Items.AddRange(arrCharacterForm.ToArray())
        cmbAnswerLang.SelectedIndex = 3 'default Meaning

        cmbVocType.Items.Clear()
        cmbVocType.Items.Add("Any")
        cmbVocType.Items.Add(Constants_LanhVC.STR_VOC_TYPE_NOUN)
        cmbVocType.Items.Add(Constants_LanhVC.STR_VOC_TYPE_PRO)
        cmbVocType.Items.Add(Constants_LanhVC.STR_VOC_TYPE_VI)
        cmbVocType.Items.Add(Constants_LanhVC.STR_VOC_TYPE_VT)
        cmbVocType.Items.Add(Constants_LanhVC.STR_VOC_TYPE_I)
        cmbVocType.Items.Add(Constants_LanhVC.STR_VOC_TYPE_NA)
        cmbVocType.Items.Add(Constants_LanhVC.STR_VOC_TYPE_PREP)
        cmbVocType.SelectedIndex = 0
    End Sub

    Private Sub treeTopics_NodeMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles treeTopics.NodeMouseClick
        Dim node As TreeNode
        Dim blnAll As Boolean

        If e.Node.Level = 0 Then
            For Each node In e.Node.Nodes
                node.Checked = e.Node.Checked
            Next
        Else
            For Each node In e.Node.Parent.Nodes
                blnAll = blnAll Or node.Checked
            Next
            e.Node.Parent.Checked = blnAll
        End If
    End Sub


    Private Sub btnSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectAll.Click
        For Each node As TreeNode In treeTopics.Nodes
            node.Checked = True
            If node.Nodes.Count > Constants_LanhVC.INT_NO_RECORD Then
                For Each subnode As TreeNode In node.Nodes
                    subnode.Checked = True
                Next
            End If
        Next
    End Sub

    Private Sub btnDeselectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeselectAll.Click
        For Each node As TreeNode In treeTopics.Nodes
            node.Checked = False
            If node.Nodes.Count > Constants_LanhVC.INT_NO_RECORD Then
                For Each subnode As TreeNode In node.Nodes
                    subnode.Checked = False
                Next
            End If
        Next
    End Sub


    Private Sub btnStartTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartTest.Click
        StartTheTest()
    End Sub


    Private Sub StartTheTest()
        blnTesting = True
        blnWaitingForDecision = False
        blnWaitingForDecisionPassed = False
        intCurrentMark = 1000
        lblMark.Text = CStr(intCurrentMark)

        'get selected topics
        selectedTopics = New ArrayList()
        For Each nodeTopicGroup As TreeNode In treeTopics.Nodes
            'get all selected Topic groups 
            If nodeTopicGroup.Checked = True Then
                'get all selected Topic IDs beloging to this Topic Group
                For Each nodeTopic As TreeNode In nodeTopicGroup.Nodes
                    If nodeTopic.Checked Then
                        selectedTopics.Add(nodeTopic.Name)
                    End If
                Next
            End If
        Next

        'get selected language to test
        strTestLanguage = cmbTestLang.Text
        'get selected answer lanaguage
        strAnswerLanguage = cmbAnswerLang.Text
        'get selected Vocabulary Type
        strVocType = cmbVocType.Text
        'get selected test mode
        If radioRandomOrder.Checked Then
            intTestMode = 0
        Else
            intTestMode = 1
        End If
        If Not CheckUserOptions() Then
            Exit Sub
        End If

        blnTestWithTotalTime = chkboxTotalTime.Checked
        'intTotalRemainSecond = txtTotalTime.Text * 60

        performTestBO = New PerformTestBO(selectedTopics, strTestLanguage, strAnswerLanguage, strVocType, intTestMode)
        'reload data
        Try
            objTestResult = performTestBO.startTest
            'display Trying compliment
            lblCompliment.Text = Constants_LanhVC.STR_TEST_TRYING_BEST_MSG
            'reset all score labels
            lblNumberQuest.Text = CStr(objTestResult.PassedQuestionNumber)
            lblRightAnsNum.Text = CStr(objTestResult.RightAnswerNumber)
            lblFalseAnsNum.Text = CStr(objTestResult.WrongAnswerNumber)

            btnStartTest.Enabled = False
            btnRestart.Enabled = True
            btnFinishTest.Enabled = True

            TableLayoutPanel4.Enabled = False
            btnPause.Text = "Pause"
            btnPause.Enabled = True
            'grpboxQuestionTime.Enabled = False
            'gbTotalTime.Enabled = False

            'grbTestMode.Enabled = False
            'grbTopicsTree.Enabled = False
            'grbTestLang.Enabled = False
            'grbAnswerLang.Enabled = False
            'grbVocType.Enabled = False

            'blnTotalTimerPaused = False
            'blnQuestionTimerPaused = False
            'btnPause.Text = "Pause"
            'txtMarkPerQuestion.Enabled = False

            If blnTestWithTotalTime Then
                lblTotalTimeLeftLabel.Visible = True
                lblTotalTimeLeftValue.Visible = True
                timerTotalAnswerTime.Start()
                'btnPause.Enabled = True
            Else
                lblTotalTimeLeftLabel.Visible = False
                lblTotalTimeLeftValue.Visible = False
                'btnPause.Enabled = False
            End If

            'get the first question as next question
            getNextQuestion()

        Catch ex As Exception
            MessageBox.Show(ex.Message, Constants_LanhVC.STR_TEST_GLOSSARY_LOADING_ERROR_CAPTION)
            lblCompliment.Text = Constants_LanhVC.STR_TEST_CHOOSE_TOPICS
        End Try
    End Sub
    Private Sub getNextQuestion()

        lblClockDisplay.ForeColor = Color.Black

        'disabled Start button
        'btnRestart.Enabled = False
        'btnFinishTest.Enabled = False

        'prevent screen automatically switch radio first answer to being checked
        boolHaveUserOptionForAnswer = False
        'enable answer group box for user to answer the question
        grbAnswers.Enabled = True

        'request PerformTestBO for the first question
        objQuestion = performTestBO.getNextQuestion()
        'clear all previous selection
        If Not radioCurrSelAnswer Is Nothing Then
            radioCurrSelAnswer.Checked = False
            radioCurrSelAnswer = Nothing
        End If

        If Not objQuestion Is Nothing AndAlso Not Constants_LanhVC.STR_BLANK_VALUE.Equals(objQuestion.Question) Then
            'display the asked word and its assumed answer
            enableAnswerRadioButton()
            lblQuestion.Text = objQuestion.Question
            Dim answerList() As String = objQuestion.ListOfAnswers
            radioFirstAns.Text = answerList(0) 'First answer in the list
            radioSecondAns.Text = answerList(1) 'Second answer in the list
            radioThirdAns.Text = answerList(2) 'Third answer in the list
            radioFourthAns.Text = answerList(3) 'Fourth answer in the list
            lblCorrectAnswer.Text = objQuestion.CorrectAnswer 'to display correct answer

            'disable untexted radio button
            DisableUnusedRadioButton()

            'enable Set Time Button to prevent time setting
            'grbControls.Enabled = False


            'hide correctAnswer label
            lblCorrectAnswer.Visible = False
            'focus
            grbAnswers.Focus()

            're-init test time
            intQuestionRemainSecond = intInitTimeInteval
            timerAnswerTime.Start()
        Else
            MessageBox.Show(Constants_LanhVC.STR_TEST_END_OF_TEST_MSG, Constants_LanhVC.STR_TEST_END_OF_TEST_CAPTION)
            btnRestart.Enabled = True
            btnFinishTest.Enabled = True
        End If
    End Sub

    Private Function CheckUserOptions() As Boolean
        'check topic list
        If selectedTopics.Count <= 0 Then
            MessageBox.Show(Constants_LanhVC.STR_TEST_MUST_CHOOSE_TOPICS_MSG, _
                            Constants_LanhVC.STR_TEST_NO_CHOSEN_TOPICS_CAPTION, _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        'check test language and language of answers
        ' they must not be the same sa each others
        If strTestLanguage.Equals(strAnswerLanguage) Then
            MessageBox.Show(Constants_LanhVC.STR_TEST_WARNING_SAME_CHARACTER_TYPE_MSG, _
                            Constants_LanhVC.STR_TEST_WARNING_SAME_CHARACTER_TYPE_CAPTION, _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Try
            intInitTimeInteval = txtQuestTime.Text * 1
        Catch ex As Exception
            MessageBox.Show("Please input valid value for time for each question (integer number)")
            Return False
        End Try

        If chkboxTotalTime.Checked Then
            Try
                intTotalRemainSecond = txtTotalTime.Text * 60
            Catch ex As Exception
                MessageBox.Show("Please input valid value for total test time (integer number)")
                Return False
            End Try
        End If

        If (txtMarkPerQuestion.Text IsNot Nothing) Then
            Try
                Dim mark As Integer = Integer.Parse(txtMarkPerQuestion.Text)
                If (mark > 1000 OrElse mark < 0) Then
                    MessageBox.Show("Please input valid value for mark per question (integer number). Maximum value is 1000.")
                    Return False
                End If
            Catch ex As Exception
                MessageBox.Show("Please input valid value for mark per question (integer number). Maximum value is 1000.")
                Return False
            End Try
        Else
            MessageBox.Show("Please input valid value for mark per question (integer number). Maximum value is 1000.")
            Return False
        End If

        Return True
    End Function


    Private Sub updateScores(ByVal testResult As TestResultEntity)
        'update compliment label
        'If testResult.LastAnswerResult = Constants_LanhVC.INT_TEST_RIGHT_RESULT Then
        '    lblCompliment.Text = Constants_LanhVC.STR_TEST_WELL_DONE_MSG
        'ElseIf testResult.LastAnswerResult = Constants_LanhVC.INT_TEST_NO_ANSWER_RESULT Then
        '    lblCompliment.Text = Constants_LanhVC.STR_TEST_TOO_SLOW_MSG
        'Else
        '    lblCompliment.Text = Constants_LanhVC.STR_TEST_WRONG_ANSWER_MSG
        'End If

        'update score labels
        lblNumberQuest.Text = CStr(testResult.PassedQuestionNumber)
        lblRightAnsNum.Text = CStr(testResult.RightAnswerNumber)
        lblFalseAnsNum.Text = CStr(testResult.WrongAnswerNumber)
        lblMark.Text = CStr(testResult.CurrentMark)
    End Sub

    Private Sub btnFinishTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinishTest.Click
        'ask user for decision
        Dim decision As DialogResult
        decision = MessageBox.Show(Constants_LanhVC.STR_TEST_ASKING_FINISHING_TEST_CONFIRMATION_MSG, _
                                   Constants_LanhVC.STR_TEST_ASKING_FINISHING_TEST_CONFIRMATION_MSG, _
                                   MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If decision = DialogResult.OK Then
            'Me.usrPerformTest_Load(sender, e)
            finishTest()
        End If

    End Sub

    Private Sub btnRestart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestart.Click
        StartTheTest()
    End Sub


    Private Sub timerAnswerTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerAnswerTime.Tick

        'If blnQuestionTimerPaused Then
        '    Return
        'End If

        'intQuestionRemainSecond -= Constants_LanhVC.INT_TEST_DECREASE_BY_ONE_SECOND ' minus by 1 second
        'lblClockDisplay.Text = CStr(intQuestionRemainSecond)
        'If intQuestionRemainSecond = 0 Then
        '    Beep()
        '    'prevent user to try to answer
        '    grbAnswers.Enabled = False
        '    timerAnswerTime.Stop()
        '    validateAnswer(Nothing)
        '    'prepareNextQuestion()
        'End If

        If blnQuestionTimerPaused OrElse Not blnTesting Then
            Return
        End If

        intQuestionRemainSecond -= Constants_LanhVC.INT_TEST_DECREASE_BY_ONE_SECOND ' minus by 1 second
        If (Not blnWaitingForDecision) Then
            lblClockDisplay.ForeColor = Color.Black
            lblClockDisplay.Text = CStr(intQuestionRemainSecond)
        Else
            lblClockDisplay.ForeColor = Color.Blue
            lblClockDisplay.Text = CStr(intQuestionRemainSecond)
        End If

        If intQuestionRemainSecond = 0 Then
            If (Not blnWaitingForDecision) Then
                blnWaitingForDecision = True
                intQuestionRemainSecond = intWaitingForDecisionTime
                Beep()

            Else
                'grbAnswers.Enabled = False
                'timerAnswerTime.Stop()

                intCurrentMark = intCurrentMark - Integer.Parse(txtMarkPerQuestion.Text)
                lblMark.Text = CType(intCurrentMark, String)

                timerAnswerTime.Stop()
                wrongSplash = New SplashWrong
                wrongSplash.Show()
                blnWaitingForDecision = False
                getNextQuestion()

            End If
        End If
    End Sub


    Private Sub timerTotalAnswerTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerTotalAnswerTime.Tick

        If blnTotalTimerPaused OrElse blnWaitingForDecision Then
            Return
        End If

        Dim displayedValue As String
        intTotalRemainSecond -= Constants_LanhVC.INT_TEST_DECREASE_BY_ONE_SECOND ' minus by 1 second
        displayedValue = CStr((intTotalRemainSecond - (intTotalRemainSecond Mod 60)) / 60) + ":"
        If (intTotalRemainSecond Mod 60 < 10) Then
            displayedValue += "0" + CStr(intTotalRemainSecond Mod 60)
        Else
            displayedValue += CStr(intTotalRemainSecond Mod 60)
        End If

        lblTotalTimeLeftValue.Text = displayedValue

        If intTotalRemainSecond = 0 Then
            Beep()
            timerTotalAnswerTime.Stop()
            'validateAnswer(Nothing)
            'Me.usrPerformTest_Load(sender, e)
            finishTest()
        End If
    End Sub


    'Private Sub btnNextQuest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    getNextQuestion()
    'End Sub

    'Private Sub grbAnswers_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grbAnswers.KeyUp
    '    boolHaveUserOptionForAnswer = True
    '    Select Case e.KeyCode
    '        Case Keys.D1
    '            If radioFirstAns.Enabled = True Then
    '                radioFirstAns.Checked = True
    '            End If
    '        Case Keys.D2
    '            If radioSecondAns.Enabled = True Then
    '                radioSecondAns.Checked = True
    '            End If
    '        Case Keys.D3
    '            If radioThirdAns.Enabled = True Then
    '                radioThirdAns.Checked = True
    '            End If
    '        Case Keys.D4
    '            If radioFourthAns.Enabled = True Then
    '                radioFourthAns.Checked = True
    '            End If
    '    End Select

    'End Sub

    Private Sub DisableUnusedRadioButton()
        If Constants_LanhVC.STR_BLANK_VALUE.Equals(radioFirstAns.Text) Then
            radioFirstAns.Enabled = False
        ElseIf Constants_LanhVC.STR_BLANK_VALUE.Equals(radioSecondAns.Text) Then
            radioSecondAns.Enabled = False
        ElseIf Constants_LanhVC.STR_BLANK_VALUE.Equals(radioThirdAns.Text) Then
            radioThirdAns.Enabled = False
        ElseIf Constants_LanhVC.STR_BLANK_VALUE.Equals(radioFourthAns.Text) Then
            radioFourthAns.Enabled = False
        End If
    End Sub
    Private Sub enableAnswerRadioButton()
        radioFirstAns.Enabled = True
        radioSecondAns.Enabled = True
        radioSecondAns.Enabled = True
        radioSecondAns.Enabled = True
        radioSecondAns.Enabled = True
    End Sub

    Private Sub radioFirstAns_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioFirstAns.Click
        boolHaveUserOptionForAnswer = True
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        blnTesting = False
        Me.Parent.Controls.Remove(Me)
        Me.Finalize()
    End Sub

    Private Sub cbkboxTotalTime_Clicked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkboxTotalTime.CheckedChanged
        If chkboxTotalTime.Checked Then
            txtTotalTime.Enabled = True
            lblTotalTimeLeftLabel.Visible = True
            lblTotalTimeLeftValue.Visible = True
        Else
            txtTotalTime.Enabled = False
            lblTotalTimeLeftLabel.Visible = False
            lblTotalTimeLeftValue.Visible = False
        End If
    End Sub

    Private Sub btnPause_Clicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnPause.MouseClick
        If blnTotalTimerPaused = True Then
            blnQuestionTimerPaused = False
            blnTotalTimerPaused = False
            btnPause.Text = "Pause"
        Else
            blnQuestionTimerPaused = True
            blnTotalTimerPaused = True
            btnPause.Text = "Resume"
        End If
    End Sub

    Private Sub cboxQuestionSize_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboxQuestionSize.SelectionChangeCommitted
        lblQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", Integer.Parse(cboxQuestionSize.SelectedItem), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    End Sub

    Private Sub btnColor_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnColor.MouseClick
        colorDialog = New ColorDialog
        colorDialog.Color = lblQuestion.BackColor
        If colorDialog.ShowDialog() = DialogResult.OK Then
            lblQuestion.ForeColor = colorDialog.Color
        End If

    End Sub

    Private Sub usrPerformSpecialTest_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grbAnswers.KeyUp

        If Keys.S.Equals(e.KeyCode) Then
            blnWaitingForDecision = False
            timerAnswerTime.Stop()

            intCurrentMark = intCurrentMark - Integer.Parse(txtMarkPerQuestion.Text)
            lblMark.Text = CType(intCurrentMark, String)

            wrongSplash = New SplashWrong
            wrongSplash.Show()
            getNextQuestion()
        ElseIf Keys.D.Equals(e.KeyCode) Then
            blnWaitingForDecision = False
            timerAnswerTime.Stop()

            lblMark.Text = CType(intCurrentMark, String)

            correctSplash = New SplashCorrect
            correctSplash.Show()
            getNextQuestion()
        ElseIf Keys.A.Equals(e.KeyCode) Then
            intCurrentMark = intCurrentMark + Integer.Parse(txtMarkPerQuestion.Text)
            lblMark.Text = CType(intCurrentMark, String)
        End If
    End Sub
End Class

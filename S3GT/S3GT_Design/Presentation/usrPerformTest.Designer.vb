<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrPerformTest
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrPerformTest))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblCorrectAnswer = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.grbAnswers = New System.Windows.Forms.GroupBox
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel
        Me.radioFirstAns = New System.Windows.Forms.RadioButton
        Me.radioSecondAns = New System.Windows.Forms.RadioButton
        Me.radioThirdAns = New System.Windows.Forms.RadioButton
        Me.radioFourthAns = New System.Windows.Forms.RadioButton
        Me.questionBlock = New System.Windows.Forms.GroupBox
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel
        Me.btnColor = New System.Windows.Forms.Button
        Me.cboxQuestionSize = New System.Windows.Forms.ComboBox
        Me.lblQuestion = New System.Windows.Forms.Label
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel
        Me.grbTopicsTree = New System.Windows.Forms.GroupBox
        Me.btnDeselectAll = New System.Windows.Forms.Button
        Me.btnSelectAll = New System.Windows.Forms.Button
        Me.treeTopics = New System.Windows.Forms.TreeView
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel
        Me.grbTestMode = New System.Windows.Forms.GroupBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.radioTopBottomOrder = New System.Windows.Forms.RadioButton
        Me.radioRandomOrder = New System.Windows.Forms.RadioButton
        Me.grbVocType = New System.Windows.Forms.GroupBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.cmbVocType = New System.Windows.Forms.ComboBox
        Me.grbAnswerLang = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.cmbAnswerLang = New System.Windows.Forms.ComboBox
        Me.grbTestLang = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.cmbTestLang = New System.Windows.Forms.ComboBox
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel
        Me.btnFinishTest = New System.Windows.Forms.Button
        Me.btnNextQuest = New System.Windows.Forms.Button
        Me.btnRestart = New System.Windows.Forms.Button
        Me.gbTotalTime = New System.Windows.Forms.GroupBox
        Me.lblTotalTime = New System.Windows.Forms.Label
        Me.chkboxTotalTime = New System.Windows.Forms.CheckBox
        Me.txtTotalTime = New System.Windows.Forms.TextBox
        Me.grpboxQuestionTime = New System.Windows.Forms.GroupBox
        Me.lblQuestionTimeLabel = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtQuestTime = New System.Windows.Forms.TextBox
        Me.lblCompliment = New System.Windows.Forms.Label
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel
        Me.grbControls = New System.Windows.Forms.GroupBox
        Me.btnPause = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnStartTest = New System.Windows.Forms.Button
        Me.btnLoadTest = New System.Windows.Forms.Button
        Me.btnSaveTest = New System.Windows.Forms.Button
        Me.grbClock = New System.Windows.Forms.GroupBox
        Me.lblTotalTimeLeftValue = New System.Windows.Forms.Label
        Me.lblTotalTimeLeftLabel = New System.Windows.Forms.Label
        Me.lblClockDisplay = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblGrade = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblPercentage = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblUnansQuestNum = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblFalseAnsNum = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblRightAnsNum = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblNumberQuest = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.timerAnswerTime = New System.Windows.Forms.Timer(Me.components)
        Me.timerTotalAnswerTime = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grbAnswers.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.questionBlock.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.grbTopicsTree.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.grbTestMode.SuspendLayout()
        Me.grbVocType.SuspendLayout()
        Me.grbAnswerLang.SuspendLayout()
        Me.grbTestLang.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.gbTotalTime.SuspendLayout()
        Me.grpboxQuestionTime.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.grbControls.SuspendLayout()
        Me.grbClock.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel7, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(657, 540)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.GroupBox1, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.grbAnswers, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.questionBlock, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel4, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.lblCompliment, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(5, 5)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(469, 530)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblCorrectAnswer)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(4, 230)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(461, 30)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        '
        'lblCorrectAnswer
        '
        Me.lblCorrectAnswer.AutoSize = True
        Me.lblCorrectAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorrectAnswer.ForeColor = System.Drawing.Color.Red
        Me.lblCorrectAnswer.Location = New System.Drawing.Point(118, 1)
        Me.lblCorrectAnswer.Name = "lblCorrectAnswer"
        Me.lblCorrectAnswer.Size = New System.Drawing.Size(19, 20)
        Me.lblCorrectAnswer.TabIndex = 17
        Me.lblCorrectAnswer.Text = "  "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 15)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Correct answer"
        '
        'grbAnswers
        '
        Me.grbAnswers.Controls.Add(Me.TableLayoutPanel3)
        Me.grbAnswers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbAnswers.Location = New System.Drawing.Point(4, 83)
        Me.grbAnswers.Name = "grbAnswers"
        Me.grbAnswers.Size = New System.Drawing.Size(461, 140)
        Me.grbAnswers.TabIndex = 21
        Me.grbAnswers.TabStop = False
        Me.grbAnswers.Text = "Answers:"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.radioFirstAns, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.radioSecondAns, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.radioThirdAns, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.radioFourthAns, 0, 3)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 17)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 4
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(455, 120)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'radioFirstAns
        '
        Me.radioFirstAns.AutoSize = True
        Me.radioFirstAns.Location = New System.Drawing.Point(3, 3)
        Me.radioFirstAns.Name = "radioFirstAns"
        Me.radioFirstAns.Size = New System.Drawing.Size(33, 19)
        Me.radioFirstAns.TabIndex = 1
        Me.radioFirstAns.TabStop = True
        Me.radioFirstAns.Text = "1"
        Me.radioFirstAns.UseVisualStyleBackColor = True
        '
        'radioSecondAns
        '
        Me.radioSecondAns.AutoSize = True
        Me.radioSecondAns.Location = New System.Drawing.Point(3, 33)
        Me.radioSecondAns.Name = "radioSecondAns"
        Me.radioSecondAns.Size = New System.Drawing.Size(33, 19)
        Me.radioSecondAns.TabIndex = 2
        Me.radioSecondAns.TabStop = True
        Me.radioSecondAns.Text = "2"
        Me.radioSecondAns.UseVisualStyleBackColor = True
        '
        'radioThirdAns
        '
        Me.radioThirdAns.AutoSize = True
        Me.radioThirdAns.Location = New System.Drawing.Point(3, 63)
        Me.radioThirdAns.Name = "radioThirdAns"
        Me.radioThirdAns.Size = New System.Drawing.Size(33, 19)
        Me.radioThirdAns.TabIndex = 3
        Me.radioThirdAns.TabStop = True
        Me.radioThirdAns.Text = "3"
        Me.radioThirdAns.UseVisualStyleBackColor = True
        '
        'radioFourthAns
        '
        Me.radioFourthAns.AutoSize = True
        Me.radioFourthAns.Location = New System.Drawing.Point(3, 93)
        Me.radioFourthAns.Name = "radioFourthAns"
        Me.radioFourthAns.Size = New System.Drawing.Size(33, 19)
        Me.radioFourthAns.TabIndex = 4
        Me.radioFourthAns.TabStop = True
        Me.radioFourthAns.Text = "4"
        Me.radioFourthAns.UseVisualStyleBackColor = True
        '
        'questionBlock
        '
        Me.questionBlock.Controls.Add(Me.TableLayoutPanel8)
        Me.questionBlock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.questionBlock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.questionBlock.Location = New System.Drawing.Point(4, 25)
        Me.questionBlock.Name = "questionBlock"
        Me.questionBlock.Size = New System.Drawing.Size(461, 51)
        Me.questionBlock.TabIndex = 20
        Me.questionBlock.TabStop = False
        Me.questionBlock.Text = "Question"
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 3
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.btnColor, 1, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.cboxQuestionSize, 2, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.lblQuestion, 0, 0)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(3, 17)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 1
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(455, 31)
        Me.TableLayoutPanel8.TabIndex = 3
        '
        'btnColor
        '
        Me.btnColor.BackgroundImage = CType(resources.GetObject("btnColor.BackgroundImage"), System.Drawing.Image)
        Me.btnColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnColor.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnColor.Location = New System.Drawing.Point(385, 3)
        Me.btnColor.Name = "btnColor"
        Me.btnColor.Size = New System.Drawing.Size(30, 23)
        Me.btnColor.TabIndex = 2
        Me.btnColor.UseVisualStyleBackColor = True
        '
        'cboxQuestionSize
        '
        Me.cboxQuestionSize.Dock = System.Windows.Forms.DockStyle.Top
        Me.cboxQuestionSize.FormattingEnabled = True
        Me.cboxQuestionSize.Location = New System.Drawing.Point(421, 3)
        Me.cboxQuestionSize.Name = "cboxQuestionSize"
        Me.cboxQuestionSize.Size = New System.Drawing.Size(31, 23)
        Me.cboxQuestionSize.TabIndex = 1
        '
        'lblQuestion
        '
        Me.lblQuestion.AutoSize = True
        Me.lblQuestion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion.ForeColor = System.Drawing.Color.Red
        Me.lblQuestion.Location = New System.Drawing.Point(3, 0)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(376, 31)
        Me.lblQuestion.TabIndex = 0
        Me.lblQuestion.Text = "                     "
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.grbTopicsTree, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel5, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(4, 267)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(461, 259)
        Me.TableLayoutPanel4.TabIndex = 35
        '
        'grbTopicsTree
        '
        Me.grbTopicsTree.Controls.Add(Me.btnDeselectAll)
        Me.grbTopicsTree.Controls.Add(Me.btnSelectAll)
        Me.grbTopicsTree.Controls.Add(Me.treeTopics)
        Me.grbTopicsTree.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grbTopicsTree.Location = New System.Drawing.Point(4, 4)
        Me.grbTopicsTree.Name = "grbTopicsTree"
        Me.grbTopicsTree.Size = New System.Drawing.Size(200, 251)
        Me.grbTopicsTree.TabIndex = 27
        Me.grbTopicsTree.TabStop = False
        Me.grbTopicsTree.Text = "Topics:"
        '
        'btnDeselectAll
        '
        Me.btnDeselectAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeselectAll.Location = New System.Drawing.Point(103, 213)
        Me.btnDeselectAll.Name = "btnDeselectAll"
        Me.btnDeselectAll.Size = New System.Drawing.Size(91, 25)
        Me.btnDeselectAll.TabIndex = 5
        Me.btnDeselectAll.Text = "Deselect All"
        Me.btnDeselectAll.UseVisualStyleBackColor = True
        '
        'btnSelectAll
        '
        Me.btnSelectAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSelectAll.Location = New System.Drawing.Point(4, 213)
        Me.btnSelectAll.Name = "btnSelectAll"
        Me.btnSelectAll.Size = New System.Drawing.Size(91, 25)
        Me.btnSelectAll.TabIndex = 4
        Me.btnSelectAll.Text = "Select All"
        Me.btnSelectAll.UseVisualStyleBackColor = True
        '
        'treeTopics
        '
        Me.treeTopics.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.treeTopics.CheckBoxes = True
        Me.treeTopics.Location = New System.Drawing.Point(3, 16)
        Me.treeTopics.Name = "treeTopics"
        Me.treeTopics.Size = New System.Drawing.Size(192, 191)
        Me.treeTopics.TabIndex = 3
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.grbTestMode, 0, 4)
        Me.TableLayoutPanel5.Controls.Add(Me.grbVocType, 0, 3)
        Me.TableLayoutPanel5.Controls.Add(Me.grbAnswerLang, 0, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.grbTestLang, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel6, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.gbTotalTime, 0, 5)
        Me.TableLayoutPanel5.Controls.Add(Me.grpboxQuestionTime, 0, 6)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(211, 4)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 7
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(246, 251)
        Me.TableLayoutPanel5.TabIndex = 28
        '
        'grbTestMode
        '
        Me.grbTestMode.Controls.Add(Me.Label11)
        Me.grbTestMode.Controls.Add(Me.radioTopBottomOrder)
        Me.grbTestMode.Controls.Add(Me.radioRandomOrder)
        Me.grbTestMode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grbTestMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbTestMode.Location = New System.Drawing.Point(5, 136)
        Me.grbTestMode.Name = "grbTestMode"
        Me.grbTestMode.Size = New System.Drawing.Size(236, 48)
        Me.grbTestMode.TabIndex = 39
        Me.grbTestMode.TabStop = False
        '
        'Label11
        '
        Me.Label11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 11)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Test mode"
        '
        'radioTopBottomOrder
        '
        Me.radioTopBottomOrder.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.radioTopBottomOrder.AutoSize = True
        Me.radioTopBottomOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioTopBottomOrder.Location = New System.Drawing.Point(107, 17)
        Me.radioTopBottomOrder.Name = "radioTopBottomOrder"
        Me.radioTopBottomOrder.Size = New System.Drawing.Size(113, 17)
        Me.radioTopBottomOrder.TabIndex = 1
        Me.radioTopBottomOrder.TabStop = True
        Me.radioTopBottomOrder.Text = "From top to bottom"
        Me.radioTopBottomOrder.UseVisualStyleBackColor = True
        '
        'radioRandomOrder
        '
        Me.radioRandomOrder.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.radioRandomOrder.AutoSize = True
        Me.radioRandomOrder.Checked = True
        Me.radioRandomOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioRandomOrder.Location = New System.Drawing.Point(107, 0)
        Me.radioRandomOrder.Name = "radioRandomOrder"
        Me.radioRandomOrder.Size = New System.Drawing.Size(92, 17)
        Me.radioRandomOrder.TabIndex = 0
        Me.radioRandomOrder.TabStop = True
        Me.radioRandomOrder.Text = "Random order"
        Me.radioRandomOrder.UseVisualStyleBackColor = True
        '
        'grbVocType
        '
        Me.grbVocType.Controls.Add(Me.Label10)
        Me.grbVocType.Controls.Add(Me.cmbVocType)
        Me.grbVocType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grbVocType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbVocType.Location = New System.Drawing.Point(5, 106)
        Me.grbVocType.Name = "grbVocType"
        Me.grbVocType.Size = New System.Drawing.Size(236, 22)
        Me.grbVocType.TabIndex = 38
        Me.grbVocType.TabStop = False
        '
        'Label10
        '
        Me.Label10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 5)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Vocabulary type"
        '
        'cmbVocType
        '
        Me.cmbVocType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbVocType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbVocType.FormattingEnabled = True
        Me.cmbVocType.Location = New System.Drawing.Point(105, 1)
        Me.cmbVocType.Name = "cmbVocType"
        Me.cmbVocType.Size = New System.Drawing.Size(126, 21)
        Me.cmbVocType.TabIndex = 1
        '
        'grbAnswerLang
        '
        Me.grbAnswerLang.Controls.Add(Me.Label9)
        Me.grbAnswerLang.Controls.Add(Me.cmbAnswerLang)
        Me.grbAnswerLang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grbAnswerLang.Location = New System.Drawing.Point(5, 76)
        Me.grbAnswerLang.Name = "grbAnswerLang"
        Me.grbAnswerLang.Size = New System.Drawing.Size(236, 22)
        Me.grbAnswerLang.TabIndex = 35
        Me.grbAnswerLang.TabStop = False
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 4)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Answer language"
        '
        'cmbAnswerLang
        '
        Me.cmbAnswerLang.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbAnswerLang.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAnswerLang.FormattingEnabled = True
        Me.cmbAnswerLang.Location = New System.Drawing.Point(104, 2)
        Me.cmbAnswerLang.Name = "cmbAnswerLang"
        Me.cmbAnswerLang.Size = New System.Drawing.Size(126, 21)
        Me.cmbAnswerLang.TabIndex = 0
        '
        'grbTestLang
        '
        Me.grbTestLang.Controls.Add(Me.Label8)
        Me.grbTestLang.Controls.Add(Me.cmbTestLang)
        Me.grbTestLang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grbTestLang.Location = New System.Drawing.Point(5, 46)
        Me.grbTestLang.Name = "grbTestLang"
        Me.grbTestLang.Size = New System.Drawing.Size(236, 22)
        Me.grbTestLang.TabIndex = 28
        Me.grbTestLang.TabStop = False
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(5, 4)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Question language"
        '
        'cmbTestLang
        '
        Me.cmbTestLang.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbTestLang.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTestLang.FormattingEnabled = True
        Me.cmbTestLang.Location = New System.Drawing.Point(104, 1)
        Me.cmbTestLang.Name = "cmbTestLang"
        Me.cmbTestLang.Size = New System.Drawing.Size(126, 21)
        Me.cmbTestLang.TabIndex = 0
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 3
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel6.Controls.Add(Me.btnFinishTest, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.btnNextQuest, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.btnRestart, 0, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(5, 5)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(236, 33)
        Me.TableLayoutPanel6.TabIndex = 0
        '
        'btnFinishTest
        '
        Me.btnFinishTest.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnFinishTest.Location = New System.Drawing.Point(159, 3)
        Me.btnFinishTest.Name = "btnFinishTest"
        Me.btnFinishTest.Size = New System.Drawing.Size(74, 27)
        Me.btnFinishTest.TabIndex = 27
        Me.btnFinishTest.Text = "Finish"
        Me.btnFinishTest.UseVisualStyleBackColor = True
        '
        'btnNextQuest
        '
        Me.btnNextQuest.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnNextQuest.Location = New System.Drawing.Point(81, 3)
        Me.btnNextQuest.Name = "btnNextQuest"
        Me.btnNextQuest.Size = New System.Drawing.Size(72, 27)
        Me.btnNextQuest.TabIndex = 26
        Me.btnNextQuest.Text = "Next ->"
        Me.btnNextQuest.UseVisualStyleBackColor = True
        '
        'btnRestart
        '
        Me.btnRestart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnRestart.Location = New System.Drawing.Point(3, 3)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(72, 27)
        Me.btnRestart.TabIndex = 25
        Me.btnRestart.Text = "Restart"
        Me.btnRestart.UseVisualStyleBackColor = True
        '
        'gbTotalTime
        '
        Me.gbTotalTime.Controls.Add(Me.lblTotalTime)
        Me.gbTotalTime.Controls.Add(Me.chkboxTotalTime)
        Me.gbTotalTime.Controls.Add(Me.txtTotalTime)
        Me.gbTotalTime.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbTotalTime.Location = New System.Drawing.Point(5, 192)
        Me.gbTotalTime.Name = "gbTotalTime"
        Me.gbTotalTime.Size = New System.Drawing.Size(236, 22)
        Me.gbTotalTime.TabIndex = 40
        Me.gbTotalTime.TabStop = False
        '
        'lblTotalTime
        '
        Me.lblTotalTime.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalTime.AutoSize = True
        Me.lblTotalTime.Location = New System.Drawing.Point(202, 4)
        Me.lblTotalTime.Name = "lblTotalTime"
        Me.lblTotalTime.Size = New System.Drawing.Size(34, 13)
        Me.lblTotalTime.TabIndex = 35
        Me.lblTotalTime.Text = "min(s)"
        '
        'chkboxTotalTime
        '
        Me.chkboxTotalTime.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkboxTotalTime.AutoSize = True
        Me.chkboxTotalTime.Location = New System.Drawing.Point(0, 2)
        Me.chkboxTotalTime.Name = "chkboxTotalTime"
        Me.chkboxTotalTime.Size = New System.Drawing.Size(124, 17)
        Me.chkboxTotalTime.TabIndex = 40
        Me.chkboxTotalTime.Text = "Enable total test time"
        Me.chkboxTotalTime.UseVisualStyleBackColor = True
        '
        'txtTotalTime
        '
        Me.txtTotalTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.txtTotalTime.Location = New System.Drawing.Point(128, 0)
        Me.txtTotalTime.Name = "txtTotalTime"
        Me.txtTotalTime.Size = New System.Drawing.Size(70, 20)
        Me.txtTotalTime.TabIndex = 35
        Me.txtTotalTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'grpboxQuestionTime
        '
        Me.grpboxQuestionTime.Controls.Add(Me.lblQuestionTimeLabel)
        Me.grpboxQuestionTime.Controls.Add(Me.Label12)
        Me.grpboxQuestionTime.Controls.Add(Me.txtQuestTime)
        Me.grpboxQuestionTime.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpboxQuestionTime.Location = New System.Drawing.Point(5, 222)
        Me.grpboxQuestionTime.Name = "grpboxQuestionTime"
        Me.grpboxQuestionTime.Size = New System.Drawing.Size(236, 24)
        Me.grpboxQuestionTime.TabIndex = 41
        Me.grpboxQuestionTime.TabStop = False
        '
        'lblQuestionTimeLabel
        '
        Me.lblQuestionTimeLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblQuestionTimeLabel.AutoSize = True
        Me.lblQuestionTimeLabel.Location = New System.Drawing.Point(6, 3)
        Me.lblQuestionTimeLabel.Name = "lblQuestionTimeLabel"
        Me.lblQuestionTimeLabel.Size = New System.Drawing.Size(91, 13)
        Me.lblQuestionTimeLabel.TabIndex = 38
        Me.lblQuestionTimeLabel.Text = "Time per question"
        '
        'Label12
        '
        Me.Label12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(202, 5)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(35, 13)
        Me.Label12.TabIndex = 37
        Me.Label12.Text = "sec(s)"
        '
        'txtQuestTime
        '
        Me.txtQuestTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.txtQuestTime.Location = New System.Drawing.Point(129, 0)
        Me.txtQuestTime.Name = "txtQuestTime"
        Me.txtQuestTime.Size = New System.Drawing.Size(70, 20)
        Me.txtQuestTime.TabIndex = 36
        Me.txtQuestTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCompliment
        '
        Me.lblCompliment.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCompliment.AutoSize = True
        Me.lblCompliment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompliment.Location = New System.Drawing.Point(4, 1)
        Me.lblCompliment.Name = "lblCompliment"
        Me.lblCompliment.Size = New System.Drawing.Size(461, 20)
        Me.lblCompliment.TabIndex = 19
        Me.lblCompliment.Text = "＊＊Test your skill! Try your best!＊＊"
        Me.lblCompliment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel7.ColumnCount = 1
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.grbControls, 0, 2)
        Me.TableLayoutPanel7.Controls.Add(Me.grbClock, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.GroupBox2, 0, 1)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(482, 5)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 3
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(170, 530)
        Me.TableLayoutPanel7.TabIndex = 1
        '
        'grbControls
        '
        Me.grbControls.Controls.Add(Me.btnPause)
        Me.grbControls.Controls.Add(Me.btnExit)
        Me.grbControls.Controls.Add(Me.btnStartTest)
        Me.grbControls.Controls.Add(Me.btnLoadTest)
        Me.grbControls.Controls.Add(Me.btnSaveTest)
        Me.grbControls.Dock = System.Windows.Forms.DockStyle.Top
        Me.grbControls.Location = New System.Drawing.Point(4, 294)
        Me.grbControls.Name = "grbControls"
        Me.grbControls.Size = New System.Drawing.Size(162, 232)
        Me.grbControls.TabIndex = 36
        Me.grbControls.TabStop = False
        '
        'btnPause
        '
        Me.btnPause.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPause.Location = New System.Drawing.Point(16, 42)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(131, 25)
        Me.btnPause.TabIndex = 35
        Me.btnPause.Text = "Pause"
        Me.btnPause.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.Location = New System.Drawing.Point(19, 165)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(131, 25)
        Me.btnExit.TabIndex = 34
        Me.btnExit.Text = "Exit the Test"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnStartTest
        '
        Me.btnStartTest.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStartTest.Location = New System.Drawing.Point(16, 11)
        Me.btnStartTest.Name = "btnStartTest"
        Me.btnStartTest.Size = New System.Drawing.Size(131, 25)
        Me.btnStartTest.TabIndex = 23
        Me.btnStartTest.Text = "Start the Test"
        Me.btnStartTest.UseVisualStyleBackColor = True
        '
        'btnLoadTest
        '
        Me.btnLoadTest.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLoadTest.Location = New System.Drawing.Point(19, 120)
        Me.btnLoadTest.Name = "btnLoadTest"
        Me.btnLoadTest.Size = New System.Drawing.Size(131, 25)
        Me.btnLoadTest.TabIndex = 1
        Me.btnLoadTest.Text = "Load previous Test"
        Me.btnLoadTest.UseVisualStyleBackColor = True
        '
        'btnSaveTest
        '
        Me.btnSaveTest.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveTest.Location = New System.Drawing.Point(19, 89)
        Me.btnSaveTest.Name = "btnSaveTest"
        Me.btnSaveTest.Size = New System.Drawing.Size(131, 25)
        Me.btnSaveTest.TabIndex = 32
        Me.btnSaveTest.Text = "Save current Test"
        Me.btnSaveTest.UseVisualStyleBackColor = True
        '
        'grbClock
        '
        Me.grbClock.Controls.Add(Me.lblTotalTimeLeftValue)
        Me.grbClock.Controls.Add(Me.lblTotalTimeLeftLabel)
        Me.grbClock.Controls.Add(Me.lblClockDisplay)
        Me.grbClock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grbClock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbClock.Location = New System.Drawing.Point(4, 4)
        Me.grbClock.Name = "grbClock"
        Me.grbClock.Size = New System.Drawing.Size(162, 72)
        Me.grbClock.TabIndex = 18
        Me.grbClock.TabStop = False
        Me.grbClock.Text = "Clock"
        '
        'lblTotalTimeLeftValue
        '
        Me.lblTotalTimeLeftValue.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalTimeLeftValue.AutoSize = True
        Me.lblTotalTimeLeftValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalTimeLeftValue.Location = New System.Drawing.Point(85, 20)
        Me.lblTotalTimeLeftValue.Name = "lblTotalTimeLeftValue"
        Me.lblTotalTimeLeftValue.Size = New System.Drawing.Size(75, 33)
        Me.lblTotalTimeLeftValue.TabIndex = 18
        Me.lblTotalTimeLeftValue.Text = "0:00"
        Me.lblTotalTimeLeftValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalTimeLeftLabel
        '
        Me.lblTotalTimeLeftLabel.AutoSize = True
        Me.lblTotalTimeLeftLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalTimeLeftLabel.Location = New System.Drawing.Point(104, 1)
        Me.lblTotalTimeLeftLabel.Name = "lblTotalTimeLeftLabel"
        Me.lblTotalTimeLeftLabel.Size = New System.Drawing.Size(34, 15)
        Me.lblTotalTimeLeftLabel.TabIndex = 17
        Me.lblTotalTimeLeftLabel.Text = "Total"
        '
        'lblClockDisplay
        '
        Me.lblClockDisplay.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblClockDisplay.AutoSize = True
        Me.lblClockDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClockDisplay.Location = New System.Drawing.Point(13, 20)
        Me.lblClockDisplay.Name = "lblClockDisplay"
        Me.lblClockDisplay.Size = New System.Drawing.Size(32, 33)
        Me.lblClockDisplay.TabIndex = 0
        Me.lblClockDisplay.Text = "0"
        Me.lblClockDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.lblGrade)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.lblPercentage)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lblUnansQuestNum)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.lblFalseAnsNum)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.lblRightAnsNum)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.lblNumberQuest)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(4, 83)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(162, 204)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Your current result"
        '
        'lblGrade
        '
        Me.lblGrade.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblGrade.AutoSize = True
        Me.lblGrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrade.Location = New System.Drawing.Point(83, 143)
        Me.lblGrade.Name = "lblGrade"
        Me.lblGrade.Size = New System.Drawing.Size(39, 20)
        Me.lblGrade.TabIndex = 11
        Me.lblGrade.Text = "      "
        Me.lblGrade.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 147)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Grade:"
        '
        'lblPercentage
        '
        Me.lblPercentage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPercentage.AutoSize = True
        Me.lblPercentage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercentage.Location = New System.Drawing.Point(117, 124)
        Me.lblPercentage.Name = "lblPercentage"
        Me.lblPercentage.Size = New System.Drawing.Size(21, 13)
        Me.lblPercentage.TabIndex = 9
        Me.lblPercentage.Text = "0%"
        Me.lblPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Percentage:"
        '
        'lblUnansQuestNum
        '
        Me.lblUnansQuestNum.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUnansQuestNum.AutoSize = True
        Me.lblUnansQuestNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnansQuestNum.Location = New System.Drawing.Point(118, 100)
        Me.lblUnansQuestNum.Name = "lblUnansQuestNum"
        Me.lblUnansQuestNum.Size = New System.Drawing.Size(13, 13)
        Me.lblUnansQuestNum.TabIndex = 7
        Me.lblUnansQuestNum.Text = "0"
        Me.lblUnansQuestNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Skipped question:"
        '
        'lblFalseAnsNum
        '
        Me.lblFalseAnsNum.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFalseAnsNum.AutoSize = True
        Me.lblFalseAnsNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFalseAnsNum.Location = New System.Drawing.Point(118, 75)
        Me.lblFalseAnsNum.Name = "lblFalseAnsNum"
        Me.lblFalseAnsNum.Size = New System.Drawing.Size(13, 13)
        Me.lblFalseAnsNum.TabIndex = 5
        Me.lblFalseAnsNum.Text = "0"
        Me.lblFalseAnsNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Incorrect answers:"
        '
        'lblRightAnsNum
        '
        Me.lblRightAnsNum.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRightAnsNum.AutoSize = True
        Me.lblRightAnsNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRightAnsNum.Location = New System.Drawing.Point(118, 51)
        Me.lblRightAnsNum.Name = "lblRightAnsNum"
        Me.lblRightAnsNum.Size = New System.Drawing.Size(13, 13)
        Me.lblRightAnsNum.TabIndex = 3
        Me.lblRightAnsNum.Text = "0"
        Me.lblRightAnsNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Right answers:"
        '
        'lblNumberQuest
        '
        Me.lblNumberQuest.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNumberQuest.AutoSize = True
        Me.lblNumberQuest.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberQuest.Location = New System.Drawing.Point(118, 26)
        Me.lblNumberQuest.Name = "lblNumberQuest"
        Me.lblNumberQuest.Size = New System.Drawing.Size(13, 13)
        Me.lblNumberQuest.TabIndex = 1
        Me.lblNumberQuest.Text = "0"
        Me.lblNumberQuest.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Questions:"
        '
        'timerAnswerTime
        '
        '
        'timerTotalAnswerTime
        '
        '
        'usrPerformTest
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoScroll = True
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "usrPerformTest"
        Me.Size = New System.Drawing.Size(657, 540)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grbAnswers.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.questionBlock.ResumeLayout(False)
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel8.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.grbTopicsTree.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.grbTestMode.ResumeLayout(False)
        Me.grbTestMode.PerformLayout()
        Me.grbVocType.ResumeLayout(False)
        Me.grbVocType.PerformLayout()
        Me.grbAnswerLang.ResumeLayout(False)
        Me.grbAnswerLang.PerformLayout()
        Me.grbTestLang.ResumeLayout(False)
        Me.grbTestLang.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.gbTotalTime.ResumeLayout(False)
        Me.gbTotalTime.PerformLayout()
        Me.grpboxQuestionTime.ResumeLayout(False)
        Me.grpboxQuestionTime.PerformLayout()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.grbControls.ResumeLayout(False)
        Me.grbClock.ResumeLayout(False)
        Me.grbClock.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblCompliment As System.Windows.Forms.Label
    Friend WithEvents questionBlock As System.Windows.Forms.GroupBox
    Friend WithEvents lblQuestion As System.Windows.Forms.Label
    Friend WithEvents grbAnswers As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents radioFirstAns As System.Windows.Forms.RadioButton
    Friend WithEvents radioSecondAns As System.Windows.Forms.RadioButton
    Friend WithEvents radioThirdAns As System.Windows.Forms.RadioButton
    Friend WithEvents radioFourthAns As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblCorrectAnswer As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents grbTopicsTree As System.Windows.Forms.GroupBox
    Friend WithEvents btnDeselectAll As System.Windows.Forms.Button
    Friend WithEvents btnSelectAll As System.Windows.Forms.Button
    Friend WithEvents treeTopics As System.Windows.Forms.TreeView
    Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents grbTestLang As System.Windows.Forms.GroupBox
    Friend WithEvents cmbTestLang As System.Windows.Forms.ComboBox
    Friend WithEvents TableLayoutPanel6 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnFinishTest As System.Windows.Forms.Button
    Friend WithEvents btnNextQuest As System.Windows.Forms.Button
    Friend WithEvents btnRestart As System.Windows.Forms.Button
    Friend WithEvents grbAnswerLang As System.Windows.Forms.GroupBox
    Friend WithEvents cmbAnswerLang As System.Windows.Forms.ComboBox
    Friend WithEvents grbTestMode As System.Windows.Forms.GroupBox
    Friend WithEvents grbVocType As System.Windows.Forms.GroupBox
    Friend WithEvents cmbVocType As System.Windows.Forms.ComboBox
    Friend WithEvents TableLayoutPanel7 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents grbControls As System.Windows.Forms.GroupBox
    Friend WithEvents btnStartTest As System.Windows.Forms.Button
    Friend WithEvents btnLoadTest As System.Windows.Forms.Button
    Friend WithEvents btnSaveTest As System.Windows.Forms.Button
    Friend WithEvents grbClock As System.Windows.Forms.GroupBox
    Friend WithEvents lblClockDisplay As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblGrade As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblPercentage As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblUnansQuestNum As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblFalseAnsNum As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblRightAnsNum As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblNumberQuest As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents timerAnswerTime As System.Windows.Forms.Timer
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents radioTopBottomOrder As System.Windows.Forms.RadioButton
    Friend WithEvents radioRandomOrder As System.Windows.Forms.RadioButton
    Friend WithEvents txtTotalTime As System.Windows.Forms.TextBox
    Friend WithEvents chkboxTotalTime As System.Windows.Forms.CheckBox
    Friend WithEvents gbTotalTime As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotalTime As System.Windows.Forms.Label
    Friend WithEvents timerTotalAnswerTime As System.Windows.Forms.Timer
    Friend WithEvents lblTotalTimeLeftValue As System.Windows.Forms.Label
    Friend WithEvents lblTotalTimeLeftLabel As System.Windows.Forms.Label
    Friend WithEvents grpboxQuestionTime As System.Windows.Forms.GroupBox
    Friend WithEvents lblQuestionTimeLabel As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtQuestTime As System.Windows.Forms.TextBox
    Friend WithEvents btnPause As System.Windows.Forms.Button
    Friend WithEvents cboxQuestionSize As System.Windows.Forms.ComboBox
    Friend WithEvents btnColor As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel8 As System.Windows.Forms.TableLayoutPanel

End Class

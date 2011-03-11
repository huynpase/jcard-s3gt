<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrFastRegisterVocabularies
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.cboTopicGroup = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cboTopic = New System.Windows.Forms.ComboBox
        Me.lnkCreateTopic = New System.Windows.Forms.LinkLabel
        Me.grbTopic = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblKanji = New System.Windows.Forms.Label
        Me.txtVocabulary = New System.Windows.Forms.TextBox
        Me.lblHiragana = New System.Windows.Forms.Label
        Me.txtOtherWritingForm = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtMeaning = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cboType = New System.Windows.Forms.ComboBox
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.cmdReset = New System.Windows.Forms.Button
        Me.cmdSubmit = New System.Windows.Forms.Button
        Me.lblHannom = New System.Windows.Forms.Label
        Me.txtHannom = New System.Windows.Forms.TextBox
        Me.grbVocabulary = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtExample = New System.Windows.Forms.TextBox
        Me.example = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnCheck = New System.Windows.Forms.Button
        Me.grbTopic.SuspendLayout()
        Me.grbVocabulary.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Topic Group"
        '
        'cboTopicGroup
        '
        Me.cboTopicGroup.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboTopicGroup.FormattingEnabled = True
        Me.cboTopicGroup.Location = New System.Drawing.Point(89, 29)
        Me.cboTopicGroup.Name = "cboTopicGroup"
        Me.cboTopicGroup.Size = New System.Drawing.Size(253, 21)
        Me.cboTopicGroup.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Topic "
        '
        'cboTopic
        '
        Me.cboTopic.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboTopic.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cboTopic.FormattingEnabled = True
        Me.cboTopic.Location = New System.Drawing.Point(89, 58)
        Me.cboTopic.Name = "cboTopic"
        Me.cboTopic.Size = New System.Drawing.Size(253, 21)
        Me.cboTopic.TabIndex = 2
        '
        'lnkCreateTopic
        '
        Me.lnkCreateTopic.AutoSize = True
        Me.lnkCreateTopic.Location = New System.Drawing.Point(118, 88)
        Me.lnkCreateTopic.Name = "lnkCreateTopic"
        Me.lnkCreateTopic.Size = New System.Drawing.Size(100, 13)
        Me.lnkCreateTopic.TabIndex = 3
        Me.lnkCreateTopic.TabStop = True
        Me.lnkCreateTopic.Text = "Create new Topic..."
        '
        'grbTopic
        '
        Me.grbTopic.BackColor = System.Drawing.SystemColors.Control
        Me.grbTopic.Controls.Add(Me.Label4)
        Me.grbTopic.Controls.Add(Me.Label3)
        Me.grbTopic.Controls.Add(Me.lnkCreateTopic)
        Me.grbTopic.Controls.Add(Me.cboTopic)
        Me.grbTopic.Controls.Add(Me.Label2)
        Me.grbTopic.Controls.Add(Me.cboTopicGroup)
        Me.grbTopic.Controls.Add(Me.Label1)
        Me.grbTopic.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbTopic.Location = New System.Drawing.Point(7, 25)
        Me.grbTopic.Name = "grbTopic"
        Me.grbTopic.Size = New System.Drawing.Size(382, 105)
        Me.grbTopic.TabIndex = 0
        Me.grbTopic.TabStop = False
        Me.grbTopic.Text = "Topic and Topic Group information of new Vocabulary"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(350, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 25)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(350, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "*"
        '
        'lblKanji
        '
        Me.lblKanji.AutoSize = True
        Me.lblKanji.Location = New System.Drawing.Point(17, 26)
        Me.lblKanji.Name = "lblKanji"
        Me.lblKanji.Size = New System.Drawing.Size(30, 13)
        Me.lblKanji.TabIndex = 0
        Me.lblKanji.Text = "Kanji"
        '
        'txtVocabulary
        '
        Me.txtVocabulary.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txtVocabulary.Location = New System.Drawing.Point(89, 23)
        Me.txtVocabulary.Name = "txtVocabulary"
        Me.txtVocabulary.Size = New System.Drawing.Size(253, 20)
        Me.txtVocabulary.TabIndex = 4
        '
        'lblHiragana
        '
        Me.lblHiragana.AutoSize = True
        Me.lblHiragana.Location = New System.Drawing.Point(17, 55)
        Me.lblHiragana.Name = "lblHiragana"
        Me.lblHiragana.Size = New System.Drawing.Size(50, 13)
        Me.lblHiragana.TabIndex = 4
        Me.lblHiragana.Text = "Hiragana"
        '
        'txtOtherWritingForm
        '
        Me.txtOtherWritingForm.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txtOtherWritingForm.Location = New System.Drawing.Point(89, 52)
        Me.txtOtherWritingForm.Name = "txtOtherWritingForm"
        Me.txtOtherWritingForm.Size = New System.Drawing.Size(253, 20)
        Me.txtOtherWritingForm.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Meaning"
        '
        'txtMeaning
        '
        Me.txtMeaning.Location = New System.Drawing.Point(89, 110)
        Me.txtMeaning.Name = "txtMeaning"
        Me.txtMeaning.Size = New System.Drawing.Size(253, 20)
        Me.txtMeaning.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 142)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Type"
        '
        'cboType
        '
        Me.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboType.FormattingEnabled = True
        Me.cboType.Location = New System.Drawing.Point(89, 139)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(253, 21)
        Me.cboType.TabIndex = 9
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(267, 247)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 13
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdReset
        '
        Me.cmdReset.Location = New System.Drawing.Point(186, 247)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(75, 23)
        Me.cmdReset.TabIndex = 12
        Me.cmdReset.Text = "Reset"
        Me.cmdReset.UseVisualStyleBackColor = True
        '
        'cmdSubmit
        '
        Me.cmdSubmit.Location = New System.Drawing.Point(105, 247)
        Me.cmdSubmit.Name = "cmdSubmit"
        Me.cmdSubmit.Size = New System.Drawing.Size(75, 23)
        Me.cmdSubmit.TabIndex = 11
        Me.cmdSubmit.Text = "Submit"
        Me.cmdSubmit.UseVisualStyleBackColor = True
        '
        'lblHannom
        '
        Me.lblHannom.AutoSize = True
        Me.lblHannom.Location = New System.Drawing.Point(17, 84)
        Me.lblHannom.Name = "lblHannom"
        Me.lblHannom.Size = New System.Drawing.Size(52, 13)
        Me.lblHannom.TabIndex = 13
        Me.lblHannom.Text = "Han Nom"
        '
        'txtHannom
        '
        Me.txtHannom.Location = New System.Drawing.Point(89, 81)
        Me.txtHannom.Name = "txtHannom"
        Me.txtHannom.Size = New System.Drawing.Size(253, 20)
        Me.txtHannom.TabIndex = 7
        '
        'grbVocabulary
        '
        Me.grbVocabulary.Controls.Add(Me.btnCheck)
        Me.grbVocabulary.Controls.Add(Me.Label5)
        Me.grbVocabulary.Controls.Add(Me.txtExample)
        Me.grbVocabulary.Controls.Add(Me.example)
        Me.grbVocabulary.Controls.Add(Me.txtHannom)
        Me.grbVocabulary.Controls.Add(Me.lblHannom)
        Me.grbVocabulary.Controls.Add(Me.cmdSubmit)
        Me.grbVocabulary.Controls.Add(Me.cmdReset)
        Me.grbVocabulary.Controls.Add(Me.cmdCancel)
        Me.grbVocabulary.Controls.Add(Me.cboType)
        Me.grbVocabulary.Controls.Add(Me.Label7)
        Me.grbVocabulary.Controls.Add(Me.txtMeaning)
        Me.grbVocabulary.Controls.Add(Me.Label6)
        Me.grbVocabulary.Controls.Add(Me.txtOtherWritingForm)
        Me.grbVocabulary.Controls.Add(Me.lblHiragana)
        Me.grbVocabulary.Controls.Add(Me.txtVocabulary)
        Me.grbVocabulary.Controls.Add(Me.lblKanji)
        Me.grbVocabulary.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbVocabulary.Location = New System.Drawing.Point(7, 136)
        Me.grbVocabulary.Name = "grbVocabulary"
        Me.grbVocabulary.Size = New System.Drawing.Size(382, 276)
        Me.grbVocabulary.TabIndex = 1
        Me.grbVocabulary.TabStop = False
        Me.grbVocabulary.Text = "New Vocabulary information"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(350, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 25)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "*"
        '
        'txtExample
        '
        Me.txtExample.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txtExample.Location = New System.Drawing.Point(89, 170)
        Me.txtExample.Multiline = True
        Me.txtExample.Name = "txtExample"
        Me.txtExample.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtExample.Size = New System.Drawing.Size(253, 51)
        Me.txtExample.TabIndex = 10
        '
        'example
        '
        Me.example.AutoSize = True
        Me.example.Location = New System.Drawing.Point(17, 187)
        Me.example.Name = "example"
        Me.example.Size = New System.Drawing.Size(47, 13)
        Me.example.TabIndex = 14
        Me.example.Text = "Example"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.grbTopic)
        Me.GroupBox1.Controls.Add(Me.grbVocabulary)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(392, 418)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fast Register New Vocabularies"
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(24, 247)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(75, 23)
        Me.btnCheck.TabIndex = 16
        Me.btnCheck.Text = "Check"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'usrFastRegisterVocabularies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "usrFastRegisterVocabularies"
        Me.Size = New System.Drawing.Size(395, 427)
        Me.grbTopic.ResumeLayout(False)
        Me.grbTopic.PerformLayout()
        Me.grbVocabulary.ResumeLayout(False)
        Me.grbVocabulary.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents S3GTTPGBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboTopicGroup As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboTopic As System.Windows.Forms.ComboBox
    Friend WithEvents lnkCreateTopic As System.Windows.Forms.LinkLabel
    Friend WithEvents grbTopic As System.Windows.Forms.GroupBox
    Friend WithEvents lblKanji As System.Windows.Forms.Label
    Friend WithEvents txtVocabulary As System.Windows.Forms.TextBox
    Friend WithEvents lblHiragana As System.Windows.Forms.Label
    Friend WithEvents txtOtherWritingForm As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtMeaning As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboType As System.Windows.Forms.ComboBox
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdReset As System.Windows.Forms.Button
    Friend WithEvents cmdSubmit As System.Windows.Forms.Button
    Friend WithEvents lblHannom As System.Windows.Forms.Label
    Friend WithEvents txtHannom As System.Windows.Forms.TextBox
    Friend WithEvents grbVocabulary As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtExample As System.Windows.Forms.TextBox
    Friend WithEvents example As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnCheck As System.Windows.Forms.Button

End Class

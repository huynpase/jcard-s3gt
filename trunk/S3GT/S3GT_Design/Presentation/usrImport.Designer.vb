<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrImport
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tab = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.btnImportKanji = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnDestination = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtDest = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.radKanjiText = New System.Windows.Forms.RadioButton
        Me.radKanjiExcel = New System.Windows.Forms.RadioButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btnImgKanji = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtImgKanjiDest = New System.Windows.Forms.TextBox
        Me.chkKanji = New System.Windows.Forms.CheckBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.btnVocImport = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.btnVocDest = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtVocDest = New System.Windows.Forms.TextBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.radVocText = New System.Windows.Forms.RadioButton
        Me.radVocExcel = New System.Windows.Forms.RadioButton
        Me.fbdImport = New System.Windows.Forms.FolderBrowserDialog
        Me.ofdImport = New System.Windows.Forms.OpenFileDialog
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.tab.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()

        'GiangNVT modified
        '
        'tab
        '
        Me.tab.Controls.Add(Me.TabPage2)
        Me.tab.Controls.Add(Me.TabPage1)
        Me.tab.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab.Location = New System.Drawing.Point(20, 28)
        Me.tab.Name = "tab"
        Me.tab.SelectedIndex = 0
        Me.tab.Size = New System.Drawing.Size(603, 330)
        Me.tab.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnImportKanji)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(595, 304)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Kanji"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnImportKanji
        '
        Me.btnImportKanji.Location = New System.Drawing.Point(465, 259)
        Me.btnImportKanji.Name = "btnImportKanji"
        Me.btnImportKanji.Size = New System.Drawing.Size(75, 23)
        Me.btnImportKanji.TabIndex = 8
        Me.btnImportKanji.Text = "Import"
        Me.btnImportKanji.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnDestination)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtDest)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 55)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(548, 68)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Import destination"
        '
        'btnDestination
        '
        Me.btnDestination.Location = New System.Drawing.Point(448, 30)
        Me.btnDestination.Name = "btnDestination"
        Me.btnDestination.Size = New System.Drawing.Size(75, 23)
        Me.btnDestination.TabIndex = 2
        Me.btnDestination.Text = "Browse"
        Me.btnDestination.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Destination"
        '
        'txtDest
        '
        Me.txtDest.Location = New System.Drawing.Point(78, 33)
        Me.txtDest.Name = "txtDest"
        Me.txtDest.Size = New System.Drawing.Size(355, 20)
        Me.txtDest.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radKanjiText)
        Me.GroupBox1.Controls.Add(Me.radKanjiExcel)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(225, 41)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Import Type"
        '
        'radKanjiText
        '
        Me.radKanjiText.AutoSize = True
        Me.radKanjiText.Location = New System.Drawing.Point(152, 20)
        Me.radKanjiText.Name = "radKanjiText"
        Me.radKanjiText.Size = New System.Drawing.Size(46, 17)
        Me.radKanjiText.TabIndex = 1
        Me.radKanjiText.Text = "Text"
        Me.radKanjiText.UseVisualStyleBackColor = True
        '
        'radKanjiExcel
        '
        Me.radKanjiExcel.AutoSize = True
        Me.radKanjiExcel.Checked = True
        Me.radKanjiExcel.Location = New System.Drawing.Point(9, 20)
        Me.radKanjiExcel.Name = "radKanjiExcel"
        Me.radKanjiExcel.Size = New System.Drawing.Size(51, 17)
        Me.radKanjiExcel.TabIndex = 0
        Me.radKanjiExcel.TabStop = True
        Me.radKanjiExcel.Text = "Excel"
        Me.radKanjiExcel.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnImgKanji)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txtImgKanjiDest)
        Me.GroupBox3.Controls.Add(Me.chkKanji)
        Me.GroupBox3.Location = New System.Drawing.Point(17, 127)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(548, 95)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Folder Import Kanji Image"
        '
        'btnImgKanji
        '
        Me.btnImgKanji.Location = New System.Drawing.Point(448, 47)
        Me.btnImgKanji.Name = "btnImgKanji"
        Me.btnImgKanji.Size = New System.Drawing.Size(75, 23)
        Me.btnImgKanji.TabIndex = 3
        Me.btnImgKanji.Text = "Browse"
        Me.btnImgKanji.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Destination"
        '
        'txtImgKanjiDest
        '
        Me.txtImgKanjiDest.Location = New System.Drawing.Point(78, 44)
        Me.txtImgKanjiDest.Name = "txtImgKanjiDest"
        Me.txtImgKanjiDest.Size = New System.Drawing.Size(355, 20)
        Me.txtImgKanjiDest.TabIndex = 1
        '
        'chkKanji
        '
        Me.chkKanji.AutoSize = True
        Me.chkKanji.Location = New System.Drawing.Point(6, 19)
        Me.chkKanji.Name = "chkKanji"
        Me.chkKanji.Size = New System.Drawing.Size(111, 17)
        Me.chkKanji.TabIndex = 0
        Me.chkKanji.Text = "Import kanji image"
        Me.chkKanji.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnVocImport)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.GroupBox5)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(595, 304)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Vocabulary"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnVocImport
        '
        Me.btnVocImport.Location = New System.Drawing.Point(353, 220)
        Me.btnVocImport.Name = "btnVocImport"
        Me.btnVocImport.Size = New System.Drawing.Size(75, 23)
        Me.btnVocImport.TabIndex = 10
        Me.btnVocImport.Text = "Import"
        Me.btnVocImport.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnVocDest)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.txtVocDest)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 99)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(437, 81)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Import destination"
        '
        'btnVocDest
        '
        Me.btnVocDest.Location = New System.Drawing.Point(345, 33)
        Me.btnVocDest.Name = "btnVocDest"
        Me.btnVocDest.Size = New System.Drawing.Size(75, 23)
        Me.btnVocDest.TabIndex = 2
        Me.btnVocDest.Text = "Browse"
        Me.btnVocDest.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Destination"
        '
        'txtVocDest
        '
        Me.txtVocDest.Location = New System.Drawing.Point(78, 33)
        Me.txtVocDest.Name = "txtVocDest"
        Me.txtVocDest.Size = New System.Drawing.Size(261, 20)
        Me.txtVocDest.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.radVocText)
        Me.GroupBox5.Controls.Add(Me.radVocExcel)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(104, 82)
        Me.GroupBox5.TabIndex = 7
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Import Type"
        '
        'radVocText
        '
        Me.radVocText.AutoSize = True
        Me.radVocText.Location = New System.Drawing.Point(9, 45)
        Me.radVocText.Name = "radVocText"
        Me.radVocText.Size = New System.Drawing.Size(46, 17)
        Me.radVocText.TabIndex = 1
        Me.radVocText.Text = "Text"
        Me.radVocText.UseVisualStyleBackColor = True
        '
        'radVocExcel
        '
        Me.radVocExcel.AutoSize = True
        Me.radVocExcel.Checked = True
        Me.radVocExcel.Location = New System.Drawing.Point(9, 20)
        Me.radVocExcel.Name = "radVocExcel"
        Me.radVocExcel.Size = New System.Drawing.Size(51, 17)
        Me.radVocExcel.TabIndex = 0
        Me.radVocExcel.TabStop = True
        Me.radVocExcel.Text = "Excel"
        Me.radVocExcel.UseVisualStyleBackColor = True
        '
        'ofdImport
        '
        Me.ofdImport.FileName = "OpenFileDialog1"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.tab)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(15, 16)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(632, 369)
        Me.GroupBox6.TabIndex = 20
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Import data from file"
        '
        'usrImport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox6)
        Me.Name = "usrImport"
        Me.Size = New System.Drawing.Size(768, 453)
        Me.tab.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tab As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnDestination As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDest As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radKanjiText As System.Windows.Forms.RadioButton
    Friend WithEvents radKanjiExcel As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnImgKanji As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtImgKanjiDest As System.Windows.Forms.TextBox
    Friend WithEvents chkKanji As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnVocDest As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtVocDest As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents radVocText As System.Windows.Forms.RadioButton
    Friend WithEvents radVocExcel As System.Windows.Forms.RadioButton
    Friend WithEvents fbdImport As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btnImportKanji As System.Windows.Forms.Button
    Friend WithEvents btnVocImport As System.Windows.Forms.Button
    Friend WithEvents ofdImport As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox

End Class

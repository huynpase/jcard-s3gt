<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrConvert
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnConvert = New System.Windows.Forms.Button
        Me.btnReset = New System.Windows.Forms.Button
        Me.chkImport = New System.Windows.Forms.CheckBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.btnOutBrowse = New System.Windows.Forms.Button
        Me.txtOutPath = New System.Windows.Forms.TextBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnInBrowse = New System.Windows.Forms.Button
        Me.txtInPath = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.txtGroupName = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.CmbExample = New System.Windows.Forms.ComboBox
        Me.CmbHanNom = New System.Windows.Forms.ComboBox
        Me.CmbMeaning = New System.Windows.Forms.ComboBox
        Me.CmbHiragana = New System.Windows.Forms.ComboBox
        Me.CmbKanji = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.fbdConvert = New System.Windows.Forms.FolderBrowserDialog
        Me.ofdConvert = New System.Windows.Forms.OpenFileDialog
        Me.sfdConvert = New System.Windows.Forms.SaveFileDialog
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnConvert)
        Me.GroupBox1.Controls.Add(Me.btnReset)
        Me.GroupBox1.Controls.Add(Me.chkImport)
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(666, 380)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Convert Glossary to Standard S3GT"
        '
        'btnConvert
        '
        Me.btnConvert.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvert.Location = New System.Drawing.Point(219, 351)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(97, 23)
        Me.btnConvert.TabIndex = 17
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(356, 351)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(97, 23)
        Me.btnReset.TabIndex = 16
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'chkImport
        '
        Me.chkImport.AutoSize = True
        Me.chkImport.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkImport.Location = New System.Drawing.Point(20, 328)
        Me.chkImport.Name = "chkImport"
        Me.chkImport.Size = New System.Drawing.Size(208, 17)
        Me.chkImport.TabIndex = 14
        Me.chkImport.Text = "Yes, I want to import this converted file"
        Me.chkImport.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label9)
        Me.GroupBox6.Controls.Add(Me.btnOutBrowse)
        Me.GroupBox6.Controls.Add(Me.txtOutPath)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(20, 278)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(627, 44)
        Me.GroupBox6.TabIndex = 13
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Output File"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(23, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Destination:"
        '
        'btnOutBrowse
        '
        Me.btnOutBrowse.Location = New System.Drawing.Point(508, 16)
        Me.btnOutBrowse.Name = "btnOutBrowse"
        Me.btnOutBrowse.Size = New System.Drawing.Size(97, 20)
        Me.btnOutBrowse.TabIndex = 2
        Me.btnOutBrowse.Text = "Browse"
        Me.btnOutBrowse.UseVisualStyleBackColor = True
        '
        'txtOutPath
        '
        Me.txtOutPath.Location = New System.Drawing.Point(125, 16)
        Me.txtOutPath.Name = "txtOutPath"
        Me.txtOutPath.Size = New System.Drawing.Size(377, 20)
        Me.txtOutPath.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.btnInBrowse)
        Me.GroupBox5.Controls.Add(Me.txtInPath)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(20, 227)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(627, 45)
        Me.GroupBox5.TabIndex = 7
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Input File"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Destination:"
        '
        'btnInBrowse
        '
        Me.btnInBrowse.Location = New System.Drawing.Point(508, 16)
        Me.btnInBrowse.Name = "btnInBrowse"
        Me.btnInBrowse.Size = New System.Drawing.Size(97, 20)
        Me.btnInBrowse.TabIndex = 2
        Me.btnInBrowse.Text = "Browse"
        Me.btnInBrowse.UseVisualStyleBackColor = True
        '
        'txtInPath
        '
        Me.txtInPath.Location = New System.Drawing.Point(125, 16)
        Me.txtInPath.Name = "txtInPath"
        Me.txtInPath.Size = New System.Drawing.Size(377, 20)
        Me.txtInPath.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(20, 29)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(627, 178)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Describe Glossary File"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtGroupName)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 20)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(305, 151)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Relative Name"
        '
        'txtGroupName
        '
        Me.txtGroupName.Location = New System.Drawing.Point(119, 21)
        Me.txtGroupName.Name = "txtGroupName"
        Me.txtGroupName.Size = New System.Drawing.Size(171, 20)
        Me.txtGroupName.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "TOPIC GROUP:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CmbExample)
        Me.GroupBox3.Controls.Add(Me.CmbHanNom)
        Me.GroupBox3.Controls.Add(Me.CmbMeaning)
        Me.GroupBox3.Controls.Add(Me.CmbHiragana)
        Me.GroupBox3.Controls.Add(Me.CmbKanji)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(317, 20)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(303, 151)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Fill Column Order Into Correlative Field"
        '
        'CmbExample
        '
        Me.CmbExample.Enabled = False
        Me.CmbExample.FormattingEnabled = True
        Me.CmbExample.Location = New System.Drawing.Point(87, 123)
        Me.CmbExample.Name = "CmbExample"
        Me.CmbExample.Size = New System.Drawing.Size(201, 21)
        Me.CmbExample.TabIndex = 14
        '
        'CmbHanNom
        '
        Me.CmbHanNom.Enabled = False
        Me.CmbHanNom.FormattingEnabled = True
        Me.CmbHanNom.Location = New System.Drawing.Point(87, 97)
        Me.CmbHanNom.Name = "CmbHanNom"
        Me.CmbHanNom.Size = New System.Drawing.Size(201, 21)
        Me.CmbHanNom.TabIndex = 13
        '
        'CmbMeaning
        '
        Me.CmbMeaning.Enabled = False
        Me.CmbMeaning.FormattingEnabled = True
        Me.CmbMeaning.Location = New System.Drawing.Point(87, 71)
        Me.CmbMeaning.Name = "CmbMeaning"
        Me.CmbMeaning.Size = New System.Drawing.Size(201, 21)
        Me.CmbMeaning.TabIndex = 12
        '
        'CmbHiragana
        '
        Me.CmbHiragana.Enabled = False
        Me.CmbHiragana.FormattingEnabled = True
        Me.CmbHiragana.Location = New System.Drawing.Point(87, 45)
        Me.CmbHiragana.Name = "CmbHiragana"
        Me.CmbHiragana.Size = New System.Drawing.Size(201, 21)
        Me.CmbHiragana.TabIndex = 11
        '
        'CmbKanji
        '
        Me.CmbKanji.Enabled = False
        Me.CmbKanji.FormattingEnabled = True
        Me.CmbKanji.Location = New System.Drawing.Point(87, 20)
        Me.CmbKanji.Name = "CmbKanji"
        Me.CmbKanji.Size = New System.Drawing.Size(201, 21)
        Me.CmbKanji.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "EXAMPLE:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "HANNOM:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "MEANING:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "HIRAGANA:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "KANJI:"
        '
        'ofdConvert
        '
        Me.ofdConvert.FileName = "ofdConvert"
        '
        'usrConvert
        '
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "usrConvert"
        Me.Size = New System.Drawing.Size(687, 404)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtGroupName As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents btnInBrowse As System.Windows.Forms.Button
    Friend WithEvents txtInPath As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnOutBrowse As System.Windows.Forms.Button
    Friend WithEvents txtOutPath As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents chkImport As System.Windows.Forms.CheckBox
    Friend WithEvents btnConvert As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents fbdConvert As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents ofdConvert As System.Windows.Forms.OpenFileDialog
    Friend WithEvents sfdConvert As System.Windows.Forms.SaveFileDialog
    Friend WithEvents CmbExample As System.Windows.Forms.ComboBox
    Friend WithEvents CmbHanNom As System.Windows.Forms.ComboBox
    Friend WithEvents CmbMeaning As System.Windows.Forms.ComboBox
    Friend WithEvents CmbHiragana As System.Windows.Forms.ComboBox
    Friend WithEvents CmbKanji As System.Windows.Forms.ComboBox

End Class

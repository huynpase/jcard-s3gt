<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrExport
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
        Me.btnKanji = New System.Windows.Forms.Button
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.btnUnCheckAll = New System.Windows.Forms.Button
        Me.btnCheckAll = New System.Windows.Forms.Button
        Me.treeKanji = New System.Windows.Forms.TreeView
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnKanjiDest = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtDest = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.radText = New System.Windows.Forms.RadioButton
        Me.radExcel = New System.Windows.Forms.RadioButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btnImgDest = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtImgKanjiDest = New System.Windows.Forms.TextBox
        Me.chkKanji = New System.Windows.Forms.CheckBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.btnVoc = New System.Windows.Forms.Button
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.tree = New System.Windows.Forms.TreeView
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.btnVocDest = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtVocDest = New System.Windows.Forms.TextBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.radVocText = New System.Windows.Forms.RadioButton
        Me.radVocExcel = New System.Windows.Forms.RadioButton
        Me.fbd = New System.Windows.Forms.FolderBrowserDialog
        Me.ofd = New System.Windows.Forms.OpenFileDialog
        Me.sfd = New System.Windows.Forms.FolderBrowserDialog
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.btn_SelectAll = New System.Windows.Forms.Button
        Me.btn_DeselectAll = New System.Windows.Forms.Button
        Me.tab.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.SuspendLayout()

        'GiangNVT modified
        '
        'tab
        '
        Me.tab.Controls.Add(Me.TabPage2)
        Me.tab.Controls.Add(Me.TabPage1)
        Me.tab.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab.Location = New System.Drawing.Point(18, 29)
        Me.tab.Name = "tab"
        Me.tab.SelectedIndex = 0
        Me.tab.Size = New System.Drawing.Size(671, 353)
        Me.tab.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnKanji)
        Me.TabPage1.Controls.Add(Me.GroupBox6)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(663, 327)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Kanji"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnKanji
        '
        Me.btnKanji.Location = New System.Drawing.Point(522, 285)
        Me.btnKanji.Name = "btnKanji"
        Me.btnKanji.Size = New System.Drawing.Size(75, 23)
        Me.btnKanji.TabIndex = 8
        Me.btnKanji.Text = "Export"
        Me.btnKanji.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.btnUnCheckAll)
        Me.GroupBox6.Controls.Add(Me.btnCheckAll)
        Me.GroupBox6.Controls.Add(Me.treeKanji)
        Me.GroupBox6.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(197, 321)
        Me.GroupBox6.TabIndex = 7
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Kanji List"
        '
        'btnUnCheckAll
        '
        Me.btnUnCheckAll.Location = New System.Drawing.Point(100, 20)
        Me.btnUnCheckAll.Name = "btnUnCheckAll"
        Me.btnUnCheckAll.Size = New System.Drawing.Size(75, 23)
        Me.btnUnCheckAll.TabIndex = 2
        Me.btnUnCheckAll.Text = "Un-check All"
        Me.btnUnCheckAll.UseVisualStyleBackColor = True
        '
        'btnCheckAll
        '
        Me.btnCheckAll.Location = New System.Drawing.Point(7, 20)
        Me.btnCheckAll.Name = "btnCheckAll"
        Me.btnCheckAll.Size = New System.Drawing.Size(75, 23)
        Me.btnCheckAll.TabIndex = 1
        Me.btnCheckAll.Text = "Check All"
        Me.btnCheckAll.UseVisualStyleBackColor = True
        '
        'treeKanji
        '
        Me.treeKanji.CheckBoxes = True
        Me.treeKanji.Location = New System.Drawing.Point(7, 51)
        Me.treeKanji.Name = "treeKanji"
        Me.treeKanji.Size = New System.Drawing.Size(184, 264)
        Me.treeKanji.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnKanjiDest)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtDest)
        Me.GroupBox2.Location = New System.Drawing.Point(203, 59)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(406, 76)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Export destination"
        '
        'btnKanjiDest
        '
        Me.btnKanjiDest.Location = New System.Drawing.Point(325, 33)
        Me.btnKanjiDest.Name = "btnKanjiDest"
        Me.btnKanjiDest.Size = New System.Drawing.Size(75, 23)
        Me.btnKanjiDest.TabIndex = 2
        Me.btnKanjiDest.Text = "Browse"
        Me.btnKanjiDest.UseVisualStyleBackColor = True
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
        Me.txtDest.Size = New System.Drawing.Size(241, 20)
        Me.txtDest.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radText)
        Me.GroupBox1.Controls.Add(Me.radExcel)
        Me.GroupBox1.Location = New System.Drawing.Point(203, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(284, 46)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Export Type"
        '
        'radText
        '
        Me.radText.AutoSize = True
        Me.radText.Location = New System.Drawing.Point(208, 17)
        Me.radText.Name = "radText"
        Me.radText.Size = New System.Drawing.Size(46, 17)
        Me.radText.TabIndex = 1
        Me.radText.TabStop = True
        Me.radText.Text = "Text"
        Me.radText.UseVisualStyleBackColor = True
        '
        'radExcel
        '
        Me.radExcel.AutoSize = True
        Me.radExcel.Checked = True
        Me.radExcel.Location = New System.Drawing.Point(9, 20)
        Me.radExcel.Name = "radExcel"
        Me.radExcel.Size = New System.Drawing.Size(51, 17)
        Me.radExcel.TabIndex = 0
        Me.radExcel.TabStop = True
        Me.radExcel.Text = "Excel"
        Me.radExcel.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnImgDest)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txtImgKanjiDest)
        Me.GroupBox3.Controls.Add(Me.chkKanji)
        Me.GroupBox3.Location = New System.Drawing.Point(203, 152)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(406, 81)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Export Kanji image"
        '
        'btnImgDest
        '
        Me.btnImgDest.Location = New System.Drawing.Point(320, 50)
        Me.btnImgDest.Name = "btnImgDest"
        Me.btnImgDest.Size = New System.Drawing.Size(75, 23)
        Me.btnImgDest.TabIndex = 3
        Me.btnImgDest.Text = "Browse"
        Me.btnImgDest.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Destination"
        '
        'txtImgKanjiDest
        '
        Me.txtImgKanjiDest.Location = New System.Drawing.Point(78, 50)
        Me.txtImgKanjiDest.Name = "txtImgKanjiDest"
        Me.txtImgKanjiDest.Size = New System.Drawing.Size(236, 20)
        Me.txtImgKanjiDest.TabIndex = 1
        '
        'chkKanji
        '
        Me.chkKanji.AutoSize = True
        Me.chkKanji.Location = New System.Drawing.Point(9, 17)
        Me.chkKanji.Name = "chkKanji"
        Me.chkKanji.Size = New System.Drawing.Size(112, 17)
        Me.chkKanji.TabIndex = 0
        Me.chkKanji.Text = "Export kanji image"
        Me.chkKanji.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnVoc)
        Me.TabPage2.Controls.Add(Me.GroupBox7)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.GroupBox5)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(663, 327)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Vocabulary"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnVoc
        '
        Me.btnVoc.Location = New System.Drawing.Point(579, 249)
        Me.btnVoc.Name = "btnVoc"
        Me.btnVoc.Size = New System.Drawing.Size(75, 23)
        Me.btnVoc.TabIndex = 11
        Me.btnVoc.Text = "Export"
        Me.btnVoc.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.btn_DeselectAll)
        Me.GroupBox7.Controls.Add(Me.btn_SelectAll)
        Me.GroupBox7.Controls.Add(Me.tree)
        Me.GroupBox7.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(236, 315)
        Me.GroupBox7.TabIndex = 10
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Select Topic"
        '
        'tree
        '
        Me.tree.CheckBoxes = True
        Me.tree.Location = New System.Drawing.Point(6, 48)
        Me.tree.Name = "tree"
        Me.tree.Size = New System.Drawing.Size(219, 261)
        Me.tree.TabIndex = 10
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnVocDest)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.txtVocDest)
        Me.GroupBox4.Location = New System.Drawing.Point(248, 101)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(406, 81)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Export destination"
        '
        'btnVocDest
        '
        Me.btnVocDest.Location = New System.Drawing.Point(325, 33)
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
        Me.txtVocDest.Size = New System.Drawing.Size(241, 20)
        Me.txtVocDest.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.radVocText)
        Me.GroupBox5.Controls.Add(Me.radVocExcel)
        Me.GroupBox5.Location = New System.Drawing.Point(248, 6)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(104, 76)
        Me.GroupBox5.TabIndex = 7
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Export Type"
        '
        'radVocText
        '
        Me.radVocText.AutoSize = True
        Me.radVocText.Location = New System.Drawing.Point(9, 43)
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
        'ofd
        '
        Me.ofd.FileName = "OpenFileDialog1"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.tab)
        Me.GroupBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(695, 390)
        Me.GroupBox8.TabIndex = 5
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Export data to file"
        '
        'btn_SelectAll
        '
        Me.btn_SelectAll.Location = New System.Drawing.Point(6, 17)
        Me.btn_SelectAll.Name = "btn_SelectAll"
        Me.btn_SelectAll.Size = New System.Drawing.Size(75, 23)
        Me.btn_SelectAll.TabIndex = 11
        Me.btn_SelectAll.Text = "Check All"
        Me.btn_SelectAll.UseVisualStyleBackColor = True
        '
        'btn_DeselectAll
        '
        Me.btn_DeselectAll.Location = New System.Drawing.Point(87, 17)
        Me.btn_DeselectAll.Name = "btn_DeselectAll"
        Me.btn_DeselectAll.Size = New System.Drawing.Size(75, 23)
        Me.btn_DeselectAll.TabIndex = 12
        Me.btn_DeselectAll.Text = "Uncheck All"
        Me.btn_DeselectAll.UseVisualStyleBackColor = True
        '
        'usrExport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox8)
        Me.Name = "usrExport"
        Me.Size = New System.Drawing.Size(788, 442)
        Me.tab.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tab As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnKanjiDest As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDest As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radText As System.Windows.Forms.RadioButton
    Friend WithEvents radExcel As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnImgDest As System.Windows.Forms.Button
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
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents tree As System.Windows.Forms.TreeView
    Friend WithEvents btnVoc As System.Windows.Forms.Button
    Friend WithEvents fbd As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents ofd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents sfd As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btnUnCheckAll As System.Windows.Forms.Button
    Friend WithEvents btnCheckAll As System.Windows.Forms.Button
    Friend WithEvents treeKanji As System.Windows.Forms.TreeView
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents btnKanji As System.Windows.Forms.Button
    Friend WithEvents btn_DeselectAll As System.Windows.Forms.Button
    Friend WithEvents btn_SelectAll As System.Windows.Forms.Button

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgSameVocabulary
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.btnSkip = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.dataVocabulary = New System.Windows.Forms.DataGridView
        Me.Check = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Kanji = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Hiragana = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Hannom = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Meaning = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Type = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.VocID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Example = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.lblMessageContent = New System.Windows.Forms.Label
        Me.chkApplyAll = New System.Windows.Forms.CheckBox
        Me.btnOverwrite = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        CType(Me.dataVocabulary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSkip
        '
        Me.btnSkip.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSkip.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSkip.Location = New System.Drawing.Point(574, 359)
        Me.btnSkip.Name = "btnSkip"
        Me.btnSkip.Size = New System.Drawing.Size(79, 30)
        Me.btnSkip.TabIndex = 1
        Me.btnSkip.Text = "&Skip"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.dataVocabulary)
        Me.Panel1.Location = New System.Drawing.Point(34, 94)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(619, 242)
        Me.Panel1.TabIndex = 2
        '
        'dataVocabulary
        '
        Me.dataVocabulary.AllowUserToAddRows = False
        Me.dataVocabulary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataVocabulary.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Check, Me.Kanji, Me.Hiragana, Me.Hannom, Me.Meaning, Me.Type, Me.VocID, Me.Example})
        Me.dataVocabulary.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataVocabulary.Location = New System.Drawing.Point(0, 0)
        Me.dataVocabulary.Name = "dataVocabulary"
        Me.dataVocabulary.Size = New System.Drawing.Size(619, 242)
        Me.dataVocabulary.TabIndex = 12
        '
        'Check
        '
        Me.Check.HeaderText = ""
        Me.Check.Name = "Check"
        Me.Check.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Check.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Check.Width = 30
        '
        'Kanji
        '
        Me.Kanji.DataPropertyName = "Kanji"
        Me.Kanji.HeaderText = "Kanji"
        Me.Kanji.Name = "Kanji"
        Me.Kanji.ReadOnly = True
        Me.Kanji.ToolTipText = "Kanji"
        '
        'Hiragana
        '
        Me.Hiragana.DataPropertyName = "Hiragana"
        DataGridViewCellStyle1.Format = "!= Nothing"
        Me.Hiragana.DefaultCellStyle = DataGridViewCellStyle1
        Me.Hiragana.HeaderText = "Reading"
        Me.Hiragana.Name = "Hiragana"
        Me.Hiragana.ReadOnly = True
        Me.Hiragana.ToolTipText = "Reading"
        '
        'Hannom
        '
        Me.Hannom.DataPropertyName = "Hannom"
        Me.Hannom.HeaderText = "Han Nom"
        Me.Hannom.Name = "Hannom"
        Me.Hannom.Width = 150
        '
        'Meaning
        '
        Me.Meaning.DataPropertyName = "Meaning"
        Me.Meaning.HeaderText = "Meaning"
        Me.Meaning.Name = "Meaning"
        Me.Meaning.ReadOnly = True
        Me.Meaning.ToolTipText = "Meaning of this word"
        Me.Meaning.Width = 255
        '
        'Type
        '
        DataGridViewCellStyle2.NullValue = "Noun"
        Me.Type.DefaultCellStyle = DataGridViewCellStyle2
        Me.Type.HeaderText = "Type"
        Me.Type.Items.AddRange(New Object() {"Noun", "Pro-noun", "Verb (Intransitive)", "Verb (Transitive)", "I Adj", "NA Adj", "Prep"})
        Me.Type.Name = "Type"
        Me.Type.ReadOnly = True
        Me.Type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Type.ToolTipText = " - vi (intransitive verb)  - vt (transitive verb)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " - adj (adjective)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " - adv (ad" & _
            "verb)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " - prep (prepostition)." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Type.Width = 90
        '
        'VocID
        '
        Me.VocID.HeaderText = ""
        Me.VocID.Name = "VocID"
        Me.VocID.Visible = False
        '
        'Example
        '
        Me.Example.HeaderText = "Example"
        Me.Example.Name = "Example"
        Me.Example.ReadOnly = True
        Me.Example.Width = 255
        '
        'lblMessageContent
        '
        Me.lblMessageContent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessageContent.Location = New System.Drawing.Point(31, 12)
        Me.lblMessageContent.Name = "lblMessageContent"
        Me.lblMessageContent.Size = New System.Drawing.Size(622, 79)
        Me.lblMessageContent.TabIndex = 1
        Me.lblMessageContent.Text = "Message Content"
        Me.lblMessageContent.UseCompatibleTextRendering = True
        '
        'chkApplyAll
        '
        Me.chkApplyAll.AutoSize = True
        Me.chkApplyAll.Location = New System.Drawing.Point(373, 367)
        Me.chkApplyAll.Name = "chkApplyAll"
        Me.chkApplyAll.Size = New System.Drawing.Size(77, 17)
        Me.chkApplyAll.TabIndex = 5
        Me.chkApplyAll.Text = "Apply to all"
        Me.chkApplyAll.UseVisualStyleBackColor = True
        '
        'btnOverwrite
        '
        Me.btnOverwrite.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnOverwrite.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnOverwrite.Location = New System.Drawing.Point(471, 359)
        Me.btnOverwrite.Name = "btnOverwrite"
        Me.btnOverwrite.Size = New System.Drawing.Size(79, 30)
        Me.btnOverwrite.TabIndex = 1
        Me.btnOverwrite.Text = "&Overwrite"
        '
        'dlgSameVocabulary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 456)
        Me.Controls.Add(Me.btnOverwrite)
        Me.Controls.Add(Me.btnSkip)
        Me.Controls.Add(Me.chkApplyAll)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblMessageContent)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgSameVocabulary"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Warning Vocabularies having same Hiragana/Katakana and Kanji "
        Me.Panel1.ResumeLayout(False)
        CType(Me.dataVocabulary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblMessageContent As System.Windows.Forms.Label
    Private WithEvents dataVocabulary As System.Windows.Forms.DataGridView
    Friend WithEvents btnSkip As System.Windows.Forms.Button
    Friend WithEvents Check As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Kanji As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Hiragana As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Hannom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Meaning As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Type As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents VocID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Example As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chkApplyAll As System.Windows.Forms.CheckBox
    Friend WithEvents btnOverwrite As System.Windows.Forms.Button

End Class

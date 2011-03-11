<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrMoveAndCopy
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.cboTopicName = New System.Windows.Forms.ComboBox
        Me.label1 = New System.Windows.Forms.Label
        Me.cboTopicGroupName = New System.Windows.Forms.ComboBox
        Me.label2 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnCopy = New System.Windows.Forms.Button
        Me.btnMove = New System.Windows.Forms.Button
        Me.dataVocabulary = New System.Windows.Forms.DataGridView
        Me.Label3 = New System.Windows.Forms.Label
        Me.lnkCreateTopic = New System.Windows.Forms.LinkLabel
        Me.Check = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Kanji = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Hiragana = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HanNom = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Meaning = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Type = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.Vocabulary_ID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Example = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel1.SuspendLayout()
        CType(Me.dataVocabulary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboTopicName
        '
        Me.cboTopicName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboTopicName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTopicName.FormattingEnabled = True
        Me.cboTopicName.Location = New System.Drawing.Point(264, 99)
        Me.cboTopicName.Name = "cboTopicName"
        Me.cboTopicName.Size = New System.Drawing.Size(372, 21)
        Me.cboTopicName.Sorted = True
        Me.cboTopicName.TabIndex = 15
        '
        'label1
        '
        Me.label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label1.AutoSize = True
        Me.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.label1.Location = New System.Drawing.Point(152, 64)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(97, 13)
        Me.label1.TabIndex = 18
        Me.label1.Text = "Topic Group Name"
        '
        'cboTopicGroupName
        '
        Me.cboTopicGroupName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboTopicGroupName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTopicGroupName.FormattingEnabled = True
        Me.cboTopicGroupName.Location = New System.Drawing.Point(264, 61)
        Me.cboTopicGroupName.Name = "cboTopicGroupName"
        Me.cboTopicGroupName.Size = New System.Drawing.Size(372, 21)
        Me.cboTopicGroupName.Sorted = True
        Me.cboTopicGroupName.TabIndex = 16
        '
        'label2
        '
        Me.label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label2.AutoSize = True
        Me.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.label2.Location = New System.Drawing.Point(184, 102)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(65, 13)
        Me.label2.TabIndex = 17
        Me.label2.Text = "Topic Name"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.btnCopy)
        Me.Panel1.Controls.Add(Me.btnMove)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 407)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(823, 66)
        Me.Panel1.TabIndex = 21
        '
        'btnCopy
        '
        Me.btnCopy.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnCopy.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCopy.Location = New System.Drawing.Point(261, 16)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(75, 30)
        Me.btnCopy.TabIndex = 11
        Me.btnCopy.Text = "&Copy"
        Me.btnCopy.UseVisualStyleBackColor = True
        '
        'btnMove
        '
        Me.btnMove.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnMove.AutoSize = True
        Me.btnMove.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnMove.Location = New System.Drawing.Point(138, 16)
        Me.btnMove.Name = "btnMove"
        Me.btnMove.Size = New System.Drawing.Size(81, 30)
        Me.btnMove.TabIndex = 11
        Me.btnMove.Text = "&Move"
        Me.btnMove.UseVisualStyleBackColor = True
        '
        'dataVocabulary
        '
        Me.dataVocabulary.AllowUserToAddRows = False
        Me.dataVocabulary.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataVocabulary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataVocabulary.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Check, Me.Kanji, Me.Hiragana, Me.HanNom, Me.Meaning, Me.Type, Me.Vocabulary_ID, Me.Example})
        Me.dataVocabulary.Location = New System.Drawing.Point(9, 143)
        Me.dataVocabulary.Name = "dataVocabulary"
        Me.dataVocabulary.Size = New System.Drawing.Size(820, 258)
        Me.dataVocabulary.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(823, 35)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Move and Copy Vocabularies"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lnkCreateTopic
        '
        Me.lnkCreateTopic.AutoSize = True
        Me.lnkCreateTopic.Location = New System.Drawing.Point(261, 123)
        Me.lnkCreateTopic.Name = "lnkCreateTopic"
        Me.lnkCreateTopic.Size = New System.Drawing.Size(100, 13)
        Me.lnkCreateTopic.TabIndex = 23
        Me.lnkCreateTopic.TabStop = True
        Me.lnkCreateTopic.Text = "Create new Topic..."
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
        Me.Kanji.HeaderText = "Kanji"
        Me.Kanji.Name = "Kanji"
        Me.Kanji.ReadOnly = True
        Me.Kanji.ToolTipText = "Kanji"
        Me.Kanji.Width = 120
        '
        'Hiragana
        '
        DataGridViewCellStyle1.Format = "!= Nothing"
        Me.Hiragana.DefaultCellStyle = DataGridViewCellStyle1
        Me.Hiragana.HeaderText = "Reading"
        Me.Hiragana.Name = "Hiragana"
        Me.Hiragana.ReadOnly = True
        Me.Hiragana.ToolTipText = "Reading"
        '
        'HanNom
        '
        Me.HanNom.HeaderText = "HanNom"
        Me.HanNom.Name = "HanNom"
        Me.HanNom.Width = 120
        '
        'Meaning
        '
        Me.Meaning.HeaderText = "Meaning"
        Me.Meaning.Name = "Meaning"
        Me.Meaning.ReadOnly = True
        Me.Meaning.ToolTipText = "Meaning of this word"
        Me.Meaning.Width = 180
        '
        'Type
        '
        DataGridViewCellStyle2.NullValue = "Noun"
        Me.Type.DefaultCellStyle = DataGridViewCellStyle2
        Me.Type.HeaderText = "Type"
        Me.Type.Items.AddRange(New Object() {"", "Noun", "Pro-noun", "Verb (Intransitive)", "Verb (Transitive)Å@", "I Adj", "NA Adj", "Prep"})
        Me.Type.Name = "Type"
        Me.Type.ReadOnly = True
        Me.Type.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Type.ToolTipText = " - vi (intransitive verb)  - vt (transitive verb)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " - adj (adjective)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " - adv (ad" & _
            "verb)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " - prep (prepostition)." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Type.Width = 90
        '
        'Vocabulary_ID
        '
        Me.Vocabulary_ID.DataPropertyName = "Vocabulary_ID"
        Me.Vocabulary_ID.HeaderText = ""
        Me.Vocabulary_ID.Name = "Vocabulary_ID"
        Me.Vocabulary_ID.Visible = False
        '
        'Example
        '
        Me.Example.HeaderText = "Example"
        Me.Example.Name = "Example"
        Me.Example.Width = 128
        '
        'usrMoveAndCopy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lnkCreateTopic)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboTopicName)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.cboTopicGroupName)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dataVocabulary)
        Me.Name = "usrMoveAndCopy"
        Me.Size = New System.Drawing.Size(823, 473)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dataVocabulary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents cboTopicName As System.Windows.Forms.ComboBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents cboTopicGroupName As System.Windows.Forms.ComboBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents btnCopy As System.Windows.Forms.Button
    Private WithEvents btnMove As System.Windows.Forms.Button
    Private WithEvents dataVocabulary As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lnkCreateTopic As System.Windows.Forms.LinkLabel
    Friend WithEvents Check As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Kanji As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Hiragana As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HanNom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Meaning As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Type As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Vocabulary_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Example As System.Windows.Forms.DataGridViewTextBoxColumn

End Class

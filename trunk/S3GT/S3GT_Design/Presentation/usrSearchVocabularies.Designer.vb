<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrSearchVocabularies
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.grbSearchCondition = New System.Windows.Forms.GroupBox
        Me.cboSearchBy = New System.Windows.Forms.ComboBox
        Me.txtInputKeyword = New System.Windows.Forms.TextBox
        Me.btnCancel = New System.Windows.Forms.Button
        Me.cboTopicName = New System.Windows.Forms.ComboBox
        Me.btnSearch = New System.Windows.Forms.Button
        Me.cboTopicGroupName = New System.Windows.Forms.ComboBox
        Me.cmbSourceForm = New System.Windows.Forms.ComboBox
        Me.lblInputKeyword = New System.Windows.Forms.Label
        Me.lblTopicName = New System.Windows.Forms.Label
        Me.lblTopicGroupName = New System.Windows.Forms.Label
        Me.lblSourceForm = New System.Windows.Forms.Label
        Me.lblTitle = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnSubmit = New System.Windows.Forms.Button
        Me.dataVocabulary = New System.Windows.Forms.DataGridView
        Me.Check = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.TopicGroup = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TopicName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Kanji = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Hiragana = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Hannom = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Meaning = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Type = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.Vocabulary_ID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Example = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Topic_ID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.modified = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.grbSearchCondition.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dataVocabulary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grbSearchCondition
        '
        Me.grbSearchCondition.AutoSize = True
        Me.grbSearchCondition.Controls.Add(Me.cboSearchBy)
        Me.grbSearchCondition.Controls.Add(Me.txtInputKeyword)
        Me.grbSearchCondition.Controls.Add(Me.btnCancel)
        Me.grbSearchCondition.Controls.Add(Me.cboTopicName)
        Me.grbSearchCondition.Controls.Add(Me.btnSearch)
        Me.grbSearchCondition.Controls.Add(Me.cboTopicGroupName)
        Me.grbSearchCondition.Controls.Add(Me.cmbSourceForm)
        Me.grbSearchCondition.Controls.Add(Me.lblInputKeyword)
        Me.grbSearchCondition.Controls.Add(Me.lblTopicName)
        Me.grbSearchCondition.Controls.Add(Me.lblTopicGroupName)
        Me.grbSearchCondition.Controls.Add(Me.lblSourceForm)
        Me.grbSearchCondition.Location = New System.Drawing.Point(26, 24)
        Me.grbSearchCondition.Name = "grbSearchCondition"
        Me.grbSearchCondition.Size = New System.Drawing.Size(422, 179)
        Me.grbSearchCondition.TabIndex = 0
        Me.grbSearchCondition.TabStop = False
        Me.grbSearchCondition.Text = "Search Condition"
        '
        'cboSearchBy
        '
        Me.cboSearchBy.FormattingEnabled = True
        Me.cboSearchBy.Items.AddRange(New Object() {"Include", "Start with", "End with"})
        Me.cboSearchBy.Location = New System.Drawing.Point(278, 110)
        Me.cboSearchBy.Name = "cboSearchBy"
        Me.cboSearchBy.Size = New System.Drawing.Size(102, 21)
        Me.cboSearchBy.TabIndex = 8
        Me.cboSearchBy.Text = "Include"
        '
        'txtInputKeyword
        '
        Me.txtInputKeyword.Location = New System.Drawing.Point(141, 111)
        Me.txtInputKeyword.Name = "txtInputKeyword"
        Me.txtInputKeyword.Size = New System.Drawing.Size(121, 20)
        Me.txtInputKeyword.TabIndex = 7
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(249, 137)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'cboTopicName
        '
        Me.cboTopicName.FormattingEnabled = True
        Me.cboTopicName.Location = New System.Drawing.Point(141, 82)
        Me.cboTopicName.Name = "cboTopicName"
        Me.cboTopicName.Size = New System.Drawing.Size(121, 21)
        Me.cboTopicName.TabIndex = 6
        Me.cboTopicName.Text = "All topic"
        '
        'btnSearch
        '
        Me.btnSearch.Enabled = False
        Me.btnSearch.Location = New System.Drawing.Point(141, 137)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'cboTopicGroupName
        '
        Me.cboTopicGroupName.FormattingEnabled = True
        Me.cboTopicGroupName.Location = New System.Drawing.Point(141, 52)
        Me.cboTopicGroupName.Name = "cboTopicGroupName"
        Me.cboTopicGroupName.Size = New System.Drawing.Size(121, 21)
        Me.cboTopicGroupName.TabIndex = 5
        Me.cboTopicGroupName.Text = "All group"
        '
        'cmbSourceForm
        '
        Me.cmbSourceForm.FormattingEnabled = True
        Me.cmbSourceForm.Items.AddRange(New Object() {"All", "Hiragana/Katakana", "Kanji", "Han Nom", "Meaning"})
        Me.cmbSourceForm.Location = New System.Drawing.Point(141, 20)
        Me.cmbSourceForm.Name = "cmbSourceForm"
        Me.cmbSourceForm.Size = New System.Drawing.Size(121, 21)
        Me.cmbSourceForm.TabIndex = 4
        Me.cmbSourceForm.Text = "All"
        '
        'lblInputKeyword
        '
        Me.lblInputKeyword.AutoSize = True
        Me.lblInputKeyword.Location = New System.Drawing.Point(42, 111)
        Me.lblInputKeyword.Name = "lblInputKeyword"
        Me.lblInputKeyword.Size = New System.Drawing.Size(75, 13)
        Me.lblInputKeyword.TabIndex = 3
        Me.lblInputKeyword.Text = "Input Keyword"
        '
        'lblTopicName
        '
        Me.lblTopicName.AutoSize = True
        Me.lblTopicName.Location = New System.Drawing.Point(42, 82)
        Me.lblTopicName.Name = "lblTopicName"
        Me.lblTopicName.Size = New System.Drawing.Size(65, 13)
        Me.lblTopicName.TabIndex = 2
        Me.lblTopicName.Text = "Inside Topic"
        '
        'lblTopicGroupName
        '
        Me.lblTopicGroupName.AutoSize = True
        Me.lblTopicGroupName.Location = New System.Drawing.Point(42, 54)
        Me.lblTopicGroupName.Name = "lblTopicGroupName"
        Me.lblTopicGroupName.Size = New System.Drawing.Size(67, 13)
        Me.lblTopicGroupName.TabIndex = 1
        Me.lblTopicGroupName.Text = "Inside Group"
        '
        'lblSourceForm
        '
        Me.lblSourceForm.AutoSize = True
        Me.lblSourceForm.Location = New System.Drawing.Point(42, 25)
        Me.lblSourceForm.Name = "lblSourceForm"
        Me.lblSourceForm.Size = New System.Drawing.Size(56, 13)
        Me.lblSourceForm.TabIndex = 0
        Me.lblSourceForm.Text = "Search By"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblTitle.Location = New System.Drawing.Point(26, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(145, 17)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "Search Vocabulary"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Controls.Add(Me.btnSubmit)
        Me.Panel1.Controls.Add(Me.dataVocabulary)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 223)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(715, 217)
        Me.Panel1.TabIndex = 21
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnDelete.Enabled = False
        Me.btnDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnDelete.Location = New System.Drawing.Point(311, 184)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 30)
        Me.btnDelete.TabIndex = 23
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSubmit.AutoSize = True
        Me.btnSubmit.Enabled = False
        Me.btnSubmit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSubmit.Location = New System.Drawing.Point(217, 184)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(84, 30)
        Me.btnSubmit.TabIndex = 22
        Me.btnSubmit.Text = "&Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'dataVocabulary
        '
        Me.dataVocabulary.AllowUserToAddRows = False
        Me.dataVocabulary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataVocabulary.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Check, Me.TopicGroup, Me.TopicName, Me.Kanji, Me.Hiragana, Me.Hannom, Me.Meaning, Me.Type, Me.Vocabulary_ID, Me.Example, Me.Topic_ID, Me.modified})
        Me.dataVocabulary.Dock = System.Windows.Forms.DockStyle.Top
        Me.dataVocabulary.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.dataVocabulary.Location = New System.Drawing.Point(0, 0)
        Me.dataVocabulary.Name = "dataVocabulary"
        Me.dataVocabulary.Size = New System.Drawing.Size(715, 178)
        Me.dataVocabulary.TabIndex = 21
        '
        'Check
        '
        Me.Check.Frozen = True
        Me.Check.HeaderText = ""
        Me.Check.Name = "Check"
        Me.Check.TrueValue = "-1"
        Me.Check.Width = 20
        '
        'TopicGroup
        '
        Me.TopicGroup.Frozen = True
        Me.TopicGroup.HeaderText = "Topic Group"
        Me.TopicGroup.Name = "TopicGroup"
        Me.TopicGroup.ReadOnly = True
        '
        'TopicName
        '
        Me.TopicName.Frozen = True
        Me.TopicName.HeaderText = "Topic"
        Me.TopicName.Name = "TopicName"
        Me.TopicName.ReadOnly = True
        '
        'Kanji
        '
        Me.Kanji.DataPropertyName = "Kanji"
        DataGridViewCellStyle1.NullValue = " "
        Me.Kanji.DefaultCellStyle = DataGridViewCellStyle1
        Me.Kanji.Frozen = True
        Me.Kanji.HeaderText = "Kanji"
        Me.Kanji.MinimumWidth = 30
        Me.Kanji.Name = "Kanji"
        Me.Kanji.Width = 80
        '
        'Hiragana
        '
        Me.Hiragana.DataPropertyName = "Hiragana"
        DataGridViewCellStyle2.Format = "!= Nothing"
        Me.Hiragana.DefaultCellStyle = DataGridViewCellStyle2
        Me.Hiragana.Frozen = True
        Me.Hiragana.HeaderText = "Reading"
        Me.Hiragana.MinimumWidth = 50
        Me.Hiragana.Name = "Hiragana"
        Me.Hiragana.Width = 90
        '
        'Hannom
        '
        Me.Hannom.DataPropertyName = "Hannom"
        DataGridViewCellStyle3.NullValue = " "
        Me.Hannom.DefaultCellStyle = DataGridViewCellStyle3
        Me.Hannom.HeaderText = "Han Nom"
        Me.Hannom.MinimumWidth = 50
        Me.Hannom.Name = "Hannom"
        Me.Hannom.Width = 110
        '
        'Meaning
        '
        Me.Meaning.DataPropertyName = "Meaning"
        DataGridViewCellStyle4.NullValue = " "
        Me.Meaning.DefaultCellStyle = DataGridViewCellStyle4
        Me.Meaning.HeaderText = "Meaning"
        Me.Meaning.MinimumWidth = 50
        Me.Meaning.Name = "Meaning"
        Me.Meaning.Width = 250
        '
        'Type
        '
        DataGridViewCellStyle5.NullValue = "Noun"
        Me.Type.DefaultCellStyle = DataGridViewCellStyle5
        Me.Type.HeaderText = "Type"
        Me.Type.Items.AddRange(New Object() {"I Adj", "NA Adj", "Noun", "Prep", "Pro-noun", "Verb (Intransitive)", "Verb (Transitive)"})
        Me.Type.MinimumWidth = 50
        Me.Type.Name = "Type"
        Me.Type.Width = 60
        '
        'Vocabulary_ID
        '
        Me.Vocabulary_ID.DataPropertyName = "Vocabulary_ID"
        Me.Vocabulary_ID.HeaderText = ""
        Me.Vocabulary_ID.Name = "Vocabulary_ID"
        Me.Vocabulary_ID.Visible = False
        Me.Vocabulary_ID.Width = 5
        '
        'Example
        '
        Me.Example.HeaderText = "Example"
        Me.Example.MinimumWidth = 50
        Me.Example.Name = "Example"
        Me.Example.Width = 300
        '
        'Topic_ID
        '
        Me.Topic_ID.DataPropertyName = "Topic_ID"
        Me.Topic_ID.HeaderText = ""
        Me.Topic_ID.Name = "Topic_ID"
        Me.Topic_ID.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Topic_ID.Visible = False
        Me.Topic_ID.Width = 5
        '
        'modified
        '
        Me.modified.HeaderText = "modified"
        Me.modified.Name = "modified"
        Me.modified.ReadOnly = True
        Me.modified.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.modified.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.modified.Visible = False
        Me.modified.Width = 5
        '
        'usrSearchVocabularies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.grbSearchCondition)
        Me.Name = "usrSearchVocabularies"
        Me.Size = New System.Drawing.Size(715, 440)
        Me.grbSearchCondition.ResumeLayout(False)
        Me.grbSearchCondition.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dataVocabulary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grbSearchCondition As System.Windows.Forms.GroupBox
    Friend WithEvents lblTopicGroupName As System.Windows.Forms.Label
    Friend WithEvents lblSourceForm As System.Windows.Forms.Label
    Friend WithEvents lblTopicName As System.Windows.Forms.Label
    Friend WithEvents lblInputKeyword As System.Windows.Forms.Label
    Friend WithEvents txtInputKeyword As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Private WithEvents cboTopicName As System.Windows.Forms.ComboBox
    Private WithEvents cboTopicGroupName As System.Windows.Forms.ComboBox
    Private WithEvents cmbSourceForm As System.Windows.Forms.ComboBox
    Private WithEvents cboSearchBy As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents btnDelete As System.Windows.Forms.Button
    Private WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents dataVocabulary As System.Windows.Forms.DataGridView
    Friend WithEvents Check As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents TopicGroup As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TopicName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Kanji As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Hiragana As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Hannom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Meaning As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Type As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Vocabulary_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Example As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Topic_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents modified As System.Windows.Forms.DataGridViewCheckBoxColumn

End Class

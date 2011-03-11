<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrVocabularies
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrVocabularies))
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.lnkCreateTopic = New System.Windows.Forms.LinkLabel
        Me.label2 = New System.Windows.Forms.Label
        Me.cboTopicName = New System.Windows.Forms.ComboBox
        Me.label1 = New System.Windows.Forms.Label
        Me.cboTopicGroupName = New System.Windows.Forms.ComboBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnFillHanNom = New System.Windows.Forms.Button
        Me.btnFillHiragana = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnSubmit = New System.Windows.Forms.Button
        Me.btnMoveAndCopy = New System.Windows.Forms.Button
        Me.btnReset = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.dataVocabulary = New System.Windows.Forms.DataGridView
        Me.Check = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Kanji = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Hiragana = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Hannom = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Meaning = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Type = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.Vocabulary_ID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Example = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.modified = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.checkDuplicated = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btn_DeSelectAll = New System.Windows.Forms.Button
        Me.btn_SelectAll = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dataVocabulary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lnkCreateTopic
        '
        resources.ApplyResources(Me.lnkCreateTopic, "lnkCreateTopic")
        Me.lnkCreateTopic.Name = "lnkCreateTopic"
        Me.lnkCreateTopic.TabStop = True
        '
        'label2
        '
        resources.ApplyResources(Me.label2, "label2")
        Me.label2.Name = "label2"
        '
        'cboTopicName
        '
        Me.cboTopicName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.cboTopicName, "cboTopicName")
        Me.cboTopicName.FormattingEnabled = True
        Me.cboTopicName.MaximumSize = New System.Drawing.Size(250, 0)
        Me.cboTopicName.Name = "cboTopicName"
        Me.cboTopicName.Sorted = True
        '
        'label1
        '
        resources.ApplyResources(Me.label1, "label1")
        Me.label1.Name = "label1"
        '
        'cboTopicGroupName
        '
        Me.cboTopicGroupName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.cboTopicGroupName, "cboTopicGroupName")
        Me.cboTopicGroupName.FormattingEnabled = True
        Me.cboTopicGroupName.MaximumSize = New System.Drawing.Size(250, 0)
        Me.cboTopicGroupName.Name = "cboTopicGroupName"
        Me.cboTopicGroupName.Sorted = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.btnFillHanNom)
        Me.Panel1.Controls.Add(Me.btnFillHiragana)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btnSubmit)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'btnFillHanNom
        '
        resources.ApplyResources(Me.btnFillHanNom, "btnFillHanNom")
        Me.btnFillHanNom.Name = "btnFillHanNom"
        Me.btnFillHanNom.UseVisualStyleBackColor = True
        '
        'btnFillHiragana
        '
        resources.ApplyResources(Me.btnFillHiragana, "btnFillHiragana")
        Me.btnFillHiragana.Name = "btnFillHiragana"
        Me.btnFillHiragana.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        resources.ApplyResources(Me.btnCancel, "btnCancel")
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        resources.ApplyResources(Me.btnSubmit, "btnSubmit")
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnMoveAndCopy
        '
        resources.ApplyResources(Me.btnMoveAndCopy, "btnMoveAndCopy")
        Me.btnMoveAndCopy.Name = "btnMoveAndCopy"
        Me.btnMoveAndCopy.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        resources.ApplyResources(Me.btnReset, "btnReset")
        Me.btnReset.Name = "btnReset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        resources.ApplyResources(Me.btnDelete, "btnDelete")
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Controls.Add(Me.dataVocabulary)
        Me.Panel2.Name = "Panel2"
        '
        'dataVocabulary
        '
        Me.dataVocabulary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataVocabulary.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Check, Me.Kanji, Me.Hiragana, Me.Hannom, Me.Meaning, Me.Type, Me.Vocabulary_ID, Me.Example, Me.modified, Me.checkDuplicated})
        resources.ApplyResources(Me.dataVocabulary, "dataVocabulary")
        Me.dataVocabulary.Name = "dataVocabulary"
        Me.dataVocabulary.ShowCellToolTips = False
        '
        'Check
        '
        Me.Check.Frozen = True
        resources.ApplyResources(Me.Check, "Check")
        Me.Check.Name = "Check"
        Me.Check.TrueValue = "-1"
        '
        'Kanji
        '
        Me.Kanji.DataPropertyName = "Kanji"
        DataGridViewCellStyle6.NullValue = " "
        Me.Kanji.DefaultCellStyle = DataGridViewCellStyle6
        Me.Kanji.Frozen = True
        resources.ApplyResources(Me.Kanji, "Kanji")
        Me.Kanji.Name = "Kanji"
        '
        'Hiragana
        '
        Me.Hiragana.DataPropertyName = "Hiragana"
        DataGridViewCellStyle7.Format = "!= Nothing"
        Me.Hiragana.DefaultCellStyle = DataGridViewCellStyle7
        Me.Hiragana.Frozen = True
        resources.ApplyResources(Me.Hiragana, "Hiragana")
        Me.Hiragana.Name = "Hiragana"
        '
        'Hannom
        '
        Me.Hannom.DataPropertyName = "Hannom"
        DataGridViewCellStyle8.NullValue = " "
        Me.Hannom.DefaultCellStyle = DataGridViewCellStyle8
        resources.ApplyResources(Me.Hannom, "Hannom")
        Me.Hannom.Name = "Hannom"
        '
        'Meaning
        '
        Me.Meaning.DataPropertyName = "Meaning"
        DataGridViewCellStyle9.NullValue = " "
        Me.Meaning.DefaultCellStyle = DataGridViewCellStyle9
        resources.ApplyResources(Me.Meaning, "Meaning")
        Me.Meaning.Name = "Meaning"
        '
        'Type
        '
        DataGridViewCellStyle10.NullValue = "Noun"
        Me.Type.DefaultCellStyle = DataGridViewCellStyle10
        resources.ApplyResources(Me.Type, "Type")
        Me.Type.Items.AddRange(New Object() {"I Adj", "NA Adj", "Noun", "Prep", "Pro-noun", "Verb (Intransitive)", "Verb (Transitive)"})
        Me.Type.Name = "Type"
        '
        'Vocabulary_ID
        '
        Me.Vocabulary_ID.DataPropertyName = "Vocabulary_ID"
        resources.ApplyResources(Me.Vocabulary_ID, "Vocabulary_ID")
        Me.Vocabulary_ID.Name = "Vocabulary_ID"
        '
        'Example
        '
        resources.ApplyResources(Me.Example, "Example")
        Me.Example.Name = "Example"
        '
        'modified
        '
        resources.ApplyResources(Me.modified, "modified")
        Me.modified.Name = "modified"
        Me.modified.ReadOnly = True
        '
        'checkDuplicated
        '
        resources.ApplyResources(Me.checkDuplicated, "checkDuplicated")
        Me.checkDuplicated.Name = "checkDuplicated"
        Me.checkDuplicated.ReadOnly = True
        Me.checkDuplicated.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.checkDuplicated.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'GroupBox1
        '
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Controls.Add(Me.btn_DeSelectAll)
        Me.GroupBox1.Controls.Add(Me.btn_SelectAll)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.btnMoveAndCopy)
        Me.GroupBox1.Controls.Add(Me.btnReset)
        Me.GroupBox1.Controls.Add(Me.cboTopicGroupName)
        Me.GroupBox1.Controls.Add(Me.label1)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.lnkCreateTopic)
        Me.GroupBox1.Controls.Add(Me.cboTopicName)
        Me.GroupBox1.Controls.Add(Me.label2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'btn_DeSelectAll
        '
        resources.ApplyResources(Me.btn_DeSelectAll, "btn_DeSelectAll")
        Me.btn_DeSelectAll.Name = "btn_DeSelectAll"
        Me.btn_DeSelectAll.UseVisualStyleBackColor = True
        '
        'btn_SelectAll
        '
        resources.ApplyResources(Me.btn_SelectAll, "btn_SelectAll")
        Me.btn_SelectAll.Name = "btn_SelectAll"
        Me.btn_SelectAll.UseVisualStyleBackColor = True
        '
        'usrVocabularies
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "usrVocabularies"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dataVocabulary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents lnkCreateTopic As System.Windows.Forms.LinkLabel
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents cboTopicName As System.Windows.Forms.ComboBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents cboTopicGroupName As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents btnCancel As System.Windows.Forms.Button
    Private WithEvents btnMoveAndCopy As System.Windows.Forms.Button
    Private WithEvents btnReset As System.Windows.Forms.Button
    Private WithEvents btnDelete As System.Windows.Forms.Button
    Private WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dataVocabulary As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_SelectAll As System.Windows.Forms.Button
    Friend WithEvents btn_DeSelectAll As System.Windows.Forms.Button
    Friend WithEvents btnFillHiragana As System.Windows.Forms.Button
    Friend WithEvents btnFillHanNom As System.Windows.Forms.Button
    Friend WithEvents Check As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Kanji As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Hiragana As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Hannom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Meaning As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Type As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Vocabulary_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Example As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents modified As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents checkDuplicated As System.Windows.Forms.DataGridViewCheckBoxColumn

End Class

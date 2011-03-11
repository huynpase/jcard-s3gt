<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrSearchSingleKanji
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
        Me.lblSearch = New System.Windows.Forms.Label
        Me.txtSingleKanji = New System.Windows.Forms.TextBox
        Me.DataKanji = New System.Windows.Forms.DataGridView
        Me.cmbSearchSingleKanji = New System.Windows.Forms.ComboBox
        Me.btnSearch = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Kanj = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HanNom = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Kunyomi = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Onyomi = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Meaning = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Kakikata = New System.Windows.Forms.DataGridViewLinkColumn
        CType(Me.DataKanji, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch.Location = New System.Drawing.Point(18, 25)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(51, 13)
        Me.lblSearch.TabIndex = 0
        Me.lblSearch.Text = "Keyword:"
        '
        'txtSingleKanji
        '
        Me.txtSingleKanji.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSingleKanji.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSingleKanji.Location = New System.Drawing.Point(81, 22)
        Me.txtSingleKanji.Name = "txtSingleKanji"
        Me.txtSingleKanji.Size = New System.Drawing.Size(100, 20)
        Me.txtSingleKanji.TabIndex = 1
        '
        'DataKanji
        '
        Me.DataKanji.AllowUserToOrderColumns = True
        Me.DataKanji.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataKanji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataKanji.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Kanj, Me.HanNom, Me.Kunyomi, Me.Onyomi, Me.Meaning, Me.Kakikata})
        Me.DataKanji.Location = New System.Drawing.Point(0, 121)
        Me.DataKanji.Name = "DataKanji"
        Me.DataKanji.ReadOnly = True
        Me.DataKanji.Size = New System.Drawing.Size(737, 231)
        Me.DataKanji.TabIndex = 12
        '
        'cmbSearchSingleKanji
        '
        Me.cmbSearchSingleKanji.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbSearchSingleKanji.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSearchSingleKanji.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSearchSingleKanji.FormattingEnabled = True
        Me.cmbSearchSingleKanji.Location = New System.Drawing.Point(271, 21)
        Me.cmbSearchSingleKanji.Name = "cmbSearchSingleKanji"
        Me.cmbSearchSingleKanji.Size = New System.Drawing.Size(168, 21)
        Me.cmbSearchSingleKanji.TabIndex = 16
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(109, 48)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(72, 26)
        Me.btnSearch.TabIndex = 17
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(203, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Search by:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblSearch)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbSearchSingleKanji)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.txtSingleKanji)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(65, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(458, 84)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search for Single Kanji"
        '
        'Kanj
        '
        Me.Kanj.HeaderText = "Kanji"
        Me.Kanj.MinimumWidth = 40
        Me.Kanj.Name = "Kanj"
        Me.Kanj.ReadOnly = True
        Me.Kanj.Width = 70
        '
        'HanNom
        '
        Me.HanNom.HeaderText = "Han Nom"
        Me.HanNom.MinimumWidth = 50
        Me.HanNom.Name = "HanNom"
        Me.HanNom.ReadOnly = True
        '
        'Kunyomi
        '
        Me.Kunyomi.HeaderText = "Kunyomi"
        Me.Kunyomi.MinimumWidth = 50
        Me.Kunyomi.Name = "Kunyomi"
        Me.Kunyomi.ReadOnly = True
        Me.Kunyomi.Width = 90
        '
        'Onyomi
        '
        Me.Onyomi.HeaderText = "Onyomi"
        Me.Onyomi.MinimumWidth = 50
        Me.Onyomi.Name = "Onyomi"
        Me.Onyomi.ReadOnly = True
        Me.Onyomi.Width = 90
        '
        'Meaning
        '
        Me.Meaning.HeaderText = "Meaning"
        Me.Meaning.MinimumWidth = 50
        Me.Meaning.Name = "Meaning"
        Me.Meaning.ReadOnly = True
        Me.Meaning.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Meaning.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Meaning.Width = 230
        '
        'Kakikata
        '
        Me.Kakikata.HeaderText = "Kakikata"
        Me.Kakikata.MinimumWidth = 50
        Me.Kakikata.Name = "Kakikata"
        Me.Kakikata.ReadOnly = True
        '
        'usrSearchSingleKanji
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataKanji)
        Me.Name = "usrSearchSingleKanji"
        Me.Size = New System.Drawing.Size(737, 366)
        CType(Me.DataKanji, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents txtSingleKanji As System.Windows.Forms.TextBox
    Friend WithEvents DataKanji As System.Windows.Forms.DataGridView
    Private WithEvents cmbSearchSingleKanji As System.Windows.Forms.ComboBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Kanj As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HanNom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Kunyomi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Onyomi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Meaning As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Kakikata As System.Windows.Forms.DataGridViewLinkColumn

End Class

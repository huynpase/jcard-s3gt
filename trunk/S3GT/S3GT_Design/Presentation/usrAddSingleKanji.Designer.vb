<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrAddSingleKanji
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
        Me.DataKanji = New System.Windows.Forms.DataGridView
        Me.SelectionCheckBox = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Kanj = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AmHan = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Kunyomi = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Onyomi = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Meaning = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Kakikata = New System.Windows.Forms.DataGridViewLinkColumn
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fldKaki = New System.Windows.Forms.FolderBrowserDialog
        Me.ofdKaki = New System.Windows.Forms.OpenFileDialog
        CType(Me.DataKanji, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataKanji
        '
        Me.DataKanji.AllowUserToAddRows = False
        Me.DataKanji.AllowUserToOrderColumns = True
        Me.DataKanji.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataKanji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataKanji.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SelectionCheckBox, Me.Kanj, Me.AmHan, Me.Kunyomi, Me.Onyomi, Me.Meaning, Me.Kakikata, Me.ID})
        Me.DataKanji.Location = New System.Drawing.Point(9, 3)
        Me.DataKanji.Name = "DataKanji"
        Me.DataKanji.Size = New System.Drawing.Size(645, 457)
        Me.DataKanji.TabIndex = 11
        '
        'SelectionCheckBox
        '
        Me.SelectionCheckBox.Frozen = True
        Me.SelectionCheckBox.HeaderText = ""
        Me.SelectionCheckBox.MinimumWidth = 20
        Me.SelectionCheckBox.Name = "SelectionCheckBox"
        Me.SelectionCheckBox.Width = 20
        '
        'Kanj
        '
        Me.Kanj.Frozen = True
        Me.Kanj.HeaderText = "Kanji"
        Me.Kanj.MinimumWidth = 30
        Me.Kanj.Name = "Kanj"
        Me.Kanj.ReadOnly = True
        Me.Kanj.Width = 40
        '
        'AmHan
        '
        Me.AmHan.Frozen = True
        Me.AmHan.HeaderText = "Hán Nôm"
        Me.AmHan.MinimumWidth = 50
        Me.AmHan.Name = "AmHan"
        Me.AmHan.ReadOnly = True
        Me.AmHan.Width = 75
        '
        'Kunyomi
        '
        Me.Kunyomi.HeaderText = "Kunyomi"
        Me.Kunyomi.Name = "Kunyomi"
        Me.Kunyomi.ReadOnly = True
        '
        'Onyomi
        '
        Me.Onyomi.HeaderText = "Onyomi"
        Me.Onyomi.Name = "Onyomi"
        Me.Onyomi.ReadOnly = True
        '
        'Meaning
        '
        Me.Meaning.HeaderText = "Meaning"
        Me.Meaning.Name = "Meaning"
        Me.Meaning.Width = 200
        '
        'Kakikata
        '
        Me.Kakikata.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Kakikata.HeaderText = "Kakikata"
        Me.Kakikata.Name = "Kakikata"
        Me.Kakikata.ReadOnly = True
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.Visible = False
        '
        'ofdKaki
        '
        Me.ofdKaki.DefaultExt = "*.gif"
        '
        'usrAddSingleKanji
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DataKanji)
        Me.Name = "usrAddSingleKanji"
        Me.Size = New System.Drawing.Size(660, 520)
        CType(Me.DataKanji, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataKanji As System.Windows.Forms.DataGridView
    Friend WithEvents fldKaki As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents ofdKaki As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SelectionCheckBox As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Kanj As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AmHan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Kunyomi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Onyomi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Meaning As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Kakikata As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn

End Class

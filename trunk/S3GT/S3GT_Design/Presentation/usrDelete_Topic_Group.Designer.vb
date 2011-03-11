<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrDelete_Topic_Group
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
        Me.Button_Delete = New System.Windows.Forms.Button
        Me.Button_Cancel = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DataGridView_Add_TG = New System.Windows.Forms.DataGridView
        Me.Topic_Group_ID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Topic_Group_Name = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Topic_Group_Description = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView_Add_TG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button_Delete
        '
        Me.Button_Delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Delete.Location = New System.Drawing.Point(170, 285)
        Me.Button_Delete.Name = "Button_Delete"
        Me.Button_Delete.Size = New System.Drawing.Size(84, 30)
        Me.Button_Delete.TabIndex = 1
        Me.Button_Delete.Text = "&Delete"
        Me.Button_Delete.UseVisualStyleBackColor = True
        '
        'Button_Cancel
        '
        Me.Button_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Cancel.Location = New System.Drawing.Point(320, 285)
        Me.Button_Cancel.Name = "Button_Cancel"
        Me.Button_Cancel.Size = New System.Drawing.Size(81, 30)
        Me.Button_Cancel.TabIndex = 2
        Me.Button_Cancel.Text = "Cancel"
        Me.Button_Cancel.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView_Add_TG)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(5, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(558, 258)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Delete Topic Groups:"
        '
        'DataGridView_Add_TG
        '
        Me.DataGridView_Add_TG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Add_TG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Topic_Group_ID, Me.Topic_Group_Name, Me.Topic_Group_Description})
        Me.DataGridView_Add_TG.Location = New System.Drawing.Point(6, 25)
        Me.DataGridView_Add_TG.Name = "DataGridView_Add_TG"
        Me.DataGridView_Add_TG.Size = New System.Drawing.Size(546, 227)
        Me.DataGridView_Add_TG.TabIndex = 9
        '
        'Topic_Group_ID
        '
        Me.Topic_Group_ID.DataPropertyName = "Topic_Group_ID"
        Me.Topic_Group_ID.HeaderText = "ID"
        Me.Topic_Group_ID.Name = "Topic_Group_ID"
        Me.Topic_Group_ID.Visible = False
        '
        'Topic_Group_Name
        '
        Me.Topic_Group_Name.DataPropertyName = "Topic_Group_Name"
        Me.Topic_Group_Name.HeaderText = "Topic Group Name"
        Me.Topic_Group_Name.Name = "Topic_Group_Name"
        Me.Topic_Group_Name.Width = 250
        '
        'Topic_Group_Description
        '
        Me.Topic_Group_Description.DataPropertyName = "Topic_Group_Description"
        Me.Topic_Group_Description.HeaderText = "Topic Group Description"
        Me.Topic_Group_Description.Name = "Topic_Group_Description"
        Me.Topic_Group_Description.Width = 250
        '
        'usrDelete_Topic_Group
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button_Cancel)
        Me.Controls.Add(Me.Button_Delete)
        Me.Name = "usrDelete_Topic_Group"
        Me.Size = New System.Drawing.Size(567, 332)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView_Add_TG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button_Delete As System.Windows.Forms.Button
    Friend WithEvents Button_Cancel As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView_Add_TG As System.Windows.Forms.DataGridView
    Friend WithEvents Topic_Group_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Topic_Group_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Topic_Group_Description As System.Windows.Forms.DataGridViewTextBoxColumn

End Class

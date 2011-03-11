<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrUpdate_Topic_Group
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button_Cancel = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox_Ad_NTpic_Gr = New System.Windows.Forms.TextBox
        Me.Button_Upd_Tpic_Gr = New System.Windows.Forms.Button
        Me.GroupBox_Upd_Tpic_Gr = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBox_Ad_DTp_Gr = New System.Windows.Forms.TextBox
        Me.DataGridView_Add_TG = New System.Windows.Forms.DataGridView
        Me.Topic_Group_ID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Topic_Group_Name = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Topic_Group_Description = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox_Upd_Tpic_Gr.SuspendLayout()
        CType(Me.DataGridView_Add_TG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Group Name"
        '
        'Button_Cancel
        '
        Me.Button_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Cancel.Location = New System.Drawing.Point(408, 97)
        Me.Button_Cancel.Name = "Button_Cancel"
        Me.Button_Cancel.Size = New System.Drawing.Size(94, 28)
        Me.Button_Cancel.TabIndex = 4
        Me.Button_Cancel.Text = "Cancel"
        Me.Button_Cancel.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label2.Location = New System.Drawing.Point(225, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(227, 25)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Table of Topic Groups"
        '
        'TextBox_Ad_NTpic_Gr
        '
        Me.TextBox_Ad_NTpic_Gr.Location = New System.Drawing.Point(266, 29)
        Me.TextBox_Ad_NTpic_Gr.Name = "TextBox_Ad_NTpic_Gr"
        Me.TextBox_Ad_NTpic_Gr.Size = New System.Drawing.Size(235, 26)
        Me.TextBox_Ad_NTpic_Gr.TabIndex = 1
        '
        'Button_Upd_Tpic_Gr
        '
        Me.Button_Upd_Tpic_Gr.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Upd_Tpic_Gr.Location = New System.Drawing.Point(308, 97)
        Me.Button_Upd_Tpic_Gr.Name = "Button_Upd_Tpic_Gr"
        Me.Button_Upd_Tpic_Gr.Size = New System.Drawing.Size(94, 28)
        Me.Button_Upd_Tpic_Gr.TabIndex = 3
        Me.Button_Upd_Tpic_Gr.Text = "&Update"
        Me.Button_Upd_Tpic_Gr.UseVisualStyleBackColor = True
        '
        'GroupBox_Upd_Tpic_Gr
        '
        Me.GroupBox_Upd_Tpic_Gr.Controls.Add(Me.Label3)
        Me.GroupBox_Upd_Tpic_Gr.Controls.Add(Me.Label1)
        Me.GroupBox_Upd_Tpic_Gr.Controls.Add(Me.TextBox_Ad_DTp_Gr)
        Me.GroupBox_Upd_Tpic_Gr.Controls.Add(Me.TextBox_Ad_NTpic_Gr)
        Me.GroupBox_Upd_Tpic_Gr.Controls.Add(Me.Button_Cancel)
        Me.GroupBox_Upd_Tpic_Gr.Controls.Add(Me.Button_Upd_Tpic_Gr)
        Me.GroupBox_Upd_Tpic_Gr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_Upd_Tpic_Gr.Location = New System.Drawing.Point(50, 27)
        Me.GroupBox_Upd_Tpic_Gr.Name = "GroupBox_Upd_Tpic_Gr"
        Me.GroupBox_Upd_Tpic_Gr.Size = New System.Drawing.Size(581, 137)
        Me.GroupBox_Upd_Tpic_Gr.TabIndex = 6
        Me.GroupBox_Upd_Tpic_Gr.TabStop = False
        Me.GroupBox_Upd_Tpic_Gr.Text = "Update Topic Group"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Group Description"
        '
        'TextBox_Ad_DTp_Gr
        '
        Me.TextBox_Ad_DTp_Gr.Location = New System.Drawing.Point(266, 63)
        Me.TextBox_Ad_DTp_Gr.Name = "TextBox_Ad_DTp_Gr"
        Me.TextBox_Ad_DTp_Gr.Size = New System.Drawing.Size(235, 26)
        Me.TextBox_Ad_DTp_Gr.TabIndex = 2
        '
        'DataGridView_Add_TG
        '
        Me.DataGridView_Add_TG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Add_TG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Topic_Group_ID, Me.Topic_Group_Name, Me.Topic_Group_Description})
        Me.DataGridView_Add_TG.Location = New System.Drawing.Point(70, 207)
        Me.DataGridView_Add_TG.Name = "DataGridView_Add_TG"
        Me.DataGridView_Add_TG.ReadOnly = True
        Me.DataGridView_Add_TG.Size = New System.Drawing.Size(543, 246)
        Me.DataGridView_Add_TG.TabIndex = 15
        '
        'Topic_Group_ID
        '
        Me.Topic_Group_ID.DataPropertyName = "Topic_Group_ID"
        Me.Topic_Group_ID.HeaderText = "ID"
        Me.Topic_Group_ID.Name = "Topic_Group_ID"
        Me.Topic_Group_ID.ReadOnly = True
        Me.Topic_Group_ID.Visible = False
        '
        'Topic_Group_Name
        '
        Me.Topic_Group_Name.DataPropertyName = "Topic_Group_Name"
        Me.Topic_Group_Name.HeaderText = "Topic Group Name"
        Me.Topic_Group_Name.Name = "Topic_Group_Name"
        Me.Topic_Group_Name.ReadOnly = True
        Me.Topic_Group_Name.Width = 250
        '
        'Topic_Group_Description
        '
        Me.Topic_Group_Description.DataPropertyName = "Topic_Group_Description"
        Me.Topic_Group_Description.HeaderText = "Topic Group Description"
        Me.Topic_Group_Description.Name = "Topic_Group_Description"
        Me.Topic_Group_Description.ReadOnly = True
        Me.Topic_Group_Description.Width = 250
        '
        'usrUpdate_Topic_Group
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DataGridView_Add_TG)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox_Upd_Tpic_Gr)
        Me.Name = "usrUpdate_Topic_Group"
        Me.Size = New System.Drawing.Size(693, 485)
        Me.GroupBox_Upd_Tpic_Gr.ResumeLayout(False)
        Me.GroupBox_Upd_Tpic_Gr.PerformLayout()
        CType(Me.DataGridView_Add_TG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button_Cancel As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Ad_NTpic_Gr As System.Windows.Forms.TextBox
    Friend WithEvents Button_Upd_Tpic_Gr As System.Windows.Forms.Button
    Friend WithEvents GroupBox_Upd_Tpic_Gr As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Ad_DTp_Gr As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView_Add_TG As System.Windows.Forms.DataGridView
    Friend WithEvents Topic_Group_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Topic_Group_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Topic_Group_Description As System.Windows.Forms.DataGridViewTextBoxColumn

End Class

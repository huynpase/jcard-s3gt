<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrAdd_New_Topic_Group
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
        Me.Button_Ad_NTpic_Gr = New System.Windows.Forms.Button
        Me.TextBox_Ad_NTpic_Gr = New System.Windows.Forms.TextBox
        Me.GroupBox_Ad_NTpic_Gr = New System.Windows.Forms.GroupBox
        Me.btnReset = New System.Windows.Forms.Button
        Me.Button_Delete = New System.Windows.Forms.Button
        Me.Button_Update_Tpic_Gr = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox_Ad_DTp_Gr = New System.Windows.Forms.TextBox
        Me.Button_Cancel = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.DataGridView_Add_TG = New System.Windows.Forms.DataGridView
        Me.Topic_Group_ID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Topic_Group_Name = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Topic_Group_Description = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox_Ad_NTpic_Gr.SuspendLayout()
        CType(Me.DataGridView_Add_TG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button_Ad_NTpic_Gr
        '
        Me.Button_Ad_NTpic_Gr.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Ad_NTpic_Gr.Location = New System.Drawing.Point(74, 90)
        Me.Button_Ad_NTpic_Gr.Name = "Button_Ad_NTpic_Gr"
        Me.Button_Ad_NTpic_Gr.Size = New System.Drawing.Size(94, 27)
        Me.Button_Ad_NTpic_Gr.TabIndex = 3
        Me.Button_Ad_NTpic_Gr.Text = "&Add"
        Me.Button_Ad_NTpic_Gr.UseVisualStyleBackColor = True
        '
        'TextBox_Ad_NTpic_Gr
        '
        Me.TextBox_Ad_NTpic_Gr.Location = New System.Drawing.Point(170, 19)
        Me.TextBox_Ad_NTpic_Gr.Name = "TextBox_Ad_NTpic_Gr"
        Me.TextBox_Ad_NTpic_Gr.Size = New System.Drawing.Size(368, 26)
        Me.TextBox_Ad_NTpic_Gr.TabIndex = 1
        '
        'GroupBox_Ad_NTpic_Gr
        '
        Me.GroupBox_Ad_NTpic_Gr.Controls.Add(Me.btnReset)
        Me.GroupBox_Ad_NTpic_Gr.Controls.Add(Me.Button_Delete)
        Me.GroupBox_Ad_NTpic_Gr.Controls.Add(Me.Button_Update_Tpic_Gr)
        Me.GroupBox_Ad_NTpic_Gr.Controls.Add(Me.Label3)
        Me.GroupBox_Ad_NTpic_Gr.Controls.Add(Me.Label1)
        Me.GroupBox_Ad_NTpic_Gr.Controls.Add(Me.TextBox_Ad_DTp_Gr)
        Me.GroupBox_Ad_NTpic_Gr.Controls.Add(Me.TextBox_Ad_NTpic_Gr)
        Me.GroupBox_Ad_NTpic_Gr.Controls.Add(Me.Button_Cancel)
        Me.GroupBox_Ad_NTpic_Gr.Controls.Add(Me.Button_Ad_NTpic_Gr)
        Me.GroupBox_Ad_NTpic_Gr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_Ad_NTpic_Gr.Location = New System.Drawing.Point(24, 22)
        Me.GroupBox_Ad_NTpic_Gr.Name = "GroupBox_Ad_NTpic_Gr"
        Me.GroupBox_Ad_NTpic_Gr.Size = New System.Drawing.Size(548, 129)
        Me.GroupBox_Ad_NTpic_Gr.TabIndex = 3
        Me.GroupBox_Ad_NTpic_Gr.TabStop = False
        Me.GroupBox_Ad_NTpic_Gr.Text = "Add New Topic Group"
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(344, 90)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(94, 27)
        Me.btnReset.TabIndex = 7
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'Button_Delete
        '
        Me.Button_Delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Delete.Location = New System.Drawing.Point(263, 90)
        Me.Button_Delete.Name = "Button_Delete"
        Me.Button_Delete.Size = New System.Drawing.Size(75, 27)
        Me.Button_Delete.TabIndex = 4
        Me.Button_Delete.Text = "&Delete"
        Me.Button_Delete.UseVisualStyleBackColor = True
        '
        'Button_Update_Tpic_Gr
        '
        Me.Button_Update_Tpic_Gr.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Update_Tpic_Gr.Location = New System.Drawing.Point(170, 90)
        Me.Button_Update_Tpic_Gr.Name = "Button_Update_Tpic_Gr"
        Me.Button_Update_Tpic_Gr.Size = New System.Drawing.Size(87, 27)
        Me.Button_Update_Tpic_Gr.TabIndex = 5
        Me.Button_Update_Tpic_Gr.Text = "&Update"
        Me.Button_Update_Tpic_Gr.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Group Description"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Group Name"
        '
        'TextBox_Ad_DTp_Gr
        '
        Me.TextBox_Ad_DTp_Gr.Location = New System.Drawing.Point(170, 52)
        Me.TextBox_Ad_DTp_Gr.Name = "TextBox_Ad_DTp_Gr"
        Me.TextBox_Ad_DTp_Gr.Size = New System.Drawing.Size(368, 26)
        Me.TextBox_Ad_DTp_Gr.TabIndex = 2
        '
        'Button_Cancel
        '
        Me.Button_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Cancel.Location = New System.Drawing.Point(444, 90)
        Me.Button_Cancel.Name = "Button_Cancel"
        Me.Button_Cancel.Size = New System.Drawing.Size(94, 27)
        Me.Button_Cancel.TabIndex = 6
        Me.Button_Cancel.Text = "Cancel"
        Me.Button_Cancel.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label2.Location = New System.Drawing.Point(153, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(216, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Table of Topic Group"
        '
        'DataGridView_Add_TG
        '
        Me.DataGridView_Add_TG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Add_TG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Topic_Group_ID, Me.Topic_Group_Name, Me.Topic_Group_Description})
        Me.DataGridView_Add_TG.Location = New System.Drawing.Point(24, 182)
        Me.DataGridView_Add_TG.Name = "DataGridView_Add_TG"
        Me.DataGridView_Add_TG.Size = New System.Drawing.Size(538, 214)
        Me.DataGridView_Add_TG.TabIndex = 7
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
        'usrAdd_New_Topic_Group
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DataGridView_Add_TG)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox_Ad_NTpic_Gr)
        Me.Name = "usrAdd_New_Topic_Group"
        Me.Size = New System.Drawing.Size(602, 441)
        Me.GroupBox_Ad_NTpic_Gr.ResumeLayout(False)
        Me.GroupBox_Ad_NTpic_Gr.PerformLayout()
        CType(Me.DataGridView_Add_TG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button_Ad_NTpic_Gr As System.Windows.Forms.Button
    Friend WithEvents TextBox_Ad_NTpic_Gr As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox_Ad_NTpic_Gr As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button_Cancel As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Ad_DTp_Gr As System.Windows.Forms.TextBox
    Friend WithEvents Button_Update_Tpic_Gr As System.Windows.Forms.Button
    Friend WithEvents DataGridView_Add_TG As System.Windows.Forms.DataGridView
    Friend WithEvents Button_Delete As System.Windows.Forms.Button
    Friend WithEvents Topic_Group_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Topic_Group_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Topic_Group_Description As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnReset As System.Windows.Forms.Button

End Class

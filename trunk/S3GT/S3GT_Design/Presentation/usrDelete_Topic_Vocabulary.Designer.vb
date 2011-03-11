<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrDeleteTopic_Vocabulary
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
        Me.dgvTopicOfTopicGroup = New System.Windows.Forms.DataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button_Cancel = New System.Windows.Forms.Button
        Me.Button_OK = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.radioMoveToDefault = New System.Windows.Forms.RadioButton
        Me.radioDeleteChild = New System.Windows.Forms.RadioButton
        Me.Label_Topic_Group = New System.Windows.Forms.Label
        CType(Me.dgvTopicOfTopicGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvTopicOfTopicGroup
        '
        Me.dgvTopicOfTopicGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTopicOfTopicGroup.Location = New System.Drawing.Point(17, 32)
        Me.dgvTopicOfTopicGroup.Name = "dgvTopicOfTopicGroup"
        Me.dgvTopicOfTopicGroup.Size = New System.Drawing.Size(478, 158)
        Me.dgvTopicOfTopicGroup.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button_Cancel)
        Me.GroupBox1.Controls.Add(Me.Button_OK)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.dgvTopicOfTopicGroup)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(23, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(513, 367)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "List of releated Topics"
        '
        'Button_Cancel
        '
        Me.Button_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Cancel.Location = New System.Drawing.Point(282, 323)
        Me.Button_Cancel.Name = "Button_Cancel"
        Me.Button_Cancel.Size = New System.Drawing.Size(89, 33)
        Me.Button_Cancel.TabIndex = 5
        Me.Button_Cancel.Text = "Cancel"
        Me.Button_Cancel.UseVisualStyleBackColor = True
        '
        'Button_OK
        '
        Me.Button_OK.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_OK.Location = New System.Drawing.Point(170, 323)
        Me.Button_OK.Name = "Button_OK"
        Me.Button_OK.Size = New System.Drawing.Size(80, 33)
        Me.Button_OK.TabIndex = 4
        Me.Button_OK.Text = "&OK"
        Me.Button_OK.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radioMoveToDefault)
        Me.GroupBox2.Controls.Add(Me.radioDeleteChild)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 207)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(478, 110)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Events"
        '
        'radioMoveToDefault
        '
        Me.radioMoveToDefault.AutoSize = True
        Me.radioMoveToDefault.Location = New System.Drawing.Point(21, 69)
        Me.radioMoveToDefault.Name = "radioMoveToDefault"
        Me.radioMoveToDefault.Size = New System.Drawing.Size(435, 21)
        Me.radioMoveToDefault.TabIndex = 3
        Me.radioMoveToDefault.TabStop = True
        Me.radioMoveToDefault.Text = "Move all relating Topics and Vocabularies to default Topic Group"
        Me.radioMoveToDefault.UseVisualStyleBackColor = True
        '
        'radioDeleteChild
        '
        Me.radioDeleteChild.AutoSize = True
        Me.radioDeleteChild.Location = New System.Drawing.Point(21, 32)
        Me.radioDeleteChild.Name = "radioDeleteChild"
        Me.radioDeleteChild.Size = New System.Drawing.Size(296, 21)
        Me.radioDeleteChild.TabIndex = 2
        Me.radioDeleteChild.TabStop = True
        Me.radioDeleteChild.Text = "Delete all relating Topics and Vocabularies"
        Me.radioDeleteChild.UseVisualStyleBackColor = True

        Me.radioDeleteChild.Checked = True
        '
        'Label_Topic_Group
        '
        Me.Label_Topic_Group.AutoSize = True
        Me.Label_Topic_Group.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Topic_Group.ForeColor = System.Drawing.Color.Purple
        Me.Label_Topic_Group.Location = New System.Drawing.Point(190, 23)
        Me.Label_Topic_Group.Name = "Label_Topic_Group"
        Me.Label_Topic_Group.Size = New System.Drawing.Size(57, 17)
        Me.Label_Topic_Group.TabIndex = 2
        Me.Label_Topic_Group.Text = "Label1"
        '
        'usrtemp_Delete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label_Topic_Group)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "usrtemp_Delete"
        Me.Size = New System.Drawing.Size(559, 444)
        CType(Me.dgvTopicOfTopicGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvTopicOfTopicGroup As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button_Cancel As System.Windows.Forms.Button
    Friend WithEvents Button_OK As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents radioMoveToDefault As System.Windows.Forms.RadioButton
    Friend WithEvents radioDeleteChild As System.Windows.Forms.RadioButton
    Friend WithEvents Label_Topic_Group As System.Windows.Forms.Label

End Class

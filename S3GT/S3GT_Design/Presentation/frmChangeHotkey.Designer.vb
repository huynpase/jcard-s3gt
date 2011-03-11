<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangeHotkey
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChangeHotkey))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.radShift = New System.Windows.Forms.RadioButton
        Me.radAlt = New System.Windows.Forms.RadioButton
        Me.radCtrl = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cboLastKey = New System.Windows.Forms.ComboBox
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnOK = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radShift)
        Me.GroupBox1.Controls.Add(Me.radAlt)
        Me.GroupBox1.Controls.Add(Me.radCtrl)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 46)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "First Key"
        '
        'radShift
        '
        Me.radShift.AutoSize = True
        Me.radShift.Location = New System.Drawing.Point(138, 19)
        Me.radShift.Name = "radShift"
        Me.radShift.Size = New System.Drawing.Size(46, 17)
        Me.radShift.TabIndex = 2
        Me.radShift.TabStop = True
        Me.radShift.Text = "Shift"
        Me.radShift.UseVisualStyleBackColor = True
        '
        'radAlt
        '
        Me.radAlt.AutoSize = True
        Me.radAlt.Location = New System.Drawing.Point(70, 19)
        Me.radAlt.Name = "radAlt"
        Me.radAlt.Size = New System.Drawing.Size(37, 17)
        Me.radAlt.TabIndex = 1
        Me.radAlt.TabStop = True
        Me.radAlt.Text = "Alt"
        Me.radAlt.UseVisualStyleBackColor = True
        '
        'radCtrl
        '
        Me.radCtrl.AutoSize = True
        Me.radCtrl.Location = New System.Drawing.Point(6, 19)
        Me.radCtrl.Name = "radCtrl"
        Me.radCtrl.Size = New System.Drawing.Size(40, 17)
        Me.radCtrl.TabIndex = 0
        Me.radCtrl.TabStop = True
        Me.radCtrl.Text = "Ctrl"
        Me.radCtrl.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboLastKey)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 54)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 52)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Last Key"
        '
        'cboLastKey
        '
        Me.cboLastKey.FormattingEnabled = True
        Me.cboLastKey.Location = New System.Drawing.Point(6, 19)
        Me.cboLastKey.Name = "cboLastKey"
        Me.cboLastKey.Size = New System.Drawing.Size(188, 21)
        Me.cboLastKey.TabIndex = 0
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(141, 112)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(62, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(73, 112)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(62, 23)
        Me.btnOK.TabIndex = 3
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'frmChangeHotkey
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(207, 153)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmChangeHotkey"
        Me.Text = "Hot Key Configuration"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents radShift As System.Windows.Forms.RadioButton
    Friend WithEvents radAlt As System.Windows.Forms.RadioButton
    Friend WithEvents radCtrl As System.Windows.Forms.RadioButton
    Friend WithEvents cboLastKey As System.Windows.Forms.ComboBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
End Class

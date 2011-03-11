<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgCreateTopic
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
        Me.usrControlPanel = New System.Windows.Forms.Panel
        Me.panShowControl = New System.Windows.Forms.Panel
        Me.usrControlPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'usrControlPanel
        '
        Me.usrControlPanel.Controls.Add(Me.panShowControl)
        Me.usrControlPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.usrControlPanel.Location = New System.Drawing.Point(0, 0)
        Me.usrControlPanel.Name = "usrControlPanel"
        Me.usrControlPanel.Size = New System.Drawing.Size(650, 390)
        Me.usrControlPanel.TabIndex = 1
        '
        'panShowControl
        '
        Me.panShowControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panShowControl.Location = New System.Drawing.Point(0, 0)
        Me.panShowControl.Name = "panShowControl"
        Me.panShowControl.Size = New System.Drawing.Size(650, 390)
        Me.panShowControl.TabIndex = 2
        '
        'dlgCreateTopic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 392)
        Me.Controls.Add(Me.usrControlPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCreateTopic"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Create New Topic"
        Me.usrControlPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents usrControlPanel As System.Windows.Forms.Panel
    Friend WithEvents panShowControl As System.Windows.Forms.Panel

End Class

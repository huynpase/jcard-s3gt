<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMoveAndCopy
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.PanelMoveAndCopy = New System.Windows.Forms.Panel
        Me.SuspendLayout()
        '
        'PanelMoveAndCopy
        '
        Me.PanelMoveAndCopy.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMoveAndCopy.Location = New System.Drawing.Point(0, 0)
        Me.PanelMoveAndCopy.Name = "PanelMoveAndCopy"
        Me.PanelMoveAndCopy.Size = New System.Drawing.Size(716, 454)
        Me.PanelMoveAndCopy.TabIndex = 0
        '
        'frmMoveAndCopy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 454)
        Me.Controls.Add(Me.PanelMoveAndCopy)
        Me.Name = "frmMoveAndCopy"
        Me.Text = "Move/Copy"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelMoveAndCopy As System.Windows.Forms.Panel
End Class

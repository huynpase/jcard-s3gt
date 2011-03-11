<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Processing
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
        Me.pgr_ProgressBar = New System.Windows.Forms.ProgressBar
        Me.btn_Cancel = New System.Windows.Forms.Button
        Me.lb_status = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'pgr_ProgressBar
        '
        Me.pgr_ProgressBar.Location = New System.Drawing.Point(13, 32)
        Me.pgr_ProgressBar.Name = "pgr_ProgressBar"
        Me.pgr_ProgressBar.Size = New System.Drawing.Size(376, 23)
        Me.pgr_ProgressBar.TabIndex = 0
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(314, 86)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_Cancel.TabIndex = 1
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'lb_status
        '
        Me.lb_status.AutoSize = True
        Me.lb_status.Location = New System.Drawing.Point(13, 62)
        Me.lb_status.Name = "lb_status"
        Me.lb_status.Size = New System.Drawing.Size(59, 13)
        Me.lb_status.TabIndex = 2
        Me.lb_status.Text = "status here"
        '
        'Processing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 135)
        Me.Controls.Add(Me.lb_status)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.pgr_ProgressBar)
        Me.Name = "Processing"
        Me.Text = "Processing"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pgr_ProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents lb_status As System.Windows.Forms.Label
End Class

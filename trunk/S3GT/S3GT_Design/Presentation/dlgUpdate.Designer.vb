<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgUpdate
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.btnProcess = New System.Windows.Forms.Button
        Me.btnSkip = New System.Windows.Forms.Button
        Me.lblMessageContent = New System.Windows.Forms.Label
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnProcess, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnSkip, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(186, 127)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(226, 39)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btnProcess
        '
        Me.btnProcess.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnProcess.Location = New System.Drawing.Point(13, 4)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(86, 30)
        Me.btnProcess.TabIndex = 0
        Me.btnProcess.Text = "&Process"
        '
        'btnSkip
        '
        Me.btnSkip.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSkip.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSkip.Location = New System.Drawing.Point(124, 4)
        Me.btnSkip.Name = "btnSkip"
        Me.btnSkip.Size = New System.Drawing.Size(90, 30)
        Me.btnSkip.TabIndex = 1
        Me.btnSkip.Text = "&Skip"
        '
        'lblMessageContent
        '
        Me.lblMessageContent.Location = New System.Drawing.Point(13, 8)
        Me.lblMessageContent.Name = "lblMessageContent"
        Me.lblMessageContent.Size = New System.Drawing.Size(399, 97)
        Me.lblMessageContent.TabIndex = 1
        Me.lblMessageContent.Text = "Label11"
        '
        'dlgUpdate
        '
        Me.AcceptButton = Me.btnProcess
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnSkip
        Me.ClientSize = New System.Drawing.Size(424, 178)
        Me.Controls.Add(Me.lblMessageContent)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgUpdate"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Warning Updated Vocabulary having some coincidences "
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnProcess As System.Windows.Forms.Button
    Friend WithEvents btnSkip As System.Windows.Forms.Button
    Friend WithEvents lblMessageContent As System.Windows.Forms.Label

End Class

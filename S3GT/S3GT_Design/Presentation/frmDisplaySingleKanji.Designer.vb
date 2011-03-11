<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDisplaySingleKanji
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDisplaySingleKanji))
        Me.lblOnyomi = New System.Windows.Forms.Label
        Me.lblKunyomi = New System.Windows.Forms.Label
        Me.lblMeaning = New System.Windows.Forms.Label
        Me.lbldsMeaning = New System.Windows.Forms.Label
        Me.lbldsKun = New System.Windows.Forms.Label
        Me.lbldsOn = New System.Windows.Forms.Label
        Me.picKaki = New System.Windows.Forms.PictureBox
        Me.lblAmHan = New System.Windows.Forms.Label
        CType(Me.picKaki, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblOnyomi
        '
        Me.lblOnyomi.AutoSize = True
        Me.lblOnyomi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOnyomi.ForeColor = System.Drawing.Color.Blue
        Me.lblOnyomi.Location = New System.Drawing.Point(306, 144)
        Me.lblOnyomi.Name = "lblOnyomi"
        Me.lblOnyomi.Size = New System.Drawing.Size(64, 16)
        Me.lblOnyomi.TabIndex = 14
        Me.lblOnyomi.Text = "Onyomi:"
        '
        'lblKunyomi
        '
        Me.lblKunyomi.AutoSize = True
        Me.lblKunyomi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKunyomi.ForeColor = System.Drawing.Color.Blue
        Me.lblKunyomi.Location = New System.Drawing.Point(306, 103)
        Me.lblKunyomi.Name = "lblKunyomi"
        Me.lblKunyomi.Size = New System.Drawing.Size(70, 16)
        Me.lblKunyomi.TabIndex = 13
        Me.lblKunyomi.Text = "Kunyomi:"
        '
        'lblMeaning
        '
        Me.lblMeaning.AutoSize = True
        Me.lblMeaning.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMeaning.ForeColor = System.Drawing.Color.Blue
        Me.lblMeaning.Location = New System.Drawing.Point(306, 61)
        Me.lblMeaning.Name = "lblMeaning"
        Me.lblMeaning.Size = New System.Drawing.Size(71, 16)
        Me.lblMeaning.TabIndex = 12
        Me.lblMeaning.Text = "Meaning:"
        '
        'lbldsMeaning
        '
        Me.lbldsMeaning.AutoSize = True
        Me.lbldsMeaning.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldsMeaning.Location = New System.Drawing.Point(326, 84)
        Me.lbldsMeaning.Name = "lbldsMeaning"
        Me.lbldsMeaning.Size = New System.Drawing.Size(109, 16)
        Me.lbldsMeaning.TabIndex = 15
        Me.lbldsMeaning.Text = "Display meaning"
        '
        'lbldsKun
        '
        Me.lbldsKun.AutoSize = True
        Me.lbldsKun.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldsKun.Location = New System.Drawing.Point(326, 126)
        Me.lbldsKun.Name = "lbldsKun"
        Me.lbldsKun.Size = New System.Drawing.Size(108, 16)
        Me.lbldsKun.TabIndex = 16
        Me.lbldsKun.Text = "Display Kunyomi"
        '
        'lbldsOn
        '
        Me.lbldsOn.AutoSize = True
        Me.lbldsOn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldsOn.Location = New System.Drawing.Point(326, 168)
        Me.lbldsOn.Name = "lbldsOn"
        Me.lbldsOn.Size = New System.Drawing.Size(103, 16)
        Me.lbldsOn.TabIndex = 17
        Me.lbldsOn.Text = "Display Onyomi"
        '
        'picKaki
        '
        Me.picKaki.Image = CType(resources.GetObject("picKaki.Image"), System.Drawing.Image)
        Me.picKaki.InitialImage = Nothing
        Me.picKaki.Location = New System.Drawing.Point(0, 2)
        Me.picKaki.Name = "picKaki"
        Me.picKaki.Size = New System.Drawing.Size(300, 300)
        Me.picKaki.TabIndex = 1
        Me.picKaki.TabStop = False
        '
        'lblAmHan
        '
        Me.lblAmHan.AutoSize = True
        Me.lblAmHan.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmHan.Location = New System.Drawing.Point(306, 15)
        Me.lblAmHan.Name = "lblAmHan"
        Me.lblAmHan.Size = New System.Drawing.Size(216, 31)
        Me.lblAmHan.TabIndex = 19
        Me.lblAmHan.Text = "Display AM HAN"
        '
        'frmDisplaySingleKanji
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 304)
        Me.Controls.Add(Me.lblAmHan)
        Me.Controls.Add(Me.lbldsOn)
        Me.Controls.Add(Me.lbldsKun)
        Me.Controls.Add(Me.lbldsMeaning)
        Me.Controls.Add(Me.lblOnyomi)
        Me.Controls.Add(Me.lblKunyomi)
        Me.Controls.Add(Me.lblMeaning)
        Me.Controls.Add(Me.picKaki)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDisplaySingleKanji"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Display a Single Kanji"
        CType(Me.picKaki, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picKaki As System.Windows.Forms.PictureBox
    Friend WithEvents lblOnyomi As System.Windows.Forms.Label
    Friend WithEvents lblKunyomi As System.Windows.Forms.Label
    Friend WithEvents lblMeaning As System.Windows.Forms.Label
    Friend WithEvents lbldsMeaning As System.Windows.Forms.Label
    Friend WithEvents lbldsKun As System.Windows.Forms.Label
    Friend WithEvents lbldsOn As System.Windows.Forms.Label
    Friend WithEvents lblAmHan As System.Windows.Forms.Label
End Class

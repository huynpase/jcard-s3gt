Imports System.Drawing.Drawing2D
Public Class SplashWrong
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents picBoxWrong As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashWrong))
        Me.picBoxWrong = New System.Windows.Forms.PictureBox
        CType(Me.picBoxWrong, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picBoxWrong
        '
        Me.picBoxWrong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picBoxWrong.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picBoxWrong.ErrorImage = Nothing
        Me.picBoxWrong.Image = CType(resources.GetObject("picBoxWrong.Image"), System.Drawing.Image)
        Me.picBoxWrong.InitialImage = Nothing
        Me.picBoxWrong.Location = New System.Drawing.Point(0, 0)
        Me.picBoxWrong.Name = "picBoxWrong"
        Me.picBoxWrong.Size = New System.Drawing.Size(294, 273)
        Me.picBoxWrong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picBoxWrong.TabIndex = 14
        Me.picBoxWrong.TabStop = False
        Me.picBoxWrong.UseWaitCursor = True
        Me.picBoxWrong.Visible = False
        '
        'SplashWrong
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(294, 273)
        Me.Controls.Add(Me.picBoxWrong)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SplashWrong"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        CType(Me.picBoxWrong, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Long)
    Private Sub frmSplash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim sRect As Rectangle
        'Me.Top = ((Screen.GetWorkingArea(sRect).Height / 2) - (Me.Height / 2)) - 75
        'Me.Left = ((Screen.GetWorkingArea(sRect).Width / 2) - (Me.Width / 2)) - 75
        Me.TransparencyKey = Me.BackColor
    End Sub

    Private Sub frmSplash_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        'Dim sRect As Rectangle, p As Integer, pR As Integer, pL As Integer
        'pR = Screen.GetWorkingArea(sRect).Width
        'pL = (pR / 2) - (Me.Width / 2)
        'Me.Left = pR
        'Draw Background Image on Form
        e.Graphics.DrawImage(picBoxWrong.Image, 0, 0)
        'For p = pR To pL Step -150
        '    Me.Left = p
        'Next
        Me.Show()
        Sleep(600)
        'Me.Hide()
        Me.Dispose()
    End Sub

End Class

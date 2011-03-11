Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports PopupControl

Namespace MoreComplexPopup
    Partial Public Class ComplexPopup
        Inherits UserControl
        Public Sub New(ByVal t As String)
            InitializeComponent()
            MinimumSize = Size
            MaximumSize = New Size(Size.Width * 2, Size.Height * 2)
            DoubleBuffered = True
            ResizeRedraw = True
            textBox1.Text = t

        End Sub

        Protected Overloads Overrides Sub WndProc(ByRef m As Message)
            If TryCast(Parent, PopupControl.Popup).ProcessResizing(m) Then
                Return
            End If
            MyBase.WndProc(m)
        End Sub

        Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


        End Sub
        Friend WithEvents textBox1 As System.Windows.Forms.TextBox

        Private Sub InitializeComponent()
            Me.textBox1 = New System.Windows.Forms.TextBox
            Me.SuspendLayout()
            '
            'textBox1
            '
            Me.textBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.textBox1.Location = New System.Drawing.Point(0, 0)
            Me.textBox1.Multiline = True
            Me.textBox1.Name = "textBox1"
            Me.textBox1.Size = New System.Drawing.Size(289, 105)
            Me.textBox1.TabIndex = 0
            '
            'ComplexPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.textBox1)
            Me.Name = "ComplexPopup"
            Me.Size = New System.Drawing.Size(289, 105)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
    End Class
End Namespace

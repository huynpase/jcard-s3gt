Public Class dlgSetTimerInterval
    Private intInterval As Integer
    Public ReadOnly Property TimerInterval() As Integer
        Get
            Return intInterval
        End Get
    End Property

    Private Sub okButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles okButton.Click
        Try
            intInterval = CInt(timeMaskedTextBox.Text)
        Catch ex As Exception
            intInterval = 0
        End Try
        If intInterval > 0 Then
            Me.Close()
        Else
            MessageBox.Show("You must enter a valid natural number", "Wrong value!")
        End If
    End Sub

    Private Sub SetTimerIntervalForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'timeMaskedTextBox.Text = CStr(MainForm.timerInterval)
        timeMaskedTextBox.Focus()
    End Sub

    Private Sub timeMaskedTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles timeMaskedTextBox.KeyPress
        If e.KeyChar = vbCr Then 'user press enter
            okButton_Click(sender, e)
        End If
    End Sub

    Private Sub timeMaskedTextBox_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles timeMaskedTextBox.Validating
        Dim tempIntervalValue As Integer
        If Not Constants_LanhVC.STR_BLANK_VALUE.Equals(timeMaskedTextBox.Text) Then
            Try
                tempIntervalValue = CType(timeMaskedTextBox.Text, Integer)
            Catch ex As Exception
                MessageBox.Show("You must enter a valid natural number", "Wrong value!")
            End Try
        Else
            tempIntervalValue = 0
        End If
        If tempIntervalValue = 0 Then
            MessageBox.Show("You must enter a value superior than 0", "Wrong value!")
        End If
    End Sub
End Class
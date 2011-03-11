Public Class Processing
    Public Delegate Sub SetCancel(ByVal cancel As Boolean)
    Public d_setCancel As SetCancel

    Public Sub SetTextCallback(ByVal text As String)
        lb_status.Text = text
    End Sub
    Public Sub SetPgrMaxValue(ByVal value As Integer)
        Me.pgr_ProgressBar.Maximum = value
    End Sub
    Public Sub SetPgrValue(ByVal value As Integer)
        If value = 0 Then
            pgr_ProgressBar.Value = 0
            Exit Sub
        End If
        If Me.pgr_ProgressBar.Value + value <= Me.pgr_ProgressBar.Maximum Then
            Me.pgr_ProgressBar.Value += value
            lb_status.Text = Math.Ceiling((pgr_ProgressBar.Value / pgr_ProgressBar.Maximum) * 100)
            lb_status.Text += "%"
        End If

    End Sub

    Private Sub btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
        If MessageBox.Show("Ban co muon ngung qua trinh lai khong!", "?", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            'Dim d_cancel = new SetCancel(AddressOf 
            If d_setCancel <> Nothing Then
                d_setCancel(False)
            End If
        End If
    End Sub
End Class
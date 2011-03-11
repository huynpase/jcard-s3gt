Public Class frmFastRegister
    Dim usrFastRegVoc As usrFastRegisterVocabularies
    Dim strVoc As String = ""
    Private Sub frmFastRegister_ControlRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.ControlEventArgs) Handles Me.ControlRemoved
        Application.Exit()
    End Sub

    Private Sub frmFastRegister_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim args As String() = Environment.GetCommandLineArgs()
        Dim strRegVocBuilder As System.Text.StringBuilder = New System.Text.StringBuilder
        If args.Length > 1 Then
            For i As Integer = 1 To args.Length - 1
                strRegVocBuilder.Append(args(i))
                strRegVocBuilder.Append(" ")
            Next
            strVoc = strRegVocBuilder.ToString.Trim
        End If
        usrFastRegVoc = New usrFastRegisterVocabularies(strVoc)
        usrFastRegVoc.Dock = DockStyle.Fill
        Me.Controls.Add(usrFastRegVoc)
        Me.Focus()
        usrFastRegVoc.InitFocus()

    End Sub

    Private Sub frmShown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        usrFastRegVoc.InitFocus()
    End Sub


    'Private Sub languageChange( _
    '   ByVal sender As Object, _
    '   ByVal e As InputLanguageChangedEventArgs _
    ') Handles MyBase.InputLanguageChanged
    '    ' If the input language is Japanese.
    '    ' set the initial IMEMode to Katakana.
    '    If e.InputLanguage.Culture.TwoLetterISOLanguageName.Equals("ja") = True Then
    '        usrFastRegVoc.txtExample.ImeMode = System.Windows.Forms.ImeMode.Katakana
    '    End If
    'End Sub

End Class

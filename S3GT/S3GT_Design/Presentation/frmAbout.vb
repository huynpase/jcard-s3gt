Imports System.IO
Public NotInheritable Class frmAbout

    Private Sub AboutBox1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set the title of the form.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            'ApplicationTitle = My.Application.Info.Title
            ApplicationTitle = Constants_LanhVC.STR_PROJECT_NAME
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("About {0}", ApplicationTitle)
        ' Initialize all of the text displayed on the About Box.
        ' TODO: Customize the application's assembly information in the "Application" pane of the project 
        '    properties dialog (under the "Project" menu).
        Me.LabelProductName.Text = Constants_LanhVC.STR_PROJECT_NAME
        Me.LabelVersion.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
        Me.LabelCopyright.Text = My.Application.Info.Copyright
        Me.LabelCompanyName.Text = My.Application.Info.CompanyName
        Dim membersFilePath As String
        membersFilePath = Directory.GetCurrentDirectory() & "\" & "members.s3gt"
        Try
            Dim memberFileReader As StreamReader = New StreamReader(membersFilePath)
            Me.TextBoxDescription.Text = memberFileReader.ReadToEnd
        Catch ex As Exception
            Me.TextBoxDescription.Text = My.Application.Info.Description
        End Try
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

End Class

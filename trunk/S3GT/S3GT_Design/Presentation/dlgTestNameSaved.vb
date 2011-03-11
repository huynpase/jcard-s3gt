Imports System.Windows.Forms
Imports System.IO

Public Class dlgTestNameSaved
    Private objDialogMode As DialogMode
    Private strTestName As String
    Public Property TestName() As String
        Get
            Return strTestName
        End Get
        Set(ByVal value As String)
            strTestName = value
        End Set
    End Property

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If Utils.ObjectToString(cboTestName.Text).Equals(Constants_LanhVC.STR_BLANK_VALUE) Then
            lblError.Text = "Test Name cannot be blank."
            lblError.Visible = True
        Else
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.TestName = Utils.ObjectToString(cboTestName.Text)
            Me.Close()
        End If

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub cboTestName_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTestName.Enter
        lblError.Text = Constants_LanhVC.STR_BLANK_VALUE
        lblError.Visible = False
    End Sub

    Public Sub New(ByVal pDialogMode As DialogMode)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        objDialogMode = pDialogMode
    End Sub

    Public Enum DialogMode
        Save
        Load
    End Enum

    Private Sub dlgTestNameSaved_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'get all saved Test file to Test Name combobox
        Dim strSavedTestPath As String
        Dim arrTestNameFiles As String()
        Dim strTestName As String
        Dim startIndex As Integer
        Dim stringLength As Integer
        Try
            cboTestName.Items.Clear()

            strSavedTestPath = Directory.GetCurrentDirectory & Constants_LanhVC.STR_TEST_FOLDER_PATH_SEPARATOR & Constants_LanhVC.STR_TEST_SAVED_FOLDER_PATH
            arrTestNameFiles = Directory.GetFiles(strSavedTestPath, "*" & Constants_LanhVC.STR_TEST_SAVED_FILE_EXTENSION)

            For index As Integer = 0 To arrTestNameFiles.Length() - 1
                strTestName = arrTestNameFiles(index)
                startIndex = strTestName.LastIndexOf(Constants_LanhVC.STR_TEST_FOLDER_PATH_SEPARATOR) + 1
                stringLength = strTestName.LastIndexOf(Constants_LanhVC.STR_TEST_SAVED_FILE_EXTENSION) - strTestName.LastIndexOf(Constants_LanhVC.STR_TEST_FOLDER_PATH_SEPARATOR) - 1
                strTestName = strTestName.Substring(startIndex, stringLength)
                If Not "blank".Equals(strTestName) AndAlso Not Constants_LanhVC.STR_BLANK_VALUE.Equals(Utils.ObjectToString(strTestName)) Then
                    cboTestName.Items.Add(strTestName)
                End If

            Next
        Catch ex As Exception
            'no processing here
        End Try
        If objDialogMode = DialogMode.Load Then
            grbTestName.Text = "Select a Test to load:"
            If cboTestName.Items.Count > 0 Then
                cboTestName.SelectedIndex = 0
            End If

        Else
            grbTestName.Text = "Input a Test name to save:"
        End If
        cboTestName.AutoCompleteMode = AutoCompleteMode.SuggestAppend
    End Sub
End Class

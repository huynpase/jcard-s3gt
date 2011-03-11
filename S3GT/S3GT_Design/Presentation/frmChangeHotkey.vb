Imports System.Text
Imports System.IO

Public Class frmChangeHotkey
    'Constants


    Dim arrHotkeyList As ArrayList
    Dim strFirstKey As String
    Dim strLastKey As String

    Private Sub frmChangeHotkey_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'load hot key list from file
            arrHotkeyList = LoadHotKeyList()
            FillHotkeyListToCombo()
            'load pre-set hot keys
            SetDefautHotKeysRetrievedFromFile()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Dim fileHotKeyWriter As StreamWriter
        Dim strHotkeysFilePath
        Try
            Dim strAppFolderPath As String = Directory.GetCurrentDirectory & Constants_LanhVC.STR_TEST_FOLDER_PATH_SEPARATOR
            strHotkeysFilePath = strAppFolderPath & My.Settings.hotkeys_file
            fileHotKeyWriter = New StreamWriter(strHotkeysFilePath, False)
            fileHotKeyWriter.WriteLine(strFirstKey)
            fileHotKeyWriter.Write(strLastKey)
            fileHotKeyWriter.Flush()
            fileHotKeyWriter.Close()
            Me.Close()
        Catch ex As Exception
            Dim dlgResult As DialogResult
            dlgResult = MessageBox.Show("The settings has not been saved due to errors. Do you want to retry?", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
            If dlgResult = Windows.Forms.DialogResult.Cancel Then
                Me.Close()
            End If
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Dim dlgResult As DialogResult
        dlgResult = MessageBox.Show("The settings has not been saved. Do you want to exit?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
        If dlgResult = Windows.Forms.DialogResult.OK Then
            Me.Close()
        End If
    End Sub

    Public Function LoadHotKeyList() As ArrayList
        Dim strHotkeyListFilePath As String
        Dim fileHotkeyListFileReader As StreamReader
        Dim strLineContent As String
        Dim arrHotKeyListInFile As ArrayList = New ArrayList()
        Try
            Dim strAppFolderPath As String = Directory.GetCurrentDirectory & Constants_LanhVC.STR_TEST_FOLDER_PATH_SEPARATOR
            strHotkeyListFilePath = strAppFolderPath & My.Settings.hotkeylist_file
            fileHotkeyListFileReader = New StreamReader(strHotkeyListFilePath)
            strLineContent = fileHotkeyListFileReader.ReadLine().Trim()
            While (Not strLineContent Is Nothing AndAlso Not Constants_LanhVC.STR_BLANK_VALUE.Equals(strLineContent))
                If arrHotKeyListInFile.IndexOf(strLineContent) < 0 Then 'no such a hot key in list before
                    arrHotKeyListInFile.Add(strLineContent)
                End If
                strLineContent = fileHotkeyListFileReader.ReadLine()
            End While
            fileHotkeyListFileReader.Close()
            If arrHotKeyListInFile.Count <= 0 Then
                Throw New Exception()
                'ElseIf arrHotKeyListInFile.IndexOf("Ctrl") < 0 Then
                'Throw New Exception()
                'ElseIf arrHotKeyListInFile.IndexOf("Alt") < 0 Then
                'Throw New Exception()
                'ElseIf arrHotKeyListInFile.IndexOf("Shift") < 0 Then
                'Throw New Exception()
            ElseIf arrHotKeyListInFile.IndexOf("LClick") < 0 Then
                Throw New Exception()
            ElseIf arrHotKeyListInFile.IndexOf("RClick") < 0 Then
                Throw New Exception()
            End If
        Catch ex As Exception
            'get default key
            arrHotKeyListInFile.Clear()
            'arrHotKeyListInFile.Add("Ctrl")
            'arrHotKeyListInFile.Add("Alt")
            'arrHotKeyListInFile.Add("Shift")
            arrHotKeyListInFile.Add("RClick")
            arrHotKeyListInFile.Add("LClick")
        End Try
        Return arrHotKeyListInFile
    End Function
    Public Sub SetDefautHotKeysRetrievedFromFile()
        Dim strHotkeysFilePath As String
        Dim fileHotkeysFileReader As StreamReader
        Dim strLineContent As String
        Try
            Dim strAppFolderPath As String = Directory.GetCurrentDirectory & Constants_LanhVC.STR_TEST_FOLDER_PATH_SEPARATOR
            strHotkeysFilePath = strAppFolderPath & My.Settings.hotkeys_file
            fileHotkeysFileReader = New StreamReader(strHotkeysFilePath)
            strLineContent = fileHotkeysFileReader.ReadLine().Trim()
            If (Not strLineContent Is Nothing And Not Constants_LanhVC.STR_BLANK_VALUE.Equals(strLineContent)) Then
                strFirstKey = strLineContent
            Else
                Throw New Exception()
            End If
            strLineContent = fileHotkeysFileReader.ReadLine().Trim()
            If (Not strLineContent Is Nothing And Not Constants_LanhVC.STR_BLANK_VALUE.Equals(strLineContent)) Then
                strLastKey = strLineContent
            Else
                Throw New Exception()
            End If
            fileHotkeysFileReader.Close()

            Select Case strFirstKey
                Case "Ctrl"
                    radCtrl.Checked = True
                Case "Alt"
                    radAlt.Checked = True
                Case "Shift"
                    radShift.Checked = True
                Case Else
                    Throw New Exception
            End Select

            If strLastKey.Equals("LClick") Then
                strLastKey = "Left Click"
            ElseIf strLastKey.Equals("RClick") Then
                strLastKey = "Right Click"
            End If
            Dim selectedIndex As Integer = cboLastKey.FindString(strLastKey)
            If selectedIndex >= 0 Then
                cboLastKey.SelectedIndex = selectedIndex
            Else
                cboLastKey.Text = "Right Click"
            End If
        Catch ex As Exception
            radCtrl.Checked = True
            cboLastKey.Text = "Right Click"
        End Try
    End Sub

    Private Sub radCtrl_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radCtrl.CheckedChanged
        strFirstKey = "Ctrl"
        FillHotkeyListToCombo()
        cboLastKey.Items.Remove("Ctrl")
    End Sub

    Private Sub radAlt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radAlt.CheckedChanged
        strFirstKey = "Alt"
        FillHotkeyListToCombo()
        cboLastKey.Items.Remove("Alt")
    End Sub

    Private Sub radShift_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radShift.CheckedChanged
        strFirstKey = "Shift"
        FillHotkeyListToCombo()
        cboLastKey.Items.Remove("Shift")
    End Sub

    Private Sub cboLastKey_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLastKey.SelectedIndexChanged
        Select Case cboLastKey.Text
            Case "Ctrl"
                'change to other first key
                radCtrl.Checked = False
                radCtrl.Enabled = False
                radAlt.Enabled = True
                radShift.Enabled = True
            Case "Alt"
                'change to other first key
                radAlt.Checked = False
                radAlt.Enabled = False
                radCtrl.Enabled = True
                radShift.Enabled = True
            Case "Shift"
                radShift.Checked = False
                radAlt.Enabled = False
                radCtrl.Enabled = True
                radShift.Enabled = True
            Case Else
                radAlt.Enabled = True
                radCtrl.Enabled = True
                radShift.Enabled = True
        End Select
        strLastKey = cboLastKey.Text
        If strLastKey.Equals("Left Click") Then
            strLastKey = "LClick"
        ElseIf strLastKey.Equals("Right Click") Then
            strLastKey = "RClick"
        End If
    End Sub
    Private Sub FillHotkeyListToCombo()
        If (Not arrHotkeyList Is Nothing AndAlso arrHotkeyList.Count > 0) Then
            cboLastKey.Items.Clear()
            For Each strKey As String In arrHotkeyList
                Select Case strKey
                    Case "LClick"
                        cboLastKey.Items.Add("Left Click")
                    Case "RClick"
                        cboLastKey.Items.Add("Right Click")
                    Case Else
                        cboLastKey.Items.Add(strKey)
                End Select
            Next
        Else
            cboLastKey.Items.Add("Right Click")
        End If
    End Sub
End Class
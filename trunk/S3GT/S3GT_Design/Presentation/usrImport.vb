Imports System.IO
Public Class usrImport
    'thread to run progress bar...
    Dim thread As Threading.Thread = Nothing

    Private bo As ImportBO = New ImportBO

    Private objParamBO As ParameterBO

    Private Sub btnDestination_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDestination.Click
        If radKanjiExcel.Checked Then
            ofdImport.Filter() = "Excel file(*.xls)|*.xls"
        Else
            ofdImport.Filter() = "Text file(*.txt)|*.txt"
        End If

        ofdImport.FileName = ""
        ofdImport.ShowDialog()

        txtDest.Text = ofdImport.FileName
    End Sub

    Private Sub btnImgKanji_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImgKanji.Click
        fbdImport.ShowDialog()
        txtImgKanjiDest.Text = fbdImport.SelectedPath
    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        'objParamBO = New ParameterBO()

        'Try
        '    Dim objTopicGroupParam As ParameterEntity = objParamBO.GetParameterByName(Constants_LanhVC.STR_CONFIG_IMPORT_KANJI_PATH)
        '    txtDest.Text = objTopicGroupParam.ParameterValue

        '    objTopicGroupParam = objParamBO.GetParameterByName(Constants_LanhVC.STR_CONFIG_IMPORT_VOC_PATH)
        '    txtVocDest.Text = objTopicGroupParam.ParameterValue
        'Catch ex As Exception
        '    txtDest.Text = ""
        '    txtVocDest.Text = ""
        'End Try


    End Sub

    Private Sub btnVocDest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVocDest.Click
        If radVocExcel.Checked Then
            ofdImport.Filter = "Excel file(*.xls)|*.xls"
        Else
            ofdImport.Filter = "Text files(*.txt)|*.txt"
        End If

        ofdImport.FileName = ""
        ofdImport.ShowDialog()
        txtVocDest.Text = ofdImport.FileName
    End Sub
    'minhln2
    'add progress bar and import's status.
    Private Sub btnImportKanji_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportKanji.Click
        Dim blnOk As Boolean = True
        Dim blnResult As Boolean = True
        Dim strKanjiTo As String = ""
        Dim strExtension As String
        Dim strFilename As String
        Dim strFolder As String

        'preparing status
        Dim processbar As Processing = New Processing()
        processbar.d_setCancel = New Processing.SetCancel(AddressOf bo.SetCancel)
        processbar.Show()
        'Dim d As New SetTextCallback(AddressOf SetText)
        'Me.Invoke(d, New Object() {"Prepare to Import..."})
        Dim d_text As New SetTextCallback(AddressOf processbar.SetTextCallback)
        Dim d_pgrValue As New SetPgrValue(AddressOf processbar.SetPgrValue)
        Dim d_pgrMax As New SetPgrMaxValue(AddressOf processbar.SetPgrMaxValue)
        d_text("Prepare to Import...")
        Application.DoEvents()

        If txtDest.Text = "" Then
            txtDest.Focus()
            blnOk = False
            MessageBox.Show("You must choose folder contains file to import", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        If chkKanji.Checked Then
            If txtImgKanjiDest.Text = "" Then
                txtImgKanjiDest.Focus()
                blnOk = False
                MessageBox.Show("You must choose folder contains kanji image to import", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
        'check extension
        If txtDest.Text.Length = 0 Or txtDest.Text.IndexOf("\") < 0 Then
            MessageBox.Show("Path is not valid", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDest.Focus()
            blnOk = False
        End If

        strFolder = Utils.GetPath(txtDest.Text)
        If Not System.IO.Directory.Exists(strFolder) Then
            MessageBox.Show("Invalid path", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDest.Focus()
            blnOk = False
        End If


        strFilename = txtDest.Text.Substring(txtDest.Text.LastIndexOf("\"), txtDest.Text.Length - txtDest.Text.LastIndexOf("\"))
        If strFilename.IndexOf(".") > 0 And strFilename.Length >= 4 Then
            strExtension = strFilename.Substring(strFilename.Length - 4, 4)
            If (radKanjiExcel.Checked And strExtension <> ".xls") Or (radKanjiText.Checked And strExtension <> ".txt") Then
                MessageBox.Show("File extension is not valid", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtDest.Focus()
                blnOk = False
            End If
        End If

        'check file exists or not
        If Not System.IO.File.Exists(txtDest.Text) And txtDest.Text.Length > 0 Then
            MessageBox.Show("File is not exists", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            blnOk = False
        End If
        'check thu muc copy hinh kanji
        If chkKanji.Checked And txtImgKanjiDest.Text <> "" Then
            If Not Directory.Exists(txtImgKanjiDest.Text) Then
                MessageBox.Show(txtImgKanjiDest.Text & " foler is not exists", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                blnOk = False
            End If
        Else
            txtImgKanjiDest.Text = ""
        End If
        'start import
        If blnOk Then
            btnImportKanji.Enabled = False
            bo.CreateLog()
            If radKanjiExcel.Checked Then
                'pass progressbar to ImportKanjiExel function
                blnResult = bo.ImportKanjiExcel(txtDest.Text, txtImgKanjiDest.Text, d_text, d_pgrValue, d_pgrMax)
            Else
                'pass progressbar to ImportKanjiText function
                blnResult = bo.ImportKanjiText(txtDest.Text, txtImgKanjiDest.Text, d_text, d_pgrValue, d_pgrMax)
            End If
            'finish...
            'lb_ImportKanjiStatus.Text = "Finish!"
            d_text("Finish!")
            If blnResult Then
                If MessageBox.Show("Import successful! Do you want to view log file", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                    Dim strLogContent = bo.GetFileContents(bo.LogFileName)
                    Dim frm As System.Windows.Forms.Form = New frmLog(strLogContent)
                    processbar.Dispose()
                    frm.ShowDialog()
                Else
                    processbar.Dispose()
                End If
            Else
                If MessageBox.Show("Fail to import ! Do you want to view log file", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                    Dim strLogContent = bo.GetFileContents(bo.LogFileName)
                    Dim frm As System.Windows.Forms.Form = New frmLog(strLogContent)
                    processbar.Dispose()
                    frm.ShowDialog()
                Else
                    processbar.Dispose()
                End If
            End If
            btnImportKanji.Enabled = True
        Else
            processbar.Dispose()
        End If
    End Sub

    'minhln2
    'delegate's used by import kanji function.
    Public Delegate Sub SetTextCallback(ByVal text As String)
    Public Delegate Sub SetPgrMaxValue(ByVal value As Integer)
    Public Delegate Sub SetPgrValue(ByVal value As Integer)


    'minhln2
    'button cancel click
    Private Sub btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    'minh ln2
    'function Import Kanji
    Private Sub ImportKanji()

    End Sub
    'minhln2
    'call back method, use to synchronize between thread.
    Private Sub SetText(ByVal [text] As String)
        'Me.lb_ImportKanjiStatus.Text = [text]
    End Sub



    'minhln2
    'add progress bar
    Private Sub btnVocImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVocImport.Click
        Dim frm As System.Windows.Forms.Form
        Dim strExtension As String
        Dim strFilename As String
        Dim strFolder As String
        Dim blnOk As Boolean = True
        'preparing status
        Dim processbar As Processing = New Processing()
        processbar.d_setCancel = New Processing.SetCancel(AddressOf bo.SetCancel)
        processbar.Show()
        Dim d_text As New SetTextCallback(AddressOf processbar.SetTextCallback)
        Dim d_pgrValue As New SetPgrValue(AddressOf processbar.SetPgrValue)
        Dim d_pgrMax As New SetPgrMaxValue(AddressOf processbar.SetPgrMaxValue)
        d_text("Prepare to Import...")
        Application.DoEvents()

        Try
            If txtVocDest.Text = "" Then
                txtVocDest.Focus()
                MessageBox.Show("You must choose folder contains file to import", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                blnOk = False
            End If

            'check extension
            If txtVocDest.Text.Length = 0 Or txtVocDest.Text.IndexOf("\") < 0 Then
                MessageBox.Show("Path is not valid", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtVocDest.Focus()
                blnOk = False
            End If

            strFolder = Utils.GetPath(txtVocDest.Text)
            If Not System.IO.Directory.Exists(strFolder) Then
                MessageBox.Show("Invalid path", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtVocDest.Focus()
                blnOk = False
            End If

            strFilename = txtVocDest.Text.Substring(txtVocDest.Text.LastIndexOf("\"), txtVocDest.Text.Length - txtVocDest.Text.LastIndexOf("\"))
            If strFilename.IndexOf(".") > 0 And strFilename.Length >= 4 Then
                strExtension = strFilename.Substring(strFilename.Length - 4, 4)
                If (radVocExcel.Checked And strExtension <> ".xls") Or (radVocText.Checked And strExtension <> ".txt") Then
                    MessageBox.Show("File extension is not valid", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtVocDest.Focus()
                    blnOk = False
                End If
            End If

            ' check file exists or not
            If Not System.IO.File.Exists(txtVocDest.Text) And txtVocDest.Text.Length > 0 Then
                MessageBox.Show("File does not exist", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtVocDest.Focus()
                blnOk = False
            End If

            'start import
            If blnOK Then
                btnVocImport.Enabled = False
                bo.LogContent = ""
                bo.CreateLog()
                If radVocExcel.Checked Then
                    If bo.ImportVocExcel(txtVocDest.Text, d_text, d_pgrValue, d_pgrMax) Then
                        frmMainForm.LoadDataToTree()
                        If MessageBox.Show("Import successful, view log file ?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                            Dim strLogContent = bo.GetFileContents(bo.LogFileName)
                            frm = New frmLog(strLogContent)
                            processbar.Dispose()
                            frm.ShowDialog()
                        Else
                            processbar.Dispose()
                        End If
                    Else
                        processbar.Dispose()
                    End If
                Else
                    If bo.ImportVocText(txtVocDest.Text, d_text, d_pgrValue, d_pgrMax) Then
                        frmMainForm.LoadDataToTree()

                        If MessageBox.Show("Import successful, view log file ?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                            Dim strLogContent = bo.GetFileContents(bo.LogFileName)
                            frm = New frmLog(strLogContent)
                            processbar.Dispose()
                            frm.ShowDialog()
                        End If
                    Else
                        processbar.Dispose()
                    End If
                End If
            Else
                processbar.Dispose()
            End If
            btnVocImport.Enabled = True
        Catch ex As Exception
            btnVocImport.Enabled = True
            processbar.Dispose()
        End Try

    End Sub


    Private Sub radKanjiText_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radKanjiText.CheckedChanged

    End Sub
End Class

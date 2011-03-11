Imports System.IO
Public Class usrExport
    Dim bo As New ExportBO
    Dim util As Utils = New Utils
    Dim objParamBO As ParameterBO

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Dim node As TreeNode
        Dim subnode As TreeNode
        Dim dtTopic As DataTable
        Dim dtSubTopic As DataTable
        Dim dtKanji As DataTable
        Dim row As DataRow
        Dim rowSub As DataRow

        'Tab Kanji
        dtKanji = bo.GetKanji()
        If dtKanji.Rows.Count > 0 Then
            For Each row In dtKanji.Rows
                node = New TreeNode(row(Constants_PhatLS.STR_Kanji))
                node.Name = row(Constants_PhatLS.STR_Kanji_ID)
                treeKanji.Nodes.Add(node)
            Next
        End If
        'Tab Vocabulary
        dtTopic = bo.GetToppic()
        If dtTopic.Rows.Count > 0 Then
            For Each row In dtTopic.Rows
                node = New TreeNode
                node.Text = row(Constants_LanhVC.STR_TPG_COLUMN_NAME_TOPIC_GROUP_NAME)
                ' treenode = tree.Nodes.Add(row("topic_group_name"))
                node.Name = row(Constants_LanhVC.STR_TPG_COLUMN_NAME_TOPIC_GROUP_ID)
                dtSubTopic = bo.GetSubToppic(row(Constants_LanhVC.STR_TPG_COLUMN_NAME_TOPIC_GROUP_ID))
                If dtSubTopic.Rows.Count > 0 Then
                    For Each rowSub In dtSubTopic.Rows
                        'treenode.Nodes.Insert(1, rowSub("topic_name"))
                        subnode = New TreeNode
                        subnode.Text = rowSub(Constants_LanhVC.STR_TPC_COLUMN_NAME_TOPIC_NAME)
                        subnode.Name = rowSub(Constants_LanhVC.STR_TPC_COLUMN_NAME_TOPIC_ID)
                        node.Nodes.Add(subnode)
                    Next
                End If
                tree.Nodes.Add(node)
            Next
        End If
        ' expand all and check all vocabulary topic
        tree.ExpandAll()

        'GiangNVT modified
        'For Each node In tree.Nodes
        '    node.Checked = True
        '    For Each subnode In node.Nodes
        '        subnode.Checked = True
        '    Next
        'Next

        'check all kanji list
        'For Each node In treeKanji.Nodes
        '    node.Checked = True
        'Next
        'txtImgKanjiDest.Text = Utils.GetPath(Application.ExecutablePath)

        objParamBO = New ParameterBO()

        Try
            Dim objTopicGroupParam As ParameterEntity = objParamBO.GetParameterByName(Constants_LanhVC.STR_CONFIG_EXPORT_KANJI_PATH)
            txtDest.Text = objTopicGroupParam.ParameterValue

            objTopicGroupParam = objParamBO.GetParameterByName(Constants_LanhVC.STR_CONFIG_EXPORT_VOC_PATH)
            txtVocDest.Text = objTopicGroupParam.ParameterValue

            objTopicGroupParam = objParamBO.GetParameterByName(Constants_LanhVC.STR_CONFIG_EXPORT_KANJI_IMAGE_PATH)
            txtImgKanjiDest.Text = objTopicGroupParam.ParameterValue
        Catch ex As Exception
            txtDest.Text = ""
            txtVocDest.Text = ""
            txtImgKanjiDest.Text = ""
        End Try

    End Sub

    Private Sub btnVocDest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVocDest.Click
        'If radVocExcel.Checked Then
        '    sfd.Filter = "Excel *.xls| *.xls"
        'Else
        '    sfd.Filter = "Text *.txt| *.txt"
        'End If
        sfd.ShowDialog()
        txtVocDest.Text = sfd.SelectedPath
    End Sub

    Private Sub btnVoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoc.Click
        'Dim strFileName As String
        'Dim strExtension As String
        Dim strFolder As String
        Dim ok As Boolean = True

        'preparing status
        Dim processbar As Processing = New Processing()
        processbar.d_setCancel = New Processing.SetCancel(AddressOf bo.SetCancel)
        'processbar.
        processbar.Show()
        Dim d_text As New SetTextCallback(AddressOf processbar.SetTextCallback)
        Dim d_pgrValue As New SetPgrValue(AddressOf processbar.SetPgrValue)
        Dim d_pgrMax As New SetPgrMaxValue(AddressOf processbar.SetPgrMaxValue)
        d_text("Prepare to Export...")
        Application.DoEvents()

        'check...

        If txtVocDest.Text Is Nothing OrElse txtVocDest.Text = "" Then
            MessageBox.Show("You must choose folder contains exported file", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            processbar.Dispose()
            Return
        End If
        'check extension
        If txtVocDest.Text.Length = 0 OrElse txtVocDest.Text.IndexOf("\") < 0 Then
            MessageBox.Show("Path is not valid", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtVocDest.Focus()
            processbar.Dispose()
            Return
        End If

        strFolder = Utils.GetPath(txtVocDest.Text)
        If Not System.IO.Directory.Exists(strFolder) Then
            MessageBox.Show("Invalid path", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtVocDest.Focus()
            processbar.Dispose()
            Return
        End If

        'Save path
        Dim objChosenTopicGroup As New ParameterEntity
        objChosenTopicGroup.ParameterName = Constants_LanhVC.STR_CONFIG_EXPORT_VOC_PATH
        objChosenTopicGroup.ParameterValue = txtVocDest.Text
        objParamBO.UpdateParameter(objChosenTopicGroup)


        'strFileName = txtVocDest.Text.Substring(txtVocDest.Text.LastIndexOf("\"), txtVocDest.Text.Length - txtVocDest.Text.LastIndexOf("\"))
        'If strFileName.IndexOf(".") > 0 And strFileName.Length >= 4 Then
        '    strExtension = strFileName.Substring(strFileName.Length - 4, 4)
        '    If (radVocExcel.Checked And strExtension <> ".xls") Or (radVocText.Checked And strExtension <> ".txt") Then
        '        MessageBox.Show("File extension is not valid", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '        txtVocDest.Focus()
        '        ok = False
        '    End If
        'End If

        'If txtVocDest.Text.IndexOf(".") < 0 Then
        '    If radVocExcel.Checked Then
        '        txtVocDest.Text = txtVocDest.Text + ".xls"
        '    Else
        '        txtVocDest.Text = txtVocDest.Text + ".txt"
        '    End If
        'End If

        If (ok) Then
            bo.CreateLog()
            If ExportVocabulary(radVocExcel.Checked, d_text, d_pgrMax, d_pgrValue) Then
                If MessageBox.Show("Export successful! Do you want to view log file", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                    Dim strLogContent = bo.GetFileContents(bo.LogFileName)
                    Dim frm As System.Windows.Forms.Form = New frmLog(strLogContent)
                    frm.ShowDialog()
                End If
                processbar.Dispose()
            Else
                MessageBox.Show("Fail to export", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                processbar.Dispose()
            End If
        Else
            processbar.Dispose()
        End If
    End Sub

    Private Sub btnKanjiDest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKanjiDest.Click
        'If radExcel.Checked Then
        '    sfd.Filter = "Excel *.xls| *.xls"
        'Else
        '    sfd.Filter = "Text *.txt| *.txt"
        'End If

        sfd.ShowDialog()
        txtDest.Text = sfd.SelectedPath
    End Sub

    Private Sub btnImgDest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImgDest.Click
        fbd.ShowDialog()
        txtImgKanjiDest.Text = fbd.SelectedPath
    End Sub

    'Minhln2...
    'add ProgressBar and label Progress Description
    Private Sub btnKanji_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKanji.Click
        'Dim strExtension As String
        'Dim strFilename As String
        Dim strFolder As String
        Dim ok As Boolean = True

        'show status: "prepare to export"...
        Dim processbar As Processing = New Processing()
        processbar.d_setCancel = New Processing.SetCancel(AddressOf bo.SetCancel)
        processbar.Show()
        Application.DoEvents()
        Dim d_text As New SetTextCallback(AddressOf processbar.SetTextCallback)
        Dim d_pgrValue As New SetPgrValue(AddressOf processbar.SetPgrValue)
        Dim d_pgrMax As New SetPgrMaxValue(AddressOf processbar.SetPgrMaxValue)
        d_text("Prepare to Export...")

        Try
            If txtDest.Text = "" Then
                txtDest.Focus()
                MessageBox.Show("You must choose folder to export", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                processbar.Dispose()
                Return
            End If
            If chkKanji.Checked Then
                If txtImgKanjiDest.Text = "" Then
                    txtImgKanjiDest.Focus()
                    MessageBox.Show("You must choose folder to exports kanji images", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    processbar.Dispose()
                    Return
                End If
            End If
            'check extension
            If txtDest.Text.Length = 0 Or txtDest.Text.IndexOf("\") < 0 Then
                MessageBox.Show("Path is not valid", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtDest.Focus()
                processbar.Dispose()
                Return
            End If

            strFolder = Utils.GetPath(txtDest.Text)
            If Not System.IO.Directory.Exists(strFolder) Then
                MessageBox.Show("Invalid path", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtDest.Focus()
                ok = False
            End If

            'Save path
            Dim objChosenTopicGroup As New ParameterEntity
            objChosenTopicGroup.ParameterName = Constants_LanhVC.STR_CONFIG_EXPORT_KANJI_PATH
            objChosenTopicGroup.ParameterValue = txtDest.Text
            objParamBO.UpdateParameter(objChosenTopicGroup)

            objChosenTopicGroup.ParameterName = Constants_LanhVC.STR_CONFIG_EXPORT_KANJI_IMAGE_PATH
            objChosenTopicGroup.ParameterValue = txtImgKanjiDest.Text
            objParamBO.UpdateParameter(objChosenTopicGroup)

            'strFilename = txtDest.Text.Substring(txtDest.Text.LastIndexOf("\"), txtDest.Text.Length - txtDest.Text.LastIndexOf("\"))

            'If strFilename.IndexOf(".") > 0 And strFilename.Length >= 4 Then
            '    strExtension = strFilename.Substring(strFilename.Length - 4, 4)
            '    If (radExcel.Checked And strExtension <> ".xls") Or (radText.Checked And strExtension <> ".txt") Then
            '        MessageBox.Show("File extension is not valid", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '        txtDest.Focus()
            '        ok = False
            '    End If
            'End If

            'If txtDest.Text.IndexOf(".") < 0 Then
            '    If radVocExcel.Checked Then
            '        txtDest.Text = txtDest.Text + ".xls"
            '    Else
            '        txtDest.Text = txtDest.Text + ".txt"
            '    End If
            'End If

            'start export
            Application.DoEvents()
            If ok Then
                bo.CreateLog()
                If ExportKanji(txtDest.Text, radExcel.Checked, d_text, d_pgrMax, d_pgrValue) Then
                    processbar.Dispose()
                    If MessageBox.Show("Export successful! Do you want to view log file", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                        Dim strLogContent = bo.GetFileContents(bo.LogFileName)
                        Dim frm As System.Windows.Forms.Form = New frmLog(strLogContent)
                        frm.ShowDialog()
                    End If
                Else
                    MessageBox.Show("Fail to export", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    processbar.Dispose()
                End If
            Else
                processbar.Dispose()
            End If
        Catch ex As Exception
            processbar.Dispose()
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    

    Private Sub tree_NodeMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles tree.NodeMouseClick
        Dim node As TreeNode
        Dim blnAll As Boolean

        If e.Node.Level = 0 Then
            For Each node In e.Node.Nodes
                node.Checked = e.Node.Checked
            Next
        Else
            For Each node In e.Node.Parent.Nodes
                blnAll = blnAll Or node.Checked
            Next
            e.Node.Parent.Checked = blnAll
        End If


    End Sub

    Private Sub treeKanji_NodeMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs)
        Dim node As TreeNode
        Dim blnAll As Boolean

        If e.Node.Level = 0 Then
            For Each node In e.Node.Nodes
                node.Checked = e.Node.Checked
            Next
        Else
            For Each node In e.Node.Parent.Nodes
                blnAll = blnAll Or node.Checked
            Next
            e.Node.Parent.Checked = blnAll
        End If
    End Sub

    Private Sub btnCheckAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckAll.Click
        Dim node As TreeNode
        For Each node In treeKanji.Nodes
            node.Checked = True
        Next
    End Sub

    Private Sub btnUncheckAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnCheckAll.Click
        Dim node As TreeNode
        For Each node In treeKanji.Nodes
            node.Checked = False
        Next
    End Sub

    'minhln2
    'add progressbar
    Function ExportVocabulary(ByVal blnExcel As Boolean, ByVal d_text As SetTextCallback, _
    ByVal d_pgrMax As SetPgrMaxValue, ByVal d_pgrValue As SetPgrValue) As Boolean
        Dim node As TreeNode
        Dim subnode As TreeNode
        Dim dt As DataTable
        Dim row As DataRow
        Dim blnResult As Boolean = True
        Try
            dt = New DataTable
            dt.Columns.Add("NodeId")
            dt.Columns.Add("NodeName")
            dt.Columns.Add("SubNodeId")
            dt.Columns.Add("SubNodeName")
            For Each node In tree.Nodes
                For Each subnode In node.Nodes
                    If subnode.Checked Then
                        row = dt.NewRow
                        row(0) = node.Name
                        row(1) = node.Text
                        row(2) = subnode.Name
                        row(3) = subnode.Text
                        dt.Rows.Add(row)

                    End If
                Next
            Next
            'exporting ...
            If blnExcel Then
                blnResult = bo.ExportVocExcel(txtVocDest.Text, dt, d_pgrMax, d_pgrValue)
            Else
                blnResult = bo.ExportVocText(txtVocDest.Text, dt, d_pgrMax, d_pgrValue)
            End If
            'd_text("Finish!")

            Return blnResult
        Catch ex As Exception
            'If ex.Message.Substring(0, Constants_NguyenNB.ERR_MESS_OPENING.Length) = Constants_NguyenNB.ERR_MESS_OPENING Then
            'MessageBox.Show(Constants_NguyenNB.MESS_OPENING, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'Else
            MessageBox.Show(ex.Message + " ExportVocabulary", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'End If
            d_text("")
            Return False
        End Try

    End Function

    'Minhln2
    'Add ProgressBar and label display export status
    Function ExportKanji(ByVal strFileName As String, ByVal blnExcel As Boolean, ByVal d_text As SetTextCallback, _
    ByVal d_pgrMax As SetPgrMaxValue, ByVal d_pgrValue As SetPgrValue) As Boolean
        Dim node As TreeNode
        Dim dt As DataTable
        Dim row As DataRow
        Dim strKanjiFrom As String
        Dim blnOk As Boolean = True
        Dim strImgKanji As String = ""
        Dim blnResult As Boolean

        Try
            strKanjiFrom = Utils.GetPath(Application.ExecutablePath) + "\" + Constants_NguyenNB.KANJI_FOLDER
            dt = New DataTable
            dt.Columns.Add("kanji_id")
            dt.Columns.Add("kanji_name")

            For Each node In treeKanji.Nodes
                If node.Checked Then
                    row = dt.NewRow
                    row(0) = node.Name
                    row(1) = node.Text
                    dt.Rows.Add(row)
                End If
            Next

            If chkKanji.Checked Then
                If Not Directory.Exists(Utils.GetPath(txtImgKanjiDest.Text)) Then
                    MessageBox.Show(txtImgKanjiDest.Text & " foler is not exists")
                    blnOk = False
                End If
                If Not Directory.Exists(strKanjiFrom) Then
                    MessageBox.Show(strKanjiFrom & " foler is not exists")
                    blnOk = False
                End If
            Else
                strKanjiFrom = ""
            End If
            'show export's status: exporting...
            d_text("Exporting...")
            If blnOk Then
                If blnExcel Then
                    'pass ProgressBar to ExportKanjiExel function
                    blnResult = bo.ExportKanjiExcel(strFileName, dt, strKanjiFrom, txtImgKanjiDest.Text, d_pgrMax, d_pgrValue)
                Else
                    'pass ProgressBar to ExportKanjiText function
                    blnResult = bo.ExportKanjiText(strFileName, dt, strKanjiFrom, txtImgKanjiDest.Text, d_pgrMax, d_pgrValue)
                End If
            End If
            'show export status: fisnish!
            d_text("Finish!")
            Return blnResult
        Catch ex As Exception
            If ex.Message.Substring(0, Constants_NguyenNB.ERR_MESS_OPENING.Length) = Constants_NguyenNB.ERR_MESS_OPENING Then
                MessageBox.Show(Constants_NguyenNB.MESS_OPENING, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                MessageBox.Show(ex.Message)
            End If
            d_text("")
            Return False
        End Try

    End Function

    'minhln2
    'delegate's used by export kanji function.
    Public Delegate Sub SetTextCallback(ByVal text As String)
    Public Delegate Sub SetPgrMaxValue(ByVal value As Integer)
    Public Delegate Sub SetPgrValue(ByVal value As Integer)

    Private Sub radVocExcel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radVocExcel.CheckedChanged

    End Sub

    Private Sub btn_SelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SelectAll.Click
        Dim node As TreeNode
        Dim subnode As TreeNode
        For Each node In tree.Nodes
            node.Checked = True
            For Each subnode In node.Nodes
                subnode.Checked = True
            Next
        Next
    End Sub

    Private Sub btn_DeselectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_DeselectAll.Click
        Dim node As TreeNode
        Dim subnode As TreeNode
        For Each node In tree.Nodes
            node.Checked = False
            For Each subnode In node.Nodes
                subnode.Checked = False
            Next
        Next
    End Sub
End Class

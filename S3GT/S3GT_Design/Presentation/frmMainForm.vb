Public Class frmMainForm
    Dim quickMode As Boolean = False
    Dim usrImport As usrImport
    Dim usrExport As usrExport
    'BINHNC1 start
    Dim usrConvert As usrConvert
    'BINHNC1 end
    Dim usrAddSingleKanji As usrAddSingleKanji
    Dim usrSearchSingleKanji As usrSearchSingleKanji
    Dim usrTopic As usrTopic
    Dim usrAdd_New_Topic_Group As usrAdd_New_Topic_Group
    Dim usrUpdate_Topic_Group As usrUpdate_Topic_Group
    Dim usrDelete_Topic_Group As usrDelete_Topic_Group
    Dim usrFastRegVoc As usrFastRegisterVocabularies
    Dim usrPerformTest As usrPerformTest
    Dim usrPerformSpecialTest As usrPerformSpecialTest
    Dim NoteSelect As New TreeNode()
    Dim Voc As usrVocabularies
    'LongBT start
    Dim usrSearchVoc As usrSearchVocabularies
    'LongBT end

    Public Sub LoadDataToTree()
        Dim tree As TreeNode
        Dim TopicNode As TreeNode
        Dim objToPicGroupBO As TopicGroupsBO
        Dim objTopicBO As TopicsBO
        Dim objTopicGroupTable As DataTable
        Dim objTopicTable As DataTable
        Dim i, j As Integer
        Dim strTopicGroupName As String

        'init
        objToPicGroupBO = New TopicGroupsBO()
        objTopicBO = New TopicsBO()
        objTopicGroupTable = Nothing
        objTopicTable = Nothing
        strTopicGroupName = Constants_LanhVC.STR_BLANK_VALUE

        treeTopic.Nodes.Clear()

        objTopicGroupTable = objToPicGroupBO.GetTopicGroupsTable()
        For i = 0 To objTopicGroupTable.Rows.Count - 1
            'Get Topic group name
            strTopicGroupName = objTopicGroupTable.Rows(i)(Constants_LanhVC.STR_TPG_COLUMN_NAME_TOPIC_GROUP_NAME).ToString()
            'get topic group to tree
            tree = treeTopic.Nodes.Add(strTopicGroupName)
            tree.Name = strTopicGroupName
            'Get all topic of Topic group
            objTopicTable = objTopicBO.GetTopicListByTopicGroupName(strTopicGroupName)

            'set topic to tree
            For j = 0 To objTopicTable.Rows.Count - 1
                TopicNode = tree.Nodes.Add(objTopicTable.Rows(j)(Constants_LanhVC.STR_TPC_COLUMN_NAME_TOPIC_NAME).ToString())
                TopicNode.Name = objTopicTable.Rows(j)(Constants_LanhVC.STR_TPC_COLUMN_NAME_TOPIC_NAME).ToString()
            Next
        Next
    End Sub

    Public Sub LoadDataToTree(ByVal strTopicGroupName As String)
        LoadDataToTree()
        treeTopic.Nodes(strTopicGroupName).Expand()
    End Sub

    Public Sub AddNewTopicToTree(ByVal strTopicGroupName As String, ByVal strTopic As String)
        Dim tree As TreeNode
        tree = treeTopic.Nodes(strTopicGroupName).Nodes.Add(strTopic)
        tree.Name = strTopic
    End Sub

    Public Sub UpdateTopicToTree(ByVal strOldTopicGroup As String, ByVal strTopicGroup As String, ByVal strOldTopic As String, ByVal strNewTopic As String)
        'GiangNVT modified
        Dim oldNode As TreeNode
        Dim newNode As TreeNode
        oldNode = treeTopic.Nodes(strOldTopicGroup)
        oldNode = oldNode.Nodes(strOldTopic)
        oldNode.Remove()

        oldNode.Name = strNewTopic
        oldNode.Text = strNewTopic
        newNode = treeTopic.Nodes(strTopicGroup)
        newNode.Nodes.Add(oldNode)

    End Sub

    Public Sub DeleteTopicNote(ByVal strTopicGroup As String, ByVal strTopic As String)
        Dim tree As TreeNode
        Dim TopicTree As TreeNode

        tree = treeTopic.Nodes(strTopicGroup)
        TopicTree = tree.Nodes(strTopic)

        tree.Nodes.Remove(TopicTree)
    End Sub


    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadDataToTree()

        'tree = treeTopic.Nodes.Add("Group1")
        'tree.Nodes.Insert(1, "Topic of Group11")
        'tree.Nodes.Insert(1, "Topic of Group12")
        'tree.Nodes.Insert(1, "Topic of Group13")

        'tree = treeTopic.Nodes.Add("Group2")
        'tree.Nodes.Insert(1, "Topic of Group21")
        'tree.Nodes.Insert(1, "Topic of Group22")
        'tree.Nodes.Insert(1, "Topic of Group23")

        'tree = treeTopic.Nodes.Add("Group3")
        'tree.Nodes.Insert(1, "Topic of Group31")
        'tree.Nodes.Insert(1, "Topic of Group32")
        'tree.Nodes.Insert(1, "Topic of Group33")

    End Sub

    'Click Topic get infomation of Note
    Private Sub treeTopic_NodeMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles treeTopic.NodeMouseClick

        Try
            usrPerformSpecialTest.blnTesting = False
            usrPerformSpecialTest.timerTotalAnswerTime.Stop()
            usrPerformSpecialTest.timerTotalAnswerTime.Dispose()
            usrPerformSpecialTest.timerAnswerTime.Stop()
            usrPerformSpecialTest.timerAnswerTime.Dispose()
        Catch ex As Exception

        End Try

        'GiangNVT modified
        Me.WindowState = FormWindowState.Maximized

        'set node select
        treeTopic.SelectedNode = e.Node
        NoteSelect = e.Node

        If e.Button = Windows.Forms.MouseButtons.Right Then

            If Not NoteSelect.Parent Is Nothing Then
                'show context menu for a Topic
                treeTopic.ContextMenuStrip = contextTopicMenu
            Else
                'show context menu for a Topic
                treeTopic.ContextMenuStrip = contextTopicGroupMenu
            End If
            'show sub menu
            treeTopic.ContextMenuStrip.Show(e.Location)

            'set node select
            'treeTopic.SelectedNode = e.Node
            'NoteSelect = e.Node

        ElseIf e.Button = Windows.Forms.MouseButtons.Left And Not NoteSelect.Parent Is Nothing Then
            'panContain.Controls.Clear()
            'panContain.Controls.Add(Voc)
            'Voc.Dock = DockStyle.Fill
            'Voc.SetTextTopicGroupControl(NoteSelect.Parent.Text)
            'Voc.SetTextTopicControl(NoteSelect.Text)
            'Voc.SetTextForButton(Constants_LanhVC.STR_SUBMIT, Constants_LanhVC.STR_SUBMIT_UPDATE)
            'Voc.TypeVovabirary = Constants_LanhVC.STR_TYPE_UPDATE
            'Voc.DisplayButton()
            'Voc.ClearDataGrid()
            'Voc.FillDataToUserControl()
            mnuDisplayVocabulary_Click(sender, e)
        End If

    End Sub

    Private Sub mnuCreateTopicGroup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCreateTopicGroup.Click

        Try
            usrPerformSpecialTest.blnTesting = False
            usrPerformSpecialTest.timerTotalAnswerTime.Stop()
            usrPerformSpecialTest.timerTotalAnswerTime.Dispose()
            usrPerformSpecialTest.timerAnswerTime.Stop()
            usrPerformSpecialTest.timerAnswerTime.Dispose()
        Catch ex As Exception

        End Try

        performCreateTopicGroup(NoteSelect)
    End Sub

    Private Sub mnuAddVocabularies_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAddVocabularies.Click

        Try
            usrPerformSpecialTest.blnTesting = False
            usrPerformSpecialTest.timerTotalAnswerTime.Stop()
            usrPerformSpecialTest.timerTotalAnswerTime.Dispose()
            usrPerformSpecialTest.timerAnswerTime.Stop()
            usrPerformSpecialTest.timerAnswerTime.Dispose()
        Catch ex As Exception

        End Try

        performAddVocabularies(NoteSelect)
    End Sub


    Private Sub mnuDisplayVocabulary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles mnuDisplayVocabularies.Click
        Voc = New usrVocabularies(NoteSelect.Parent.Text, NoteSelect.Text, Utils.ModeUpdate.Update)
        panContain.Controls.Clear()
        panContain.Controls.Add(Voc)
        Voc.Dock = DockStyle.Fill
        Voc.SetTextTopicGroupControl(NoteSelect.Parent.Text)
        Voc.SetTextTopicControl(NoteSelect.Text)
        'Voc.SetTextForButton(Constants_LanhVC.STR_SUBMIT, Constants_LanhVC.STR_SUBMIT_UPDATE)
        Voc.TypeVovabirary = Constants_LanhVC.STR_TYPE_UPDATE
        Voc.DisplayButton()
        Voc.ClearDataGrid()
        Voc.FillDataToUserControl(Constants_LanhVC.STR_BLANK_VALUE)

    End Sub

    Private Sub mnuUpdateTopicGroup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuUpdateTopicGroup.Click

        Try
            usrPerformSpecialTest.blnTesting = False
            usrPerformSpecialTest.timerTotalAnswerTime.Stop()
            usrPerformSpecialTest.timerTotalAnswerTime.Dispose()
            usrPerformSpecialTest.timerAnswerTime.Stop()
            usrPerformSpecialTest.timerAnswerTime.Dispose()
        Catch ex As Exception

        End Try

        performUpdateTopicGroup(NoteSelect)
        'If Not NoteSelect.Parent Is Nothing Then
        'panContain.Controls.Clear()
        'panContain.Controls.Add(Voc)
        'Voc.SetTextTopicControl(NoteSelect.Text)
        'Voc.SetTextTopicGroupControl(NoteSelect.Parent.Text)
        'Voc.SetStatusForButton(Constants_LanhVC.STR_SUBMIT, Constants_LanhVC.INT_ENABLE_FALSE)
        'Voc.SetStatusForButton(Constants_LanhVC.STR_CANCEL, Constants_LanhVC.INT_ENABLE_FALSE)
        'Voc.TypeVovabirary = Constants_LanhVC.STR_TYPE_UPDATE
        'Voc.DisplayButton()
        'Else
        'MessageBox.Show("Create Group")
        'End If
    End Sub

    Private Sub mnuFile_Import_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFile_Import.Click

        Try
            usrPerformSpecialTest.blnTesting = False
            usrPerformSpecialTest.timerTotalAnswerTime.Stop()
            usrPerformSpecialTest.timerTotalAnswerTime.Dispose()
            usrPerformSpecialTest.timerAnswerTime.Stop()
            usrPerformSpecialTest.timerAnswerTime.Dispose()
        Catch ex As Exception

        End Try

        usrImport = New usrImport()
        panContain.Controls.Clear()
        usrImport.Dock = DockStyle.Fill
        panContain.Controls.Add(usrImport)
    End Sub

    Private Sub mnuFile_Export_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFile_Export.Click

        Try
            usrPerformSpecialTest.blnTesting = False
            usrPerformSpecialTest.timerTotalAnswerTime.Stop()
            usrPerformSpecialTest.timerTotalAnswerTime.Dispose()
            usrPerformSpecialTest.timerAnswerTime.Stop()
            usrPerformSpecialTest.timerAnswerTime.Dispose()
        Catch ex As Exception

        End Try

        usrExport = New usrExport()
        panContain.Controls.Clear()
        usrExport.Dock = DockStyle.Fill
        panContain.Controls.Add(usrExport)
    End Sub


    Private Sub mnuTopicGroup_AddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTopicGroup_AddNew.Click

        Try
            usrPerformSpecialTest.blnTesting = False
            usrPerformSpecialTest.timerTotalAnswerTime.Stop()
            usrPerformSpecialTest.timerTotalAnswerTime.Dispose()
            usrPerformSpecialTest.timerAnswerTime.Stop()
            usrPerformSpecialTest.timerAnswerTime.Dispose()
        Catch ex As Exception

        End Try
        'usrAdd_New_Topic_Group = New usrAdd_New_Topic_Group()
        'usrAdd_New_Topic_Group.Dock = DockStyle.Fill
        'panContain.Controls.Clear()
        'panContain.Controls.Add(usrAdd_New_Topic_Group)
        performCreateTopicGroup(NoteSelect)

    End Sub

    Private Sub mnuTopicGroup_Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTopicGroup_Update.Click

        Try
            usrPerformSpecialTest.blnTesting = False
            usrPerformSpecialTest.timerTotalAnswerTime.Stop()
            usrPerformSpecialTest.timerTotalAnswerTime.Dispose()
            usrPerformSpecialTest.timerAnswerTime.Stop()
            usrPerformSpecialTest.timerAnswerTime.Dispose()
        Catch ex As Exception

        End Try
        'usrUpdate_Topic_Group.Dock = DockStyle.Fill
        'panContain.Controls.Clear()
        'panContain.Controls.Add(usrUpdate_Topic_Group)
        performUpdateTopicGroup(NoteSelect)
    End Sub

    Private Sub mnuTopicGroup_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTopicGroup_Delete.Click

        Try
            usrPerformSpecialTest.blnTesting = False
            usrPerformSpecialTest.timerTotalAnswerTime.Stop()
            usrPerformSpecialTest.timerTotalAnswerTime.Dispose()
            usrPerformSpecialTest.timerAnswerTime.Stop()
            usrPerformSpecialTest.timerAnswerTime.Dispose()
        Catch ex As Exception

        End Try

        Dim usrTopicGroup As New usrDelete_Topic_Group()
        usrTopicGroup.Dock = DockStyle.Fill
        panContain.Controls.Clear()
        panContain.Controls.Add(usrTopicGroup)
    End Sub


    Private Sub mnuSingleKanji_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSingleKanji_Add.Click

        Try
            usrPerformSpecialTest.blnTesting = False
            usrPerformSpecialTest.timerTotalAnswerTime.Stop()
            usrPerformSpecialTest.timerTotalAnswerTime.Dispose()
            usrPerformSpecialTest.timerAnswerTime.Stop()
            usrPerformSpecialTest.timerAnswerTime.Dispose()
        Catch ex As Exception

        End Try


        usrAddSingleKanji = New usrAddSingleKanji("", "", "", "", "", "")
        panContain.Controls.Clear()
        panContain.Controls.Add(usrAddSingleKanji)
        usrAddSingleKanji.Dock = DockStyle.Fill
    End Sub

    Private Sub mnuSingleKanji_Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSingleKanji_Search.Click

        Try
            usrPerformSpecialTest.blnTesting = False
            usrPerformSpecialTest.timerTotalAnswerTime.Stop()
            usrPerformSpecialTest.timerTotalAnswerTime.Dispose()
            usrPerformSpecialTest.timerAnswerTime.Stop()
            usrPerformSpecialTest.timerAnswerTime.Dispose()
        Catch ex As Exception

        End Try

        usrSearchSingleKanji = New usrSearchSingleKanji
        panContain.Controls.Clear()
        panContain.Controls.Add(usrSearchSingleKanji)
        usrSearchSingleKanji.Dock = DockStyle.Fill
    End Sub


    Private Sub mnuTopic_AddNewTopic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTopic_AddNewTopic.Click

        Try
            usrPerformSpecialTest.blnTesting = False
            usrPerformSpecialTest.timerTotalAnswerTime.Stop()
            usrPerformSpecialTest.timerTotalAnswerTime.Dispose()
            usrPerformSpecialTest.timerAnswerTime.Stop()
            usrPerformSpecialTest.timerAnswerTime.Dispose()
        Catch ex As Exception

        End Try

        'main menu
        usrTopic = New usrTopic()
        usrTopic.Dock = DockStyle.Fill
        panContain.Controls.Clear()
        panContain.Controls.Add(usrTopic)
    End Sub

    Private Sub performCreateTopicGroup(ByVal p_NoteSelect As TreeNode)

        usrAdd_New_Topic_Group = New usrAdd_New_Topic_Group()
        usrAdd_New_Topic_Group.Dock = DockStyle.Fill
        panContain.Controls.Clear()
        panContain.Controls.Add(usrAdd_New_Topic_Group)
    End Sub
    Private Sub performUpdateTopicGroup(ByVal p_NoteSelect As TreeNode)

        usrUpdate_Topic_Group = New usrUpdate_Topic_Group(p_NoteSelect.Text)
        usrUpdate_Topic_Group.Dock = DockStyle.Fill
        panContain.Controls.Clear()
        panContain.Controls.Add(usrUpdate_Topic_Group)
    End Sub

    Private Sub mnuCreateNewTopic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCreateNewTopic.Click

        Try
            usrPerformSpecialTest.blnTesting = False
            usrPerformSpecialTest.timerTotalAnswerTime.Stop()
            usrPerformSpecialTest.timerTotalAnswerTime.Dispose()
            usrPerformSpecialTest.timerAnswerTime.Stop()
            usrPerformSpecialTest.timerAnswerTime.Dispose()
        Catch ex As Exception

        End Try

        performCreateNewTopic()
    End Sub
    Private Sub performCreateNewTopic()

        usrTopic = New usrTopic(NoteSelect.Text)
        usrTopic.Dock = DockStyle.Fill
        panContain.Controls.Clear()
        panContain.Controls.Add(usrTopic)
    End Sub

    Private Sub performAddVocabularies(ByVal NoteSelect As TreeNode)

        If (Not NoteSelect Is Nothing) AndAlso (Not NoteSelect.Parent Is Nothing) Then
            'Voc.SetTextTopicGroupControl(NoteSelect.Parent.Text)
            'Voc.SetTextTopicControl(NoteSelect.Text)
            Voc = New usrVocabularies(NoteSelect.Parent.Text, NoteSelect.Text, Utils.ModeUpdate.Add)
        Else
            'Voc.SetTextTopicGroupControl(Constants_LanhVC.STR_GROUP_TEXT)
            'Voc.SetTextTopicControl(Constants_LanhVC.STR_TOPIC_TEXT)
            Voc = New usrVocabularies(Constants_LanhVC.STR_GROUP_TEXT, Constants_LanhVC.STR_TOPIC_TEXT, Utils.ModeUpdate.Add)
        End If
        Voc.Dock = DockStyle.Fill
        panContain.Controls.Clear()
        panContain.Controls.Add(Voc)
        Voc.SetStatusForButton(Constants_LanhVC.STR_SUBMIT, Constants_LanhVC.INT_ENABLE_FALSE)
        Voc.SetStatusForButton(Constants_LanhVC.STR_CANCEL, Constants_LanhVC.INT_ENABLE_FALSE)
        Voc.SetTextForButton(Constants_LanhVC.STR_SUBMIT, Constants_LanhVC.STR_SUBMIT_NEW)
        Voc.TypeVovabirary = Constants_LanhVC.STR_TYPE_NEW
        Voc.ClearDataGrid()
        Voc.DisplayButton()
    End Sub


    Private Sub mnuVocabularies_FastRegisterVoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try
            usrPerformSpecialTest.blnTesting = False
            usrPerformSpecialTest.timerTotalAnswerTime.Stop()
            usrPerformSpecialTest.timerTotalAnswerTime.Dispose()
            usrPerformSpecialTest.timerAnswerTime.Stop()
            usrPerformSpecialTest.timerAnswerTime.Dispose()
        Catch ex As Exception

        End Try

        usrFastRegVoc = New usrFastRegisterVocabularies()
        panContain.Controls.Clear()
        usrFastRegVoc.Dock = DockStyle.Fill
        panContain.Controls.Add(usrFastRegVoc)
        usrFastRegVoc.InitFocus()
    End Sub


    Private Sub mnuPerformASpecialTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPerformASpecialTest.Click

        Try
            usrPerformSpecialTest.blnTesting = False
            usrPerformSpecialTest.timerTotalAnswerTime.Stop()
            usrPerformSpecialTest.timerTotalAnswerTime.Dispose()
            usrPerformSpecialTest.timerAnswerTime.Stop()
            usrPerformSpecialTest.timerAnswerTime.Dispose()
        Catch ex As Exception

        End Try

        panContain.Controls.Clear()
        usrPerformSpecialTest = New usrPerformSpecialTest
        usrPerformSpecialTest.Dock = DockStyle.Fill
        Me.WindowState = FormWindowState.Maximized
        panContain.Controls.Add(usrPerformSpecialTest)
    End Sub


    Private Sub mnuPerformATest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPerformATest.Click

        Try
            usrPerformSpecialTest.blnTesting = False
            usrPerformSpecialTest.timerTotalAnswerTime.Stop()
            usrPerformSpecialTest.timerTotalAnswerTime.Dispose()
            usrPerformSpecialTest.timerAnswerTime.Stop()
            usrPerformSpecialTest.timerAnswerTime.Dispose()
        Catch ex As Exception

        End Try

        panContain.Controls.Clear()
        usrPerformTest = New usrPerformTest
        usrPerformTest.Dock = DockStyle.Fill
        Me.WindowState = FormWindowState.Maximized
        panContain.Controls.Add(usrPerformTest)
    End Sub


    'LongBT start
    Private Sub Form_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.ControlKey AndAlso e.KeyCode = Keys.F Then
            panContain.Controls.Clear()
            usrSearchVoc.Dock = DockStyle.Fill
            '   Me.WindowState = FormWindowState.Maximized
            panContain.Controls.Add(usrSearchVoc)
            panContain.Controls.Item(0).Focus()
        ElseIf e.KeyCode = Keys.ControlKey AndAlso e.KeyCode = Keys.T Then
            mnuPerformATest_Click(sender, e)
        ElseIf e.KeyCode = Keys.ControlKey AndAlso e.KeyCode = Keys.R Then
            mnuVocabularies_FastRegisterVoc_Click(sender, e)
        End If
    End Sub


    'LongBT end
    Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        Application.Exit()
    End Sub


    Private Sub mnuVocabularies_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuVocabularies_Add.Click

        Try
            usrPerformSpecialTest.blnTesting = False
            usrPerformSpecialTest.timerTotalAnswerTime.Stop()
            usrPerformSpecialTest.timerTotalAnswerTime.Dispose()
            usrPerformSpecialTest.timerAnswerTime.Stop()
            usrPerformSpecialTest.timerAnswerTime.Dispose()
        Catch ex As Exception

        End Try

        Dim noteSelect As New TreeNode()
        performAddVocabularies(noteSelect)
    End Sub

    
    'End Display Single Kanji
    Private Sub mnuMoveToTopic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMoveToTopic.Click

        Try
            usrPerformSpecialTest.blnTesting = False
            usrPerformSpecialTest.timerTotalAnswerTime.Stop()
            usrPerformSpecialTest.timerTotalAnswerTime.Dispose()
            usrPerformSpecialTest.timerAnswerTime.Stop()
            usrPerformSpecialTest.timerAnswerTime.Dispose()
        Catch ex As Exception

        End Try

        'If Voc Is Nothing Then
        mnuDisplayVocabulary_Click(sender, e)
        'End If
        Voc.SetCheckAllRecord()
        Voc.btnMoveAndCopy_Click(sender, e)
    End Sub


    Private Sub mnuDeleteThisTopic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDeleteThisTopic.Click

        Try
            usrPerformSpecialTest.blnTesting = False
            usrPerformSpecialTest.timerTotalAnswerTime.Stop()
            usrPerformSpecialTest.timerTotalAnswerTime.Dispose()
            usrPerformSpecialTest.timerAnswerTime.Stop()
            usrPerformSpecialTest.timerAnswerTime.Dispose()
        Catch ex As Exception

        End Try

        Try
            Dim result As DialogResult = MessageBox.Show(Constants_LanhVC.STR_MSG_RELOAD_SCREEN_CONFIRMATION, "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = Windows.Forms.DialogResult.OK Then
                usrTopic = New usrTopic()
                Me.usrTopic.delete(NoteSelect.Parent.Text, NoteSelect.Text)
                ReloadControls()
            End If

            'DeleteTopicNote(NoteSelect.Parent.Text, NoteSelect.Text)

            '          If Me.panContain.Controls.ContainsKey("usrTopic") Then
            'Me.panContain.Controls.RemoveByKey("usrTopic")
            'usrTopic = New usrTopic()
            'usrTopic.Dock = DockStyle.Fill
            'Me.panContain.Controls.Add(usrTopic)
            'End If
        Catch ex As Exception

        End Try
        
    End Sub

    Public Sub ReloadControls()
        Dim arrControl As New ArrayList

        Dim strType As String
        For Each usrControl As Control In Me.panContain.Controls
            strType = usrControl.GetType.Name
            Dim reloadedControl As Control = GetControl(strType)
            If Not reloadedControl Is Nothing Then
                arrControl.Add(reloadedControl)
            End If
            usrControl.Dispose()
        Next
        Me.panContain.Controls.Clear()
        For Each usrControl As Control In arrControl
            usrControl.Dock = DockStyle.Fill
            Me.panContain.Controls.Add(usrControl)
        Next
    End Sub

    Public Function GetControl(ByVal pControlType As String) As Control
        Dim retControl As New Control
        Select Case pControlType
            Case "usrAdd_New_Topic_Group"
                retControl = New usrAdd_New_Topic_Group()
            Case "usrAddSingleKanji"
                retControl = New usrAddSingleKanji("", "", "", "", "", "")
            Case "usrDelete_Topic_Group"
                retControl = New usrDelete_Topic_Group()
            Case "usrDeleteTopic_Vocabulary"
                retControl = Nothing 'New usrDeleteTopic_Vocabulary()
            Case "usrExport"
                retControl = New usrExport()
            Case "usrFastRegisterVocabularies"
                retControl = New usrFastRegisterVocabularies()
            Case "usrImport"
                retControl = New usrImport()
                'BINHNC1 Start
            Case "usrConvert"
                retControl = New usrConvert(Me)
                'BINHNC1 End
            Case "usrMoveAndCopy"
                retControl = Nothing 'New usrMoveAndCopy(Nothing, "", "")
            Case "usrPerformTest"
                retControl = New usrPerformTest()
            Case "usrSearchSingleKanji"
                retControl = New usrSearchSingleKanji()
            Case "usrSearchVocabularies"
                retControl = New usrSearchVocabularies()
            Case "usrTopic"
                retControl = New usrTopic()
            Case "usrUpdate_Topic_Group"
                retControl = New usrUpdate_Topic_Group()
            Case "usrVocabularies"
                Dim tempRetControl As usrVocabularies = New usrVocabularies(Constants_HaoLT.DEFAULT_TOPICGROUP_NAME, Constants_HaoLT.DEFAULT_TOPICNAME, Utils.ModeUpdate.Add)
                tempRetControl.SetStatusForButton(Constants_LanhVC.STR_SUBMIT, Constants_LanhVC.INT_ENABLE_FALSE)
                tempRetControl.SetStatusForButton(Constants_LanhVC.STR_CANCEL, Constants_LanhVC.INT_ENABLE_FALSE)
                tempRetControl.SetTextForButton(Constants_LanhVC.STR_SUBMIT, Constants_LanhVC.STR_SUBMIT_NEW)
                tempRetControl.TypeVovabirary = Constants_LanhVC.STR_TYPE_NEW
                tempRetControl.ClearDataGrid()
                tempRetControl.DisplayButton()
                retControl = tempRetControl
        End Select
        Return retControl
    End Function

    Private Sub aboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles aboutToolStripMenuItem.Click

        Try
            usrPerformSpecialTest.blnTesting = False
            usrPerformSpecialTest.timerTotalAnswerTime.Stop()
            usrPerformSpecialTest.timerTotalAnswerTime.Dispose()
            usrPerformSpecialTest.timerAnswerTime.Stop()
            usrPerformSpecialTest.timerAnswerTime.Dispose()
        Catch ex As Exception

        End Try

        Dim objAboutForm As New frmAbout
        objAboutForm.Show()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        Try
            usrPerformSpecialTest.blnTesting = False
            usrPerformSpecialTest.timerTotalAnswerTime.Stop()
            usrPerformSpecialTest.timerTotalAnswerTime.Dispose()
            usrPerformSpecialTest.timerAnswerTime.Stop()
            usrPerformSpecialTest.timerAnswerTime.Dispose()
        Catch ex As Exception

        End Try

        usrSearchVoc = New usrSearchVocabularies
        usrSearchVoc.Dock = DockStyle.Fill
        panContain.Controls.Clear()
        'Me.WindowState = FormWindowState.Maximized
        panContain.Controls.Add(usrSearchVoc)
    End Sub


    Private Sub SearchVocToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchVocToolStripButton.Click

        Try
            usrPerformSpecialTest.blnTesting = False
            usrPerformSpecialTest.timerTotalAnswerTime.Stop()
            usrPerformSpecialTest.timerTotalAnswerTime.Dispose()
            usrPerformSpecialTest.timerAnswerTime.Stop()
            usrPerformSpecialTest.timerAnswerTime.Dispose()
        Catch ex As Exception

        End Try

        btnSearch_Click(sender, e)
    End Sub

    Private Sub TestVocToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TestVocToolStripButton.Click

        Try
            usrPerformSpecialTest.blnTesting = False
            usrPerformSpecialTest.timerTotalAnswerTime.Stop()
            usrPerformSpecialTest.timerTotalAnswerTime.Dispose()
            usrPerformSpecialTest.timerAnswerTime.Stop()
            usrPerformSpecialTest.timerAnswerTime.Dispose()
        Catch ex As Exception

        End Try

        mnuPerformATest_Click(sender, e)
    End Sub

    Private Sub AddKanjiToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddKanjiToolStripButton.Click

        Try
            usrPerformSpecialTest.blnTesting = False
            usrPerformSpecialTest.timerTotalAnswerTime.Stop()
            usrPerformSpecialTest.timerTotalAnswerTime.Dispose()
            usrPerformSpecialTest.timerAnswerTime.Stop()
            usrPerformSpecialTest.timerAnswerTime.Dispose()
        Catch ex As Exception

        End Try

        mnuSingleKanji_Add_Click(sender, e)
    End Sub

    Private Sub SearchKanjiToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchKanjiToolStripButton.Click

        Try
            usrPerformSpecialTest.blnTesting = False
            usrPerformSpecialTest.timerTotalAnswerTime.Stop()
            usrPerformSpecialTest.timerTotalAnswerTime.Dispose()
            usrPerformSpecialTest.timerAnswerTime.Stop()
            usrPerformSpecialTest.timerAnswerTime.Dispose()
        Catch ex As Exception

        End Try

        mnuSingleKanji_Search_Click(sender, e)
    End Sub

    Private Sub ImportToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportToolStripButton.Click

        Try
            usrPerformSpecialTest.blnTesting = False
            usrPerformSpecialTest.timerTotalAnswerTime.Stop()
            usrPerformSpecialTest.timerTotalAnswerTime.Dispose()
            usrPerformSpecialTest.timerAnswerTime.Stop()
            usrPerformSpecialTest.timerAnswerTime.Dispose()
        Catch ex As Exception

        End Try

        mnuFile_Import_Click(sender, e)
    End Sub

    Private Sub ExportToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportToolStripButton.Click

        Try
            usrPerformSpecialTest.blnTesting = False
            usrPerformSpecialTest.timerTotalAnswerTime.Stop()
            usrPerformSpecialTest.timerTotalAnswerTime.Dispose()
            usrPerformSpecialTest.timerAnswerTime.Stop()
            usrPerformSpecialTest.timerAnswerTime.Dispose()
        Catch ex As Exception

        End Try

        mnuFile_Export_Click(sender, e)
    End Sub

    Private Sub UpdateATopicToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateATopicToolStripMenuItem.Click

        Try
            usrPerformSpecialTest.blnTesting = False
            usrPerformSpecialTest.timerTotalAnswerTime.Stop()
            usrPerformSpecialTest.timerTotalAnswerTime.Dispose()
            usrPerformSpecialTest.timerAnswerTime.Stop()
            usrPerformSpecialTest.timerAnswerTime.Dispose()
        Catch ex As Exception

        End Try

        'main menu
        usrTopic = New usrTopic()
        usrTopic.Dock = DockStyle.Fill
        panContain.Controls.Clear()
        panContain.Controls.Add(usrTopic)
    End Sub

    Private Sub DeleteATopicToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteATopicToolStripMenuItem.Click

        Try
            usrPerformSpecialTest.blnTesting = False
            usrPerformSpecialTest.timerTotalAnswerTime.Stop()
            usrPerformSpecialTest.timerTotalAnswerTime.Dispose()
            usrPerformSpecialTest.timerAnswerTime.Stop()
            usrPerformSpecialTest.timerAnswerTime.Dispose()
        Catch ex As Exception

        End Try

        'main menu
        usrTopic = New usrTopic()
        usrTopic.Dock = DockStyle.Fill
        panContain.Controls.Clear()
        panContain.Controls.Add(usrTopic)
    End Sub

    Private Sub mnuUpdateTopic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuUpdateTopic.Click

        Try
            usrPerformSpecialTest.blnTesting = False
            usrPerformSpecialTest.timerTotalAnswerTime.Stop()
            usrPerformSpecialTest.timerTotalAnswerTime.Dispose()
            usrPerformSpecialTest.timerAnswerTime.Stop()
            usrPerformSpecialTest.timerAnswerTime.Dispose()
        Catch ex As Exception

        End Try

        usrTopic = New usrTopic(NoteSelect.Parent.Text, NoteSelect.Text)
        usrTopic.Dock = DockStyle.Fill
        panContain.Controls.Clear()
        panContain.Controls.Add(usrTopic)
    End Sub

    Private Sub mnuContextDeleteTopicGroup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuContextDeleteTopicGroup.Click

        Try
            usrPerformSpecialTest.blnTesting = False
            usrPerformSpecialTest.timerTotalAnswerTime.Stop()
            usrPerformSpecialTest.timerTotalAnswerTime.Dispose()
            usrPerformSpecialTest.timerAnswerTime.Stop()
            usrPerformSpecialTest.timerAnswerTime.Dispose()
        Catch ex As Exception

        End Try

        Try
            Dim result As DialogResult = MessageBox.Show(Constants_LanhVC.STR_MSG_RELOAD_SCREEN_CONFIRMATION, "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = Windows.Forms.DialogResult.OK Then
                usrDelete_Topic_Group.DeleteTopicGroupFromTree(NoteSelect.Text) ' topic group name
                ReloadControls()
                treeTopic.Nodes.Remove(NoteSelect)
            End If

            'DeleteTopicNote(NoteSelect.Parent.Text, NoteSelect.Text)

            '          If Me.panContain.Controls.ContainsKey("usrTopic") Then
            'Me.panContain.Controls.RemoveByKey("usrTopic")
            'usrTopic = New usrTopic()
            'usrTopic.Dock = DockStyle.Fill
            'Me.panContain.Controls.Add(usrTopic)
            'End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub frmMainForm_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs)
        Application.Exit()
    End Sub

    Private Sub frmMainForm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show(Constants_LanhVC.STR_MSG_INFO_023, "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'If Process.GetProcessesByName("QuickRegister").Length <= 0 Then
        '    Process.Start("QuickRegister.exe")
        'End If
    End Sub

    Private Sub mnuChangeHotKey_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuChangeHotKey.Click
        Dim frmChangeHotkey As New frmChangeHotkey
        frmChangeHotkey.Show()
        'get current Quick Register process
        Dim currQuickRegisterProc As System.Diagnostics.Process() = System.Diagnostics.Process.GetProcessesByName("QuickRegister")
        If currQuickRegisterProc.Length > 0 Then
            For i As Integer = 0 To currQuickRegisterProc.Length - 1
                currQuickRegisterProc(i).Kill()
            Next
            'restart the Quick Register
            Process.Start("QuickRegister.exe")
        End If
    End Sub

    'BINHNC1 start
    Private Sub ConvertToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConvertToolStripButton.Click, ConvertGlossaryToStandardS3GTToolStripMenuItem.Click
        usrConvert = New usrConvert(Me)
        panContain.Controls.Clear()
        usrConvert.Dock = DockStyle.Fill
        panContain.Controls.Add(usrConvert)
    End Sub
    'BINHNC1 end

    'BINHNC1 start
    Private Sub mnuFile_Convert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFile_Export.Click
    End Sub
    'BINHNC1 end




    Public Sub treeTopic_ItemDrag(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemDragEventArgs) Handles treeTopic.ItemDrag

        'Set the drag node and initiate the DragDrop
        DoDragDrop(e.Item, DragDropEffects.Move)

    End Sub

    Public Sub treeTopic_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles treeTopic.DragEnter

        'See if there is a TreeNode being dragged
        If e.Data.GetDataPresent("System.Windows.Forms.TreeNode", True) Then
            'TreeNode found allow move effect
            e.Effect = DragDropEffects.Move
        Else
            'No TreeNode found, prevent move
            e.Effect = DragDropEffects.None
        End If

    End Sub

    Public Sub treeTopic_DragOver(ByVal sender As System.Object, ByVal e As DragEventArgs) Handles treeTopic.DragOver

        'Check that there is a TreeNode being dragged
        If e.Data.GetDataPresent("System.Windows.Forms.TreeNode", True) = False Then Exit Sub

        'Get the TreeView raising the event (incase multiple on form)
        Dim selectedTreeview As TreeView = CType(sender, TreeView)

        'As the mouse moves over nodes, provide feedback to the user
        'by highlighting the node that is the current drop target
        Dim pt As Point = CType(sender, TreeView).PointToClient(New Point(e.X, e.Y))
        Dim targetNode As TreeNode = selectedTreeview.GetNodeAt(pt)

        'See if the targetNode is currently selected, if so no need to validate again
        If Not (selectedTreeview Is targetNode) Then
            'Select the node currently under the cursor
            selectedTreeview.SelectedNode = targetNode

            'Check that the selected node is not the dropNode and also that it
            'is not a child of the dropNode and therefore an invalid target
            Dim dropNode As TreeNode = CType(e.Data.GetData("System.Windows.Forms.TreeNode"), TreeNode)
            Do Until targetNode Is Nothing
                If targetNode Is dropNode Then
                    e.Effect = DragDropEffects.None
                    Exit Sub
                End If
                targetNode = targetNode.Parent
            Loop
        End If

        'Currently selected node is a suitable target, allow the move
        e.Effect = DragDropEffects.Move

    End Sub

    Public Sub treeTopic_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles treeTopic.DragDrop

        'Check that there is a TreeNode being dragged
        If e.Data.GetDataPresent("System.Windows.Forms.TreeNode", True) = False Then Exit Sub

        'Get the TreeView raising the event (incase multiple on form)
        Dim selectedTreeview As TreeView = CType(sender, TreeView)

        'Get the TreeNode being dragged
        Dim dropNode As TreeNode = CType(e.Data.GetData("System.Windows.Forms.TreeNode"), TreeNode)
        If Not (dropNode.Level = 1) Then
            MessageBox.Show("Can only move/copy a topic")
            Exit Sub
        End If

        'The target node should be selected from the DragOver event
        Dim targetNode As TreeNode = selectedTreeview.SelectedNode
        If Not (targetNode.Level = 0) OrElse targetNode.Equals(dropNode.Parent) Then
            MessageBox.Show("Can only move/copy a topic from a topic group to another topic group")
            Exit Sub
        End If




        Dim strTopic, strSourceGroup, strTargetGroup As String
        strTopic = dropNode.Text
        strSourceGroup = dropNode.Parent.Text
        strTargetGroup = targetNode.Text

        Try
            If IsDefaultTopic(strTopic, dropNode.Parent.Text) Then
                MessageBox.Show(Constants_PhatLS.STR_MSG_ERR_021)
            ElseIf Not targetNode.Nodes(strTopic) Is Nothing Then
                MessageBox.Show(Constants_PhatLS.STR_MSG_ERR_002)
            Else
                Dim table As Data.DataTable
                Dim topicsBO As New TopicsBO
                Dim topicGroupsBO As New TopicGroupsBO

                table = topicsBO.GetTopicByTopicNameGroupName(strSourceGroup, strTopic)

                Dim topicentry As TopicsEntity = New TopicsEntity()
                topicentry.TopicID = table.Rows(0).Item(Constants_HaoLT.TOPIC_ID)
                topicentry.TopicName = table.Rows(0).Item(Constants_HaoLT.TOPIC_NAME)
                topicentry.TopicDescription = table.Rows(0).Item(Constants_HaoLT.TOPIC_DESCRIPTION)
                topicentry.TopicGroupName = strTargetGroup
                topicentry.TopicGroupID = topicGroupsBO.GetTopicGroupID(strTargetGroup)
                topicsBO.UpdateTopic(topicentry)

                'table.Rows.Item(table.Rows.IndexOf(Me.curr_row)).BeginEdit()
                'table.Rows.Item(table.Rows.IndexOf(Me.curr_row)).Item(Constants_HaoLT.TOPIC_NAME) = row.Item(Constants_HaoLT.TOPIC_NAME)
                'table.Rows.Item(table.Rows.IndexOf(Me.curr_row)).Item(Constants_HaoLT.TOPIC_DESCRIPTION) = row.Item(Constants_HaoLT.TOPIC_DESCRIPTION)
                'table.Rows.Item(table.Rows.IndexOf(Me.curr_row)).Item(Constants_HaoLT.TOPIC_GROUP_NAME) = row.Item(Constants_HaoLT.TOPIC_GROUP_NAME)
                'table.Rows.Item(table.Rows.IndexOf(Me.curr_row)).Item(Constants_HaoLT.TOPIC_GROUP_ID) = row.Item(Constants_HaoLT.TOPIC_GROUP_ID)
                'table.Rows.Item(table.Rows.IndexOf(Me.curr_row)).EndEdit()

                ''LanhVC - start
                ''frmMainForm.UpdateTopicToTree(cboTopicGroup.Text, strOldTopic, txtTopicName.Text)
                'Dim usrVoc As usrVocabularies = frmMainForm.panContain.Controls.Item(Constants_LanhVC.STR_USR_VOCABULARIES)
                'usrVoc.UpdateTopic(txtTopicName.Text)



                'Remove the drop node from its current location
                dropNode.Remove()

                'If there is no targetNode add dropNode to the bottom of the TreeView root
                'nodes, otherwise add it to the end of the dropNode child nodes
                If targetNode Is Nothing Then
                    selectedTreeview.Nodes.Add(dropNode)
                Else
                    targetNode.Nodes.Add(dropNode)
                End If

                'Ensure the newley created node is visible to the user and select it
                dropNode.EnsureVisible()
                selectedTreeview.SelectedNode = dropNode

            End If
        Catch ex As Exception
            'Do nothing
        End Try

    End Sub


    Public Function IsDefaultTopic(ByVal pGroupName As String, ByVal pTopicName As String) As Boolean
        Dim isDefault As Boolean = False
        If Constants_HaoLT.DEFAULT_TOPICGROUP_NAME = pGroupName AndAlso Constants_HaoLT.DEFAULT_TOPICNAME = pTopicName Then
            isDefault = True
        End If
        Return isDefault
    End Function

    Private Sub ConvertToJword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConvertJword.Click, ConvertGlossaryToJwordDataToolStripMenuItem.Click

        Try
            usrPerformSpecialTest.blnTesting = False
            usrPerformSpecialTest.timerTotalAnswerTime.Stop()
            usrPerformSpecialTest.timerTotalAnswerTime.Dispose()
            usrPerformSpecialTest.timerAnswerTime.Stop()
            usrPerformSpecialTest.timerAnswerTime.Dispose()
        Catch ex As Exception

        End Try

        panContain.Controls.Clear()
        Dim jwordForm As S3GT_2_JWORD.Form1 = New S3GT_2_JWORD.Form1
        jwordForm.ShowDialog()

    End Sub
End Class

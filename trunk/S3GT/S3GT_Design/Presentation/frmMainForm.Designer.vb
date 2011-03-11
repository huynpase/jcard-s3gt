<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainForm))
        Me.splitContainer1 = New System.Windows.Forms.SplitContainer
        Me.treeTopic = New System.Windows.Forms.TreeView
        Me.panContain = New System.Windows.Forms.Panel
        Me.contextTopicGroupMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuCreateTopicGroup = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuUpdateTopicGroup = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuCreateNewTopic = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuContextDeleteTopicGroup = New System.Windows.Forms.ToolStripMenuItem
        Me.statusStrip1 = New System.Windows.Forms.StatusStrip
        Me.fileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuFile_Export = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuFile_Import = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuChangeHotKey = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem
        Me.helpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.aboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip
        Me.mnuVocabularies = New System.Windows.Forms.ToolStripMenuItem
        Me.TopicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuTopicGroup_AddNew = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuTopicGroup_Update = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuTopicGroup_Delete = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuTopic = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuTopic_AddNewTopic = New System.Windows.Forms.ToolStripMenuItem
        Me.UpdateATopicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteATopicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuVocabularies_Add = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuPerformATest = New System.Windows.Forms.ToolStripMenuItem
        Me.btnSearch = New System.Windows.Forms.ToolStripMenuItem
        Me.SingleKanjiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuSingleKanji_Add = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuSingleKanji_Search = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConvertGlossaryToStandardS3GTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConvertGlossaryToJwordDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.SearchVocToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.TestVocToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.AddKanjiToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.SearchKanjiToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.ImportToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.ExportToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.ConvertToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.ConvertJword = New System.Windows.Forms.ToolStripButton
        Me.contextTopicMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuAddVocabularies = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuMoveToTopic = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuDeleteThisTopic = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuUpdateTopic = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuPerformASpecialTest = New System.Windows.Forms.ToolStripMenuItem
        Me.splitContainer1.Panel1.SuspendLayout()
        Me.splitContainer1.Panel2.SuspendLayout()
        Me.splitContainer1.SuspendLayout()
        Me.contextTopicGroupMenu.SuspendLayout()
        Me.menuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.contextTopicMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'splitContainer1
        '
        Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer1.Location = New System.Drawing.Point(0, 79)
        Me.splitContainer1.Name = "splitContainer1"
        '
        'splitContainer1.Panel1
        '
        Me.splitContainer1.Panel1.Controls.Add(Me.treeTopic)
        '
        'splitContainer1.Panel2
        '
        Me.splitContainer1.Panel2.Controls.Add(Me.panContain)
        Me.splitContainer1.Size = New System.Drawing.Size(900, 406)
        Me.splitContainer1.SplitterDistance = 172
        Me.splitContainer1.TabIndex = 5
        '
        'treeTopic
        '
        Me.treeTopic.AllowDrop = True
        Me.treeTopic.Dock = System.Windows.Forms.DockStyle.Fill
        Me.treeTopic.Location = New System.Drawing.Point(0, 0)
        Me.treeTopic.Name = "treeTopic"
        Me.treeTopic.Size = New System.Drawing.Size(172, 406)
        Me.treeTopic.TabIndex = 0
        '
        'panContain
        '
        Me.panContain.AutoScroll = True
        Me.panContain.BackgroundImage = CType(resources.GetObject("panContain.BackgroundImage"), System.Drawing.Image)
        Me.panContain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panContain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panContain.Location = New System.Drawing.Point(0, 0)
        Me.panContain.Name = "panContain"
        Me.panContain.Size = New System.Drawing.Size(724, 406)
        Me.panContain.TabIndex = 0
        '
        'contextTopicGroupMenu
        '
        Me.contextTopicGroupMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCreateTopicGroup, Me.mnuUpdateTopicGroup, Me.mnuCreateNewTopic, Me.mnuContextDeleteTopicGroup})
        Me.contextTopicGroupMenu.Name = "contextMenu"
        Me.contextTopicGroupMenu.Size = New System.Drawing.Size(211, 92)
        '
        'mnuCreateTopicGroup
        '
        Me.mnuCreateTopicGroup.Name = "mnuCreateTopicGroup"
        Me.mnuCreateTopicGroup.Size = New System.Drawing.Size(210, 22)
        Me.mnuCreateTopicGroup.Text = "&Create New Topic Group"
        '
        'mnuUpdateTopicGroup
        '
        Me.mnuUpdateTopicGroup.Name = "mnuUpdateTopicGroup"
        Me.mnuUpdateTopicGroup.Size = New System.Drawing.Size(210, 22)
        Me.mnuUpdateTopicGroup.Text = "&Update Topic Group"
        '
        'mnuCreateNewTopic
        '
        Me.mnuCreateNewTopic.Name = "mnuCreateNewTopic"
        Me.mnuCreateNewTopic.Size = New System.Drawing.Size(210, 22)
        Me.mnuCreateNewTopic.Text = "Create New &Topic"
        '
        'mnuContextDeleteTopicGroup
        '
        Me.mnuContextDeleteTopicGroup.Name = "mnuContextDeleteTopicGroup"
        Me.mnuContextDeleteTopicGroup.Size = New System.Drawing.Size(210, 22)
        Me.mnuContextDeleteTopicGroup.Text = "&Delete the Topic Group"
        '
        'statusStrip1
        '
        Me.statusStrip1.Location = New System.Drawing.Point(0, 485)
        Me.statusStrip1.Name = "statusStrip1"
        Me.statusStrip1.Size = New System.Drawing.Size(900, 22)
        Me.statusStrip1.TabIndex = 4
        Me.statusStrip1.Text = "statusStrip1"
        '
        'fileToolStripMenuItem
        '
        Me.fileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile_Export, Me.mnuFile_Import, Me.mnuChangeHotKey, Me.ToolStripSeparator2, Me.mnuExit})
        Me.fileToolStripMenuItem.Name = "fileToolStripMenuItem"
        Me.fileToolStripMenuItem.Size = New System.Drawing.Size(36, 20)
        Me.fileToolStripMenuItem.Text = "&File"
        '
        'mnuFile_Export
        '
        Me.mnuFile_Export.Name = "mnuFile_Export"
        Me.mnuFile_Export.Size = New System.Drawing.Size(203, 22)
        Me.mnuFile_Export.Text = "Export"
        '
        'mnuFile_Import
        '
        Me.mnuFile_Import.Name = "mnuFile_Import"
        Me.mnuFile_Import.Size = New System.Drawing.Size(203, 22)
        Me.mnuFile_Import.Text = "Import"
        '
        'mnuChangeHotKey
        '
        Me.mnuChangeHotKey.Name = "mnuChangeHotKey"
        Me.mnuChangeHotKey.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.K), System.Windows.Forms.Keys)
        Me.mnuChangeHotKey.Size = New System.Drawing.Size(203, 22)
        Me.mnuChangeHotKey.Text = "&Change Hot Key"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(200, 6)
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.mnuExit.Size = New System.Drawing.Size(203, 22)
        Me.mnuExit.Text = "Exit"
        '
        'helpToolStripMenuItem
        '
        Me.helpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.aboutToolStripMenuItem})
        Me.helpToolStripMenuItem.Name = "helpToolStripMenuItem"
        Me.helpToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.helpToolStripMenuItem.Text = "&Help"
        '
        'aboutToolStripMenuItem
        '
        Me.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem"
        Me.aboutToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.aboutToolStripMenuItem.Text = "&About"
        '
        'menuStrip1
        '
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fileToolStripMenuItem, Me.mnuVocabularies, Me.SingleKanjiToolStripMenuItem, Me.ToolToolStripMenuItem, Me.helpToolStripMenuItem})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(900, 24)
        Me.menuStrip1.TabIndex = 3
        Me.menuStrip1.Text = "menuStrip1"
        '
        'mnuVocabularies
        '
        Me.mnuVocabularies.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TopicToolStripMenuItem, Me.mnuTopic, Me.mnuVocabularies_Add, Me.mnuPerformATest, Me.mnuPerformASpecialTest, Me.btnSearch})
        Me.mnuVocabularies.Name = "mnuVocabularies"
        Me.mnuVocabularies.Size = New System.Drawing.Size(86, 20)
        Me.mnuVocabularies.Text = "Vocabularies"
        '
        'TopicToolStripMenuItem
        '
        Me.TopicToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTopicGroup_AddNew, Me.mnuTopicGroup_Update, Me.mnuTopicGroup_Delete})
        Me.TopicToolStripMenuItem.Name = "TopicToolStripMenuItem"
        Me.TopicToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.TopicToolStripMenuItem.Text = "&Topic Group"
        '
        'mnuTopicGroup_AddNew
        '
        Me.mnuTopicGroup_AddNew.Name = "mnuTopicGroup_AddNew"
        Me.mnuTopicGroup_AddNew.Size = New System.Drawing.Size(114, 22)
        Me.mnuTopicGroup_AddNew.Text = "&New"
        '
        'mnuTopicGroup_Update
        '
        Me.mnuTopicGroup_Update.Name = "mnuTopicGroup_Update"
        Me.mnuTopicGroup_Update.Size = New System.Drawing.Size(114, 22)
        Me.mnuTopicGroup_Update.Text = "&Update"
        '
        'mnuTopicGroup_Delete
        '
        Me.mnuTopicGroup_Delete.Name = "mnuTopicGroup_Delete"
        Me.mnuTopicGroup_Delete.Size = New System.Drawing.Size(114, 22)
        Me.mnuTopicGroup_Delete.Text = "&Delete"
        '
        'mnuTopic
        '
        Me.mnuTopic.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTopic_AddNewTopic, Me.UpdateATopicToolStripMenuItem, Me.DeleteATopicToolStripMenuItem})
        Me.mnuTopic.Name = "mnuTopic"
        Me.mnuTopic.Size = New System.Drawing.Size(197, 22)
        Me.mnuTopic.Text = "T&opic"
        '
        'mnuTopic_AddNewTopic
        '
        Me.mnuTopic_AddNewTopic.Name = "mnuTopic_AddNewTopic"
        Me.mnuTopic_AddNewTopic.Size = New System.Drawing.Size(159, 22)
        Me.mnuTopic_AddNewTopic.Text = "&Add New Topic"
        '
        'UpdateATopicToolStripMenuItem
        '
        Me.UpdateATopicToolStripMenuItem.Name = "UpdateATopicToolStripMenuItem"
        Me.UpdateATopicToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.UpdateATopicToolStripMenuItem.Text = "&Update a Topic"
        '
        'DeleteATopicToolStripMenuItem
        '
        Me.DeleteATopicToolStripMenuItem.Name = "DeleteATopicToolStripMenuItem"
        Me.DeleteATopicToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.DeleteATopicToolStripMenuItem.Text = "&Delete a Topic"
        '
        'mnuVocabularies_Add
        '
        Me.mnuVocabularies_Add.Name = "mnuVocabularies_Add"
        Me.mnuVocabularies_Add.Size = New System.Drawing.Size(197, 22)
        Me.mnuVocabularies_Add.Text = "&Add new Vocabularies"
        '
        'mnuPerformATest
        '
        Me.mnuPerformATest.Name = "mnuPerformATest"
        Me.mnuPerformATest.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.mnuPerformATest.Size = New System.Drawing.Size(197, 22)
        Me.mnuPerformATest.Text = "Perform a Test"
        '
        'btnSearch
        '
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.btnSearch.Size = New System.Drawing.Size(197, 22)
        Me.btnSearch.Text = "Search"
        '
        'SingleKanjiToolStripMenuItem
        '
        Me.SingleKanjiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSingleKanji_Add, Me.mnuSingleKanji_Search})
        Me.SingleKanjiToolStripMenuItem.Name = "SingleKanjiToolStripMenuItem"
        Me.SingleKanjiToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.SingleKanjiToolStripMenuItem.Text = "Single Kanji"
        '
        'mnuSingleKanji_Add
        '
        Me.mnuSingleKanji_Add.Name = "mnuSingleKanji_Add"
        Me.mnuSingleKanji_Add.Size = New System.Drawing.Size(155, 22)
        Me.mnuSingleKanji_Add.Text = "Create/Update"
        '
        'mnuSingleKanji_Search
        '
        Me.mnuSingleKanji_Search.Name = "mnuSingleKanji_Search"
        Me.mnuSingleKanji_Search.Size = New System.Drawing.Size(155, 22)
        Me.mnuSingleKanji_Search.Text = "Search"
        '
        'ToolToolStripMenuItem
        '
        Me.ToolToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConvertGlossaryToStandardS3GTToolStripMenuItem, Me.ConvertGlossaryToJwordDataToolStripMenuItem})
        Me.ToolToolStripMenuItem.Name = "ToolToolStripMenuItem"
        Me.ToolToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.ToolToolStripMenuItem.Text = "Tool"
        '
        'ConvertGlossaryToStandardS3GTToolStripMenuItem
        '
        Me.ConvertGlossaryToStandardS3GTToolStripMenuItem.Name = "ConvertGlossaryToStandardS3GTToolStripMenuItem"
        Me.ConvertGlossaryToStandardS3GTToolStripMenuItem.Size = New System.Drawing.Size(270, 22)
        Me.ConvertGlossaryToStandardS3GTToolStripMenuItem.Text = "Convert Glossary To Standard S3GT"
        '
        'ConvertGlossaryToJwordDataToolStripMenuItem
        '
        Me.ConvertGlossaryToJwordDataToolStripMenuItem.Name = "ConvertGlossaryToJwordDataToolStripMenuItem"
        Me.ConvertGlossaryToJwordDataToolStripMenuItem.Size = New System.Drawing.Size(270, 22)
        Me.ConvertGlossaryToJwordDataToolStripMenuItem.Text = "Convert Glossary To Jword Data"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripSeparator, Me.SearchVocToolStripButton, Me.TestVocToolStripButton, Me.toolStripSeparator1, Me.AddKanjiToolStripButton, Me.SearchKanjiToolStripButton, Me.ToolStripSeparator3, Me.ImportToolStripButton, Me.ExportToolStripButton, Me.ConvertToolStripButton, Me.ConvertJword})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(900, 55)
        Me.ToolStrip1.TabIndex = 8
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 55)
        '
        'SearchVocToolStripButton
        '
        Me.SearchVocToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SearchVocToolStripButton.Image = CType(resources.GetObject("SearchVocToolStripButton.Image"), System.Drawing.Image)
        Me.SearchVocToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SearchVocToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SearchVocToolStripButton.Name = "SearchVocToolStripButton"
        Me.SearchVocToolStripButton.Size = New System.Drawing.Size(52, 52)
        Me.SearchVocToolStripButton.Text = "Search Vocabularies"
        '
        'TestVocToolStripButton
        '
        Me.TestVocToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TestVocToolStripButton.Image = CType(resources.GetObject("TestVocToolStripButton.Image"), System.Drawing.Image)
        Me.TestVocToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TestVocToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TestVocToolStripButton.Name = "TestVocToolStripButton"
        Me.TestVocToolStripButton.Size = New System.Drawing.Size(52, 52)
        Me.TestVocToolStripButton.Text = "Perform a Vocabulary Test"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 55)
        '
        'AddKanjiToolStripButton
        '
        Me.AddKanjiToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AddKanjiToolStripButton.Image = CType(resources.GetObject("AddKanjiToolStripButton.Image"), System.Drawing.Image)
        Me.AddKanjiToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AddKanjiToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddKanjiToolStripButton.Name = "AddKanjiToolStripButton"
        Me.AddKanjiToolStripButton.Size = New System.Drawing.Size(52, 52)
        Me.AddKanjiToolStripButton.Text = "View All Kanjis"
        '
        'SearchKanjiToolStripButton
        '
        Me.SearchKanjiToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SearchKanjiToolStripButton.Image = CType(resources.GetObject("SearchKanjiToolStripButton.Image"), System.Drawing.Image)
        Me.SearchKanjiToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SearchKanjiToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SearchKanjiToolStripButton.Name = "SearchKanjiToolStripButton"
        Me.SearchKanjiToolStripButton.Size = New System.Drawing.Size(52, 52)
        Me.SearchKanjiToolStripButton.Text = "Search single Kanji characters"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 55)
        '
        'ImportToolStripButton
        '
        Me.ImportToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ImportToolStripButton.Image = CType(resources.GetObject("ImportToolStripButton.Image"), System.Drawing.Image)
        Me.ImportToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ImportToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ImportToolStripButton.Name = "ImportToolStripButton"
        Me.ImportToolStripButton.Size = New System.Drawing.Size(52, 52)
        Me.ImportToolStripButton.Text = "Import Data from files"
        '
        'ExportToolStripButton
        '
        Me.ExportToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ExportToolStripButton.Image = CType(resources.GetObject("ExportToolStripButton.Image"), System.Drawing.Image)
        Me.ExportToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ExportToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExportToolStripButton.Name = "ExportToolStripButton"
        Me.ExportToolStripButton.Size = New System.Drawing.Size(52, 52)
        Me.ExportToolStripButton.Text = "Export Data from files"
        '
        'ConvertToolStripButton
        '
        Me.ConvertToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ConvertToolStripButton.Image = CType(resources.GetObject("ConvertToolStripButton.Image"), System.Drawing.Image)
        Me.ConvertToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ConvertToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ConvertToolStripButton.Name = "ConvertToolStripButton"
        Me.ConvertToolStripButton.Size = New System.Drawing.Size(52, 52)
        Me.ConvertToolStripButton.Text = "Convert Glossary To Standard S3GT"
        Me.ConvertToolStripButton.ToolTipText = "Convert Glossary To Standard S3GT"
        '
        'ConvertJword
        '
        Me.ConvertJword.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ConvertJword.Image = CType(resources.GetObject("ConvertJword.Image"), System.Drawing.Image)
        Me.ConvertJword.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ConvertJword.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ConvertJword.Name = "ConvertJword"
        Me.ConvertJword.Size = New System.Drawing.Size(52, 52)
        Me.ConvertJword.Text = "Convert Glossary To Jword Data"
        Me.ConvertJword.ToolTipText = "Convert Glossary To Jword Data"
        '
        'contextTopicMenu
        '
        Me.contextTopicMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAddVocabularies, Me.mnuMoveToTopic, Me.mnuDeleteThisTopic, Me.mnuUpdateTopic})
        Me.contextTopicMenu.Name = "contextTopicMenu"
        Me.contextTopicMenu.Size = New System.Drawing.Size(311, 92)
        '
        'mnuAddVocabularies
        '
        Me.mnuAddVocabularies.Name = "mnuAddVocabularies"
        Me.mnuAddVocabularies.Size = New System.Drawing.Size(310, 22)
        Me.mnuAddVocabularies.Text = "&Add Vocabularies"
        '
        'mnuMoveToTopic
        '
        Me.mnuMoveToTopic.Name = "mnuMoveToTopic"
        Me.mnuMoveToTopic.Size = New System.Drawing.Size(310, 22)
        Me.mnuMoveToTopic.Text = "&Move Topic's Vocabulaires to another topic"
        '
        'mnuDeleteThisTopic
        '
        Me.mnuDeleteThisTopic.Name = "mnuDeleteThisTopic"
        Me.mnuDeleteThisTopic.Size = New System.Drawing.Size(310, 22)
        Me.mnuDeleteThisTopic.Text = "&Delete this topic"
        '
        'mnuUpdateTopic
        '
        Me.mnuUpdateTopic.Name = "mnuUpdateTopic"
        Me.mnuUpdateTopic.Size = New System.Drawing.Size(310, 22)
        Me.mnuUpdateTopic.Text = "&Update the Topic's information"
        '
        'mnuPerformASpecialTest
        '
        Me.mnuPerformASpecialTest.Name = "mnuPerformASpecialTest"
        Me.mnuPerformASpecialTest.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuPerformASpecialTest.Size = New System.Drawing.Size(237, 22)
        Me.mnuPerformASpecialTest.Text = "Perform a Special Test"
        '
        'frmMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(900, 507)
        Me.Controls.Add(Me.splitContainer1)
        Me.Controls.Add(Me.statusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.menuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmMainForm"
        Me.Text = "Special 3 kyu glossaries tool - S3GT"
        Me.splitContainer1.Panel1.ResumeLayout(False)
        Me.splitContainer1.Panel2.ResumeLayout(False)
        Me.splitContainer1.ResumeLayout(False)
        Me.contextTopicGroupMenu.ResumeLayout(False)
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.contextTopicMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents splitContainer1 As System.Windows.Forms.SplitContainer
    Private WithEvents treeTopic As System.Windows.Forms.TreeView
    Private WithEvents mnuCreateTopicGroup As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents statusStrip1 As System.Windows.Forms.StatusStrip
    Private WithEvents contextTopicGroupMenu As System.Windows.Forms.ContextMenuStrip
    Private WithEvents fileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents helpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents aboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents menuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents panContain As System.Windows.Forms.Panel
    Friend WithEvents mnuFile_Import As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFile_Export As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SearchVocToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents TestVocToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddKanjiToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuUpdateTopicGroup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCreateNewTopic As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents contextTopicMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuAddVocabularies As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMoveToTopic As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuVocabularies As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnSearch As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SingleKanjiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSingleKanji_Add As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSingleKanji_Search As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TopicToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTopicGroup_AddNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTopicGroup_Update As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTopicGroup_Delete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTopic As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTopic_AddNewTopic As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuVocabularies_Add As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateATopicToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchKanjiToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuDeleteThisTopic As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteATopicToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPerformATest As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ImportToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ExportToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuUpdateTopic As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuContextDeleteTopicGroup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuChangeHotKey As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConvertToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ConvertJword As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConvertGlossaryToStandardS3GTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConvertGlossaryToJwordDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPerformASpecialTest As System.Windows.Forms.ToolStripMenuItem

End Class

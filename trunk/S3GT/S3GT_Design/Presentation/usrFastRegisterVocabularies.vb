Imports System.IO

Public Class usrFastRegisterVocabularies
    Const STR_HIRAGANA_KATAKANA = "Hiragana/Katakana"
    Const STR_KANJI = "Kanji"
    Const STR_HIRAGANA_EMPTY = "Blank Hiragana/Katakana"
    Const STR_FILTER_BY_TOPIC_GROUP_ID = "Topic_Group_ID = {0}"
    Const INT_DEFAULT_TOPIC_GROUP_ID = 0
    Dim objTopicGroupTable As DataTable
    Dim objTopicTable As DataTable
    Dim objTopicGroupBO As TopicGroupsBO
    Dim objTopicBO As TopicsBO
    Dim write As Boolean = False
    ''PhongNT
    Dim objKanTable As DataTable
    Dim objKanBO As SingleKanjiBO
    ''QuanTDA added - Date: 31 Aug 2009
    Dim objParamBO As ParameterBO
    Dim intTopicGroupID As Integer
    Dim intTopicID As Integer


    Private Sub lnkCreateTopic_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkCreateTopic.LinkClicked
        Dim dlgCreateTopic As New dlgCreateTopic(cboTopic.Text)
        dlgCreateTopic.ShowDialog()
        'reload Topic Groups and Topics list
        LoadTopicsDataToCombo()
        'display the newest Topic and Topic Group
        'retrieve the Topic Group ID of the newest Topic in table
        Dim intTopicGroupID As Integer
        intTopicGroupID = CInt(objTopicTable.Rows(objTopicTable.Rows.Count - 1)(Constants_LanhVC.STR_TPC_COLUMN_NAME_TOPIC_GROUP_ID).ToString)
        cboTopicGroup.SelectedValue = intTopicGroupID
        'retrieve the newest Topic's ID
        Dim intTopicID As Integer = CInt(objTopicTable.Rows(objTopicTable.Rows.Count - 1)(Constants_LanhVC.STR_TPC_COLUMN_NAME_TOPIC_ID).ToString)
        cboTopic.SelectedValue = intTopicID
    End Sub


    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        usrFastRegisterVocabularies_initialize()
    End Sub

    Public Sub New(ByVal strVoc As String)
        Me.New()
        txtVocabulary.Text = strVoc
    End Sub

    Private Sub usrFastRegisterVocabularies_initialize()
        'Get list of all existing Topic Groups
        objTopicGroupBO = New TopicGroupsBO()
        objTopicGroupTable = objTopicGroupBO.GetTopicGroupsTable()

        'get list of all existing Topics
        objTopicBO = New TopicsBO
        objTopicTable = objTopicBO.GetTopicsTable()

        'binding Topic Groups Table with Topic Group combobox
        cboTopicGroup.DataSource = objTopicGroupTable
        cboTopicGroup.ValueMember = Constants_LanhVC.STR_TPG_COLUMN_NAME_TOPIC_GROUP_ID
        cboTopicGroup.DisplayMember = Constants_LanhVC.STR_TPG_COLUMN_NAME_TOPIC_GROUP_NAME


        'binding Topic Groups Table with Topic Group combobox
        cboTopic.DataSource = objTopicTable
        cboTopic.ValueMember = Constants_LanhVC.STR_TPC_COLUMN_NAME_TOPIC_ID
        cboTopic.DisplayMember = Constants_LanhVC.STR_TPC_COLUMN_NAME_TOPIC_NAME

        'Parameter
        objParamBO = New ParameterBO()
        'get last chosen Topic Group and Topic

        'Topic Group
        Try
            Dim objTopicGroupParam As ParameterEntity = objParamBO.GetParameterByName(Constants_LanhVC.STR_PARAM_LAST_CHOSEN_TOPIC_GROUP_ID)
            intTopicGroupID = Integer.Parse(objTopicGroupParam.ParameterValue)
        Catch ex As Exception
            intTopicGroupID = Constants_LanhVC.INT_DEFAULT_LAST_CHOSEN_TOPIC_GROUP_ID
        End Try
        cboTopicGroup.SelectedValue = intTopicGroupID

        'Topic
        Try
            Dim objTopicParam As ParameterEntity = objParamBO.GetParameterByName(Constants_LanhVC.STR_PARAM_LAST_CHOSEN_TOPIC_ID)
            intTopicID = Integer.Parse(objTopicParam.ParameterValue)
        Catch ex As Exception
            intTopicID = Constants_LanhVC.INT_DEFAULT_LAST_CHOSEN_TOPIC_ID
        End Try
        cboTopic.SelectedValue = intTopicID

        '<<<QuanTDA:The following code won't be used anymore>>>
        '<<<The default topic and Topic Group will be loaded from the Parameters table>>>
        '<<<Creation date: Aug 31th 2009>>
        ''binding Topic Table with Topic Group combobox
        'write = False
        'cboTopic.DataSource = objTopicTable
        'cboTopic.ValueMember = Constants_LanhVC.STR_TPC_COLUMN_NAME_TOPIC_ID
        'cboTopic.DisplayMember = Constants_LanhVC.STR_TPC_COLUMN_NAME_TOPIC_NAME
        ''cboTopicGroup.SelectedIndex = Constants_LanhVC.INT_DEFAULT_TOPIC_INDEX


        ''binding Topic Groups Table with Topic Group combobox
        'cboTopicGroup.DataSource = objTopicGroupTable
        'cboTopicGroup.ValueMember = Constants_LanhVC.STR_TPG_COLUMN_NAME_TOPIC_GROUP_ID
        'cboTopicGroup.DisplayMember = Constants_LanhVC.STR_TPG_COLUMN_NAME_TOPIC_GROUP_NAME
        'cboTopicGroup.SelectedIndex = Constants_LanhVC.INT_DEFAULT_TOPIC_GROUP_INDEX
        'write = True
        'Dim AppPath As String = System.Reflection.Assembly.GetExecutingAssembly.Location
        'If File.Exists(AppPath & "lastchoice.txt") Then
        'Dim inFile As StreamReader = New StreamReader(AppPath & "lastchoice.txt")
        'Dim selectedIndex As Integer = Integer.Parse(inFile.ReadLine())
        'inFile.Close()
        'If selectedIndex < cboTopicGroup.Items.Count Then
        'cboTopicGroup.SelectedIndex = selectedIndex
        'End If
        'End If
        '<<<End QuanTDA:The following code won't be used anymore>>>

        '<<<QuanTDA:The following code get default Topic Group and Topic>>>
        '<<<The default topic and Topic Group will be loaded from the Parameters table>>>
        '<<<Creation date: Aug 31th 2009>>

        'set default value for other controls
        txtVocabulary.Text = Constants_LanhVC.STR_BLANK_VALUE
        txtOtherWritingForm.Text = Constants_LanhVC.STR_BLANK_VALUE
        txtHannom.Text = Constants_LanhVC.STR_BLANK_VALUE
        txtMeaning.Text = Constants_LanhVC.STR_BLANK_VALUE
        'add values to Type combobox
        cboType.Items.Clear()
        cboType.Items.Add(Constants_LanhVC.STR_VOC_TYPE_NOUN)
        cboType.Items.Add(Constants_LanhVC.STR_VOC_TYPE_PRO)
        cboType.Items.Add(Constants_LanhVC.STR_VOC_TYPE_I)
        cboType.Items.Add(Constants_LanhVC.STR_VOC_TYPE_NA)
        cboType.Items.Add(Constants_LanhVC.STR_VOC_TYPE_VI)
        cboType.Items.Add(Constants_LanhVC.STR_VOC_TYPE_VT)
        cboType.Items.Add(Constants_LanhVC.STR_VOC_TYPE_PREP)
        cboType.SelectedIndex = 0
        txtExample.Text = Constants_LanhVC.STR_BLANK_VALUE

        '<<<QuanTDA:Create the following code paragraph due to the request from TrieuTDH - Project Sponsor at July 28th 2009:>>>
        '<<<Creation date: Aug 18th 2009>>
        '<<<focus on Submit button.>>>
        cmdSubmit.Focus()
        '<<<QuanTDA:end creating code>>>
    End Sub


    Private Sub cmdSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSubmit.Click
        Dim vocBO As VocabulariesBO
        Dim vocTable As DataTable
        Dim vocabularyEntity As VocabulariesEntity


        If write = True Then
            Dim AppPath As String = System.Reflection.Assembly.GetExecutingAssembly.Location
            Dim outFile As StreamWriter = New StreamWriter(AppPath & "lastchoice.txt")
            outFile.Write(cboTopicGroup.SelectedIndex)
            outFile.Close()
        End If
        'init
        vocBO = New VocabulariesBO
        vocTable = New DataTable
        'first copy input data to entity
        vocabularyEntity = CopyDataToEntity()

        'GiangNVT modified
        If ValidInputData(vocabularyEntity) Then
            'check if there are Vocabulary having same Hiragana.
            'vocTable = vocBO.GetVocabulariesTable
            Try
                vocTable = vocBO.CheckExist(vocabularyEntity.Hiragana, vocabularyEntity.Kanji, vocabularyEntity.TopicID)
            Catch checkExistEx As Exception
                MessageBox.Show(checkExistEx.Message, "Error while inserting new Vocabulary", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            'get rows of Vocabularies having the same Hiragana value as vocabularyEntity
            'if any, show Warning Vocabulary having same Hiragana.
            'vocTable.DefaultView.RowFilter = String.Format(Constants_LanhVC.STR_VOC_TABLE_FILTER_BY_HIRAGANA, vocabularyEntity.Hiragana)
            If vocTable.Rows.Count > Constants_LanhVC.INT_NO_RECORD Then 'there are some Vocabularies of the same Hiragana
                'display Warning Vocabulary have some coincidences.
                'Dim dlgSameVocabulary As New dlgSameVocabulary(vocabularyEntity, vocTable.DefaultView) 'vocTable.DefaultView
                Dim dlgSameVocabulary As New dlgSameVocabulary(vocabularyEntity, vocTable)
                'dlgSameVocabulary.SetTextForTextbox(Constants_LanhVC.STR_MSG_ERR_003)
                dlgSameVocabulary.ShowDialog()
            Else
                'if not, insert this Vocabulary
                Try
                    vocBO.AddNew(vocabularyEntity)
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error while inserting new Vocabulary", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try
            End If
            MessageBox.Show("New Vocabulary has been created")
            txtVocabulary.Text = Constants_LanhVC.STR_BLANK_VALUE
            txtOtherWritingForm.Text = Constants_LanhVC.STR_BLANK_VALUE
            txtHannom.Text = Constants_LanhVC.STR_BLANK_VALUE
            txtMeaning.Text = Constants_LanhVC.STR_BLANK_VALUE
            txtExample.Text = Constants_LanhVC.STR_BLANK_VALUE
            'usrFastRegisterVocabularies_initialize()
            'cmdCancel_Click(sender, e)
        End If
    End Sub

    Private Sub cmdReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReset.Click
        performReset()
    End Sub
    Public Sub performReset()
        'display the default topic group
        cboTopicGroup.SelectedIndex = Constants_LanhVC.INT_DEFAULT_TOPIC_GROUP_INDEX 'the first topic in this topic group will also displayed
        'reset all textbox
        txtVocabulary.Text = Constants_LanhVC.STR_BLANK_VALUE
        txtOtherWritingForm.Text = Constants_LanhVC.STR_BLANK_VALUE
        txtHannom.Text = Constants_LanhVC.STR_BLANK_VALUE
        txtMeaning.Text = Constants_LanhVC.STR_BLANK_VALUE
        cboType.SelectedIndex = 0
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Parent.Controls.Remove(Me)
        Me.Dispose()
    End Sub
    Private Function CopyDataToEntity() As VocabulariesEntity
        Dim vocabularyEntity As New VocabulariesEntity
        Dim currTopicView As DataRowView
        Dim objTopicID As Integer
        'get selected Topic ID
        currTopicView = CType(cboTopic.SelectedItem, DataRowView)
        objTopicID = CInt(currTopicView.Row(Constants_LanhVC.STR_TPC_COLUMN_NAME_TOPIC_ID))
        vocabularyEntity.TopicID = objTopicID ' selected Topic's ID

        'GiangNVT modified
        'binding Hiragana and Kanji
        'If lblVocabulary.Text = STR_KANJI Then
        '    vocabularyEntity.Hiragana = txtOtherWritingForm.Text
        '    vocabularyEntity.Kanji = txtVocabulary.Text
        'Else
        '    vocabularyEntity.Hiragana = txtVocabulary.Text
        '    vocabularyEntity.Kanji = txtOtherWritingForm.Text
        'End If
        vocabularyEntity.Kanji = txtVocabulary.Text
        vocabularyEntity.Hiragana = txtOtherWritingForm.Text

        vocabularyEntity.Hannom = txtHannom.Text ' Han Nom
        vocabularyEntity.Meaning = txtMeaning.Text 'Meaning
        vocabularyEntity.Type = Utils.GetType_IntFromText(cboType.SelectedValue) 'Number indicating Vocabulary type
        vocabularyEntity.Example = txtExample.Text ' Example
        Return vocabularyEntity
    End Function

    Private Sub cboTopicGroup_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTopicGroup.SelectedIndexChanged
        'filter existing Topics by Topic Group ID
        Dim currentTopicGroupView As DataRowView
        currentTopicGroupView = CType(cboTopicGroup.SelectedItem, DataRowView)

        Try
            intTopicGroupID = CInt(currentTopicGroupView.Row(Constants_LanhVC.STR_TPG_COLUMN_NAME_TOPIC_GROUP_ID))
            objTopicTable.DefaultView.RowFilter = String.Format(STR_FILTER_BY_TOPIC_GROUP_ID, intTopicGroupID)
        Catch ex As Exception

        End Try



        '<<<QuanTDA:Save Last Chosen Topic Group>>>
        '<<<The default topic and Topic Group will be stored>>>
        '<<<Creation date: Aug 31th 2009>>
        Try
            intTopicGroupID = Integer.Parse(cboTopicGroup.SelectedValue)
        Catch ex As Exception
            intTopicGroupID = Constants_LanhVC.INT_DEFAULT_LAST_CHOSEN_TOPIC_GROUP_ID
        End Try

        Try
            intTopicID = Integer.Parse(cboTopic.SelectedValue)
        Catch ex As Exception
            intTopicID = Constants_LanhVC.INT_DEFAULT_LAST_CHOSEN_TOPIC_ID
        End Try
        '<<<End QuanTDA:Save Last Chosen Topic Group>>>

        '<<<QuanTDA:The following code won't be used anymore>>>
        '<<<The default topic and Topic Group will be loaded from the Parameters table,>>>
        '<<<instead of using text data file>>
        '<<<Creation date: Aug 31th 2009>>
        '''''Programmer :minhltp 12/24/08 Lastchoice
        ''save last choose
        'If write = True Then
        'Dim AppPath As String = System.Reflection.Assembly.GetExecutingAssembly.Location
        'Dim outFile As StreamWriter = New StreamWriter(AppPath & "lastchoice.txt")
        'outFile.Write(cboTopicGroup.SelectedIndex)
        'outFile.Close()
        'End If
        '<<<End QuanTDA:The following code won't be used anymore>>>
    End Sub
    Private Sub LoadTopicsDataToCombo()
        'Get list of all existing Topic Groups
        objTopicGroupBO = New TopicGroupsBO()
        objTopicGroupTable = objTopicGroupBO.GetTopicGroupsTable()

        'get list of all existing Topics
        objTopicBO = New TopicsBO
        objTopicTable = objTopicBO.GetTopicsTable()

        'binding Topic Table with Topic Group combobox
        cboTopic.DataSource = objTopicTable
        cboTopic.ValueMember = Constants_LanhVC.STR_TPC_COLUMN_NAME_TOPIC_ID
        cboTopic.DisplayMember = Constants_LanhVC.STR_TPC_COLUMN_NAME_TOPIC_NAME
        'cboTopicGroup.SelectedIndex = Constants_LanhVC.INT_DEFAULT_TOPIC_INDEX

        'binding Topic Groups Table with Topic Group combobox
        cboTopicGroup.DataSource = objTopicGroupTable
        cboTopicGroup.ValueMember = Constants_LanhVC.STR_TPG_COLUMN_NAME_TOPIC_GROUP_ID
        cboTopicGroup.DisplayMember = Constants_LanhVC.STR_TPG_COLUMN_NAME_TOPIC_GROUP_NAME
        cboTopicGroup.SelectedIndex = Constants_LanhVC.INT_DEFAULT_TOPIC_GROUP_INDEX
    End Sub

    Private Function ValidInputData(ByVal pVocabularyEntity As VocabulariesEntity) As Boolean
        Dim strErrorMsgBuilder As System.Text.StringBuilder = New System.Text.StringBuilder
        Dim strErrorMsg As String = Constants_LanhVC.STR_BLANK_VALUE
        Dim isValid As Boolean = True

        'Check for Topic Group field
        If cboTopicGroup.SelectedItem Is Nothing Then
            strErrorMsgBuilder.Append("Topic Group must be selected")
            cmdSubmit.Focus()
            MessageBox.Show(strErrorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cboTopicGroup.Focus()
            Return False
            'strErrorMsgBuilder.AppendLine()
        End If

        'Check for Topic field
        If cboTopic.SelectedItem Is Nothing Then
            strErrorMsgBuilder.Append("Topic must be selected")
            cmdSubmit.Focus()
            MessageBox.Show(strErrorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cboTopic.Focus()
            Return False
        End If

        'Check for Kanji field
        If pVocabularyEntity.Kanji Is Nothing OrElse pVocabularyEntity.Kanji.Trim.Length = 0 Then
            strErrorMsgBuilder.Append("Kanji can't be blank")
            cmdSubmit.Focus()
            MessageBox.Show(strErrorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtVocabulary.Focus()
            Return False
        End If

        'Check for Hiragana field
        If pVocabularyEntity.Hiragana Is Nothing OrElse pVocabularyEntity.Hiragana.Trim.Length = 0 Then
            strErrorMsgBuilder.Append("Hiragana can't be blank")
            cmdSubmit.Focus()
            MessageBox.Show(strErrorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtOtherWritingForm.Focus()
            Return False
        End If

        'Check for Meaning field
        If pVocabularyEntity.Meaning Is Nothing OrElse pVocabularyEntity.Meaning.Trim.Length = 0 Then
            strErrorMsgBuilder.Append("Meaning can't be blank")
            cmdSubmit.Focus()
            MessageBox.Show(strErrorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtMeaning.Focus()
            Return False
        End If

        '<<<QuanTDA:replace the following code paragraph due to the request from TrieuTDH - Project Sponsor at July 28th 2009:>>>
        '<<<Creation date: Aug 17th 2009>>
        '<<<user can input Japanese characters in Meaning field.>>> 
        'If Not Constants_LanhVC.STR_BLANK_VALUE.Equals(pVocabularyEntity.Meaning) Then
        'If (Utils.IsStringKatakana(pVocabularyEntity.Meaning)) _
        '   Or (Utils.IsStringHiragana(pVocabularyEntity.Meaning)) _
        '   Or (Utils.isKanji(pVocabularyEntity.Meaning)) Then
        'strErrorMsgBuilder.Append("Meaning value of the Vocabulary must not be in Japanese characters")
        'strErrorMsgBuilder.AppendLine()
        'End If
        'End If
        '<<<QuanTDA:end replacing code.>>>

        '<<<QuanTDA:replace the following code paragraph due to the request from TrieuTDH - Project Sponsor at July 28th 2009:>>>
        '<<<Creation date: Aug 17th 2009>>
        '<<<no need to check blank value on Hiragana field.>>>
        'If Constants_LanhVC.STR_BLANK_VALUE.Equals(pVocabularyEntity.Hiragana) Then
        'strErrorMsgBuilder.Append("Value in Hiragana form of the Vocabulary must not be blank")
        'End If
        '<<<QuanTDA:end replacing code>>>

        strErrorMsg = strErrorMsgBuilder.ToString
        If strErrorMsg.Length > 0 Then
            cmdSubmit.Focus()
            MessageBox.Show(strErrorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            isValid = False
        End If
        Return isValid

    End Function

    Private Sub usrFastRegisterVocabularies_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        '<<<QuanTDA:Create the following code paragraph due to the request from TrieuTDH - Project Sponsor at July 28th 2009:>>>
        '<<<Creation date: Aug 18th 2009>>
        'When unload
        'Save chosen Topic Group and Topic into Parameters table
        Dim objChosenTopicGroup As New ParameterEntity
        objChosenTopicGroup.ParameterName = Constants_LanhVC.STR_PARAM_LAST_CHOSEN_TOPIC_GROUP_ID
        objChosenTopicGroup.ParameterValue = intTopicGroupID.ToString
        objParamBO.UpdateParameter(objChosenTopicGroup)

        'Topic
        Dim objChosenTopic As New ParameterEntity
        objChosenTopic.ParameterName = Constants_LanhVC.STR_PARAM_LAST_CHOSEN_TOPIC_ID
        objChosenTopic.ParameterValue = intTopicID.ToString
        objParamBO.UpdateParameter(objChosenTopic)
    End Sub

    Private Sub usrFastRegisterVocabularies_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtVocabulary.KeyUp, txtOtherWritingForm.KeyUp, txtMeaning.KeyUp, txtHannom.KeyUp
        '<<<QuanTDA:Create the following code paragraph due to the request from TrieuTDH - Project Sponsor at July 28th 2009:>>>
        '<<<Creation date: Aug 18th 2009>>
        '<<<When user press Enter key, submit the new vocabulary>>>
        If Keys.Enter.Equals(e.KeyCode) AndAlso e.Shift Then
            cmdSubmit_Click(sender, e)
        End If
        '<<<QuanTDA:end replacing code>>>
    End Sub

    Private Sub usrFastRegisterVocabularies_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''''Programmer :minhltp 12/24/08 Lastchoice
        'save last choose


    End Sub

    Private Sub txtVocabulary_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVocabulary.TextChanged

        'GiangNVT modified
        'Dim strSQL As String
        'Dim strHanNom As String = ""
        'Dim charArray() As Char = txtVocabulary.Text.ToCharArray
        'For i As Integer = 0 To charArray.Length - 1
        '    strSQL = Constants_PhatLS.STR_SQL_SINGLE_KANJI_Kanji + charArray(i) + """"
        '    Try
        '        objKanBO = New SingleKanjiBO()
        '        objKanTable = objKanBO.GetKanjiTable(strSQL)
        '        If Not (objKanTable.Rows.Count = 0) Then
        '            For j As Integer = 0 To objKanTable.Rows.Count - 1
        '                If i < 1 Then
        '                    strHanNom += objKanTable.Rows(j)(Constants_PhatLS.STR_HanNom)
        '                Else
        '                    strHanNom += " " + objKanTable.Rows(j)(Constants_PhatLS.STR_HanNom)
        '                End If
        '            Next
        '        End If
        '    Catch ex As Exception
        '        MessageBox.Show(ex.ToString(), Constants_LanhVC.STR_MSG_ERR_CODING, MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    End Try
        'Next

        txtHannom.Text = Utils.GetHanNom(txtVocabulary.Text)
        txtOtherWritingForm.Text = Utils.GetJPhonetic(txtVocabulary.Text)

        '<<<QuanTDA:Create the following code paragraph due to the request from TrieuTDH - Project Sponsor at July 28th 2009:>>>
        '<<<If no Kanji character exists in the input Vocabulary, then this Vocabulary introduce full-Hiragana/katakana word>>>
        '<<<Creation date: Aug 18th 2009>>
        'If Utils.Replace(txtVocabulary.Text).Trim.Length > 0 AndAlso Not Utils.isKanji(Utils.Replace(txtVocabulary.Text)) Then
        '    cboWritingForm.SelectedIndex = 1 'Hiragana mode
        'Else
        '    cboWritingForm.SelectedIndex = 0 'Kanji mode
        'End If
        '<<<End QuanTDA>>>
    End Sub

    Private Sub cboTopic_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTopic.SelectedIndexChanged
        '<<<QuanTDA:The following code save Topic>>>
        '<<<The default topic will be saved to the Parameters table>>>
        '<<<Creation date: Aug 31th 2009>>
        Try
            intTopicID = Integer.Parse(cboTopic.SelectedValue)
        Catch ex As Exception
            intTopicID = Constants_LanhVC.INT_DEFAULT_LAST_CHOSEN_TOPIC_ID
        End Try
        '<<<End QuanTDA:The following code save Topic Group and Topic>>>
    End Sub

    Public Sub InitFocus()
        txtMeaning.Focus()
    End Sub
End Class

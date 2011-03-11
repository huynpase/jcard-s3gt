Public Class usrUpdate_Topic_Group
    Dim tableTopicGroups As DataTable
    Dim objTopicGroupEntity As TopicGroupsEntity
    Dim objTopicGroupsBO As TopicGroupsBO
    Public Function Reset()
        tableTopicGroups = objTopicGroupsBO.GetTopicGroupsTable
        DataGridView_Add_TG.DataSource = tableTopicGroups
        DataGridView_Add_TG.Columns(0).Visible = False
        DataGridView_Add_TG.Visible() = True
        Return 0
    End Function
    Private Sub Button_Upd_Tpic_Gr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Upd_Tpic_Gr.Click
        Dim strThong_bao As String = Constants_LanhVC.STR_BLANK_VALUE
        Dim tempTable As DataTable = tableTopicGroups.Copy()
        tempTable.DefaultView.RowFilter = String.Format(Constants_LanhVC.STR_TPG_TABLE_FILTER_BY_TOPIC_GROUP_NAME, TextBox_Ad_NTpic_Gr.Text.Trim())

        If Constants_LanhVC.STR_BLANK_VALUE.Equals(TextBox_Ad_NTpic_Gr.Text) Then
            MessageBox.Show(Constants_LanhVC.STR_MSG_ERR_007, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Constants_HaoLT.DEFAULT_TOPICGROUP_ID = objTopicGroupEntity.TopicGroupID Then
            MessageBox.Show(Constants_PhatLS.STR_MSG_ERR_021, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf tempTable.DefaultView.Count > 0 AndAlso Not tempTable.DefaultView.Item(0)(Constants_LanhVC.STR_TPG_COLUMN_NAME_TOPIC_GROUP_ID).ToString.Equals(objTopicGroupEntity.TopicGroupID.ToString) Then
            MessageBox.Show(Constants_LanhVC.STR_MSG_ERR_008, "Warning")
        ElseIf (MessageBox.Show("Are your sure want to update data ?", "Message", MessageBoxButtons.OKCancel) = DialogResult.OK) Then
            'Dim dtBH As Bussiness_HuyenDTN
            objTopicGroupEntity.TopicGroupName = TextBox_Ad_NTpic_Gr.Text.Trim()
            objTopicGroupEntity.TopicGroupDescription = TextBox_Ad_DTp_Gr.Text.Trim()
            Try
                objTopicGroupsBO.UpdateTopicGroup(objTopicGroupEntity)
                strThong_bao = "Topic Group information was updated."
                MessageBox.Show(strThong_bao, "Message!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                frmMainForm.LoadDataToTree()
                Reset()
            Catch ex As Exception
                strThong_bao = "Error when updating Topic Group information."
                MessageBox.Show(strThong_bao, "Message!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub usrUpdate_Topic_Group_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tableTopicGroups = objTopicGroupsBO.GetTopicGroupsTable
        DataGridView_Add_TG.DataSource = tableTopicGroups
        DataGridView_Add_TG.Columns(0).Visible = False
        DataGridView_Add_TG.Visible() = True

        'QuanTDA's code
        'If a topic group name is passed in,
        'then retrieve the corresponding topic group and set it as defaultly selected topic group
        If Not objTopicGroupEntity Is Nothing AndAlso Not Constants_LanhVC.STR_BLANK_VALUE.Equals(objTopicGroupEntity.TopicGroupName) Then
            Dim selectedTopicGroupRows As DataRow()
            'because the Topic Group Name is unique in the table of Topic Groups
            'use the first row returned as the desired Topic Group
            Dim strFilter As String
            strFilter = String.Format(Constants_LanhVC.STR_TPG_TABLE_FILTER_BY_TOPIC_GROUP_NAME, objTopicGroupEntity.TopicGroupName)
            selectedTopicGroupRows = tableTopicGroups.Select(strFilter)
            If selectedTopicGroupRows.Length > 0 Then
                Dim rowTopicGroup As DataRow
                rowTopicGroup = selectedTopicGroupRows(0)
                objTopicGroupEntity.TopicGroupID = rowTopicGroup(Constants_LanhVC.STR_TPG_COLUMN_NAME_TOPIC_GROUP_ID)
                objTopicGroupEntity.TopicGroupName = rowTopicGroup(Constants_LanhVC.STR_TPG_COLUMN_NAME_TOPIC_GROUP_NAME)
                objTopicGroupEntity.TopicGroupDescription = rowTopicGroup(Constants_LanhVC.STR_TPG_COLUMN_NAME_TOPIC_GROUP_DESCRIPTION)
                'display selected Topic Group's name and description in Textboxes
                TextBox_Ad_NTpic_Gr.Text = objTopicGroupEntity.TopicGroupName
                TextBox_Ad_DTp_Gr.Text = objTopicGroupEntity.TopicGroupDescription
                'enable update button
                Button_Upd_Tpic_Gr.Enabled = True
            End If


        End If
    End Sub

    Private Sub Button_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Cancel.Click
        'TextBox_Ad_DTp_Gr.Text = ""
        'TextBox_Ad_NTpic_Gr.Text = ""
        'QuanTDA
        frmMainForm.panContain.Controls.Remove(Me)
        Me.Dispose()
        'QuanTDA
    End Sub

    Private Sub DataGridView_Add_TG_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView_Add_TG.CellClick
        If (e.RowIndex > -1 And e.RowIndex < DataGridView_Add_TG.Rows.Count - 1) Then
            TextBox_Ad_NTpic_Gr.Text = DataGridView_Add_TG.Item(1, e.RowIndex).Value.ToString
            TextBox_Ad_DTp_Gr.Text = DataGridView_Add_TG.Item(2, e.RowIndex).Value.ToString
            objTopicGroupEntity.TopicGroupID = DataGridView_Add_TG.Item(0, e.RowIndex).Value.ToString
        Else
            MessageBox.Show(" Please select Rows have data", "Message!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        objTopicGroupEntity.TopicGroupName = TextBox_Ad_NTpic_Gr.Text.Trim()
        objTopicGroupEntity.TopicGroupDescription = TextBox_Ad_DTp_Gr.Text.Trim()
    End Sub

    Public Sub New(ByVal pTopicGroupName As String)
        Dim tableTempTopicGroup As New DataTable
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        objTopicGroupsBO = New TopicGroupsBO
        objTopicGroupEntity = New TopicGroupsEntity()
        'set the topic group name passed in as default selected topic group
        If Not Constants_LanhVC.STR_BLANK_VALUE.Equals(pTopicGroupName) Then
            objTopicGroupEntity.TopicGroupName = pTopicGroupName
            tableTempTopicGroup = objTopicGroupsBO.CheckExist(pTopicGroupName)
            'because there are only a Topic Group for a name
            'objTopicGroupEntity.TopicGroupID = tableTempTopicGroup.Rows(0)(Constants_LanhVC.STR_TPC_COLUMN_NAME_TOPIC_GROUP_ID)
            'objTopicGroupEntity.TopicGroupDescription = tableTempTopicGroup.Rows(0)(Constants_LanhVC.STR_TPG_COLUMN_NAME_TOPIC_GROUP_DESCRIPTION)
        End If
    End Sub
    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        objTopicGroupsBO = New TopicGroupsBO
        objTopicGroupEntity = New TopicGroupsEntity
    End Sub
End Class

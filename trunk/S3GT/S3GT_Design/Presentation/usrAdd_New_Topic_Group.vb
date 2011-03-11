Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Windows.Forms
Public Class usrAdd_New_Topic_Group
    Dim temp As New Connection_HuyenDTN
    Dim objTopicGroupsBO As New TopicGroupsBO
    Dim objTopicGroupsEntity As New TopicGroupsEntity
    Dim strSQL As String
    Dim tableTopicGroups As DataTable
    Private Sub Button_Ad_NTpic_Gr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Ad_NTpic_Gr.Click
        Dim tempTable As DataTable = tableTopicGroups.Copy()

        'get input information from user
        tempTable.DefaultView.RowFilter = String.Format(Constants_LanhVC.STR_TPG_TABLE_FILTER_BY_TOPIC_GROUP_NAME, Utils.Replace(TextBox_Ad_NTpic_Gr.Text.Trim()))
        If Constants_LanhVC.STR_BLANK_VALUE.Equals(TextBox_Ad_NTpic_Gr.Text) Then
            MessageBox.Show(Constants_LanhVC.STR_MSG_ERR_007, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'ElseIf tempTable.DefaultView.Count > 0 AndAlso Not tempTable.DefaultView.Item(0)(Constants_LanhVC.STR_TPG_COLUMN_NAME_TOPIC_GROUP_ID).ToString.Equals(objTopicGroupsEntity.TopicGroupID.ToString) Then
        ElseIf tempTable.DefaultView.Count > 0 Then
            MessageBox.Show(Constants_LanhVC.STR_MSG_ERR_008, "Warning")
        Else
            Dim strThong_Bao As String = "Error when adding new Topic Group."
            Try
                objTopicGroupsEntity.TopicGroupName = TextBox_Ad_NTpic_Gr.Text
                objTopicGroupsEntity.TopicGroupDescription = TextBox_Ad_DTp_Gr.Text
                objTopicGroupsBO.AddNew(objTopicGroupsEntity)
                strThong_Bao = "A new Topic Group has been added."
                MessageBox.Show(strThong_Bao, "Message!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show(strThong_Bao, "Message!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Reset()
            frmMainForm.LoadDataToTree()
        End If
    End Sub
    Public Function Reset()
        tableTopicGroups = temp.getDataTable("Select * From S3GT_TPG")
        DataGridView_Add_TG.DataSource = tableTopicGroups
        DataGridView_Add_TG.Columns(0).Visible = False
        DataGridView_Add_TG.Visible() = True
        Return 0
    End Function
    Private Sub usrAdd_New_Topic_Group_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tableTopicGroups = objTopicGroupsBO.GetTopicGroupsTable
        DataGridView_Add_TG.DataSource = tableTopicGroups
        DataGridView_Add_TG.Columns(0).Visible = False
        DataGridView_Add_TG.Visible() = True
        Button_Ad_NTpic_Gr.Enabled = True
        Button_Update_Tpic_Gr.Enabled = False
        Button_Delete.Enabled = False
    End Sub
    Private Sub Button_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Cancel.Click
        'TextBox_Ad_NTpic_Gr.Text = Constants_LanhVC.STR_BLANK_VALUE
        'TextBox_Ad_DTp_Gr.Text = Constants_LanhVC.STR_BLANK_VALUE
        'QuanTDA code
        'usrAdd_New_Topic_Group_Load(sender, e)
        'exit this form
        frmMainForm.panContain.Controls.Remove(Me)
        Me.Dispose()
        'End QuanTDA code
    End Sub
    Private Sub Button_Update_Tpic_Gr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Update_Tpic_Gr.Click
        Dim tempTable As DataTable = tableTopicGroups.Copy()
        tempTable.DefaultView.RowFilter = String.Format(Constants_LanhVC.STR_TPG_TABLE_FILTER_BY_TOPIC_GROUP_NAME, _
        Utils.Replace(TextBox_Ad_NTpic_Gr.Text.Trim()))
        If Constants_LanhVC.STR_BLANK_VALUE.Equals(TextBox_Ad_NTpic_Gr.Text) Then
            MessageBox.Show(Constants_LanhVC.STR_MSG_ERR_007, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf objTopicGroupsEntity.TopicGroupID = Constants_HaoLT.DEFAULT_TOPICGROUP_ID Then
            MessageBox.Show(Constants_PhatLS.STR_MSG_ERR_021, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf tempTable.DefaultView.Count > 0 AndAlso Not tempTable.DefaultView.Item(0)(Constants_LanhVC.STR_TPG_COLUMN_NAME_TOPIC_GROUP_ID).ToString.Equals(objTopicGroupsEntity.TopicGroupID.ToString) Then
            MessageBox.Show(Constants_LanhVC.STR_MSG_ERR_008, "Warning")
        Else
            Dim strThong_bao As String = Constants_LanhVC.STR_BLANK_VALUE
            If (MessageBox.Show("Are your sure want to update data ?", "Message", MessageBoxButtons.OKCancel) = DialogResult.OK) Then
                objTopicGroupsEntity.TopicGroupName = TextBox_Ad_NTpic_Gr.Text
                objTopicGroupsEntity.TopicGroupDescription = TextBox_Ad_DTp_Gr.Text
                strThong_bao = "Error when updating Topic Group information."
                Try
                    objTopicGroupsBO.UpdateTopicGroup(objTopicGroupsEntity)
                    strThong_bao = "Topic Group information was updated."
                    frmMainForm.LoadDataToTree()
                    MessageBox.Show(strThong_bao, "Message!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show(strThong_bao, "Message!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            End If
            'object_data.Xoa(dtBH_temp)
            Reset()
            Button_Ad_NTpic_Gr.Enabled = True
            Button_Update_Tpic_Gr.Enabled = False
            Button_Delete.Enabled = False
        End If
    End Sub
    

    Private Sub DataGridView_Add_TG_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView_Add_TG.CellClick
        Button_Ad_NTpic_Gr.Enabled = False
        Button_Update_Tpic_Gr.Enabled = True
        Button_Delete.Enabled = True
        If e.ColumnIndex = 1 And e.RowIndex > -1 And e.RowIndex < DataGridView_Add_TG.Rows.Count - 1 Then
            TextBox_Ad_NTpic_Gr.Text = DataGridView_Add_TG.Item(e.ColumnIndex, e.RowIndex).Value.ToString
            TextBox_Ad_DTp_Gr.Text = DataGridView_Add_TG.Item(e.ColumnIndex + 1, e.RowIndex).Value.ToString
            objTopicGroupsEntity.TopicGroupID = DataGridView_Add_TG.Item(e.ColumnIndex - 1, e.RowIndex).Value.ToString
        Else
            If (e.ColumnIndex > 1 And e.RowIndex > -1 And e.RowIndex < DataGridView_Add_TG.Rows.Count - 1) Then
                TextBox_Ad_NTpic_Gr.Text = DataGridView_Add_TG.Item(e.ColumnIndex - 1, e.RowIndex).Value.ToString
                TextBox_Ad_DTp_Gr.Text = DataGridView_Add_TG.Item(e.ColumnIndex, e.RowIndex).Value.ToString
                objTopicGroupsEntity.TopicGroupID = DataGridView_Add_TG.Item(e.ColumnIndex - 2, e.RowIndex).Value.ToString
            Else
                MessageBox.Show(" Please select Rows have data", "Message!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If

        objTopicGroupsEntity.TopicGroupName = TextBox_Ad_NTpic_Gr.Text
        objTopicGroupsEntity.TopicGroupDescription = TextBox_Ad_DTp_Gr.Text
    End Sub

    Private Sub Button_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Delete.Click
        Dim strThong_bao As String = "You must select a Topic Group"
        If Constants_LanhVC.STR_BLANK_VALUE.Equals(objTopicGroupsEntity.TopicGroupName) Then
            MessageBox.Show(strThong_bao, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Constants_HaoLT.DEFAULT_TOPICGROUP_NAME.Equals(objTopicGroupsEntity.TopicGroupName) Then
            strThong_bao = Constants_PhatLS.STR_MSG_ERR_022
            MessageBox.Show(strThong_bao, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            strThong_bao = "Are you sure you want to delete Topic Group?"
            If (MessageBox.Show(strThong_bao, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                Try
                    objTopicGroupsBO.DeleteTopicGroup(objTopicGroupsEntity)
                    strThong_bao = "A Topic Group has been deleted."
                    MessageBox.Show(strThong_bao, "Message!")
                    Reset()
                    frmMainForm.LoadDataToTree()
                Catch ex As Exception
                    strThong_bao = Constants_LanhVC.STR_MSG_TOPIC_GROUP_HAS_CHILD
                    If (MessageBox.Show(strThong_bao, "Message!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                        Dim dlgDelTopic_Voc As New dlgDeleteTopic_Vocabulary(objTopicGroupsEntity.TopicGroupID, objTopicGroupsEntity.TopicGroupName)
                        dlgDelTopic_Voc.ShowDialog()
                        Reset()
                        If dlgDelTopic_Voc.HasDeletedSuccessfully Then
                            frmMainForm.LoadDataToTree()
                        End If
                    Else
                        'MessageBox.Show("Xu ly khong xoa")
                        Reset()
                    End If
                End Try
            End If
        End If
        Reset()
        Button_Ad_NTpic_Gr.Enabled = True
        Button_Update_Tpic_Gr.Enabled = False
        Button_Delete.Enabled = False

    End Sub

    'QuanTDA - move statement in old btnCancel_Click method to this method
    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        TextBox_Ad_NTpic_Gr.Text = Constants_LanhVC.STR_BLANK_VALUE
        TextBox_Ad_DTp_Gr.Text = Constants_LanhVC.STR_BLANK_VALUE
        'QuanTDA code
        usrAdd_New_Topic_Group_Load(sender, e)

    End Sub
    'End QuanTDA code
End Class
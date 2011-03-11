Public Class TopicGroupsBO


    ''' <summary>
    ''' Add new Topic Group into database
    ''' </summary>
    ''' <param name="objTopicGroupEntity">data of Topic Group</param>
    ''' <returns>new value of Topic Group</returns>
    ''' <remarks>Have ID of Topic Group</remarks>
    Public Function AddNew(ByVal objTopicGroupEntity As TopicGroupsEntity) As TopicGroupsEntity
        Dim objTopicGroupDAO As TopicGroupDAO

        'init
        objTopicGroupDAO = New TopicGroupDAO()
        objTopicGroupEntity = objTopicGroupDAO.AddNew(objTopicGroupEntity)

        Return objTopicGroupEntity
    End Function

    ''' <summary>
    ''' Get all rows in the Topic Groups Table.
    ''' Here the returned parameter is a Datatable to facilitating filtering on table rows
    ''' </summary>
    ''' <returns>Data table of Topic Groups</returns>
    ''' <remarks></remarks>
    Public Function GetTopicGroupsTable() As DataTable
        Dim TopicGroupTable As New DataTable
        Dim objTopicGroupDAO As TopicGroupDAO

        'init
        objTopicGroupDAO = New TopicGroupDAO()
        'TopicGroupTable.DefaultView.RowFilter = ""
        TopicGroupTable = objTopicGroupDAO.GetTopicGroupsTable()
        Return TopicGroupTable
    End Function



    ''' <summary>
    ''' Get Topic Group by TopicGroup ID
    ''' </summary>
    ''' <param name="p_intTopicGroupID">Content ID of Topic Group</param>
    ''' <returns>Topic Group Entity object</returns>
    ''' <remarks></remarks>
    Public Function GetTopicGroupByID(ByVal p_intTopicGroupID As Integer) As TopicGroupsEntity
        Dim objTopicGroupEntity As New TopicGroupsEntity
        Dim objTopicGroupDAO As TopicGroupDAO

        'init
        objTopicGroupDAO = New TopicGroupDAO()
        'TopicGroupTable.DefaultView.RowFilter = ""
        objTopicGroupEntity = objTopicGroupDAO.GetTopicGroupByID(p_intTopicGroupID)

        Return objTopicGroupEntity
    End Function

    ''' <summary>
    ''' Delete a Topic Group from database
    ''' </summary>
    ''' <param name="objTopicGroupEntity">Content ID of TopicGroup</param>
    ''' <remarks></remarks>
    Public Sub DeleteTopicGroup(ByVal objTopicGroupEntity As TopicGroupsEntity)
        Dim objTopicGroupDAO As TopicGroupDAO

        'init
        objTopicGroupDAO = New TopicGroupDAO()

        objTopicGroupDAO.DeleteTopicGroup(objTopicGroupEntity)
    End Sub

    Public Function CheckExist(ByVal strTopicGroupName As String) As DataTable
        Dim TopicGroupTable As New DataTable
        Dim objTopicGroupDAO As TopicGroupDAO

        'init
        objTopicGroupDAO = New TopicGroupDAO()

        TopicGroupTable = objTopicGroupDAO.CheckExist(strTopicGroupName)

        Return TopicGroupTable

    End Function

    Public Sub UpdateTopicGroup(ByVal objTopicGroupEntity As TopicGroupsEntity)
        Dim objTopicGroupDAO As TopicGroupDAO

        'init
        objTopicGroupDAO = New TopicGroupDAO()

        objTopicGroupDAO.UpdateTopicGroup(objTopicGroupEntity)
    End Sub

    Public Function CopyDataToEntityFromDataGrid(ByVal dataTopicGroup As DataGridView, ByVal intID As Int32)
        Dim objTopicGroupEntity As TopicGroupsEntity

        'init
        objTopicGroupEntity = New TopicGroupsEntity()
        'chua co copy Topic ID
        objTopicGroupEntity.TopicGroupID = _
                    dataTopicGroup.Rows(intID).Cells(Constants_LanhVC.STR_TPG_COLUMN_NAME_TOPIC_GROUP_ID).Value ' Topic Group ID column

        objTopicGroupEntity.TopicGroupName = dataTopicGroup.Rows(intID).Cells(Constants_LanhVC.STR_TPG_COLUMN_NAME_TOPIC_GROUP_NAME).Value
        objTopicGroupEntity.TopicGroupDescription = _
                    dataTopicGroup.Rows(intID).Cells(Constants_LanhVC.STR_TPG_COLUMN_NAME_TOPIC_GROUP_DESCRIPTION).Value

        Return objTopicGroupEntity
    End Function

    Public Function GetTopicGroupID(ByVal strTopicGroupName As String) As Integer
        Dim objTopicGroupDAO As TopicGroupDAO

        objTopicGroupDAO = New TopicGroupDAO()
        Return objTopicGroupDAO.GetTopicGroupID(strTopicGroupName)
    End Function
End Class

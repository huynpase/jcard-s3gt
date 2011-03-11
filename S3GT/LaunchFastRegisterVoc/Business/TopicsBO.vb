
Public Class TopicsBO


    ''' <summary>
    ''' Add new Topic into database
    ''' </summary>
    ''' <param name="objTopicEntity">data of Topic</param>
    ''' <returns>new value of Topic</returns>
    ''' <remarks>Have ID of Topic</remarks>
    Public Function AddNew(ByVal objTopicEntity As TopicsEntity) As TopicsEntity
        Dim objTopicDAO As TopicDAO

        'init
        objTopicDAO = New TopicDAO()
        objTopicEntity = objTopicDAO.AddNew(objTopicEntity)

        Return objTopicEntity
    End Function

    ''' <summary>
    ''' Get all rows in the Topics Table.
    ''' Here the returned parameter is a Datatable to facilitating filtering on table rows
    ''' </summary>
    ''' <returns>Data table of Topics</returns>
    ''' <remarks></remarks>
    Public Function GetTopicsTable() As DataTable
        Dim TopicTable As New DataTable
        Dim objTopicDAO As TopicDAO

        'init
        objTopicDAO = New TopicDAO()
        'TopicTable.DefaultView.RowFilter = ""
        TopicTable = objTopicDAO.GetTopicsTable()
        Return TopicTable
    End Function
    Public Function GetCob_TopicGroup() As DataTable
        Dim TopicTable As New DataTable
        Dim objTopicDAO As TopicDAO

        'init
        objTopicDAO = New TopicDAO()
        'TopicTable.DefaultView.RowFilter = ""
        TopicTable = objTopicDAO.GetTopicGroup
        Return TopicTable
    End Function
    Function is_BLANK(ByVal text As String) As Boolean
        Dim flag As Boolean = True
        If (text = Constants_HaoLT.NULLSTRING) Then Return True
        For Each Item As Char In text

            If Item.ToString = Constants_HaoLT.BLANK Then
            Else
                flag = False
                Exit For
            End If
        Next
        Return flag
    End Function
    Function is_DuplicateTopic(ByVal table As Data.DataTable, ByVal row As Data.DataRow) As Boolean
        Dim flag As Boolean = False
        If (table Is Nothing) Then Return False
        For Each item As Data.DataRow In table.Rows
            If item.Item(Constants_HaoLT.TOPIC_NAME) = row.Item(Constants_HaoLT.TOPIC_NAME) And item.Item(Constants_HaoLT.TOPIC_GROUP_NAME) = row.Item(Constants_HaoLT.TOPIC_GROUP_NAME) Then
                Return True
            End If
        Next
        Return flag
    End Function


    ''' <summary>
    ''' Get Table Topic by Topic Group
    ''' </summary>
    ''' <param name="p_intTopicGroupID">Content ID of Topc</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetTopicTableByTopicGroup(ByVal p_intTopicGroupID As Integer) As DataTable
        Dim topicTable As New DataTable
        Dim objTopicDAO As TopicDAO

        'init
        objTopicDAO = New TopicDAO()
        'vocTable.DefaultView.RowFilter = ""
        topicTable = objTopicDAO.GetTopicTableByTopicGroup(p_intTopicGroupID)
        Return topicTable

    End Function

    ''' <summary>
    ''' Get Topic by Topic ID
    ''' </summary>
    ''' <param name="p_intTopicID">Content ID of Topic</param>
    ''' <returns>Topic Entity object</returns>
    ''' <remarks></remarks>
    Public Function GetTopicByID(ByVal p_intTopicID As Integer) As TopicsEntity
        Dim objTopicEntity As New TopicsEntity
        Dim objTopicDAO As TopicDAO

        'init
        objTopicDAO = New TopicDAO()
        'TopicTable.DefaultView.RowFilter = ""
        objTopicEntity = objTopicDAO.GetTopicByID(p_intTopicID)

        Return objTopicEntity
    End Function
    Public Function GetTopicByName(ByVal topicname As String, ByVal topicgroup As String) As TopicsEntity
        Dim objTopicEntity As New TopicsEntity
        Dim objTopicDAO As TopicDAO

        'init
        objTopicDAO = New TopicDAO()
        'TopicTable.DefaultView.RowFilter = ""
        objTopicEntity = objTopicDAO.GetTopicByName(topicname, topicgroup)

        Return objTopicEntity
    End Function


    ''' <summary>
    ''' Delete Topic by ID
    ''' </summary>
    ''' <param name="objTopicEntity">Content ID of Topic</param>
    ''' <remarks></remarks>
    Public Sub DeleteTopicVOC(ByVal objTopicEntity As TopicsEntity)
        Dim objTopicDAO As TopicDAO

        'init
        objTopicDAO = New TopicDAO()

        objTopicDAO.DeleteTopic_VOC(objTopicEntity)
    End Sub
    Public Sub DeleteTopicMoveVOC(ByVal objTopicEntity As TopicsEntity)
        Dim objTopicDAO As TopicDAO

        'init
        objTopicDAO = New TopicDAO()

        objTopicDAO.DeleteTopic_MoveVOC(objTopicEntity)
    End Sub
    Public Function CheckExist(ByVal strTopicName As String) As DataTable
        Dim TopicTable As New DataTable
        Dim objTopicDAO As TopicDAO

        'init
        objTopicDAO = New TopicDAO()

        TopicTable = objTopicDAO.CheckExist(strTopicName)

        Return TopicTable

    End Function

    Public Sub UpdateTopic(ByVal objTopicEntity As TopicsEntity)
        Dim objTopicDAO As TopicDAO

        'init
        objTopicDAO = New TopicDAO()

        objTopicDAO.UpdateTopic(objTopicEntity)
    End Sub

    Public Function CopyDataToEntityFromDataGrid(ByVal dataTopic As DataGridView, ByVal intID As Int32)
        Dim objTopicEntity As TopicsEntity

        'init
        objTopicEntity = New TopicsEntity()
        'chua co copy Topic ID
        objTopicEntity.TopicID = _
                    dataTopic.Rows(intID).Cells(Constants_LanhVC.STR_TPC_COLUMN_NAME_TOPIC_ID).Value ' Topic ID column
        objTopicEntity.TopicGroupID = _
                            dataTopic.Rows(intID).Cells(Constants_LanhVC.STR_TPC_COLUMN_NAME_TOPIC_GROUP_ID).Value ' Topic ID column
        objTopicEntity.TopicName = dataTopic.Rows(intID).Cells(Constants_LanhVC.STR_TPC_COLUMN_NAME_TOPIC_NAME).Value
        objTopicEntity.TopicGroupName = dataTopic.Rows(intID).Cells(Constants_LanhVC.STR_TPC_COLUMN_NAME_TOPIC_GROUP_NAME).Value
        objTopicEntity.TopicDescription = _
                    dataTopic.Rows(intID).Cells(Constants_LanhVC.STR_TPG_COLUMN_NAME_TOPIC_GROUP_DESCRIPTION).Value

        Return objTopicEntity
    End Function
    'LanhVC - start

    ''' <summary>
    ''' Get ID by group name and topic name
    ''' </summary>
    ''' <param name="strTopicGroup">Group name</param>
    ''' <param name="strTopicName">Topic name</param>
    ''' <returns>ID of topic</returns>
    ''' <remarks></remarks>
    Public Function GetTopicID(ByVal strTopicGroup As String, ByVal strTopicName As String)
        Dim objTopicDAO As TopicDAO

        'init
        objTopicDAO = New TopicDAO()

        Return objTopicDAO.GetTopicID(strTopicGroup, strTopicName)

    End Function

    ''' <summary>
    ''' Get List of Topic by Topic Group Name
    ''' </summary>
    ''' <param name="strTopicGroup">Topic Group Name</param>
    ''' <returns>datatable of Topic Group(ID, Name, Description)</returns>
    ''' <remarks></remarks>
    Public Function GetTopicListByTopicGroupName(ByVal strTopicGroup As String)
        Dim objTopicDAO As TopicDAO

        'init
        objTopicDAO = New TopicDAO()

        Return objTopicDAO.GetTopicListByTopicGroupName(strTopicGroup)
    End Function
    'LanhVC - End
End Class

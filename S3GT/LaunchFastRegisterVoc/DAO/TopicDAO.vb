Public Class TopicDAO

    ''' <summary>
    ''' Add one Topic to database
    ''' </summary>
    ''' <param name="objTopicEntity">data of Topic Group</param>
    ''' <returns>new value of Topic Group</returns>
    ''' <remarks>Have ID of Topic Group</remarks>
    Public Function AddNew(ByVal objTopicEntity As TopicsEntity) As TopicsEntity
        Dim strSQL As String
        Dim objBaseDAO As BaseDAO

        'init
        strSQL = Constants_LanhVC.STR_BLANK_VALUE
        objBaseDAO = Nothing

        'set value for SQL
        strSQL = String.Format(Constants_LanhVC.STR_SQL_TPC_ADDNEW, _
                       Utils.Replace(objTopicEntity.TopicGroupID), _
                       Utils.Replace(objTopicEntity.TopicName), _
                       Utils.Replace(objTopicEntity.TopicDescription))
        'get ID of voc
        objBaseDAO = New BaseDAO()
        objBaseDAO.ExecuteNonQuery(strSQL)
        objTopicEntity.TopicID = Integer.Parse(objBaseDAO.ExecuteScalar(Constants_LanhVC.STR_SQL_TPC_GETMAXID).ToString())

        Return objTopicEntity
    End Function

    ''' <summary>
    ''' Get table of all existing Topics.
    ''' </summary>
    ''' <returns>DataTable - table of all Topics</returns>
    ''' <remarks>Here we use Datatable as return data to facilitate the filter on table rows following some criteria
    ''' without requery from database.</remarks>
    Public Function GetTopicsTable() As DataTable
        Dim vocTable As New DataTable
        Dim strSQL As String
        Dim objBaseDAO As BaseDAO

        'init
        objBaseDAO = Nothing

        'set value for SQL
        strSQL = Constants_LanhVC.STR_SQL_TPC_GETALL

        'get table of Topics
        objBaseDAO = New BaseDAO()
        vocTable = objBaseDAO.ExecuteQuery(strSQL)
        Return vocTable
    End Function
    Public Function GetTopicGroup() As DataTable
        Dim vocTable As New DataTable
        Dim strSQL As String
        Dim objBaseDAO As BaseDAO

        'init
        objBaseDAO = Nothing

        'set value for SQL
        strSQL = Constants_LanhVC.STR_SQL_TPG_GETALL

        'get table of Topics
        objBaseDAO = New BaseDAO()
        vocTable = objBaseDAO.ExecuteQuery(strSQL)
        Return vocTable
    End Function

    ''' <summary>
    ''' Get Table of Topics by TopicGroup and Toptic
    ''' </summary>
    ''' <param name="p_intTopicGroupID">Content ID of Topic Group</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetTopicTableByTopicGroup(ByVal p_intTopicGroupID As Integer) As DataTable
        Dim objTopicTable As DataTable
        Dim strSQL As String
        Dim objBaseDAO As BaseDAO
        'init
        objTopicTable = New DataTable()
        strSQL = Constants_LanhVC.STR_BLANK_VALUE
        objBaseDAO = Nothing

        'set value for SQL
        strSQL = String.Format(Constants_LanhVC.STR_SQL_TPC_GETDATATABLE_BY_TOPICGROUP, p_intTopicGroupID)

        'get datatable of voc
        objBaseDAO = New BaseDAO()
        objTopicTable = objBaseDAO.ExecuteQuery(strSQL)

        Return objTopicTable
    End Function
    ''' <summary>
    ''' Get Topic by ID
    ''' </summary>
    ''' <param name="topicname">Topic Name</param>
    ''' <param name="topicgroup">Topic Group Name</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetTopicByName(ByVal topicname As String, ByVal topicgroup As String) As TopicsEntity
        Dim objTopicsTable As DataTable
        Dim objTopicEntity As TopicsEntity
        Dim strSQL As String
        Dim objBaseDAO As BaseDAO
        'init
        objTopicsTable = New DataTable()
        strSQL = Constants_LanhVC.STR_BLANK_VALUE
        objBaseDAO = Nothing

        'set value for SQL
        strSQL = String.Format(Constants_LanhVC.STR_SQL_TPC_GET_TOPIC_BY_Name, Utils.Replace(topicname), Utils.Replace(topicgroup))

        'get datatable of voc
        objBaseDAO = New BaseDAO()
        objTopicsTable = objBaseDAO.ExecuteQuery(strSQL)

        'because there are only a Topic Group with the given ID
        objTopicEntity = New TopicsEntity
        objTopicEntity.TopicID = Integer.Parse(objTopicsTable.Rows(0)(Constants_LanhVC.STR_TPC_COLUMN_NAME_TOPIC_ID).ToString)
        objTopicEntity.TopicGroupID = Integer.Parse(objTopicsTable.Rows(0)(Constants_LanhVC.STR_TPC_COLUMN_NAME_TOPIC_ID).ToString)
        objTopicEntity.TopicName = objTopicsTable.Rows(0)(Constants_LanhVC.STR_TPC_COLUMN_NAME_TOPIC_NAME)
        objTopicEntity.TopicGroupName = objTopicsTable.Rows(0)(Constants_LanhVC.STR_TPC_COLUMN_NAME_TOPIC_GROUP_NAME)
        objTopicEntity.TopicDescription = objTopicsTable.Rows(0)(Constants_LanhVC.STR_TPC_COLUMN_NAME_TOPIC_DESCRIPTION)

        Return objTopicEntity
    End Function

    ''' <summary>
    ''' Get Topic by ID
    ''' </summary>
    ''' <param name="p_intTopicID">Topic Group ID</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetTopicByID(ByVal p_intTopicID As Integer) As TopicsEntity
        Dim objTopicsTable As DataTable
        Dim objTopicEntity As TopicsEntity
        Dim strSQL As String
        Dim objBaseDAO As BaseDAO
        'init
        objTopicsTable = New DataTable()
        strSQL = Constants_LanhVC.STR_BLANK_VALUE
        objBaseDAO = Nothing

        'set value for SQL
        strSQL = String.Format(Constants_LanhVC.STR_SQL_TPC_GET_TOPIC_BY_ID, p_intTopicID)

        'get datatable of voc
        objBaseDAO = New BaseDAO()
        objTopicsTable = objBaseDAO.ExecuteQuery(strSQL)

        'because there are only a Topic Group with the given ID
        objTopicEntity = New TopicsEntity
        objTopicEntity.TopicID = Integer.Parse(objTopicsTable.Rows(0)(Constants_LanhVC.STR_TPC_COLUMN_NAME_TOPIC_ID).ToString)
        objTopicEntity.TopicGroupID = Integer.Parse(objTopicsTable.Rows(0)(Constants_LanhVC.STR_TPC_COLUMN_NAME_TOPIC_ID).ToString)
        objTopicEntity.TopicName = objTopicsTable.Rows(0)(Constants_LanhVC.STR_TPC_COLUMN_NAME_TOPIC_NAME)
        objTopicEntity.TopicGroupName = objTopicsTable.Rows(0)(Constants_LanhVC.STR_TPC_COLUMN_NAME_TOPIC_GROUP_NAME)
        objTopicEntity.TopicDescription = objTopicsTable.Rows(0)(Constants_LanhVC.STR_TPC_COLUMN_NAME_TOPIC_DESCRIPTION)

        Return objTopicEntity
    End Function

    ''' <summary>
    ''' Delete Topic Group by ID
    ''' </summary>
    ''' <param name="objTopicEntity">Content ID of Topic Group</param>
    ''' <remarks></remarks>
    Public Sub DeleteTopic_VOC(ByVal objTopicEntity As TopicsEntity)
        Dim strSQL, strSQL2 As String
        Dim objBaseDAO As BaseDAO

        'init
        strSQL = Constants_LanhVC.STR_BLANK_VALUE
        strSQL2 = Constants_LanhVC.STR_BLANK_VALUE
        objBaseDAO = Nothing

        'set value for SQL
        strSQL = String.Format(Constants_LanhVC.STR_SQL_TPC_DELETE_TPC, objTopicEntity.TopicID)
        strSQL2 = String.Format(Constants_LanhVC.STR_SQL_TPC_DELETE_VOC_BASEON_TOPICID, objTopicEntity.TopicID)
        'delete voc
        objBaseDAO = New BaseDAO()
        objBaseDAO.ExecuteNonQuery(strSQL2)
        objBaseDAO.ExecuteNonQuery(strSQL)

    End Sub
    Public Sub DeleteTopic_MoveVOC(ByVal objTopicEntity As TopicsEntity)
        Dim strSQL, strSQL2 As String
        Dim objBaseDAO As BaseDAO

        'init
        strSQL = Constants_LanhVC.STR_BLANK_VALUE
        strSQL2 = Constants_LanhVC.STR_BLANK_VALUE
        objBaseDAO = Nothing

        'set value for SQL
        strSQL = String.Format(Constants_LanhVC.STR_SQL_TPC_MOVE_VOC, Constants_HaoLT.DEFAULT_TOPICID, objTopicEntity.TopicID)
        strSQL2 = String.Format(Constants_LanhVC.STR_SQL_TPC_DELETE_TPC, objTopicEntity.TopicID)
        'delete voc
        objBaseDAO = New BaseDAO()
        objBaseDAO.ExecuteNonQuery(strSQL)
        objBaseDAO.ExecuteNonQuery(strSQL2)
    End Sub
    ''' <summary>
    ''' Check exist of 1 Topic Group in database
    ''' </summary>
    ''' <param name="p_strTopicName">Topic Group Name</param>
    ''' <returns>Table of existing Topic Groups found</returns>
    ''' <remarks></remarks>
    Public Function CheckExist(ByVal p_strTopicName As String) As DataTable

        Dim objTopicTable As DataTable
        Dim strSQL As String
        Dim objBaseDAO As BaseDAO

        'init
        objTopicTable = New DataTable()
        strSQL = Constants_LanhVC.STR_BLANK_VALUE
        objBaseDAO = Nothing

        'set value for SQL
        strSQL = String.Format(Constants_LanhVC.STR_SQL_TPC_CHECK_EXIST, Utils.Replace(p_strTopicName))

        'get datatable of voc
        objBaseDAO = New BaseDAO()
        objTopicTable = objBaseDAO.ExecuteQuery(strSQL)

        Return objTopicTable

    End Function

    ''' <summary>
    ''' Update 1 Topic
    ''' </summary>
    ''' <param name="objTopicEntity">Topic ID</param>    
    ''' <remarks></remarks>
    Public Sub UpdateTopic(ByVal objTopicEntity As TopicsEntity)

        Dim strSQL As String
        Dim objBaseDAO As BaseDAO

        'init
        strSQL = Constants_LanhVC.STR_BLANK_VALUE
        objBaseDAO = Nothing

        'set value for SQL
        strSQL = String.Format(Constants_LanhVC.STR_SQL_TPC_UpdateByID, _
                             Utils.Replace(objTopicEntity.TopicName), _
                               Utils.Replace(objTopicEntity.TopicDescription), _
                               Utils.Replace(objTopicEntity.TopicGroupID), _
                              Utils.Replace(objTopicEntity.TopicID))

        'get datatable of voc
        objBaseDAO = New BaseDAO()
        objBaseDAO.ExecuteNonQuery(strSQL)

    End Sub
    ''' <remarks></remarks>
    Public Function GetTopicID(ByVal strTopicGroup As String, ByVal strTopicName As String)
        Dim objTopicTable As DataTable
        Dim strSQL As String
        Dim objBaseDAO As BaseDAO
        Dim intResult As Integer

        'init
        objTopicTable = New DataTable()
        strSQL = Constants_LanhVC.STR_BLANK_VALUE
        objBaseDAO = Nothing
        intResult = -1

        'set value for SQL
        strSQL = String.Format(Constants_LanhVC.STR_SQL_TPC_GET_TOPIC, Utils.Replace(strTopicGroup), Utils.Replace(strTopicName))

        'get datatable of voc
        objBaseDAO = New BaseDAO()
        objTopicTable = objBaseDAO.ExecuteQuery(strSQL)

        If objTopicTable.Rows.Count > 0 Then
            intResult = Integer.Parse(objTopicTable.Rows(0)(0).ToString())
        End If

        Return intResult
    End Function


    ''' <summary>
    ''' Get List of Topic by Topic Group Name
    ''' </summary>
    ''' <param name="strTopicGroup">Topic Group Name</param>
    ''' <returns>datatable of Topic Group(ID, Name, Description)</returns>
    ''' <remarks></remarks>
    Public Function GetTopicListByTopicGroupName(ByVal strTopicGroup As String)
        Dim objTopicTable As DataTable
        Dim strSQL As String
        Dim objBaseDAO As BaseDAO

        'init
        objTopicTable = New DataTable()
        strSQL = Constants_LanhVC.STR_BLANK_VALUE
        objBaseDAO = Nothing

        'set value for SQL
        strSQL = String.Format(Constants_LanhVC.STR_SQL_TPC_GET_TOPIC_LIST, Utils.Replace(strTopicGroup))

        'get datatable of voc
        objBaseDAO = New BaseDAO()
        objTopicTable = objBaseDAO.ExecuteQuery(strSQL)

        Return objTopicTable
    End Function
    'LanhVC - End

End Class

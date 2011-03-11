Public Class TopicGroupDAO

    ''' <summary>
    ''' Add one Topic Group to database
    ''' </summary>
    ''' <param name="objTopicGroupEntity">data of Topic Group</param>
    ''' <returns>new value of Topic Group</returns>
    ''' <remarks>Have ID of Topic Group</remarks>
    Public Function AddNew(ByVal objTopicGroupEntity As TopicGroupsEntity) As TopicGroupsEntity
        Dim strSQL As String
        Dim objBaseDAO As BaseDAO

        'init
        strSQL = Constants_LanhVC.STR_BLANK_VALUE
        objBaseDAO = Nothing

        'set value for SQL
        strSQL = String.Format(Constants_LanhVC.STR_SQL_TPG_ADD_NEW, _
                      Utils.Replace(objTopicGroupEntity.TopicGroupName), _
                       Utils.Replace(objTopicGroupEntity.TopicGroupDescription))
        'get ID of voc
        objBaseDAO = New BaseDAO()
        objBaseDAO.ExecuteNonQuery(strSQL)
        objTopicGroupEntity.TopicGroupID = Int32.Parse(objBaseDAO.ExecuteScalar(Constants_LanhVC.STR_SQL_TPG_GETMAXID).ToString())

        Return objTopicGroupEntity
    End Function

    ''' <summary>
    ''' Get table of all existing TopicGroups.
    ''' </summary>
    ''' <returns>DataTable - table of all TopicGroups</returns>
    ''' <remarks>Here we use Datatable as return data to facilitate the filter on table rows following some criteria
    ''' without requery from database.</remarks>
    Public Function GetTopicGroupsTable() As DataTable
        Dim vocTable As New DataTable
        Dim strSQL As String
        Dim objBaseDAO As BaseDAO

        'init
        objBaseDAO = Nothing

        'set value for SQL
        strSQL = Constants_LanhVC.STR_SQL_TPG_GETALL

        'get table of TopicGroups
        objBaseDAO = New BaseDAO()
        vocTable = objBaseDAO.ExecuteQuery(strSQL)
        Return vocTable
    End Function


    ''' <summary>
    ''' Get TopicGroup by ID
    ''' </summary>
    ''' <param name="p_intTopicGroupID">Topic Group ID</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetTopicGroupByID(ByVal p_intTopicGroupID As Integer) As TopicGroupsEntity
        Dim objTopicGroupsTable As DataTable
        Dim objTopicGroupEntity As TopicGroupsEntity
        Dim strSQL As String
        Dim objBaseDAO As BaseDAO
        'init
        objTopicGroupsTable = New DataTable()
        strSQL = Constants_LanhVC.STR_BLANK_VALUE
        objBaseDAO = Nothing

        'set value for SQL
        strSQL = String.Format(Constants_LanhVC.STR_SQL_TPG_GET_TOPIC_GROUP_BY_ID, p_intTopicGroupID)

        'get datatable of voc
        objBaseDAO = New BaseDAO()
        objTopicGroupsTable = objBaseDAO.ExecuteQuery(strSQL)

        'because there are only a Topic Group with the given ID
        objTopicGroupEntity = New TopicGroupsEntity
        objTopicGroupEntity.TopicGroupID = Integer.Parse(objTopicGroupsTable.Rows(0)(Constants_LanhVC.STR_TPG_COLUMN_NAME_TOPIC_GROUP_ID).ToString)
        objTopicGroupEntity.TopicGroupName = objTopicGroupsTable.Rows(0)(Constants_LanhVC.STR_TPG_COLUMN_NAME_TOPIC_GROUP_NAME)
        objTopicGroupEntity.TopicGroupDescription = objTopicGroupsTable.Rows(0)(Constants_LanhVC.STR_TPG_COLUMN_NAME_TOPIC_GROUP_DESCRIPTION)

        Return objTopicGroupEntity
    End Function

    ''' <summary>
    ''' Delete Topic Group by ID
    ''' </summary>
    ''' <param name="objTopicGroupEntity">Content ID of Topic Group</param>
    ''' <remarks></remarks>
    Public Sub DeleteTopicGroup(ByVal objTopicGroupEntity As TopicGroupsEntity)
        Dim strSQL As String
        Dim objBaseDAO As BaseDAO

        'init
        strSQL = Constants_LanhVC.STR_BLANK_VALUE
        objBaseDAO = Nothing

        'set value for SQL
        strSQL = String.Format(Constants_LanhVC.STR_SQL_TPG_DELETE_TPG, objTopicGroupEntity.TopicGroupID)

        'delete voc
        objBaseDAO = New BaseDAO()
        objBaseDAO.ExecuteNonQuery(strSQL)

    End Sub

    ''' <summary>
    ''' Check exist of 1 Topic Group in database
    ''' </summary>
    ''' <param name="p_strTopicGroupName">Topic Group Name</param>
    ''' <returns>Table of existing Topic Groups found</returns>
    ''' <remarks></remarks>
    Public Function CheckExist(ByVal p_strTopicGroupName As String) As DataTable

        Dim objTopicGroupTable As DataTable
        Dim strSQL As String
        Dim objBaseDAO As BaseDAO

        'init
        objTopicGroupTable = New DataTable()
        strSQL = Constants_LanhVC.STR_BLANK_VALUE
        objBaseDAO = Nothing

        'set value for SQL
        strSQL = String.Format(Constants_LanhVC.STR_SQL_TPG_CHECK_EXIST, Utils.Replace(p_strTopicGroupName))

        'get datatable of voc
        objBaseDAO = New BaseDAO()
        objTopicGroupTable = objBaseDAO.ExecuteQuery(strSQL)

        Return objTopicGroupTable

    End Function

    ''' <summary>
    ''' Update 1 Topic Group
    ''' </summary>    
    ''' <remarks></remarks>
    Public Sub UpdateTopicGroup(ByVal objTopicGroupEntity As TopicGroupsEntity)

        Dim strSQL As String
        Dim objBaseDAO As BaseDAO

        'init
        strSQL = Constants_LanhVC.STR_BLANK_VALUE
        objBaseDAO = Nothing

        'set value for SQL
        strSQL = String.Format(Constants_LanhVC.STR_SQL_TPG_UpdateByID, _
                              Utils.Replace(objTopicGroupEntity.TopicGroupName), _
                               Utils.Replace(objTopicGroupEntity.TopicGroupDescription), _
                                objTopicGroupEntity.TopicGroupID)

        'get datatable of voc
        objBaseDAO = New BaseDAO()
        objBaseDAO.ExecuteNonQuery(strSQL)

    End Sub
End Class

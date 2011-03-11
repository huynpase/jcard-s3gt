Public Class ParameterDAO
    ''' <summary>
    ''' Add one Parameter with Values to database
    ''' </summary>
    ''' <param name="objParamEntity">data of a Parameter</param>
    ''' <returns>New value of Parameter</returns>
    ''' <remarks>Have ID of Parameter</remarks>
    Public Function AddNew(ByVal objParamEntity As ParameterEntity) As ParameterEntity
        Dim strSQL As String
        Dim objBaseDAO As BaseDAO

        'init
        strSQL = Constants_LanhVC.STR_BLANK_VALUE
        objBaseDAO = Nothing

        'set value for SQL
        strSQL = String.Format(Constants_LanhVC.STR_SQL_PARAM_ADD_NEW, _
                        Utils.Replace(objParamEntity.ParameterName), _
                        Utils.Replace(objParamEntity.ParameterValue), _
                        Utils.Replace(objParamEntity.ParameterDescription))
        'get ID of voc
        objBaseDAO = New BaseDAO()
        Try
            objBaseDAO.ExecuteNonQuery(strSQL)
        Catch ex As Exception
            objParamEntity = Nothing
        End Try
        Return objParamEntity
    End Function

    ''' <summary>
    ''' Get table of all existing Parameters.
    ''' </summary>
    ''' <returns>DataTable - table of all Parameters</returns>
    ''' <remarks>Here we use Datatable as return data to facilitate the filter on table rows following some criteria
    ''' without requery from database.</remarks>
    Public Function GetParamsTable() As DataTable
        Dim paramTable As New DataTable
        Dim strSQL As String
        Dim objBaseDAO As BaseDAO

        'init
        objBaseDAO = Nothing

        'set value for SQL
        strSQL = Constants_LanhVC.STR_SQL_PARAM_GETALL

        'get table of TopicGroups
        objBaseDAO = New BaseDAO()
        paramTable = objBaseDAO.ExecuteQuery(strSQL)
        Return paramTable
    End Function


    ''' <summary>
    ''' Get Parameter by Name
    ''' </summary>
    ''' <param name="p_strParamName">Parameter Name</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetParameterByName(ByVal p_strParamName As String) As ParameterEntity
        Dim objParamsTable As DataTable
        Dim objParamEntity As ParameterEntity
        Dim strSQL As String
        Dim objBaseDAO As BaseDAO
        'init
        objParamsTable = New DataTable()
        strSQL = Constants_LanhVC.STR_BLANK_VALUE
        objBaseDAO = Nothing

        'set value for SQL
        strSQL = String.Format(Constants_LanhVC.STR_SQL_PARAM_GET_PARAM_BY_NAME, p_strParamName)

        'get datatable of voc
        objBaseDAO = New BaseDAO()
        objParamsTable = objBaseDAO.ExecuteQuery(strSQL)

        'because there are only a Topic Group with the given ID

        objParamEntity = New ParameterEntity
        objParamEntity.ParameterName = Utils.Replace(objParamsTable.Rows(0)(Constants_LanhVC.STR_PARAM_COLUMN_NAME_PARAMETER_NAME))
        objParamEntity.ParameterValue = Utils.Replace(objParamsTable.Rows(0)(Constants_LanhVC.STR_PARAM_COLUMN_NAME_PARAMETER_VALUE))
        objParamEntity.ParameterDescription = Utils.Replace(objParamsTable.Rows(0)(Constants_LanhVC.STR_PARAM_COLUMN_NAME_PARAMETER_DESCRIPTION))

        Return objParamEntity
    End Function

    ''' <summary>
    ''' Delete Topic Group by ID
    ''' </summary>
    ''' <param name="objParamEntity">Parameter</param>
    ''' <remarks></remarks>
    Public Sub DeleteParamter(ByVal objParamEntity As ParameterEntity)
        Dim strSQL As String
        Dim objBaseDAO As BaseDAO

        'init
        strSQL = Constants_LanhVC.STR_BLANK_VALUE
        objBaseDAO = Nothing

        'set value for SQL
        strSQL = String.Format(Constants_LanhVC.STR_SQL_PARAM_DELETE_PARAM, objParamEntity.ParameterName)

        'delete voc
        objBaseDAO = New BaseDAO()
        objBaseDAO.ExecuteNonQuery(strSQL)

    End Sub

    ''' <summary>
    ''' Check exist of 1 Topic Group in database
    ''' </summary>
    ''' <param name="p_strParamName">Parameter Name</param>
    ''' <returns>Table of existing Parameters found</returns>
    ''' <remarks></remarks>
    Public Function CheckExist(ByVal p_strParamName As String) As DataTable

        Dim objParamsTable As DataTable
        Dim strSQL As String
        Dim objBaseDAO As BaseDAO

        'init
        objParamsTable = New DataTable()
        strSQL = Constants_LanhVC.STR_BLANK_VALUE
        objBaseDAO = Nothing

        'set value for SQL
        strSQL = String.Format(Constants_LanhVC.STR_SQL_PARAM_CHECK_EXIST, Utils.Replace(p_strParamName))

        'get datatable of voc
        objBaseDAO = New BaseDAO()
        objParamsTable = objBaseDAO.ExecuteQuery(strSQL)

        Return objParamsTable

    End Function

    ''' <summary>
    ''' Update 1 Parameter
    ''' </summary>    
    ''' <remarks></remarks>
    Public Sub UpdateParameter(ByVal objParamEntity As ParameterEntity)

        Dim strSQL As String
        Dim objBaseDAO As BaseDAO
        Dim dataTable As DataTable

        'init
        strSQL = Constants_LanhVC.STR_BLANK_VALUE
        objBaseDAO = Nothing

        'check 
        strSQL = String.Format(Constants_LanhVC.STR_SQL_PARAM_GET_PARAM_BY_NAME, _
                        Utils.Replace(objParamEntity.ParameterName))
        objBaseDAO = New BaseDAO()
        dataTable = objBaseDAO.ExecuteQuery(strSQL)
        If (dataTable IsNot Nothing AndAlso dataTable.Rows.Count = 1) Then
            'set value for SQL
            strSQL = String.Format(Constants_LanhVC.STR_SQL_PARAM_UPDATE_BY_NAME, _
                           Utils.Replace(objParamEntity.ParameterValue), _
                           Utils.Replace(objParamEntity.ParameterDescription), _
                            objParamEntity.ParameterName)
            objBaseDAO.ExecuteNonQuery(strSQL)
        Else
            strSQL = String.Format(Constants_LanhVC.STR_SQL_PARAM_ADD_NEW, _
                           Utils.Replace(objParamEntity.ParameterName), _
                           Utils.Replace(objParamEntity.ParameterValue), _
                            objParamEntity.ParameterDescription)
            objBaseDAO.ExecuteNonQuery(strSQL)
        End If

    End Sub
End Class

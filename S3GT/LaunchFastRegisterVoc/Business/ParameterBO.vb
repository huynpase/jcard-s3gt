Public Class ParameterBO
    ''' <summary>
    ''' Add new Parameter into database
    ''' </summary>
    ''' <param name="objParamEntity">data of Paramter</param>
    ''' <returns>new value of Parameter</returns>
    Public Function AddNew(ByVal objParamEntity As ParameterEntity) As ParameterEntity
        Dim objParamDAO As ParameterDAO

        'init
        objParamDAO = New ParameterDAO()
        objParamEntity = objParamDAO.AddNew(objParamEntity)

        Return objParamEntity
    End Function

    ''' <summary>
    ''' Get all rows in the Parameters Table.
    ''' Here the returned parameter is a Datatable to facilitating filtering on table rows
    ''' </summary>
    ''' <returns>Data table of Topic Groups</returns>
    ''' <remarks></remarks>
    Public Function GetParametersTable() As DataTable
        Dim objParamsTable As New DataTable
        Dim objParamDAO As ParameterDAO

        'init
        objParamDAO = New ParameterDAO()
        'TopicGroupTable.DefaultView.RowFilter = ""
        objParamsTable = objParamDAO.GetParamsTable()
        Return objParamsTable
    End Function



    ''' <summary>
    ''' Get Parameter by Parameter Name
    ''' </summary>
    ''' <param name="p_strParamName">Content ID of Topic Group</param>
    ''' <returns>Topic Group Entity object</returns>
    ''' <remarks></remarks>
    Public Function GetParameterByName(ByVal p_strParamName As String) As ParameterEntity
        Dim objParamEntity As New ParameterEntity
        Dim objParamDAO As ParameterDAO

        'init
        objParamDAO = New ParameterDAO()
        'TopicGroupTable.DefaultView.RowFilter = ""
        objParamEntity = objParamDAO.GetParameterByName(p_strParamName)

        Return objParamEntity
    End Function

    ''' <summary>
    ''' Delete a Topic Group from database
    ''' </summary>
    ''' <param name="objParamEntity">Content of Parameter</param>
    ''' <remarks></remarks>
    Public Sub DeleteParameter(ByVal objParamEntity As ParameterEntity)
        Dim objParamDAO As ParameterDAO

        'init
        objParamDAO = New ParameterDAO()

        objParamDAO.DeleteParamter(objParamEntity)
    End Sub

    Public Function CheckExist(ByVal strParamName As String) As DataTable
        Dim objParamTable As New DataTable
        Dim objParamDAO As ParameterDAO

        'init
        objParamDAO = New ParameterDAO()

        objParamTable = objParamDAO.CheckExist(strParamName)

        Return objParamTable

    End Function

    Public Sub UpdateParameter(ByVal objParamEntity As ParameterEntity)
        Dim objParamDAO As ParameterDAO

        'init
        objParamDAO = New ParameterDAO()

        objParamDAO.UpdateParameter(objParamEntity)
    End Sub
End Class

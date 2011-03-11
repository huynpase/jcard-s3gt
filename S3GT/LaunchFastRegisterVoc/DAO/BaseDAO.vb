
Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Configuration


Public Class BaseDAO

    ''' <summary>
    ''' Open connect to database
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Connect() As OleDbConnection

        Dim objConnection As OleDbConnection
        Dim strConnection As String

        objConnection = Nothing
        Try
            'strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= D:\SourceCode3kyu\S3GT_Design\bin\Debug\datasource\s3gt_db.mdb" 'My.Settings.s3gt_dbConnectionString
            strConnection = CStr(My.Settings.s3gt_dbConnectionString) 'My.Settings.s3gt_dbConnectionString
            'MessageBox.Show(strConnection)

            objConnection = New OleDbConnection(strConnection)
            objConnection.Open()

        Catch ex As Exception

        End Try

        Return objConnection

    End Function

    ''' <summary>
    ''' Close connection
    ''' </summary>
    ''' <param name="objConnection"></param>
    ''' <remarks></remarks>
    Public Sub Disconnect(ByVal objConnection As OleDbConnection)

        Try
            If objConnection.State = ConnectionState.Open Then
                objConnection.Close()
                objConnection = Nothing
            End If
        Catch ex As Exception
            'MessageBox.Show(ex.ToString())
            Throw ex
        End Try
    End Sub


    ''' <summary>
    ''' Select data form table
    ''' </summary>
    ''' <param name="strQuery">SQL string: noi dung cau SQL</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ExecuteQuery(ByVal strQuery As String) As DataTable
        ' declare variable
        Dim objDataset As DataSet
        Dim objDataAdapter As OleDbDataAdapter
        Dim objConnection As OleDbConnection
        Dim objDatatable As DataTable
        'init
        objDataset = Nothing
        objDataAdapter = Nothing
        objConnection = Connect()
        objDatatable = Nothing
        Try
            objDataAdapter = New OleDbDataAdapter(strQuery, objConnection)

            If Not objDataAdapter Is Nothing Then
                objDataset = New DataSet()
                objDataAdapter.Fill(objDataset)

                If (Not objDataset Is Nothing) AndAlso (objDataset.Tables.Count > 0) Then
                    objDatatable = objDataset.Tables(0)
                End If
            End If
        Catch ex As Exception
            Throw ex

            'MessageBox.Show(ex.ToString())
        Finally
            Disconnect(objConnection)
        End Try
        Return objDatatable
    End Function

    ''' <summary>
    ''' Insert, Update, Delete data in table
    ''' </summary>
    ''' <param name="strQuery">SQL string: Cau lenh SQL  dua vao</param>
    ''' <remarks></remarks>
    Public Sub ExecuteNonQuery(ByVal strQuery As String)
        ' declare variable
        Dim objCommand As OleDbCommand
        Dim objConnection As OleDbConnection

        'init
        objCommand = Nothing
        objConnection = Connect()

        Try
            objCommand = New OleDbCommand(strQuery, objConnection)
            objCommand.CommandType = CommandType.Text
            'MessageBox.Show(objCommand.CommandText)
            Dim i As Integer
            i = objCommand.ExecuteNonQuery()
            'MessageBox.Show("Number of affected records:" & i)
        Catch ex As Exception
            'MessageBox.Show(ex.ToString)
            Throw ex
        Finally
            Disconnect(objConnection)
        End Try
    End Sub

    ''' <summary>
    ''' Get Max, Min, Sum ... from Column of table
    ''' </summary>
    ''' <param name="strQuery">SQL string: Cau lenh SQL dua vao</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ExecuteScalar(ByVal strQuery As String) As Object

        Dim objCommand As OleDbCommand
        Dim objConnection As OleDbConnection
        Dim objResult As Object

        ' init
        objResult = Nothing
        objCommand = Nothing
        objConnection = Connect()
        Try
            objCommand = New OleDbCommand(strQuery, objConnection)
            objResult = objCommand.ExecuteScalar()
        Catch ex As Exception
            'MessageBox.Show(ex.ToString())
            Throw ex
        Finally
            Disconnect(objConnection)
        End Try

        Return objResult

    End Function

End Class



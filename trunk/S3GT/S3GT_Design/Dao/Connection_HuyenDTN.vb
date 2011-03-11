Imports System
Imports System.Data
Imports System.Data.OleDb
Public Class Connection_HuyenDTN
    'Dim strCon As String = My.Settings.s3gt_dbConnectionString '"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\\..\\datasource\\s3gt_db.mdb"
    Dim strCon As String = CStr(My.Settings.s3gt_dbConnectionString) '"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\\..\\datasource\\s3gt_db.mdb"
    Public Property ConStr() As String
        Get
            Return strCon
        End Get
        Set(ByVal value As String)
            strCon = value
        End Set
    End Property
    Private strSQL As String
    Public Property SQL() As String
        Get
            Return strSQL
        End Get
        Set(ByVal value As String)
            strSQL = value
        End Set
    End Property
    Private strError As String = ""
    Public ReadOnly Property Errors() As String
        Get
            Return strError
        End Get
    End Property
    Public Function getValue() As String
        Dim strResult As String = ""
        Dim myCon As OleDbConnection = New OleDbConnection(strCon)
        Dim myCom As OleDbCommand = New OleDbCommand(strSQL, myCon)
        Try
            myCon.Open()
            If Not myCom.ExecuteScalar() Is Nothing Then
                strResult = myCom.ExecuteScalar()
            End If
            myCon.Close()
            myCon.Dispose()
        Catch ex As Exception
            strError = ex.Message
        End Try
        Return strResult
    End Function
    Dim dtTable As New DataTable
    Dim myDT As New DataTable
    Function Open_Connection() As OleDbConnection
        Dim Kq As New OleDbConnection
        Try
            Kq = (New OleDbConnection(strCon))
            Kq.Open()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
        Return Kq
    End Function
    Function getDataTable(ByVal strSQL As String) As DataTable
        Dim myCon As New OleDbConnection(strCon)
        Dim myTable As New DataTable
        Dim myData As New OleDbDataAdapter(strSQL, myCon)
        Try
            myData.Fill(myTable)
            myCon.Close()
            myCon.Dispose()
        Catch ex As Exception

        End Try
        Return myTable
    End Function
    Function SQL_XuLy(ByVal str_Lenh As String, ByVal table As DataTable) As Boolean
        Dim Kq As Boolean
        Kq = True
        Dim connect As OleDbConnection = Open_Connection()
        Try
            Dim Bo_thich_ung As OleDbDataAdapter = New OleDbDataAdapter(str_Lenh, connect)
            Dim cmand As OleDbCommandBuilder = New OleDbCommandBuilder(Bo_thich_ung)
            Bo_thich_ung.Update(table)
            Bo_thich_ung.Fill(table)
            connect.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
            Kq = False
        End Try
        Return Kq
    End Function
    Function Write_Database(ByVal table As DataTable) As Boolean
        Dim Kq As Boolean
        Dim str_Lenh As String = "Insert into S3GT_TPG values ('" + "15" + "','" + "a" + "','" + "a" + "')"
        Kq = SQL_XuLy(str_Lenh, table)
        Return Kq
    End Function
    Dim table As DataTable
    Function Delete_Data(ByVal str_Lenh As String, ByVal table As DataTable) As Boolean
        Dim Kq As Boolean
        Kq = SQL_XuLy(str_Lenh, table)
        Return Kq
    End Function
    Function Update_Data(ByVal strLenh As String) As DataTable
        'Dim Kq As Boolean
        'Kq = SQL_XuLy(str_Lenh, table)
        'Return Kq
        Dim Kq As New DataTable
        Dim Ket_noi As OleDbConnection = Open_Connection()
        Try
            Dim Bo_thich_ung As New OleDbDataAdapter(strLenh, Ket_noi)
            Bo_thich_ung.Update(Kq)
        Catch ex As Exception
            MessageBox.Show("Error with String sql: " + strLenh + " " + ex.Message)
        End Try
        Return Kq
    End Function
    Function Read(ByVal strLenh As String) As DataTable
        Dim Kq As New DataTable
        Dim Ket_noi As OleDbConnection = Open_Connection()
        Try
            Dim Bo_thich_ung As New OleDbDataAdapter(strLenh, Ket_noi)
            Bo_thich_ung.Fill(Kq)
        Catch ex As Exception
            MessageBox.Show("Error with String sql: " + strLenh + " " + ex.Message)
        End Try
        Return Kq
    End Function
    Function Write(ByVal Table As DataTable, ByVal Name As String) As Boolean
        Dim Kq As Boolean = True
        Dim strLenh As String = "Select * From " + Name
        Dim Ket_noi As OleDbConnection = Open_Connection()
        Try
            Dim Bo_thich_ung As New OleDbDataAdapter(strLenh, Ket_noi)
            Dim Lenh As New OleDbCommandBuilder(Bo_thich_ung)
            Bo_thich_ung.Update(Table)
        Catch ex As Exception
            'MessageBox.Show("Error: " + strLenh + " " + ex.Message)
            Kq = False
        End Try
        Return Kq
    End Function
End Class

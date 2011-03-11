Public Class Bussiness_HuyenDTN
    Private ma_MTPG As Int32
    Public Property MTPG() As Integer
        Get
            Return ma_MTPG
        End Get
        Set(ByVal value As Integer)
            ma_MTPG = value
        End Set
    End Property

    Private strTGName As String
    Public Property Name() As String
        Get
            Return strTGName
        End Get
        Set(ByVal value As String)
            strTGName = value
        End Set
    End Property
    Private strTGDescription As String
    Public Property Description() As String
        Get
            Return strTGDescription
        End Get
        Set(ByVal value As String)
            strTGDescription = value
        End Set
    End Property
    Public Function Check(ByVal object_data As Bussiness_HuyenDTN) As Boolean
        Dim Kq As Boolean = True
        If (object_data.strTGName = "" Or object_data.strTGDescription = "") Then
            Kq = False
        End If
        Return Kq
    End Function
    '//////////////////////////////////////////////////////////////////////////////////////////
    Dim temp As New Connection_HuyenDTN()
    Function Doc_danh_sach() As ArrayList
        Dim Kq As New ArrayList
        Dim table As DataTable = temp.Read("Select * From S3GT_TPG")
        For Each Dong As DataRow In table.Rows
            Kq.Add(Khoi_tao(Dong))
        Next
        Return Kq
    End Function
    Function Khoi_tao(ByVal Dong As DataRow) As Bussiness_HuyenDTN
        Dim Kq As New Bussiness_HuyenDTN
        Kq.MTPG = Integer.Parse(Dong(0))
        Kq.Name = Dong(1).ToString
        Kq.Description = Dong(2).ToString
        Return Kq
    End Function
    Function Xoa(ByVal dt As Bussiness_HuyenDTN) As Boolean
        Dim Kq As Boolean = True
        Dim table As DataTable = temp.Read("Select * From S3GT_TPG Where Topic_Group_ID = " + dt.MTPG.ToString)
        Kq = table.Rows.Count = 1
        'If (Kq) Then
        table.Rows(0).Delete()
        Kq = temp.Write(table, "S3GT_TPG")
        'End If
        Return Kq
    End Function
    Function Delete(ByVal dt As Bussiness_HuyenDTN) As Boolean
        Dim Kq As Boolean = True
        Dim table As DataTable = temp.Read("Select Topic_ID From S3GT_TPG Where Topic_Group_ID = " + dt.MTPG.ToString)
        Kq = table.Rows.Count = 1
        'If (Kq) Then
        table.Rows(0).Delete()
        Kq = temp.Write(table, "S3GT_TPG")
        'End If
        Return Kq
    End Function
    Function Ghi(ByVal dtBH As Bussiness_HuyenDTN) As Boolean
        Dim Kq As Boolean
        Dim table As DataTable = temp.Read("Select * From S3GT_TPG Where Topic_Group_ID = " + dtBH.MTPG.ToString)
        Dim Dong As DataRow
        If (table.Rows.Count = 1) Then
        Else
            Dong = table.NewRow()
            table.Rows.Add(Dong)
        End If
        Dim i As Int32 = 1
        Dong("Topic_Group_Name") = dtBH.Name
        i = i + 1
        Dong("Topic_Group_Description") = dtBH.Description
        Kq = temp.Write(table, "S3GT_TPG")
        Return Kq
    End Function
    Function _Ghi(ByVal dtBH As Bussiness_HuyenDTN) As Boolean
        Dim Kq As Boolean = True
        Dim table As DataTable = temp.Read("Select * From S3GT_TPG")
        'Dim Dong As DataRow = table.Rows(0)
        'QuanTDA code
        'filter table of Topic Group in order to get the rows with appropriate Topic_Group_ID
        table.DefaultView.RowFilter = "Topic_Group_ID=" + CStr(dtBH.MTPG)
        Dim Dong As DataRow = table.DefaultView.Item(0).Row  ' because there is only resulting Topic Group with such an ID 'table.Rows(0)
        'End QuanTDA code
        Dong("Topic_Group_Name") = dtBH.Name
        Dong("Topic_Group_Description") = dtBH.Description
        Kq = temp.Write(table, "S3GT_TPG")
        Return Kq
    End Function
    Function Update_data(ByVal dtBH As Bussiness_HuyenDTN) As Boolean
        Dim Kq As Boolean = True
        Dim stringlenh As String = ""
        'stringlenh = "UPDATE    S3GT_TPC "
        'stringlenh += "SET              Topic_Name = '" + dtBH.Name + "', Topic_Description = '" + dtBH.Description + "', Topic_Group_ID = " + dtBH.MTPG.ToString + " "
        'stringlenh += "WHERE     (Topic_ID = " + dtBH.MTPG.ToString + ")"
        'Dim table As DataTable = temp.Read(stringlenh)
        Dim table As DataTable = temp.Read("Select * From S3GT_TPG")
        'QuanTDA code
        'filter table of Topic Group in order to get the rows with appropriate Topic_Group_ID
        table.DefaultView.RowFilter = "Topic_Group_ID=" + CStr(dtBH.MTPG)
        Dim Dong As DataRow = table.DefaultView.Item(0).Row  ' because there is only resulting Topic Group with such an ID 'table.Rows(0)
        'End QuanTDA code
        'Dim Dong As DataRow = table.Rows(0)
        Dong("Topic_Group_Name") = dtBH.Name
        Dong("Topic_Group_Description") = dtBH.Description
        Kq = temp.Write(table, "S3GT_TPG")
        Return Kq
    End Function
End Class

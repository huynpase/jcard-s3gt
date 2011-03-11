Imports System.Data.OleDb
Imports System.Configuration
Imports S3GT.Constants_NguyenNB

Public Class ExportDAO
    Dim daoBase As New BaseDAO
    Dim con As OleDbConnection
    Public Sub New()
        con = daoBase.Connect()

    End Sub
    Function GetToppic() As DataTable
        Dim sql As String
        Try
            sql = "Select * from {0}"
            sql = String.Format(sql, S3GT_TABLE_TOPIC_GROUP)
            Return daoBase.ExecuteQuery(sql)

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Function GetTopicById(ByVal strID As String) As DataRow
        Dim sql As String
        'sql = "Select * from {0} where {1) = {2}"
        'sql = String.Format(sql, S3GT_TABLE_TOPIC_GROUP, S3GT_TPG_ID, strID)
        sql = "Select * from S3GT_TPG where Topic_group_id = " + strID
        Return daoBase.ExecuteQuery(sql).Rows(0)
    End Function

    Function GetSubTopicById(ByVal strID As String) As DataRow
        Dim sql As String
        sql = "Select * from {0} where {1} = {2}"
        sql = String.Format(sql, S3GT_TABLE_TOPIC, S3GT_TPC_ID, strID)
        'sql = "Select * from S3GT_TPC where Topic_id = " + strID
        Return daoBase.ExecuteQuery(sql).Rows(0)
    End Function

    Function GetSubToppic(ByVal strTopicGroupID As String) As DataTable
        Dim sql As String
        sql = "Select * from {0} where {1} = {2}"
        sql = String.Format(sql, S3GT_TABLE_TOPIC, S3GT_TPG_ID, strTopicGroupID)
        'sql = "Select * from S3GT_TPC where topic_group_id = " & strTopicGroupID
        Return daoBase.ExecuteQuery(sql)
    End Function

    Function GetVoc(ByVal strTopicID As String) As DataTable
        Dim sql As String
        ' sql = "Select * from S3GT_VOC where topic_id = " & strTopicID
        sql = "Select * from {0} where {1} = {2}"
        sql = String.Format(sql, S3GT_TABLE_VOCABULARY, S3GT_TPC_ID, strTopicID)
        Return daoBase.ExecuteQuery(sql)
    End Function

    Function GetKanji() As DataTable
        Dim sql As String
        sql = "select * from {0}"
        sql = String.Format(sql, S3GT_TABLE_KANJI)
        Return daoBase.ExecuteQuery(sql)
    End Function

    Function GetKanjiById(ByVal strId As String) As DataRow
        Dim sql As String
        'sql = "select * from S3GT_KAN where Kanji_id = " & strId
        sql = "select * from {0} where {1} = {2}"
        sql = String.Format(sql, S3GT_TABLE_KANJI, S3GT_KAN_KANJI_ID, strId)
        Return daoBase.ExecuteQuery(sql).Rows(0)

    End Function


End Class

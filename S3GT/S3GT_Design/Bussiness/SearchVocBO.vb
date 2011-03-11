Public Class SearchVocBO
    Public Function SearchVocabulary(ByVal SearchBy As String, ByVal SearchFollow As String, ByVal Topic_Group_ID As Int32, ByVal txtInputKeyword As String, ByVal Topic_Name As String) As DataTable
        Dim vocTable As New DataTable
        Dim SearchVocDAO As SearchVocDAO

        'init
        SearchVocDAO = New SearchVocDAO()
        '
        vocTable = SearchVocDAO.SearchVocabulary(SearchBy, SearchFollow, Topic_Group_ID, txtInputKeyword, Topic_Name)
        Dim TypeStringColumn As New DataColumn
        TypeStringColumn.ColumnName = Constants_PhatLS.STR_VOC_COLUMN_NAME_TYPE_IN_STRING
        vocTable.Columns.Add(TypeStringColumn)
        For i As Integer = 0 To vocTable.Rows.Count - 1
            vocTable.Rows(i).Item(Constants_PhatLS.INT_VOC_DB_COLUMN_TYPE_IN_STRING) = Utils.GetType_TextFromInt(vocTable.Rows(i).Item(Constants_PhatLS.INT_VOC_DB_COLUMN_TYPE))
            vocTable.Rows(i).Item(Constants_PhatLS.INT_VOC_DB_COLUMN_EXAMPLE) = vocTable.Rows(i).Item(Constants_PhatLS.INT_VOC_DB_COLUMN_EXAMPLE)
        Next
        Return vocTable

    End Function
End Class


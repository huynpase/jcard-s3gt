Public Class PerformTestDAO
    Public Function loadVocabulariesFromTopics(ByVal listTopicIDs As ArrayList, ByVal intType As Integer) As DataTable
        Dim objBaseDAO As BaseDAO
        Dim strGetTestVocQuery As String
        Dim strListTopics As String
        Dim strTypeCondition As String
        Dim tableTestVoc As DataTable
        Dim strListTopicsBuilder As System.Text.StringBuilder

        'init
        objBaseDAO = New BaseDAO
        objBaseDAO.Connect()
        strListTopicsBuilder = New System.Text.StringBuilder()

        For index As Integer = 0 To listTopicIDs.Count - 1
            If index <> listTopicIDs.Count - 1 Then
                strListTopicsBuilder.Append(CStr(listTopicIDs.Item(index)))
                strListTopicsBuilder.Append(",")
            Else
                strListTopicsBuilder.Append(CStr(listTopicIDs.Item(index)))
            End If
        Next
        strListTopics = strListTopicsBuilder.ToString

        If intType <> 0 Then
            strTypeCondition = String.Format(Constants_LanhVC.STR_TEST_FILTER_BY_TYPE, CStr(intType))
        Else
            strTypeCondition = Constants_LanhVC.STR_TEST_ANY_TYPE_FILTER
        End If

        strGetTestVocQuery = String.Format(Constants_LanhVC.STR_TEST_GET_VOCABULARIES, _
                                                       strListTopics, _
                                                       strTypeCondition)
        tableTestVoc = objBaseDAO.ExecuteQuery(strGetTestVocQuery)
        Return tableTestVoc
    End Function
End Class

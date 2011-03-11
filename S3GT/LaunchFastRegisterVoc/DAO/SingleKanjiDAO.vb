Public Class SingleKanjiDAO
    ''' <summary>
    ''' Add one Single Kanji to database
    ''' </summary>
    ''' <param name="objSingleKanjiEntity">data of Single Kanji</param>
    ''' <returns>new value of Single Kanji</returns>
    ''' <remarks>Have ID of Single Kanji</remarks>
    Public Function AddNew(ByVal objSingleKanjiEntity As SingleKanjiEntity) As SingleKanjiEntity
        Dim strSQL As String
        Dim objBaseDAO As BaseDAO

        'init
        strSQL = Constants_PhatLS.STR_BLANK_VALUE
        objBaseDAO = Nothing

        'set value for SQL
        'vi Kanji, kunyomi,onyomi chac chan khong co ky tu SQL injection nen khong can dung ham replace
        strSQL = String.Format(Constants_PhatLS.STR_SQL_SINGLE_KANJI_ADDNEW, _
                       objSingleKanjiEntity.Kanji, _
                        Utils.Replace(objSingleKanjiEntity.HanNom), _
                        objSingleKanjiEntity.Kunyomi, _
                        objSingleKanjiEntity.Onyomi, _
                       Utils.Replace(objSingleKanjiEntity.Meaning))
        'get ID of voc
        objBaseDAO = New BaseDAO()
        objBaseDAO.ExecuteNonQuery(strSQL)
        objSingleKanjiEntity.SingleKanjiID = Int32.Parse(objBaseDAO.ExecuteScalar(Constants_PhatLS.STR_SQL_SINGLE_KANJI_GETMAXID).ToString())

        Return objSingleKanjiEntity
    End Function
    ''' <summary>
    ''' Delete Single Kanji by ID
    ''' </summary>
    ''' <param name="objSingleKanjiEntity">Content ID of Single Kanji</param>
    ''' <remarks></remarks>
    Public Sub DeleteSingleKanji(ByVal objSingleKanjiEntity As SingleKanjiEntity)
        Dim strSQL As String
        Dim objBaseDAO As BaseDAO

        'init
        strSQL = Constants_PhatLS.STR_BLANK_VALUE
        objBaseDAO = Nothing

        'set value for SQL
        strSQL = String.Format(Constants_PhatLS.STR_SQL_VOC_DELETE_VOC, objSingleKanjiEntity.SingleKanjiID)

        'delete voc
        objBaseDAO = New BaseDAO()
        objBaseDAO.ExecuteNonQuery(strSQL)

    End Sub

    ''' <summary>
    ''' Update 1 Single Kanji
    ''' </summary>    
    ''' <remarks></remarks>
    Public Sub UpdateSingleKanji(ByVal objSingleKanjiEntity As SingleKanjiEntity)

        Dim strSQL As String
        Dim objBaseDAO As BaseDAO

        'init
        strSQL = Constants_PhatLS.STR_BLANK_VALUE
        objBaseDAO = Nothing

        'set value for SQL
        strSQL = String.Format(Constants_PhatLS.STR_SQL_VOC_UpdateByID, _
                                objSingleKanjiEntity.Kanji, _
                                Utils.Replace(objSingleKanjiEntity.HanNom), _
                                objSingleKanjiEntity.Kunyomi, _
                                objSingleKanjiEntity.Onyomi, _
                                Utils.Replace(objSingleKanjiEntity.Meaning), _
                                objSingleKanjiEntity.SingleKanjiID)

        'get datatable of voc
        objBaseDAO = New BaseDAO()
        objBaseDAO.ExecuteNonQuery(strSQL)

    End Sub

    'PhatLS's Code
    ''' <summary>
    ''' Get table of all rows of Single Kanji match as input key Kunyomi.
    ''' </summary>
    ''' <returns>DataTable - table of all Single Kanji match as input key Kunyomi</returns>
    ''' <remarks>Here we use Datatable as return data to facilitate the filter on table rows following some criteria
    ''' without requery from database.</remarks>
    Public Function GetSingleKanjiTable(ByVal strSQL As String) As DataTable
        Dim vocTable As New DataTable
        Dim objBaseDAO As BaseDAO

        'init
        objBaseDAO = Nothing

        'get table of vocabularies
        objBaseDAO = New BaseDAO()
        vocTable = objBaseDAO.ExecuteQuery(strSQL)
        Return vocTable
    End Function
    'End PhatLS's Code
End Class

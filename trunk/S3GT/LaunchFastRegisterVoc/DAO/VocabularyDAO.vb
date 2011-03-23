Public Class VocabularyDAO


    ''' <summary>
    ''' Add one Vocabulary to database
    ''' </summary>
    ''' <param name="objVocEntity">data of Vocabulary</param>
    ''' <returns>new value of Vocabulary</returns>
    ''' <remarks>Have ID of vocabulary</remarks>
    Public Function AddNew(ByVal objVocEntity As VocabulariesEntity) As VocabulariesEntity
        Dim strSQL As String
        Dim objBaseDAO As BaseDAO

        'init
        strSQL = Constants_LanhVC.STR_BLANK_VALUE
        objBaseDAO = Nothing

        'set value for SQL
        'S3GTv2.0 replaces these line of code:
        'objVocEntity.Hiragana, _
        'objVocEntity.Kanji, _
        'objVocEntity.Hannom, _
        'objVocEntity.Meaning, _
        'objVocEntity.Type
        'by:
        'Utils.Replace(objVocEntity.Hiragana), _
        'Utils.Replace(objVocEntity.Kanji), _
        'Utils.Replace(objVocEntity.Hannom), _
        'Utils.Replace(objVocEntity.Meaning), _
        'objVocEntity.Type, _
        'Utils.Replace(objVocEntity.Example)
        strSQL = String.Format(Constants_LanhVC.STR_SQL_VOC_ADDNEW, _
                        objVocEntity.TopicID, _
                        Utils.Replace(objVocEntity.Hiragana), _
                        Utils.Replace(objVocEntity.Kanji), _
                        Utils.Replace(objVocEntity.Hannom), _
                        Utils.Replace(objVocEntity.Meaning), _
                        objVocEntity.Type, _
                        Utils.Replace(objVocEntity.Example))

        'get ID of voc
        objBaseDAO = New BaseDAO()
        objBaseDAO.ExecuteNonQuery(strSQL)
        objVocEntity.VocID = Int32.Parse(objBaseDAO.ExecuteScalar(Constants_LanhVC.STR_SQL_VOC_GETMAXID).ToString())

        Return objVocEntity
    End Function


    'QuanTDA's Code
    ''' <summary>
    ''' Get table of all existing Vocabularies.
    ''' </summary>
    ''' <returns>DataTable - table of all Vocabularies</returns>
    ''' <remarks>Here we use Datatable as return data to facilitate the filter on table rows following some criteria
    ''' without requery from database.</remarks>
    Public Function GetVocabulariesTable() As DataTable
        Dim vocTable As New DataTable
        Dim strSQL As String
        Dim objBaseDAO As BaseDAO

        'init
        objBaseDAO = Nothing

        'set value for SQL
        strSQL = Constants_LanhVC.STR_SQL_VOC_GETALL

        'get table of vocabularies
        objBaseDAO = New BaseDAO()
        vocTable = objBaseDAO.ExecuteQuery(strSQL)
        Return vocTable
    End Function
    'End QuanTDA's Code

    ''' <summary>
    ''' Get Table Vocabulary by TopicGroup and Toptic
    ''' </summary>
    ''' <param name="intTopicID"> ID of Topc</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetVocTableByTopic(ByVal intTopicID As Integer) As DataTable
        Dim objVocTable As DataTable
        Dim strSQL As String
        Dim objBaseDAO As BaseDAO
        'init
        objVocTable = New DataTable()
        strSQL = Constants_LanhVC.STR_BLANK_VALUE
        objBaseDAO = Nothing

        'set value for SQL
        strSQL = String.Format(Constants_LanhVC.STR_SQL_VOC_GETDATATABLE_BYTOPIC, intTopicID)

        'get datatable of voc
        objBaseDAO = New BaseDAO()
        objVocTable = objBaseDAO.ExecuteQuery(strSQL)

        Return objVocTable
    End Function

    ''' <summary>
    ''' Get Table Vocabulary by TopicGroup and Toptic
    ''' </summary>
    ''' <param name="strTopicGroupName"> Topic Group Name</param>
    ''' <param name="strTopicName"> Topic Name</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetVocTableByKanji(ByVal strTopicGroupName As String, ByVal strTopicName As String, ByVal strKanji As String) As DataTable
        Dim objVocTable As DataTable
        Dim strSQL As String
        Dim objBaseDAO As BaseDAO
        'init
        objVocTable = New DataTable()
        strSQL = Constants_LanhVC.STR_BLANK_VALUE
        objBaseDAO = Nothing

        'set value for SQL
        strSQL = String.Format(Constants_LanhVC.STR_SQL_VOC_GETDATATABLE_KANJI, strTopicGroupName, strTopicName, strKanji)

        'get datatable of voc
        objBaseDAO = New BaseDAO()
        objVocTable = objBaseDAO.ExecuteQuery(strSQL)

        Return objVocTable
    End Function

    ''' <summary>
    ''' Delete Vocabulary by ID
    ''' </summary>
    ''' <param name="objVocEntity">Content ID of Voc</param>
    ''' <remarks></remarks>
    Public Sub DeleteVocabulary(ByVal objVocEntity As VocabulariesEntity)
        Dim strSQL As String
        Dim objBaseDAO As BaseDAO

        'init
        strSQL = Constants_LanhVC.STR_BLANK_VALUE
        objBaseDAO = Nothing

        'set value for SQL
        strSQL = String.Format(Constants_LanhVC.STR_SQL_VOC_DELETE_VOC, objVocEntity.VocID)

        'delete voc
        objBaseDAO = New BaseDAO()
        objBaseDAO.ExecuteNonQuery(strSQL)

    End Sub

    ''' <summary>
    ''' Check exist of 1 vocabulary in database
    ''' </summary>
    ''' <param name="strHigarana"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CheckExist(ByVal strHigarana As String) As DataTable

        Dim objVocTable As DataTable
        Dim strSQL As String
        Dim objBaseDAO As BaseDAO

        'init
        objVocTable = New DataTable()
        strSQL = Constants_LanhVC.STR_BLANK_VALUE
        objBaseDAO = Nothing

        'set value for SQL
        strSQL = String.Format(Constants_LanhVC.STR_SQL_VOC_CHECK_EXIST, Utils.Replace(strHigarana)) 'strHigarana

        'get datatable of voc
        objBaseDAO = New BaseDAO()
        objVocTable = objBaseDAO.ExecuteQuery(strSQL)

        Return objVocTable

    End Function

    ''' <summary>
    '''  Check exist of 1 vocabulary in database
    ''' </summary>
    ''' <param name="strHigarana"></param>
    ''' <param name="intTopicID"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CheckExist(ByVal strHigarana As String, ByVal intTopicID As Integer) As DataTable

        Dim objVocTable As DataTable
        Dim strSQL As String
        Dim objBaseDAO As BaseDAO

        'init
        objVocTable = New DataTable()
        strSQL = Constants_LanhVC.STR_BLANK_VALUE
        objBaseDAO = Nothing

        'set value for SQL
        strSQL = String.Format(Constants_LanhVC.STR_SQL_VOC_CHECK_EXIST_IN_TOPIC, Utils.Replace(strHigarana), intTopicID) 'strHigarana

        'get datatable of voc
        objBaseDAO = New BaseDAO()
        objVocTable = objBaseDAO.ExecuteQuery(strSQL)

        Return objVocTable

    End Function

    ''' <summary>
    '''  Check exist of 1 vocabulary in database
    ''' </summary>
    ''' <param name="strHigarana"></param>
    ''' <param name="intTopicID"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CheckExist(ByVal strHigarana As String, ByVal strKanji As String, ByVal intTopicID As Integer) As DataTable

        Dim objVocTable As DataTable
        Dim strSQL As String
        Dim objBaseDAO As BaseDAO

        'init
        objVocTable = New DataTable()
        strSQL = Constants_LanhVC.STR_BLANK_VALUE
        objBaseDAO = Nothing

        'set value for SQL
        strSQL = String.Format(Constants_LanhVC.STR_SQL_VOC_CHECK_EXIST_IN_TOPIC2, Utils.Replace(strHigarana), Utils.Replace(strKanji), intTopicID)

        'get datatable of voc
        objBaseDAO = New BaseDAO()
        objVocTable = objBaseDAO.ExecuteQuery(strSQL)

        Return objVocTable

    End Function


    ''' <summary>
    '''  Check exist of 1 vocabulary in database
    ''' </summary>
    ''' <param name="strHigarana"></param>
    ''' <param name="intTopicID"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CheckExist(ByVal strKanji As String, ByVal intGroupID As Integer, ByVal intTopicID As Integer) As DataTable

        Dim objVocTable As DataTable
        Dim strSQL As String
        Dim objBaseDAO As BaseDAO

        'init
        objVocTable = New DataTable()
        strSQL = Constants_LanhVC.STR_BLANK_VALUE
        objBaseDAO = Nothing

        'set value for SQL
        strSQL = String.Format(Constants_LanhVC.STR_SQL_VOC_CHECK_EXIST_IN_TOPIC3, Utils.Replace(strKanji), intTopicID)

        'get datatable of voc
        objBaseDAO = New BaseDAO()
        objVocTable = objBaseDAO.ExecuteQuery(strSQL)

        Return objVocTable

    End Function




    ''' <summary>
    ''' Search Vocabulary
    ''' </summary>    
    ''' <remarks></remarks>
    Public Function SearchVocabulary(ByVal SearchFollow As String, ByVal Topic_Group_ID As Int32, ByVal txtInputKeyword As String, ByVal Topic_Name As String) As DataTable
        Dim strSQL As String
        Dim objBaseDAO As BaseDAO
        Dim objVocTable As DataTable

        'init
        objVocTable = New DataTable()
        strSQL = Constants_LanhVC.STR_BLANK_VALUE
        objBaseDAO = Nothing

        'set value for SQL
        Select Case SearchFollow
            Case "Hiragana/Katakana"
                strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_HIRAGANA, _
                                Topic_Group_ID, _
                                Utils.Replace(txtInputKeyword), _
                                Utils.Replace(Topic_Name))
            Case "Kanji"
                strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_KANJI, _
                                Topic_Group_ID, _
                                Utils.Replace(txtInputKeyword), _
                                Utils.Replace(Topic_Name))
            Case "Meaning"
                strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_MEANING, _
                                Topic_Group_ID, _
                                Utils.Replace(txtInputKeyword), _
                                Utils.Replace(Topic_Name))
        End Select

        'get datatable of voc
        objBaseDAO = New BaseDAO()
        objVocTable = objBaseDAO.ExecuteQuery(strSQL)
        Return objVocTable
    End Function


    Public Sub UpdateVocabulary(ByVal objVocEntity As VocabulariesEntity)

        Dim strSQL As String
        Dim objBaseDAO As BaseDAO

        'init
        strSQL = Constants_LanhVC.STR_BLANK_VALUE
        objBaseDAO = Nothing

        'set value for SQL
        '<<<QuanTDA: correct the strSQL>>>
        '<<<Date: 07 Sep 2009>>>
        '<<<Reason: Example of the Vocabulary was added to Update statement>>>
        '<<<but not in this strSQL Format>>>
        strSQL = String.Format(Constants_LanhVC.STR_SQL_VOC_UpdateByID, _
                                Utils.Replace(objVocEntity.Hiragana), _
                                Utils.Replace(objVocEntity.Kanji), _
                                Utils.Replace(objVocEntity.Hannom), _
                                Utils.Replace(objVocEntity.Meaning), _
                                Utils.Replace(objVocEntity.Example), _
                                Utils.Replace(objVocEntity.Type), _
                                objVocEntity.TopicID, _
                                objVocEntity.VocID)
        '<<<End QuanTDA: correct the strSQL>>>

        'get datatable of voc
        objBaseDAO = New BaseDAO()
        objBaseDAO.ExecuteNonQuery(strSQL)

    End Sub

End Class
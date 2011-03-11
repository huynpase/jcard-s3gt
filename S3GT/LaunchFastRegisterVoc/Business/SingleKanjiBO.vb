Public Class SingleKanjiBO

    ''' <summary>
    ''' Add new single kanji into database
    ''' </summary>
    ''' <param name="objSingleKanjiEntity">data of single kanji</param>
    ''' <returns>new value of single kanji</returns>
    ''' <remarks>Have ID of single kanji</remarks>
    Public Function AddNew(ByVal objSingleKanjiEntity As SingleKanjiEntity) As SingleKanjiEntity
        Dim objSingleKanjiDAO As SingleKanjiDAO

        'init
        objSingleKanjiDAO = New SingleKanjiDAO()
        objSingleKanjiEntity = objSingleKanjiDAO.AddNew(objSingleKanjiEntity)

        Return objSingleKanjiEntity
    End Function

    ''' <summary>
    ''' Delete Single Kanji by ID
    ''' </summary>
    ''' <param name="objSingleKanjiEntity">Content ID of Single Kanji</param>
    ''' <remarks></remarks>
    Public Sub DeleteSingleKanji(ByVal objSingleKanjiEntity As SingleKanjiEntity)
        Dim objSingleKanjiDAO As SingleKanjiDAO

        'init
        objSingleKanjiDAO = New SingleKanjiDAO()

        objSingleKanjiDAO.DeleteSingleKanji(objSingleKanjiEntity)
    End Sub
    Public Sub UpdateSingleKanji(ByVal objSingleKanjiEntity As SingleKanjiEntity)
        Dim objSingleKanjiDAO As SingleKanjiDAO

        'init
        objSingleKanjiDAO = New SingleKanjiDAO()

        objSingleKanjiDAO.UpdateSingleKanji(objSingleKanjiEntity)
    End Sub
    Public Function CopyDataToEntityFromDataGrid(ByVal Kanji As String, ByVal HanNom As String, ByVal Kun As String, _
                    ByVal Onyomi As String, ByVal Meaning As String)
        Dim objSingleKanjiEntity As SingleKanjiEntity

        'init
        objSingleKanjiEntity = New SingleKanjiEntity()

        objSingleKanjiEntity.Kanji = Kanji
        objSingleKanjiEntity.HanNom = HanNom
        objSingleKanjiEntity.Kunyomi = Kun
        objSingleKanjiEntity.Onyomi = Onyomi
        objSingleKanjiEntity.Meaning = Meaning

        Return objSingleKanjiEntity
    End Function
    'PhatLS's Code
    ''' <summary>
    ''' Get table of all rows of Single Kanji match as input key Kunyomi.
    ''' </summary>
    ''' <returns>DataTable - table of all Single Kanji match as input key Kunyomi</returns>
    ''' <remarks>Here we use Datatable as return data to facilitate the filter on table rows following some criteria
    ''' without requery from database.</remarks>
    Public Function GetKanjiTable(ByVal strSQL As String) As DataTable
        Dim vocTable As New DataTable
        Dim objVocDAO As SingleKanjiDAO

        'init
        objVocDAO = New SingleKanjiDAO()
        vocTable = objVocDAO.GetSingleKanjiTable(strSQL)
        Return vocTable
    End Function    'PhatLS's Code
End Class

Public Class VocabulariesBO


    ''' <summary>
    ''' Add new vocabulary into database
    ''' </summary>
    ''' <param name="objVocEntity">data of vocabulary</param>
    ''' <returns>new value of vocabulary</returns>
    ''' <remarks>Have ID of vocabulary</remarks>
    Public Function AddNew(ByVal objVocEntity As VocabulariesEntity) As VocabulariesEntity
        Dim objVocDAO As VocabularyDAO

        'init
        objVocDAO = New VocabularyDAO()
        objVocEntity = objVocDAO.AddNew(objVocEntity)

        Return objVocEntity
    End Function

    'QuanTDA's Code
    ''' <summary>
    ''' Get all rows in the Vocabularies Table.
    ''' Here the returned parameter is a Datatable to facilitating filtering on table rows
    ''' </summary>
    ''' <returns>Data table of Vocabularies</returns>
    ''' <remarks></remarks>
    Public Function GetVocabulariesTable() As DataTable
        Dim vocTable As New DataTable
        Dim objVocDAO As VocabularyDAO

        'init
        objVocDAO = New VocabularyDAO()
        'vocTable.DefaultView.RowFilter = ""
        vocTable = objVocDAO.GetVocabulariesTable()
        Return vocTable
    End Function
    'End QuanTDA's Code


    ''' <summary>
    ''' Get Table Vocabulary by TopicGroup and Toptic
    ''' </summary>
    ''' <param name="intTopicID">Content ID of Topc</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetVocTableByTopic(ByVal intTopicID As Integer) As DataTable
        Dim vocTable As New DataTable
        Dim objVocDAO As VocabularyDAO

        'init
        objVocDAO = New VocabularyDAO()
        'vocTable.DefaultView.RowFilter = ""
        vocTable = objVocDAO.GetVocTableByTopic(intTopicID)
        Return vocTable

    End Function


    ''' <summary>
    ''' Get Table Vocabulary by TopicGroupName, TopicName,  Kanji
    ''' </summary>
    ''' <param name="strTopicGroupName"></param>
    ''' <param name="strTopicName"></param>
    ''' <param name="strKanji"></param>
    ''' <returns>list Voc</returns>
    ''' <remarks></remarks>
    Public Function GetVocTableByKanji(ByVal strTopicGroupName As String, ByVal strTopicName As String, ByVal strKanji As String) As DataTable
        Dim vocTable As New DataTable
        Dim objVocDAO As VocabularyDAO

        'init
        objVocDAO = New VocabularyDAO()
        'vocTable.DefaultView.RowFilter = ""
        vocTable = objVocDAO.GetVocTableByKanji(strTopicGroupName, strTopicName, strKanji)
        Return vocTable

    End Function


    ''' <summary>
    ''' Delete Vocabulary by ID
    ''' </summary>
    ''' <param name="objVocEntity">Content ID of Voc</param>
    ''' <remarks></remarks>
    Public Sub DeleteVocabulary(ByVal objVocEntity As VocabulariesEntity)
        Dim objVocDAO As VocabularyDAO

        'init
        objVocDAO = New VocabularyDAO()

        objVocDAO.DeleteVocabulary(objVocEntity)
    End Sub

    Public Function CheckExist(ByVal strHigarana As String) As DataTable
        Dim vocTable As New DataTable
        Dim objVocDAO As VocabularyDAO

        'init
        objVocDAO = New VocabularyDAO()

        vocTable = objVocDAO.CheckExist(strHigarana)

        Return vocTable
    End Function


    Public Function CheckExist(ByVal strHigarana As String, ByVal intTopicID As Integer) As DataTable
        Dim vocTable As New DataTable
        Dim objVocDAO As VocabularyDAO

        'init
        objVocDAO = New VocabularyDAO()

        vocTable = objVocDAO.CheckExist(strHigarana, intTopicID)

        Return vocTable
    End Function

    Public Function CheckExist(ByVal strHigarana As String, ByVal strKanji As String, ByVal intTopicID As Integer) As DataTable
        Dim vocTable As New DataTable
        Dim objVocDAO As VocabularyDAO

        'init
        objVocDAO = New VocabularyDAO()

        vocTable = objVocDAO.CheckExist(strHigarana, strKanji, intTopicID)

        Return vocTable

    End Function

    Public Function CheckExist(ByVal strKanji As String, ByVal intTopicGroupID As Integer, ByVal intTopicID As Integer) As DataTable
        Dim vocTable As New DataTable
        Dim objVocDAO As VocabularyDAO

        'init
        objVocDAO = New VocabularyDAO()

        vocTable = objVocDAO.CheckExist(strKanji, intTopicGroupID, intTopicID)

        Return vocTable

    End Function

    Public Function CheckExistUpdate(ByVal dataVocabulary As DataGridView, ByVal intRow As Integer) As Boolean
        Dim i As Integer

        For i = 0 To dataVocabulary.Rows.Count - 1
            If i <> intRow And dataVocabulary.Rows(i).Cells(Constants_LanhVC.INT_VOC_COLUMN_HIGARANA).Value = _
                            dataVocabulary.Rows(intRow).Cells(Constants_LanhVC.INT_VOC_COLUMN_HIGARANA).Value Then
                Return True
            End If
        Next

        Return False
    End Function



    Public Sub UpdateVocabulary(ByVal objVocEntity As VocabulariesEntity)
        Dim objVocDAO As VocabularyDAO

        'init
        objVocDAO = New VocabularyDAO()

        objVocDAO.UpdateVocabulary(objVocEntity)
    End Sub


    ''' <summary>
    ''' Copy 1 record (thu intID) from grid to entity
    ''' </summary>
    ''' <param name="dataVocabulary">datagrid</param>
    ''' <param name="intID">ID of record</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CopyDataToEntityFromDataGrid(ByVal dataVocabulary As DataGridView, ByVal intID As Int32)
        Dim objVocEntity As VocabulariesEntity

        'init
        objVocEntity = New VocabulariesEntity()
        'chua co copy Topic ID
        objVocEntity.TopicID = -1

        objVocEntity.Kanji = Utils.ObjectToString(dataVocabulary.Rows(intID).Cells(Constants_LanhVC.INT_VOC_COLUMN_KANJI).Value)
        objVocEntity.Hiragana = Utils.ObjectToString(dataVocabulary.Rows(intID).Cells(Constants_LanhVC.INT_VOC_COLUMN_HIGARANA).Value)
        objVocEntity.Hannom = Utils.ObjectToString(dataVocabulary.Rows(intID).Cells(Constants_LanhVC.INT_VOC_COLUMN_HANNOM).Value)
        objVocEntity.Meaning = Utils.ObjectToString(dataVocabulary.Rows(intID).Cells(Constants_LanhVC.INT_VOC_COLUMN_MEANING).Value)
        objVocEntity.Type = Utils.GetType_IntFromText(dataVocabulary.Rows(intID).Cells(Constants_LanhVC.INT_VOC_COLUMN_TYPE).Value)
        objVocEntity.VocID = dataVocabulary.Rows(intID).Cells(Constants_LanhVC.INT_VOC_COLUMN_VOCID).Value

        Return objVocEntity
    End Function

End Class

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
    'Public Function GetVocTableByTopic(ByVal intTopicID As Integer, ByRef hasNext As Boolean, _
    '         ByRef hasPrevious As Boolean, ByVal intOrder As Integer) As DataTable
    '    Dim temVocTable As New DataTable
    '    Dim vocTable As New DataTable
    '    Dim objVocDAO As VocabularyDAO
    '    Dim index As Integer
    '    Dim total As Integer

    '    'init
    '    objVocDAO = New VocabularyDAO()
    '    'vocTable.DefaultView.RowFilter = ""

    '    temVocTable = objVocDAO.Get_100_VocTableByTopic(intTopicID)

    '    If (intOrder > 0) Then
    '        hasPrevious = True
    '    Else
    '        hasPrevious = False
    '    End If

    '    If temVocTable.Rows.Count > Constants_LanhVC.INT_NUM_PER_PAGE * (intOrder + 1) Then
    '        hasNext = True
    '    Else
    '        hasNext = False
    '    End If

    '    total = temVocTable.Rows.Count

    '    For index = Constants_LanhVC.INT_NUM_PER_PAGE * (intOrder + 1) + 1 To total
    '        temVocTable.Rows.RemoveAt(temVocTable.Rows.Count)
    '    Next

    '    For index = 1 To Constants_LanhVC.INT_NUM_PER_PAGE * intOrder
    '        temVocTable.Rows.RemoveAt(0)
    '    Next

    '    Return vocTable

    'End Function
    Public Function GetVocTableByTopic(ByVal intTopicID As Integer, ByRef hasNext As Boolean, _
         ByRef hasPrevious As Boolean, ByVal intOrder As Integer) As DataTable
        Dim vocTable As New DataTable
        Dim objVocDAO As VocabularyDAO

        'init
        objVocDAO = New VocabularyDAO()
        'vocTable.DefaultView.RowFilter = ""

        vocTable = objVocDAO.Get_100_VocTableByTopic(intTopicID)

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


    Public Function CheckExist(ByVal strHigarana As String, ByVal strKanji As String, ByVal intTopicID As Integer) As DataTable
        Dim vocTable As New DataTable
        Dim objVocDAO As VocabularyDAO

        'init
        objVocDAO = New VocabularyDAO()
        vocTable = objVocDAO.CheckExist(strHigarana, strKanji, intTopicID)
        Return vocTable
    End Function

    Public Function CheckExist(ByVal dataVocabulary As DataGridView, ByVal intRow As Integer, ByVal TopicID As Integer) As DataTable
        Dim VocTable As New DataTable
        Dim i As Integer

        VocTable.Columns.Add("VocID", System.Type.GetType("System.String"))
        VocTable.Columns.Add("TopicID", System.Type.GetType("System.String"))
        VocTable.Columns.Add("Hiragana", System.Type.GetType("System.String"))
        VocTable.Columns.Add("Kanji", System.Type.GetType("System.String"))
        VocTable.Columns.Add("HanNom", System.Type.GetType("System.String"))
        VocTable.Columns.Add("Meaning", System.Type.GetType("System.String"))
        VocTable.Columns.Add("Type", System.Type.GetType("System.String"))
        VocTable.Columns.Add("Example", System.Type.GetType("System.String"))
        For i = 0 To dataVocabulary.Rows.Count - 1
            If i <> intRow And dataVocabulary.Rows(i).Cells(Constants_LanhVC.INT_VOC_COLUMN_HIGARANA).Value = _
                            dataVocabulary.Rows(intRow).Cells(Constants_LanhVC.INT_VOC_COLUMN_HIGARANA).Value _
                            And dataVocabulary.Rows(i).Cells(Constants_LanhVC.INT_VOC_COLUMN_KANJI).Value = _
                            dataVocabulary.Rows(intRow).Cells(Constants_LanhVC.INT_VOC_COLUMN_KANJI).Value Then
                VocTable.Rows.Add(dataVocabulary.Rows(i).Cells(Constants_LanhVC.INT_VOC_COLUMN_VOCID).Value, _
                                TopicID, dataVocabulary.Rows(i).Cells(Constants_LanhVC.INT_VOC_COLUMN_HIGARANA).Value, _
                                dataVocabulary.Rows(i).Cells(Constants_LanhVC.INT_VOC_COLUMN_KANJI).Value, _
                                dataVocabulary.Rows(i).Cells(Constants_LanhVC.INT_VOC_COLUMN_HANNOM).Value, _
                                dataVocabulary.Rows(i).Cells(Constants_LanhVC.INT_VOC_COLUMN_MEANING).Value, _
                                Utils.GetType_IntFromText(dataVocabulary.Rows(i).Cells(Constants_LanhVC.INT_VOC_COLUMN_TYPE).Value), _
                                dataVocabulary.Rows(i).Cells(Constants_LanhVC.INT_VOC_COLUMN_EXAMPLE).Value)
            End If
        Next
        Return VocTable
    End Function

    Public Function CheckExistUpdate(ByVal dataVocabulary As DataGridView, ByVal intRow As Integer) As Boolean
        Dim i As Integer

        For i = 0 To dataVocabulary.Rows.Count - 1
            If i <> intRow And dataVocabulary.Rows(i).Cells(Constants_LanhVC.INT_VOC_COLUMN_HIGARANA).Value = _
                            dataVocabulary.Rows(intRow).Cells(Constants_LanhVC.INT_VOC_COLUMN_HIGARANA).Value _
                            And dataVocabulary.Rows(i).Cells(Constants_LanhVC.INT_VOC_COLUMN_KANJI).Value = _
                            dataVocabulary.Rows(intRow).Cells(Constants_LanhVC.INT_VOC_COLUMN_KANJI).Value Then
                Return True
            End If
        Next

        Return False
    End Function

    Public Function CheckExistUpdate_SearchForm(ByVal objVocEntity As VocabulariesEntity) As Boolean
        Dim objVocDAO As VocabularyDAO
        'init
        objVocDAO = New VocabularyDAO()
        If objVocDAO.CheckVocDupDAO(objVocEntity) Then
            Return True
        End If
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
        objVocEntity.Example = Utils.ObjectToString(dataVocabulary.Rows(intID).Cells(Constants_LanhVC.INT_VOC_COLUMN_EXAMPLE).Value)



        Return objVocEntity
    End Function

    Public Function CopyDataToEntityFromDataGrid_SearchForm(ByVal dataVocabulary As DataGridView, ByVal intID As Int32)
        Dim objVocEntity As VocabulariesEntity

        'init
        objVocEntity = New VocabulariesEntity()
        'chua co copy Topic ID
        objVocEntity.TopicID = -1

        objVocEntity.Kanji = Utils.ObjectToString(dataVocabulary.Rows(intID).Cells(Constants_LanhVC.INT_VOC_SEARCH_COLUMN_KANJI).Value)
        objVocEntity.Hiragana = Utils.ObjectToString(dataVocabulary.Rows(intID).Cells(Constants_LanhVC.INT_VOC_SEARCH_COLUMN_HIGARANA).Value)
        objVocEntity.Hannom = Utils.ObjectToString(dataVocabulary.Rows(intID).Cells(Constants_LanhVC.INT_VOC_SEARCH_COLUMN_HANNOM).Value)
        objVocEntity.Meaning = Utils.ObjectToString(dataVocabulary.Rows(intID).Cells(Constants_LanhVC.INT_VOC_SEARCH_COLUMN_MEANING).Value)
        objVocEntity.Type = Utils.GetType_IntFromText(dataVocabulary.Rows(intID).Cells(Constants_LanhVC.INT_VOC_SEARCH_COLUMN_TYPE).Value)
        objVocEntity.VocID = dataVocabulary.Rows(intID).Cells(Constants_LanhVC.INT_VOC_SEARCH_COLUMN_VOCID).Value
        objVocEntity.Example = Utils.ObjectToString(dataVocabulary.Rows(intID).Cells(Constants_LanhVC.INT_VOC_SEARCH_COLUMN_EXAMPLE).Value)



        Return objVocEntity
    End Function

    Public Function GetExistingVoc(ByVal objVocEntity As VocabulariesEntity) As DataTable
        Dim objVocDAO As VocabularyDAO

        'init
        objVocDAO = New VocabularyDAO()
        Return objVocDAO.GetExistingVocDAO(objVocEntity)
    End Function

End Class

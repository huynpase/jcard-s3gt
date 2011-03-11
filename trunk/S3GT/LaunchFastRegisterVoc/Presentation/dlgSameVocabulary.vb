Imports System.Windows.Forms



Public Class dlgSameVocabulary

    Dim intNewRow As Integer

    Private strTopicName As String
    Private strTopicGroupName As String
    Private isSkippedAction As Boolean = False
    Public Property ActionIsSkipped() As Boolean
        Get
            Return isSkippedAction
        End Get
        Set(ByVal value As Boolean)
            isSkippedAction = value
        End Set
    End Property

    Public Property TopicName() As String
        Get
            Return strTopicName
        End Get
        Set(ByVal value As String)
            strTopicName = value
        End Set
    End Property


    Public Property TopicGroupName() As String
        Get
            Return strTopicGroupName
        End Get
        Set(ByVal value As String)
            strTopicGroupName = value
        End Set
    End Property


    Dim vocInProcessingEntity As VocabulariesEntity
    ''' <summary>
    ''' set text for message content
    ''' </summary>
    ''' <param name="strValue">message content</param>
    ''' <remarks></remarks>
    Public Sub SetTextForTextbox(ByVal strValue As String)
        lblMessageContent.Text = strValue
    End Sub

    Public Sub New(ByVal dataSourceVocabulary As DataGridViewRowCollection, ByVal intID As Int32, ByVal objVocTable As DataTable)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'Dim arrSameVocabulary As ArrayList
        'Dim i As Int32

        'arrSameVocabulary = Utils.GetSameVocabulary(dataSourceVocabulary)

        ''if have Same vocabulary
        'If arrSameVocabulary.Count > 0 Then
        '    dataVocabulary.Rows.Clear()
        '    'set text color is red
        '    For i = 0 To arrSameVocabulary.Count - 1
        '        'dataVocabulary.Rows(arrSameVocabulary.Item(i)).DefaultCellStyle.ForeColor = Color.Red
        '        dataVocabulary.Rows.Add(dataSourceVocabulary.Item(arrSameVocabulary(i)).Cells(0).Value, _
        '                            dataSourceVocabulary.Item(arrSameVocabulary(i)).Cells(1).Value, _
        '                            dataSourceVocabulary.Item(arrSameVocabulary(i)).Cells(2).Value, _
        '                            dataSourceVocabulary.Item(arrSameVocabulary(i)).Cells(3).Value, _
        '                            dataSourceVocabulary.Item(arrSameVocabulary(i)).Cells(4).Value)
        '    Next
        'End If


        Dim i As Integer
        Dim strTypeText As String

        dataVocabulary.Rows.Add(dataSourceVocabulary.Item(intID).Cells(0).Value, _
                                    dataSourceVocabulary.Item(intID).Cells(1).Value, _
                                    dataSourceVocabulary.Item(intID).Cells(2).Value, _
                                    dataSourceVocabulary.Item(intID).Cells(3).Value, _
                                    dataSourceVocabulary.Item(intID).Cells(4).Value)

        intNewRow = dataVocabulary.Rows.Count

        For i = 0 To objVocTable.Rows.Count - 1
            strTypeText = Utils.GetType_TextFromInt(objVocTable.Rows(i)(Constants_LanhVC.INT_VOC_DB_COLUMN_TYPE))
            dataVocabulary.Rows.Add(Constants_LanhVC.INT_CHECK, _
                                    objVocTable.Rows(i)(Constants_LanhVC.INT_VOC_DB_COLUMN_KANJI), _
                                    objVocTable.Rows(i)(Constants_LanhVC.INT_VOC_DB_COLUMN_HIGARANA), _
                                    objVocTable.Rows(i)(Constants_LanhVC.INT_VOC_DB_COLUMN_HANNOM), _
                                    objVocTable.Rows(i)(Constants_LanhVC.INT_VOC_DB_COLUMN_MEANING), _
                                    strTypeText)
        Next

        lblMessageContent.Text = Constants_LanhVC.STR_MSG_ERR_003

    End Sub
    'QuanTDA's Code
    ''' <summary>
    ''' Define new Dialog of Vocabularies having same Hiragana
    ''' </summary>
    ''' <param name="vocabularyEntity">Vocabulary in processing</param>
    ''' <param name="objSameHiraganaVocTable">List of Vocabularies having same Hiragana as Vocabulary in processing</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal vocabularyEntity As VocabulariesEntity, ByVal objSameHiraganaVocTable As DataTable) 'ByVal sameHiraganaVocView As DataView)
        Dim i As Integer
        Dim dataSameHiraTable As New DataTable
        Dim vocBO As New VocabulariesBO
        dataSameHiraTable = vocBO.GetVocabulariesTable

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        'init
        Me.vocInProcessingEntity = vocabularyEntity
        Dim strTypeText = Utils.GetType_TextFromInt(vocabularyEntity.Type)
        dataVocabulary.Rows.Add(Constants_LanhVC.INT_CHECK, _
                                    vocInProcessingEntity.Kanji, _
                                    vocInProcessingEntity.Hiragana, _
                                    vocInProcessingEntity.Hannom, _
                                    vocInProcessingEntity.Meaning, _
                                    strTypeText)
        intNewRow = dataVocabulary.Rows.Count
        'set list of Vocabularies having same Hiragana as the Vocabulary in processing
        'dataVocabulary.datagr = sameHiraganaVocView
        'For i = 0 To sameHiraganaVocView.Count - 1
        'dataVocabulary.Rows(arrSameVocabulary.Item(i)).DefaultCellStyle.ForeColor = Color.Red
        'dataVocabulary.Rows.Add(sameHiraganaVocView.Item(i).Item(1), _
        '                    sameHiraganaVocView.Item(i).Item(2), _
        '                    sameHiraganaVocView.Item(i).Item(3), _
        '                    sameHiraganaVocView.Item(i).Item(4))

        'Next
        'Dim dataSameHiraView As DataView = dataSameHiraTable.DefaultView
        'dataSameHiraView.RowFilter = "Hiragana='" & vocabularyEntity.Hiragana & "'"
        'dataVocabulary.DataSource = dataSameHiraView
        For i = 0 To objSameHiraganaVocTable.Rows.Count - 1
            strTypeText = Utils.GetType_TextFromInt(objSameHiraganaVocTable.Rows(i)(Constants_LanhVC.INT_VOC_DB_COLUMN_TYPE))
            dataVocabulary.Rows.Add(Constants_LanhVC.INT_CHECK, _
                                    objSameHiraganaVocTable.Rows(i)(Constants_LanhVC.INT_VOC_DB_COLUMN_KANJI), _
                                    objSameHiraganaVocTable.Rows(i)(Constants_LanhVC.INT_VOC_DB_COLUMN_HIGARANA), _
                                    objSameHiraganaVocTable.Rows(i)(Constants_LanhVC.INT_VOC_DB_COLUMN_HANNOM), _
                                    objSameHiraganaVocTable.Rows(i)(Constants_LanhVC.INT_VOC_DB_COLUMN_MEANING), _
                                    strTypeText)
        Next

        lblMessageContent.Text = Constants_LanhVC.STR_MSG_ERR_003
    End Sub
    'QuanTDA's Code

    'Public Function GetSameVocabulary(ByVal dataSourceSameVocabulary As DataGridViewRowCollection)
    '    Dim arrSameVocabulary As New ArrayList
    '    'Dim arrResult As ArrayList
    '    Dim bFirst As Boolean = True

    '    Dim i, j As Int32

    '    For i = 0 To dataSourceSameVocabulary.Count - 1
    '        For j = i + 1 To dataSourceSameVocabulary.Count - 2
    '            If dataSourceSameVocabulary.Item(i).Cells(1).Value = dataSourceSameVocabulary.Item(j).Cells(1).Value Then
    '                arrSameVocabulary.Add(i)
    '                arrSameVocabulary.Add(j)
    '            End If
    '        Next
    '    Next

    '    arrSameVocabulary.Sort()
    '    Dim arrResult As New ArrayList(arrSameVocabulary)
    '    i = 0
    '    Do While i < arrSameVocabulary.Count - 1
    '        If arrSameVocabulary.Item(i) = arrSameVocabulary.Item(i + 1) Then
    '            arrSameVocabulary.RemoveAt(i)
    '            i = i - 1
    '        End If
    '        i = i + 1
    '    Loop
    '    arrResult = arrSameVocabulary
    '    Return arrResult
    'End Function


    Private Function ProcessSameVocabulary(ByVal intType As Integer)
        Dim objDataTableVOC As DataTable
        Dim intResult As Integer
        Dim objVocBO As VocabulariesBO
        Dim objVocEntity As VocabulariesEntity
        Dim objTopicBO As TopicsBO
        Dim i, j As Integer
        Dim intTopicID As Integer

        'init
        intResult = 1
        objDataTableVOC = Nothing

        Try
            'get list Voc 
            objVocBO = New VocabulariesBO()
            objDataTableVOC = objVocBO.GetVocabulariesTable()
            objVocEntity = New VocabulariesEntity()
            objTopicBO = New TopicsBO()

            'check & get list voc same with voc input
            For i = 0 To intNewRow - 1

                'lay danh sach cac tu vung trung nhau
                If Not vocInProcessingEntity Is Nothing Then
                    intTopicID = vocInProcessingEntity.TopicID
                Else
                    intTopicID = objTopicBO.GetTopicID(strTopicGroupName, strTopicName)
                End If
                
                objDataTableVOC = objVocBO.CheckExist(dataVocabulary.Rows(i).Cells(Constants_LanhVC.INT_VOC_COLUMN_HIGARANA).Value, intTopicID)
                

                If objDataTableVOC.Rows.Count > 0 Then

                    For j = 0 To objDataTableVOC.Rows.Count - 1
                        'neu co check tren check box
                        If dataVocabulary.Rows(intNewRow + j).Cells(Constants_LanhVC.INT_VOC_COLUMN_CHECKBOX).Value Then

                            objVocEntity = CopyDataFromTableToEntity(objDataTableVOC, j)
                            Select Case intType
                                Case Constants_LanhVC.INT_OVERRIDE
                                    objVocEntity.Kanji = dataVocabulary.Rows(i).Cells(Constants_LanhVC.INT_VOC_COLUMN_KANJI).Value
                                    objVocEntity.Hiragana = dataVocabulary.Rows(i).Cells(Constants_LanhVC.INT_VOC_COLUMN_HIGARANA).Value
                                    objVocEntity.Hannom = dataVocabulary.Rows(i).Cells(Constants_LanhVC.INT_VOC_COLUMN_HANNOM).Value
                                    objVocEntity.Meaning = dataVocabulary.Rows(i).Cells(Constants_LanhVC.INT_VOC_COLUMN_MEANING).Value
                                    objVocEntity.Type = Utils.GetType_IntFromText(dataVocabulary.Rows(i).Cells(Constants_LanhVC.INT_VOC_COLUMN_TYPE).Value)
                                    objVocBO.UpdateVocabulary(objVocEntity)

                                Case Constants_LanhVC.INT_MERGE_KANJI
                                    objVocEntity.Kanji = objVocEntity.Kanji + Constants_LanhVC.STR_COMMA_VALUE + _
                                                                                dataVocabulary.Rows(i).Cells(Constants_LanhVC.INT_VOC_COLUMN_KANJI).Value
                                    objVocBO.UpdateVocabulary(objVocEntity)

                                Case Constants_LanhVC.INT_MERGE_MEANING
                                    objVocEntity.Meaning = objVocEntity.Meaning + Constants_LanhVC.STR_COMMA_VALUE + _
                                                                                    dataVocabulary.Rows(i).Cells(Constants_LanhVC.INT_VOC_COLUMN_MEANING).Value
                                    objVocBO.UpdateVocabulary(objVocEntity)

                                Case Constants_LanhVC.INT_CREATE_NEW
                                    objVocEntity.Kanji = dataVocabulary.Rows(i).Cells(Constants_LanhVC.INT_VOC_COLUMN_KANJI).Value
                                    objVocEntity.Hiragana = dataVocabulary.Rows(i).Cells(Constants_LanhVC.INT_VOC_COLUMN_HIGARANA).Value
                                    objVocEntity.Hannom = dataVocabulary.Rows(i).Cells(Constants_LanhVC.INT_VOC_COLUMN_HANNOM).Value
                                    objVocEntity.Meaning = dataVocabulary.Rows(i).Cells(Constants_LanhVC.INT_VOC_COLUMN_MEANING).Value
                                    objVocEntity.Type = Utils.GetType_IntFromText(dataVocabulary.Rows(i).Cells(Constants_LanhVC.INT_VOC_COLUMN_TYPE).Value)
                                    objVocBO.AddNew(objVocEntity)

                                Case Constants_LanhVC.INT_SKIP
                                    'nothing to do
                                    'MessageBox.Show("Selete Skip")
                            End Select
                        End If
                    Next
                End If
            Next
        Catch ex As Exception
            intResult = 0
        Finally
            'Me.Close()
        End Try
        Return intResult
    End Function


    ''' <summary>
    ''' Copy 1 record in datatable to Voc Entity 
    ''' </summary>
    ''' <param name="objDataTableVOC">datatable of Voc exist in database</param>
    ''' <param name="intID"> ID of voc in datatable</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function CopyDataFromTableToEntity(ByVal objDataTableVOC As DataTable, ByVal intID As Integer)
        Dim objEntityVOC As VocabulariesEntity

        'init
        objEntityVOC = New VocabulariesEntity()

        objEntityVOC.VocID = objDataTableVOC.Rows(intID)(Constants_LanhVC.INT_VOC_DB_COLUMN_VOCID)
        objEntityVOC.TopicID = objDataTableVOC.Rows(intID)(Constants_LanhVC.INT_VOC_DB_COLUMN_TOPICID)
        objEntityVOC.Hiragana = objDataTableVOC.Rows(intID)(Constants_LanhVC.INT_VOC_DB_COLUMN_HIGARANA)
        objEntityVOC.Kanji = objDataTableVOC.Rows(intID)(Constants_LanhVC.INT_VOC_DB_COLUMN_KANJI)
        objEntityVOC.Hannom = objDataTableVOC.Rows(intID)(Constants_LanhVC.INT_VOC_DB_COLUMN_HANNOM)
        objEntityVOC.Meaning = objDataTableVOC.Rows(intID)(Constants_LanhVC.INT_VOC_DB_COLUMN_MEANING)
        objEntityVOC.Type = objDataTableVOC.Rows(intID)(Constants_LanhVC.INT_VOC_DB_COLUMN_TYPE)


        Return objEntityVOC
    End Function

    Private Sub btnOverride_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOverwrite.Click
        DialogResult = ProcessSameVocabulary(Constants_LanhVC.INT_OVERRIDE)
        Me.Close()
    End Sub

    Private Sub btnSkip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSkip.Click
        Me.ActionIsSkipped = True
        Me.DialogResult = Constants_LanhVC.INT_SKIP
        Me.Close()
    End Sub

End Class

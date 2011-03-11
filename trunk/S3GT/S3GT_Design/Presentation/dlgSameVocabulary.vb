Imports System.Windows.Forms



Public Class dlgSameVocabulary

    Dim intNewRow As Integer
    Public applyToAll As Boolean
    Public selection As String

    Private strTopicName As String
    Private strTopicGroupName As String

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

        applyToAll = False


        Dim i As Integer
        Dim strTypeText As String

        dataVocabulary.Rows.Add(dataSourceVocabulary.Item(intID).Cells(0).Value, _
                                    dataSourceVocabulary.Item(intID).Cells(1).Value, _
                                    dataSourceVocabulary.Item(intID).Cells(2).Value, _
                                    dataSourceVocabulary.Item(intID).Cells(3).Value, _
                                    dataSourceVocabulary.Item(intID).Cells(4).Value)
        dataVocabulary.Rows(0).Cells(Constants_LanhVC.INT_VOC_COLUMN_EXAMPLE).Value = dataSourceVocabulary.Item(intID).Cells(Constants_LanhVC.INT_VOC_DB_COLUMN_EXAMPLE).Value

        intNewRow = dataVocabulary.Rows.Count

        For i = 0 To objVocTable.Rows.Count - 1
            strTypeText = Utils.GetType_TextFromInt(objVocTable.Rows(i)(Constants_LanhVC.INT_VOC_DB_COLUMN_TYPE))
            dataVocabulary.Rows.Add(Constants_LanhVC.INT_CHECK, _
                                    objVocTable.Rows(i)(Constants_LanhVC.INT_VOC_DB_COLUMN_KANJI), _
                                    objVocTable.Rows(i)(Constants_LanhVC.INT_VOC_DB_COLUMN_HIGARANA), _
                                    objVocTable.Rows(i)(Constants_LanhVC.INT_VOC_DB_COLUMN_HANNOM), _
                                    objVocTable.Rows(i)(Constants_LanhVC.INT_VOC_DB_COLUMN_MEANING), _
                                    strTypeText)
            dataVocabulary.Rows(i + 1).Cells(Constants_LanhVC.INT_VOC_COLUMN_EXAMPLE).Value = objVocTable.Rows(i)(Constants_LanhVC.INT_VOC_DB_COLUMN_EXAMPLE)
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
        Dim vocBO As New VocabulariesBO

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        applyToAll = False

        'init
        Me.vocInProcessingEntity = vocabularyEntity
        Dim strTypeText = Utils.GetType_TextFromInt(vocabularyEntity.Type)
        dataVocabulary.Rows.Add(Constants_LanhVC.INT_CHECK, _
                                    vocInProcessingEntity.Kanji, _
                                    vocInProcessingEntity.Hiragana, _
                                    vocInProcessingEntity.Hannom, _
                                    vocInProcessingEntity.Meaning, _
                                    strTypeText)
        dataVocabulary.Rows(0).Cells(Constants_LanhVC.INT_VOC_COLUMN_EXAMPLE).Value = vocInProcessingEntity.Example
        intNewRow = dataVocabulary.Rows.Count
        For i = 0 To objSameHiraganaVocTable.Rows.Count - 1
            strTypeText = Utils.GetType_TextFromInt(objSameHiraganaVocTable.Rows(i)(Constants_LanhVC.INT_VOC_DB_COLUMN_TYPE))
            dataVocabulary.Rows.Add(Constants_LanhVC.INT_CHECK, _
                                    objSameHiraganaVocTable.Rows(i)(Constants_LanhVC.INT_VOC_DB_COLUMN_KANJI), _
                                    objSameHiraganaVocTable.Rows(i)(Constants_LanhVC.INT_VOC_DB_COLUMN_HIGARANA), _
                                    objSameHiraganaVocTable.Rows(i)(Constants_LanhVC.INT_VOC_DB_COLUMN_HANNOM), _
                                    objSameHiraganaVocTable.Rows(i)(Constants_LanhVC.INT_VOC_DB_COLUMN_MEANING), _
                                    strTypeText)
            dataVocabulary.Rows(i + 1).Cells(Constants_LanhVC.INT_VOC_COLUMN_EXAMPLE).Value = objSameHiraganaVocTable.Rows(i)(Constants_LanhVC.INT_VOC_DB_COLUMN_EXAMPLE)
        Next
        lblMessageContent.Text = Constants_LanhVC.STR_MSG_ERR_003
    End Sub

    Private Function ProcessSameVocabulary(ByVal intType As Integer)
        Dim objDataTableVOC As DataTable
        Dim intResult As Integer
        Dim objVocBO As VocabulariesBO
        Dim objVocEntity As VocabulariesEntity
        Dim objTopicBO As TopicsBO
        Dim i, j, VocIDtemp, TopicIDTemp As Integer
        Dim intTopicID As Integer

        'init
        intResult = 1
        objDataTableVOC = Nothing

        Try
            'get list Voc 
            objVocBO = New VocabulariesBO()
            'objDataTableVOC = objVocBO.GetVocabulariesTable()
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

                objDataTableVOC = objVocBO.CheckExist(dataVocabulary.Rows(i).Cells(Constants_LanhVC.INT_VOC_COLUMN_HIGARANA).Value, dataVocabulary.Rows(i).Cells(Constants_LanhVC.INT_VOC_COLUMN_KANJI).Value, intTopicID)
                If objDataTableVOC.Rows.Count > 0 Then

                    For j = 0 To objDataTableVOC.Rows.Count - 1
                        'neu co check tren check box
                        If dataVocabulary.Rows(intNewRow + j).Cells(Constants_LanhVC.INT_VOC_COLUMN_CHECKBOX).Value Then

                            objVocEntity = CopyDataFromTableToEntity(objDataTableVOC, j)
                            Select Case intType
                                Case Constants_LanhVC.INT_OVERRIDE
                                    VocIDtemp = objVocEntity.VocID
                                    TopicIDTemp = objVocEntity.TopicID
                                    objVocEntity = objVocBO.CopyDataToEntityFromDataGrid(dataVocabulary, i)
                                    objVocEntity.VocID = VocIDtemp
                                    objVocEntity.TopicID = TopicIDTemp
                                    objVocBO.UpdateVocabulary(objVocEntity)
                                Case Constants_LanhVC.INT_MERGE_KANJI
                                    objVocEntity.Kanji = objVocEntity.Kanji + Constants_LanhVC.STR_COMMA_VALUE + _
                                                                                dataVocabulary.Rows(i).Cells(Constants_LanhVC.INT_VOC_COLUMN_KANJI).Value
                                    objVocBO.UpdateVocabulary(objVocEntity)

                                Case Constants_LanhVC.INT_MERGE_MEANING
                                    objVocEntity.Meaning = objVocEntity.Meaning + Constants_LanhVC.STR_COMMA_VALUE + _
                                                                                    dataVocabulary.Rows(i).Cells(Constants_LanhVC.INT_VOC_COLUMN_MEANING).Value
                                    objVocBO.UpdateVocabulary(objVocEntity)
                                Case Constants_LanhVC.INT_SKIP
                                    'nothing to do
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
        objEntityVOC.Example = objDataTableVOC.Rows(intID)(Constants_LanhVC.INT_VOC_DB_COLUMN_EXAMPLE)
        Return objEntityVOC
    End Function

    Private Sub btnSkip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSkip.Click
        'Me.DialogResult = Constants_LanhVC.INT_SKIP
        selection = Constants_LanhVC.STR_DUPLICATE_SELECTION_SKIP
        Me.Close()
    End Sub

    Private Sub btnOverride_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOverwrite.Click
        'Me.DialogResult = Constants_LanhVC.INT_SKIP
        selection = Constants_LanhVC.STR_DUPLICATE_SELECTION_OVERWRITE
        Me.Close()
    End Sub

    Private Sub dlgSameVocabulary2_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.DialogResult = Constants_LanhVC.INT_SKIP
    End Sub

    Private Sub chkApplyAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkApplyAll.Click
        If (chkApplyAll.Checked) Then
            applyToAll = True
        Else
            applyToAll = False
        End If
    End Sub
End Class

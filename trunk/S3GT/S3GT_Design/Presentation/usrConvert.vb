Imports System.Data.OleDb
Imports S3GT.Constants_NguyenNB


Public Class usrConvert

    Dim mainForm As frmMainForm

    Dim KanjiInt, HiraganaInt, MeaningInt, HanNomInt, ExampleInt As Integer
    Dim MyConnection As System.Data.OleDb.OleDbConnection
    Dim Ds As System.Data.DataSet
    Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
    Private bo As ImportBO = New ImportBO

    Public Sub New(ByVal mainForm As frmMainForm)
        InitializeComponent()
        Me.mainForm = mainForm
    End Sub

    Private Sub ReleaseComObject(ByRef Reference As Object)
        Try
            Do Until _
             System.Runtime.InteropServices.Marshal.ReleaseComObject(Reference) <= 0
            Loop
        Catch
        Finally
            Reference = Nothing
        End Try
    End Sub

    Private Sub btnInBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInBrowse.Click
        Try
            ofdConvert.Filter() = "Excel file(*.xls)|*.xls"
            ofdConvert.FileName = ""
            ofdConvert.ShowDialog()
            txtInPath.Text = ofdConvert.FileName
            Dim arrWorkSheetName, arrColumn As New ArrayList
            Dim Ds As System.Data.DataSet
            Dim i As Integer
            CmbKanji.Items.Clear()
            CmbHiragana.Items.Clear()
            CmbMeaning.Items.Clear()
            CmbHanNom.Items.Clear()
            CmbExample.Items.Clear()

            CmbKanji.Items.Add("None")
            CmbHiragana.Items.Add("None")
            CmbMeaning.Items.Add("None")
            CmbHanNom.Items.Add("None")
            CmbExample.Items.Add("None")

            CmbKanji.SelectedIndex = 0
            CmbHiragana.SelectedIndex = 0
            CmbMeaning.SelectedIndex = 0
            CmbHanNom.SelectedIndex = 0
            CmbExample.SelectedIndex = 0

            GetExcelSheetName(txtInPath.Text, arrWorkSheetName)
            Ds = RetrieveExcelData(arrWorkSheetName(0))

            If Ds.Tables.Count > 0 Then
                For i = 0 To Ds.Tables(0).Columns.Count - 1
                    CmbKanji.Items.Add(Ds.Tables(0).Columns(i).ColumnName)
                    CmbHiragana.Items.Add(Ds.Tables(0).Columns(i).ColumnName)
                    CmbMeaning.Items.Add(Ds.Tables(0).Columns(i).ColumnName)
                    CmbHanNom.Items.Add(Ds.Tables(0).Columns(i).ColumnName)
                    CmbExample.Items.Add(Ds.Tables(0).Columns(i).ColumnName)
                Next
                CmbKanji.Enabled = True
                CmbMeaning.Enabled = True
                CmbExample.Enabled = True
                CmbHiragana.Enabled = True
                CmbHanNom.Enabled = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnOutBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOutBrowse.Click
        Try
            sfdConvert.Filter() = "Excel file(*.xls)|*.xls"
            sfdConvert.ShowDialog()
            txtOutPath.Text = sfdConvert.FileName
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        txtInPath.Text = ""
        txtOutPath.Text = ""
        txtGroupName.Text = ""
        CmbKanji.Enabled = False
        CmbMeaning.Enabled = False
        CmbExample.Enabled = False
        CmbHiragana.Enabled = False
        CmbHanNom.Enabled = False
    End Sub

    Private Sub btnConvert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConvert.Click
        convertToExcel()
        If chkImport.Checked Then
            bo.ImportVocExcel(txtOutPath.Text)
            mainForm.LoadDataToTree()
        End If
        Process.Start("taskkill", " /f /im EXCEL.EXE")
    End Sub
    ' Get all sheet name into ArrayList
    Private Sub GetExcelSheetName(ByVal excelFile As String, ByRef alworkSheetName As ArrayList)
        Dim Destination_Application As New Object
        Dim Destination_Workbook
        Try
            Destination_Application = CreateObject("Excel.Application")
            'set the application alerts not to be displayed for confirmation
            Destination_Application.Application.DisplayAlerts = False
            Destination_Workbook = Destination_Application.Workbooks.Open(txtInPath.Text)

            Dim S As Integer = 1
            'Get names of all sheets in the workbook
            Do While S <= Destination_Application.Application.Sheets.Count()
                alworkSheetName.Add(Destination_Application.Application.Sheets(S).Name)
                S = S + 1
            Loop
        Catch ex As Exception
        Finally
            Destination_Application.Application.Quit()
            ' Destination_Worksheet = Nothing
            Destination_Workbook = Nothing
            Destination_Application = Nothing
        End Try
    End Sub

    ' Retrieve Excel Data by Name Sheet
    Function RetrieveExcelData(ByVal excelSheetName As String) As DataSet
        Try
            ' Fetch Data from Excel
            MyConnection = New System.Data.OleDb.OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0; " & _
                            "data source='" & txtInPath.Text & " '; " & "Extended Properties=Excel 8.0;")

            ' Select the data from excelSheetName of the workbook.
            MyCommand = New System.Data.OleDb.OleDbDataAdapter("select * from [" + excelSheetName + "$]", MyConnection)
            Ds = New System.Data.DataSet
            MyCommand.Fill(Ds)
            MyConnection.Close()
        Catch ex As Exception
            MessageBox.Show("Source File is Error")
            MyConnection.Close()
        End Try

        Return Ds
    End Function

    Private Sub setColumn()
        KanjiInt = CmbKanji.SelectedIndex - 1
        HiraganaInt = CmbHiragana.SelectedIndex - 1
        MeaningInt = CmbMeaning.SelectedIndex - 1
        HanNomInt = CmbHanNom.SelectedIndex - 1
        ExampleInt = CmbExample.SelectedIndex - 1
    End Sub

    Function checkInfo() As Boolean
        If txtGroupName.Text = "" Then
            MessageBox.Show("You must set Topic Group Name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtGroupName.Focus()
            Return False
        End If

        If txtInPath.Text = "" Then
            MessageBox.Show("You must choose source file", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If txtOutPath.Text = "" Then
            MessageBox.Show("You must set converted file", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If CmbKanji.SelectedIndex = 0 Then
            MessageBox.Show("Kanji Column Cannot None")
            CmbKanji.Focus()
            Return False
        End If

        If CmbHiragana.SelectedIndex <> 0 Then
            If CmbHiragana.SelectedIndex = CmbKanji.SelectedIndex Then
                MessageBox.Show("Hiragana Column must difference Kanji Column")
                CmbHiragana.Focus()
                Return False
            End If
        End If


        If CmbMeaning.SelectedIndex <> 0 Then
            If CmbMeaning.SelectedIndex = CmbKanji.SelectedIndex Then
                MessageBox.Show("Meaning Column must difference Kanji Column")
                CmbHiragana.Focus()
                Return False
            End If

            If CmbMeaning.SelectedIndex = CmbHiragana.SelectedIndex Then
                MessageBox.Show("Meaning Column must difference Hiragana Column")
                CmbHiragana.Focus()
                Return False
            End If
        End If


        If CmbHanNom.SelectedIndex <> 0 Then
            If CmbHanNom.SelectedIndex = CmbKanji.SelectedIndex Then
                MessageBox.Show("HanNom Column must difference Kanji Column")
                CmbHiragana.Focus()
                Return False
            End If

            If CmbHanNom.SelectedIndex = CmbHiragana.SelectedIndex Then
                MessageBox.Show("HanNom Column must difference Hiragana Column")
                CmbHiragana.Focus()
                Return False
            End If

            If CmbHanNom.SelectedIndex = CmbMeaning.SelectedIndex Then
                MessageBox.Show("HanNom Column must difference Meaning Column")
                CmbHiragana.Focus()
                Return False
            End If
        End If


        If CmbExample.SelectedIndex <> 0 Then
            If CmbExample.SelectedIndex = CmbKanji.SelectedIndex Then
                MessageBox.Show("Example Column must difference Kanji Column")
                CmbHiragana.Focus()
                Return False
            End If

            If CmbExample.SelectedIndex = CmbHiragana.SelectedIndex Then
                MessageBox.Show("Example Column must difference Hiragana Column")
                CmbHiragana.Focus()
                Return False
            End If

            If CmbExample.SelectedIndex = CmbMeaning.SelectedIndex Then
                MessageBox.Show("Example Column must difference Meaning Column")
                CmbHiragana.Focus()
                Return False
            End If

            If CmbExample.SelectedIndex = CmbHanNom.SelectedIndex Then
                MessageBox.Show("Example Column must difference HanNom Column")
                CmbHiragana.Focus()
                Return False
            End If
        End If
        Return True
    End Function

    'Convert To Excel
    Private Sub convertToExcel()
        Dim Ds As System.Data.DataSet
        Dim arrWorkSheetName As New ArrayList
        Dim i, j As Integer
        Dim excelApp As Excel.Application
        Dim ws As Excel.Worksheet
        Dim wb As Excel.Workbook
        Try
            If checkInfo() Then
                setColumn()
                GetExcelSheetName(txtInPath.Text, arrWorkSheetName)
                excelApp = New Excel.Application
                wb = excelApp.Workbooks.Add()
                'add sheet topic group
                ws = wb.Sheets(1)
                ws.Name = EXP_PREFIX_SHEET_TOPIC_GROUP
                ws.Cells(1, 2) = txtGroupName.Text
                'add sheet topic
                ws = wb.Sheets(2)
                ws.Name = EXP_PREFIX_SHEET_TOPIC
                For i = 1 To arrWorkSheetName.Count
                    ws.Cells(i, 2) = txtGroupName.Text
                    ws.Cells(i, 4) = arrWorkSheetName(i - 1).ToString
                Next

                ws = wb.Sheets(3)
                ws.Delete()
                For i = 1 To arrWorkSheetName.Count
                    Ds = RetrieveExcelData(arrWorkSheetName(i - 1))
                    If Ds.Tables(0).Rows.Count > 0 And (Ds.Tables(0).Columns.Count > 1) Then

                        ws = CType(wb.Worksheets.Add(After:=wb.Worksheets(wb.Worksheets.Count)), Excel.Worksheet)
                        ws.Name = "VOC" & i
                        ws.Cells(1, 1) = EXP_ITEM_TOPIC_GROUP
                        ws.Cells(1, 2) = txtGroupName.Text
                        ws.Cells(2, 1) = EXP_ITEM_TOPIC
                        ws.Cells(2, 2) = arrWorkSheetName(i - 1).ToString
                        ws.Cells(3, 1) = S3GT_VOC_KANJI
                        ws.Cells(3, 2) = S3GT_VOC_HIRAGANA
                        ws.Cells(3, 3) = S3GT_VOC_MEANING
                        ws.Cells(3, 4) = S3GT_VOC_HANNOM
                        ws.Cells(3, 5) = S3GT_VOC_EXAMPLE




                        If Ds.Tables.Count > 0 Then
                            'add column name.
                            ws.Cells(4, 1) = Ds.Tables(0).Columns(KanjiInt).ColumnName
                            If HiraganaInt >= 0 Then
                                ws.Cells(4, 2) = Ds.Tables(0).Columns(HiraganaInt).ColumnName
                            End If
                            If MeaningInt >= 0 Then
                                ws.Cells(4, 3) = Ds.Tables(0).Columns(MeaningInt).ColumnName
                            End If
                            If HanNomInt >= 0 Then
                                ws.Cells(4, 4) = Ds.Tables(0).Columns(HanNomInt).ColumnName
                            End If
                            If ExampleInt >= 0 Then
                                ws.Cells(4, 5) = Ds.Tables(0).Columns(ExampleInt).ColumnName
                            End If
                            'add row
                            For j = 0 To Ds.Tables(0).Rows.Count - 1
                                ws.Cells(j + 5, 1) = Ds.Tables(0).Rows(j)(KanjiInt).ToString
                                If HiraganaInt >= 0 Then
                                    ws.Cells(j + 5, 2) = Ds.Tables(0).Rows(j)(HiraganaInt).ToString
                                End If
                                If MeaningInt >= 0 Then
                                    ws.Cells(j + 5, 3) = Ds.Tables(0).Rows(j)(MeaningInt).ToString
                                End If
                                If HanNomInt >= 0 Then
                                    ws.Cells(j + 5, 4) = Ds.Tables(0).Rows(j)(HanNomInt).ToString
                                End If
                                If ExampleInt >= 0 Then
                                    ws.Cells(j + 5, 5) = Ds.Tables(0).Rows(j)(ExampleInt).ToString
                                End If
                            Next

                            Ds.Clear()
                        Else
                            MessageBox.Show("Moi Sheet Trong File Nguon Khong dong nhat", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            excelApp.Quit()
                        End If
                    Else
                        'add column name.
                        If (Ds.Tables(0).Columns.Count > 1) Then
                            ws = CType(wb.Worksheets.Add(After:=wb.Worksheets(wb.Worksheets.Count)), Excel.Worksheet)
                            ws.Name = "VOC" & i
                            ws.Cells(1, 1) = EXP_ITEM_TOPIC_GROUP
                            ws.Cells(1, 2) = txtGroupName.Text
                            ws.Cells(2, 1) = EXP_ITEM_TOPIC
                            ws.Cells(2, 2) = arrWorkSheetName(i - 1).ToString
                            ws.Cells(3, 1) = S3GT_VOC_KANJI
                            ws.Cells(3, 2) = S3GT_VOC_HIRAGANA
                            ws.Cells(3, 3) = S3GT_VOC_MEANING
                            ws.Cells(3, 4) = S3GT_VOC_HANNOM
                            ws.Cells(3, 5) = S3GT_VOC_EXAMPLE

                            ws.Cells(4, 1) = Ds.Tables(0).Columns(KanjiInt).ColumnName
                            If HiraganaInt >= 0 Then
                                ws.Cells(4, 2) = Ds.Tables(0).Columns(HiraganaInt).ColumnName
                            End If
                            If MeaningInt >= 0 Then
                                ws.Cells(4, 3) = Ds.Tables(0).Columns(MeaningInt).ColumnName
                            End If
                            If HanNomInt >= 0 Then
                                ws.Cells(4, 4) = Ds.Tables(0).Columns(HanNomInt).ColumnName
                            End If
                            If ExampleInt >= 0 Then
                                ws.Cells(4, 5) = Ds.Tables(0).Columns(ExampleInt).ColumnName
                            End If
                        Else
                            ws = wb.Sheets(2)
                            ws.Cells(i, 2) = ""
                            ws.Cells(i, 4) = ""
                        End If
                    End If
                Next

                wb.SaveAs(txtOutPath.Text)
                wb.Close()
                excelApp.Quit()
                ReleaseComObject(excelApp)
                wb = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show(ex.StackTrace, "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
End Class

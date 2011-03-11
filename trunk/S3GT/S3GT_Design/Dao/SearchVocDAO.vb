Public Class SearchVocDAO

    ''' <summary>
    ''' Search Vocabulary
    ''' </summary>    
    ''' <remarks></remarks>
    Public Function SearchVocabulary(ByVal SearchBy As String, ByVal SearchFollow As String, ByVal Topic_Group_ID As Int32, ByVal txtInputKeyword As String, ByVal Topic_Name As String) As DataTable
        Dim strSQL As String
        Dim objBaseDAO As BaseDAO
        Dim objVocTable As DataTable

        'init
        objVocTable = New DataTable()
        strSQL = Constants_LanhVC.STR_BLANK_VALUE
        ''objBaseDAO = Nothing
        objBaseDAO = New BaseDAO()

        'set value for SQL
        Select Case SearchBy
            Case "Include"
                'Start with SearchBy = "Include"
                If Not Topic_Group_ID = 0 And Not Topic_Name = "All topic" Then
                    Select Case SearchFollow
                        Case "Hiragana/Katakana"
                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_HIRAGANA, _
                                            Topic_Group_ID, _
                                            Utils.Replace(txtInputKeyword), _
                                           Utils.Replace(Topic_Name))
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            Return objVocTable
                        Case "Kanji"
                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_KANJI, _
                                            Topic_Group_ID, _
                                            Utils.Replace(txtInputKeyword), _
                                            Utils.Replace(Topic_Name))
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            Return objVocTable
                        Case "Han Nom"
                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_HANNOM, _
                                            Topic_Group_ID, _
                                            Utils.Replace(txtInputKeyword), _
                                            Utils.Replace(Topic_Name))
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            Return objVocTable
                        Case "Meaning"
                            Print("SearchBy" + SearchBy, "SearchFollow" + SearchFollow, "txtInputKeyword" + txtInputKeyword)
                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_MEANING, _
                                            Topic_Group_ID, _
                                           Utils.Replace(txtInputKeyword), _
                                           Utils.Replace(Topic_Name))
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            Return objVocTable

                        Case "All"
                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_HIRAGANA, _
                                            Topic_Group_ID, _
                                            Utils.Replace(txtInputKeyword), _
                                           Utils.Replace(Topic_Name))
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            If Not objVocTable.Rows.Count = 0 Then Return objVocTable

                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_KANJI, _
                                            Topic_Group_ID, _
                                            Utils.Replace(txtInputKeyword), _
                                            Utils.Replace(Topic_Name))
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            If Not objVocTable.Rows.Count = 0 Then Return objVocTable

                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_HANNOM, _
                                            Topic_Group_ID, _
                                            Utils.Replace(txtInputKeyword), _
                                            Utils.Replace(Topic_Name))
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            If Not objVocTable.Rows.Count = 0 Then Return objVocTable

                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_MEANING, _
                                            Topic_Group_ID, _
                                           Utils.Replace(txtInputKeyword), _
                                           Utils.Replace(Topic_Name))
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            If Not objVocTable.Rows.Count = 0 Then Return objVocTable

                    End Select
                ElseIf Not Topic_Group_ID = 0 And Topic_Name = "All topic" Then
                    Select Case SearchFollow
                        Case "Hiragana/Katakana"
                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_HIRAGANA_TPNNULL, _
                                            Topic_Group_ID, _
                                            txtInputKeyword)
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            If Not objVocTable.Rows.Count = 0 Then Return objVocTable
                        Case "Kanji"
                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_KANJI_TPNNULL, _
                                            Topic_Group_ID, _
                                            Utils.Replace(txtInputKeyword))
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            If Not objVocTable.Rows.Count = 0 Then Return objVocTable
                        Case "Han Nom"
                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_HANNOM_TPNNULL, _
                                            Topic_Group_ID, _
                                            Utils.Replace(txtInputKeyword))
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            If Not objVocTable.Rows.Count = 0 Then Return objVocTable
                        Case "Meaning"
                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_MEANING_TPNNULL, _
                                            Topic_Group_ID, _
                                            Utils.Replace(txtInputKeyword))
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            If Not objVocTable.Rows.Count = 0 Then Return objVocTable
                        Case "All"
                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_HIRAGANA_TPNNULL, _
                                            Topic_Group_ID, _
                                            txtInputKeyword)
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            If Not objVocTable.Rows.Count = 0 Then Return objVocTable
                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_KANJI_TPNNULL, _
                                            Topic_Group_ID, _
                                            Utils.Replace(txtInputKeyword))
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            If Not objVocTable.Rows.Count = 0 Then Return objVocTable
                        Case "Han Nom"
                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_HANNOM_TPNNULL, _
                                            Topic_Group_ID, _
                                            Utils.Replace(txtInputKeyword))
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            If Not objVocTable.Rows.Count = 0 Then Return objVocTable
                        Case "Meaning"
                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_MEANING_TPNNULL, _
                                            Topic_Group_ID, _
                                            Utils.Replace(txtInputKeyword))
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            If Not objVocTable.Rows.Count = 0 Then Return objVocTable
                    End Select
                ElseIf Topic_Group_ID = 0 And Topic_Name = "All topic" Then
                    Select Case SearchFollow
                        Case "Hiragana/Katakana"
                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_HIRAGANA_TPGNULL, _
                                            Utils.Replace(txtInputKeyword))
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            Return objVocTable
                        Case "Kanji"
                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_KANJI_TPGNULL, _
                                            Utils.Replace(txtInputKeyword))
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            Return objVocTable
                        Case "Han Nom"
                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_HANNOM_TPGNULL, _
                                            Utils.Replace(txtInputKeyword))
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            Return objVocTable
                        Case "Meaning"
                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_MEANING_TPGNULL, _
                                            Utils.Replace(txtInputKeyword))
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            Return objVocTable

                        Case "All"
                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_HIRAGANA_TPGNULL, _
                                           Utils.Replace(txtInputKeyword))
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            If Not objVocTable.Rows.Count = 0 Then Return objVocTable

                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_KANJI_TPGNULL, _
                                            Utils.Replace(txtInputKeyword))
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            If Not objVocTable.Rows.Count = 0 Then Return objVocTable

                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_HANNOM_TPGNULL, _
                                            Utils.Replace(txtInputKeyword))
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            If Not objVocTable.Rows.Count = 0 Then Return objVocTable

                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_MEANING_TPGNULL, _
                                            Utils.Replace(txtInputKeyword))
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            If Not objVocTable.Rows.Count = 0 Then Return objVocTable



                    End Select
                End If
                'End with SearchBy = "Include"

            Case "End with"
                'Start with SearchBy = "Start with"
                If Not Topic_Group_ID = 0 And Not Topic_Name = "All topic" Then
                    Select Case SearchFollow
                        Case "Hiragana/Katakana"
                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_HIRAGANA_START, _
                                            Topic_Group_ID, _
                                            Utils.Replace(txtInputKeyword), _
                                           Utils.Replace(Topic_Name))
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            Return objVocTable
                        Case "Kanji"
                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_KANJI_START, _
                                            Topic_Group_ID, _
                                            Utils.Replace(txtInputKeyword), _
                                            Utils.Replace(Topic_Name))
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            Return objVocTable
                        Case "Han Nom"
                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_HANNOM_TPGNULL_START, _
                                            Topic_Group_ID, _
                                            Utils.Replace(txtInputKeyword), _
                                            Utils.Replace(Topic_Name))
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            Return objVocTable
                        Case "Meaning"
                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_MEANING_START, _
                                            Topic_Group_ID, _
                                            Utils.Replace(txtInputKeyword), _
                                            Utils.Replace(Topic_Name))
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            Return objVocTable

                        Case "All"
                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_HIRAGANA_START, _
                                            Topic_Group_ID, _
                                            Utils.Replace(txtInputKeyword), _
                                           Utils.Replace(Topic_Name))
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            If Not objVocTable.Rows.Count = 0 Then Return objVocTable

                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_KANJI_START, _
                                            Topic_Group_ID, _
                                            Utils.Replace(txtInputKeyword), _
                                            Utils.Replace(Topic_Name))
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            If Not objVocTable.Rows.Count = 0 Then Return objVocTable

                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_HANNOM_TPGNULL_START, _
                                            Topic_Group_ID, _
                                            Utils.Replace(txtInputKeyword), _
                                            Utils.Replace(Topic_Name))
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            If Not objVocTable.Rows.Count = 0 Then Return objVocTable

                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_MEANING_START, _
                                            Topic_Group_ID, _
                                            Utils.Replace(txtInputKeyword), _
                                            Utils.Replace(Topic_Name))
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            If Not objVocTable.Rows.Count = 0 Then Return objVocTable
                    End Select
                ElseIf Not Topic_Group_ID = 0 And Topic_Name = "All topic" Then
                    Select Case SearchFollow
                        Case "Hiragana/Katakana"
                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_HIRAGANA_TPNNULL_START, _
                                            Topic_Group_ID, _
                                            Utils.Replace(txtInputKeyword))
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            Return objVocTable
                        Case "Kanji"
                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_KANJI_TPNNULL_START, _
                                            Topic_Group_ID, _
                                            Utils.Replace(txtInputKeyword))
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            Return objVocTable
                        Case "Han Nom"
                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_HANNOM_TPNNULL_START, _
                                            Topic_Group_ID, _
                                            Utils.Replace(txtInputKeyword))
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            Return objVocTable
                        Case "Meaning"
                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_MEANING_TPNNULL_START, _
                                            Topic_Group_ID, _
                                            Utils.Replace(txtInputKeyword))

                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            Return objVocTable

                        Case "All"
                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_HIRAGANA_TPNNULL_START, _
                                            Topic_Group_ID, _
                                            Utils.Replace(txtInputKeyword))
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            If Not objVocTable.Rows.Count = 0 Then Return objVocTable

                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_KANJI_TPNNULL_START, _
                                            Topic_Group_ID, _
                                            Utils.Replace(txtInputKeyword))
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            If Not objVocTable.Rows.Count = 0 Then Return objVocTable

                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_HANNOM_TPNNULL_START, _
                                            Topic_Group_ID, _
                                            Utils.Replace(txtInputKeyword))
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            If Not objVocTable.Rows.Count = 0 Then Return objVocTable

                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_MEANING_TPNNULL_START, _
                                            Topic_Group_ID, _
                                            Utils.Replace(txtInputKeyword))

                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            If Not objVocTable.Rows.Count = 0 Then Return objVocTable

                    End Select
                ElseIf Topic_Group_ID = 0 And Topic_Name = "All topic" Then
                    Select Case SearchFollow
                        Case "Hiragana/Katakana"
                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_HIRAGANA_TPGNULL_START, _
                                            Utils.Replace(txtInputKeyword))
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            Return objVocTable
                        Case "Kanji"
                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_KANJI_TPGNULL_START, _
                                            Utils.Replace(txtInputKeyword))
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            Return objVocTable
                        Case "Han Nom"
                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_HANNOM_TPGNULL_START, _
                                            Utils.Replace(txtInputKeyword))
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            Return objVocTable
                        Case "Meaning"
                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_MEANING_TPGNULL_START, _
                                            Utils.Replace(txtInputKeyword))
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            Return objVocTable

                        Case "All"
                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_HIRAGANA_TPGNULL_START, _
                                            Utils.Replace(txtInputKeyword))
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            If Not objVocTable.Rows.Count = 0 Then Return objVocTable

                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_KANJI_TPGNULL_START, _
                                            Utils.Replace(txtInputKeyword))
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            If Not objVocTable.Rows.Count = 0 Then Return objVocTable

                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_HANNOM_TPGNULL_START, _
                                            Utils.Replace(txtInputKeyword))
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            If Not objVocTable.Rows.Count = 0 Then Return objVocTable

                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_MEANING_TPGNULL_START, _
                                            Utils.Replace(txtInputKeyword))
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            If Not objVocTable.Rows.Count = 0 Then Return objVocTable

                    End Select
                End If
                'End with SearchBy = "Start with"

            Case "Start with"
                'Start with SearchBy = "End with"
                If Not Topic_Group_ID = 0 And Not Topic_Name = "All topic" Then
                    Select Case SearchFollow
                        Case "Hiragana/Katakana"
                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_HIRAGANA_TPGNULL_END, _
                                            Topic_Group_ID, _
                                            Utils.Replace(txtInputKeyword), _
                                            Utils.Replace(Topic_Name))
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            Return objVocTable
                        Case "Kanji"
                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_KANJI_TPGNULL_END, _
                                            Topic_Group_ID, _
                                            Utils.Replace(txtInputKeyword), _
                                            Utils.Replace(Topic_Name))
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            Return objVocTable
                        Case "Han Nom"
                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_HANNOM_TPGNULL_END, _
                                            Topic_Group_ID, _
                                            Utils.Replace(txtInputKeyword), _
                                            Utils.Replace(Topic_Name))
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            Return objVocTable
                        Case "Meaning"
                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_MEANING_END, _
                                            Topic_Group_ID, _
                                            Utils.Replace(txtInputKeyword), _
                                            Utils.Replace(Topic_Name))
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            Return objVocTable

                        Case "All"
                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_HIRAGANA_TPGNULL_END, _
                                            Topic_Group_ID, _
                                            Utils.Replace(txtInputKeyword), _
                                            Utils.Replace(Topic_Name))
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            If Not objVocTable.Rows.Count = 0 Then Return objVocTable

                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_KANJI_TPGNULL_END, _
                                            Topic_Group_ID, _
                                            Utils.Replace(txtInputKeyword), _
                                            Utils.Replace(Topic_Name))
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            If Not objVocTable.Rows.Count = 0 Then Return objVocTable

                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_HANNOM_TPGNULL_END, _
                                            Topic_Group_ID, _
                                            Utils.Replace(txtInputKeyword), _
                                            Utils.Replace(Topic_Name))
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            If Not objVocTable.Rows.Count = 0 Then Return objVocTable

                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_MEANING_END, _
                                            Topic_Group_ID, _
                                            Utils.Replace(txtInputKeyword), _
                                            Utils.Replace(Topic_Name))
                            If Not objVocTable.Rows.Count = 0 Then Return objVocTable

                    End Select
                ElseIf Not Topic_Group_ID = 0 And Topic_Name = "All topic" Then
                    Select Case SearchFollow
                        Case "Hiragana/Katakana"
                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_HIRAGANA_TPNNULL_END, _
                                            Topic_Group_ID, _
                                            Utils.Replace(txtInputKeyword))
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            Return objVocTable
                        Case "Kanji"
                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_KANJI_TPNNULL_END, _
                                            Topic_Group_ID, _
                                            Utils.Replace(txtInputKeyword))
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            Return objVocTable
                        Case "Han Nom"
                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_HANNOM_TPNNULL_END, _
                                            Topic_Group_ID, _
                                            Utils.Replace(txtInputKeyword))
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            Return objVocTable
                        Case "Meaning"
                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_MEANING_TPNNULL_END, _
                                            Topic_Group_ID, _
                                            Utils.Replace(txtInputKeyword))
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            Return objVocTable

                        Case "All"
                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_HIRAGANA_TPNNULL_END, _
                                            Topic_Group_ID, _
                                            Utils.Replace(txtInputKeyword))
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            If Not objVocTable.Rows.Count = 0 Then Return objVocTable

                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_KANJI_TPNNULL_END, _
                                            Topic_Group_ID, _
                                            Utils.Replace(txtInputKeyword))
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            If Not objVocTable.Rows.Count = 0 Then Return objVocTable

                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_HANNOM_TPNNULL_END, _
                                            Topic_Group_ID, _
                                            Utils.Replace(txtInputKeyword))
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            If Not objVocTable.Rows.Count = 0 Then Return objVocTable

                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_MEANING_TPNNULL_END, _
                                            Topic_Group_ID, _
                                            Utils.Replace(txtInputKeyword))
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            If Not objVocTable.Rows.Count = 0 Then Return objVocTable

                    End Select
                ElseIf Topic_Group_ID = 0 And Topic_Name = "All topic" Then
                    Select Case SearchFollow
                        Case "Hiragana/Katakana"
                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_HIRAGANA_TPGNULL_END, _
                                            Utils.Replace(txtInputKeyword))
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            Return objVocTable
                        Case "Kanji"
                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_KANJI_TPGNULL_END, _
                                            Utils.Replace(txtInputKeyword))
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            Return objVocTable
                        Case "Han Nom"
                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_HANNOM_TPGNULL_END, _
                                            Utils.Replace(txtInputKeyword))
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            Return objVocTable
                        Case "Meaning"
                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_MEANING_TPGNULL_END, _
                                            Utils.Replace(txtInputKeyword))
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            Return objVocTable

                        Case "All"
                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_HIRAGANA_TPGNULL_END, _
                                            Utils.Replace(txtInputKeyword))
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            If Not objVocTable.Rows.Count = 0 Then Return objVocTable

                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_KANJI_TPGNULL_END, _
                                            Utils.Replace(txtInputKeyword))
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            If Not objVocTable.Rows.Count = 0 Then Return objVocTable

                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_HANNOM_TPGNULL_END, _
                                            Utils.Replace(txtInputKeyword))
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            If Not objVocTable.Rows.Count = 0 Then Return objVocTable

                            strSQL = String.Format(Constants_PhatLS.STR_SQL_VOCABULARY_SEARCH_MEANING_TPGNULL_END, _
                                            Utils.Replace(txtInputKeyword))
                            objVocTable = objBaseDAO.ExecuteQuery(strSQL)
                            If Not objVocTable.Rows.Count = 0 Then Return objVocTable
                    End Select
                End If
                'End with SearchBy = "End with"

        End Select

        'get datatable of voc
        'objBaseDAO = New BaseDAO()
        'objVocTable = objBaseDAO.ExecuteQuery(strSQL)
        Return objVocTable
    End Function
End Class

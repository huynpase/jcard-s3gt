Imports S3GT.Constants_NguyenNB
Public Class ImportDAO
    Dim daoBase As BaseDAO = New BaseDAO

    Public applyToAll As Boolean
    Dim selection As String


    Function GetTopicGroupIdByName(ByVal strTopicGroupName As String) As DataTable
        Dim strSql As String
        Dim dt As DataTable = New DataTable
        Try
            ' strSql = "select * from s3gt_tpg where topic_group_name = '" + strTopicGroupName + "'"
            strSql = "select * from {0} where {1} = '{2}'"
            strSql = String.Format(strSql, S3GT_TABLE_TOPIC_GROUP, S3GT_TPG_NAME, Utils.Replace(strTopicGroupName))
            dt = daoBase.ExecuteQuery(strSql)
        Catch ex As Exception
            MessageBox.Show(ex.Message + " GetTopicGroupIdByName")
        End Try
        Return dt

    End Function

    Function GetTopicIdByName(ByVal objTopicGroup As TopicGroupsEntity, ByVal strTopicName As String) As DataTable
        Dim strSql As String
        Dim dt As DataTable = New DataTable
        Try
            'strSql = "select * from s3gt_tpc where topic_name = '" + strTopicName + "'"
            'strSql += " and " + Constants_NguyenNB.S3GT_TPC_GROUP_ID + " = " + objTopicGroup.TopicGroupID.ToString

            strSql = "select * from {0} where {1} = '{2}' and {3} = {4}"
            strSql = String.Format(strSql, S3GT_TABLE_TOPIC, S3GT_TPC_NAME, Utils.Replace(strTopicName), S3GT_TPC_GROUP_ID, objTopicGroup.TopicGroupID.ToString)
            dt = daoBase.ExecuteQuery(strSql)
        Catch ex As Exception
            MessageBox.Show(ex.Message + " GetTopicIdByName")
        End Try

        Return dt

    End Function

    Sub InsertTopicGroup(ByRef objTopicGroup As TopicGroupsEntity)
        Dim strSql As String
        Dim dt As DataTable = New DataTable
        'have no time now, in maintainance phase, change all to constant, and use String.Format function
        Try
            strSql = "Insert into s3gt_tpg(" + Constants_NguyenNB.S3GT_TPG_NAME + ","
            strSql += Constants_NguyenNB.S3GT_TPG_DESCRIPTION + ") "
            strSql += "values('" + Utils.Replace(objTopicGroup.TopicGroupName) + "','"
            strSql += Utils.Replace(objTopicGroup.TopicGroupDescription) + "')"
            daoBase.ExecuteNonQuery(strSql)
            strSql = "select * from s3gt_tpg"
            strSql += " where " + Constants_NguyenNB.S3GT_TPG_NAME + "='" + Utils.Replace(objTopicGroup.TopicGroupName) + "'"
            dt = daoBase.ExecuteQuery(strSql)
            If dt.Rows.Count > 0 Then
                objTopicGroup.TopicGroupID = dt.Rows(0)(Constants_NguyenNB.S3GT_TPG_ID)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message + " InsertTopicGroup")
        End Try

    End Sub

    Sub InsertTopic(ByRef objTopic As TopicsEntity)
        Dim strSql As String
        Dim dt As DataTable = New DataTable
        'have no time now, in maintainance phase, change all to constant, and use String.Format function
        Try
            If objTopic.TopicDescription Is Nothing Then
                objTopic.TopicDescription = "Not defined"
            End If
            If objTopic.TopicDescription.Length = 0 Then
                objTopic.TopicDescription = "Not defined"
            End If
            strSql = "Insert into s3gt_tpc(" + Constants_NguyenNB.S3GT_TPC_GROUP_ID + ","
            strSql += Constants_NguyenNB.S3GT_TPC_NAME + ","
            strSql += Constants_NguyenNB.S3GT_TPC_DESCRIPTION + ") "
            strSql += "values('" + Utils.Replace(objTopic.TopicGroupID) + "','"
            strSql += Utils.Replace(objTopic.TopicName) + "','"
            strSql += Utils.Replace(objTopic.TopicDescription) + "')"
            daoBase.ExecuteNonQuery(strSql)

            strSql = "Select * from s3gt_tpc where " + Constants_NguyenNB.S3GT_TPC_NAME
            strSql += " = '" + Utils.Replace(objTopic.TopicName) + "' and " + Constants_NguyenNB.S3GT_TPC_DESCRIPTION
            strSql += " = '" + Utils.Replace(objTopic.TopicDescription) + "' and " + Constants_NguyenNB.S3GT_TPC_GROUP_ID
            strSql += " = " + objTopic.TopicGroupID.ToString
            dt = daoBase.ExecuteQuery(strSql)
            If dt.Rows.Count > 0 Then
                objTopic.TopicID = dt.Rows(0)(Constants_NguyenNB.S3GT_TPC_ID)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message + " InsertTopic")
        End Try

    End Sub

    Function CheckVocExist(ByVal objTopic As TopicsEntity, ByVal objvoc As VocabulariesEntity) As Boolean
        Dim strSql As String
        Dim dt As DataTable = New DataTable
        'have no time now, in maintainance phase, change all to constant, and use String.Format function
        Try
            strSql = "Select * from s3gt_voc where " + Constants_NguyenNB.S3GT_VOC_HIRAGANA
            strSql += " = '" + Utils.Replace(objvoc.Hiragana) + "' and " + Constants_NguyenNB.S3GT_VOC_KANJI
            strSql += " = '" + Utils.Replace(objvoc.Kanji) + "' and " + Constants_NguyenNB.S3GT_VOC_TOPIC_ID
            strSql += " = " + objTopic.TopicID.ToString
            dt = daoBase.ExecuteQuery(strSql)
            If dt.Rows.Count > 0 Then Return True Else Return False

        Catch ex As Exception
            MessageBox.Show(ex.Message + " CheckVocExist")
            Return True
        End Try
    End Function
    Sub InsertVoc(ByVal objTopic As TopicsEntity, ByVal objVoc As VocabulariesEntity)
        Dim strSql As String
        'have no time now, in maintainance phase, change all to constant, and use String.Format function
        Try
            strSql = "Insert into s3gt_voc(" + Constants_NguyenNB.S3GT_VOC_TOPIC_ID + ","
            strSql += Constants_NguyenNB.S3GT_VOC_HIRAGANA + ","
            strSql += Constants_NguyenNB.S3GT_VOC_KANJI + ","
            strSql += Constants_NguyenNB.S3GT_VOC_HANNOM + ","
            strSql += Constants_NguyenNB.S3GT_VOC_MEANING + ","
            strSql += Constants_NguyenNB.S3GT_VOC_TYPE + ","
            strSql += Constants_NguyenNB.S3GT_VOC_EXAMPLE + ")"
            strSql += " values('" + Utils.Replace(objTopic.TopicID) + "','"
            strSql += Utils.Replace(objVoc.Hiragana) + "','"
            strSql += Utils.Replace(objVoc.Kanji) + "','"
            strSql += Utils.Replace(objVoc.Hannom) + "','"
            strSql += Utils.Replace(objVoc.Meaning) + "','"
            strSql += Utils.Replace(objVoc.Type) + "','"
            strSql += Utils.Replace(objVoc.Example) + " ')"
            daoBase.ExecuteNonQuery(strSql)

        Catch ex As Exception
            MessageBox.Show(ex.Message + "InsertVoc")
        End Try

    End Sub

    Function CheckKanjiExist(ByVal strKanji As String)
        Dim strSql As String
        Dim dt As DataTable = New DataTable
        'have no time now, in maintainance phase, change all to constant, and use String.Format function
        strSql = "select " + Constants_NguyenNB.S3GT_KAN_KANJI_ID + " from s3gt_kan where "
        strSql += Constants_NguyenNB.S3GT_KAN_KANJI + " = '" + Utils.Replace(strKanji) + "'"
        dt = daoBase.ExecuteQuery(strSql)
        If dt.Rows.Count > 0 Then Return True Else Return False
    End Function

    Function InsertKanji(ByVal objKanji As SingleKanjiEntity) As Boolean
        Dim strSql As String
        'have no time now, in maintainance phase, change all to constant, and use String.Format function
        Try
            strSql = "Insert into s3gt_kan(" + Constants_NguyenNB.S3GT_KAN_KANJI + ","
            strSql += Constants_NguyenNB.S3GT_KAN_HanNom + ","
            strSql += Constants_NguyenNB.S3GT_KAN_Kunyomi + ","
            strSql += Constants_NguyenNB.S3GT_KAN_Onyomi + ","
            strSql += Constants_NguyenNB.S3GT_KAN_Meaning + ")"
            strSql += " values('" + Utils.Replace(objKanji.Kanji) + "','"
            strSql += Utils.Replace(objKanji.HanNom) + "','"
            strSql += Utils.Replace(objKanji.Kunyomi) + "','"
            strSql += Utils.Replace(objKanji.Onyomi) + "','"
            strSql += Utils.Replace(objKanji.Meaning) + "')"

            daoBase.ExecuteNonQuery(strSql)
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message + " InsertKanji")
            Return False
        End Try

    End Function
    Function MergeVoc(ByVal objTopic As TopicsEntity, ByVal objVoc As VocabulariesEntity) As String
        Dim strSql As String
        Dim dt As DataTable = New DataTable
        Dim dlgSameVocabulary As dlgSameVocabulary
        Dim strLog As String = ""
        'have no time now, in maintainance phase, change all to constant, and use String.Format function
        Try

            strSql = "select * from s3gt_voc where "
            strSql += Constants_NguyenNB.S3GT_VOC_TOPIC_ID + "= " + objTopic.TopicID.ToString
            strSql += " and hiragana = '" + objVoc.Hiragana + "'"
            strSql += " and kanji= '" + objVoc.Kanji + "'"

            dt = daoBase.ExecuteQuery(strSql)

            objVoc.TopicID = objTopic.TopicID

            If dt.Rows.Count = 0 Then
                InsertVoc(objTopic, objVoc)
                strLog = "Kanji: " + objVoc.Kanji + "- Hiragana: " + objVoc.Hiragana + " was imported." + vbCrLf
            Else
                'GiangNVT modified
                strLog = "Kanji: " + objVoc.Kanji + "- Hiragana: " + objVoc.Hiragana + " already existed and was ignored" + vbCrLf
                Dim index As Integer
                For index = 0 To dt.Rows.Count - 1
                    If Not (dt.Rows(index)(Constants_LanhVC.INT_VOC_DB_COLUMN_HANNOM) = objVoc.Hannom AndAlso _
                            dt.Rows(index)(Constants_LanhVC.INT_VOC_DB_COLUMN_MEANING) = objVoc.Meaning) Then
                        objVoc.VocID = dt.Rows(index)(Constants_LanhVC.INT_VOC_DB_COLUMN_VOCID)
                        If (applyToAll = False) Then

                            'Fix bug
                            dlgSameVocabulary = New dlgSameVocabulary(objVoc, dt)
                            dlgSameVocabulary.TopicName = objTopic.TopicName
                            dlgSameVocabulary.TopicGroupName = objTopic.TopicGroupName
                            dlgSameVocabulary.ShowDialog()
                            dlgSameVocabulary.Dispose()
                            applyToAll = dlgSameVocabulary.applyToAll
                            selection = dlgSameVocabulary.selection

                            If (dlgSameVocabulary.selection = Constants_LanhVC.STR_DUPLICATE_SELECTION_OVERWRITE) Then
                                UpdateVocabulary(objVoc)
                            ElseIf (dlgSameVocabulary.selection = Constants_LanhVC.STR_DUPLICATE_SELECTION_SKIP) Then
                                'Do nothing
                            End If

                            strLog = "Kanji: " + objVoc.Kanji + "- Hiragana: " + objVoc.Hiragana + " already existed and was overwriten/merged/ignored" + vbCrLf
                            Exit For
                        Else
                            If (selection = Constants_LanhVC.STR_DUPLICATE_SELECTION_OVERWRITE) Then
                                UpdateVocabulary(objVoc)
                            ElseIf (selection = Constants_LanhVC.STR_DUPLICATE_SELECTION_OVERWRITE) Then
                                'Do nothing
                            End If
                        End If
                    End If
                Next
            End If
            Return strLog
        Catch ex As Exception
            MessageBox.Show(ex.Message + " MergeVoc")
            Return "Import failed" + vbCrLf
        End Try

    End Function
    Function InsertVoc(ByVal objVoc As VocabulariesEntity)
        Dim strSql As String
        'have no time now, in maintainance phase, change all to constant, and use String.Format function
        Try
            strSql = "insert into s3gt_voc(" + Constants_NguyenNB.S3GT_VOC_TOPIC_ID + ","
            strSql += Constants_NguyenNB.S3GT_VOC_KANJI + ","
            strSql += Constants_NguyenNB.S3GT_VOC_HIRAGANA + ","
            strSql += Constants_NguyenNB.S3GT_VOC_MEANING + ","
            strSql += Constants_NguyenNB.S3GT_VOC_TYPE + ","
            strSql += Constants_NguyenNB.S3GT_VOC_EXAMPLE + ")"
            strSql += " values('" + objVoc.TopicID + "',"
            strSql += Utils.Replace(objVoc.Kanji) + ","
            strSql += Utils.Replace(objVoc.Hiragana) + ","
            strSql += Utils.Replace(objVoc.Meaning) + ","
            strSql += Utils.Replace(objVoc.Type) + ","
            strSql += Utils.Replace(objVoc.Example) + ")"
            daoBase.ExecuteNonQuery(strSql)
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try

    End Function

    Public Sub UpdateVocabulary(ByVal objVocEntity As VocabulariesEntity)

        Dim strSQL As String
        Dim objBaseDAO As BaseDAO

        'init
        strSQL = Constants_LanhVC.STR_BLANK_VALUE
        objBaseDAO = Nothing

        'set value for SQL
        strSQL = String.Format(Constants_LanhVC.STR_SQL_VOC_UpdateByID, _
                                Utils.Replace(objVocEntity.Hiragana), _
                                Utils.Replace(objVocEntity.Kanji), _
                                Utils.Replace(objVocEntity.Hannom), _
                                Utils.Replace(objVocEntity.Meaning), _
                                Utils.Replace(objVocEntity.Example), _
                                objVocEntity.Type, _
                                objVocEntity.TopicID, _
                                objVocEntity.VocID)

        'get datatable of voc
        objBaseDAO = New BaseDAO()
        objBaseDAO.ExecuteNonQuery(strSQL)
    End Sub

End Class

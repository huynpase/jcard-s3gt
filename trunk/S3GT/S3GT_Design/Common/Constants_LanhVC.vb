Public Class Constants_LanhVC

    'Value of number
    Public Const INT_COMBOBOX_FIRST_VALUE As Int32 = 0

    'Value of Resource Button
    Public Const INT_OVERRIDE As Int16 = 1
    Public Const INT_MERGE_KANJI As Int16 = 2
    Public Const INT_MERGE_MEANING As Int16 = 3
    Public Const INT_CREATE_NEW As Int16 = 4
    Public Const INT_SKIP As Int16 = 5
    Public Const INT_PROCESS As Int16 = 6

    Public Const INT_SUCCESSFUL As Integer = 1
    Public Const INT_FAIL As Integer = 2


    'Status of Button
    Public Const INT_ENABLE_FALSE As Int16 = 0
    Public Const INT_ENABLE_TRUE As Int16 = 1
    Public Const INT_VISIBLE_FALSE As Int16 = 2
    Public Const INT_VISIBLE_TRUE As Int16 = 3

    'Name of User control
    Public Const STR_USR_VOCABULARIES As String = "usrVocabularies"

    'Name of button
    Public Const STR_SUBMIT As String = "SUBMIT"
    Public Const STR_DELETE As String = "DELETE"
    Public Const STR_MOVE_COPY As String = "MOVE_COPY"
    Public Const STR_CANCEL As String = "CANCEL"

    'Text of button
    Public Const STR_SUBMIT_UPDATE As String = "&Submit Changes"
    Public Const STR_SUBMIT_NEW As String = "&Save"

    'Text value
    Public Const STR_BLANK_VALUE As String = ""
    Public Const STR_COMMA_VALUE As String = ", "

    'text of Type
    Public Const STR_TYPE_NEW As String = "Save"
    Public Const STR_TYPE_UPDATE As String = "Update"
    Public Const STR_TYPE_VIEW As String = "View"

    'Type of Message box
    Public Const STR_MESS_TYPE_WARRING As String = "Warring"
    Public Const STR_MESS_TYPE_ERORR As String = "Error"
    Public Const STR_MESS_TYPE_INFORMATION As String = "Infomation"

    'Check box
    Public Const STR_CHK_CHECK As Integer = True
    Public Const STR_CHK_UNCHECK As Integer = False


    'SQL
    Public Const STR_SQL_VOC_ADDNEW As String = "insert into S3GT_VOC(Topic_ID,Hiragana,Kanji,Hannom, Meaning, Type, Example) values({0},'{1}','{2}','{3}','{4}',{5}, '{6}')"
    Public Const STR_SQL_VOC_GETMAXID As String = "SELECT max(Vocabulary_ID) from S3GT_Voc"
    Public Const STR_SQL_VOC_GETALL As String = "SELECT * from S3GT_VOC"
    Public Const STR_SQL_VOC_GETBYID As String = "SELECT * from S3GT_VOC where Vocabulary_ID = {0}"
    Public Const STR_SQL_VOC_GETDATATABLE_BYTOPIC As String = "SELECT * from S3GT_VOC where Topic_ID ={0}"
    Public Const STR_SQL_VOC_GETDATATABLE_BYTOPIC_ALL_ROWS As String = "SELECT * from S3GT_VOC where Topic_ID ={0}"
    Public Const STR_SQL_VOC_GETDATATABLE_BYTOPIC_XXX_ROWS As String = "SELECT TOP {0} * from S3GT_VOC where Topic_ID ={1}"
    Public Const INT_NUM_PER_PAGE As Integer = 2000

    Public Const STR_SQL_VOC_GETDATATABLE_KANJI As String = "SELECT VOC.Vocabulary_ID, VOC.Topic_ID, VOC.Hiragana, VOC.Kanji, VOC.Meaning, VOC.Type, VOC.Example " & _
                                                   "FROM S3GT_TPC as TPC, S3GT_TPG as TPG, S3GT_VOC as VOC " & _
                                                   "WHERE Topic_Group_Name = '{0}' and Topic_Name = '{1}' and Voc.Kanji = '{2}' and TPG.Topic_Group_ID = TPC.Topic_Group_ID and VOC.Topic_ID = TPC.Topic_ID "

    Public Const STR_SQL_VOC_DELETE_VOC As String = "delete * from S3GT_VOC where Vocabulary_ID = {0}"
    Public Const STR_SQL_VOC_CHECK_EXIST As String = "SELECT * from S3GT_VOC where Hiragana = '{0}'"
    Public Const STR_SQL_VOC_CHECK_EXIST_IN_TOPIC As String = "SELECT * from S3GT_VOC where Hiragana = '{0}' and kanji = '{1}' and Topic_ID ={2}"
    Public Const STR_SQL_VOC_UpdateByID As String = "Update S3GT_VOC set Hiragana ='{0}'  , kanji='{1}' , Hannom='{2}', Meaning='{3}' , Example='{4}' , Type ={5},  Topic_ID={6} where Vocabulary_ID = {7} "

    'SQL TOPIC GROUP - Added by QuanTDA
    Public Const STR_SQL_TPG_ADD_NEW As String = "insert into S3GT_TPG(Topic_Group_Name,Topic_Group_Description) values('{0}','{1}')"
    Public Const STR_SQL_TPG_GETMAXID As String = "SELECT max(Topic_Group_ID) from S3GT_TPG"
    Public Const STR_SQL_TPG_GETALL As String = "SELECT * from S3GT_TPG"
    Public Const STR_SQL_TPG_GET_TOPIC_GROUP_BY_ID As String = "SELECT * from S3GT_TPG where Topic_Group_ID = {0}"
    Public Const STR_SQL_TPG_GET_TOPIC_GROUP_ID_BY_NAME As String = "SELECT TPG.Topic_Group_ID from S3GT_TPG as TPG where TPG.Topic_Group_Name = '{0}'"
    Public Const STR_SQL_TPG_DELETE_TPG As String = "delete * from S3GT_TPG where Topic_Group_ID = {0}"
    Public Const STR_SQL_TPG_CHECK_EXIST As String = "SELECT * from S3GT_TPG where Topic_Group_Name = '{0}'"
    Public Const STR_SQL_TPG_UpdateByID As String = "Update S3GT_TPG set Topic_Group_Name ='{0}'  , Topic_Group_Description='{1}' where Topic_Group_ID = {2} "


    'SQL TOPIC - Added by QuanTDA
    Public Const STR_SQL_TPC_ADDNEW As String = "insert into S3GT_TPC(Topic_Group_ID,Topic_Name,Topic_Description) values({0},'{1}','{2}')"
    Public Const STR_SQL_TPC_GETMAXID As String = "SELECT max(Topic_ID) from S3GT_TPC"
    Public Const STR_SQL_TPC_GETALL As String = "SELECT TPC.Topic_ID, TPC.Topic_Group_ID, TPC.Topic_Name, TPG.Topic_Group_Name, TPC.Topic_Description " & _
                                                "from S3GT_TPC as TPC, S3GT_TPG as TPG where TPG.Topic_Group_ID = TPC.Topic_Group_ID"
    Public Const STR_SQL_TPC_GET_TOPIC_BY_ID As String = "SELECT TPC.Topic_ID," & _
                                                                "TPC.Topic_Group_ID," & _
                                                                "TPC.Topic_Name,TPG.Topic_Group_Name,TPC.Topic_Description " & _
                                                         "from S3GT_TPC as TPC, S3GT_TPG as TPG " & _
                                                         "where TPC.Topic_ID = {0} and TPG.Topic_Group_ID = TPC.Topic_Group_ID"
    Public Const STR_SQL_TPC_GET_TOPIC_BY_Name As String = "SELECT TPC.Topic_ID," & _
                                                            "TPC.Topic_Group_ID," & _
                                                            "TPC.Topic_Name,TPG.Topic_Group_Name,TPC.Topic_Description " & _
                                                     "FROM S3GT_TPC as TPC, (SELECT * FROM S3GT_TPG  WHERE Topic_Group_Name = '{1}') as TPG " & _
                                                     "where TPC.Topic_Name = '{0}' and TPG.Topic_Group_ID = TPC.Topic_Group_ID "

    Public Const STR_SQL_TPC_GETDATATABLE_BY_TOPICGROUP As String = "SELECT TPC.Topic_ID," & _
                                                                           "TPC.Topic_Group_ID," & _
                                                                           "TPC.Topic_Name,TPG.Topic_Group_Name,TPC.Topic_Description " & _
                                                                           "from S3GT_TPC as TPC, S3GT_TPG as TPG " & _
                                                                           "where TPC.Topic_Group_ID = {0} and TPG.Topic_Group_ID = TPC.Topic_Group_ID"
    Public Const STR_SQL_TPC_DELETE_TPC As String = "delete * from S3GT_TPC where Topic_ID = {0}"
    Public Const STR_SQL_TPC_DELETE_VOC_BASEON_TOPICID As String = "delete * from S3GT_VOC where Topic_ID ={0}"
    Public Const STR_SQL_TPC_MOVE_VOC As String = "update  S3GT_VOC  set topic_id = {0} where Topic_ID ={1}"

    Public Const STR_SQL_TPC_CHECK_EXIST As String = "SELECT * from S3GT_TPC where Topic_Name = '{0}'"
    Public Const STR_SQL_TPC_UpdateByID As String = "Update S3GT_TPC set Topic_Name ='{0}'  , Topic_Description='{1}' , Topic_Group_ID={2} where Topic_ID = {3} "

    Public Const STR_SQL_TPC_GET_TOPIC As String = "SELECT TPC.Topic_ID " & _
                                                   "FROM S3GT_TPC as TPC, S3GT_TPG as TPG " & _
                                                   "WHERE Topic_Group_Name = '{0}' and Topic_Name = '{1}' and TPG.Topic_Group_ID = TPC.Topic_Group_ID"

    Public Const STR_SQL_TPC_GET_TOPIC_LIST As String = "SELECT TPC.Topic_ID, TPG.Topic_Group_ID, TPC.Topic_Name, TPC.Topic_Description " & _
                                                   "FROM S3GT_TPC as TPC, S3GT_TPG as TPG " & _
                                                   "WHERE TPG.Topic_Group_Name = '{0}' and TPC.Topic_Group_ID = TPG.Topic_Group_ID"

    Public Const STR_SQL_TPC_GET_TOPIC_BY_GROUP_NAME_TOPIC_NAME As String = "SELECT TPC.Topic_ID, TPG.Topic_Group_ID, TPC.Topic_Name, TPC.Topic_Description " & _
                                               "FROM S3GT_TPC as TPC, S3GT_TPG as TPG " & _
                                               "WHERE TPG.Topic_Group_Name = '{0}' and TPC.Topic_Name = '{1}' and TPC.Topic_Group_ID = TPG.Topic_Group_ID"

    'sql check vocabulary duplicate - added by MinhLN2
    Public Const STR_SQL_CHECK_VOC_DUP As String = "SELECT * FROM S3GT_VOC where Topic_ID = {0} and " & _
                                                    "Kanji = '{1}' and Hiragana = '{2}' and Vocabulary_ID <> {3}"

    'Filter criteria - added by QuanTDA
    Public Const STR_VOC_TABLE_FILTER_BY_HIRAGANA As String = "Hiragana = '{0}'" 'Filter Vocabularies row by Hiragana or Katakana
    Public Const STR_TPC_FILTER_BY_TOPIC_GROUP_ID = "Topic_Group_ID={0}" ' Filter Topics rows by their Topic_Group_ID

    'Data - added by QuanTDA
    Public Const INT_NO_RECORD As Integer = 0
    Public Const INT_FIRST_TOPIC_INDEX_IN_TOPIC_GROUP As Integer = 0

    'Check box
    Public Const INT_CHECK = 1
    Public Const INT_UNCHECK = 0

    'Type of Vocabulary
    Public Const STR_VOC_TYPE_NOUN As String = "Noun"
    Public Const STR_VOC_TYPE_PRO As String = "Pro-noun"
    Public Const STR_VOC_TYPE_VI As String = "Verb (Intransitive)"
    Public Const STR_VOC_TYPE_VT As String = "Verb (Transitive)"
    Public Const STR_VOC_TYPE_I As String = "I Adj"
    Public Const STR_VOC_TYPE_NA As String = "NA Adj"
    Public Const STR_VOC_TYPE_PREP As String = "Prep"

    'Vocabularies Table Column Names
    Public Const STR_VOC_COLUMN_NAME_VOCABULARY_ID As String = "Vocabulary_ID"
    Public Const STR_VOC_COLUMN_NAME_TOPIC_ID As String = "Topic_ID"
    Public Const STR_VOC_COLUMN_NAME_HIRAGANA As String = "Hiragana"
    Public Const STR_VOC_COLUMN_NAME_KANJI As String = "Kanji"
    Public Const STR_VOC_COLUMN_NAME_HANNOM As String = "Hannom"
    Public Const STR_VOC_COLUMN_NAME_MEANING As String = "Meaning"
    Public Const STR_VOC_COLUMN_NAME_TYPE As String = "Type"
    Public Const STR_VOC_COLUMN_NAME_EXAMPLE As String = "Example"

    Public Const INT_VOC_DB_COLUMN_VOCID As Int32 = 0
    Public Const INT_VOC_DB_COLUMN_TOPICID As Int32 = 1
    Public Const INT_VOC_DB_COLUMN_HIGARANA As Int32 = 2
    Public Const INT_VOC_DB_COLUMN_KANJI As Int32 = 3
    Public Const INT_VOC_DB_COLUMN_HANNOM As Int32 = 4
    Public Const INT_VOC_DB_COLUMN_MEANING As Int32 = 5
    Public Const INT_VOC_DB_COLUMN_TYPE As Int32 = 6
    Public Const INT_VOC_DB_COLUMN_EXAMPLE As Int32 = 7

    'Column in datagrid
    Public Const INT_VOC_COLUMN_CHECKBOX As Int32 = 0
    Public Const INT_VOC_COLUMN_KANJI As Int32 = 1
    Public Const INT_VOC_COLUMN_HIGARANA As Int32 = 2
    Public Const INT_VOC_COLUMN_HANNOM As Int32 = 3
    Public Const INT_VOC_COLUMN_MEANING As Int32 = 4
    Public Const INT_VOC_COLUMN_TYPE As Int32 = 5
    Public Const INT_VOC_COLUMN_VOCID As Int32 = 6
    Public Const INT_VOC_COLUMN_EXAMPLE As Int32 = 7

    Public Const INT_GRID_COLUMN_VOCID As Int32 = 6

    'Table Column Names in Search Form - Add by MinhLN2

    Public Const INT_VOC_DB_SEARCH_COLUMN_VOCID As Int32 = 7
    Public Const INT_VOC_DB_SEARCH_COLUMN_TOPICID As Int32 = 3
    Public Const INT_VOC_DB_SEARCH_COLUMN_HIGARANA As Int32 = 9
    Public Const INT_VOC_DB_SEARCH_COLUMN_KANJI As Int32 = 10
    Public Const INT_VOC_DB_SEARCH_COLUMN_HANNOM As Int32 = 11
    Public Const INT_VOC_DB_SEARCH_COLUMN_MEANING As Int32 = 12
    Public Const INT_VOC_DB_SEARCH_COLUMN_TYPE As Int32 = 13
    Public Const INT_VOC_DB_SEARCH_COLUMN_EXAMPLE As Int32 = 14
    Public Const INT_VOC_DB_SEARCH_COLUMN_TOPICGROUPNAME As Int32 = 1
    Public Const INT_VOC_DB_SEARCH_COLUMN_TOPICNAME As Int32 = 5


    Public Const INT_VOC_SEARCH_COLUMN_VOCID As Int32 = 8
    Public Const INT_VOC_SEARCH_COLUMN_TOPICID As Int32 = 10
    Public Const INT_VOC_SEARCH_COLUMN_HIGARANA As Int32 = 4
    Public Const INT_VOC_SEARCH_COLUMN_KANJI As Int32 = 3
    Public Const INT_VOC_SEARCH_COLUMN_HANNOM As Int32 = 5
    Public Const INT_VOC_SEARCH_COLUMN_MEANING As Int32 = 6
    Public Const INT_VOC_SEARCH_COLUMN_TYPE As Int32 = 7
    Public Const INT_VOC_SEARCH_COLUMN_EXAMPLE As Int32 = 9
    Public Const INT_VOC_SEARCH_COLUMN_TOPICGROUPNAME As Int32 = 1
    Public Const INT_VOC_SEARCH_COLUMN_TOPICNAME As Int32 = 2

    'Topic Groups Table Column Names
    Public Const STR_TPG_COLUMN_NAME_TOPIC_GROUP_ID As String = "Topic_Group_ID"
    Public Const STR_TPG_COLUMN_NAME_TOPIC_GROUP_NAME As String = "Topic_Group_Name"
    Public Const STR_TPG_COLUMN_NAME_TOPIC_GROUP_DESCRIPTION As String = "Topic_Group_Description"

    Public Const INT_DEFAULT_TOPIC_GROUP_INDEX As Integer = 0

    Public Const STR_TPG_TABLE_FILTER_BY_TOPIC_GROUP_NAME As String = "Topic_Group_Name = '{0}'"

    'Topics Table Column Names
    Public Const STR_TPC_COLUMN_NAME_TOPIC_ID As String = "Topic_ID"
    Public Const STR_TPC_COLUMN_NAME_TOPIC_GROUP_ID As String = "Topic_Group_ID"
    Public Const STR_TPC_COLUMN_NAME_TOPIC_NAME As String = "Topic_Name"
    Public Const STR_TPC_COLUMN_NAME_TOPIC_GROUP_NAME As String = "Topic_Group_Name"
    Public Const STR_TPC_COLUMN_NAME_TOPIC_DESCRIPTION As String = "Topic_Description"

    Public Const INT_DEFAULT_TOPIC_INDEX As Integer = 0

    Public Const STR_PROJECT_NAME As String = "S3GT"
    Public Const STR_GROUP_TEXT As String = "Uncategorized Topics"
    Public Const STR_TOPIC_TEXT As String = "Unknown topic"

    'Message for Perform Vocabulary Test function

    'Test constants
    Public Const STR_TEST_GET_VOCABULARIES As String = "Select * from S3GT_VOC where Topic_ID in ({0}) and {1}"
    Public Const STR_TEST_FILTER_BY_TYPE As String = "Type = {0}"
    Public Const STR_TEST_ANY As String = "Any"
    Public Const STR_TEST_ANY_TYPE_FILTER = "1=1"
    Public Const STR_TEST_NO_TOPIC_GROUP_NAME As String = "{}"
    Public Const STR_TEST_TRYING_BEST_MSG As String = "Try your best!"
    Public Const STR_TEST_BELOW_MIN_WORD_COUNT_MSG As String = "The number of words is less than 5. Please choose another dictionary"
    Public Const STR_TEST_WARNING_CAPTION As String = "Lack of Words"
    Public Const STR_TEST_SUCCESFULLY_LOADING_MSG As String = "All words in datasheet has been loaded. You can the test now!"
    Public Const STR_TEST_LOAD_OK_CAPTION As String = "Loading words sucessfully"
    Public Const STR_TEST_GLOSSARY_LOADING_ERROR_MSG As String = "Error while loading vocabularies. Please try another dictionary!"
    Public Const STR_TEST_GLOSSARY_LOADING_ERROR_CAPTION As String = "Error in data loading"
    Public Const STR_TEST_WELL_DONE_MSG As String = "Well done!"
    Public Const STR_TEST_TOO_SLOW_MSG As String = "Too slow!"
    Public Const STR_TEST_WRONG_ANSWER_MSG As String = "Wrong answer!"
    Public Const INT_TEST_NO_ANSWER_RESULT As Integer = 0
    Public Const INT_TEST_RIGHT_RESULT = 1
    Public Const INT_TEST_WRONG_RESULT = 2
    Public Const INT_TEST_MISSED_RESULT = 3

    Public Const INT_TEST_DECREASE_BY_ONE_SECOND As Integer = 1
    Public Const INT_TEST_TIMER_ONE_SECOND As Integer = 1000
    Public Const STR_TEST_CHOOSE_TOPICS As String = "Please select Topics again!"
    Public Const STR_TEST_END_OF_TEST_MSG As String = "You get the end of the test. Please press Finish to finish the test!"
    Public Const STR_TEST_END_OF_TEST_CAPTION As String = "End of the test"
    Public Const STR_TEST_MUST_CHOOSE_TOPICS_MSG As String = "At least a Topic must be chosen."
    Public Const STR_TEST_NO_CHOSEN_TOPICS_CAPTION As String = "No Topic selected"
    Public Const STR_TEST_WARNING_SAME_CHARACTER_TYPE_MSG As String = "Character type to display and character type of answers cannot be the same"
    Public Const STR_TEST_WARNING_SAME_CHARACTER_TYPE_CAPTION As String = "Same character type"
    Public Const STR_TEST_ASKING_FINISHING_TEST_CONFIRMATION_MSG As String = "Are you sure to finish the test?"
    Public Const STR_TEST_WARNING As String = "Warning"
    Public Const STR_TEST_TEST_NOT_STARTED_YET As String = "You have not started a Test."
    Public Const STR_TEST_ERROR As String = "Error!"
    Public Const STR_TEST_SAVED_FOLDER_PATH As String = "SavedTest"
    Public Const STR_TEST_FOLDER_PATH_SEPARATOR As String = "\"
    Public Const STR_TEST_SAVED_FILE_EXTENSION As String = ".s3gt"
    Public Const STR_TEST_CHECK_BY_VOCABULARY_ID = Constants_LanhVC.STR_VOC_COLUMN_NAME_VOCABULARY_ID & " = " & "{0}"
    Public Const STR_TEST_INFO_FILTER_BY_TOPIC_ID = Constants_LanhVC.STR_VOC_COLUMN_NAME_TOPIC_ID & " = " & "{0}"

    'saved Test information constants
    Public Const STR_TEST_INFO_TOPICS As String = "Topics:"
    Public Const STR_TEST_INFO_TEST_LANGUAGE As String = "Test language:"
    Public Const STR_TEST_INFO_ANSWER_LANGUAGE As String = "Answer language:"
    Public Const STR_TEST_INFO_VOC_TYPE As String = "Vocabularies type:"
    Public Const STR_TEST_INFO_TEST_MODE As String = "Test mode:"
    Public Const STR_TEST_INFO_VOC_IDS As String = "Vocabulary IDs:"
    Public Const STR_TEST_INFO_NUM_PASSED_QUEST As String = "Number of Passed Question:"
    Public Const STR_TEST_INFO_NUM_RIGHT_ANS As String = "Number of Right Answer:"
    Public Const STR_TEST_INFO_NUM_WRONG_ANS As String = "Number of Wrong Answer:"
    Public Const STR_TEST_INFO_NUM_UNANS_QUEST As String = "Number of Unanswered Question:"
    Public Const STR_TEST_INFO_PASSED_VOC_IDS As String = "Passed Vocabulary IDs:"
    Public Const STR_TEST_INFO_TOTAL_TIME_LEFT As String = "Total time left:"

    Public Const INT_TEST_NO_ANSWER_INDEX As Integer = 0
    Public Const INT_TEST_RIGHT_ANSWER_INDEX As Integer = 1
    Public Const INT_TEST_WRONG_ANSWER_INDEX As Integer = 2
    Public Const INT_TEST_MAX_ANSWER_BY_QUESTION_INDEX As Integer = 5
    Public Const INT_TEST_FIRST_ANSWER_OF_QUESTION_INDEX As Integer = 1
    Public Const INT_TEST_MIN_NUMBER_OF_ANSWER_FOR_A_VOC As Integer = 2
    Public Const INT_TEST_MIN_WORD_COUNT As Integer = 5
    
    
    'Value of message box

    Public Const STR_MSG_INFO_001 As String = "New Topic has been created"
    Public Const STR_MSG_INFO_002 As String = "Topic information has been updated."
    Public Const STR_MSG_INFO_003 As String = "New Vocabularies has been added."
    Public Const STR_MSG_INFO_004 As String = "Vocabulary(ies) has been updated."
    Public Const STR_MSG_INFO_005 As String = "Are you sure you want  to delete these Vocabularies?"
    Public Const STR_MSG_INFO_006 As String = "Vocabularies has been deleted."
    Public Const STR_MSG_INFO_007 As String = "Vocabularies has been moved/copy to the new Topics."
    Public Const STR_MSG_INFO_008 As String = "A new Topic Group has been created."
    Public Const STR_MSG_INFO_009 As String = "This Topic Group has been updated."
    Public Const STR_MSG_INFO_010 As String = "Are you sure you want to delete this Topic Group?"
    Public Const STR_MSG_INFO_011 As String = "Topic Group has been deleted."
    Public Const STR_MSG_INFO_012 As String = "Are you sure you want to delete this Topic?"
    Public Const STR_MSG_INFO_013 As String = "Topic Group has been deleted."
    Public Const STR_MSG_INFO_014 As String = "A new single-Kanji has been created."
    Public Const STR_MSG_INFO_015 As String = "Single-Kanji has been updated."
    Public Const STR_MSG_INFO_021 As String = "The export process has been finished. Do you want to view the log file?"
    Public Const STR_MSG_INFO_022 As String = "The import process has been finished. Do you want to view the log file?"
    Public Const STR_MSG_INFO_023 As String = "Are you sure you want to exit S3GT?"

    Public Const STR_MSG_ERR_001 As String = "Topic name cannot be blank."
    Public Const STR_MSG_ERR_002 As String = "A Topic has exists with input Topic Group name and Topic name. Please input other Topic Group name or Topic name."
    Public Const STR_MSG_ERR_003 As String = "Another vocabulary with the same Hiragana and belongs to the same Topic existed. " & STR_NEW_LINE & STR_NEW_LINE & "Please choose your preferred action."
    Public Const STR_MSG_ERR_004 As String = "Vocabulary at row {0}th is invalid. Kanji and Hiragana cannot be blank."
    Public Const STR_MSG_ERR_005 As String = "Another vocabulary with the same Hiragana and belongs to the same Topic existed. " & STR_NEW_LINE & STR_NEW_LINE & "Do you want to continue?"
    Public Const STR_MSG_ERR_006 As String = "Vocabulary to search cannot be blank or space."
    Public Const STR_MSG_ERR_007 As String = "Topic Group name cannot be blank"
    Public Const STR_MSG_ERR_008 As String = "A Topic Group exists with the input Topic Group name. Please input another Topic Group name."
    Public Const STR_MSG_ERR_009 As String = "Kanji value cannot be blank or  space"
    Public Const STR_MSG_ERR_010 As String = "A single-Kanji exists with the input Kanji value. Please input another Kanji value."
    Public Const STR_MSG_ERR_011 As String = "Kanji value cannot be longer than a character"
    Public Const STR_MSG_ERR_012 As String = "Kanji value of the single-Kanji to search cannot be blank or space."
    Public Const STR_MSG_ERR_013 As String = "Destination file path and file name cannot be blank."
    Public Const STR_MSG_ERR_014 As String = "Destination file path is invalid."
    Public Const STR_MSG_ERR_015 As String = "File path of the exported Kakikata image files folder  cannot be blank."
    Public Const STR_MSG_ERR_016 As String = "File path of the exported Kakikata image files folder  is invalid."
    Public Const STR_MSG_ERR_017 As String = "Source file path and file name cannot be blank."
    Public Const STR_MSG_ERR_018 As String = "Source file path is invalid."
    Public Const STR_MSG_ERR_019 As String = "File path of the imported Kakikata image files folder  cannot be blank."
    Public Const STR_MSG_ERR_020 As String = "File path of the imported Kakikata image files folder  is invalid."
    Public Const STR_MSG_TOPIC_GROUP_HAS_CHILD As String = "The Topic Group has some Topics. Do you want to continue?"

    Public Const STR_VOC_NO_VOCABULARY_IN_GRID As String = "No Vocabulary in the grid to save.Please input at least a Vocabulary."
    Public Const STR_MSG_RELOAD_SCREEN_CONFIRMATION As String = "This feature will impact the current displayed screen." _
                                                                & " The screen need to be reloaded." & vbCrLf _
                                                                & "Do you want to continue?"
    Public Const STR_MSG_ERR_CODING As String = "Error coding"


    'Commont
    Public Const STR_NEW_LINE As String = Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)

    'Parameters table - Added by QuanTDA
    Public Const STR_SQL_PARAM_ADD_NEW As String = "insert into S3GT_PAR(Parameter_Name,Parameter_Value,Parameter_Description) values('{0}','{1}','{2}')"
    Public Const STR_SQL_PARAM_GETALL As String = "SELECT * from S3GT_TPG"
    Public Const STR_SQL_PARAM_GET_PARAM_BY_NAME As String = "SELECT * from S3GT_PAR where Parameter_Name = '{0}'"
    Public Const STR_SQL_PARAM_DELETE_PARAM As String = "delete * from S3GT_PAR where Parameter_Name = '{0}'"
    Public Const STR_SQL_PARAM_CHECK_EXIST As String = "SELECT * from S3GT_PAR where Parameter_Name = '{0}'"
    Public Const STR_SQL_PARAM_UPDATE_BY_NAME As String = "Update S3GT_PAR set Parameter_Value = '{0}' , Parameter_Description='{1}' where Parameter_Name = '{2}' "

    'Parameters Table Column Names
    Public Const STR_PARAM_COLUMN_NAME_PARAMETER_NAME As String = "Parameter_Name"
    Public Const STR_PARAM_COLUMN_NAME_PARAMETER_VALUE As String = "Parameter_Value"
    Public Const STR_PARAM_COLUMN_NAME_PARAMETER_DESCRIPTION As String = "Parameter_Description"

    Public Const STR_PARAM_TABLE_FILTER_BY_PARAM_NAME As String = "Parameter_Name = '{0}'"

    'Parameter Names - Added by QuanTDA
    Public Const STR_PARAM_LAST_CHOSEN_TOPIC_GROUP_ID As String = "LAST_CHOSEN_TOPIC_GROUP_ID"
    Public Const STR_PARAM_LAST_CHOSEN_TOPIC_ID As String = "LAST_CHOSEN_TOPIC_ID"

    'Default Values - Added by QuanTDA - Date: 31 Aug 2009
    Public Const INT_DEFAULT_LAST_CHOSEN_TOPIC_GROUP_ID As Integer = 1
    Public Const INT_DEFAULT_LAST_CHOSEN_TOPIC_ID As Integer = 1

    Public Const STR_COLUMN_CHECK_DUPLICATED As String = "checkDuplicated"

    Public Const STR_CONFIG_EXPORT_VOC_PATH As String = "CONFIG_EXPORT_VOC_PATH"
    Public Const STR_CONFIG_EXPORT_KANJI_PATH As String = "CONFIG_EXPORT_KANJI_PATH"
    Public Const STR_CONFIG_EXPORT_KANJI_IMAGE_PATH As String = "CONFIG_EXPORT_KANJI_IMAGE_PATH"

    Public Const STR_DUPLICATE_SELECTION_OVERWRITE As String = "Overwrite"
    Public Const STR_DUPLICATE_SELECTION_SKIP As String = "Skip"



End Class

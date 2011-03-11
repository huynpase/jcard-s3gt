Public Class Constants_PhatLS
    Public Const CUSTOM_CONTENT_HEIGHT As Int32 = 30

    'String
    Public Const STR_Kanji_ID = "Kanji_ID"
    Public Const STR_Kanji = "Kanji"
    Public Const STR_HanNom = "HanNom"
    Public Const STR_Kunyomi = "Kunyomi"
    Public Const STR_Onyomi = "Onyomi"
    Public Const STR_Meaning = "Meaning"

    'Type of VOC
    Public Const STR_VOC_TYPE_NOUN As String = "Noun"
    Public Const STR_VOC_TYPE_PRO As String = "Pro-noun"
    Public Const STR_VOC_TYPE_VI As String = "Verb (Intransitive)"
    Public Const STR_VOC_TYPE_VT As String = "Verb (Transitive)"
    Public Const STR_VOC_TYPE_I As String = "I Adj"
    Public Const STR_VOC_TYPE_NA As String = "NA Adj"
    Public Const STR_VOC_TYPE_PREP As String = "Prep"

    'Column of datagrid dgSearchVoc
    Public Const STR_SEARCH_VOC_COLUMN_TPGNAME As Int16 = 0
    Public Const STR_SEARCH_VOC_COLUMN_TOPICNAME As Int16 = 1
    Public Const STR_SEARCH_VOC_COLUMN_HIRAGANA As Int16 = 2
    Public Const STR_SEARCH_VOC_COLUMN_KANJI As Int16 = 3
    Public Const STR_SEARCH_VOC_COLUMN_MEANING As Int16 = 4
    Public Const STR_SEARCH_VOC_COLUMN_TYPE As Int16 = 5
    Public Const STR_SEARCH_VOC_COLUMN_ID As Int16 = 6

    'Column of datagrid in Create/Update Single_Kanji
    Public Const STR_CREATE_UPDATE_SINGLE_KANJI_COLUMN_CHECKBOX As Int16 = 0
    Public Const STR_CREATE_UPDATE_SINGLE_KANJI_COLUMN_KANJI As Int16 = 1
    Public Const STR_CREATE_UPDATE_SINGLE_KANJI_COLUMN_HANNOM As Int16 = 2
    Public Const STR_CREATE_UPDATE_SINGLE_KANJI_COLUMN_KUNYOMI As Int16 = 3
    Public Const STR_CREATE_UPDATE_SINGLE_KANJI_COLUMN_ONYOMI As Int16 = 4
    Public Const STR_CREATE_UPDATE_SINGLE_KANJI_COLUMN_MEANING As Int16 = 5
    Public Const STR_CREATE_UPDATE_SINGLE_KANJI_COLUMN_KAKIKATA As Int16 = 6
    Public Const STR_CREATE_UPDATE_SINGLE_KANJI_COLUMN_ID As Int16 = 7

    'Column of datagrid in Search Single_Kanji
    Public Const STR_SEARCH_SINGLE_KANJI_COLUMN_KANJI As Int16 = 0
    Public Const STR_SEARCH_SINGLE_KANJI_COLUMN_HANNOM As Int16 = 1
    Public Const STR_SEARCH_SINGLE_KANJI_COLUMN_KUNYOMI As Int16 = 2
    Public Const STR_SEARCH_SINGLE_KANJI_COLUMN_ONYOMI As Int16 = 3
    Public Const STR_SEARCH_SINGLE_KANJI_COLUMN_MEANING As Int16 = 4
    Public Const STR_SEARCH_SINGLE_KANJI_COLUMN_KAKIKATA As Int16 = 5
    Public Const STR_SEARCH_SINGLE_KANJI_COLUMN_EDIT As Int16 = 6

    'Vocabularies Table Column Names for search
    Public Const STR_VOC_COLUMN_NAME_HIGARANA As String = "Higarana"
    Public Const STR_VOC_COLUMN_NAME_KANJI As String = "Kanji"
    Public Const STR_VOC_COLUMN_NAME_HANNOM As String = "Hán Nôm"
    Public Const STR_VOC_COLUMN_NAME_MEANING As String = "Meaning"
    Public Const STR_VOC_COLUMN_NAME_TYPE As String = "Type"
    Public Const STR_VOC_COLUMN_NAME_TYPE_IN_STRING As String = "TypeInString"


    Public Const INT_VOC_DB_COLUMN_TYPE_IN_STRING As Int32 = 14
    Public Const INT_VOC_DB_COLUMN_TYPE As Int32 = 13
    Public Const INT_VOC_DB_COLUMN_MEANING As Int32 = 12
    Public Const INT_VOC_DB_COLUMN_HANNOM As Int32 = 11
    Public Const INT_VOC_DB_COLUMN_KANJI As Int32 = 10
    Public Const INT_VOC_DB_COLUMN_HIGARANA As Int32 = 9
    Public Const INT_VOC_DB_COLUMN_TOPICID As Int32 = 8
    Public Const INT_VOC_DB_COLUMN_VOCID As Int32 = 7
    Public Const INT_VOC_DB_COLUMN_TOPICNAME As Int32 = 5
    Public Const INT_VOC_DB_COLUMN_TOPICGROUPNAME As Int32 = 1
    'Column Headers for Seacrh
    Public Const STR_VOC_COLUMN_HIRAGANA_HEADER_TEXT As String = "Reading"
    Public Const STR_VOC_COLUMN_TYPE_HEADER_TEXT As String = "Type"
    Public Const STR_VOC_COLUMN_TOPICGROUPNAME_HEADER_TEXT As String = "Topic Group"
    Public Const STR_VOC_COLUMN_TOPICNAME_HEADER_TEXT As String = "Topic"
    'Topics Table Column Names
    Public Const STR_TPC_COLUMN_NAME_TOPIC_ID As String = "Topic_ID"
    Public Const STR_TPC_COLUMN_NAME_TOPIC_GROUP_ID As String = "Topic_Group_ID"
    Public Const STR_TPC_COLUMN_NAME_TOPIC_NAME As String = "Topic_Name"
    Public Const STR_TPC_COLUMN_NAME_TOPIC_GROUP_NAME As String = "Topic_Group_Name"
    Public Const STR_TPC_COLUMN_NAME_TOPIC_DESCRIPTION As String = "Topic_Description"

    'text of Type
    Public Const STR_TYPE_NEW As String = "Add New"
    Public Const STR_TYPE_UPDATE As String = "Update"
    Public Const STR_TYPE_VIEW As String = "View"
    Public Const STR_TYPE_SUBMIT As String = "Submit"

    'Existed that Single_Kanji
    Public Const STR_EXISTED_SINGLE_KANJI As Boolean = True
    Public Const STR_UNEXISTED_SINGLE_KANJI As Boolean = False

    'Enable
    Public Const STR_TYPE_ENABLE_TRUE As Boolean = True
    Public Const STR_TYPE_ENABLE_FALSE As Boolean = False

    'Type of image is supported to view Kakikata
    Public Const STR_TYPE_IMAGE As String = ".gif"

    'Not define Kanji
    Public Const STR_KANJI_DEFINE As String = " is not defined"

    'Value of checkbox in datagrid
    Public Const STR_TYPE_CHECKED As Boolean = True
    Public Const STR_TYPE_UNCHECKED As Boolean = False

    'File existed or not
    Public Const STR_EXISTED_IMAGE As Boolean = True
    Public Const STR_UNEXISTED_IMAGE As Boolean = False

    'Confirm 
    Public Const STR_MSG_SINGLE_KANJI_DELETE As String = "Are you sure you want  to delete these Single-Kanji(es)?"

    'Tool Tip show
    Public Const STR_MSG_TOOLTIP As String = "Choose a single Kanji, right click to show meaning"
    'Text value
    Public Const STR_BLANK_VALUE As String = ""

    'Image source
    Public Const STR_SOURCE_KANJI_IMAGE As String = "\KanjiImage\" '"\resources\"

    'Type of Message box
    Public Const STR_MESS_TYPE_WARRING As String = "Warring"
    Public Const STR_MESS_TYPE_ERORR As String = "Error"
    Public Const STR_MESS_TYPE_INFORMATION As String = "Infomation"

    'Browse folder
    Public Const STR_BROWSER_FOLDER As String = "gif files (*.gif)|*.gif"

    'Length of Kanji
    Public Const NUM_LENGTH_KANJI As Int16 = 1
    Public Const NUM_MIN_LIMIT_KANJI As Int32 = 19968
    Public Const NUM_MAX_LIMIT_KANJI As Int32 = 40879

    'SQL
    Public Const STR_SQL_VOCABULARY_SEARCH_HIRAGANA As String = "SELECT S3GT_TPG.*, S3GT_TPC.*, S3GT_VOC.* " & _
                                                            "from S3GT_VOC,S3GT_TPC,S3GT_TPG " & _
                                                            "where S3GT_VOC.Topic_ID=S3GT_TPC.Topic_ID " & _
                                                            "and S3GT_TPC.Topic_Group_ID=S3GT_TPG.Topic_Group_ID " & _
                                                            "and S3GT_TPC.Topic_Group_ID={0} " & _
                                                            "and S3GT_VOC.Hiragana like '%{1}%' " & _
                                                            "and  S3GT_TPC.Topic_Name = '{2}'"
    Public Const STR_SQL_VOCABULARY_SEARCH_KANJI As String = "SELECT S3GT_TPG.*, S3GT_TPC.*, S3GT_VOC.* " & _
                                                            "from S3GT_VOC,S3GT_TPC,S3GT_TPG " & _
                                                            "where S3GT_VOC.Topic_ID=S3GT_TPC.Topic_ID " & _
                                                            "and S3GT_TPC.Topic_Group_ID=S3GT_TPG.Topic_Group_ID " & _
                                                            "and S3GT_TPC.Topic_Group_ID={0} " & _
                                                            "and S3GT_VOC.Kanji like '%{1}%' " & _
                                                            "and  S3GT_TPC.Topic_Name = '{2}'"
    Public Const STR_SQL_VOCABULARY_SEARCH_HANNOM As String = "SELECT S3GT_TPG.*, S3GT_TPC.*, S3GT_VOC.* " & _
                                                            "from S3GT_VOC,S3GT_TPC,S3GT_TPG " & _
                                                            "where S3GT_VOC.Topic_ID=S3GT_TPC.Topic_ID " & _
                                                            "and S3GT_TPC.Topic_Group_ID=S3GT_TPG.Topic_Group_ID " & _
                                                            "and S3GT_TPC.Topic_Group_ID={0} " & _
                                                            "and S3GT_VOC.Hannom like '%{1}%' " & _
                                                            "and  S3GT_TPC.Topic_Name = '{2}'"
    Public Const STR_SQL_VOCABULARY_SEARCH_MEANING As String = "SELECT S3GT_TPG.*, S3GT_TPC.*, S3GT_VOC.* " & _
                                                            "from S3GT_VOC,S3GT_TPC,S3GT_TPG " & _
                                                            "where S3GT_VOC.Topic_ID=S3GT_TPC.Topic_ID " & _
                                                            "and S3GT_TPC.Topic_Group_ID=S3GT_TPG.Topic_Group_ID " & _
                                                            "and S3GT_TPC.Topic_Group_ID={0} " & _
                                                            "and S3GT_VOC.Meaning like '%{1}%' " & _
                                                            "and  S3GT_TPC.Topic_Name = '{2}'"
    'SQL for SEARCH VOC when TOPIC NAME IS NULL
    Public Const STR_SQL_VOCABULARY_SEARCH_HIRAGANA_TPNNULL As String = "SELECT S3GT_TPG.*, S3GT_TPC.*, S3GT_VOC.* " & _
                                                            "from S3GT_VOC,S3GT_TPC,S3GT_TPG " & _
                                                            "where S3GT_VOC.Topic_ID=S3GT_TPC.Topic_ID " & _
                                                            "and S3GT_TPC.Topic_Group_ID=S3GT_TPG.Topic_Group_ID " & _
                                                            "and S3GT_TPC.Topic_Group_ID={0} " & _
                                                            "and S3GT_VOC.Hiragana like '%{1}%' "
    Public Const STR_SQL_VOCABULARY_SEARCH_KANJI_TPNNULL As String = "SELECT S3GT_TPG.*, S3GT_TPC.*, S3GT_VOC.* " & _
                                                            "from S3GT_VOC,S3GT_TPC,S3GT_TPG " & _
                                                            "where S3GT_VOC.Topic_ID=S3GT_TPC.Topic_ID " & _
                                                            "and S3GT_TPC.Topic_Group_ID=S3GT_TPG.Topic_Group_ID " & _
                                                            "and S3GT_TPC.Topic_Group_ID={0} " & _
                                                            "and S3GT_VOC.Kanji like '%{1}%' "
    Public Const STR_SQL_VOCABULARY_SEARCH_HANNOM_TPNNULL As String = "SELECT S3GT_TPG.*, S3GT_TPC.*, S3GT_VOC.* " & _
                                                            "from S3GT_VOC,S3GT_TPC,S3GT_TPG " & _
                                                            "where S3GT_VOC.Topic_ID=S3GT_TPC.Topic_ID " & _
                                                            "and S3GT_TPC.Topic_Group_ID=S3GT_TPG.Topic_Group_ID " & _
                                                            "and S3GT_TPC.Topic_Group_ID={0} " & _
                                                            "and S3GT_VOC.Hannom like '%{1}%' "

    Public Const STR_SQL_VOCABULARY_SEARCH_MEANING_TPNNULL As String = "SELECT S3GT_TPG.*, S3GT_TPC.*, S3GT_VOC.* " & _
                                                                "from S3GT_VOC,S3GT_TPC,S3GT_TPG " & _
                                                                "where S3GT_VOC.Topic_ID=S3GT_TPC.Topic_ID " & _
                                                                "and S3GT_TPC.Topic_Group_ID=S3GT_TPG.Topic_Group_ID " & _
                                                                "and S3GT_TPC.Topic_Group_ID={0} " & _
                                                                "and S3GT_VOC.Meaning like '%{1}%' "
    'SQL for SEARCH VOC when TOPIC GROUP NAME IS NULL
    Public Const STR_SQL_VOCABULARY_SEARCH_HIRAGANA_TPGNULL As String = "SELECT S3GT_TPG.*, S3GT_TPC.*, S3GT_VOC.* " & _
                                                            "from S3GT_VOC,S3GT_TPC,S3GT_TPG " & _
                                                            "where S3GT_VOC.Topic_ID=S3GT_TPC.Topic_ID " & _
                                                            "and S3GT_TPC.Topic_Group_ID=S3GT_TPG.Topic_Group_ID " & _
                                                            "and S3GT_VOC.Hiragana like '%{0}%' "
    Public Const STR_SQL_VOCABULARY_SEARCH_KANJI_TPGNULL As String = "SELECT S3GT_TPG.*, S3GT_TPC.*, S3GT_VOC.* " & _
                                                            "from S3GT_VOC,S3GT_TPC,S3GT_TPG " & _
                                                            "where S3GT_VOC.Topic_ID=S3GT_TPC.Topic_ID " & _
                                                            "and S3GT_TPC.Topic_Group_ID=S3GT_TPG.Topic_Group_ID " & _
                                                            "and S3GT_VOC.Kanji like '%{0}%' "
    Public Const STR_SQL_VOCABULARY_SEARCH_HANNOM_TPGNULL As String = "SELECT S3GT_TPG.*, S3GT_TPC.*, S3GT_VOC.* " & _
                                                            "from S3GT_VOC,S3GT_TPC,S3GT_TPG " & _
                                                            "where S3GT_VOC.Topic_ID=S3GT_TPC.Topic_ID " & _
                                                            "and S3GT_TPC.Topic_Group_ID=S3GT_TPG.Topic_Group_ID " & _
                                                            "and S3GT_VOC.Hannom like '%{0}%' "

    Public Const STR_SQL_VOCABULARY_SEARCH_MEANING_TPGNULL As String = "SELECT S3GT_TPG.*, S3GT_TPC.*, S3GT_VOC.* " & _
                                                                "from S3GT_VOC,S3GT_TPC,S3GT_TPG " & _
                                                                "where S3GT_VOC.Topic_ID=S3GT_TPC.Topic_ID " & _
                                                                "and S3GT_TPC.Topic_Group_ID=S3GT_TPG.Topic_Group_ID " & _
                                                                "and S3GT_VOC.Meaning like '%{0}%' "
    'Start searchBy = Start with
    Public Const STR_SQL_VOCABULARY_SEARCH_HIRAGANA_START As String = "SELECT S3GT_TPG.*, S3GT_TPC.*, S3GT_VOC.* " & _
                                                           "from S3GT_VOC,S3GT_TPC,S3GT_TPG " & _
                                                           "where S3GT_VOC.Topic_ID=S3GT_TPC.Topic_ID " & _
                                                           "and S3GT_TPC.Topic_Group_ID=S3GT_TPG.Topic_Group_ID " & _
                                                           "and S3GT_TPC.Topic_Group_ID={0} " & _
                                                           "and S3GT_VOC.Hiragana like '%{1}' " & _
                                                           "and  S3GT_TPC.Topic_Name = '{2}'"
    Public Const STR_SQL_VOCABULARY_SEARCH_KANJI_START As String = "SELECT S3GT_TPG.*, S3GT_TPC.*, S3GT_VOC.* " & _
                                                            "from S3GT_VOC,S3GT_TPC,S3GT_TPG " & _
                                                            "where S3GT_VOC.Topic_ID=S3GT_TPC.Topic_ID " & _
                                                            "and S3GT_TPC.Topic_Group_ID=S3GT_TPG.Topic_Group_ID " & _
                                                            "and S3GT_TPC.Topic_Group_ID={0} " & _
                                                            "and S3GT_VOC.Kanji like '%{1}' " & _
                                                            "and  S3GT_TPC.Topic_Name = '{2}'"
    Public Const STR_SQL_VOCABULARY_SEARCH_HANNOM_START As String = "SELECT S3GT_TPG.*, S3GT_TPC.*, S3GT_VOC.* " & _
                                                            "from S3GT_VOC,S3GT_TPC,S3GT_TPG " & _
                                                            "where S3GT_VOC.Topic_ID=S3GT_TPC.Topic_ID " & _
                                                            "and S3GT_TPC.Topic_Group_ID=S3GT_TPG.Topic_Group_ID " & _
                                                            "and S3GT_TPC.Topic_Group_ID={0} " & _
                                                            "and S3GT_VOC.Hannom like '%{1}' " & _
                                                            "and  S3GT_TPC.Topic_Name = '{2}'"
    Public Const STR_SQL_VOCABULARY_SEARCH_MEANING_START As String = "SELECT S3GT_TPG.*, S3GT_TPC.*, S3GT_VOC.* " & _
                                                            "from S3GT_VOC,S3GT_TPC,S3GT_TPG " & _
                                                            "where S3GT_VOC.Topic_ID=S3GT_TPC.Topic_ID " & _
                                                            "and S3GT_TPC.Topic_Group_ID=S3GT_TPG.Topic_Group_ID " & _
                                                            "and S3GT_TPC.Topic_Group_ID={0} " & _
                                                            "and S3GT_VOC.Meaning like '%{1}' " & _
                                                            "and  S3GT_TPC.Topic_Name = '{2}'"
    'SQL for SEARCH VOC when TOPIC NAME IS NULL
    Public Const STR_SQL_VOCABULARY_SEARCH_HIRAGANA_TPNNULL_START As String = "SELECT S3GT_TPG.*, S3GT_TPC.*, S3GT_VOC.* " & _
                                                            "from S3GT_VOC,S3GT_TPC,S3GT_TPG " & _
                                                            "where S3GT_VOC.Topic_ID=S3GT_TPC.Topic_ID " & _
                                                            "and S3GT_TPC.Topic_Group_ID=S3GT_TPG.Topic_Group_ID " & _
                                                            "and S3GT_TPC.Topic_Group_ID={0} " & _
                                                            "and S3GT_VOC.Hiragana like '%{1}' "
    Public Const STR_SQL_VOCABULARY_SEARCH_KANJI_TPNNULL_START As String = "SELECT S3GT_TPG.*, S3GT_TPC.*, S3GT_VOC.* " & _
                                                            "from S3GT_VOC,S3GT_TPC,S3GT_TPG " & _
                                                            "where S3GT_VOC.Topic_ID=S3GT_TPC.Topic_ID " & _
                                                            "and S3GT_TPC.Topic_Group_ID=S3GT_TPG.Topic_Group_ID " & _
                                                            "and S3GT_TPC.Topic_Group_ID={0} " & _
                                                            "and S3GT_VOC.Kanji like '%{1}' "
    Public Const STR_SQL_VOCABULARY_SEARCH_HANNOM_TPNNULL_START As String = "SELECT S3GT_TPG.*, S3GT_TPC.*, S3GT_VOC.* " & _
                                                            "from S3GT_VOC,S3GT_TPC,S3GT_TPG " & _
                                                            "where S3GT_VOC.Topic_ID=S3GT_TPC.Topic_ID " & _
                                                            "and S3GT_TPC.Topic_Group_ID=S3GT_TPG.Topic_Group_ID " & _
                                                            "and S3GT_TPC.Topic_Group_ID={0} " & _
                                                            "and S3GT_VOC.Hannom like '%{1}' "

    Public Const STR_SQL_VOCABULARY_SEARCH_MEANING_TPNNULL_START As String = "SELECT S3GT_TPG.*, S3GT_TPC.*, S3GT_VOC.* " & _
                                                                "from S3GT_VOC,S3GT_TPC,S3GT_TPG " & _
                                                                "where S3GT_VOC.Topic_ID=S3GT_TPC.Topic_ID " & _
                                                                "and S3GT_TPC.Topic_Group_ID=S3GT_TPG.Topic_Group_ID " & _
                                                                "and S3GT_TPC.Topic_Group_ID={0} " & _
                                                                "and S3GT_VOC.Meaning like '%{1}' "
    'SQL for SEARCH VOC when TOPIC GROUP NAME IS NULL
    Public Const STR_SQL_VOCABULARY_SEARCH_HIRAGANA_TPGNULL_START As String = "SELECT S3GT_TPG.*, S3GT_TPC.*, S3GT_VOC.* " & _
                                                            "from S3GT_VOC,S3GT_TPC,S3GT_TPG " & _
                                                            "where S3GT_VOC.Topic_ID=S3GT_TPC.Topic_ID " & _
                                                            "and S3GT_TPC.Topic_Group_ID=S3GT_TPG.Topic_Group_ID " & _
                                                            "and S3GT_VOC.Hiragana like '%{0}' "
    Public Const STR_SQL_VOCABULARY_SEARCH_KANJI_TPGNULL_START As String = "SELECT S3GT_TPG.*, S3GT_TPC.*, S3GT_VOC.* " & _
                                                            "from S3GT_VOC,S3GT_TPC,S3GT_TPG " & _
                                                            "where S3GT_VOC.Topic_ID=S3GT_TPC.Topic_ID " & _
                                                            "and S3GT_TPC.Topic_Group_ID=S3GT_TPG.Topic_Group_ID " & _
                                                            "and S3GT_VOC.Kanji like '%{0}' "
    Public Const STR_SQL_VOCABULARY_SEARCH_HANNOM_TPGNULL_START As String = "SELECT S3GT_TPG.*, S3GT_TPC.*, S3GT_VOC.* " & _
                                                            "from S3GT_VOC,S3GT_TPC,S3GT_TPG " & _
                                                            "where S3GT_VOC.Topic_ID=S3GT_TPC.Topic_ID " & _
                                                            "and S3GT_TPC.Topic_Group_ID=S3GT_TPG.Topic_Group_ID " & _
                                                            "and S3GT_VOC.Hannom like '%{0}' "

    Public Const STR_SQL_VOCABULARY_SEARCH_MEANING_TPGNULL_START As String = "SELECT S3GT_TPG.*, S3GT_TPC.*, S3GT_VOC.* " & _
                                                                "from S3GT_VOC,S3GT_TPC,S3GT_TPG " & _
                                                                "where S3GT_VOC.Topic_ID=S3GT_TPC.Topic_ID " & _
                                                                "and S3GT_TPC.Topic_Group_ID=S3GT_TPG.Topic_Group_ID " & _
                                                                "and S3GT_VOC.Meaning like '%{0}' "
    'Start searchBy = End with
    Public Const STR_SQL_VOCABULARY_SEARCH_HIRAGANA_END As String = "SELECT S3GT_TPG.*, S3GT_TPC.*, S3GT_VOC.* " & _
                                                            "from S3GT_VOC,S3GT_TPC,S3GT_TPG " & _
                                                            "where S3GT_VOC.Topic_ID=S3GT_TPC.Topic_ID " & _
                                                            "and S3GT_TPC.Topic_Group_ID=S3GT_TPG.Topic_Group_ID " & _
                                                            "and S3GT_TPC.Topic_Group_ID={0} " & _
                                                            "and S3GT_VOC.Hiragana like '{1}%' " & _
                                                            "and  S3GT_TPC.Topic_Name = '{2}'"
    Public Const STR_SQL_VOCABULARY_SEARCH_KANJI_END As String = "SELECT S3GT_TPG.*, S3GT_TPC.*, S3GT_VOC.* " & _
                                                            "from S3GT_VOC,S3GT_TPC,S3GT_TPG " & _
                                                            "where S3GT_VOC.Topic_ID=S3GT_TPC.Topic_ID " & _
                                                            "and S3GT_TPC.Topic_Group_ID=S3GT_TPG.Topic_Group_ID " & _
                                                            "and S3GT_TPC.Topic_Group_ID={0} " & _
                                                            "and S3GT_VOC.Kanji like '{1}%' " & _
                                                            "and  S3GT_TPC.Topic_Name = '{2}'"
    Public Const STR_SQL_VOCABULARY_SEARCH_HANNOM_END As String = "SELECT S3GT_TPG.*, S3GT_TPC.*, S3GT_VOC.* " & _
                                                            "from S3GT_VOC,S3GT_TPC,S3GT_TPG " & _
                                                            "where S3GT_VOC.Topic_ID=S3GT_TPC.Topic_ID " & _
                                                            "and S3GT_TPC.Topic_Group_ID=S3GT_TPG.Topic_Group_ID " & _
                                                            "and S3GT_TPC.Topic_Group_ID={0} " & _
                                                            "and S3GT_VOC.Hannom like '{1}%' " & _
                                                            "and  S3GT_TPC.Topic_Name = '{2}'"
    Public Const STR_SQL_VOCABULARY_SEARCH_MEANING_END As String = "SELECT S3GT_TPG.*, S3GT_TPC.*, S3GT_VOC.* " & _
                                                            "from S3GT_VOC,S3GT_TPC,S3GT_TPG " & _
                                                            "where S3GT_VOC.Topic_ID=S3GT_TPC.Topic_ID " & _
                                                            "and S3GT_TPC.Topic_Group_ID=S3GT_TPG.Topic_Group_ID " & _
                                                            "and S3GT_TPC.Topic_Group_ID={0} " & _
                                                            "and S3GT_VOC.Meaning like '{1}%' " & _
                                                            "and  S3GT_TPC.Topic_Name = '{2}'"
    'SQL for SEARCH VOC when TOPIC NAME IS NULL
    Public Const STR_SQL_VOCABULARY_SEARCH_HIRAGANA_TPNNULL_END As String = "SELECT S3GT_TPG.*, S3GT_TPC.*, S3GT_VOC.* " & _
                                                            "from S3GT_VOC,S3GT_TPC,S3GT_TPG " & _
                                                            "where S3GT_VOC.Topic_ID=S3GT_TPC.Topic_ID " & _
                                                            "and S3GT_TPC.Topic_Group_ID=S3GT_TPG.Topic_Group_ID " & _
                                                            "and S3GT_TPC.Topic_Group_ID={0} " & _
                                                            "and S3GT_VOC.Hiragana like '{1}%' "
    Public Const STR_SQL_VOCABULARY_SEARCH_KANJI_TPNNULL_END As String = "SELECT S3GT_TPG.*, S3GT_TPC.*, S3GT_VOC.* " & _
                                                            "from S3GT_VOC,S3GT_TPC,S3GT_TPG " & _
                                                            "where S3GT_VOC.Topic_ID=S3GT_TPC.Topic_ID " & _
                                                            "and S3GT_TPC.Topic_Group_ID=S3GT_TPG.Topic_Group_ID " & _
                                                            "and S3GT_TPC.Topic_Group_ID={0} " & _
                                                            "and S3GT_VOC.Kanji like '{1}%' "
    Public Const STR_SQL_VOCABULARY_SEARCH_HANNOM_TPNNULL_END As String = "SELECT S3GT_TPG.*, S3GT_TPC.*, S3GT_VOC.* " & _
                                                            "from S3GT_VOC,S3GT_TPC,S3GT_TPG " & _
                                                            "where S3GT_VOC.Topic_ID=S3GT_TPC.Topic_ID " & _
                                                            "and S3GT_TPC.Topic_Group_ID=S3GT_TPG.Topic_Group_ID " & _
                                                            "and S3GT_TPC.Topic_Group_ID={0} " & _
                                                            "and S3GT_VOC.Hannom like '{1}%' "

    Public Const STR_SQL_VOCABULARY_SEARCH_MEANING_TPNNULL_END As String = "SELECT S3GT_TPG.*, S3GT_TPC.*, S3GT_VOC.* " & _
                                                                "from S3GT_VOC,S3GT_TPC,S3GT_TPG " & _
                                                                "where S3GT_VOC.Topic_ID=S3GT_TPC.Topic_ID " & _
                                                                "and S3GT_TPC.Topic_Group_ID=S3GT_TPG.Topic_Group_ID " & _
                                                                "and S3GT_TPC.Topic_Group_ID={0} " & _
                                                                "and S3GT_VOC.Meaning like '{1}%' "
    'SQL for SEARCH VOC when TOPIC GROUP NAME IS NULL
    Public Const STR_SQL_VOCABULARY_SEARCH_HIRAGANA_TPGNULL_END As String = "SELECT S3GT_TPG.*, S3GT_TPC.*, S3GT_VOC.* " & _
                                                            "from S3GT_VOC,S3GT_TPC,S3GT_TPG " & _
                                                            "where S3GT_VOC.Topic_ID=S3GT_TPC.Topic_ID " & _
                                                            "and S3GT_TPC.Topic_Group_ID=S3GT_TPG.Topic_Group_ID " & _
                                                            "and S3GT_VOC.Hiragana like '{0}%' "
    Public Const STR_SQL_VOCABULARY_SEARCH_KANJI_TPGNULL_END As String = "SELECT S3GT_TPG.*, S3GT_TPC.*, S3GT_VOC.* " & _
                                                            "from S3GT_VOC,S3GT_TPC,S3GT_TPG " & _
                                                            "where S3GT_VOC.Topic_ID=S3GT_TPC.Topic_ID " & _
                                                            "and S3GT_TPC.Topic_Group_ID=S3GT_TPG.Topic_Group_ID " & _
                                                            "and S3GT_VOC.Kanji like '{0}%' "
    Public Const STR_SQL_VOCABULARY_SEARCH_HANNOM_TPGNULL_END As String = "SELECT S3GT_TPG.*, S3GT_TPC.*, S3GT_VOC.* " & _
                                                            "from S3GT_VOC,S3GT_TPC,S3GT_TPG " & _
                                                            "where S3GT_VOC.Topic_ID=S3GT_TPC.Topic_ID " & _
                                                            "and S3GT_TPC.Topic_Group_ID=S3GT_TPG.Topic_Group_ID " & _
                                                            "and S3GT_VOC.Hannom like '{0}%' "

    Public Const STR_SQL_VOCABULARY_SEARCH_MEANING_TPGNULL_END As String = "SELECT S3GT_TPG.*, S3GT_TPC.*, S3GT_VOC.* " & _
                                                                "from S3GT_VOC,S3GT_TPC,S3GT_TPG " & _
                                                                "where S3GT_VOC.Topic_ID=S3GT_TPC.Topic_ID " & _
                                                                "and S3GT_TPC.Topic_Group_ID=S3GT_TPG.Topic_Group_ID " & _
                                                                "and S3GT_VOC.Meaning like '{0}%' "

    Public Const STR_SQL_SINGLE_KANJI_ADDNEW As String = "insert into S3GT_KAN(Kanji,HanNom,Kunyomi,Onyomi,Meaning) values('{0}','{1}','{2}','{3}','{4}')"
    Public Const STR_SQL_VOC_DELETE_VOC As String = "delete * from S3GT_KAN where Kanji_ID = {0}"
    Public Const STR_SQL_VOC_UpdateByID As String = "Update S3GT_KAN set Kanji ='{0}'  , HanNom='{1}' , Kunyomi='{2}' , Onyomi ='{3}' , Meaning='{4}' where Kanji_ID = {5} "

    Public Const STR_SQL_SINGLE_KANJI_GETMAXID As String = "SELECT max(Kanji_ID) from S3GT_KAN"
    Public Const STR_SQL_SINGLE_KANJI As String = "SELECT * from S3GT_KAN"
    Public Const STR_SQL_SINGLE_KANJI_Kanji As String = "SELECT * from S3GT_KAN where Kanji="""
    Public Const STR_SQL_SINGLE_KANJI_HanNom As String = "SELECT * from S3GT_KAN where HanNom like " & "'" & "%"
    Public Const STR_SQL_SINGLE_KANJI_Kunyomi As String = "SELECT * from S3GT_KAN where Kunyomi like " & """" & "%"
    Public Const STR_SQL_SINGLE_KANJI_Onyomi As String = "SELECT * from S3GT_KAN where Onyomi like " & """" & "%"
    Public Const STR_SQL_SINGLE_KANJI_Meaning As String = "SELECT * from S3GT_KAN where Meaning like " & """" & "%"

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
    Public Const STR_MSG_INFO_023 As String = "Are you want to create Vocabulary in this topic?"

    Public Const STR_MSG_ERR_001 As String = "Topic name cannot be blank."
    Public Const STR_MSG_ERR_002 As String = "A Topic has exists with input Topic Group name and Topic name. Please input other Topic Group name or Topic name."
    Public Const STR_MSG_ERR_003 As String = "The edited Vocabulary has the same Hiragana/Katakana and belongs to the same Topic as the following Vocabularies. " & STR_NEW_LINE & STR_NEW_LINE & "Please choose your preferred action."
    Public Const STR_MSG_ERR_004 As String = "Hiragana/Katakana cannot be blank or space."
    Public Const STR_MSG_ERR_005 As String = "The edited Vocabulary has the same Hiragana/Katakana and belongs to the same Topic as the following Vocabularies." & STR_NEW_LINE & STR_NEW_LINE & "Do you want to continue?"
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
    Public Const STR_MSG_ERR_021 As String = "Cannot update the default Topic and Topic Group."
    Public Const STR_MSG_ERR_022 As String = "Cannot delete the default Topic and Topic Group."
    Public Const STR_MSG_ERR_CODING As String = "Error coding"

    'Commont
    Public Const STR_NEW_LINE As String = Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)

End Class
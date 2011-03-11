Public Class Constants_NguyenNB
    Public Const KANJI_FOLDER As String = "KanjiImage"
    Public Const SEPERATOR As String = ":"
    Public Const RESOURCES As String = "Resources"
    Public Const TEMPLATE As String = "Template.xlt"
    'error message
    Public Const ERR_MESS_REGION As String = "Old format or invalid type library"
    Public Const ERR_MESS_ACCESS As String = "Cannot access"
    Public Const ERR_MESS_OPENING As String = "Index and length must refer to a location within the string"

    'output message
    Public Const MESS_OPENING As String = "File is opening or file is read only, cannot continue!"
    Public Const MESS_REGION As String = "Please change regional setting (standard and format) to English"

    'EXTENSION FILE IMAGE
    Public Const IMG_EXTENSION As String = ".gif"
    'Log constant
    Public Const EXP_SUCCESS_MESS As String = " exported successfully."
    Public Const ERR_MESS_READONLY As String = "File read-only, cannot continue"

    'LOG CONSTANT FAIL
    Public Const EXP_IMG_FAIL As String = "is not exists, failed to export."

    Public Const EXP_PREFIX_SHEET_VOC As String = "VOC"
    Public Const EXP_PREFIX_SHEET_TOPIC As String = "TPC"
    Public Const EXP_PREFIX_SHEET_TOPIC_GROUP As String = "TPG"
    Public Const EXP_PREFIX_SHEET_KANJI As String = "KAN"

    Public Const EXP_SHEET_KANJI As String = "KANJI"

    Public Const EXP_ITEM_VOC As String = "VOCABULARY :"
    Public Const EXP_ITEM_TOPIC_GROUP As String = "TOPIC GROUP: "
    Public Const EXP_ITEM_TOPIC As String = "TOPIC :"
    'table s3gt_kan
    Public Const S3GT_KAN_KANJI_ID As String = "KANJI_ID"
    Public Const S3GT_KAN_KANJI As String = "KANJI"
    Public Const S3GT_KAN_HanNom = "HanNom"
    Public Const S3GT_KAN_Kunyomi = "Kunyomi"
    Public Const S3GT_KAN_Onyomi = "Onyomi"
    Public Const S3GT_KAN_Meaning = "Meaning"

    'TABLES 
    Public Const S3GT_TABLE_TOPIC_GROUP = "S3GT_TPG"
    Public Const S3GT_TABLE_TOPIC = "S3GT_TPC"
    Public Const S3GT_TABLE_KANJI = "S3GT_KAN"
    Public Const S3GT_TABLE_VOCABULARY = "S3GT_VOC"

    'TABLE S3GT_TPG
    Public Const S3GT_TPG_ID = "TOPIC_GROUP_ID"
    Public Const S3GT_TPG_NAME = "TOPIC_GROUP_NAME"
    Public Const S3GT_TPG_DESCRIPTION = "TOPIC_GROUP_DESCRIPTION"

    'TABLE S3GT_TPC
    Public Const S3GT_TPC_ID = "TOPIC_ID"
    Public Const S3GT_TPC_GROUP_ID = "TOPIC_GROUP_ID"
    Public Const S3GT_TPC_NAME = "TOPIC_NAME"
    Public Const S3GT_TPC_DESCRIPTION = "TOPIC_DESCRIPTION"

    'TABLE S3GT_VOC
    Public Const S3GT_VOC_ID = "VOCABULARY_ID"
    Public Const S3GT_VOC_TOPIC_ID = "TOPIC_ID"
    Public Const S3GT_VOC_HIRAGANA = "HIRAGANA"
    Public Const S3GT_VOC_KANJI = "KANJI"
    Public Const S3GT_VOC_HANNOM = "HANNOM"
    Public Const S3GT_VOC_MEANING = "MEANING"
    Public Const S3GT_VOC_TYPE = "TYPE"
    Public Const S3GT_VOC_EXAMPLE = "EXAMPLE"

    'String
    Public Const STR_Kanji_ID = "Kanji_ID"
    Public Const STR_Kanji = "Kanji"
    Public Const STR_HanNom = "HanNom"
    Public Const STR_Kunyomi = "Kunyomi"
    Public Const STR_Onyomi = "Onyomi"
    Public Const STR_Meaning = "Meaning"

    'ten sheet khi export
    Public Const SHEET_TOPIC_GROUP = "TPG"
    Public Const SHEET_TOPIC = "TPC"


End Class

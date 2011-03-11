Public Class VocabulariesEntity
    Private intTopicID As Integer
    Private strKanji As String
    Private strHiragana As String
    Private strHannom As String
    Private strMeaning As String
    Private intType As Byte
    Private intVocID As Integer
    Private strExample As String


    Public Property VocID() As Integer
        Get
            Return intVocID
        End Get
        Set(ByVal value As Integer)
            intVocID = value
        End Set
    End Property
    Public Property TopicID() As Int32
        Get
            Return intTopicID
        End Get
        Set(ByVal value As Int32)
            intTopicID = value
        End Set
    End Property
    Public Property Hiragana() As String
        Get
            Return strHiragana
        End Get
        Set(ByVal value As String)
            strHiragana = value
        End Set
    End Property
    Public Property Kanji() As String
        Get
            Return strKanji
        End Get
        Set(ByVal value As String)
            strKanji = value
        End Set
    End Property
    Public Property Hannom() As String
        Get
            Return strHannom
        End Get
        Set(ByVal value As String)
            strHannom = value
        End Set
    End Property
    Public Property Meaning() As String
        Get
            Return strMeaning
        End Get
        Set(ByVal value As String)
            strMeaning = value
        End Set
    End Property

    Public Property Type() As Byte
        Get
            Return intType
        End Get
        Set(ByVal value As Byte)
            intType = value
        End Set
    End Property

    Public Property Example() As String
        Get
            Return strExample
        End Get
        Set(ByVal value As String)
            strExample = value
        End Set
    End Property
End Class

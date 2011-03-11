Public Class SingleKanjiEntity
    Private strKanji As String
    Private strHanNom As String
    Private strKun As String
    Private strOn As String
    Private strMeaning As String
    Private intSingleKanjID As Integer
    Public Property Kanji() As String
        Get
            Return strKanji
        End Get
        Set(ByVal value As String)
            strKanji = value
        End Set
    End Property
    Public Property HanNom() As String
        Get
            Return strHanNom
        End Get
        Set(ByVal value As String)
            strHanNom = value
        End Set
    End Property
    Public Property Kunyomi() As String
        Get
            Return strKun
        End Get
        Set(ByVal value As String)
            strKun = value
        End Set
    End Property
    Public Property Onyomi() As String
        Get
            Return strOn
        End Get
        Set(ByVal value As String)
            strOn = value
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
    Public Property SingleKanjiID() As Integer
        Get
            Return intSingleKanjID
        End Get
        Set(ByVal value As Integer)
            intSingleKanjID = value
        End Set
    End Property
End Class

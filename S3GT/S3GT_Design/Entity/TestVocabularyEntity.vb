Public Class TestVocabularyEntity
    Inherits VocabulariesEntity
    
    Public Function getDefinitionByLang(ByVal langName As String) As String
        Dim definitionString As String = Constants_LanhVC.STR_BLANK_VALUE
        Select Case langName
            Case "Hiragana"
                definitionString = Me.Hiragana
            Case "Hiragana/Katakana"
                definitionString = Me.Hiragana
            Case "Kanji"
                definitionString = Me.Kanji
            Case "Meaning"
                definitionString = Me.Meaning
            Case "Han Nom"
                definitionString = Me.Hannom
            Case "HanNom"
                definitionString = Me.Hannom
            Case "Hannom"
                definitionString = Me.Hannom
        End Select
        Return definitionString
    End Function
End Class


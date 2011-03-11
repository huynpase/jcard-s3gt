Public Class ParameterEntity
    Private paramName As String
    Public Property ParameterName() As String
        Get
            Return paramName
        End Get
        Set(ByVal value As String)
            paramName = value
        End Set
    End Property
    Private paramValue As String
    Public Property ParameterValue() As String
        Get
            Return paramValue
        End Get
        Set(ByVal value As String)
            paramValue = value
        End Set
    End Property
    Private paramDesc As String
    Public Property ParameterDescription() As String
        Get
            Return paramDesc
        End Get
        Set(ByVal value As String)
            paramDesc = value
        End Set
    End Property

End Class

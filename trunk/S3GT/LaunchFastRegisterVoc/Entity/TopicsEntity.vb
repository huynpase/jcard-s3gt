Public Class TopicsEntity
    Private intTopicID As Integer
    Private intTopicGroupID As Integer
    Private strTopicName As String
    Private strTopicGroupName As String
    Private strTopicDescription As String
    Public Property TopicID() As Integer
        Get
            Return intTopicID
        End Get
        Set(ByVal value As Integer)
            intTopicID = value
        End Set
    End Property
    Public Property TopicGroupID() As Integer
        Get
            Return intTopicGroupID
        End Get
        Set(ByVal value As Integer)
            intTopicGroupID = value
        End Set
    End Property

    Public Property TopicName() As String
        Get
            Return strTopicName
        End Get
        Set(ByVal value As String)
            strTopicName = value
        End Set
    End Property
    Public Property TopicGroupName() As String
        Get
            Return strTopicGroupName
        End Get
        Set(ByVal value As String)
            strTopicGroupName = value
        End Set
    End Property

    Public Property TopicDescription() As String
        Get
            Return strTopicDescription
        End Get
        Set(ByVal value As String)
            strTopicDescription = value
        End Set
    End Property

    Public Sub New(ByVal topic As String, ByVal group As String)
        Me.strTopicName = topic
        Me.strTopicGroupName = group
    End Sub
    Public Sub New(ByVal topic As Integer)
        Me.TopicID = topic
    End Sub
    Public Sub New()
    End Sub
End Class

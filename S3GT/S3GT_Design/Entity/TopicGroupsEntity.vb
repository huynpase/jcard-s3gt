Public Class TopicGroupsEntity
    Private intTopicGroupID As Integer
    Private strTopicGroupName As String
    Private strTopicGroupDescription As String

    Public Property TopicGroupID() As Integer
        Get
            Return intTopicGroupID
        End Get
        Set(ByVal value As Integer)
            intTopicGroupID = value
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

    Public Property TopicGroupDescription() As String
        Get
            Return strTopicGroupDescription
        End Get
        Set(ByVal value As String)
            strTopicGroupDescription = value
        End Set
    End Property
End Class

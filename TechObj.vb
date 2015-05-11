Public Class TechObj

    'each tech will need a tech id , techName, techemail
    'date and description are not part of the techobj. 
    Dim techIDstring As String
    Private Property TechID() As String
        Get
            Return techIDstring
        End Get
        Set(value As String)
            techIDstring = value
        End Set
    End Property

    Dim techEmailstring As String
    Private Property techEmail() As String
        Get
            Return techEmailstring
        End Get
        Set(value As String)
            techEmailstring = value
        End Set
    End Property

    Dim techNameinstance As String
    Private Property techName() As String
        Get
            Return techNameinstance
        End Get
        Set(value As String)
            techNameinstance = value
        End Set
    End Property
    ' may not need this contstructor to send object to the database. 
    'Sub New(techname As String, techid As String, techemail As String)

    'End Sub
End Class

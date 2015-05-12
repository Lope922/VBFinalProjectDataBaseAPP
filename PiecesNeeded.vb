Public Structure Ticket3
End Structure
' each ticket in the database will need a 
'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~SEPERATE STRUCTURE~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
'' a light weight class. Does and can this relate to a DBO ?  
'this row will contain a new ticket row like this [techID | ProblemTicketNumber | DateIn | BriefDescriptionOfProblem | Location | Severity ]

' this is an experimental ticket for creating an open ticket using stucture 
Public Structure Ticket


    ' this isn't implemented yet , but will be recorded as the person logging the ticket. 
    Private _selectedTechID As String

    Public Property selectedTechID() As String
        Get
            Return _selectedTechID
        End Get
        Set(ByVal value As String)
            _selectedTechID = value
        End Set
    End Property

    ' the ticket number 
    Private _ticketId As Integer

    Public Property Id() As Integer
        Get
            Return _ticketId
        End Get
        Set(ByVal value As Integer)
            _ticketId = value
        End Set
    End Property

    Private _dateIn As Date
    Public Property dateCalledIN() As Date
        Get
            Return _dateIn
        End Get

        Set(value As Date)
            _dateIn = value
        End Set
    End Property

    Private _descriptionOfProblem As String

    Public Property descrip_of_prob As String
        Get
            Return _descriptionOfProblem
        End Get
        Set(value As String)
            _descriptionOfProblem = value
        End Set
    End Property

    Private _locationOfProblem As String

    Public Property Location() As String
        Get
            Return _locationOfProblem
        End Get
        Set(ByVal value As String)
            _locationOfProblem = value
        End Set

    End Property
    '' the serverity of the problem

    Private _severity As Integer

    Public Property Severity() As Integer
        Get
            Return _severity
        End Get
        Set(ByVal value As Integer)
            _severity = value
        End Set
    End Property

    Sub New(techId As String, ticketNum As Integer, datein As Date, description As String, location As String, severity As Integer)

    End Sub
    'this row will contain a new ticket row like this [techID | ProblemTicketNumber | DateIn | BriefDescriptionOfProblem | Location | Severity ]
    'Public Overrides Function ToString() As String
    '   Return ("@TechID," + _selectedTechID + "@ProblemTicketNumber," + _ticketId + "@Datein," + dateCalledIN.ToShortDateString
    'End Function

End Structure

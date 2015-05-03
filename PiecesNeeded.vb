Imports System.Data.SqlClient

Public Class PiecesNeeded

    ''~~~~~~~~~~~~~~~~@@@@@@@@@@@@@@@@@@@@@@@@@@@@@!!!!!!!!!!!!!!!!!!!!!!!!!!!!~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'tech list table needs(tech name as string , tech email as string, techid , number of tickets, resolved tickets, callbacks, ints ints ints
    Private Structure TechObj


        ' 
        Dim techId As String

        Dim techNumOfTickets As Integer
        Dim resolvedTickets As Integer

        Dim DATEIN As Date
        Dim RESOLVEDATE As Date

        Dim LOCATION As String

        Dim Description As String

        '' see coffee demo and compare this to another object and see if i am using structure right. 
    End Structure



    '' this is a big class that holds all the pieces needed at the moment will split as necessary, just need to get underway modularizing the program. 

    '' in this problem ticket for i will need to be able to create a problem ticket
    ' each problem ticket needs to have : Severity of problem : an assigned technician : date called in :
    ' : location of problem : ticketId number : 

    ' in the database the column names are TicketID_# as string , Severity as integer, AssignedTech as string, Date as date, Location as string , Description as string 


    '' move this into a seperate class to called pieces. At first they might all just be one global class that each form can access. and can be divivded later. 

    Dim objConnection As New SqlConnection("server=LOPE_S_PC\MCTCSQLSTUDENT;database=coffeereviews;user id=sa;password=paSSw0rd29")
    '  Dim insertTicketinfoSQL As String = "INSERT INTO create_SupportTicket values(@Severity,@AssignedTech,@Date,@Location,@Description)"
    ' Dim problemDescription As String = problemDescriptionTextBox.Text
    'date called in 
    Dim dateIn As New Date


    'date resolved
    Dim dateOut As Date

    ' database should handleTicket ID 
    'Ticket Id as string 

    Dim severity As Integer

    Public Property retrieveProblemSeverity As Integer
        Get
            Return severity
        End Get
        Set(value As Integer)
            value = severity
        End Set
    End Property
    Public Property dateCalledIn() As Date
        Get
            dateIn.DayOfYear.ToString()
            Return dateIn
        End Get
        Set(value As Date)
            value = dateIn
        End Set
    End Property

 
    Public Structure Tech ' the structure/form the tech object needs to take. With pieces it needs. 

        Private username_fromLogin As String ' this will be the login set when user logs in, and will also be a tag when sending e-mails as well as other forms. 

        Public Property Username() As String ' this will call a function that gets and sets the value of the function. 
            Get
                Return username_fromLogin ' set to the instance of the user login when initializing. 

            End Get

            Set(value As String)

                username_fromLogin = value

            End Set

        End Property

        '' test this out to see if i can get just tech name to show up in the combo drop down box. 

        ' tech id also needs e-mail address to be sent in e-mails. 
        'may only need to be written as an overloaded sub. 

        'leaving off here.  <~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

        '' this sniippet is from the coffee shop program. 

        Private _email As String
        Public Property Email() As String
            Get
                Return _email
            End Get
            Set(ByVal value As String)
                _email = value
            End Set
        End Property

        Private _id As Integer
        Public Property Id() As Integer
            Get
                Return _id
            End Get
            Set(ByVal value As Integer)
                _id = value
            End Set
        End Property

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

    End Structure



    '' an experimental function to get the date 
    'Private Function getDate() As String
    '    Dim dateOfCallin As Date
    '    dateOfCallin.DayOfYear.ToString()
    '    Console.WriteLine("Just to show we retrieved the date properly" + dateOfCallin.ToString)
    '    Return dateOfCallin.DayOfYear.ToString()
    'End Function

    ''experimental function to get the severity of the problem
    'Private Function getSeverity() As String

    '    Try
    '        Dim ticketSeverity As String
    '        ticketSeverity = ticketSeverityComboBox.SelectedItem.ToString
    '        Return ticketSeverity
    '    Catch noSelect As Exception
    '        MessageBox.Show("Problem severity not selected please use the combo box to make a selection", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

    '    End Try
    'End Function

    '' get the location of the problem from the combo box 
    'Private Function getLocation() As String
    '    Try
    '        Dim location As String
    '        location = locationComboBox.SelectedItem.ToString
    '    Catch locationRetrievalProblem As Exception
    '        MessageBox.Show(" Problem getting Location" + locationRetrievalProblem.Message)
    '    End Try
    'End Function

    '' tech that is going to be assigned problem task to fix 
    'Private Function getTechName() As String
    '    Try
    '        Dim selectedTech As String
    '        selectedTech = assignedTechcomboBox.SelectedItem.ToString
    '    Catch ex As Exception

    '    End Try
    'End Function
    '' when this button is clicked the program should attempt to send the information to the database 
    'Private Sub addProblemTicket_Click(sender As Object, e As EventArgs)
    '    If Me.DialogResult = System.Windows.Forms.DialogResult.OK Then


    '        ' in the database the column names are TicketID_# as string , Severity as integer, AssignedTech as string, Date as date, Location as string , Description as string 


    '        Dim insertNewProblemTicketSQLCommand As New SqlCommand(insertTicketinfoSQL, objConnection)
    '        insertNewProblemTicketSQLCommand.Parameters.AddWithValue("@Severity", getSeverity())
    '        insertNewProblemTicketSQLCommand.Parameters.AddWithValue("@AssignedTech", getTechName())
    '        insertNewProblemTicketSQLCommand.Parameters.AddWithValue("@Date", getDate())
    '        insertNewProblemTicketSQLCommand.Parameters.AddWithValue("@Location", getLocation())
    '    End If
    '    ' close the window ? 
    '    Me.Close()
    'End Sub

    'Private Sub createProblemTicketWindow_Load(sender As Object, e As EventArgs) Handles Me.Load
    '    ' when the form is loaded fill the combo boxes with these following options 


    'End Sub




End Class

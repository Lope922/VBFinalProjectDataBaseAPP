Imports System.Data.SqlClient

Public Class problemTicketForm
    '' in this problem ticket for i will need to be able to create a problem ticket
    ' each problem ticket needs to have : Severity of problem : an assigned technician : date called in :
    ' : location of problem : ticketId number : 

    ' in the database the column names are TicketID_# as string , Severity as integer, AssignedTech as string, Date as date, Location as string , Description as string 

    Dim objConnection As New SqlConnection("server=LOPE_S_PC\MCTCSQLSTUDENT;database=coffeereviews;user id=sa;password=paSSw0rd29")
    Dim insertTicketinfoSQL As String = "INSERT INTO create_SupportTicket values(@Severity,@AssignedTech,@Date,@Location,@Description)"
    Dim problemDescription As String = problemDescriptionTextBox.Text

    Private Function getDate() As String
        Dim dateOfCallin As Date
        dateOfCallin.DayOfYear.ToString()
        Console.WriteLine("Just to show we retrieved the date properly" + dateOfCallin.ToString)
        Return dateOfCallin.DayOfYear.ToString()
    End Function

    Private Function getSeverity() As String

        Try
            Dim ticketSeverity As String
            ticketSeverity = ticketSeverityComboBox.SelectedItem.ToString
            Return ticketSeverity
        Catch noSelect As Exception
            MessageBox.Show("Problem severity not selected please use the combo box to make a selection", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End Try
    End Function

    Private Function getLocation() As String
        Try
            Dim location As String
            location = locationComboBox.SelectedItem.ToString
        Catch locationRetrievalProblem As Exception
            MessageBox.Show(" Problem getting Location" + locationRetrievalProblem.Message)
        End Try
    End Function
    Private Function getTechName() As String
        Try
            Dim selectedTech As String
            selectedTech = assignedTechcomboBox.SelectedItem.ToString
        Catch ex As Exception

        End Try
    End Function

    ' when this button is clicked the program should attempt to send the information to the database 
    Private Sub addProblemTicket_Click(sender As Object, e As EventArgs) Handles addProblemTicket.Click
        ' in the database the column names are TicketID_# as string , Severity as integer, AssignedTech as string, Date as date, Location as string , Description as string 


        Dim insertNewProblemTicketSQLCommand As New SqlCommand(insertTicketinfoSQL, objConnection)
        insertNewProblemTicketSQLCommand.Parameters.AddWithValue("@Severity", getSeverity())
        insertNewProblemTicketSQLCommand.Parameters.AddWithValue("@AssignedTech", getTechName())
        insertNewProblemTicketSQLCommand.Parameters.AddWithValue("@Date", getDate())
        insertNewProblemTicketSQLCommand.Parameters.AddWithValue("@Location", getLocation())
    End Sub

    Private Sub problemTicketForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        locationComboBox.Items.Add("Accounting")
        locationComboBox.Items.Add("IT Department")
        locationComboBox.Items.Add("Financing")
        locationComboBox.Items.Add("Tech Support")
        locationComboBox.Items.Add("Database Administration")
        locationComboBox.Items.Add("Front End")
        locationComboBox.Items.Add("Back End")
        locationComboBox.Items.Add("Warehouse")

        ticketSeverityComboBox.Items.Add(1)
        ticketSeverityComboBox.Items.Add(2)
        ticketSeverityComboBox.Items.Add(3)
        ticketSeverityComboBox.Items.Add(4)
        ticketSeverityComboBox.Items.Add(5)


    End Sub
End Class
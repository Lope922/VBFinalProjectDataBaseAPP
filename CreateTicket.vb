Imports System.Windows.Forms
Imports System.Data.SqlClient

'Imports System.Data.SqlClient

Public Class CreateTicket

    'global variables so far. 
    Dim objTableDataAdapter As SqlDataAdapter
    Dim objTechNamesDataTable As New DataTable()
    'constant(s)
    Public DB_connection_string As New SqlConnection("server=LOPE_S_PC\MCTCSQLSTUDENT;database=FinalDatabaseProject;Trusted_Connection=yes")


    ' this will be used when creating a ticket it will be auto applied. 


    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        'when the cancel button is clicked go back to the main window. 
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Dialog1_Load(sender As Object, e As EventArgs) Handles Me.Load
      
        'set the choices for the user to select the problem location. 
        locationComboBox.Items.Add("Accounting")
        locationComboBox.Items.Add("IT Department")
        locationComboBox.Items.Add("Financing")
        locationComboBox.Items.Add("Tech Support")
        locationComboBox.Items.Add("Database Administration")
        locationComboBox.Items.Add("Front End")
        locationComboBox.Items.Add("Back End")
        locationComboBox.Items.Add("Warehouse")


        'use the date in to show the date to the user and allow tickets to be entered into the system with the current date
        Dim dateIn As Date = Today
        dateLabel.Text = ("Current Date:" + dateIn.ToString)

        ' request the techs available from the database. 
        ' if database is empty display a message letting the user know that they need to add Techs to the database. 
   
        'Fetch names of tables and display them in first combobox using a new objTableDataAdapter
        objTableDataAdapter = New SqlDataAdapter("SELECT [Tech name] FROM TechList", DB_connection_string)

        ' use the tech names data table to fill the obj table data adapter 
        objTableDataAdapter.Fill(objTechNamesDataTable)

        'the data source for the combo box is the available techs in the database. 
        assignedTechcomboBox.DataSource = objTechNamesDataTable

        'use this search string to select the tech name column to be displayed in the combo box. 
        Dim columnName As String = "Tech Name"
        'this assigns the value within the column into the member displayed in the data table 
        assignedTechcomboBox.DisplayMember = columnName
        assignedTechcomboBox.ValueMember = columnName


        ' dim select all Sql string that will make the request 
        'TODO ANSWE QUESTION IS THIS CONSTANT CAN IT BE MOVED TO THE TOP. ?
        Dim selectAllOpenTicketsSQL As String = "SELECT ticketID,techID,Problemdescription,datein,location,severity FROM TechSupportTicket where dateout is null"

        Dim allDataFromTableDataAdapter As SqlDataAdapter
        'THIS DATA adapter allows communication of all_data from database
        Dim addDataFromTableDataTable As DataTable '[emptyTable_1]
        'this data table store the table of information

        ' now make the connection to  fill a grid box with the data. 
        allDataFromTableDataAdapter = New SqlDataAdapter(selectAllOpenTicketsSQL, DB_connection_string)

        
        '' EXACTLY WHAT I WANT TO DO RIGHT HERE./
        addDataFromTableDataTable = New DataTable() '[emtyTable_2]
        ' THIS FILLS THE DATA GRID. 
        allDataFromTableDataAdapter.Fill(addDataFromTableDataTable) '[emptyTable_2] now contains data from the all_data data adapter
        '' THIS SAYS THE DATA GRID SOURCE IS THE DATA GRID ITSELF. 
        createTicketDataGridView.DataSource = addDataFromTableDataTable
        'datagridview source = [emptyTable_1]

        ' may need this later 
        'Dim technameRowCount As Integer = objTechNamesDataTable.Rows.Count
        'Dim techName As String = objTableDataAdapter



    End Sub
    'PART oF TESTING
    Dim createTicketDataSQL As New SqlDataAdapter
    'almost had to implement a counter because i couldn't get the primary key to auto assign its identity 
    'Dim counter As Integer = counter + 1


    'TODO get problem ticket working. 

    Private Sub addProblemTicket_Click(sender As Object, e As EventArgs) Handles addProblemTicket.Click
        Dim SQLticketObjBeingBuilt As Ticket

        'initialize something to hold the data table to send to the database 
        Dim newRowDataAdapter As SqlDataAdapter
        'TODO VALIDATE INPUT 

        'IF THE USER DIDN'T INPUT PROPER MESSAGE DISPLAY A MESSAGE 
        'Read in data from text boxes and combobox; simple validation
        'Other checks - is the email address is in a valid format? 

       
       ' THE ASSIGNED TECH SHOULD BE A VALUE SELECTED FROM THE COMBO BOX

        'Dim techtoAssignTask As String = assignedTechcomboBox.SelectedValue.ToString
        SQLticketObjBeingBuilt.selectedTechID = assignedTechcomboBox.SelectedValue.ToString
        ' here is the assigned tech 

        '    MessageBox.Show("To make sure we have the right tech selected here is the assigned tech " + techtoAssignTask)

        'Dim dateCalledIn As Date = Date.Now
        'date called in 
        SQLticketObjBeingBuilt.dateCalledIN = Date.Now

        'Dim problemDescription As String = createTicket_RichTextBox.Text
        ' the problem description 
        SQLticketObjBeingBuilt.descrip_of_prob = createTicket_RichTextBox.Text

        'Dim problemSeverity As Integer = CInt(severityNumericUpDown.Value)

        SQLticketObjBeingBuilt.Severity = CInt(severityNumericUpDown.Value)
        ' here is the severity 


        'Dim problemLocation As String = locationComboBox.SelectedItem.ToString
        SQLticketObjBeingBuilt.Location = locationComboBox.SelectedItem.ToString

        '' ALL VALUES ARE ACOUNTED FOR NOW, BESIDES TICKET NUMBER, BUT I WANT THE DATABASE TO ASSIGN THIS AS THE PRIMARY KEY. 
        ''HOW DO I DO THIS ? i THINK I DO IT BY ADDING A NEW ROW .


        ''this row will contain a new ticket row like this [techID | ProblemTicketNumber | DateIn | BriefDescriptionOfProblem | Location | Severity ]
        ' when this button is clicked set the values needed to equal to the user input 

        'TODO EITHER GO THIS ROUTE CHECKING FOR VALUES WHEN BUTTON TO SEND TO DATABASE IS CLICKED, OR VERIFY WITH THE USER THAT THEY WANT TO SUBMIT DATA. 
        'If severityNumericUpDown.Value = 0 Then
        '    MessageBox.Show("Select a severity level of the problem", "Wait!", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        'End If

        Dim sqlinsertTicketCommand As String = "INSERT INTO TechSupportTicket (techID,datein, problemdescription, location, severity) VALUES ( @techID, @Datein, @ProblemDescription, @Location, @Severity)"
        ''tech id , problem ticket number, description, date called in, location of problem, severity

        Dim insertProblemticketSqlCommand As New SqlCommand(sqlinsertTicketCommand, DB_connection_string)

        'here is where i start to build the object to send to the database
        ' don't need a ticketId value because DB will assign one. 
        '  insertProblemticketSqlCommand.Parameters.AddWithValue("@ticketID", SQLticketObjBeingBuilt.Id)

        insertProblemticketSqlCommand.Parameters.AddWithValue("@TechID", SQLticketObjBeingBuilt.selectedTechID)
        insertProblemticketSqlCommand.Parameters.AddWithValue("@Datein", SQLticketObjBeingBuilt.dateCalledIN)
        insertProblemticketSqlCommand.Parameters.AddWithValue("@ProblemDescription", SQLticketObjBeingBuilt.descrip_of_prob)
        insertProblemticketSqlCommand.Parameters.AddWithValue("@Location", SQLticketObjBeingBuilt.Location)
        insertProblemticketSqlCommand.Parameters.AddWithValue("@Severity", SQLticketObjBeingBuilt.Severity)

        Try
            DB_connection_string.Open()
            insertProblemticketSqlCommand.ExecuteNonQuery()
            DB_connection_string.Close()
            'create a request to the database to send the above information 



            'TODO AFTER THIS IS WORKING ALLOW USER TO SET DATE IN AND DATE RESOLVED. AS AN EXTRA FEATURE:

        Catch similarErr As Exception
            MessageBox.Show(similarErr.Message + vbNewLine + " I have experienced a similar error " + vbNewLine + " within the sqlcreateticketcommand. Checker the sql queries is setup corretly")
            If similarErr.Message = Nothing Then
                MessageBox.Show("Ticket sent to Database" + vbNewLine + "Check Database table to see updated content", "Sucess!", MessageBoxButtons.OK, MessageBoxIcon.None)
                DB_connection_string.Close()
            End If
        End Try

        'show a messagebox that request was sent with no error response from servery. Check data grid on main table to see if it worked. 
        MessageBox.Show("Ticket Sent to database" + vbNewLine + "Check against table in main menu to verify integrity. ", "Ticket Sent", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub createTicketDataGridView_Click(sender As Object, e As EventArgs) Handles createTicketDataGridView.Click
        'TODO set this to refresh the data grid view on window click. 
    End Sub
End Class

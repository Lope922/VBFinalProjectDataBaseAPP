Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class rtDialog



    Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click


        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()

        Form1.Show()
    End Sub
    Dim objTableDataAdapter As SqlDataAdapter



    Dim objTechNamesDataTable As New DataTable()


    Dim DB_connection_string As New SqlConnection("server=LOPE_S_PC\MCTCSQLSTUDENT;database=FinalDatabaseProject;Trusted_Connection=yes")
    Private Sub ResolveTicketDialog_Load(sender As Object, e As EventArgs) Handles Me.Load

        'TO DO WORK ON THIS PART NEXT. RESOLVE A FRIGGIN TICKET
        'Try USING THIS SNIPPET
        ' Try
        'Dim row As DataGridViewRow = openTicketsDataGridView.SelectedRows.Item(0)





        'make sure user can only select one row because of how tickets are resolved. 
        openTicketsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        'also only want to be able to edit through program. 
        openTicketsDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically
        'upon loading load the open tickets table into the resolved table. ' this may be tricky now working off of one table. May need to go back to two tables 


        ''Fetch names of tables and display them in first combobox
        'objTableDataAdapter = New SqlDataAdapter("SELECT [Tech name] FROM TechList", DB_connection_string)
        '' use the tech names data table to fill the obj table data adapter 
        'objTableDataAdapter.Fill(objTechNamesDataTable)

        ''the data source for the combo box is the available techs in the database. 
        'assignedTechcomboBox.DataSource = objTechNamesDataTable

        'Dim columnName As String = "Tech Name"

        'assignedTechcomboBox.DisplayMember = columnName

        'assignedTechcomboBox.ValueMember = columnName

        ' dim select all Sql string that will make the request 
        Dim selectAllOpenTicketsSQL As String = "SELECT * FROM OpenTickets"
        Dim allDataFromTableDataAdapter As SqlDataAdapter
        Dim addDataFromTableDataTable As DataTable


        ' now fill a grid box with the data. 
        allDataFromTableDataAdapter = New SqlDataAdapter(selectAllOpenTicketsSQL, DB_connection_string)


        '' EXACTLY WHAT I WANT TO DO RIGHT HERE./
        addDataFromTableDataTable = New DataTable()
        ' THIS FILLS THE DATA GRID. 
        allDataFromTableDataAdapter.Fill(addDataFromTableDataTable)
        '' THIS SAYS THE DATA GRID SOURCE IS THE DATA GRID ITSELF. 
        openTicketsDataGridView.DataSource = addDataFromTableDataTable

        dateLabel.Text = "Today's Date: " + Date.Now.ToShortDateString
        ' may need this later 
        'Dim technameRowCount As Integer = objTechNamesDataTable.Rows.Count
        'Dim techName As String = objTableDataAdapter

        Dim openTickets As String = "Select problemTicketNumber from OpenTickets"
        'Dim openTicketComboBoxDataAdapter As SqlDataAdapter
        Dim openTicketsdataTable As New DataTable()

        ' Dim fillComboBoxFromTableDataTable As SqlDataAdapter
        Dim fillComboBoxFromTableDataTable As SqlDataAdapter = New SqlDataAdapter(openTickets, DB_connection_string)
        fillComboBoxFromTableDataTable.Fill(openTicketsdataTable)
        Dim columnName As String = "problem_ticket_Number"
        'column name to be displayed in the combo box.
        problemTicketNumberToResolve.DisplayMember = columnName
        problemTicketNumberToResolve.ValueMember = columnName


    End Sub

    Private Sub resolveProblemTicket_Click(sender As Object, e As EventArgs) Handles resolveProblemTicket.Click
        'when this button is clicked get either the selected ticket from the selected item in the data grid view or ticket number and resolve that ticket. 
        'easiest may be the selected row. 




        '' selected row is problem to solve. 
        'just have the user enter a description of the resolution and then they will be able to resolve the ticket either through an update or insert SQL command

        ''now how to get the database to know that this is the row that we want to edit 



        ' insert into the database the problem you solved. 
        ' so use the selected row as the row to insert. 


        'how does the database want the row to be sent in ? that is the big question 

        'start to establish a connection with the database to update the table. 

        'this is the connection string i want to use
        Dim sqlConnectionString As New SqlConnection("server=LOPE_S_PC\MCTCSQLSTUDENT;database=FinalDatabaseProject;Trusted_Connection=yes")

        'now to send it into database table 

        'TODO FIGURE OUT HOW TO WRITE THIS COMMAND 
        'TRYING TO WRITE THE DATA INTO THE RESOLVED TICKEST. iF I CAN'T GET IT TO WORK THEN I SHOULD JUST UPDATE THE OPEN TICKETS BY ADDING AS RESOLVED TICKET DATE, AND DESCRIIPTION
        'Dim resolveTicketSQLcommand As SqlCommand("INSERT INTO ResolvedTickets VALUES (@Tech_ID, @Problem_Ticket_Number, @Description, @Date_called_in,@location, @severity)"


        ''tech id , problem ticket number, description, date called in, location of problem, severity

        'Dim insertProblemticketSqlCommand As New SqlCommand(sqlinsertTicketCommand, DB_connection_string)

        'insertProblemticketSqlCommand.Parameters.AddWithValue("@Tech_ID", techtoAssignTask)
        'insertProblemticketSqlCommand.Parameters.AddWithValue("@Problem_Ticket_Number", 2)
        'insertProblemticketSqlCommand.Parameters.AddWithValue("@Description", problemDescription)
        'insertProblemticketSqlCommand.Parameters.AddWithValue("@Date_called_in", dateCalledIn)
        'insertProblemticketSqlCommand.Parameters.AddWithValue("@location", problemLocation)
        'insertProblemticketSqlCommand.Parameters.AddWithValue("@severity", problemSeverity)

        Try
            DB_connection_string.Open()
            'insertProblemticketSqlCommand.ExecuteNonQuery()
            DB_connection_string.Close()
            'create a request to the database to send the above information 


            'create a lable to show today's date. That will be helpful. 
            'TODO AFTER THIS IS WORKING ALLOW USER TO SET DATE IN AND DATE RESOLVED. AS AN EXTRA FEATURE:

        Catch similarErr As Exception
            MessageBox.Show(similarErr.Message + vbNewLine + " I have experienced a similar error " + vbNewLine + " within the sqlcreateticketcommand. Checker the sql queries is setup corretly")
        End Try
        'NOT FUNCTIONING YET 


        'LEFT OF REVIEWING COFFEE SHOP EXAMPLE SAVE BUTTON. 
        MessageBox.Show("Ticket sent to Database" + vbNewLine + "Check Database table to see updated content", "Sucess!", MessageBoxButtons.OK, MessageBoxIcon.None)
    End Sub








End Class

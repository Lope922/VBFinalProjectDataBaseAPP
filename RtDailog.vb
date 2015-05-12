Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class rtDialog



    Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()

        Form1.Show()
    End Sub
    'global variables within this form. 
    Dim objTableDataAdapter As SqlDataAdapter
    Dim objTechNamesDataTable As New DataTable()
    Public DB_connection_string As New SqlConnection("server=LOPE_S_PC\MCTCSQLSTUDENT;database=FinalDatabaseProject;Trusted_Connection=yes")
    Private Sub ResolveTicketDialog_Load(sender As Object, e As EventArgs) Handles Me.Load

        'make sure user can only select one row because of how tickets are resolved. 
        openTicketsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        'also only want to be able to edit through program. 
        openTicketsDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically
        'upon loading load the open tickets table into the resolved table. ' this may be tricky now working off of one table. May need to go back to two tables 

        ' if i decide to go the combo box option to select the ticket to remove use this snippet just replace SQL request for what's needed
        ''Fetch names of tables and display them in first combobox
        objTableDataAdapter = New SqlDataAdapter("SELECT ticketID FROM TechSupportTicket", DB_connection_string)
        '' use the tech names data table to fill the obj table data adapter 
        objTableDataAdapter.Fill(objTechNamesDataTable)

        ''the data source for the combo box is the available techs in the database. 
        problemTicketNumberToResolve.DataSource = objTechNamesDataTable

        Dim columnName As String = "ticketID"

        problemTicketNumberToResolve.DisplayMember = columnName

        problemTicketNumberToResolve.ValueMember = columnName

        ' dim select all Sql string that will make the request 
        Dim selectAllOpenTechSupportTicketSQL As String = "SELECT * FROM TechSupportTicket"
        Dim allDataFromTableDataAdapter As SqlDataAdapter
        Dim addDataFromTableDataTable As DataTable


        ' now fill a grid box with the data. 
        allDataFromTableDataAdapter = New SqlDataAdapter(selectAllOpenTechSupportTicketSQL, DB_connection_string)


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

        Dim openTickets As String = "Select ticketID from TechSupportTicket"
        'Dim openTicketComboBoxDataAdapter As SqlDataAdapter
        Dim openTicketsdataTable As New DataTable()

        ' Dim fillComboBoxFromTableDataTable As SqlDataAdapter
        Dim fillComboBoxFromTableDataTable As SqlDataAdapter = New SqlDataAdapter(openTickets, DB_connection_string)
        fillComboBoxFromTableDataTable.Fill(openTicketsdataTable)
        Dim ticketColumnName As String = "ticketID"
        'column name to be displayed in the combo box.
        problemTicketNumberToResolve.DisplayMember = ticketColumnName
        problemTicketNumberToResolve.ValueMember = ticketColumnName

        'trying to close this here because i was getting errors that might relate to this ? 
        DB_connection_string.Close()
    End Sub

    Private Sub resolveProblemTicket_Click(sender As Object, e As EventArgs) Handles resolveProblemTicket.Click
        'when this button is clicked get either the selected ticket from the selected item in the data grid view or ticket number and resolve that ticket. 
        'easiest may be the selected row. 


        'TO DO WORK ON THIS PART NEXT. RESOLVE A FRIGGIN TICKET
        'Try USING THIS SNIPPET
        '  Try
        '   Dim row As DataGridViewRow = openTicketsDataGridView.SelectedRows.Item(0)

        '' selected row is problem to solve. 
        'just have the user enter a description of the resolution and then they will be able to resolve the ticket either through an update or insert SQL command

        ''now how to get the database to know that this is the row that we want to edit 
        Dim ticketNum As Integer = CInt(problemTicketNumberToResolve.SelectedValue)




        Dim SQLinsertResolveTicketCommand As String = "Insert into ResolvedTickets (ticketid,dateout,resolutiondescription) values ( @ticketID, @Dateout, @resolutionDescription)"

        Dim SQLResolveTicketCommand As New SqlCommand(SQLinsertResolveTicketCommand, DB_connection_string)

        SQLResolveTicketCommand.Parameters.AddWithValue("@ticketID", ticketNum)

        SQLResolveTicketCommand.Parameters.AddWithValue("@Dateout", Date.Now)

        SQLResolveTicketCommand.Parameters.AddWithValue("@resolutionDescription", resolutionDescription_RichTextBox.Text)

        Try
            DB_connection_string.Open()
            SQLResolveTicketCommand.ExecuteNonQuery()

            DB_connection_string.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message + "Look into this error if throw and try to write meaning ful catch phrases" + vbNewLine + ":)", "Fix Me", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

        'TODO AFTER THIS IS WORKING ALLOW USER TO SET DATE IN AND DATE RESOLVED. AS AN EXTRA FEATURE:
        '    MessageBox.Show("Ticket sent to Database" + vbNewLine + "Check Database table to see updated content", "Sucess!", MessageBoxButtons.OK, MessageBoxIcon.None)
    End Sub








End Class

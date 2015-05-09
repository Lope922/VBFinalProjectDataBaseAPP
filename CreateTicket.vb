Imports System.Windows.Forms
Imports System.Data.SqlClient

'Imports System.Data.SqlClient

Public Class CreateTicket

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
        ' create a new sqldataadapter to geneerate a request for all tech names avialable from to fill the combo box with. 
        Dim allTechsAvailableInDB As New SqlDataAdapter

        locationComboBox.Items.Add("Accounting")
        locationComboBox.Items.Add("IT Department")
        locationComboBox.Items.Add("Financing")
        locationComboBox.Items.Add("Tech Support")
        locationComboBox.Items.Add("Database Administration")
        locationComboBox.Items.Add("Front End")
        locationComboBox.Items.Add("Back End")
        locationComboBox.Items.Add("Warehouse")

        '' figure how to automatically get the date in this formate listed below 

        Dim dateIn As Date = Today
        dateLabel.Text = ("Current Date:" + dateIn.ToString)

        ' request the techs available from the database. 
        ' if database is empty display a message letting the user know that they need to add Techs to the database. 
    End Sub

    Dim objTableDataAdapter As SqlDataAdapter



    Dim objTechNamesDataTable As New DataTable()


    Dim DB_connection_string As New SqlConnection("server=LOPE_S_PC\MCTCSQLSTUDENT;database=FinalDatabaseProject;Trusted_Connection=yes")
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Fetch names of tables and display them in first combobox
        objTableDataAdapter = New SqlDataAdapter("SELECT [Tech name] FROM TechList", DB_connection_string)
        ' use the tech names data table to fill the obj table data adapter 
        objTableDataAdapter.Fill(objTechNamesDataTable)

        'the data source for the combo box is the available techs in the database. 
        assignedTechcomboBox.DataSource = objTechNamesDataTable

        Dim columnName As String = "Tech Name"

        assignedTechcomboBox.DisplayMember = columnName

        assignedTechcomboBox.ValueMember = columnName

        ' dim select all Sql string that will make the request 
        Dim selectAllOpenTicketsSQL As String = "SELECT * FROM [OpenTickets]"
        Dim allDataFromTableDataAdapter As SqlDataAdapter
        Dim addDataFromTableDataTable As DataTable

        ' now fill a grid box with the data. 
        allDataFromTableDataAdapter = New SqlDataAdapter(selectAllOpenTicketsSQL, DB_connection_string)

        
        '' EXACTLY WHAT I WANT TO DO RIGHT HERE./
        addDataFromTableDataTable = New DataTable()
        ' THIS FILLS THE DATA GRID. 
        allDataFromTableDataAdapter.Fill(addDataFromTableDataTable)
        '' THIS SAYS THE DATA GRID SOURCE IS THE DATA GRID ITSELF. 
        createTicketDataGridView.DataSource = addDataFromTableDataTable
        
        ' may need this later 
        'Dim technameRowCount As Integer = objTechNamesDataTable.Rows.Count
        'Dim techName As String = objTableDataAdapter



    End Sub
    'PART oF TESTING
    Dim createTicketDataSQL As New SqlDataAdapter



    ' this is for testing out the class object. 
    Dim testMe As PiecesNeeded
    Private Sub addProblemTicket_Click(sender As Object, e As EventArgs) Handles addProblemTicket.Click
        ' when this button is clicked set the values needed to equal to the user input 


        Dim techtoAssignTask As String = assignedTechcomboBox.SelectedValue.ToString

        ' here is the assigned tech 
        '    MessageBox.Show("To make sure we have the right tech selected here is the assigned tech " + techtoAssignTask)
        Dim dateCalledIn As Date = Date.Now
        'date called in 

        Dim problemDescription As String = createTicket_RichTextBox.Text
        ' the problem description 

        Dim problemSeverity As Integer = CInt(severityNumericUpDown.Value)
        ' here is the severity 

        Dim problemLocation As String = locationComboBox.SelectedItem.ToString

        Dim sqlinsertTicketCommand As String = "INSERT INTO OpenTickets VALUES (@Tech_ID, @Problem_Ticket_Number, @Description, @Date_called_in,@location, @severity)"
        'tech id , problem ticket number, description, date called in, location of problem, severity

        Dim insertProblemticketSqlCommand As New SqlCommand(sqlinsertTicketCommand, DB_connection_string)

        insertProblemticketSqlCommand.Parameters.AddWithValue("@Tech_ID", techtoAssignTask)
        insertProblemticketSqlCommand.Parameters.AddWithValue("@Problem_Ticket_Number", 2)
        insertProblemticketSqlCommand.Parameters.AddWithValue("@Description", problemDescription)
        insertProblemticketSqlCommand.Parameters.AddWithValue("@Date_called_in", dateCalledIn)
        insertProblemticketSqlCommand.Parameters.AddWithValue("@location", problemLocation)
        insertProblemticketSqlCommand.Parameters.AddWithValue("@severity", problemSeverity)

        Try
            DB_connection_string.Open()
            insertProblemticketSqlCommand.ExecuteNonQuery()
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

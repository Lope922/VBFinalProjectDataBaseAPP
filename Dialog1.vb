Imports System.Windows.Forms
Imports System.Data.SqlClient

'Imports System.Data.SqlClient

Public Class Dialog1
    ' this will be used when creating a ticket it will be auto applied. 


    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
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
        Dim dateIn As Date = Now.ToShortDateString("MM.dd.yy")
        dateLabel = dateIn

        ' request the techs available from the database. 
        ' if database is empty display a message letting the user know that they need to add Techs to the database. 
    End Sub

    Dim objTableDataAdapter As SqlDataAdapter


   
    Dim objTechNamesDataTable As New DataTable()
   
    Dim DB_connection_string As String = "server=LOPE_S_PC\MCTCSQLSTUDENT;database=FinalDatabaseProject;user id=sa;password=paSSw0rd29"
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

        ' may need this later 
        'Dim technameRowCount As Integer = objTechNamesDataTable.Rows.Count
        'Dim techName As String = objTableDataAdapter



    End Sub
    ' this is for testing out the class object. 
    Dim testMe As PiecesNeeded
    Private Sub addProblemTicket_Click(sender As Object, e As EventArgs) Handles addProblemTicket.Click
        ' when this button is clicked set the values needed to equal to the user input 

        Dim techtoAssignTask As String = assignedTechcomboBox.SelectedText
        ' here is the assigned tech 
        Dim problemSeverity As Integer = CInt(severityNumericUpDown.Value)
        ' here is the severity 

        'create a lable to show today's date. That will be helpful. 

        ' what is required for a problem ticket ? Tech id , problem ticket #, problem description, date called in, location and severity. 
    End Sub
End Class

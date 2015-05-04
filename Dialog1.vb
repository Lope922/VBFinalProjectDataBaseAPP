Imports System.Windows.Forms
Imports System.Data.SqlClient

'Imports System.Data.SqlClient

Public Class Dialog1

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

        ' request the techs available from the database. 
        ' if database is empty display a message letting the user know that they need to add Techs to the database. 

        Dim sqlConnectionString As New SqlConnection("server=LOPE_S_PC\MCTCSQLSTUDENT;database=FinalDatabaseProject;user id=sa;password=paSSw0rd29")

        Dim requestForTechs As String = "SELECT Tech Name FROM TechList"

        '' fill the combo box with the possible names selected, and then use that name to assign a ticket to them 
        Dim comboBox As SqlDataAdapter()

        allTechsAvailableInDB = New SqlDataAdapter(requestForTechs, sqlConnectionString)

        addDatatoComboBox = New DataTable()

        allTechsAvailableInDB.Fill(comboBox)

        assignedTechcomboBox.



    End Sub
End Class

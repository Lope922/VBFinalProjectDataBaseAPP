Imports System.Data.SqlClient
Public Class Form1

    'think about the objects that will be used throughout the program and start to divide up pieces needed into classes. 

    Dim testobjAdapter As SqlDataAdapter
    ' Dim main_menu_test_Data_Grid_1st_queary As DataTable()
    Dim allDataFromTableDataAdapter As SqlDataAdapter
    Dim addDataFromTableDataTable As DataTable


    Private Sub helpButton_Click(sender As Object, e As EventArgs) Handles programhelpButton.Click
        ' open a dialog window to show the user how to use the main menu and program.


    End Sub

    Private Sub createTicketButton_Click(sender As Object, e As EventArgs) Handles createTicketButton.Click
        '   Try
        'MessageBox.Show("Here comes the Dialog window ")
        Me.Hide()

        CreateTicket.ShowDialog()
        ' createProblemTicket.Show()

        'Catch ex As Exception
        'MessageBox.Show(ex.Message)
        'End Try
    End Sub

    Private Sub emailTech_Click(sender As Object, e As EventArgs) Handles emailTech.Click
        Me.Hide()
        CreateEmail.ShowDialog()
    End Sub


    ''TODO GET ONE BASIC THING WORKING WITH THE DATABASE. eVEN PULLING A TABLE THAT IS FULL OF INFORMATION INTO A FORM, OR BUTTON CLICK. 
    ' first basic thing to get working is the tech name list loading into dialog1 form. 




    ''TODO FINISH WRITING STRUCTURES/CLASSES AFTER REVIEWING COFFEE SHOP PROGRAM 

    ''CONSIDER THE PRACTICALITY OF HAVING A USER LOGIN , SO WHO CREATES THE ISSUE TICKET CAN BE RECORDED. 

    

    Private Sub viewOpenTickets_Click(sender As Object, e As EventArgs) Handles viewOpenTickets.Click
        'create a connection to the database and make a sql queary for the table of open tickets. 
        ' select all information needed from the table and display it in the data grid view of the window that opens. 


        ''TRYING TO FIX CONNECTION STRING... SET IT UP FOR LOCAL HOST AND WINDOWS TRUSTED CONNECTION. 

        ' queary connection string. 
        Dim sqlConnectionSTring As New SqlConnection("server=LOPE_S_PC\MCTCSQLSTUDENT;database=FinalDatabaseProject;Trusted_Connection=yes")
        ' just created a talbe that has open tickets that stores : TECH ID AS STRING, PROBLEM TICKET AS INT, DESCRIPTION AS STRING, DATE CALLED IN AS DATE, LOCATION AS STRING. 

        ' dim select all Sql string that will make the request 
        ' select everything from the ticket table 
        Dim selectTicketSQL As String = "SELECT * FROM Tickets"

        'testobjAdapter = New SqlDataAdapter(selectAllSQL, sqlConnectionSTring)

        'testobjAdapter = New DataTable()
        'testobjAdapter.Fill(main_menu_test_Data_Grid_1st_queary)

        'openTicketsDataGridView1.DataSource = main_menu_test_Data_Grid_1st_queary
        ' now fill a grid box with the data. 
        allDataFromTableDataAdapter = New SqlDataAdapter(selectTicketSQL, sqlConnectionSTring)


        '' EXACTLY WHAT I WANT TO DO RIGHT HERE./
        addDataFromTableDataTable = New DataTable()
        ' THIS FILLS THE DATA GRID. 
        allDataFromTableDataAdapter.Fill(addDataFromTableDataTable)
        '' THIS SAYS THE DATA GRID SOURCE IS THE DATA GRID ITSELF. 
        openTicketsDataGridView1.DataSource = addDataFromTableDataTable

    End Sub

    Private Sub resolveProblemTicketButton_Click(sender As Object, e As EventArgs) Handles resolveProblemTicketButton.Click
        rtDialog.Show()
        Me.Hide()
    End Sub

    Private Sub addTechButton_Click(sender As Object, e As EventArgs) Handles addTechButton.Click

    End Sub
End Class

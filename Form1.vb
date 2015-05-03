Imports System.Data.SqlClient
Public Class Form1

    Private Sub helpButton_Click(sender As Object, e As EventArgs) Handles programhelpButton.Click
        ' open a dialog window to show the user how to use the main menu and program.


    End Sub

    Private Sub createTicketButton_Click(sender As Object, e As EventArgs) Handles createTicketButton.Click
        '   Try
        MessageBox.Show("Here comes the Dialog window ")
        Me.Hide()

        Dialog1.ShowDialog()
        ' createProblemTicket.Show()

        'Catch ex As Exception
        'MessageBox.Show(ex.Message)
        'End Try
    End Sub

    Private Sub emailTech_Click(sender As Object, e As EventArgs) Handles emailTech.Click
        CreateEmail.ShowDialog()
    End Sub


    ''TODO GET ONE BASIC THING WORKING WITH THE DATABASE. eVEN PULLING A TABLE THAT IS FULL OF INFORMATION INTO A FORM, OR BUTTON CLICK. 
    ' first basic thing to get working is the tech name list loading into dialog1 form. 




    ''TODO FINISH WRITING STRUCTURES/CLASSES AFTER REVIEWING COFFEE SHOP PROGRAM 

    ''CONSIDER THE PRACTICALITY OF HAVING A USER LOGIN , SO WHO CREATES THE ISSUE TICKET CAN BE RECORDED. 

    'THESE Are PUBLIC MOVE TO THE TOP  
    Dim testobjAdapter As SqlDataAdapter
    Dim main_menu_test_Data_Grid_1st_queary As DataTable()


    Private Sub viewOpenTickets_Click(sender As Object, e As EventArgs) Handles viewOpenTickets.Click
        'create a connection to the database and make a sql queary for the table of open tickets. 
        ' select all information needed from the table and display it in the data grid view of the window that opens. 

        ' queary connection string. 
        Dim sqlConnectionSTring As New SqlConnection("server=LOPE_S_PC\MCTCSQLSTUDENT;database=FinalDatabaseProject;user id=sa;password=paSSw0rd29")
        ' just created a talbe that has open tickets that stores : TECH ID AS STRING, PROBLEM TICKET AS INT, DESCRIPTION AS STRING, DATE CALLED IN AS DATE, LOCATION AS STRING. 

        ' dim select all Sql string that will make the request 
        Dim selectAllSQL As String = "SELECT * FROM Open Tickets"

        testobjAdapter = New SqlDataAdapter(selectAllSQL, sqlConnectionSTring)

        ' main_menu_test_Data_Grid_1st_queary = New DataTable()
        'testobjAdapter.Fill(main_menu_test_Data_Grid_1st_queary)

        openTicketsDataGridView1.DataSource = main_menu_test_Data_Grid_1st_queary
        ' now fill a grid box with the data. 


    End Sub
End Class

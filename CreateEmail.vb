Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class CreateEmail


    Dim objTableDataAdapter As SqlDataAdapter
    Dim objTechNamesDataTable As New DataTable()
    Dim DB_connection_string As New SqlConnection("server=LOPE_S_PC\MCTCSQLSTUDENT;database=FinalDatabaseProject;Trusted_Connection=yes")

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub CreateEmail_Click(sender As Object, e As EventArgs) Handles Me.Click

    End Sub


    Private Sub CreateEmail_Load(sender As Object, e As EventArgs) Handles Me.Load


        ' techAvailableToeMailComboBox.SelectedItem = Nothing
        'try to find some way to make sure that user want's the selected user to be the assigned tech to recieve the e-mail. 

        problemTicketToEmailComboBox.Enabled = False


        'LOAD THE AVAILABLE TECHS TO E-MAIL FROM THE TECHLIST. 
        'Fetch names of tables and display them in first combobox
        ' objTableDataAdapter = New SqlDataAdapter("SELECT [Tech name] FROM TechList where dateout is null", DB_connection_string)
        objTableDataAdapter = New SqlDataAdapter("SELECT techid FROM techsupportticket where dateout is null", DB_connection_string)
        ' use the tech names data table to fill the obj table data adapter 
        objTableDataAdapter.Fill(objTechNamesDataTable)

        'the data source for the combo box is the available techs in the database. 
        techAvailableToeMailComboBox.DataSource = objTechNamesDataTable

        Dim columnName As String = "Techid"

        techAvailableToeMailComboBox.DisplayMember = columnName

        techAvailableToeMailComboBox.ValueMember = columnName

        '' ONCE THIS IS LOADED THE USER CAN PICK WHO THEY WOULD LIKE TO E-MAIL , WHICH SHOULD THEN LOAD THE AVAILBLE TICKET BY TICKET NUMBER. 

        'for now the only failsafe to keep the user from messing things up is disableing the combobox

        Send_Button.Enabled = False


    End Sub

    Private Sub viewOpenTickets_Click(sender As Object, e As EventArgs) Handles viewOpenTickets.Click
        'after the user has viewed the list of open ticket's they can select the technician to email and then e-mail them their open tickets. 
        problemTicketToEmailComboBox.Enabled = True
        'todo  get the basics working here. 
        ' this is the search string to display open tickets in the data grid. SELECT ticketID,techID,Problemdescription,datein,location,severity FROM TechSupportTicket where dateout is null"
        ' they should then be able to reference which technician to e-mail the problem ticket number. 

        ' maybe create some radio buttons to either e-mail selected ticket from data row table, and send just one ticket , 
        'or another radio button to select all open tickets and send by severity and oldest date first at the top of the list. 

        Open_Ticket_Dialog_Window.Show()

        'then user selects the ticket they want to e-mail to the user. 
        'when this window is opened display the open tickets as well as the avilable techs. 
        'Fetch names of tables and display them in first combobox using a new objTableDataAdapter
        objTableDataAdapter = New SqlDataAdapter("SELECt ticketID FROm TechSupportTicket where dateout is null", DB_connection_string)

        ' use the tech names data table to fill the obj table data adapter 
        objTableDataAdapter.Fill(objTechNamesDataTable)

        'the data source for the combo box is the available techs in the database. 
        problemTicketToEmailComboBox.DataSource = objTechNamesDataTable

        'use this search string to select the tech name column to be displayed in the combo box. 
        Dim columnName As String = "TicketID"
        'this assigns the value within the column into the member displayed in the data table 
        problemTicketToEmailComboBox.DisplayMember = columnName
        problemTicketToEmailComboBox.ValueMember = columnName




    End Sub

    Private Sub Send_Button_Click(sender As Object, e As EventArgs) Handles Send_Button.Click
        'send the e-mail to the tech 

        '' this came from database support APP. See what this was from it may be useful. 
        'Dim row As DataGridViewRow = grdTechnicians.SelectedRows.Item(0)

        'From the row, get the second cell - the one with the email in
        'Dim techEmail As String = row.Cells.Item(2).FormattedValue.ToString

        Dim techName As String = techAvailableToeMailComboBox.SelectedValue.ToString
        Dim subject As String = "You have work to do!"

        Dim testText As String = "Here is where the formatted message would go."
        '' try to send an e-mail using outlook if installed. 
        Try
            Process.Start(String.Format("mailto:{0}?subject={1}&body={2}", techName.ToString, subject, testText.ToString))


            'TODO FIX E-MAIL ADDRESS AND ADD MESSAGE CONTNETS TO THE THE STRING FORMAT. 

        Catch ex As Exception
            MessageBox.Show("No default email client (e.g. Outlook) is not configured")
        End Try

        'If you wanted to, this would be fairly easy to modify to email all technicians
        'Or, to change the selection mode to multiple rows and email selected technicians
    End Sub

    Private Sub Cancel_Button_Click_1(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        Me.Hide()
        Form1.ShowDialog()
    End Sub

    Private Sub techAvailableToeMailComboBox_Click(sender As Object, e As EventArgs) Handles techAvailableToeMailComboBox.Click
        If techAvailableToeMailComboBox.SelectedValue Is Nothing Then
            Send_Button.Enabled = False
        ElseIf techAvailableToeMailComboBox.SelectedIndex > 1 Then
            Send_Button.Enabled = True
        End If
    End Sub

    Private Sub helpthisForm_Button1_Click(sender As Object, e As EventArgs) Handles helpthisForm_Button1.Click
        If createEmail_help_RichTextBox1.Enabled = False Then
            createEmail_help_RichTextBox1.Show()
        Else
            createEmail_help_RichTextBox1.Enabled = False
        End If
    End Sub
End Class

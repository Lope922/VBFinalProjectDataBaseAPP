Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class CreateEmail

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        ' once the user clicks the send button use the problem ticket window to send propblem ticket from reference window that shows open tickets



        'show the avialable tickets by problem ticket and ticket Number

        MessageBox.Show("email sent")
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    'TOMORROW THE TODO FOR THIS IS TO LOAD THE TEXT BOX AND POP UP WITH WINDOW TO SEE HOW TO SEND THE E=MAIL. 

    ' when this button is clicked popup a window that shows the current open tickets. 
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub


    Dim objTableDataAdapter As SqlDataAdapter



    Dim objTechNamesDataTable As New DataTable()


    Dim DB_connection_string As New SqlConnection("server=LOPE_S_PC\MCTCSQLSTUDENT;database=FinalDatabaseProject;Trusted_Connection=yes")
    Private Sub CreateEmail_Load(sender As Object, e As EventArgs) Handles Me.Load


        ' techAvailableToeMailComboBox.SelectedItem = Nothing
        'try to find some way to make sure that user want's the selected user to be the assigned tech to recieve the e-mail. 

        problemTicketToEmailComboBox.Enabled = False


        'LOAD THE AVAILABLE TECHS TO E-MAIL FROM THE TECHLIST. 
        'Fetch names of tables and display them in first combobox
        objTableDataAdapter = New SqlDataAdapter("SELECT [Tech name] FROM TechList", DB_connection_string)
        ' use the tech names data table to fill the obj table data adapter 
        objTableDataAdapter.Fill(objTechNamesDataTable)

        'the data source for the combo box is the available techs in the database. 
        techAvailableToeMailComboBox.DataSource = objTechNamesDataTable

        Dim columnName As String = "Tech Name"

        techAvailableToeMailComboBox.DisplayMember = columnName

        techAvailableToeMailComboBox.ValueMember = columnName




        '' ONCE THIS IS LOADED THE USER CAN PICK WHO THEY WOULD LIKE TO E-MAIL , WHICH SHOULD THEN LOAD THE AVAILBLE TICKET BY TICCKET NUMBER. 




    End Sub

    Private Sub viewOpenTickets_Click(sender As Object, e As EventArgs) Handles viewOpenTickets.Click
        'after the user has viewed the list of open ticket's they can select the technician to email and then e-mail them their open tickets. 
        problemTicketToEmailComboBox.Enabled = True

        ' they should then be able to reference which technician to e-mail the problem ticket number. 

        ' maybe create some radio buttons to either e-mail selected ticket from data row table, and send just one ticket , 
        'or another radio button to select all open tickets and send by severity and oldest date first at the top of the list. 

        Open_Ticket_Dialog_Window.Show()




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
End Class

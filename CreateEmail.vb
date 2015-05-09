Imports System.Windows.Forms

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

    Private Sub CreateEmail_Load(sender As Object, e As EventArgs) Handles Me.Load

        'load available techs from techlist. 


        'IF THE USER CLICKS THE ADD TICKET BUTTON EXECTURE WHAT IS BELOW.
        'If NewUserDialog.ShowDialog = Windows.Forms.DialogResult.OK Then

        '    'Fetch new user from Tag, extract username and email

        '    Dim user As User = CType(NewUserDialog.Tag, User)

        'DONE AND DONE 
        '    Dim newUserInsertSQL As String = "insert into users values (@username, @email)"
        '    Dim sqlAddUserCommand As New SqlCommand(newUserInsertSQL, objConnection)


        '    sqlAddUserCommand.Parameters.AddWithValue("@username", user.Username)
        '    sqlAddUserCommand.Parameters.AddWithValue("@email", user.Email)

        '    Try
        '        objConnection.Open()
        '        sqlAddUserCommand.ExecuteNonQuery()
        '        objConnection.Close()

        '        MessageBox.Show("New user added, reload table in datagrid view to verify")

        '    Catch se As SqlException
        '        'If this username already exists, we'll get a specific SQLException 
        '        'SQL Exceptions contain an error code, to help identify different types of errors.
        '        'Trying to insert a row with a unique column value that duplicates the same value
        '        ' in another row generates a SQLException with error code 2627. You can look these up online - Google "SQL Server error codes"
        '      
        'If se.Number = 2627 Then
        '            'Duplicate row, this user already exists
        '            MessageBox.Show("This user or email already exists the database in, try again")
        '        Else
        '            MessageBox.Show("Database error: " & se.Message) 'Don't display the exception message in production code!
        '        End If

        '    End Try

        'End If



       
    End Sub
End Class

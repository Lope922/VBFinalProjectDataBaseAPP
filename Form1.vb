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
    ''TODO FINISH WRITING STRUCTURES/CLASSES AFTER REVIEWING COFFEE SHOP PROGRAM 

    ''CONSIDER THE PRACTICALITY OF HAVING A USER LOGIN , SO WHO CREATES THE ISSUE TICKET CAN BE RECORDED. 



End Class

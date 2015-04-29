Public Class Form1

    Private Sub helpButton_Click(sender As Object, e As EventArgs) Handles helpButton.Click
        ' open a dialog window to show the user how to use the main menu and program.

    End Sub

    Private Sub createTicketButton_Click(sender As Object, e As EventArgs) Handles createTicketButton.Click
        problemTicketForm.ShowDialog()
    End Sub
End Class

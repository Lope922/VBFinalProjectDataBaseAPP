Imports System.Windows.Forms
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

        locationComboBox.Items.Add("Accounting")
        locationComboBox.Items.Add("IT Department")
        locationComboBox.Items.Add("Financing")
        locationComboBox.Items.Add("Tech Support")
        locationComboBox.Items.Add("Database Administration")
        locationComboBox.Items.Add("Front End")
        locationComboBox.Items.Add("Back End")
        locationComboBox.Items.Add("Warehouse")

        'ticketSeverityComboBox.Items.Add(1)
        'ticketSeverityComboBox.Items.Add(2)
        'ticketSeverityComboBox.Items.Add(3)
        'ticketSeverityComboBox.Items.Add(4)
        'ticketSeverityComboBox.Items.Add(5)
    End Sub
End Class

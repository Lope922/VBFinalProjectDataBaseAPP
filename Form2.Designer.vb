<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class problemTicketForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.addProblemTicket = New System.Windows.Forms.Button()
        Me.close_ProblemTicketWindow = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.assignedTechcomboBox = New System.Windows.Forms.ComboBox()
        Me.ticketSeverityComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.problemDescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.locationComboBox = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'addProblemTicket
        '
        Me.addProblemTicket.Location = New System.Drawing.Point(406, 201)
        Me.addProblemTicket.Name = "addProblemTicket"
        Me.addProblemTicket.Size = New System.Drawing.Size(119, 23)
        Me.addProblemTicket.TabIndex = 0
        Me.addProblemTicket.Text = "Add Problem Ticket"
        Me.addProblemTicket.UseVisualStyleBackColor = True
        '
        'close_ProblemTicketWindow
        '
        Me.close_ProblemTicketWindow.Location = New System.Drawing.Point(531, 201)
        Me.close_ProblemTicketWindow.Name = "close_ProblemTicketWindow"
        Me.close_ProblemTicketWindow.Size = New System.Drawing.Size(75, 23)
        Me.close_ProblemTicketWindow.TabIndex = 1
        Me.close_ProblemTicketWindow.Text = "Close "
        Me.close_ProblemTicketWindow.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(393, 21)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Assign Tech"
        '
        'assignedTechcomboBox
        '
        Me.assignedTechcomboBox.FormattingEnabled = True
        Me.assignedTechcomboBox.Location = New System.Drawing.Point(18, 87)
        Me.assignedTechcomboBox.Name = "assignedTechcomboBox"
        Me.assignedTechcomboBox.Size = New System.Drawing.Size(121, 21)
        Me.assignedTechcomboBox.TabIndex = 4
        '
        'ticketSeverityComboBox
        '
        Me.ticketSeverityComboBox.FormattingEnabled = True
        Me.ticketSeverityComboBox.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.ticketSeverityComboBox.Location = New System.Drawing.Point(15, 35)
        Me.ticketSeverityComboBox.Name = "ticketSeverityComboBox"
        Me.ticketSeverityComboBox.Size = New System.Drawing.Size(121, 21)
        Me.ticketSeverityComboBox.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Problem Severity"
        '
        'problemDescriptionTextBox
        '
        Me.problemDescriptionTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.problemDescriptionTextBox.Location = New System.Drawing.Point(18, 151)
        Me.problemDescriptionTextBox.Name = "problemDescriptionTextBox"
        Me.problemDescriptionTextBox.Size = New System.Drawing.Size(293, 20)
        Me.problemDescriptionTextBox.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Problem Description"
        '
        'locationComboBox
        '
        Me.locationComboBox.FormattingEnabled = True
        Me.locationComboBox.Location = New System.Drawing.Point(204, 87)
        Me.locationComboBox.Name = "locationComboBox"
        Me.locationComboBox.Size = New System.Drawing.Size(121, 21)
        Me.locationComboBox.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(201, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Problem Location (Building)"
        '
        'problemTicketForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 236)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.locationComboBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.problemDescriptionTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ticketSeverityComboBox)
        Me.Controls.Add(Me.assignedTechcomboBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.close_ProblemTicketWindow)
        Me.Controls.Add(Me.addProblemTicket)
        Me.Name = "problemTicketForm"
        Me.Text = "Create Problem Ticket"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents addProblemTicket As System.Windows.Forms.Button
    Friend WithEvents close_ProblemTicketWindow As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents assignedTechcomboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ticketSeverityComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents problemDescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents locationComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateEmail
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
        Me.viewOpenTickets = New System.Windows.Forms.Button()
        Me.problemTicketToEmailComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.techAvailableToeMailComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Send_Button = New System.Windows.Forms.Button()
        Me.createEmail_help_RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.helpthisForm_Button1 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'viewOpenTickets
        '
        Me.viewOpenTickets.Location = New System.Drawing.Point(76, 130)
        Me.viewOpenTickets.Name = "viewOpenTickets"
        Me.viewOpenTickets.Size = New System.Drawing.Size(122, 23)
        Me.viewOpenTickets.TabIndex = 17
        Me.viewOpenTickets.Text = "View Open Tickets"
        Me.viewOpenTickets.UseVisualStyleBackColor = True
        '
        'problemTicketToEmailComboBox
        '
        Me.problemTicketToEmailComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.problemTicketToEmailComboBox.FormattingEnabled = True
        Me.problemTicketToEmailComboBox.Location = New System.Drawing.Point(139, 65)
        Me.problemTicketToEmailComboBox.Name = "problemTicketToEmailComboBox"
        Me.problemTicketToEmailComboBox.Size = New System.Drawing.Size(162, 21)
        Me.problemTicketToEmailComboBox.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Problem Ticket"
        '
        'techAvailableToeMailComboBox
        '
        Me.techAvailableToeMailComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.techAvailableToeMailComboBox.FormattingEnabled = True
        Me.techAvailableToeMailComboBox.Items.AddRange(New Object() {"--"})
        Me.techAvailableToeMailComboBox.Location = New System.Drawing.Point(139, 18)
        Me.techAvailableToeMailComboBox.Name = "techAvailableToeMailComboBox"
        Me.techAvailableToeMailComboBox.Size = New System.Drawing.Size(162, 21)
        Me.techAvailableToeMailComboBox.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Technician To e-mail"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Send_Button, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(261, 127)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 12
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'Send_Button
        '
        Me.Send_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Send_Button.Location = New System.Drawing.Point(3, 3)
        Me.Send_Button.Name = "Send_Button"
        Me.Send_Button.Size = New System.Drawing.Size(67, 23)
        Me.Send_Button.TabIndex = 0
        Me.Send_Button.Text = "Send"
        '
        'createEmail_help_RichTextBox1
        '
        Me.createEmail_help_RichTextBox1.Enabled = False
        Me.createEmail_help_RichTextBox1.Font = New System.Drawing.Font("Modern No. 20", 17.95!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.createEmail_help_RichTextBox1.Location = New System.Drawing.Point(22, 45)
        Me.createEmail_help_RichTextBox1.Name = "createEmail_help_RichTextBox1"
        Me.createEmail_help_RichTextBox1.Size = New System.Drawing.Size(401, 100)
        Me.createEmail_help_RichTextBox1.TabIndex = 63
        Me.createEmail_help_RichTextBox1.Text = "HERE is where you can generate e-mails  associated with the ticket nuber and work" & _
    "er. Click view open tickets to get started. "
        '
        'helpthisForm_Button1
        '
        Me.helpthisForm_Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.helpthisForm_Button1.Font = New System.Drawing.Font("Magneto", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.helpthisForm_Button1.ForeColor = System.Drawing.Color.Yellow
        Me.helpthisForm_Button1.Location = New System.Drawing.Point(396, 12)
        Me.helpthisForm_Button1.Name = "helpthisForm_Button1"
        Me.helpthisForm_Button1.Size = New System.Drawing.Size(27, 31)
        Me.helpthisForm_Button1.TabIndex = 64
        Me.helpthisForm_Button1.Text = "?"
        Me.helpthisForm_Button1.UseVisualStyleBackColor = False
        '
        'CreateEmail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 175)
        Me.Controls.Add(Me.createEmail_help_RichTextBox1)
        Me.Controls.Add(Me.helpthisForm_Button1)
        Me.Controls.Add(Me.viewOpenTickets)
        Me.Controls.Add(Me.problemTicketToEmailComboBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.techAvailableToeMailComboBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CreateEmail"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "CreateEmail"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents viewOpenTickets As System.Windows.Forms.Button
    Friend WithEvents problemTicketToEmailComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents techAvailableToeMailComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Send_Button As System.Windows.Forms.Button
    Friend WithEvents createEmail_help_RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents helpthisForm_Button1 As System.Windows.Forms.Button

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateTicket
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.addProblemTicket = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.locationComboBox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.assignedTechcomboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.createTicketDataGridView = New System.Windows.Forms.DataGridView()
        Me.severityNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.createTicket_RichTextBox = New System.Windows.Forms.RichTextBox()
        Me.dateLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.createTicketDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.severityNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.addProblemTicket, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(350, 323)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(259, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(145, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(97, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Close Window"
        '
        'addProblemTicket
        '
        Me.addProblemTicket.Location = New System.Drawing.Point(3, 3)
        Me.addProblemTicket.Name = "addProblemTicket"
        Me.addProblemTicket.Size = New System.Drawing.Size(121, 23)
        Me.addProblemTicket.TabIndex = 33
        Me.addProblemTicket.Text = "Add Problem Ticket"
        Me.addProblemTicket.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 13)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Problem Location (Building)"
        '
        'locationComboBox
        '
        Me.locationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.locationComboBox.FormattingEnabled = True
        Me.locationComboBox.Location = New System.Drawing.Point(51, 184)
        Me.locationComboBox.Name = "locationComboBox"
        Me.locationComboBox.Size = New System.Drawing.Size(121, 21)
        Me.locationComboBox.TabIndex = 42
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 251)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Problem Description"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Problem Severity"
        '
        'assignedTechcomboBox
        '
        Me.assignedTechcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.assignedTechcomboBox.FormattingEnabled = True
        Me.assignedTechcomboBox.Location = New System.Drawing.Point(51, 101)
        Me.assignedTechcomboBox.Name = "assignedTechcomboBox"
        Me.assignedTechcomboBox.Size = New System.Drawing.Size(121, 21)
        Me.assignedTechcomboBox.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Assign Tech"
        '
        'createTicketDataGridView
        '
        Me.createTicketDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.createTicketDataGridView.Location = New System.Drawing.Point(259, 38)
        Me.createTicketDataGridView.Name = "createTicketDataGridView"
        Me.createTicketDataGridView.Size = New System.Drawing.Size(433, 213)
        Me.createTicketDataGridView.TabIndex = 35
        '
        'severityNumericUpDown
        '
        Me.severityNumericUpDown.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.severityNumericUpDown.Location = New System.Drawing.Point(147, 57)
        Me.severityNumericUpDown.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.severityNumericUpDown.Name = "severityNumericUpDown"
        Me.severityNumericUpDown.Size = New System.Drawing.Size(36, 20)
        Me.severityNumericUpDown.TabIndex = 44
        Me.severityNumericUpDown.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'createTicket_RichTextBox
        '
        Me.createTicket_RichTextBox.Location = New System.Drawing.Point(51, 267)
        Me.createTicket_RichTextBox.Name = "createTicket_RichTextBox"
        Me.createTicket_RichTextBox.Size = New System.Drawing.Size(293, 99)
        Me.createTicket_RichTextBox.TabIndex = 45
        Me.createTicket_RichTextBox.Text = ""
        '
        'dateLabel
        '
        Me.dateLabel.AutoSize = True
        Me.dateLabel.Location = New System.Drawing.Point(12, 24)
        Me.dateLabel.Name = "dateLabel"
        Me.dateLabel.Size = New System.Drawing.Size(79, 13)
        Me.dateLabel.TabIndex = 46
        Me.dateLabel.Text = "Today's Date : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(256, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Open Tickets :"
        '
        'CreateTicket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(716, 381)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dateLabel)
        Me.Controls.Add(Me.createTicket_RichTextBox)
        Me.Controls.Add(Me.severityNumericUpDown)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.locationComboBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.assignedTechcomboBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.createTicketDataGridView)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CreateTicket"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Dialog1"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.createTicketDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.severityNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents locationComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents assignedTechcomboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents createTicketDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents addProblemTicket As System.Windows.Forms.Button
    Friend WithEvents severityNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents createTicket_RichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents dateLabel As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rtDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rtDialog))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dateLabel = New System.Windows.Forms.Label()
        Me.resolutionDescription_RichTextBox = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.openTicketsDataGridView = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.closeButton = New System.Windows.Forms.Button()
        Me.resolveProblemTicket = New System.Windows.Forms.Button()
        Me.problemTicketNumberToResolve = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.helpthisForm_Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rT_help_RichTextBox1 = New System.Windows.Forms.RichTextBox()
        CType(Me.openTicketsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(265, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Open Tickets :"
        '
        'dateLabel
        '
        Me.dateLabel.AutoSize = True
        Me.dateLabel.Location = New System.Drawing.Point(12, 65)
        Me.dateLabel.Name = "dateLabel"
        Me.dateLabel.Size = New System.Drawing.Size(79, 13)
        Me.dateLabel.TabIndex = 58
        Me.dateLabel.Text = "Today's Date : "
        '
        'resolutionDescription_RichTextBox
        '
        Me.resolutionDescription_RichTextBox.Location = New System.Drawing.Point(12, 118)
        Me.resolutionDescription_RichTextBox.Name = "resolutionDescription_RichTextBox"
        Me.resolutionDescription_RichTextBox.Size = New System.Drawing.Size(255, 167)
        Me.resolutionDescription_RichTextBox.TabIndex = 57
        Me.resolutionDescription_RichTextBox.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 13)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Resolution Description"
        '
        'openTicketsDataGridView
        '
        Me.openTicketsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.openTicketsDataGridView.Location = New System.Drawing.Point(283, 65)
        Me.openTicketsDataGridView.Name = "openTicketsDataGridView"
        Me.openTicketsDataGridView.Size = New System.Drawing.Size(493, 183)
        Me.openTicketsDataGridView.TabIndex = 49
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.closeButton, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.resolveProblemTicket, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(517, 259)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(259, 29)
        Me.TableLayoutPanel2.TabIndex = 48
        '
        'closeButton
        '
        Me.closeButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.closeButton.Location = New System.Drawing.Point(145, 3)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(97, 23)
        Me.closeButton.TabIndex = 1
        Me.closeButton.Text = "Close Window"
        '
        'resolveProblemTicket
        '
        Me.resolveProblemTicket.Location = New System.Drawing.Point(3, 3)
        Me.resolveProblemTicket.Name = "resolveProblemTicket"
        Me.resolveProblemTicket.Size = New System.Drawing.Size(121, 23)
        Me.resolveProblemTicket.TabIndex = 33
        Me.resolveProblemTicket.Text = "Resolve Selected Ticket"
        Me.resolveProblemTicket.UseVisualStyleBackColor = True
        '
        'problemTicketNumberToResolve
        '
        Me.problemTicketNumberToResolve.FormattingEnabled = True
        Me.problemTicketNumberToResolve.Location = New System.Drawing.Point(83, 30)
        Me.problemTicketNumberToResolve.Name = "problemTicketNumberToResolve"
        Me.problemTicketNumberToResolve.Size = New System.Drawing.Size(121, 21)
        Me.problemTicketNumberToResolve.TabIndex = 60
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 13)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Select Ticket to resolve from combo box"
        '
        'helpthisForm_Button1
        '
        Me.helpthisForm_Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.helpthisForm_Button1.Font = New System.Drawing.Font("Magneto", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.helpthisForm_Button1.ForeColor = System.Drawing.Color.Yellow
        Me.helpthisForm_Button1.Location = New System.Drawing.Point(732, 12)
        Me.helpthisForm_Button1.Name = "helpthisForm_Button1"
        Me.helpthisForm_Button1.Size = New System.Drawing.Size(27, 31)
        Me.helpthisForm_Button1.TabIndex = 62
        Me.helpthisForm_Button1.Text = "?"
        Me.helpthisForm_Button1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rT_help_RichTextBox1)
        Me.Panel1.Location = New System.Drawing.Point(61, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(687, 223)
        Me.Panel1.TabIndex = 63
        '
        'rT_help_RichTextBox1
        '
        Me.rT_help_RichTextBox1.Enabled = False
        Me.rT_help_RichTextBox1.Font = New System.Drawing.Font("Modern No. 20", 15.7!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rT_help_RichTextBox1.Location = New System.Drawing.Point(3, 3)
        Me.rT_help_RichTextBox1.Name = "rT_help_RichTextBox1"
        Me.rT_help_RichTextBox1.Size = New System.Drawing.Size(681, 215)
        Me.rT_help_RichTextBox1.TabIndex = 0
        Me.rT_help_RichTextBox1.Text = resources.GetString("rT_help_RichTextBox1.Text")
        Me.rT_help_RichTextBox1.ZoomFactor = 1.5!
        '
        'rtDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 300)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.helpthisForm_Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.problemTicketNumberToResolve)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dateLabel)
        Me.Controls.Add(Me.resolutionDescription_RichTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.openTicketsDataGridView)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "rtDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Resolve Open Ticket"
        CType(Me.openTicketsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dateLabel As System.Windows.Forms.Label
    Friend WithEvents resolutionDescription_RichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents openTicketsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents closeButton As System.Windows.Forms.Button
    Friend WithEvents resolveProblemTicket As System.Windows.Forms.Button
    Friend WithEvents problemTicketNumberToResolve As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents helpthisForm_Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rT_help_RichTextBox1 As System.Windows.Forms.RichTextBox

End Class

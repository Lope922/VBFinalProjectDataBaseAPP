<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.createTicketButton = New System.Windows.Forms.Button()
        Me.resolveProblemTicketButton = New System.Windows.Forms.Button()
        Me.viewOpenTickets = New System.Windows.Forms.Button()
        Me.addTechButton = New System.Windows.Forms.Button()
        Me.emailTech = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.helpButton = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'createTicketButton
        '
        Me.createTicketButton.Location = New System.Drawing.Point(12, 35)
        Me.createTicketButton.Name = "createTicketButton"
        Me.createTicketButton.Size = New System.Drawing.Size(148, 23)
        Me.createTicketButton.TabIndex = 0
        Me.createTicketButton.Text = "Create Problem Ticket"
        Me.createTicketButton.UseVisualStyleBackColor = True
        '
        'resolveProblemTicketButton
        '
        Me.resolveProblemTicketButton.Location = New System.Drawing.Point(12, 64)
        Me.resolveProblemTicketButton.Name = "resolveProblemTicketButton"
        Me.resolveProblemTicketButton.Size = New System.Drawing.Size(148, 23)
        Me.resolveProblemTicketButton.TabIndex = 1
        Me.resolveProblemTicketButton.Text = "Resolve Ticket"
        Me.resolveProblemTicketButton.UseVisualStyleBackColor = True
        '
        'viewOpenTickets
        '
        Me.viewOpenTickets.Location = New System.Drawing.Point(12, 93)
        Me.viewOpenTickets.Name = "viewOpenTickets"
        Me.viewOpenTickets.Size = New System.Drawing.Size(148, 23)
        Me.viewOpenTickets.TabIndex = 2
        Me.viewOpenTickets.Text = "View Open Tickets"
        Me.viewOpenTickets.UseVisualStyleBackColor = True
        '
        'addTechButton
        '
        Me.addTechButton.Location = New System.Drawing.Point(12, 122)
        Me.addTechButton.Name = "addTechButton"
        Me.addTechButton.Size = New System.Drawing.Size(148, 23)
        Me.addTechButton.TabIndex = 3
        Me.addTechButton.Text = "Add Technician"
        Me.addTechButton.UseVisualStyleBackColor = True
        '
        'emailTech
        '
        Me.emailTech.Location = New System.Drawing.Point(12, 151)
        Me.emailTech.Name = "emailTech"
        Me.emailTech.Size = New System.Drawing.Size(148, 23)
        Me.emailTech.TabIndex = 4
        Me.emailTech.Text = "send E-mail To Tech"
        Me.emailTech.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 509)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(817, 22)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'helpButton
        '
        Me.helpButton.Location = New System.Drawing.Point(631, 416)
        Me.helpButton.Name = "helpButton"
        Me.helpButton.Size = New System.Drawing.Size(75, 23)
        Me.helpButton.TabIndex = 6
        Me.helpButton.Text = "Help"
        Me.helpButton.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(39, 210)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 531)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.helpButton)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.emailTech)
        Me.Controls.Add(Me.addTechButton)
        Me.Controls.Add(Me.viewOpenTickets)
        Me.Controls.Add(Me.resolveProblemTicketButton)
        Me.Controls.Add(Me.createTicketButton)
        Me.Name = "Form1"
        Me.Text = "Ticket Manager App"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents createTicketButton As System.Windows.Forms.Button
    Friend WithEvents resolveProblemTicketButton As System.Windows.Forms.Button
    Friend WithEvents viewOpenTickets As System.Windows.Forms.Button
    Friend WithEvents addTechButton As System.Windows.Forms.Button
    Friend WithEvents emailTech As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents helpButton As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox

End Class

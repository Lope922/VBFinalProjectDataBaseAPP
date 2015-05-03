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
        Me.programhelpButton = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.testPanel1 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.openTicketsDataGridView1 = New System.Windows.Forms.DataGridView()
        Me.testPanel1.SuspendLayout()
        CType(Me.openTicketsDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.viewOpenTickets.Location = New System.Drawing.Point(12, 209)
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
        Me.StatusStrip1.BackColor = System.Drawing.Color.Gray
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 365)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(634, 22)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'programhelpButton
        '
        Me.programhelpButton.Location = New System.Drawing.Point(12, 299)
        Me.programhelpButton.Name = "programhelpButton"
        Me.programhelpButton.Size = New System.Drawing.Size(146, 23)
        Me.programhelpButton.TabIndex = 6
        Me.programhelpButton.Text = "Program Help.."
        Me.programhelpButton.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(254, 142)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 8
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(254, 212)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(203, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 24)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "User Name "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(203, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 24)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Password"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(292, 274)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Login"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'testPanel1
        '
        Me.testPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.testPanel1.Controls.Add(Me.openTicketsDataGridView1)
        Me.testPanel1.ForeColor = System.Drawing.Color.White
        Me.testPanel1.Location = New System.Drawing.Point(426, 44)
        Me.testPanel1.Name = "testPanel1"
        Me.testPanel1.Size = New System.Drawing.Size(185, 268)
        Me.testPanel1.TabIndex = 13
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel1.Location = New System.Drawing.Point(-9, 328)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(686, 13)
        Me.Panel1.TabIndex = 0
        '
        'openTicketsDataGridView1
        '
        Me.openTicketsDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.openTicketsDataGridView1.Location = New System.Drawing.Point(12, 3)
        Me.openTicketsDataGridView1.Name = "openTicketsDataGridView1"
        Me.openTicketsDataGridView1.Size = New System.Drawing.Size(160, 253)
        Me.openTicketsDataGridView1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(634, 387)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.testPanel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.programhelpButton)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.emailTech)
        Me.Controls.Add(Me.addTechButton)
        Me.Controls.Add(Me.viewOpenTickets)
        Me.Controls.Add(Me.resolveProblemTicketButton)
        Me.Controls.Add(Me.createTicketButton)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "Form1"
        Me.Text = "Ticket Manager App"
        Me.testPanel1.ResumeLayout(False)
        CType(Me.openTicketsDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents programhelpButton As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents testPanel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents openTicketsDataGridView1 As System.Windows.Forms.DataGridView

End Class

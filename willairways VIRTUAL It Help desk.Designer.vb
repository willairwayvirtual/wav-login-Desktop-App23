<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ITHELPDESK
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ITHELPDESK))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MailSubject = New System.Windows.Forms.TextBox()
        Me.Umail = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Send_Ticket = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Qry = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(228, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(568, 31)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Welcome to willairways VIRTUAL It Help desk"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(358, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(215, 39)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "create  ticket"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Silver
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(-9, -6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(197, 61)
        Me.Button2.TabIndex = 46
        Me.Button2.Text = "back menu"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'MailSubject
        '
        Me.MailSubject.BackColor = System.Drawing.SystemColors.MenuText
        Me.MailSubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MailSubject.ForeColor = System.Drawing.SystemColors.Info
        Me.MailSubject.Location = New System.Drawing.Point(260, 142)
        Me.MailSubject.Name = "MailSubject"
        Me.MailSubject.Size = New System.Drawing.Size(596, 38)
        Me.MailSubject.TabIndex = 50
        '
        'Umail
        '
        Me.Umail.BackColor = System.Drawing.SystemColors.MenuText
        Me.Umail.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Umail.ForeColor = System.Drawing.SystemColors.Info
        Me.Umail.Location = New System.Drawing.Point(260, 89)
        Me.Umail.Name = "Umail"
        Me.Umail.Size = New System.Drawing.Size(596, 38)
        Me.Umail.TabIndex = 49
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(-4, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(258, 25)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Username  Email address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(107, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 37)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "subject"
        '
        'Send_Ticket
        '
        Me.Send_Ticket.BackColor = System.Drawing.Color.Yellow
        Me.Send_Ticket.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Send_Ticket.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Send_Ticket.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Send_Ticket.Location = New System.Drawing.Point(897, 87)
        Me.Send_Ticket.Name = "Send_Ticket"
        Me.Send_Ticket.Size = New System.Drawing.Size(226, 84)
        Me.Send_Ticket.TabIndex = 53
        Me.Send_Ticket.Text = "send ticket"
        Me.Send_Ticket.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(399, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 33)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "your query"
        '
        'Qry
        '
        Me.Qry.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Qry.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Qry.ForeColor = System.Drawing.SystemColors.Info
        Me.Qry.Location = New System.Drawing.Point(1, 221)
        Me.Qry.Multiline = True
        Me.Qry.Name = "Qry"
        Me.Qry.Size = New System.Drawing.Size(1205, 450)
        Me.Qry.TabIndex = 51
        Me.Qry.Text = "your query"
        '
        'ITHELPDESK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1135, 533)
        Me.Controls.Add(Me.Send_Ticket)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Qry)
        Me.Controls.Add(Me.MailSubject)
        Me.Controls.Add(Me.Umail)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ITHELPDESK"
        Me.Text = "willairways VIRTUAL It Help desk"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents MailSubject As TextBox
    Friend WithEvents Umail As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Send_Ticket As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Qry As TextBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WASupport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WASupport))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Qry = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Send_Ticket = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Uname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Subject = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(341, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(215, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "create  ticket"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(132, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 37)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "subject"
        '
        'Qry
        '
        Me.Qry.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Qry.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Qry.ForeColor = System.Drawing.SystemColors.Info
        Me.Qry.Location = New System.Drawing.Point(0, 197)
        Me.Qry.Multiline = True
        Me.Qry.Name = "Qry"
        Me.Qry.Size = New System.Drawing.Size(1182, 419)
        Me.Qry.TabIndex = 3
        Me.Qry.Text = "your query"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(436, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 33)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "your query"
        '
        'Send_Ticket
        '
        Me.Send_Ticket.BackColor = System.Drawing.Color.Yellow
        Me.Send_Ticket.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Send_Ticket.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Send_Ticket.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Send_Ticket.Location = New System.Drawing.Point(877, 113)
        Me.Send_Ticket.Name = "Send_Ticket"
        Me.Send_Ticket.Size = New System.Drawing.Size(305, 81)
        Me.Send_Ticket.TabIndex = 5
        Me.Send_Ticket.Text = "send ticket"
        Me.Send_Ticket.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Silver
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(0, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(197, 61)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "back menu"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker1.Location = New System.Drawing.Point(877, 3)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(282, 62)
        Me.DateTimePicker1.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(90, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(173, 37)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Username "
        '
        'Uname
        '
        Me.Uname.BackColor = System.Drawing.SystemColors.MenuText
        Me.Uname.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Uname.ForeColor = System.Drawing.SystemColors.Info
        Me.Uname.Location = New System.Drawing.Point(269, 67)
        Me.Uname.Name = "Uname"
        Me.Uname.Size = New System.Drawing.Size(596, 38)
        Me.Uname.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(256, -6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(454, 31)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Welcome to willairways IT Help desk"
        '
        'Subject
        '
        Me.Subject.BackColor = System.Drawing.SystemColors.MenuText
        Me.Subject.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Subject.ForeColor = System.Drawing.SystemColors.Info
        Me.Subject.Location = New System.Drawing.Point(269, 123)
        Me.Subject.Name = "Subject"
        Me.Subject.Size = New System.Drawing.Size(596, 38)
        Me.Subject.TabIndex = 30
        '
        'WASupport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1171, 605)
        Me.Controls.Add(Me.Subject)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Uname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Send_Ticket)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Qry)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "WASupport"
        Me.Text = " Support form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Qry As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Send_Ticket As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Uname As TextBox
    Friend WithEvents Label5 As Label

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles Uname.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Friend WithEvents Subject As TextBox

    Private Sub Qry_TextChanged(sender As Object, e As EventArgs) Handles Qry.TextChanged

    End Sub

End Class

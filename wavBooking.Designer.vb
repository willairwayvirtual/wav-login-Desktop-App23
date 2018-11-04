<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WavBooking
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
        Me.FltNum = New System.Windows.Forms.TextBox()
        Me.deptime = New System.Windows.Forms.TextBox()
        Me.ArrAir = New System.Windows.Forms.TextBox()
        Me.DeptAir = New System.Windows.Forms.TextBox()
        Me.Uname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dte = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'FltNum
        '
        Me.FltNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FltNum.Location = New System.Drawing.Point(2, 57)
        Me.FltNum.Name = "FltNum"
        Me.FltNum.Size = New System.Drawing.Size(224, 35)
        Me.FltNum.TabIndex = 0
        '
        'deptime
        '
        Me.deptime.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deptime.Location = New System.Drawing.Point(2, 269)
        Me.deptime.Name = "deptime"
        Me.deptime.Size = New System.Drawing.Size(224, 35)
        Me.deptime.TabIndex = 1
        '
        'ArrAir
        '
        Me.ArrAir.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArrAir.Location = New System.Drawing.Point(2, 199)
        Me.ArrAir.Name = "ArrAir"
        Me.ArrAir.Size = New System.Drawing.Size(224, 35)
        Me.ArrAir.TabIndex = 2
        '
        'DeptAir
        '
        Me.DeptAir.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeptAir.Location = New System.Drawing.Point(2, 130)
        Me.DeptAir.Name = "DeptAir"
        Me.DeptAir.Size = New System.Drawing.Size(224, 35)
        Me.DeptAir.TabIndex = 3
        '
        'Uname
        '
        Me.Uname.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Uname.Location = New System.Drawing.Point(2, 338)
        Me.Uname.Name = "Uname"
        Me.Uname.Size = New System.Drawing.Size(224, 35)
        Me.Uname.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-3, -4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 29)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Confirm your booking"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(54, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 29)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "FltNum"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(52, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 29)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "DeptAir"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(54, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 29)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "ArrAir"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 237)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(172, 29)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Departure time"
        '
        'dte
        '
        Me.dte.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dte.Location = New System.Drawing.Point(2, 407)
        Me.dte.Name = "dte"
        Me.dte.Size = New System.Drawing.Size(224, 35)
        Me.dte.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(55, 305)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 29)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Uname"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(67, 375)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 29)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "date"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(2, 468)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(224, 46)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Confirm your booking"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(2, 510)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(224, 44)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "back to wavschedule"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(31, 445)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(165, 20)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "please use shot dates"
        '
        'WavBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(223, 556)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dte)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Uname)
        Me.Controls.Add(Me.DeptAir)
        Me.Controls.Add(Me.ArrAir)
        Me.Controls.Add(Me.deptime)
        Me.Controls.Add(Me.FltNum)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "WavBooking"
        Me.Text = "book a flght"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FltNum As TextBox
    Friend WithEvents deptime As TextBox
    Friend WithEvents ArrAir As TextBox
    Friend WithEvents DeptAir As TextBox
    Friend WithEvents Uname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dte As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label8 As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WavFlightPlan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WavFlightPlan))
        Me.Route = New System.Windows.Forms.TextBox()
        Me.FltNum = New System.Windows.Forms.TextBox()
        Me.Plan = New System.Windows.Forms.TextBox()
        Me.ArrAir = New System.Windows.Forms.TextBox()
        Me.ETA = New System.Windows.Forms.TextBox()
        Me.Gate = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.AcType = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DeptAir = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Fuel = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.PIC = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Network = New System.Windows.Forms.TextBox()
        Me.ALTAI = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Route
        '
        Me.Route.BackColor = System.Drawing.Color.Silver
        Me.Route.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Route.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Route.ForeColor = System.Drawing.Color.White
        Me.Route.Location = New System.Drawing.Point(1, 187)
        Me.Route.Multiline = True
        Me.Route.Name = "Route"
        Me.Route.Size = New System.Drawing.Size(1241, 185)
        Me.Route.TabIndex = 0
        '
        'FltNum
        '
        Me.FltNum.BackColor = System.Drawing.Color.Silver
        Me.FltNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FltNum.ForeColor = System.Drawing.Color.White
        Me.FltNum.Location = New System.Drawing.Point(1, 31)
        Me.FltNum.Name = "FltNum"
        Me.FltNum.Size = New System.Drawing.Size(133, 26)
        Me.FltNum.TabIndex = 1
        '
        'Plan
        '
        Me.Plan.BackColor = System.Drawing.Color.Silver
        Me.Plan.ForeColor = System.Drawing.Color.White
        Me.Plan.Location = New System.Drawing.Point(153, 104)
        Me.Plan.Name = "Plan"
        Me.Plan.Size = New System.Drawing.Size(171, 20)
        Me.Plan.TabIndex = 2
        '
        'ArrAir
        '
        Me.ArrAir.BackColor = System.Drawing.Color.Silver
        Me.ArrAir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArrAir.ForeColor = System.Drawing.Color.White
        Me.ArrAir.Location = New System.Drawing.Point(325, 31)
        Me.ArrAir.Name = "ArrAir"
        Me.ArrAir.Size = New System.Drawing.Size(126, 26)
        Me.ArrAir.TabIndex = 3
        '
        'ETA
        '
        Me.ETA.BackColor = System.Drawing.Color.Silver
        Me.ETA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ETA.ForeColor = System.Drawing.Color.White
        Me.ETA.Location = New System.Drawing.Point(457, 32)
        Me.ETA.Name = "ETA"
        Me.ETA.Size = New System.Drawing.Size(100, 26)
        Me.ETA.TabIndex = 4
        '
        'Gate
        '
        Me.Gate.BackColor = System.Drawing.Color.Silver
        Me.Gate.ForeColor = System.Drawing.Color.White
        Me.Gate.Location = New System.Drawing.Point(563, 32)
        Me.Gate.Name = "Gate"
        Me.Gate.Size = New System.Drawing.Size(130, 20)
        Me.Gate.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-4, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Flight Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(143, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 25)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Departure Airport"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(329, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 24)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Arrival Airport"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(473, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 25)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "ETA"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(558, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 29)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Gate/ stand"
        '
        'AcType
        '
        Me.AcType.BackColor = System.Drawing.Color.Silver
        Me.AcType.ForeColor = System.Drawing.Color.White
        Me.AcType.Location = New System.Drawing.Point(704, 31)
        Me.AcType.Name = "AcType"
        Me.AcType.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.AcType.Size = New System.Drawing.Size(127, 20)
        Me.AcType.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(699, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 25)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Type aircraft"
        '
        'DeptAir
        '
        Me.DeptAir.BackColor = System.Drawing.Color.Silver
        Me.DeptAir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeptAir.ForeColor = System.Drawing.Color.White
        Me.DeptAir.Location = New System.Drawing.Point(148, 32)
        Me.DeptAir.Name = "DeptAir"
        Me.DeptAir.Size = New System.Drawing.Size(171, 26)
        Me.DeptAir.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(185, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 25)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Plan_name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(414, 138)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(172, 31)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "ATC ROUTE"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(574, 55)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(334, 26)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "If you go from a stand or from a cargo depot, please enter S or C plus " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the numb" &
    "er in the stand box." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 76)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(125, 25)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "TRIP  FUEL"
        '
        'Fuel
        '
        Me.Fuel.BackColor = System.Drawing.Color.Silver
        Me.Fuel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Fuel.ForeColor = System.Drawing.Color.White
        Me.Fuel.Location = New System.Drawing.Point(9, 105)
        Me.Fuel.Name = "Fuel"
        Me.Fuel.Size = New System.Drawing.Size(125, 20)
        Me.Fuel.TabIndex = 18
        Me.Fuel.Text = "              "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(837, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(182, 47)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "SEND  FlightPlan  to Network Control"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(837, 138)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(177, 35)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "back menu"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker1.Location = New System.Drawing.Point(1, 141)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(372, 40)
        Me.DateTimePicker1.TabIndex = 23
        Me.DateTimePicker1.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(330, 77)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(153, 25)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Departure time"
        '
        'TextBox10
        '
        Me.TextBox10.BackColor = System.Drawing.Color.Silver
        Me.TextBox10.ForeColor = System.Drawing.Color.White
        Me.TextBox10.Location = New System.Drawing.Point(330, 104)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(153, 20)
        Me.TextBox10.TabIndex = 26
        '
        'PIC
        '
        Me.PIC.BackColor = System.Drawing.Color.Silver
        Me.PIC.ForeColor = System.Drawing.Color.White
        Me.PIC.Location = New System.Drawing.Point(489, 115)
        Me.PIC.Name = "PIC"
        Me.PIC.Size = New System.Drawing.Size(174, 20)
        Me.PIC.TabIndex = 27
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(489, 88)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(158, 24)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Pilot in Command"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(701, 89)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(107, 24)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "NETWORK"
        '
        'Network
        '
        Me.Network.BackColor = System.Drawing.Color.DarkGray
        Me.Network.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Network.ForeColor = System.Drawing.Color.White
        Me.Network.Location = New System.Drawing.Point(692, 114)
        Me.Network.Name = "Network"
        Me.Network.Size = New System.Drawing.Size(116, 20)
        Me.Network.TabIndex = 30
        '
        'ALTAI
        '
        Me.ALTAI.BackColor = System.Drawing.Color.Silver
        Me.ALTAI.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ALTAI.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALTAI.ForeColor = System.Drawing.Color.White
        Me.ALTAI.Location = New System.Drawing.Point(-1, 422)
        Me.ALTAI.Multiline = True
        Me.ALTAI.Name = "ALTAI"
        Me.ALTAI.Size = New System.Drawing.Size(1236, 213)
        Me.ALTAI.TabIndex = 31
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(440, 382)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(382, 37)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "ALTERNATE PLANNING"
        '
        'WavFlightPlan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Blue
        Me.ClientSize = New System.Drawing.Size(1234, 579)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.ALTAI)
        Me.Controls.Add(Me.Network)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.PIC)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Fuel)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DeptAir)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.AcType)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Gate)
        Me.Controls.Add(Me.ETA)
        Me.Controls.Add(Me.ArrAir)
        Me.Controls.Add(Me.Plan)
        Me.Controls.Add(Me.FltNum)
        Me.Controls.Add(Me.Route)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "WavFlightPlan"
        Me.Text = " wavFlightPlan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Route As TextBox
    Friend WithEvents FltNum As TextBox
    Friend WithEvents Plan As TextBox
    Friend WithEvents ArrAir As TextBox
    Friend WithEvents ETA As TextBox
    Friend WithEvents Gate As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents AcType As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DeptAir As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Fuel As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents PIC As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Network As TextBox
    Friend WithEvents ALTAI As TextBox
    Friend WithEvents Label14 As Label
End Class

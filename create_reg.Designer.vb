<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class create_reg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(create_reg))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.New_fname = New System.Windows.Forms.TextBox()
        Me.new_lname = New System.Windows.Forms.TextBox()
        Me.EMailAdd = New System.Windows.Forms.TextBox()
        Me.new_username = New System.Windows.Forms.TextBox()
        Me.new_password = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.FIRST = New System.Windows.Forms.Label()
        Me.last = New System.Windows.Forms.Label()
        Me.userm = New System.Windows.Forms.Label()
        Me.EMAIL = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.passwod = New System.Windows.Forms.Label()
        Me.conf_pword = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BackLogin = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(244, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(328, 42)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Create an Account"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(233, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(352, 43)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'New_fname
        '
        Me.New_fname.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.New_fname.Location = New System.Drawing.Point(233, 108)
        Me.New_fname.Name = "New_fname"
        Me.New_fname.Size = New System.Drawing.Size(294, 35)
        Me.New_fname.TabIndex = 8
        '
        'new_lname
        '
        Me.new_lname.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.new_lname.Location = New System.Drawing.Point(233, 149)
        Me.new_lname.Name = "new_lname"
        Me.new_lname.Size = New System.Drawing.Size(294, 35)
        Me.new_lname.TabIndex = 9
        '
        'EMailAdd
        '
        Me.EMailAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EMailAdd.Location = New System.Drawing.Point(233, 253)
        Me.EMailAdd.Name = "EMailAdd"
        Me.EMailAdd.Size = New System.Drawing.Size(294, 35)
        Me.EMailAdd.TabIndex = 10
        '
        'new_username
        '
        Me.new_username.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.new_username.Location = New System.Drawing.Point(233, 198)
        Me.new_username.Name = "new_username"
        Me.new_username.Size = New System.Drawing.Size(294, 35)
        Me.new_username.TabIndex = 11
        '
        'new_password
        '
        Me.new_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.new_password.Location = New System.Drawing.Point(233, 315)
        Me.new_password.MaxLength = 10
        Me.new_password.Name = "new_password"
        Me.new_password.Size = New System.Drawing.Size(294, 35)
        Me.new_password.TabIndex = 13
        '
        'TextBox7
        '
        Me.TextBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(233, 385)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox7.Size = New System.Drawing.Size(294, 35)
        Me.TextBox7.TabIndex = 14
        '
        'FIRST
        '
        Me.FIRST.AutoSize = True
        Me.FIRST.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FIRST.Location = New System.Drawing.Point(50, 108)
        Me.FIRST.Name = "FIRST"
        Me.FIRST.Size = New System.Drawing.Size(116, 25)
        Me.FIRST.TabIndex = 15
        Me.FIRST.Text = "First Name"
        '
        'last
        '
        Me.last.AutoSize = True
        Me.last.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.last.Location = New System.Drawing.Point(50, 149)
        Me.last.Name = "last"
        Me.last.Size = New System.Drawing.Size(115, 25)
        Me.last.TabIndex = 16
        Me.last.Text = "Last Name"
        '
        'userm
        '
        Me.userm.AutoSize = True
        Me.userm.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userm.Location = New System.Drawing.Point(41, 198)
        Me.userm.Name = "userm"
        Me.userm.Size = New System.Drawing.Size(110, 25)
        Me.userm.TabIndex = 17
        Me.userm.Text = "Username"
        '
        'EMAIL
        '
        Me.EMAIL.AutoSize = True
        Me.EMAIL.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EMAIL.Location = New System.Drawing.Point(41, 253)
        Me.EMAIL.Name = "EMAIL"
        Me.EMAIL.Size = New System.Drawing.Size(148, 25)
        Me.EMAIL.TabIndex = 18
        Me.EMAIL.Text = "Email address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(541, 315)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(273, 29)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Minimum of 4 characters"
        '
        'passwod
        '
        Me.passwod.AutoSize = True
        Me.passwod.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwod.Location = New System.Drawing.Point(40, 315)
        Me.passwod.Name = "passwod"
        Me.passwod.Size = New System.Drawing.Size(106, 25)
        Me.passwod.TabIndex = 21
        Me.passwod.Text = "Password"
        '
        'conf_pword
        '
        Me.conf_pword.AutoSize = True
        Me.conf_pword.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.conf_pword.Location = New System.Drawing.Point(40, 374)
        Me.conf_pword.Name = "conf_pword"
        Me.conf_pword.Size = New System.Drawing.Size(186, 25)
        Me.conf_pword.TabIndex = 22
        Me.conf_pword.Text = "Confirm Password"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Yellow
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(203, 436)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(369, 50)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "sign up in to willairways Virtual"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BackLogin
        '
        Me.BackLogin.BackColor = System.Drawing.Color.Black
        Me.BackLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackLogin.ForeColor = System.Drawing.Color.White
        Me.BackLogin.Location = New System.Drawing.Point(203, 492)
        Me.BackLogin.Name = "BackLogin"
        Me.BackLogin.Size = New System.Drawing.Size(382, 45)
        Me.BackLogin.TabIndex = 28
        Me.BackLogin.Text = "back to the login screen"
        Me.BackLogin.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker1.Location = New System.Drawing.Point(591, 2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(235, 44)
        Me.DateTimePicker1.TabIndex = 30
        '
        'create_reg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(826, 561)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.BackLogin)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.conf_pword)
        Me.Controls.Add(Me.passwod)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.EMAIL)
        Me.Controls.Add(Me.userm)
        Me.Controls.Add(Me.last)
        Me.Controls.Add(Me.FIRST)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.new_password)
        Me.Controls.Add(Me.new_username)
        Me.Controls.Add(Me.EMailAdd)
        Me.Controls.Add(Me.new_lname)
        Me.Controls.Add(Me.New_fname)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "create_reg"
        Me.Text = "sign up in to willairwys Virtual"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents New_fname As TextBox
    Friend WithEvents new_lname As TextBox
    Friend WithEvents EMailAdd As TextBox
    Friend WithEvents new_username As TextBox
    Friend WithEvents new_password As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents FIRST As Label
    Friend WithEvents last As Label
    Friend WithEvents userm As Label
    Friend WithEvents EMAIL As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents passwod As Label
    Friend WithEvents conf_pword As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents BackLogin As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class

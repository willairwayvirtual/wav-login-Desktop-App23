<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class wav_new_login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(wav_new_login))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.login = New System.Windows.Forms.TabPage()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.conf_pword = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.new_password = New System.Windows.Forms.TextBox()
        Me.passwod = New System.Windows.Forms.Label()
        Me.EMailAdd = New System.Windows.Forms.TextBox()
        Me.EMAIL = New System.Windows.Forms.Label()
        Me.new_username = New System.Windows.Forms.TextBox()
        Me.userm = New System.Windows.Forms.Label()
        Me.new_lname = New System.Windows.Forms.TextBox()
        Me.last = New System.Windows.Forms.Label()
        Me.New_fname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FIRST = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.USName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.login.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.login)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(1, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(472, 525)
        Me.TabControl1.TabIndex = 0
        '
        'login
        '
        Me.login.BackColor = System.Drawing.Color.Gray
        Me.login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.login.Controls.Add(Me.CheckBox1)
        Me.login.Controls.Add(Me.Button2)
        Me.login.Controls.Add(Me.txtUsername)
        Me.login.Controls.Add(Me.PictureBox1)
        Me.login.Controls.Add(Me.Label3)
        Me.login.Controls.Add(Me.txtPassword)
        Me.login.Controls.Add(Me.Label2)
        Me.login.Controls.Add(Me.Label1)
        Me.login.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login.Location = New System.Drawing.Point(4, 22)
        Me.login.Name = "login"
        Me.login.Padding = New System.Windows.Forms.Padding(3)
        Me.login.Size = New System.Drawing.Size(464, 499)
        Me.login.TabIndex = 0
        Me.login.Text = "login"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(100, 277)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(228, 37)
        Me.CheckBox1.TabIndex = 13
        Me.CheckBox1.Text = "Remember me"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(-25, 332)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(499, 130)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "login"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(58, 166)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(251, 35)
        Me.txtUsername.TabIndex = 11
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(-5, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(370, 90)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(114, 204)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 29)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Password "
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.White
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.Black
        Me.txtPassword.Location = New System.Drawing.Point(58, 236)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(262, 35)
        Me.txtPassword.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(129, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 29)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-4, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(273, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = " Welcome to Willairways Virtual please enter" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " you username and password or regis" &
    "ter your user details"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Gray
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.TextBox1)
        Me.TabPage2.Controls.Add(Me.conf_pword)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.new_password)
        Me.TabPage2.Controls.Add(Me.passwod)
        Me.TabPage2.Controls.Add(Me.EMailAdd)
        Me.TabPage2.Controls.Add(Me.EMAIL)
        Me.TabPage2.Controls.Add(Me.new_username)
        Me.TabPage2.Controls.Add(Me.userm)
        Me.TabPage2.Controls.Add(Me.new_lname)
        Me.TabPage2.Controls.Add(Me.last)
        Me.TabPage2.Controls.Add(Me.New_fname)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.FIRST)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(464, 499)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Create an Account"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Yellow
        Me.Button1.Location = New System.Drawing.Point(-4, 434)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(472, 33)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "sign up in to willairways Virtual"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(31, 396)
        Me.TextBox1.MaxLength = 10
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox1.Size = New System.Drawing.Size(294, 35)
        Me.TextBox1.TabIndex = 29
        '
        'conf_pword
        '
        Me.conf_pword.AutoSize = True
        Me.conf_pword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.conf_pword.Location = New System.Drawing.Point(98, 375)
        Me.conf_pword.Name = "conf_pword"
        Me.conf_pword.Size = New System.Drawing.Size(132, 18)
        Me.conf_pword.TabIndex = 28
        Me.conf_pword.Text = "Confirm Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(256, 318)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 16)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Minimum of 4 characters"
        '
        'new_password
        '
        Me.new_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.new_password.Location = New System.Drawing.Point(31, 337)
        Me.new_password.MaxLength = 10
        Me.new_password.Name = "new_password"
        Me.new_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.new_password.Size = New System.Drawing.Size(294, 35)
        Me.new_password.TabIndex = 26
        '
        'passwod
        '
        Me.passwod.AutoSize = True
        Me.passwod.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwod.Location = New System.Drawing.Point(111, 309)
        Me.passwod.Name = "passwod"
        Me.passwod.Size = New System.Drawing.Size(106, 25)
        Me.passwod.TabIndex = 25
        Me.passwod.Text = "Password"
        '
        'EMailAdd
        '
        Me.EMailAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EMailAdd.Location = New System.Drawing.Point(32, 271)
        Me.EMailAdd.Name = "EMailAdd"
        Me.EMailAdd.Size = New System.Drawing.Size(294, 35)
        Me.EMailAdd.TabIndex = 24
        '
        'EMAIL
        '
        Me.EMAIL.AutoSize = True
        Me.EMAIL.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EMAIL.Location = New System.Drawing.Point(96, 243)
        Me.EMAIL.Name = "EMAIL"
        Me.EMAIL.Size = New System.Drawing.Size(148, 25)
        Me.EMAIL.TabIndex = 23
        Me.EMAIL.Text = "Email address"
        '
        'new_username
        '
        Me.new_username.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.new_username.Location = New System.Drawing.Point(32, 205)
        Me.new_username.Name = "new_username"
        Me.new_username.Size = New System.Drawing.Size(294, 35)
        Me.new_username.TabIndex = 22
        '
        'userm
        '
        Me.userm.AutoSize = True
        Me.userm.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userm.Location = New System.Drawing.Point(117, 177)
        Me.userm.Name = "userm"
        Me.userm.Size = New System.Drawing.Size(110, 25)
        Me.userm.TabIndex = 21
        Me.userm.Text = "Username"
        '
        'new_lname
        '
        Me.new_lname.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.new_lname.Location = New System.Drawing.Point(32, 139)
        Me.new_lname.Name = "new_lname"
        Me.new_lname.Size = New System.Drawing.Size(294, 35)
        Me.new_lname.TabIndex = 20
        '
        'last
        '
        Me.last.AutoSize = True
        Me.last.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.last.Location = New System.Drawing.Point(117, 111)
        Me.last.Name = "last"
        Me.last.Size = New System.Drawing.Size(115, 25)
        Me.last.TabIndex = 19
        Me.last.Text = "Last Name"
        '
        'New_fname
        '
        Me.New_fname.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.New_fname.Location = New System.Drawing.Point(32, 73)
        Me.New_fname.Name = "New_fname"
        Me.New_fname.Size = New System.Drawing.Size(294, 35)
        Me.New_fname.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(328, 42)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Create an Account"
        '
        'FIRST
        '
        Me.FIRST.AutoSize = True
        Me.FIRST.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FIRST.Location = New System.Drawing.Point(111, 45)
        Me.FIRST.Name = "FIRST"
        Me.FIRST.Size = New System.Drawing.Size(116, 25)
        Me.FIRST.TabIndex = 16
        Me.FIRST.Text = "First Name"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.Gray
        Me.TabPage3.Controls.Add(Me.Button3)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.TextBox3)
        Me.TabPage3.Controls.Add(Me.TextBox2)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.USName)
        Me.TabPage3.Controls.Add(Me.Label7)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(464, 499)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = " Reset Password "
        '
        'Button3
        '
        Me.Button3.ForeColor = System.Drawing.Color.Red
        Me.Button3.Location = New System.Drawing.Point(0, 331)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(468, 60)
        Me.Button3.TabIndex = 34
        Me.Button3.Text = "Update Password "
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(40, 240)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(220, 25)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Confirm New Password "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(53, 220)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(182, 20)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Minimum of 4 characters"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(32, 268)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox3.Size = New System.Drawing.Size(250, 40)
        Me.TextBox3.TabIndex = 10
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(32, 177)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox2.Size = New System.Drawing.Size(250, 40)
        Me.TextBox2.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(88, 149)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(147, 25)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "New Password "
        '
        'USName
        '
        Me.USName.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.USName.Location = New System.Drawing.Point(32, 94)
        Me.USName.Name = "USName"
        Me.USName.Size = New System.Drawing.Size(250, 40)
        Me.USName.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(89, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 25)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "User Name"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(311, 42)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = " Reset Password "
        '
        'wav_new_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(469, 509)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "wav_new_login"
        Me.Text = "wav login"
        Me.TabControl1.ResumeLayout(False)
        Me.login.ResumeLayout(False)
        Me.login.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents login As TabPage
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents conf_pword As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents new_password As TextBox
    Friend WithEvents passwod As Label
    Friend WithEvents EMailAdd As TextBox
    Friend WithEvents EMAIL As Label
    Friend WithEvents new_username As TextBox
    Friend WithEvents userm As Label
    Friend WithEvents new_lname As TextBox
    Friend WithEvents last As Label
    Friend WithEvents New_fname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents FIRST As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents USName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents CheckBox1 As CheckBox
End Class

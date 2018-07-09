Imports System.Data.OleDb
Public Class create_reg
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim conn As OleDbConnection = New OleDbConnection

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        'Change the following to your access database location
        dataFile = "C:\VisStudioProj\wav login Desktop App23\wav login Desktop App23\BIN\DEBUG\logindb.accdb"
        connString = provider & dataFile
        conn.ConnectionString = connString

        'check status of connection string
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        Else
            conn.Close()
        End If

        'check password status and continue to create new user
        If new_password.Text.Length < 4 Then
            MsgBox("Miminum Password Length is 4 Characters")
        Else
            'add new records
            Dim savenew As String = "INSERT INTO [tblaccessinfo]  (Uname,Pword,Fname,Lname,EMailAdd) values('" &
        new_username.Text & "','" &
        new_password.Text & "','" &
        New_fname.Text & "','" &
        new_lname.Text & "','" &
        EMailAdd.Text & "');"

            Dim cmd As New OleDbCommand

            With cmd
                .CommandText = savenew
                .Connection = conn
                .ExecuteNonQuery()
            End With
            MessageBox.Show("Welcome on board ")

            conn.Close()
        End If
    End Sub

    Private Sub BackLogin_Click(sender As Object, e As EventArgs) Handles BackLogin.Click
        Me.Close()
        main_login.Show()
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        If TextBox7.Text = new_password.Text Then
            conf_pword.ForeColor = Color.Green
        Else
            conf_pword.ForeColor = Color.Red
        End If
    End Sub

    Private Sub conf_Click(sender As Object, e As EventArgs) Handles conf_pword.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles EMailAdd.TextChanged

    End Sub
End Class

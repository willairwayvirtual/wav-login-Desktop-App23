Imports System.Data.OleDb
Public Class ResetPword
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim conn As OleDbConnection = New OleDbConnection
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        'Change the following to your access database location
        dataFile = "C:\VisStudioProj\wav login Desktop App23\wav login Desktop App23\BIN\DEBUG\willairwayvirtualDatabase.accdb"
        connString = provider & dataFile
        conn.ConnectionString = connString

        'check status of connection string
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        Else
            conn.Close()
        End If

        'check password status and continue to create new user
        If CNewPword.Text.Length < 4 Then
            MsgBox("Miminum Password Length is 4 Characters")
        Else
            'update records
            Dim savenew As String = "Update  [tblaccessinfo] set [Pword] ='" & CNewPword.Text & "' where [Uname] = '" & USName.Text & "';"


            Dim cmd As New OleDbCommand

            With cmd
                .CommandText = savenew
                .Connection = conn
                .ExecuteNonQuery()
            End With
            MessageBox.Show("Password Updated")

            conn.Close()
        End If
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        main_login.Show()
        Me.Close()
    End Sub
End Class

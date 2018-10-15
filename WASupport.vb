Imports System.Data.OleDb
Public Class WASupport
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim conn As OleDbConnection = New OleDbConnection

    Private Sub Send_ticket_click(sender As Object, e As EventArgs) Handles Send_Ticket.Click
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        'Change the following to your access database location
        dataFile = "C:\VisStudioProj\wav login Desktop App23\wav login Desktop App23\BIN\DEBUG\willairwayvirtualDBv1.accdb"
        connString = provider & dataFile
        conn.ConnectionString = connString

        'check status of connection string
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        Else
            conn.Close()
        End If

        'add new records
        Dim savenew As String = "INSERT INTO [Support]  (Uname,subject,Qry) values('" &
        Uname.Text & "','" &
        Subject.Text & "','" &
        Qry.Text & "');"

        Dim cmd As New OleDbCommand

        With cmd
            .CommandText = savenew
            .Connection = conn
            .ExecuteNonQuery()
        End With
        MessageBox.Show("Query Filed - you will a response between 24 and 48 hours")

        conn.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Close()


    End Sub
End Class

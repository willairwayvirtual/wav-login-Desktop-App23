Imports System.Data.OleDb
Public Class WASupport
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim conn As OleDbConnection = New OleDbConnection

    Private Sub Send_ticket_click(sender As Object, e As EventArgs) Handles Send_Ticket.Click
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

        'add new records
        Dim savenew As String = "INSERT INTO [Support_form]  (Uname,Subject,Qry) values('" &
        Uname.Text & "','" &
        Subject.Text & "','" &
        Qry.Text & "');"

        Dim cmd As New OleDbCommand

        With cmd
            .CommandText = savenew
            .Connection = conn
            .ExecuteNonQuery()
        End With
        MessageBox.Show("Query Filed")

        conn.Close()

    End Sub
End Class

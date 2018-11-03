Imports System.Data.OleDb
Public Class WavBooking
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim conn As OleDbConnection = New OleDbConnection

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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
        Dim savenew As String = "INSERT INTO [bookaflght]  (FltNum,DepTair,ArrAir,deptime,Uname,dte) values('" &
            FltNum.Text & "','" &
            DeptAir.Text & "','" &
            ArrAir.Text & "','" &
           deptime.Text & "','" &
            Uname.Text & "','" &
            dte.Text & "');"


        Dim cmd As New OleDbCommand

        With cmd
            .CommandText = savenew
            .Connection = conn
            .ExecuteNonQuery()
        End With
        MessageBox.Show(" Flight confirmed ")

        conn.Close()


    End Sub
End Class

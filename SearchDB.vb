Imports System.Data.OleDb
Public Class SearchDB
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim conn As OleDbConnection = New OleDbConnection


    Private Sub Buttonsc_Click(sender As Object, e As EventArgs) Handles Buttonsc.Click
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

        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        da = New OleDbDataAdapter("Select * from flightplan where fltnum Like '%" & TextBox1.Text & "%'", conn)
        da.Fill(dt)

        DataGridView1.DataSource = dt.DefaultView
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Close()

    End Sub
End Class

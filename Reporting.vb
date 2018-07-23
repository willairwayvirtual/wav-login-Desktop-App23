Imports System.Data.OleDb
Public Class Reporting

    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim conn As OleDbConnection = New OleDbConnection

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
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

        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        da = New OleDbDataAdapter("Select * from reporting_flt_deck where uname Like '%" & utextBox1.Text & "%'", conn)
        da.Fill(dt)

        DataGridView1.DataSource = dt.DefaultView
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Form1.Show()
        Me.Close()


    End Sub
End Class

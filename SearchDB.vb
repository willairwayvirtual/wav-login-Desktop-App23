Imports System.Data.OleDb
Public Class SearchDB
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim conn As OleDbConnection = New OleDbConnection

    Private Sub Buttonsc_Click(sender As Object, e As EventArgs) Handles Buttonsc.Click
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        'Change the following to your access database location
        dataFile = "C:\VisStudioProj\wav web\willairwayvirtual34\willairwayvirtual34\app_data\willairwayvirtualDBv1.accdb"
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

        'da = New OleDbDataAdapter("Select * from flightplan where fltnum Like '%" & TextBox1.Text & "%'", conn)
        da = New OleDbDataAdapter("Select * from flightplan WHERE [fltnum] = '" & TextBox1.Text & "' or [Deptair] = '" & TextBox3.Text & "' Or [Arrair] = '" & TextBox6.Text & "'", conn)
        da.Fill(dt)

        DataGridView1.DataSource = dt.DefaultView
        conn.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub
End Class

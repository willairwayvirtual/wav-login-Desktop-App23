Imports System.Data.OleDb
Public Class Reporting

    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim conn As OleDbConnection = New OleDbConnection

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
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

        da = New OleDbDataAdapter("Select * from repfltdeck where [uname] = '" & utextBox1.Text & "' or [lastname] = '" & TextBox1.Text & "' Or [reportingtime] = '" & TextBox2.Text & "' Or [flightnumber] = '" & TextBox3.Text & "'", conn)

        da.Fill(dt)


        DataGridView1.DataSource = dt.DefaultView
        conn.Close()
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Close()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.Show()
        Me.Close()


    End Sub

    Private Sub utextBox1_TextChanged(sender As Object, e As EventArgs) Handles utextBox1.TextChanged

    End Sub

    Private Sub label4_Click(sender As Object, e As EventArgs) Handles label4.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
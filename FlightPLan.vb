Imports System.Data.OleDb
Public Class WavFlightPlan
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim conn As OleDbConnection = New OleDbConnection

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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
        Dim savenew As String = "INSERT INTO [flightplan]  (FltNum,DepTair,ArrAir,ETA,Gate,AcType,Plan,Route,Fuel,PIC,network) values('" &
        FltNum.Text & "','" &
        DeptAir.Text & "','" &
        ArrAir.Text & "','" &
        ETA.Text & "','" &
        Gate.Text & "','" &
       AcType.Text & "','" &
       Plan.Text & "','" &
       Route.Text & "','" &
       Fuel.Text & "','" &
       Network.Text & "','" &
       PIC.Text & "');"



        Dim cmd As New OleDbCommand

        With cmd
            .CommandText = savenew
            .Connection = conn
            .ExecuteNonQuery()
        End With
        MessageBox.Show("Plan Loaded Have a good flight")

        conn.Close()

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles ETA.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub FltNum_TextChanged(sender As Object, e As EventArgs) Handles FltNum.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Close()


    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub
End Class

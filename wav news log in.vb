﻿Imports System.Data.OleDb
Public Class wav_new_login
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection
    Dim conn As OleDbConnection = New OleDbConnection


    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        myConnection.Close()
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        'Change the following to your access database location
        dataFile = "C:\VisStudioProj\wav web\willairwayvirtual34\willairwayvirtual34\app_data\willairwayvirtualDBv1.accdb"
        connString = provider & dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()
        'the query:
        Dim cmd As OleDbCommand = New OleDbCommand("Select * FROM [tblaccessinfo] WHERE [Uname] = '" & txtUsername.Text & "' AND [Pword] = '" & txtPassword.Text & "'", myConnection)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        ' the following variable is hold true if user is found, and false if user is not found 
        Dim userFound As Boolean = False
        ' the following variables will hold the user first and last name if found.
        Dim FirstName As String = ""
        Dim LastName As String = ""
        Dim Status As String = ""
        Dim totalHours As String = ""
        Dim lastflight As String = ""

        'if found:
        While dr.Read
            userFound = True
            FirstName = dr("FName").ToString
            LastName = dr("LName").ToString
            Status = dr("status").ToString
            totalHours = dr("TotalHours").ToString
            lastflight = dr("lastflight").ToString


        End While

        'checking the result
        If userFound = True Then

            Dim obj As New Form2
            obj.stringtext1 = "Hi " & txtUsername.Text & " " & Status & " Member " & "Total Flying Time " & totalHours &
                " Hours Last flight " & lastflight
            obj.Show()
            Me.Close()
        Else
            MsgBox("YOU DONT EXIST", MsgBoxStyle.OkOnly, "YOU DONT EXIST")
        End If
        myConnection.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        create_reg.Show()
        Me.Close()


    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
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

        'check password status and continue to create new user
        If TextBox2.Text.Length < 4 Then
            MsgBox("Miminum Password Length is 4 Characters")
        Else
            'update records
            Dim savenew As String = "Update  [tblaccessinfo] set [Pword] ='" & TextBox3.Text & "' where [Uname] = '" & USName.Text & "';"


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

    Private Sub Button33_ContextMenuChanged(sender As Object, e As EventArgs) Handles Button33.ContextMenuChanged

    End Sub
End Class
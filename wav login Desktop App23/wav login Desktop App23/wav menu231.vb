﻿Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Reporting.Show()
        Me.Close()


    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        WASupport.Show()
        Me.Close()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        WavFlightPlan.Show()
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SearchDB.Show()
        Me.Close()


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        main_login.Show()
        Me.Close()


    End Sub

    Private Sub Button63_Click(sender As Object, e As EventArgs) Handles Button63.Click
        Form132.Show()
        Me.Close()


    End Sub
End Class

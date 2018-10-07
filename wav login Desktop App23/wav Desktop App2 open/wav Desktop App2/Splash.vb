Public Class Splash
    Private Sub Button1cli_Click(sender As Object, e As EventArgs)
        Timer1.Start()
        Enabled = False



    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            If ProgressBar1.Value = 100 Then

            End If



            Timer1.Stop()

        End If
        Label1.Text = ProgressBar1.Value & (" %")
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class

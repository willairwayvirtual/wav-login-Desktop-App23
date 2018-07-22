Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Reporting.Show()
        Me.Close()


    End Sub

    Private Sub Button4_ClientSizeChanged(sender As Object, e As EventArgs) Handles Button4.ClientSizeChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        WASupport.Show()
        Me.Close()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        WavFlightPlan.Show()
        Me.Close()

    End Sub
End Class

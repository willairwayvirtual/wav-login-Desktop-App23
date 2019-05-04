Public Class Form2
    Public Property stringtext1 As String

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = stringtext1
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        loading.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        connect.Show()
        Me.Close()




    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        wav_new_login.Show()
        Me.Close()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim obj As New wavschedule
        obj.stringtext2 = stringtext1
        obj.Show()
        Me.Close()






    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Reporting.Show()
        Me.Close()


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ITHELPDESK.Show()
        Me.Close()


    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        wav12.Show()
        Me.Close()

    End Sub
End Class
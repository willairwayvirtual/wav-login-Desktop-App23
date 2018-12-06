
Imports System.Net.Mail
Public Class ITHELPDESK
    Private Sub Send_ticket_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Send_Ticket.Click
        Dim mail As New MailMessage
        mail.Subject = MailSubject.Text
        mail.To.Add("wavithelpdesk@hotmail.com")
        mail.From = New MailAddress(Umail.Text)
        mail.Body = Qry.Text

        Dim smtp As New SmtpClient("smtp-mail.outlook.com")
        smtp.EnableSsl = True
        smtp.Credentials = New System.Net.NetworkCredential("willjones97@hotmail.com", "spongebob")
        smtp.Port = "587"
        smtp.Send(mail)
        MsgBox("Ticket sent by email")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Uname_TextChanged(sender As Object, e As EventArgs) Handles Umail.TextChanged

    End Sub

    Private Sub Subject_TextChanged(sender As Object, e As EventArgs) Handles MailSubject.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Close()


    End Sub
End Class

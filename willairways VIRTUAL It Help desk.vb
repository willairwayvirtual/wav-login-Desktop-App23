﻿
Imports System.Net.Mail
Public Class ITHELPDESK
    Private Sub Send_ticket_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Send_Ticket.Click
        Dim mail As New MailMessage
        mail.Subject = MailSubject.Text
        ' mail.To.Add("Wavuserhelpdesk@hotmail.com")
        mail.To.Add("Wavuserhelpdesk@hotmail.com")
        mail.From = New MailAddress("Wavuserhelpdesk@hotmail.com")
        mail.Body = "From: " & (Umail.Text) & " Query Text: " & Qry.Text

        Dim smtp As New SmtpClient("smtp-mail.outlook.com")
        'Dim smtp As New SmtpClient("smtp.live.com")
        smtp.EnableSsl = True
        smtp.Credentials = New System.Net.NetworkCredential("Wavuserhelpdesk@hotmail.com", "Spongebob97")
        smtp.Port = "587"
        'smtp.Port = "25"
        smtp.Send(mail)
        MsgBox("Thank you for your enquiry.  We will review and aim to respond within 24 hours.
 
     Thanks
 
    WAV Development and Support Team
      ")
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

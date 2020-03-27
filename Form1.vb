Imports System.Net.Mail
Public Class Form1
    Dim Mail As New MailMessage
    Dim smtp As New SmtpClient
    Dim numInicial As Integer = 1
    Dim numFinal As Integer = 1

    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If EmailAccount.Text = "" Then
            MsgBox("¡Hey! Por favor, ingrese su correo Gmail", MsgBoxStyle.Exclamation, "¡Correo incorrecto!")
        Else
            Try
                Mail.From = New MailAddress(EmailAccount.Text, MyName.Text)
                Mail.To.Add(DestinataryEmail.Text)
                Mail.Subject = (SubjectMail.Text)
                Mail.Body = (BodyMail.Text)
                Dim s As New SmtpClient("Smtp.gmail.com")
                s.Port = 587
                s.EnableSsl = True
                s.Credentials = New System.Net.NetworkCredential(EmailAccount.Text, PasswordText.Text)
                numFinal = NumberOfMails.Text
                For i = numInicial To numFinal
                    s.Send(Mail)
                Next i
                MsgBox("¡Genial! El mensaje ha sido enviado correctamente", MsgBoxStyle.Information)
            Catch ex As Exception
            End Try
            If MyName.Text = "" Then
                MsgBox("¡Hey! Por favor, ingrese un nombre", MsgBoxStyle.Exclamation, "¡No hay nombre!")
            End If
            If PasswordText.Text = "" Then
                MsgBox("¡Hey! Por favor, ingrese la contraseña", MsgBoxStyle.Exclamation, "¡No hay contraseña!")
            End If
            If DestinataryEmail.Text = "" Then
                MsgBox("¡Hey! Por favor, ingrese el correo", MsgBoxStyle.Exclamation, "¡No hay correo!")
            End If
            If BodyMail.Text = "" Then
                MsgBox("¡Hey! Por favor, ingrese el texto", MsgBoxStyle.Exclamation, "¿Y el cuerpo?")
            End If
        End If

    End Sub
End Class

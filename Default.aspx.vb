Imports System.Net.Mail
Public Class _Default
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If IsPostBack Then
            LabelErr.Text = "Λάθος όνομα χρήστη ή κωδικού πρόσβασης"
            If name.Value <> "" AndAlso email.Value <> "" AndAlso comments.Value <> "" Then
                Dim ok As Boolean = True
                If name.Value.Trim = "" Then
                    contactMsg.InnerText = "Πρέπει να συμπληρωθεί το ονοματεπώνυμο!"
                    contactMsg.Attributes("style") = "color:white;display:"
                    ok = False
                End If
                If email.Value.Trim = "" Then
                    contactMsg.InnerText = "Πρέπει να συμπληρωθεί το email σας!"
                    contactMsg.Attributes("style") = "color:white;display:"
                    ok = False
                End If
                If comments.Value.Trim = "" Then
                    contactMsg.InnerText = "Πρέπει να συμπληρώσετε το μήνυμα!"
                    contactMsg.Attributes("style") = "color:white;display:"
                    ok = False
                End If
                If ok Then
                    Try
                        Dim message As New MailMessage("dimoskopisi@hc-crete.gr", "informatics@hc-crete.gr", "Νέο μήνυμα δημοσκόπησης από τον/την " & name.Value, "Ονοματεπώνυμο αποστολέα: " & name.Value & vbCrLf & "email αποστολέα: " & email.Value & vbCrLf & comments.Value)
                        Dim smtpClient As New SmtpClient("mailgate.0491.syzefxis.gov.gr")
                        smtpClient.UseDefaultCredentials = True
                        smtpClient.Send(message)
                        contactMsg.InnerText = "Το μήνυμα έφυγε!! Σας ευχαριστούμε..."
                        contactMsg.Attributes("style") = "color:white;display:"
                        LabelErr.Text = "Το μήνυμα έφυγε!! Σας ευχαριστούμε..."
                        LabelErr.Visible = True
                        comments.Value = ""
                        name.Value = ""
                        email.Value = ""
                    Catch ex As Exception
                        contactMsg.InnerText = ex.ToString
                        contactMsg.Attributes("style") = "color:white;display:"
                    End Try
                End If
            Else
                contactMsg.Attributes("style") = "color:white;display:none"
            End If
            If inputUserName.Value <> "" AndAlso inputPassword.Value <> "" Then
                Dim localData As New localDBconnection
                Dim dt As DataTable = localData.getData("SELECT [users].[UserName], [users].[ID_DIM], [ΔΗΜΟΣΚΟΠΙΣΕΙΣ].[ΠΕΡΙΓΡΑΦΗ], [users].[powerUser] FROM [ΔΗΜΟΣΚΟΠΙΣΕΙΣ] inner join [users] ON [ΔΗΜΟΣΚΟΠΙΣΕΙΣ].ID_DIM= [users].[ID_DIM] WHERE [UserName]='" & inputUserName.Value.Replace("'", "") & "' AND [Password]='" & inputPassword.Value.Replace("'", "") & "'")
                If dt.Rows.Count = 1 Then
                    localData.updateData("INSERT INTO [LOGS] ([ΠΕΡΙΓΡΑΦΗ]) VALUES ('Ο χρήστης " & inputUserName.Value & " έκανε είσοδο στη πλατφόρμα με IP: " & HttpContext.Current.Request.UserHostAddress & "')")
                    LabelErr.Visible = False
                    localData.TerminateLocalDBConnection()
                    Session("user") = dt.Rows(0).Item(0)
                    Session("dimoskopisiID") = dt.Rows(0).Item(1)
                    Session("dimoskopisiName") = dt.Rows(0).Item(2)
                    Session("powerUser") = dt.Rows(0).Item(3)

                    Response.Redirect("~/nosokomeia.aspx")
                Else
                    LabelErr.Visible = True
                    localData.updateData("insert into [LOGS] ([ΠΕΡΙΓΡΑΦΗ]) VALUES ('Αποτυχημένη προσπάθεια πρόσβασης με τα κάθωτι στοιχεία: username: " & inputUserName.Value.Replace("'", "") & " και password: " & inputPassword.Value.Replace("'", "") & " με IP: " & HttpContext.Current.Request.UserHostAddress & " ')")
                End If
                localData.TerminateLocalDBConnection()
            Else
                LabelErr.Visible = False
            End If
        End If
    End Sub
End Class
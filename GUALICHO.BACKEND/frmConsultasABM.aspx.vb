Imports GUALICHO.AD
Imports System.Net.Mail
Imports System.IO

Public Class frmConsultasABM
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack = False Then
            CargarMenuRoles()
            CargarConsulta()
            Status()

        End If
    End Sub
#Region "ROLES"
    Private Sub CargarMenuRoles()
        If User.Identity.IsAuthenticated = True Then

            If User.IsInRole("ADMINISTRADOR") Then

                lblUsuario.Text = "ADMINISTRADOR"

                Men_QuienesSomos.Visible = True
                Men_Nosotros.Visible = True
                Men_Servicios.Visible = True
                Men_Banners.Visible = True
                Men_Sponsors.Visible = True

                men_Marcas.Visible = True
                men_Rubros.Visible = True
                men_SubRubros.Visible = True
                Men_Item.Visible = True

                Men_ItemImagen.Visible = True
                men_Consultas.Visible = True
                men_Contacto.Visible = True



            End If


            men_CambiarPass.Visible = True
            men_CerrarSesion.Visible = True
        Else
            Response.Redirect("frmLogin.aspx")
        End If
    End Sub
#End Region

#Region "LOGIN"
    Protected Sub CerrarSesion(sender As Object, e As EventArgs)
        FormsAuthentication.SignOut()
        Roles.DeleteCookie()
        Session.Clear()
        Response.Redirect("frmlogin.aspx")
    End Sub
#End Region


#Region "Consultas"

    Private Sub CargarConsulta()
        Dim ID As Integer = Request.QueryString("ID")
        Dim ods As New DataSet
        Dim oObjeto As New Consultas
        ods = oObjeto.BuscarPorID(ID)

        'RepeaterPedidos.DataSource = ods.Tables(0)
        'RepeaterPedidos.DataBind()


        If ods.Tables(0).Rows.Count > 0 Then


            txtUsuario.Text = ods.Tables(0).Rows(0).Item("Email")
            HfID_Consulta.Value = ods.Tables(0).Rows(0).Item("ID_Consulta")

            TxtTelefono.Text = ods.Tables(0).Rows(0).Item("Telefono")




            If ods.Tables(0).Rows(0).Item("Mensaje").ToString <> "" Then
                TxtMensaje.Text = ods.Tables(0).Rows(0).Item("Mensaje").ToString




            Else
                TxtMensaje.Text = "Esta consulta no tiene ningun mensaje"
            End If


        End If
    End Sub


#End Region


#Region "Status"
    Public Sub Status()

        Dim status As String = Session("status")
        Dim titulo As String = Session("titulo")
        Dim imagen As String = Session("imagen")

        Session("status") = Nothing
        Session("titulo") = Nothing
        Session("imagen") = Nothing

        If status = 1 Then
            TituloStatusSpan.InnerText = titulo
            ImagenStatus.Src = imagen

            PanelControles.Visible = False
            PanelVolver.Visible = True

            DivStatus.Visible = True


        End If


    End Sub

    Private Sub btnVolver_ServerClick(sender As Object, e As System.EventArgs) Handles btnVolver.ServerClick
        Response.Redirect("frmConsultas.aspx")
    End Sub

    Protected Sub SendEmail()

        'Dim ods1 As New DataSet
        'Dim oConsulta As New Consultas
        'ods1 = oConsulta.BuscarPorID(Request.QueryString("ID"))


        Dim Email_evento As String = "logistica.ideastdi@gmail.com"
        Dim Pass_evento As String = "password.9"

        Dim Email_evento_consulta As String = txtUsuario.Text



        Dim Desde As New MailAddress(Email_evento, "GUALICHO")

        Dim destinatarios As String = Email_evento_consulta
        Dim msg As New MailMessage(Desde.ToString, destinatarios, "Respuesta a consulta", "Respuesta: " & txtEnviar.Text + vbCrLf + "GUALICHO CERVECERIA -")

        Dim smptHost As String
        smptHost = "smtp.gmail.com"




        Dim SmtpServer As New SmtpClient("smtp.gmail.com")

        Dim client As New SmtpClient(smptHost, 587)
        client.DeliveryMethod = SmtpDeliveryMethod.Network
        client.Port = 587
        client.Credentials = New System.Net.NetworkCredential(Email_evento, Pass_evento)
        client.EnableSsl = True

        client.Send(msg)

    End Sub
    'Private Function PopulateBody(ByVal Descripcion As String, ByVal Titulo As String, ByVal Url As String) As String
    '    Dim body As String = String.Empty
    '    Dim reader As StreamReader = New StreamReader(Server.MapPath("~/EmailTemplate1.htm"))
    '    body = reader.ReadToEnd
    '    body = body.Replace("{Descripcion}", Descripcion)
    '    body = body.Replace("{Titulo}", Titulo)
    '    body = body.Replace("{Url}", Url)
    '    Return body
    'End Function
    'Private Sub SendHtmlFormattedEmail(ByVal recepientEmail As String, ByVal subject As String)
    '    Dim mailMessage As MailMessage = New MailMessage
    '    mailMessage.From = New MailAddress(ConfigurationManager.AppSettings("UserName"))
    '    mailMessage.Subject = subject
    '    mailMessage.Body = txtEnviar.Text
    '    mailMessage.IsBodyHtml = True
    '    mailMessage.To.Add(New MailAddress(recepientEmail))
    '    Dim smtp As SmtpClient = New SmtpClient
    '    smtp.Host = ConfigurationManager.AppSettings("host")
    '    smtp.EnableSsl = Convert.ToBoolean(ConfigurationManager.AppSettings("EnableSsl"))
    '    Dim NetworkCred As System.Net.NetworkCredential = New System.Net.NetworkCredential
    '    NetworkCred.UserName = ConfigurationManager.AppSettings("UserName")
    '    NetworkCred.Password = ConfigurationManager.AppSettings("Password")
    '    smtp.UseDefaultCredentials = True
    '    smtp.Credentials = NetworkCred
    '    smtp.Port = Integer.Parse(ConfigurationManager.AppSettings("port"))
    '    smtp.Send(mailMessage)
    'End Sub

    Protected Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.ServerClick






        '///////////////////EnviarEmail///////////////////////////////
        If txtEnviar.Text <> "" Then


                    If txtUsuario.Text.Contains("@") Then

                ModificarEstadoPedido()
                SendEmail()



                        Dim tituloStatus As String
                        tituloStatus = "RESPUESTA ENVIADA EXITOSAMENTE"

                        Session.Add("status", 1)

                        Session.Add("titulo", tituloStatus)
                        Session.Add("imagen", "Imagenes/OkTickets.png")

                        Response.Redirect("frmConsultasABM.aspx")
                    End If

                    '///////////////////FinEnviarEmail///////////////////////////////



                End If
        '///////////////////EnviarNotificacion///////////////////////////////



        '///////////////////FinEnviarNotificacion///////////////////////////////







    End Sub

    Private Sub ModificarEstadoPedido()
        lblError.Text = ""

        Dim oDs As New DataSet
        Dim oObjeto As New Consultas

        oDs = oObjeto.ModificarEstado(Request.QueryString("ID"), 2)

    End Sub
#End Region


End Class
Imports HIERCONS.AD
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
        Dim oObjeto As New PedidosDetalles
        ods = oObjeto.BuscarPorID_Pedido(ID)

        RepeaterPedidos.DataSource = ods.Tables(0)
        RepeaterPedidos.DataBind()


        If ods.Tables(0).Rows.Count > 0 Then


            txtUsuario.Text = ods.Tables(0).Rows(0).Item("Usuario")
            HfID_Consulta.Value = ods.Tables(0).Rows(0).Item("ID_Pedido")

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

        Dim ods1 As New DataSet
        Dim oPedidodetalle As New PedidosDetalles
        ods1 = oPedidodetalle.BuscarPorID_Pedido(Request.QueryString("ID"))



        Dim ods As New DataSet
        Dim oitem As New Items

        ods = oitem.BuscarPorID(ods1.Tables(0).Rows(0).Item("ID_Item"))

        Dim id_item As String = ods1.Tables(0).Rows(0).Item("ID_Item")

        Dim web As String = SingletonParametro("WEB", "WEB")

        Dim body As String = Me.PopulateBody(txtEnviar.Text, _
            ods.Tables(0).Rows(0).Item("Descripcion"), _
             web & ods.Tables(0).Rows(0).Item("Url") & "?ID=" & id_item _
        )

        Dim emailconsulta As String = txtUsuario.Text

        Dim asunto As String = SingletonParametro("TITULOEMAIL", "TITULOEMAIL")

        Me.SendHtmlFormattedEmail(emailconsulta, asunto, body)
    End Sub
    Private Function PopulateBody(ByVal Descripcion As String, ByVal Titulo As String, ByVal Url As String) As String
        Dim body As String = String.Empty
        Dim reader As StreamReader = New StreamReader(Server.MapPath("~/EmailTemplate1.htm"))
        body = reader.ReadToEnd
        body = body.Replace("{Descripcion}", Descripcion)
        body = body.Replace("{Titulo}", Titulo)
        body = body.Replace("{Url}", Url)
        Return body
    End Function
    Private Sub SendHtmlFormattedEmail(ByVal recepientEmail As String, ByVal subject As String, ByVal body As String)
        Dim mailMessage As MailMessage = New MailMessage
        mailMessage.From = New MailAddress(ConfigurationManager.AppSettings("UserName"))
        mailMessage.Subject = subject
        mailMessage.Body = body
        mailMessage.IsBodyHtml = True
        mailMessage.To.Add(New MailAddress(recepientEmail))
        Dim smtp As SmtpClient = New SmtpClient
        smtp.Host = ConfigurationManager.AppSettings("host")
        smtp.EnableSsl = Convert.ToBoolean(ConfigurationManager.AppSettings("EnableSsl"))
        Dim NetworkCred As System.Net.NetworkCredential = New System.Net.NetworkCredential
        NetworkCred.UserName = ConfigurationManager.AppSettings("UserName")
        NetworkCred.Password = ConfigurationManager.AppSettings("Password")
        smtp.UseDefaultCredentials = True
        smtp.Credentials = NetworkCred
        smtp.Port = Integer.Parse(ConfigurationManager.AppSettings("port"))
        smtp.Send(mailMessage)
    End Sub

    Protected Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.ServerClick

        If HfID_Consulta.Value <> "" Then

            ModificarEstadoPedido()
            If lblError.Text = "" Then

                '///////////////////EnviarEmail///////////////////////////////
                If txtEnviar.Text <> "" Then


                    If txtUsuario.Text.Contains("@") Then


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



            End If


        End If

    End Sub

    Private Sub ModificarEstadoPedido()
        lblError.Text = ""

        Dim oDs As New DataSet
        Dim oObjeto As New Pedidos

        oDs = oObjeto.ModificarEstado(HfID_Consulta.Value, 2)

    End Sub
#End Region


End Class
Imports GUALICHO.AD
Imports System.Net.Mail
Imports System.Web.Script.Serialization
Imports System.Web.Script.Services
Imports System.Web.Services
Public Class FrmInicio
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack = False Then
            ValidarCarrito()
            cargarBanners()
            CargarMenuRubros()
            UltimosProductos()
            ValidarMenu()
            CargarContactos()
            CargarSponsors()
            QuienesSomos()

        End If
    End Sub

#Region "Validar Carrito"
    Public Sub ValidarCarrito()
        If User.Identity.IsAuthenticated = True Then
            btnCarrito.Attributes("onclick") = "AbrirModalCarrito()"
        Else
            btnCarrito.Attributes("onclick") = "IrLogin()"
        End If


    End Sub
#End Region


#Region "Menu"
    Public Sub CargarMenuRubros()

        Dim ods As New DataSet
        Dim oObjeto As New Rubros

        ods = oObjeto.BuscarTodos

        RepeaterMenuRubros.DataSource = ods.Tables(1)
        RepeaterMenuRubros.DataBind()


        RepeaterMenuRubrosMobile.DataSource = ods.Tables(1)
        RepeaterMenuRubrosMobile.DataBind()
    End Sub
#End Region

#Region "UltimosProductos"
    Public Sub UltimosProductos()


        Dim ods As New DataSet
        Dim oObjeto As New Items


        ods = oObjeto.BuscarUltimos8

        'RepeaterUltimosProductos.DataSource = ods.Tables(0)
        'RepeaterUltimosProductos.DataBind()


    End Sub
#End Region

#Region "ValidarMenu"
    Public Sub ValidarMenu()

        If User.Identity.IsAuthenticated = True Then
            MenuIniciarSesion.Visible = False
            MenuCerrarSesion.Visible = True
            'MenuMisConsultas.Visible = True

            MenuIniciarSesionMobile.Visible = False
            MenuCerrarSesionMobile.Visible = True
          MenuMisComprasMobile.Visible = True


        Else

            MenuIniciarSesion.Visible = True
            MenuCerrarSesion.Visible = False

            MenuIniciarSesionMobile.Visible = True
            MenuCerrarSesionMobile.Visible = False

            MenuMisComprasMobile.Visible = False
            MenuMisCompras.Visible = False
        End If
    End Sub

    Protected Sub CerrarSesion(sender As Object, e As EventArgs)
        FormsAuthentication.SignOut()
        'Roles.DeleteCookie()
        Session.Clear()
        Response.Redirect("frmlogin.aspx")
    End Sub
#End Region

#Region "Sponsors"



    Public Sub CargarSponsors()
        Dim ods As New DataSet
        Dim oObjeto As New Sponsors

        ods = oObjeto.BuscarTodos

        RepeaterSponsors.DataSource = ods.Tables(0)
        RepeaterSponsors.DataBind()

    End Sub

#End Region

#Region "EmailContacto"
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Shared Function EnviarEmailContacto_Ws(ByVal cadena As String) As String


        Try


            Dim jss As New JavaScriptSerializer()
            Dim dict = jss.Deserialize(Of List(Of ContactoWS))("[" & cadena & "]")




            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''



            Dim Email As String = Convert.ToString(dict(0).Email)

            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''




            Dim Email_evento As String = "gualichocerveceria@yahoo.com"
            Dim Pass_evento As String = "Rock2356"

            'Dim Email_evento_consulta As String = "emmabria28@gmail.com"

            Dim ods As New DataSet
            Dim oObjeto As New Contacto
            ods = oObjeto.BuscarTodos()

            Dim Email_evento_consulta As String = ods.Tables(0).Rows(0).Item("Email").ToString




            Dim Desde As New MailAddress(Email_evento, "GUALICHO")

            Dim destinatarios As String = Email_evento_consulta
            Dim msg As New MailMessage(Desde.ToString, destinatarios, "Nuevo Email para recibir información", "Email: " & Email + vbCrLf + vbCrLf + "GUALICHO - NUEVO EMAIL PARA RECIBIR INFORMACIÓN -")

            Dim smptHost As String
            smptHost = "smtp.gmail.com"




            Dim SmtpServer As New SmtpClient("smtp.gmail.com")

            Dim client As New SmtpClient(smptHost, 587)
            client.DeliveryMethod = SmtpDeliveryMethod.Network
            client.Port = 587
            client.Credentials = New System.Net.NetworkCredential(Email_evento, Pass_evento)
            client.EnableSsl = True

            client.Send(msg)


            Dim data = New With {
                     Key .Status = "200",
                     Key .Data = "Creado con Exito"
                 }

            Dim serializer = New JavaScriptSerializer()
            Dim json = serializer.Serialize(data)


            Return New JavaScriptSerializer().Serialize(data)




        Catch ex As Exception

            Return Error401()
        End Try


    End Function


#End Region

#Region "Manejo de Status"

    Public Shared Function Error401()

        Dim data = New With {
                         Key .Status = "401"
                     }
        Dim serializer = New JavaScriptSerializer()
        Dim json = serializer.Serialize(data)

        Return New JavaScriptSerializer().Serialize(data)
    End Function

    Public Function Status200()
        Dim data = New With {
                   Key .Status = "200"}

        Dim serializer = New JavaScriptSerializer()
        Dim json = serializer.Serialize(data)

        Return New JavaScriptSerializer().Serialize(data)

    End Function

    Public Function ErrorLogin(ByVal Mensaje As String)
        Dim data = New With {
                     Key .Status = "401",
                     Key .Data = New With {
                     Key .Message = Mensaje
                   }
                 }

        Dim serializer = New JavaScriptSerializer()
        Dim json = serializer.Serialize(data)




        Return New JavaScriptSerializer().Serialize(data)
    End Function

    Private Function StatusReclamos(ByVal NroStatus As String, ByVal Mensaje As String)
        Dim data = New With {
                  Key .Status = NroStatus,
                  Key .Data = New With {
                  Key .Message = Mensaje
                }
              }

        Dim serializer = New JavaScriptSerializer()
        Dim json = serializer.Serialize(data)
        Return New JavaScriptSerializer().Serialize(data)
    End Function

    Private Function StatusCambioPAss(ByVal NroStatus As String, ByVal Mensaje As String)
        Dim data = New With {
                  Key .Status = NroStatus,
                  Key .Data = New With {
                  Key .Message = Mensaje
                }
              }

        Dim serializer = New JavaScriptSerializer()
        Dim json = serializer.Serialize(data)
        Return New JavaScriptSerializer().Serialize(data)
    End Function
#End Region

#Region "RedesSociales"
    Public Sub CargarContactos()
        Dim ods As New DataSet
        Dim oObjeto As New Contactos
        ods = oObjeto.BuscarTodos

        Dim twitter As String = ""
        Dim instagram As String = ods.Tables(0).Rows(0).Item("Url").ToString
        Dim facebook As String = ods.Tables(0).Rows(1).Item("Url").ToString
        Dim whatsapp As String = ods.Tables(0).Rows(2).Item("Url").ToString

        If twitter <> "" Then
            HrefTwitter.Visible = True
            HrefTwitter.HRef = twitter
        Else
            HrefTwitter.Visible = False
        End If

        If instagram <> "" Then
            HrefInstagram.Visible = True
            HrefInstagram.HRef = instagram
        Else
            HrefInstagram.Visible = False
        End If

        If facebook <> "" Then
            HrefFacebook.Visible = True
            HrefFacebook.HRef = facebook
        Else
            HrefFacebook.Visible = False
        End If

        If whatsapp <> "" Then
            HrefWhatsapp.Visible = True
            HrefWhatsapp.HRef = whatsapp
        Else
            HrefInstagram.Visible = False
        End If

    End Sub
#End Region

#Region "Banner"
    Public Sub cargarBanners()
        Dim ods As New DataSet
        Dim oObjeto As New Banners

        ods = oObjeto.BuscarTodos
        RepeaterBanner.DataSource = ods.Tables(0)
        RepeaterBanner.DataBind()
    End Sub


#End Region

#Region "Quienes Somos"
    Public Sub QuienesSomos()
        Dim ods As New DataSet
        Dim oObjeto As New QuienesSomos

        ods = oObjeto.BuscarTodos

        TxtTituloQS.InnerText = ods.Tables(0).Rows(0).Item("Titulo").ToString
        TxtSubTituloQS.InnerText = ods.Tables(0).Rows(0).Item("Subtitulo").ToString
        TxtDescripcionQS.InnerHtml = ods.Tables(0).Rows(0).Item("Descripcion").ToString

        'ImgQuienesSomos.Src = ods.Tables(0).Rows(0).Item("Imagen").ToString
        'TxtTooltip1.InnerText = ods.Tables(0).Rows(0).Item("Tooltip1").ToString
        'TxtTooltip2.InnerText = ods.Tables(0).Rows(0).Item("Tooltip2").ToString
        'TxtTooltip3.InnerText = ods.Tables(0).Rows(0).Item("Tooltip3").ToString
        'TxtTooltip4.InnerText = ods.Tables(0).Rows(0).Item("Tooltip4").ToString
        'TxtTooltip5.InnerText = ods.Tables(0).Rows(0).Item("Tooltip5").ToString
    End Sub
#End Region



End Class
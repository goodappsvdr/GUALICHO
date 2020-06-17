Imports GUALICHO.AD
Imports System.Net.Mail
Imports System.Web.Script.Serialization
Imports System.Web.Script.Services
Imports System.Web.Services
Imports MercadoPago.Common
Imports MercadoPago.DataStructures.Preference
Imports MercadoPago.Resources


Public Class FrmFinalizarCompra
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        If Page.IsPostBack = False Then
            Main()

            If MercadoPago.SDK.ClientId Is Nothing Then
                'MercadoPago.SDK.ClientId = "6712721325584376"
                'MercadoPago.SDK.ClientSecret = "zl2Sq8B8Z7gK9rBUBahLtExu3BCIJkoQ"
                MercadoPago.SDK.ClientId = "6192370592363131"
                MercadoPago.SDK.ClientSecret = "enI0eJPHYwqFIUkRjneDU4AHeSYcJemy"
            End If

            ValidarCarrito()
            ValidarMenu()
            CargarMenuRubros()
            CargarSponsors()
            CargarContactos()


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

#Region "ValidarMenu"
    Public Sub ValidarMenu()

        If User.Identity.IsAuthenticated = True Then
            MenuIniciarSesion.Visible = False
            MenuCerrarSesion.Visible = True
           MenuMisCompras.Visible = true

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




            Dim Email_evento As String = "gualichobeerstore@gmail.com"
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


    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Shared Function FinalizarYPagar_Ws(ByVal cadena As String) As String


        Try


            IniciaTransaccion()

            Dim jss As New JavaScriptSerializer()
            Dim dict = jss.Deserialize(Of List(Of CriteriosWS))("[" & cadena & "]")

            Dim Domicilio As String = Convert.ToString(dict(0).Domicilio)

            Dim Geolatitud As String = Convert.ToString(dict(0).Geolatitud)

            Dim Geolongitud As String = Convert.ToString(dict(0).Geolongitud)

            Dim EntreCalles As String = Convert.ToString(dict(0).EntreCalles)



            Dim oDs As New DataSet
            Dim oObjeto As New Carrito


            Dim newUser As MembershipUser = Membership.GetUser
            Dim newUserId As Guid = DirectCast(newUser.ProviderUserKey, Guid)


            oDs = oObjeto.BuscarPorUserId(newUserId)


            Dim TotalGeneral As Double = 0
            For i = 0 To oDs.Tables(0).Rows.Count - 1

                TotalGeneral = TotalGeneral + oDs.Tables(0).Rows(i).Item("Total")
            Next


            Dim ods3 As New DataSet
            Dim oObjeto3 As New User_Profile
            ods3 = oObjeto3.BuscarPorUserId(newUserId)

            Dim Email As String = ods3.Tables(0).Rows(0).Item("Usuario").ToString
            Dim RazonSocial As String = ods3.Tables(0).Rows(0).Item("RazonSocial").ToString

            Dim FechaCompra As Date = Date.Now

            Dim FechaExpiracion As Date
            FechaExpiracion = FechaCompra
            FechaExpiracion = FechaExpiracion.AddDays(2)


            Dim ID_PedidoMP_New As Integer
            Dim oObjeto1 As New PedidosMP

            ID_PedidoMP_New = oObjeto1.Agregar(transaccion, FechaCompra, newUserId, TotalGeneral, 1, 0, RazonSocial, Email, Domicilio, Geolatitud, Geolongitud, EntreCalles, "")


            Dim ID_PedidoDetalleMP_New As Integer
            Dim oObjeto4 As New PedidosDetalleMP
            For i = 0 To oDs.Tables(0).Rows.Count - 1

                ID_PedidoDetalleMP_New = oObjeto4.Agregar(transaccion, ID_PedidoMP_New, oDs.Tables(0).Rows(i).Item("ID_Item"), "", "", oDs.Tables(0).Rows(i).Item("Cantidad"), oDs.Tables(0).Rows(i).Item("Precio"), oDs.Tables(0).Rows(i).Item("Total"))

            Next


            Dim ods5 As New DataSet
            Dim oObjeto5 As New Carrito

            ods5 = oObjeto.EliminarTodoPorUsuario(newUserId)





            Dim Titulo As String = "PAGO USUARIO: " & Email


            Dim preference As New Preference
            Dim item2 As New MercadoPago.DataStructures.Preference.Item
            item2.Id = ID_PedidoMP_New.ToString
            item2.Description = Titulo
            item2.Title = Titulo
            item2.Quantity = 1
            item2.CurrencyId = CurrencyId.ARS
            item2.UnitPrice = TotalGeneral





            Dim payer As New MercadoPago.DataStructures.Preference.Payer
            payer.Name = RazonSocial
            payer.Surname = RazonSocial
            payer.Email = Email


            Dim back_urls As New MercadoPago.DataStructures.Preference.BackUrls
            back_urls.Success = "https://cerveceriagualicho.com/frmPagoExitoso.aspx"
            back_urls.Failure = "https://cerveceriagualicho.com/frmPagoRechazado.aspx"
            back_urls.Pending = "https://cerveceriagualicho.com/frmPagoPendiente.aspx"



            preference.Items.Add(item2)
            preference.Payer = payer
            preference.AutoReturn = MercadoPago.Common.AutoReturnType.approved
            preference.BackUrls = back_urls
            preference.ExternalReference = (ID_PedidoMP_New.ToString)
            preference.ExpirationDateTo = FechaExpiracion
            'preference.PaymentMethods = payments_excluded


            preference.Save()


            'Process.Start(preference.InitPoint)


            Dim ods2 As New DataSet
            Dim oObjeto2 As New PedidosMP

            ods2 = oObjeto2.AgregarUrlMP(transaccion, ID_PedidoMP_New.ToString, preference.InitPoint)





            Dim url As String = preference.InitPoint






            Dim data = New With {
                     Key .Status = "200",
                     Key .Data = url
                 }

            Dim serializer = New JavaScriptSerializer()
            Dim json = serializer.Serialize(data)

            FinalizaTransaccion()

            Return New JavaScriptSerializer().Serialize(data)



        Catch ex As Exception
            CancelaTransaccion()
            Return Error401()
        End Try


    End Function

End Class
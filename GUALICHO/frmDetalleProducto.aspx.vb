Imports System.Net.Mail
Imports System.Web.Script.Serialization
Imports System.Web.Script.Services
Imports System.Web.Services
Imports GUALICHO.AD
Public Class frmDetalleProducto
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Main()

        If Page.IsPostBack = False Then
            ValidarMenu()
            CargarMenuRubros()
            CargarDetalleitem()
            CargarImagenesItems()
            CargarSponsors()
            CargarContactos()
        End If
    End Sub


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

#Region "Detallle Producto"
    Public Sub CargarDetalleitem()


        Dim oDs As New DataSet
        Dim Objeto As New Items


        Dim ID_Item As String = Request.QueryString("ID")


        oDs = Objeto.Items_BuscarporID_Item(ID_Item)
        'imagen = oDs.Tables(0).Rows(0).Item("ImagenPrincipal")




        TxtProducto.InnerHtml = oDs.Tables(0).Rows(0).Item("Descripcion").ToString


        TxtTitulo.InnerHtml = oDs.Tables(0).Rows(0).Item("Descripcion").ToString
        TxtPrecio.InnerHtml = oDs.Tables(0).Rows(0).Item("Precio").ToString

        TxtMarca.InnerHtml = oDs.Tables(0).Rows(0).Item("Marca").ToUpper.ToString
        TxtRubro.InnerHtml = oDs.Tables(0).Rows(0).Item("Rubro").ToUpper.ToString
        TxtSubRubro.InnerHtml = oDs.Tables(0).Rows(0).Item("SubRubro").ToUpper.ToString



        Me.Title = "HIERCONS -  " & oDs.Tables(0).Rows(0).Item("Descripcion").ToString
        imagenRedesSociales.Content = oDs.Tables(0).Rows(0).Item("ImagenPrincipal").ToString
        DescripcionRedesSociales.Content = oDs.Tables(0).Rows(0).Item("Detalle").ToString


        TxtDetalleProducto.InnerHtml = oDs.Tables(0).Rows(0).Item("Detalle").ToString
        TxtExtrasProducto.InnerHtml = oDs.Tables(0).Rows(0).Item("Extendida").ToString

    End Sub

    Private Sub CargarImagenesItems()
        Dim oDs As New DataSet
        Dim oObjeto As New ItemsImagenes
        Dim ID_Item As String = Request.QueryString("ID")

        oDs = oObjeto.ItemsImagenes_BuscarPorID_Item(ID_Item)



        If oDs.Tables(0).Rows.Count <> Nothing Then


            Dim dt As New DataTable

            dt.Columns.Add("Imagen")
            dt.Columns.Add("Clase")
            dt.Columns.Add("ID")
            dt.Columns.Add("Clase2")

            For i As Integer = 0 To oDs.Tables(0).Rows.Count - 1
                Dim r As DataRow = dt.NewRow

                r(0) = oDs.Tables(0).Rows(i).Item("Imagen").ToString
                r(2) = oDs.Tables(0).Rows(i).Item("ID_ItemImagen").ToString
                If i = 0 Then
                    r(1) = "tab-pane fade in active"
                    r(3) = "pot-small-img active"
                Else
                    r(1) = "tab-pane fade"
                    r(3) = "pot-small-img"
                End If


                dt.Rows.Add(r)
            Next


            Dim dtImgGrande As New DataTable

            dtImgGrande = dt











            RepeaterImgGrandes.DataSource = dtImgGrande
            RepeaterImgGrandes.DataBind()

            RepeaterImgChicas.DataSource = dtImgGrande
            RepeaterImgChicas.DataBind()
        Else
            RepeaterImgGrandes.DataSource = Nothing
            RepeaterImgGrandes.DataBind()

            RepeaterImgChicas.DataSource = Nothing
            RepeaterImgChicas.DataBind()
        End If



    End Sub
#End Region


    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Shared Function Consulta_Enviar_Ws(ByVal cadena As String) As String


        Try


            Dim jss As New JavaScriptSerializer()
            Dim dict = jss.Deserialize(Of List(Of ContactoWS))("[" & cadena & "]")




            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''



            Dim ID_Item As String = Convert.ToString(dict(0).ID_Item)
            Dim RazonSocial As String = Convert.ToString(dict(0).RazonSocial)
            Dim Email As String = Convert.ToString(dict(0).Email)
            Dim Telefono As String = Convert.ToString(dict(0).Telefono)
            Dim Mensaje As String = Convert.ToString(dict(0).Mensaje)

            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''







            Try
                IniciaTransaccion()
                Dim oDs As New DataSet
                Dim oObjeto As New Pedidos


                Dim id_pedido As Integer

                id_pedido = oObjeto.Agregar(transaccion, FechaHoraServidor, Email, 0, 1, 0, RazonSocial)


                Dim oDs3 As New DataSet
                Dim oObjeto3 As New PedidosDetalles
                Dim id_pedidoDetalle As Integer






                id_pedidoDetalle = oObjeto3.Agregar(transaccion, id_pedido, ID_Item, Telefono, Mensaje, 1, 0, 0)





                Dim oDs4 As New DataSet
                Dim oObjeto4 As New PedidosDetallesCaracteristicas
                Dim resultado As Integer

                resultado = oObjeto4.Agregar(transaccion, id_pedidoDetalle, 0, 0, 0)


                FinalizaTransaccion()
            Catch ex As Exception
                CancelaTransaccion()

            End Try











            EnviarConsulta(Email, RazonSocial, Telefono, Mensaje)

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

    Public Shared Sub EnviarConsulta(ByVal emailCliente As String, ByVal Nombre_Consulta As String, ByVal telefono_consulta As String, ByVal mensaje_consulta As String)



        Dim Email_evento As String = "logistica.ideastdi@gmail.com"
        Dim Pass_evento As String = "password.9"

        Dim Email_evento_consulta As String = "logistica.ideastdi@gmail.com"



        Dim Desde As New MailAddress(Email_evento, "HIERCONS")

        Dim destinatarios As String = Email_evento_consulta
        Dim msg As New MailMessage(Desde.ToString, destinatarios, "Nueva Consulta", "Nombre y Apellido: " & Nombre_Consulta + vbCrLf + "Email: " & emailCliente + vbCrLf + "Teléfono: " & telefono_consulta + vbCrLf + "Mensaje: " & mensaje_consulta + vbCrLf + "HIERCONS - NUEVA CONSULTA -")

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


#Region "ValidarMenu"
    Public Sub ValidarMenu()

        If User.Identity.IsAuthenticated = True Then
            MenuIniciarSesion.Visible = False
            MenuCerrarSesion.Visible = True
            '  MenuMisConsultas.Visible = True

            MenuIniciarSesionMobile.Visible = False
            MenuCerrarSesionMobile.Visible = True
            MenuMisConsultasMobile.Visible = True

            CargarDatosUsuario()
        Else

            MenuIniciarSesion.Visible = True
            MenuCerrarSesion.Visible = False
            '  MenuMisConsultas.Visible = true
            MenuIniciarSesionMobile.Visible = True
            MenuCerrarSesionMobile.Visible = False
            MenuMisConsultasMobile.Visible = true
        End If
    End Sub

    Protected Sub CerrarSesion(sender As Object, e As EventArgs)
        FormsAuthentication.SignOut()
        'Roles.DeleteCookie()
        Session.Clear()
        Response.Redirect("frmlogin.aspx")
    End Sub


#End Region

#Region "DatosUsuario"
    Public Sub CargarDatosUsuario()

        '    Dim ods As New DataSet
        '    Dim oObjeto As New User_Profile

        '    Dim newUser As MembershipUser = Membership.GetUser
        '    Dim newUserId As Guid = DirectCast(newUser.ProviderUserKey, Guid)

        '    ods = oObjeto.BuscarPorUserId(newUserId)


        '    txtEmail.value = ods.Tables(0).Rows(0).Item("Usuario").ToString

        '    TxtNombre.Value = ods.Tables(0).Rows(0).Item("RazonSocial").ToString


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




            Dim Email_evento As String = "logistica.ideastdi@gmail.com"
            Dim Pass_evento As String = "password.9"

            'Dim Email_evento_consulta As String = "emmabria28@gmail.com"

            Dim ods As New DataSet
            Dim oObjeto As New Contacto
            ods = oObjeto.BuscarTodos()

            Dim Email_evento_consulta As String = ods.Tables(0).Rows(0).Item("Email").ToString




            Dim Desde As New MailAddress(Email_evento, "HIERCONS")

            Dim destinatarios As String = Email_evento_consulta
            Dim msg As New MailMessage(Desde.ToString, destinatarios, "Nuevo Email para recibir información", "Email: " & Email + vbCrLf + vbCrLf + "HIERCONS - NUEVO EMAIL PARA RECIBIR INFORMACIÓN -")

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
#Region "RedesSociales"
    Public Sub CargarContactos()
        Dim ods As New DataSet
        Dim oObjeto As New Contactos
        ods = oObjeto.BuscarTodos

        Dim twitter As String = ""
        Dim instagram As String = ods.Tables(0).Rows(0).Item("Url").ToString
        Dim facebook As String = ods.Tables(0).Rows(1).Item("Url").ToString
        'Dim whatsapp As String = ods.Tables(0).Rows(2).Item("Url").ToString

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

        'If whatsapp <> "" Then
        '    HrefWhatsapp.Visible = True
        '    HrefWhatsapp.HRef = whatsapp
        'Else
        '    HrefInstagram.Visible = False
        'End If


    End Sub
#End Region

End Class
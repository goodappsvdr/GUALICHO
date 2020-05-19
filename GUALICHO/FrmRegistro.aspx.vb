﻿Imports GUALICHO.AD
Imports System.Net.Mail
Imports System.Web.Script.Serialization
Imports System.Web.Script.Services
Imports System.Web.Services
Public Class FrmRegistro
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack = False Then
            CargarMenuRubros()
            ValidarMenu()
            CargarSponsors()
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


#Region "CrearUsuario"



    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Shared Function Usuarios_Crear_Web(ByVal cadena As String) As String


        Try


            Dim jss As New JavaScriptSerializer()
            Dim dict = jss.Deserialize(Of List(Of UsuariosWeb))("[" & cadena & "]")




            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''




            Dim RazonSocial As String = Convert.ToString(dict(0).RazonSocial)
            Dim Email As String = Convert.ToString(dict(0).Email)
            Dim Pass As String = Convert.ToString(dict(0).Pass)
            Dim DNI As String = Convert.ToString(dict(0).DNI)



            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

            'CREAR USUARIO EN MEMBERSHIP

            Dim createStatus As MembershipCreateStatus
            Dim newUser As MembershipUser = Membership.CreateUser(Email, Pass, Email, "ropa", "ropa", True, createStatus)


            'FIN CREAR USUARIO EN MEMBERSHIP




            Select Case createStatus
                Case MembershipCreateStatus.Success

                    Dim user As MembershipUser = Membership.GetUser(Email)
                    Dim newUserId As Guid = DirectCast(newUser.ProviderUserKey, Guid)




                    Dim resultado As Integer
                    Dim oEventos As New User_Profile



                    Dim LinkActivador As String = CLng(DateTime.UtcNow.Subtract(New DateTime(1970, 1, 1)).TotalMilliseconds)

                    LinkActivador = LinkActivador & CLng(DateTime.UtcNow.Subtract(New DateTime(1970, 1, 1)).TotalMilliseconds)

                    LinkActivador = LinkActivador & CLng(DateTime.UtcNow.Subtract(New DateTime(1970, 1, 1)).TotalMilliseconds)



                    resultado = oEventos.Agregar(newUserId, Email, RazonSocial, LinkActivador, RazonSocial, DNI, 1)

                    Dim estado_sistema As Boolean = False

                    'DESABILITO EL USUARIO HASTA QUE CONFIRME EL EMAIL
                    Dim ods2 As New DataSet
                    Dim oObjeto2 As New User_Profile

                    ods2 = oObjeto2.UsuariosSistema_ModificarEstado(newUserId, estado_sistema)





                    Dim link As String

                    link = SingletonParametro("URL", "ACTIVARUSUARIO")

                    link = link & LinkActivador


                    EnviarEmailParaActivarCuenta(Email, link)


                    Dim data = New With {
                     Key .Status = "200",
                       Key .Data = "Ok"
                 }

                    Dim serializer = New JavaScriptSerializer()
                    Dim json = serializer.Serialize(data)


                    Return New JavaScriptSerializer().Serialize(data)

                    Exit Select








                Case MembershipCreateStatus.DuplicateUserName


                    Dim data = New With {
                     Key .Status = "401",
                     Key .Data = "Nombre de Usuario en Uso"
                 }

                    Dim serializer = New JavaScriptSerializer()
                    Dim json = serializer.Serialize(data)


                    Return New JavaScriptSerializer().Serialize(data)


                    Exit Select






                Case MembershipCreateStatus.DuplicateEmail


                    Dim data = New With {
                     Key .Status = "401",
                     Key .Data = "Ya existe un usuario con este email"
                 }

                    Dim serializer = New JavaScriptSerializer()
                    Dim json = serializer.Serialize(data)


                    Return New JavaScriptSerializer().Serialize(data)



                    Exit Select










                Case MembershipCreateStatus.InvalidEmail
                    Dim data = New With {
                     Key .Status = "401",
                     Key .Data = "Email Invalido"
                 }

                    Dim serializer = New JavaScriptSerializer()
                    Dim json = serializer.Serialize(data)


                    Return New JavaScriptSerializer().Serialize(data)

                    Exit Select








                Case MembershipCreateStatus.InvalidAnswer

                    Dim data = New With {
                     Key .Status = "401",
                     Key .Data = "Pregunta invalida"
                 }

                    Dim serializer = New JavaScriptSerializer()
                    Dim json = serializer.Serialize(data)


                    Return New JavaScriptSerializer().Serialize(data)


                    Exit Select










                Case MembershipCreateStatus.InvalidPassword

                    Dim data = New With {
                     Key .Status = "401",
                     Key .Data = "Contraseña Invalida"
                 }

                    Dim serializer = New JavaScriptSerializer()
                    Dim json = serializer.Serialize(data)


                    Return New JavaScriptSerializer().Serialize(data)


                    Exit Select






                Case Else

                    Dim data = New With {
                     Key .Status = "401",
                     Key .Data = "Error"
                 }

                    Dim serializer = New JavaScriptSerializer()
                    Dim json = serializer.Serialize(data)


                    Return New JavaScriptSerializer().Serialize(data)

                    Exit Select


            End Select



        Catch ex As Exception
            Return Error401()
        End Try


    End Function






#End Region


    Public Shared Sub EnviarEmailParaActivarCuenta(ByVal emailCliente As String, ByVal link As String)




        Dim Email_evento As String = "logistica.ideastdi@gmail.com"
        Dim Pass_evento As String = "password.9"



        Dim Desde As New MailAddress(Email_evento, "HIERCONS")

        Dim destinatarios As String = emailCliente
        Dim msg As New MailMessage(Desde.ToString, destinatarios, "ACTIVACIÓN DE CUENTA", "Clickea en el siguiente link para activar tu cuenta" + vbCrLf + "Link: " + link + vbCrLf + "HIERCONS")

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
            MenuMisConsultas.Visible = True

            MenuIniciarSesionMobile.Visible = False
            MenuCerrarSesionMobile.Visible = True
            MenuMisConsultasMobile.Visible = True


        Else

            MenuIniciarSesion.Visible = True
            MenuCerrarSesion.Visible = False
            MenuMisConsultas.Visible = true
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
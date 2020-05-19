﻿Imports GUALICHO.AD
Imports System.Net.Mail
Imports System.Web.Script.Serialization
Imports System.Web.Script.Services
Imports System.Web.Services
Public Class FrmNosotros
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack = False Then
            CargarMenuRubros()
            ValidarMenu()
            CargarSponsors()
            CargarNosotros()
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
            MenuMisConsultas.Visible = True
            MenuIniciarSesionMobile.Visible = True
            MenuCerrarSesionMobile.Visible = False
            MenuMisConsultasMobile.Visible = True
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

#Region "Nosotros"
    Public Sub CargarNosotros()
        Dim ods As New DataSet
        Dim oObjeto As New Nosotros

        ods = oObjeto.BuscarTodos

        TxtTitulo.InnerText = ods.Tables(0).Rows(0).Item("Titulo").ToString
        TxtDescripcion1.InnerHtml = ods.Tables(0).Rows(0).Item("DescripcionPrincipal").ToString
        ImgEmpresa.Src = ods.Tables(0).Rows(0).Item("Imagen").ToString
        TxtDescripcion2.InnerHtml = ods.Tables(0).Rows(0).Item("DescripcionSecundaria").ToString




        Dim ods1 As New DataSet
        Dim oObjeto1 As New ImagenesNosotros

        ods1 = oObjeto1.BuscarTodos




        Dim dt As New DataTable
        dt.Columns.Add("Imagen")
        dt.Columns.Add("Clase")

        For i As Integer = 0 To ods1.Tables(0).Rows.Count - 1
            Dim r As DataRow = dt.NewRow

            r(0) = ods1.Tables(0).Rows(i).Item("Imagen").ToString
            If i = 0 Then
                r(1) = "item active"
            Else
                r(1) = "item"
            End If


            dt.Rows.Add(r)
        Next



        Dim dtMP As New DataTable

        dtMP = dt

        RepeaterImagenesNosotros.DataSource = dtMP
        RepeaterImagenesNosotros.DataBind()




    End Sub
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
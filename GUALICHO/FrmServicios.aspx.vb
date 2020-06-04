Imports GUALICHO.AD
Public Class FrmServicios
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack = False Then
            ValidarCarrito()
            CargarMenuRubros()
            ValidarMenu()
            CargarSponsors()
            CargarContactos()
            Servicios()
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


#Region "Servicios"


    Public Sub Servicios()
        Dim ods As New DataSet
        Dim oObjeto As New Servicios
        ods = oObjeto.BuscarTodos

        RepeaterServicios.DataSource = ods.Tables(0)
        RepeaterServicios.DataBind()
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


#Region "ValidarMenu"
    Public Sub ValidarMenu()

        If User.Identity.IsAuthenticated = True Then
            MenuIniciarSesion.Visible = False
            MenuCerrarSesion.Visible = True
            MenuMisCompras.Visible = True

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





End Class
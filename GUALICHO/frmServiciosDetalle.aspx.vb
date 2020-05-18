Imports GUALICHO.AD
Public Class frmServiciosDetalle
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack = False Then
            CargarMenuRubros()
            ValidarMenu()
            CargarSponsors()
            CargarContactos()
            Servicios()
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


#Region "Servicios"


    Public Sub Servicios()

        Dim ods As New DataSet
        Dim oObjeto As New Servicios
        Dim id_servicio As String = Request.QueryString("ID")
        ods = oObjeto.BuscarPorID(id_servicio)

        TxtServicio.InnerHtml = ods.Tables(0).Rows(0).Item("Nombre").ToString
        txtDetalle.InnerHtml = ods.Tables(0).Rows(0).Item("Descripcion").ToString
        txtServicioArriba.InnerHtml = ods.Tables(0).Rows(0).Item("Nombre").ToString


        Dim ods1 As New DataSet
        Dim oObjeto1 As New ImagenesServicios
        ods1 = oObjeto1.BuscarPorID_Servicio(id_servicio)



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

        RepeaterImagenesServicios.DataSource = dtMP
        RepeaterImagenesServicios.DataBind()


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



End Class
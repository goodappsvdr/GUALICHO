Imports HIERCONS.AD
Public Class frmImagenesServicios
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        If Page.IsPostBack = False Then
            CargarMenuRoles()
            ImagenesServiciosBuscarPorID_servicio()
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

#Region "IMAGENES Servicios"
    Private Sub ImagenesServiciosBuscarPorID_servicio()

        Dim id_servicio As String = Request.QueryString("ID")

        Dim ods1 As New DataSet
        Dim oObjeto1 As New Servicios
        ods1 = oObjeto1.BuscarPorID(id_servicio)

        TxtServicio.InnerHtml = "IMÁGENES SERVICIO: <b>" & ods1.Tables(0).Rows(0).Item("Nombre").ToString & "</b>"




        Dim oDs As New DataSet
        Dim oObjeto As New ImagenesServicios
        oDs = oObjeto.BuscarPorID_servicio(id_servicio)
        RepeaterImagenesNosotros.DataSource = oDs.Tables(0)
        RepeaterImagenesNosotros.DataBind()
    End Sub

    Private Sub BtnNuevoImagenServicio_ServerClick(sender As Object, e As EventArgs) Handles BtnNuevoImagenServicio.Click
        Dim id_servicio As String = Request.QueryString("ID")

        Response.Redirect("frmImagenesServiciosABM.aspx?ID_Servicio=" & id_servicio & "&Action=Nuevo")
    End Sub





#End Region



End Class
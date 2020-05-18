Imports HIERCONS.AD
Public Class frmConsultas
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargarMenuRoles()
        ConsultasBuscarTodos()

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

#Region "CONSULTAS"

    Private Sub ConsultasBuscarTodos()
        Dim oDs As New DataSet
        Dim oObjeto As New Pedidos
        oDs = oObjeto.BuscarTodos
        RepeaterConsultas.DataSource = oDs.Tables(0)
        RepeaterConsultas.DataBind()
    End Sub


#End Region
End Class
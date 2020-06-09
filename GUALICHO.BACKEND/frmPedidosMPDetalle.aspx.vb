Imports GUALICHO.AD
Public Class frmPedidosMPDetalle
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        CargarMenuRoles()
        CargarDetallePedido()

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

    Private Sub CargarDetallePedido()
        Dim oDs As New DataSet
        Dim oObjeto As New PedidosMP

        Dim id_pedidoMP As Integer = Request.QueryString("ID")
        oDs = oObjeto.BuscarPorID_PedidoMP(id_pedidoMP)


        RepeaterMisPedidos.DataSource = oDs.Tables(0)
        RepeaterMisPedidos.DataBind()


    End Sub
    Private Sub RepeaterMisPedidos_ItemDataBound(sender As Object, e As System.Web.UI.WebControls.RepeaterItemEventArgs) Handles RepeaterMisPedidos.ItemDataBound
        If e.Item.ItemType = ListItemType.Item OrElse e.Item.ItemType = ListItemType.AlternatingItem Then


            Dim ID_pedido As Integer = CInt(TryCast(e.Item.FindControl("hd1"), HiddenField).Value)

            Dim oDs As New DataSet

            Dim opedidosdetalles As New PedidosDetalleMP

            oDs = opedidosdetalles.BuscarID_PedidoMP(ID_pedido)

            Dim RepeaterDetalle As Repeater = TryCast(e.Item.FindControl("RepeaterPedidosDetalles"), Repeater)

            RepeaterDetalle.DataSource = oDs.Tables(0)
            RepeaterDetalle.DataBind()

        End If
    End Sub


#End Region

End Class
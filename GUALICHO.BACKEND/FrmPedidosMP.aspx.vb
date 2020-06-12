Imports GUALICHO.AD
Public Class FrmPedidosMP
    Inherits System.Web.UI.Page
    Dim HoraActual As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        HoraActual = FechaHoraServidor()

        ComprobarEstadoPedidos()
        CargarMenuRoles()
        PedidosBuscarTodos()

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

#Region "PEDIDOS"

    Private Sub PedidosBuscarTodos()
        Dim oDs As New DataSet
        Dim oObjeto As New PedidosMP
        oDs = oObjeto.BuscarTodos
        RepeaterPedidos.DataSource = oDs.Tables(0)
        RepeaterPedidos.DataBind()
    End Sub


    Private Sub ComprobarEstadoPedidos()
        Dim oDs As New DataSet
        Dim oObjeto As New PedidosMP
        oDs = oObjeto.BuscarPendientes

        'Busco las compras que estan en estado Pendiente





        For i = 0 To oDs.Tables(0).Rows.Count - 1

            If CDate(oDs.Tables(0).Rows(i).Item("Fecha")).AddHours(3) <= HoraActual Then
                'modificar el estado y ponerlo como consultado
                oObjeto.CambiarAConsultado(oDs.Tables(0).Rows(i).Item("ID_PedidoMP"), 7)
            End If

        Next


    End Sub

#End Region
End Class
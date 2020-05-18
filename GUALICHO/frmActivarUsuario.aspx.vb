Imports GUALICHO.AD
Public Class frmActivarUsuario
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack = False Then
            ValidarUsuario()
        End If
    End Sub
    Private Sub ValidarUsuario()
        Dim ods1 As New DataSet
        Dim oObjeto1 As New User_Profile

        Dim linkActivar As String = Request.QueryString("ID").ToString

        ods1 = oObjeto1.BuscarPorLinkActivador(linkActivar)


        If ods1.Tables(0).Rows.Count = 1 Then

            Dim UserId As Guid = ods1.Tables(0).Rows(0).Item("UserId")


            Dim ods As New DataSet
            Dim oObjeto As New User_Profile

            ods = oObjeto.Usuarios_ModificarEstado(UserId, "cuenta activada")


            Dim ods2 As New DataSet
            Dim oObjeto2 As New User_Profile

            ods2 = oObjeto2.UsuariosSistema_ModificarEstado(UserId, True)

            Response.Redirect("frmCuentaExito.aspx")
        Else
            Response.Redirect("frmCuentaError.aspx")
        End If

    End Sub

End Class
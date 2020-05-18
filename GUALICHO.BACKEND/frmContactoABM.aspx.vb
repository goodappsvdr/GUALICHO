Imports GUALICHO.AD
Public Class frmContactoABM_aspx
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargarMenuRoles()
        If Page.IsPostBack = False Then
            CargarMarca()
            Status()
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

#Region "CONTACTO"

    Private Sub CargarMarca()



        Dim oDs As New DataSet
        Dim oObjeto As New Contacto

        oDs = oObjeto.BuscarTodos



        If oDs.Tables(0).Rows.Count > 0 Then
            lblTitulo.InnerHtml = "EDITAR CONTACTO"
            txtDireccion.Text = oDs.Tables(0).Rows(0).Item("Direccion")
            txtEmail.Text = oDs.Tables(0).Rows(0).Item("Email")
            txtTelefono.Text = oDs.Tables(0).Rows(0).Item("Telefono")

            Dim ods1 As New DataSet
            Dim oObjeto1 As New Contactos

            ods1 = oObjeto1.BuscarTodos

            TxtInstagram.Text = ods1.Tables(0).Rows(0).Item("Url")
            TxtFacebook.Text = ods1.Tables(0).Rows(1).Item("Url")


        End If
    End Sub

    Private Sub ModificarContacto()
        lblError.Text = ""

        If txtDireccion.Text <> "" And txtEmail.Text <> "" And txtTelefono.Text <> "" Then

            Dim mapa As String = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3399.7944019908473!2d-63.54453088440215!3d-31.557256581357382!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x94332a52b0c2e023%3A0xfd7692428bc88a58!2sHier%20Cons%20Sh!5e0!3m2!1ses!2sar!4v1575993824277!5m2!1ses!2sar"


            Dim oDs As New DataSet
            Dim oObjeto As New Contacto
            oDs = oObjeto.Modificar(txtDireccion.Text, txtEmail.Text, txtTelefono.Text, mapa)




            Dim oDs1 As New DataSet
            Dim oObjeto1 As New Contactos
            oDs1 = oObjeto1.ModificarInstagram(TxtInstagram.Text)


            Dim oDs2 As New DataSet
            Dim oObjeto2 As New Contactos
            oDs2 = oObjeto2.ModificarFacebook(TxtFacebook.Text)





            Dim tituloStatus As String
            tituloStatus = "CONTACTO MODIFICADO EXITOSAMENTE"

            Session.Add("status", 1)

            Session.Add("titulo", tituloStatus)
            Session.Add("imagen", "Imagenes/OkTickets.png")


        ElseIf txtDireccion.Text = "" Then
            lblError.Text = "INGRESE UNA DIRECCION"

        ElseIf txtEmail.Text = "" Then
            lblError.Text = "INGRESE UN EMAIL"

        ElseIf txtTelefono.Text = "" Then
            lblError.Text = "INGRESE UN TELEFONO"

        End If
    End Sub
    Protected Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.ServerClick



        ModificarContacto()

        If lblError.Text = "" Then



            Response.Redirect("frmContactoABM.aspx")


        End If



    End Sub


#End Region

#Region "Status"
    Public Sub Status()
        Dim status As String = Session("status")
        Dim titulo As String = Session("titulo")
        Dim imagen As String = Session("imagen")

        Session("status") = Nothing
        Session("titulo") = Nothing
        Session("imagen") = Nothing

        If status = 1 Then
            TituloStatusSpan.InnerText = titulo
            ImagenStatus.Src = imagen

            PanelControles.Visible = False
            PanelVolver.Visible = True

            DivStatus.Visible = True


        End If


    End Sub

    Private Sub btnVolver_ServerClick(sender As Object, e As System.EventArgs) Handles btnVolver.ServerClick
        Response.Redirect("FrmContactoABM.aspx")
    End Sub
#End Region


End Class
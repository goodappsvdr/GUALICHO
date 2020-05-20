Imports GUALICHO.AD
Public Class FrmServiciosABM
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        CargarMenuRoles()
        If Page.IsPostBack = False Then
            CargarServicio()
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
                'Men_Servicios.Visible = True
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

#Region "SERVICIOS"

    Private Sub CargarServicio()

        Dim ID As Integer = Request.QueryString("ID")



        Dim oDs As New DataSet
        Dim oObjeto As New Servicios

        oDs = oObjeto.BuscarPorID(ID)



        If oDs.Tables(0).Rows.Count > 0 Then
            lblTitulo.InnerHtml = "EDITAR SERVICIO"
            HfID_Servicio.Value = oDs.Tables(0).Rows(0).Item("ID_Servicio")
            TxtNombre.Text = oDs.Tables(0).Rows(0).Item("Nombre")
            TxtDescripcion.Text = oDs.Tables(0).Rows(0).Item("Descripcion")
            chkActivo.Checked = oDs.Tables(0).Rows(0).Item("Activo")

            btnNuevaImagenServicio.Visible = True
        Else
            lblTitulo.InnerHtml = "NUEVO SERVICIO"
            chkActivo.Checked = True
            btnNuevaImagenServicio.Visible = False
        End If
    End Sub
    Private Sub AgregarServicio()
        lblError.Text = ""
        If TxtDescripcion.Text <> "" Then

            Dim oDs As New DataSet
            Dim oObjeto As New Servicios

            oDs = oObjeto.Agregar(TxtNombre.Text, TxtDescripcion.Text, chkActivo.Checked)



            Dim tituloStatus As String
            tituloStatus = "SERVICIO AGREGADO EXITOSAMENTE"

            Session.Add("status", 1)

            Session.Add("titulo", tituloStatus)
            Session.Add("imagen", "Imagenes/OkTickets.png")


        ElseIf TxtDescripcion.Text = "" Then
            lblError.Text = "INGRESE UNA DESCRIPCIÓN"
        End If
    End Sub
    Private Sub ModificarServicio()
        lblError.Text = ""
        If TxtDescripcion.Text <> "" Then

            Dim oDs As New DataSet
            Dim oObjeto As New Servicios
            oDs = oObjeto.Modificar(HfID_Servicio.Value, TxtNombre.Text, TxtDescripcion.Text, chkActivo.Checked)


            Dim tituloStatus As String
            tituloStatus = "SERVICIO MODIFICADO EXITOSAMENTE"

            Session.Add("status", 1)

            Session.Add("titulo", tituloStatus)
            Session.Add("imagen", "Imagenes/OkTickets.png")


        ElseIf TxtDescripcion.Text = "" Then
            lblError.Text = "INGRESE UNA DESCRIPCIÓN"

        End If
    End Sub
    Protected Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click

        If HfID_Servicio.Value <> "" Then

            ModificarServicio()

            If lblError.Text = "" Then



                Response.Redirect("frmServiciosABM.aspx")


            End If

        ElseIf lblError.Text = "" Then

            AgregarServicio()

            If lblError.Text = "" Then

                Response.Redirect("frmServiciosABM.aspx")

            End If
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
        Response.Redirect("Frmservicios.aspx")
    End Sub

    Private Sub btnNuevaImagenServicio_Click(sender As Object, e As EventArgs) Handles btnNuevaImagenServicio.Click

        Dim id_servicio As String = Request.QueryString("ID")

        Response.Redirect("FrmImagenesServicios.aspx?ID=" & id_servicio)
    End Sub


#End Region



End Class
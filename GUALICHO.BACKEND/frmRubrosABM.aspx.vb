Imports GUALICHO.AD
Public Class frmRubrosABM
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Page.IsPostBack = False Then
            CargarMenuRoles()
            CargarRubros()
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


#Region "Rubros"
    Private Sub CargarRubros()
        Dim ID As Integer = Request.QueryString("ID")
        Dim oDs As New DataSet
        Dim oObjeto As New Rubros

        oDs = oObjeto.Rubros_BuscarPorID(ID)



        If oDs.Tables(0).Rows.Count > 0 Then

            lblTitulo.InnerText = "EDITAR RUBRO"
            HfID_Rubro.Value = oDs.Tables(0).Rows(0).Item("ID_Rubro")
            txtDescripcion.Text = oDs.Tables(0).Rows(0).Item("Descripcion")
            TxtOrden.Text = oDs.Tables(0).Rows(0).Item("Orden")
            chkActivo.Checked = oDs.Tables(0).Rows(0).Item("Estado")
            HfID_MenuWeb.Value = oDs.Tables(0).Rows(0).Item("ID_MenuWeb")

            TituloOrden.InnerText = "Orden"
        Else
            lblTitulo.InnerText = "NUEVO RUBRO"
            TituloOrden.InnerText = "Orden Sugerido"
            BuscarOrdenSugerido()
            chkActivo.Checked = True
        End If


    End Sub

    Private Sub BuscarOrdenSugerido()
        Dim ods As New DataSet
        Dim oObjeto As New Rubros

        ods = oObjeto.BuscarOrdenSugerido


        If ods.Tables(0).Rows.Count > 0 Then


            TxtOrden.Text = ods.Tables(0).Rows(0).Item("Orden").ToString + 1
        Else
            TxtOrden.Text = 1
        End If


    End Sub

    Private Sub AgregarRubro()
        lblError.Text = ""
        If txtDescripcion.Text <> "" Then

            Dim oDs As New DataSet
            Dim oObjeto As New Rubros

            Dim resultado As Integer
            resultado = oObjeto.Agregar(txtDescripcion.Text, "frmRubros.aspx", "NoImagen", TxtOrden.Text, chkActivo.Checked)


            Dim resultado2 As Integer
            Dim oDs2 As New DataSet
            Dim oObjeto2 As New MenuWeb
            Dim int As Nullable(Of Integer)
            resultado2 = oObjeto2.Agregar(txtDescripcion.Text, txtDescripcion.Text, txtDescripcion.Text, "frmRubros.aspx", 0, TxtOrden.Text, chkActivo.Checked, resultado, 0)

            Dim tituloStatus As String
            tituloStatus = "RUBRO AGREGADO EXITOSAMENTE"

            Session.Add("status", 1)

            Session.Add("titulo", tituloStatus)
            Session.Add("imagen", "Imagenes/OkTickets.png")


        ElseIf txtDescripcion.Text = "" Then
            lblError.Text = "INGRESE UNA DESCRIPCIÓN"
        End If
    End Sub
    Private Sub ModificarRubro()
        lblError.Text = ""
        If txtDescripcion.Text <> "" Then

            Dim oDs As New DataSet
            Dim oObjeto As New Rubros
            oDs = oObjeto.ModificarBEWeb(HfID_Rubro.Value, txtDescripcion.Text, "frmRubros.aspx", TxtOrden.Text, chkActivo.Checked)

            Dim oDs2 As New DataSet
            Dim oObjeto2 As New MenuWeb

            oDs2 = oObjeto2.Modificar(HfID_MenuWeb.Value, txtDescripcion.Text, txtDescripcion.Text, txtDescripcion.Text, "frmRubros.aspx", 0, TxtOrden.Text, chkActivo.Checked, HfID_Rubro.Value, 0)


            Dim tituloStatus As String
            tituloStatus = "RUBRO MODIFICADO EXITOSAMENTE"

            Session.Add("status", 1)

            Session.Add("titulo", tituloStatus)
            Session.Add("imagen", "Imagenes/OkTickets.png")


        ElseIf txtDescripcion.Text = "" Then
            lblError.Text = "INGRESE UNA DESCRIPCIÓN"

        End If
    End Sub
    Protected Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.ServerClick

        If HfID_Rubro.Value <> "" Then

            ModificarRubro()

            If lblError.Text = "" Then



                Response.Redirect("frmRubrosABM.aspx")


            End If

        ElseIf lblError.Text = "" Then

            AgregarRubro()

            If lblError.Text = "" Then

                Response.Redirect("frmRubrosABM.aspx")

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
        Response.Redirect("frmRubros.aspx")
    End Sub
#End Region


End Class
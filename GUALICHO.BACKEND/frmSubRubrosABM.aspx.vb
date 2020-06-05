Imports GUALICHO.AD

Public Class frmSubRubrosABM

    Inherits System.Web.UI.Page
    Dim id_subrubro As String
    Dim resultado2 As Integer
    Dim resultado As Integer
    Dim ID_MenuWeb As Integer
    Dim ID_MenuPadre As Integer = 0
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Page.IsPostBack = False Then
            CargarMenuRoles()
            CargarRubros()

            CargarSubRubros()

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


#Region "Rubros"
    Private Sub CargarSubRubros()
        Dim ID As Integer = Request.QueryString("ID")
        Dim oDs As New DataSet
        Dim oObjeto As New SubRubros

        oDs = oObjeto.SubRubros_BuscarPorID(ID)



        If oDs.Tables(0).Rows.Count > 0 Then


            lblTitulo.InnerText = "EDITAR SUBRUBRO"
            HfID_SubRubro.Value = oDs.Tables(0).Rows(0).Item("ID_SubRubro")
            txtDescripcion.Text = oDs.Tables(0).Rows(0).Item("Descripcion")
            TxtOrden.Text = oDs.Tables(0).Rows(0).Item("Orden")
            chkActivo.Checked = oDs.Tables(0).Rows(0).Item("Estado")
            ID_MenuWeb = oDs.Tables(0).Rows(0).Item("ID_MenuWeb")
            ID_MenuPadre = oDs.Tables(0).Rows(0).Item("ID_MenuPadre")
            CboRubro.SelectedValue = oDs.Tables(0).Rows(0).Item("ID_Rubro")

            TituloOrden.InnerText = "Orden"
        Else
            lblTitulo.InnerText = "NUEVO SUBRUBRO"
            TituloOrden.InnerText = "Orden Sugerido"
            BuscarOrdenSugerido()
            chkActivo.Checked = True
        End If


    End Sub


    Private Sub CargarRubros()
        Dim oDs As New DataSet
        Dim oObjeto As New Rubros
        oDs = oObjeto.BuscarTodos
        cboRubro.DataSource = oDs.Tables(0)
        cboRubro.DataTextField = "Descripcion"
        cboRubro.DataValueField = "ID_Rubro"
        cboRubro.DataBind()

    End Sub

    Private Sub BuscarOrdenSugerido()
        Dim ods As New DataSet
        Dim oObjeto As New SubRubros

        ods = oObjeto.BuscarOrdenSugeridoPorID_Rubro(CboRubro.SelectedValue)

        If ods.Tables(0).Rows.Count > 0 Then


            TxtOrden.Text = ods.Tables(0).Rows(0).Item("Orden").ToString + 1
        Else
            TxtOrden.Text = 1
        End If

    End Sub

    Private Sub AgregarSubRubro()
        Dim oDs As New DataSet
        Dim oObjeto As New SubRubros

        resultado = oObjeto.Agregar(cboRubro.SelectedValue, txtDescripcion.Text, "frmSubRubro.aspx", "a", TxtOrden.Text, chkActivo.Checked)
        id_subrubro = resultado

        Dim oDs2 As New DataSet
        Dim oObjeto2 As New MenuWeb
        If ID_MenuPadre = 0 Then
            Dim ods3 As New DataSet
            Dim oObjeto3 As New SubRubros
            ods3 = oObjeto3.SubRubros_BuscarID_MenuPadrePorID_Rubro(cboRubro.SelectedValue)
            ID_MenuPadre = ods3.Tables(0).Rows(0).Item("id_MenuWeb")
        End If
        resultado2 = oObjeto2.Agregar(txtDescripcion.Text, txtDescripcion.Text, txtDescripcion.Text, "frmSubRubro.aspx", ID_MenuPadre, TxtOrden.Text, chkActivo.Checked, cboRubro.SelectedValue, resultado)


            Dim tituloStatus As String
        tituloStatus = "SUB RUBRO AGREGADO EXITOSAMENTE"

            Session.Add("status", 1)

            Session.Add("titulo", tituloStatus)
            Session.Add("imagen", "Imagenes/OkTickets.png")


    End Sub
    Private Sub ModificarSubRubro()
        Dim oDs As New DataSet
        Dim oObjeto As New SubRubros
        oDs = oObjeto.Modificar(HfID_SubRubro.Value, cboRubro.SelectedValue, txtDescripcion.Text, "frmSubRubro.aspx", "a", TxtOrden.Text, chkActivo.Checked)


        If ID_MenuPadre = 0 Then
            Dim ods3 As New DataSet
            Dim oObjeto3 As New SubRubros
            ods3 = oObjeto3.SubRubros_BuscarID_MenuPadrePorID_Rubro(cboRubro.SelectedValue)
            ID_MenuPadre = ods3.Tables(0).Rows(0).Item("id_MenuWeb")
        End If




        Dim ID As Integer = Request.QueryString("ID")
        Dim oDs4 As New DataSet
        Dim oObjeto4 As New SubRubros

        oDs4 = oObjeto4.SubRubros_BuscarPorID(ID)

        ID_MenuWeb = oDs4.Tables(0).Rows(0).Item("ID_MenuWeb")

        Dim oDs2 As New DataSet
        Dim oObjeto2 As New MenuWeb

        oDs2 = oObjeto2.Modificar(ID_MenuWeb, txtDescripcion.Text, txtDescripcion.Text, txtDescripcion.Text, "frmSubRubro.aspx", ID_MenuPadre, TxtOrden.Text, chkActivo.Checked, cboRubro.SelectedValue, HfID_SubRubro.Value)

        Dim tituloStatus As String
        tituloStatus = "SUB RUBRO MODIFICADO EXITOSAMENTE"

        Session.Add("status", 1)

        Session.Add("titulo", tituloStatus)
        Session.Add("imagen", "Imagenes/OkTickets.png")



    End Sub

    Protected Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.ServerClick

           If HfID_SubRubro.Value <> "" Then

            ModificarSubRubro()
            If lblError.Text = "" Then
                Response.Redirect("FrmSubRubrosABM.aspx")
            End If

        ElseIf lblError.Text = "" Then
            AgregarSubRubro()
            If lblError.Text = "" Then
                Response.Redirect("FrmSubRubrosABM.aspx")
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
        Response.Redirect("frmSubRubros.aspx")
    End Sub
#End Region

    Private Sub CboRubro_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles CboRubro.SelectedIndexChanged
        BuscarOrdenSugerido()
    End Sub
End Class
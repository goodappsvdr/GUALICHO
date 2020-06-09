Imports GUALICHO.AD
Public Class frmBannersABM
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Page.IsPostBack = False Then
            CargarMenuRoles()
            CargarBanner()
            Status()
            TxtFechaFin.Text = Date.Now.ToString("yyyy-MM-dd")
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




#Region "BANNERS"
    Private Sub CargarBanner()
        Dim ID As Integer = Request.QueryString("ID")
        Dim oDs As New DataSet
        Dim oObjeto As New Banners

        oDs = oObjeto.BuscarPorID(ID)



        If oDs.Tables(0).Rows.Count > 0 Then
            ImgBanner.Visible = True
            lblTitulo.InnerText = "EDITAR PORTADA"
            HfID_Banner.Value = oDs.Tables(0).Rows(0).Item("ID_Banner")
            txtDescripcion.Text = oDs.Tables(0).Rows(0).Item("Descripcion")
            TxtFechaFin.Text = oDs.Tables(0).Rows(0).Item("FechaFin")
            ImgBanner.Src = oDs.Tables(0).Rows(0).Item("Imagen").ToString()


            chkActivo.Checked = oDs.Tables(0).Rows(0).Item("Activo")
        Else
            lblTitulo.InnerText = "NUEVA PORTADA"
            chkActivo.Checked = True
        End If


    End Sub


    Private Sub BtnAceptar_ServerClick(sender As Object, e As System.EventArgs) Handles BtnAceptar.Click

        If HfID_Banner.Value <> "" Then

            If btnSubirImg.HasFile = False Then
                ModificarBanner()
                Response.Redirect("frmBannersABM.aspx")
            Else
                ModificarBannerConImagen()
                Response.Redirect("frmBannersABM.aspx")
            End If


        Else
            AgregarBanner()
            Response.Redirect("frmBannersABM.aspx")
        End If



    End Sub

    Private Sub ModificarBanner()
        Dim oDs As New DataSet
        Dim oObjeto As New Banners
        oDs = oObjeto.ModificarBEWeb(HfID_Banner.Value, txtDescripcion.Text, TxtFechaFin.Text, chkActivo.Checked)

        Dim tituloStatus As String
        tituloStatus = "PORTADA MODIFICADA EXITOSAMENTE"

        Session.Add("status", 1)

        Session.Add("titulo", tituloStatus)
        Session.Add("imagen", "Imagenes/OkTickets.png")
    End Sub


    Private Sub ModificarBannerConImagen()
        Dim oDs As New DataSet
        Dim oObjeto As New Banners
        oDs = oObjeto.ModificarBEWeb(HfID_Banner.Value, txtDescripcion.Text, TxtFechaFin.Text, chkActivo.Checked)

        Dim urlImagen As String
        urlImagen = "https://cerveceriagualicho.com/Admin/Imagenes/Banners/"



        btnSubirImg.SaveAs(HttpContext.Current.Server.MapPath("./Imagenes/Banners/") & HfID_Banner.Value & ".png")




        urlImagen = urlImagen & HfID_Banner.Value & ".png"

        oDs = oObjeto.ModificarImagen(HfID_Banner.Value, urlImagen)

        Dim tituloStatus As String
        tituloStatus = "PORTADA MODIFICADA EXITOSAMENTE"

        Session.Add("status", 1)

        Session.Add("titulo", tituloStatus)
        Session.Add("imagen", "Imagenes/OkTickets.png")

    End Sub

    Private Sub AgregarBanner()

        If btnSubirImg.HasFile = True Then



            Dim oDs As New DataSet
            Dim oObjeto As New Banners

            Dim resultado As Integer
            Dim id_banner As String
            resultado = oObjeto.Agregar(txtDescripcion.Text, ".", TxtFechaFin.Text, chkActivo.Checked)
            id_banner = resultado


            Dim urlImagen As String
            urlImagen = "https://cerveceriagualicho.com/Admin/Imagenes/Banners/"


            btnSubirImg.SaveAs(HttpContext.Current.Server.MapPath("./Imagenes/Banners/") & id_banner & ".png")


            urlImagen = urlImagen & id_banner & ".png"

            oDs = oObjeto.ModificarImagen(id_banner, urlImagen)




            Dim tituloStatus As String
            tituloStatus = "PORTADA AGREGADA EXITOSAMENTE"

            Session.Add("status", 1)

            Session.Add("titulo", tituloStatus)
            Session.Add("imagen", "Imagenes/OkTickets.png")


        Else

            Dim tituloStatus As String
            tituloStatus = "POR FAVOR SELECCIONE UNA FOTO PARA SUBIR"

            Session.Add("status", 2)

            Session.Add("Descripcion", txtDescripcion.Text)
            Session.Add("FechaFin", TxtFechaFin.Text)

            Session.Add("titulo", tituloStatus)
            Session.Add("imagen", "Imagenes/IncorrectoTickets.png")
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
            lblTitulo.Visible = False

        End If

        If status = 2 Then
            TituloStatusSpan.InnerText = titulo
            ImagenStatus.Src = imagen


            DivStatus.Visible = True

            Dim descripcion As String = Session("Descripcion")
            Dim fecha As String = Session("FechaFin")
            Session("Descripcion") = Nothing
            Session("FechaFin") = Nothing

            txtDescripcion.Text = descripcion
            TxtFechaFin.Text = fecha
        End If



    End Sub

    Private Sub btnVolver_ServerClick(sender As Object, e As System.EventArgs) Handles btnVolver.ServerClick
        Response.Redirect("frmBanners.aspx")
    End Sub
#End Region
End Class
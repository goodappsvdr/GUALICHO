Imports GUALICHO.AD
Public Class frmImagenesNosotrosABM
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Page.IsPostBack = False Then
            CargarMenuRoles()
            CargarImgNosotros()
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




#Region "IMG NOSOTROS"
    Private Sub CargarImgNosotros()
        Dim ID As Integer = Request.QueryString("ID")
        Dim oDs As New DataSet
        Dim oObjeto As New ImagenesNosotros

        oDs = oObjeto.BuscarPorID(ID)



        If oDs.Tables(0).Rows.Count > 0 Then
            ImgBanner.Visible = True
            lblTitulo.InnerText = "EDITAR IMÁGENES DE LA FÁBRICA"
            HfID_ImagenesNosotros.Value = oDs.Tables(0).Rows(0).Item("ID_ImagenNosotros")

            ImgBanner.Src = oDs.Tables(0).Rows(0).Item("Imagen").ToString()


            chkActivo.Checked = oDs.Tables(0).Rows(0).Item("Activo")
        Else
            lblTitulo.InnerText = "NUEVO IMÁGENES DE LA FÁBRICA"
            chkActivo.Checked = True
        End If


    End Sub


    Private Sub BtnAceptar_ServerClick(sender As Object, e As System.EventArgs) Handles BtnAceptar.Click

        If HfID_ImagenesNosotros.Value <> "" Then

            If btnSubirImg.HasFile = False Then
                ModificarImgNosotros()
                Response.Redirect("frmImagenesNosotrosABM.aspx")
            Else
                ModificarImgNosotrosConImagen()
                Response.Redirect("frmImagenesNosotrosABM.aspx")
            End If


        Else
            AgregarImgNosotros()
            Response.Redirect("frmImagenesNosotrosABM.aspx")
        End If



    End Sub

    Private Sub ModificarImgNosotros()
        Dim oDs As New DataSet
        Dim oObjeto As New ImagenesNosotros
        oDs = oObjeto.Modificar(HfID_ImagenesNosotros.Value, chkActivo.Checked)

        Dim tituloStatus As String
        tituloStatus = "IMÁGEN DE LA FÁBRICA MODIFICADA EXITOSAMENTE"

        Session.Add("status", 1)

        Session.Add("titulo", tituloStatus)
        Session.Add("imagen", "Imagenes/OkTickets.png")
    End Sub


    Private Sub ModificarImgNosotrosConImagen()
        Dim oDs As New DataSet
        Dim oObjeto As New ImagenesNosotros
        oDs = oObjeto.Modificar(HfID_ImagenesNosotros.Value, chkActivo.Checked)

        Dim urlImagen As String
        urlImagen = "http://168.197.51.109/GUALICHO/Admin/Imagenes/ImagenesNosotros/"



        btnSubirImg.SaveAs(HttpContext.Current.Server.MapPath("./Imagenes/ImagenesNosotros/") & HfID_ImagenesNosotros.Value & ".png")




        urlImagen = urlImagen & HfID_ImagenesNosotros.Value & ".png"

        oDs = oObjeto.ModificarImagen(HfID_ImagenesNosotros.Value, urlImagen)

        Dim tituloStatus As String
        tituloStatus = "IMÁGEN DE LA FÁBRICA MODIFICADA EXITOSAMENTE"

        Session.Add("status", 1)

        Session.Add("titulo", tituloStatus)
        Session.Add("imagen", "Imagenes/OkTickets.png")

    End Sub

    Private Sub AgregarImgNosotros()

        If btnSubirImg.HasFile = True Then



            Dim oDs As New DataSet
            Dim oObjeto As New ImagenesNosotros
            Dim resultado As Integer
            Dim id_banner As String
            resultado = oObjeto.Agregar(".", chkActivo.Checked)
            id_banner = resultado


            Dim urlImagen As String
            urlImagen = "http://168.197.51.109/GUALICHO/Admin/Imagenes/ImagenesNosotros/"


            btnSubirImg.SaveAs(HttpContext.Current.Server.MapPath("./Imagenes/ImagenesNosotros/") & id_banner & ".png")


            urlImagen = urlImagen & id_banner & ".png"

            oDs = oObjeto.ModificarImagen(id_banner, urlImagen)




            Dim tituloStatus As String
            tituloStatus = "IMÁGEN DE LA FÁBRICA AGREGADA EXITOSAMENTE"

            Session.Add("status", 1)

            Session.Add("titulo", tituloStatus)
            Session.Add("imagen", "Imagenes/OkTickets.png")


        Else

            Dim tituloStatus As String
            tituloStatus = "POR FAVOR SELECCIONE UNA FOTO PARA SUBIR"

            Session.Add("status", 2)

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

        End If



    End Sub

    Private Sub btnVolver_ServerClick(sender As Object, e As System.EventArgs) Handles btnVolver.ServerClick
        Response.Redirect("frmNosotrosImagenes.aspx")
    End Sub
#End Region

End Class
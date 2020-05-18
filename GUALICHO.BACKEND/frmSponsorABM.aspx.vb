Imports GUALICHO.AD
Public Class frmSponsorABM
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack = False Then
            CargarMenuRoles()
            CargarBanner()
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




#Region "BANNERS"
    Private Sub CargarBanner()
        Dim ID As Integer = Request.QueryString("ID")
        Dim oDs As New DataSet
        Dim oObjeto As New Sponsors

        oDs = oObjeto.BuscarPorID(ID)



        If oDs.Tables(0).Rows.Count > 0 Then
            ImgSponsor.Visible = True
            lblTitulo.InnerText = "EDITAR SPONSOR"
            HfID_Sponsor.Value = oDs.Tables(0).Rows(0).Item("ID_Sponsor")
            txtDescripcion.Text = oDs.Tables(0).Rows(0).Item("Descripcion")

            ImgSponsor.Src = oDs.Tables(0).Rows(0).Item("Imagen").ToString()


            chkActivo.Checked = oDs.Tables(0).Rows(0).Item("Activo")
        Else
            lblTitulo.InnerText = "NUEVO SPONSOR"
            chkActivo.Checked = True
        End If


    End Sub


    Private Sub BtnAceptar_ServerClick(sender As Object, e As System.EventArgs) Handles BtnAceptar.Click

        If HfID_Sponsor.Value <> "" Then

            If btnSubirImg.HasFile = False Then
                ModificarSponsor()
                Response.Redirect("frmSponsorABM.aspx")
            Else
                ModificarSponsorConImagen()
                Response.Redirect("frmSponsorABM.aspx")
            End If


        Else
            AgregarBanner()
            Response.Redirect("frmSponsorABM.aspx")
        End If



    End Sub

    Private Sub ModificarSponsor()
        Dim oDs As New DataSet
        Dim oObjeto As New Sponsors
        oDs = oObjeto.ModificarBEWeb(HfID_Sponsor.Value, txtDescripcion.Text, chkActivo.Checked)

        Dim tituloStatus As String
        tituloStatus = "SPONSOR MODIFICADO EXITOSAMENTE"

        Session.Add("status", 1)

        Session.Add("titulo", tituloStatus)
        Session.Add("imagen", "Imagenes/OkTickets.png")
    End Sub


    Private Sub ModificarSponsorConImagen()
        Dim oDs As New DataSet
        Dim oObjeto As New Sponsors
        oDs = oObjeto.ModificarBEWeb(HfID_Sponsor.Value, txtDescripcion.Text, chkActivo.Checked)

        Dim urlImagen As String
        urlImagen = "http://www.hiercons.com.ar/Admin/Imagenes/Sponsors/"



        btnSubirImg.SaveAs(HttpContext.Current.Server.MapPath("./Imagenes/Sponsors/") & HfID_Sponsor.Value & ".png")




        urlImagen = urlImagen & HfID_Sponsor.Value & ".png"

        oDs = oObjeto.ModificarImagen(HfID_Sponsor.Value, urlImagen)

        Dim tituloStatus As String
        tituloStatus = "SPONSOR MODIFICADO EXITOSAMENTE"

        Session.Add("status", 1)

        Session.Add("titulo", tituloStatus)
        Session.Add("imagen", "Imagenes/OkTickets.png")

    End Sub

    Private Sub AgregarBanner()

        If btnSubirImg.HasFile = True Then



            Dim oDs As New DataSet
            Dim oObjeto As New Sponsors

            Dim resultado As Integer
            Dim id_sponsor As String
            resultado = oObjeto.Agregar(txtDescripcion.Text, ".", chkActivo.Checked)
            id_sponsor = resultado


            Dim urlImagen As String
            urlImagen = "http://www.hiercons.com.ar/Admin/Imagenes/Sponsors/"


            btnSubirImg.SaveAs(HttpContext.Current.Server.MapPath("./Imagenes/Sponsors/") & id_sponsor & ".png")


            urlImagen = urlImagen & id_sponsor & ".png"

            oDs = oObjeto.ModificarImagen(id_sponsor, urlImagen)




            Dim tituloStatus As String
            tituloStatus = "SPONSOR AGREGADO EXITOSAMENTE"

            Session.Add("status", 1)

            Session.Add("titulo", tituloStatus)
            Session.Add("imagen", "Imagenes/OkTickets.png")


        Else

            Dim tituloStatus As String
            tituloStatus = "POR FAVOR SELECCIONE UNA FOTO PARA SUBIR"

            Session.Add("status", 2)

            Session.Add("Descripcion", txtDescripcion.Text)

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
            Session("Descripcion") = Nothing

            txtDescripcion.Text = descripcion
        End If



    End Sub

    Private Sub btnVolver_ServerClick(sender As Object, e As System.EventArgs) Handles btnVolver.ServerClick
        Response.Redirect("frmSponsors.aspx")
    End Sub
#End Region
End Class
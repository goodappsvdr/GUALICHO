Imports GUALICHO.AD
Public Class frmNosotrosABM
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack = False Then
            CargarMenuRoles()
            CargarNosotros()
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


#Region "Nosotros"
    Private Sub CargarNosotros()

        Dim oDs As New DataSet
        Dim oObjeto As New Nosotros

        oDs = oObjeto.BuscarTodos





        lblTitulo.InnerText = "EDITAR NOSOTROS"

        TxtTitulo.Text = oDs.Tables(0).Rows(0).Item("titulo").ToString
        TxtDescripcionPrinicipal.Text = oDs.Tables(0).Rows(0).Item("DescripcionPrincipal").ToString
        TxtDescripcionSecundaria.Text = oDs.Tables(0).Rows(0).Item("DescripcionSecundaria").ToString

        ImgQS.Src = oDs.Tables(0).Rows(0).Item("Imagen").ToString


    End Sub




    Private Sub ModificarQuienesSomos()
        lblError.Text = ""
        If TxtTitulo.Text <> "" Then

            Dim oDs As New DataSet
            Dim oObjeto As New Nosotros
            oDs = oObjeto.Modificar(TxtTitulo.Text, TxtDescripcionPrinicipal.Text, TxtDescripcionSecundaria.Text)



            Dim tituloStatus As String
            tituloStatus = "NOSOTROS SOMOS MODIFICADO EXITOSAMENTE"

            Session.Add("status", 1)

            Session.Add("titulo", tituloStatus)
            Session.Add("imagen", "Imagenes/OkTickets.png")


        ElseIf TxtTitulo.Text = "" Then
            lblError.Text = "INGRESE UNA TÍTULO"

        End If
    End Sub


    Private Sub ModificarQuienesSomosconImagen()
        Dim oDs As New DataSet
        Dim oObjeto As New Nosotros
        oDs = oObjeto.Modificar(TxtTitulo.Text, TxtDescripcionPrinicipal.Text, TxtDescripcionSecundaria.Text)


        Dim urlImagen As String
        urlImagen = "http://168.197.51.109/GUALICHO/Admin/Imagenes/Nostros/"



        btnSubirImg.SaveAs(HttpContext.Current.Server.MapPath("./Imagenes/Nosotros/") & "Nosotros" & ".png")




        urlImagen = urlImagen & "Nosotros" & ".png"

        oDs = oObjeto.ModificarImagen(urlImagen)

        Dim tituloStatus As String
        tituloStatus = "NOSOTROS MODIFICADO EXITOSAMENTE"

        Session.Add("status", 1)

        Session.Add("titulo", tituloStatus)
        Session.Add("imagen", "Imagenes/OkTickets.png")

    End Sub

    Protected Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click



        If btnSubirImg.HasFile = False Then
            ModificarQuienesSomos()
            Response.Redirect("frmNosotrosABM.aspx")
        Else
            ModificarQuienesSomosconImagen()
            Response.Redirect("frmNosotrosABM.aspx")
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
        Response.Redirect("frmNosotrosABM.aspx")
    End Sub

    Private Sub btnNosotrosImagenes_Click(sender As Object, e As EventArgs) Handles btnNosotrosImagenes.Click
        Response.Redirect("frmNosotrosImagenes.aspx")
    End Sub
#End Region
End Class
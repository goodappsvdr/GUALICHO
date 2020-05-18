Imports GUALICHO.AD
Public Class frmImagenesServiciosABM
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack = False Then
            CargarMenuRoles()
            CargarImgServicio()
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
    Private Sub CargarImgServicio()

        Dim Action As String = Request.QueryString("Action")
        Dim ID_Servicio As Integer = Request.QueryString("ID_Servicio")


        If Action = "Modificar" Then


            Dim ID_Imagen As Integer = Request.QueryString("ID_Imagen")



            Dim oDs As New DataSet
            Dim oObjeto As New ImagenesServicios

            oDs = oObjeto.BuscarPorID(ID_Imagen)



            If oDs.Tables(0).Rows.Count > 0 Then

                Dim ods1 As New DataSet
                Dim oObjeto1 As New Servicios
                ods1 = oObjeto1.BuscarPorID(ID_Servicio)



                ImgServicio.Visible = True
                lblTitulo.InnerHtml = "EDITAR IMÁGEN SERVICIO: <b>" & ods1.Tables(0).Rows(0).Item("Nombre").ToString & "</b>"
                HfID_ImagenesServicios.Value = oDs.Tables(0).Rows(0).Item("ID_ImagenServicio")

                ImgServicio.Src = oDs.Tables(0).Rows(0).Item("Imagen").ToString()


                chkActivo.Checked = oDs.Tables(0).Rows(0).Item("Activo")
            Else
                Dim ods1 As New DataSet
                Dim oObjeto1 As New Servicios
                ods1 = oObjeto1.BuscarPorID(ID_Servicio)




                lblTitulo.InnerHtml = "NUEVA IMÁGEN SERVICIO: <b>" & ods1.Tables(0).Rows(0).Item("Nombre").ToString & "</b>"
                chkActivo.Checked = True
            End If
        Else

            Dim ods1 As New DataSet
            Dim oObjeto1 As New Servicios
            ods1 = oObjeto1.BuscarPorID(ID_Servicio)




            lblTitulo.InnerHtml = "NUEVA IMÁGEN SERVICIO: <b>" & ods1.Tables(0).Rows(0).Item("Nombre").ToString & "</b>"
            chkActivo.Checked = True



        End If

    End Sub


    Private Sub BtnAceptar_ServerClick(sender As Object, e As System.EventArgs) Handles BtnAceptar.Click


        Dim ID_Servicio As Integer = Request.QueryString("ID_Servicio")


        If HfID_ImagenesServicios.Value <> "" Then

            If btnSubirImg.HasFile = False Then
                ModificarImgServicios()
                Response.Redirect("frmImagenesServiciosABM.aspx?ID_Servicio=" & ID_Servicio & "&Action=" & "Modificar")
            Else
                ModificarImgServiciosConImagen()
                Response.Redirect("frmImagenesServiciosABM.aspx?ID_Servicio=" & ID_Servicio & "&Action=" & "Modificar")
            End If


        Else
            AgregarImgNosotros()
            Response.Redirect("frmImagenesServiciosABM.aspx?ID_Servicio=" & ID_Servicio & "&Action=" & "Nuevo")
        End If



    End Sub

    Private Sub ModificarImgServicios()




        Dim ID_Servicio As Integer = Request.QueryString("ID_Servicio")



        Dim oDs As New DataSet
        Dim oObjeto As New ImagenesServicios
        oDs = oObjeto.Modificar(HfID_ImagenesServicios.Value, ID_Servicio, chkActivo.Checked)

        Dim tituloStatus As String
        tituloStatus = "IMÁGEN SERVICIO MODIFICADA EXITOSAMENTE"

        Session.Add("status", 1)

        Session.Add("titulo", tituloStatus)
        Session.Add("imagen", "Imagenes/OkTickets.png")
    End Sub


    Private Sub ModificarImgServiciosConImagen()


        Dim ID_Servicio As Integer = Request.QueryString("ID_Servicio")



        Dim oDs As New DataSet
        Dim oObjeto As New ImagenesServicios
        oDs = oObjeto.Modificar(HfID_ImagenesServicios.Value, ID_Servicio, chkActivo.Checked)

        Dim urlImagen As String
        urlImagen = "http://www.hiercons.com.ar/Admin/Imagenes/ImagenesServicios/"
        'urlImagen = "http://www.hiercons.com.ar/Admin/Imagenes/ImagenesServicios/"


        btnSubirImg.SaveAs(HttpContext.Current.Server.MapPath("./Imagenes/ImagenesServicios/") & HfID_ImagenesServicios.Value & ".png")




        urlImagen = urlImagen & HfID_ImagenesServicios.Value & ".png"

        oDs = oObjeto.ModificarImagen(HfID_ImagenesServicios.Value, urlImagen)

        Dim tituloStatus As String
        tituloStatus = "IMÁGEN SERVICIO MODIFICADA EXITOSAMENTE"

        Session.Add("status", 1)

        Session.Add("titulo", tituloStatus)
        Session.Add("imagen", "Imagenes/OkTickets.png")

    End Sub

    Private Sub AgregarImgNosotros()

        If btnSubirImg.HasFile = True Then


            Dim ID_Servicio As Integer = Request.QueryString("ID_Servicio")



            Dim oDs As New DataSet
            Dim oObjeto As New ImagenesServicios
            Dim resultado As Integer
            Dim id_imagenservicio As String
            resultado = oObjeto.Agregar(ID_Servicio, ".", chkActivo.Checked)
            id_imagenservicio = resultado


            Dim urlImagen As String
            urlImagen = "http://www.hiercons.com.ar/Admin/Imagenes/ImagenesServicios/"


            btnSubirImg.SaveAs(HttpContext.Current.Server.MapPath("./Imagenes/ImagenesServicios/") & id_imagenservicio & ".png")


            urlImagen = urlImagen & id_imagenservicio & ".png"

            oDs = oObjeto.ModificarImagen(id_imagenservicio, urlImagen)




            Dim tituloStatus As String
            tituloStatus = "IMÁGEN SERVICIO AGREGADA EXITOSAMENTE"

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
            TituloStatusSpan.InnerHtml = titulo
            ImagenStatus.Src = imagen

            PanelControles.Visible = False
            PanelVolver.Visible = True

            DivStatus.Visible = True
            lblTitulo.Visible = False

        End If

        If status = 2 Then
            TituloStatusSpan.InnerHtml = titulo
            ImagenStatus.Src = imagen


            DivStatus.Visible = True

            Dim descripcion As String = Session("Descripcion")
            Dim fecha As String = Session("FechaFin")
            Session("Descripcion") = Nothing
            Session("FechaFin") = Nothing

        End If



    End Sub

    Private Sub btnVolver_ServerClick(sender As Object, e As System.EventArgs) Handles btnVolver.ServerClick





        Response.Redirect("frmServicios.aspx")
    End Sub
#End Region

End Class
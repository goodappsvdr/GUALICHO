Imports HIERCONS.AD
Public Class frmItemImagenesABM
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack = False Then
            CargarMenuRoles()
            CargarItemImagen()
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

#Region "ItemImagenes"
   

    Private Sub CargarItemImagen()
        Dim ID As Integer = Request.QueryString("ID")
        Dim oDs As New DataSet
        Dim oObjeto As New ItemsImagenes

        Dim oObjeto1 As New Items
        oDs = oObjeto1.BuscarPorID(ID)



        If oDs.Tables(0).Rows.Count > 0 Then
            lblItem.InnerText = oDs.Tables(0).Rows(0).Item("Descripcion").ToString
            ImagenPrincipal.Src = oDs.Tables(0).Rows(0).Item("Imagen").ToString


            oDs = oObjeto.ItemsImagenes_BuscarPorID_Item(ID)

        End If

        If oDs.Tables(0).Rows.Count > 0 Then

            Try


                If oDs.Tables(0).Rows(0).Item("Imagen").ToString <> "" And oDs.Tables(0).Rows(0).Item("Activo").ToString = True Then
                    Imagen1.Src = oDs.Tables(0).Rows(0).Item("Imagen").ToString
                    chkActivoImagen1.Checked = True
                End If

                If oDs.Tables(0).Rows(1).Item("Imagen").ToString <> "" And oDs.Tables(0).Rows(1).Item("Activo").ToString = True Then
                    Imagen2.Src = oDs.Tables(0).Rows(1).Item("Imagen").ToString
                    chkActivoImagen2.Checked = True
                End If

                If oDs.Tables(0).Rows(2).Item("Imagen").ToString <> "" And oDs.Tables(0).Rows(2).Item("Activo").ToString = True Then
                    Imagen3.Src = oDs.Tables(0).Rows(2).Item("Imagen").ToString
                    chkActivoImagen3.Checked = True
                End If



                If oDs.Tables(0).Rows(3).Item("Imagen").ToString <> "" And oDs.Tables(0).Rows(3).Item("Activo").ToString = True Then
                    Imagen4.Src = oDs.Tables(0).Rows(3).Item("Imagen").ToString
                    chkActivoImagen4.Checked = True
                End If
            Catch ex As Exception
            End Try
        End If

    End Sub

    Dim i1 As Boolean
    Dim i2 As Boolean
    Dim i3 As Boolean
    Dim i4 As Boolean
    Private Sub cmdAceptar_ServerClick(sender As Object, e As System.EventArgs) Handles cmdAceptar.ServerClick

        Img1()
        Img2()
        Img3()
        Img4()

        If i1 = True And i2 = False And i3 = False And i4 = False Then

            Dim tituloStatus As String
            tituloStatus = "IMAGEN 1 AGREGADA EXITOSAMENTE"

            Session.Add("status", 1)

            Session.Add("titulo", tituloStatus)
            Session.Add("imagen", "Imagenes/OkTickets.png")
            Response.Redirect("frmItemImagenesABM.aspx")
        End If

        If i1 = True And i2 = True And i3 = False And i4 = False Then

            Dim tituloStatus As String
            tituloStatus = "IMAGEN 1 y 2 AGREGADAS EXITOSAMENTE"

            Session.Add("status", 1)

            Session.Add("titulo", tituloStatus)
            Session.Add("imagen", "Imagenes/OkTickets.png")
            Response.Redirect("frmItemImagenesABM.aspx")
        End If



        If i1 = True And i2 = True And i3 = True And i4 = False Then

            Dim tituloStatus As String
            tituloStatus = "IMAGEN 1, 2 y 3 AGREGADAS EXITOSAMENTE"

            Session.Add("status", 1)

            Session.Add("titulo", tituloStatus)
            Session.Add("imagen", "Imagenes/OkTickets.png")
            Response.Redirect("frmItemImagenesABM.aspx")
        End If



        If i1 = True And i2 = True And i3 = True And i4 = True Then

            Dim tituloStatus As String
            tituloStatus = "IMAGEN 1, 2, 3 y 4 AGREGADAS EXITOSAMENTE"

            Session.Add("status", 1)

            Session.Add("titulo", tituloStatus)
            Session.Add("imagen", "Imagenes/OkTickets.png")
            Response.Redirect("frmItemImagenesABM.aspx")
        End If


        If i1 = True And i2 = False And i3 = True And i4 = False Then

            Dim tituloStatus As String
            tituloStatus = "IMAGEN 1 y 3 AGREGADAS EXITOSAMENTE"

            Session.Add("status", 1)

            Session.Add("titulo", tituloStatus)
            Session.Add("imagen", "Imagenes/OkTickets.png")
            Response.Redirect("frmItemImagenesABM.aspx")
        End If


        If i1 = True And i2 = False And i3 = False And i4 = True Then

            Dim tituloStatus As String
            tituloStatus = "IMAGEN 1 y 4 AGREGADAS EXITOSAMENTE"

            Session.Add("status", 1)

            Session.Add("titulo", tituloStatus)
            Session.Add("imagen", "Imagenes/OkTickets.png")
            Response.Redirect("frmItemImagenesABM.aspx")
        End If












        If i1 = False And i2 = True And i3 = False And i4 = False Then

            Dim tituloStatus As String
            tituloStatus = "IMAGEN 2 AGREGADA EXITOSAMENTE"

            Session.Add("status", 1)

            Session.Add("titulo", tituloStatus)
            Session.Add("imagen", "Imagenes/OkTickets.png")
            Response.Redirect("frmItemImagenesABM.aspx")
        End If

        If i1 = False And i2 = True And i3 = True And i4 = False Then

            Dim tituloStatus As String
            tituloStatus = "IMAGEN 2 y 3 AGREGADAS EXITOSAMENTE"

            Session.Add("status", 1)

            Session.Add("titulo", tituloStatus)
            Session.Add("imagen", "Imagenes/OkTickets.png")
            Response.Redirect("frmItemImagenesABM.aspx")
        End If

        If i1 = False And i2 = True And i3 = True And i4 = True Then

            Dim tituloStatus As String
            tituloStatus = "IMAGEN 2,3 y 4 AGREGADAS EXITOSAMENTE"

            Session.Add("status", 1)

            Session.Add("titulo", tituloStatus)
            Session.Add("imagen", "Imagenes/OkTickets.png")
            Response.Redirect("frmItemImagenesABM.aspx")
        End If

        If i1 = False And i2 = True And i3 = False And i4 = True Then

            Dim tituloStatus As String
            tituloStatus = "IMAGEN 2 y 4 AGREGADAS EXITOSAMENTE"

            Session.Add("status", 1)

            Session.Add("titulo", tituloStatus)
            Session.Add("imagen", "Imagenes/OkTickets.png")
            Response.Redirect("frmItemImagenesABM.aspx")
        End If








        If i1 = False And i2 = False And i3 = True And i4 = False Then

            Dim tituloStatus As String
            tituloStatus = "IMAGEN 3 AGREGADA EXITOSAMENTE"

            Session.Add("status", 1)

            Session.Add("titulo", tituloStatus)
            Session.Add("imagen", "Imagenes/OkTickets.png")
            Response.Redirect("frmItemImagenesABM.aspx")
        End If


        If i1 = False And i2 = False And i3 = True And i4 = True Then

            Dim tituloStatus As String
            tituloStatus = "IMAGEN 3 y 4 AGREGADAS EXITOSAMENTE"

            Session.Add("status", 1)

            Session.Add("titulo", tituloStatus)
            Session.Add("imagen", "Imagenes/OkTickets.png")
            Response.Redirect("frmItemImagenesABM.aspx")
        End If



        If i1 = False And i2 = False And i3 = False And i4 = True Then

            Dim tituloStatus As String
            tituloStatus = "IMAGEN 4 AGREGADA EXITOSAMENTE"

            Session.Add("status", 1)

            Session.Add("titulo", tituloStatus)
            Session.Add("imagen", "Imagenes/OkTickets.png")

            Response.Redirect("frmItemImagenesABM.aspx")
        End If






    End Sub

    Private Sub Img1()
        If btnSubirImg1.HasFile = True Then



            Dim oDs As New DataSet
            Dim oObjeto As New ItemsImagenes

            Dim ID As Integer = Request.QueryString("ID")
            Dim id_itemImagen As Integer

            Dim resultado As Integer
            resultado = oObjeto.Agregar(ID, "NoImagen", chkActivoImagen1.Checked)
            id_itemImagen = resultado

            Dim urlImagen As String
            urlImagen = "http://www.hiercons.com.ar/Admin/Imagenes/ItemsImagenes/"

            btnSubirImg1.SaveAs(HttpContext.Current.Server.MapPath("./Imagenes/ItemsImagenes/") & id_itemImagen & ".png")


            urlImagen = urlImagen & id_itemImagen & ".png"

            oDs = oObjeto.ModificarImagen(id_itemImagen, urlImagen)

            i1 = True
        End If
    End Sub

    Private Sub Img2()
        If btnSubirImg2.HasFile = True Then



            Dim oDs As New DataSet
            Dim oObjeto As New ItemsImagenes

            Dim ID As Integer = Request.QueryString("ID")
            Dim id_itemImagen As Integer

            Dim resultado As Integer
            resultado = oObjeto.Agregar(ID, "NoImagen", chkActivoImagen2.Checked)
            id_itemImagen = resultado

            Dim urlImagen As String
            urlImagen = "http://www.hiercons.com.ar/Admin/Imagenes/ItemsImagenes/"

            btnSubirImg2.SaveAs(HttpContext.Current.Server.MapPath("./Imagenes/ItemsImagenes/") & id_itemImagen & ".png")


            urlImagen = urlImagen & id_itemImagen & ".png"

            oDs = oObjeto.ModificarImagen(id_itemImagen, urlImagen)
            i2 = True

        End If
    End Sub

    Private Sub Img3()
        If btnSubirImg3.HasFile = True Then



            Dim oDs As New DataSet
            Dim oObjeto As New ItemsImagenes

            Dim ID As Integer = Request.QueryString("ID")
            Dim id_itemImagen As Integer

            Dim resultado As Integer
            resultado = oObjeto.Agregar(ID, "NoImagen", chkActivoImagen3.Checked)
            id_itemImagen = resultado

            Dim urlImagen As String
            urlImagen = "http://www.hiercons.com.ar/Admin/Imagenes/ItemsImagenes/"

            btnSubirImg3.SaveAs(HttpContext.Current.Server.MapPath("./Imagenes/ItemsImagenes/") & id_itemImagen & ".png")


            urlImagen = urlImagen & id_itemImagen & ".png"

            oDs = oObjeto.ModificarImagen(id_itemImagen, urlImagen)

            i3 = True
        End If
    End Sub

    Private Sub Img4()
        If btnSubirImg4.HasFile = True Then



            Dim oDs As New DataSet
            Dim oObjeto As New ItemsImagenes

            Dim ID As Integer = Request.QueryString("ID")
            Dim id_itemImagen As Integer

            Dim resultado As Integer
            resultado = oObjeto.Agregar(ID, "NoImagen", chkActivoImagen4.Checked)
            id_itemImagen = resultado

            Dim urlImagen As String
            urlImagen = "http://www.hiercons.com.ar/Admin/Imagenes/ItemsImagenes/"

            btnSubirImg4.SaveAs(HttpContext.Current.Server.MapPath("./Imagenes/ItemsImagenes/") & id_itemImagen & ".png")


            urlImagen = urlImagen & id_itemImagen & ".png"

            oDs = oObjeto.ModificarImagen(id_itemImagen, urlImagen)

            i4 = True
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
        Response.Redirect("FrmItemImagenes.aspx")
    End Sub
#End Region
End Class
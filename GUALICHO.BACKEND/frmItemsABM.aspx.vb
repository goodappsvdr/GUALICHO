Imports GUALICHO.AD
Public Class frmItemsABM
    Inherits System.Web.UI.Page
    Dim id_item As String
    Dim resultado As Integer
    Dim TipoItem As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargarMenuRoles()
        If Page.IsPostBack = False Then
            CargarRubros()
            cargarmarcas()
            CargarITem()

            Status()
        Else

        End If
    End Sub
#Region "LOGIN"
    Protected Sub CerrarSesion(sender As Object, e As EventArgs)
        FormsAuthentication.SignOut()
        Roles.DeleteCookie()
        Session.Clear()
        Response.Redirect("frmlogin.aspx")
    End Sub
#End Region

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


#Region "ITEMS"
    Private Sub CargarRubros()
        Dim oDs As New DataSet
        Dim oObjeto As New Rubros
        oDs = oObjeto.BuscarTodos
        CboRubro.DataSource = oDs.Tables(0)
        CboRubro.DataTextField = "Descripcion"
        CboRubro.DataValueField = "ID_Rubro"
        CboRubro.DataBind()

        CargarSubRubros(CboRubro.SelectedValue)

    End Sub

    Private Sub CargarSubRubros(ByVal id_rubro As Integer)
        CboSubRubro.Items.Clear()
        Dim oDs As New DataSet
        Dim oObjeto As New SubRubros
        oDs = oObjeto.Subrubros_BuscarPorID_Rubro(id_rubro)
        CboSubRubro.DataSource = oDs.Tables(0)
        CboSubRubro.DataTextField = "DescripcionSubRubro"
        CboSubRubro.DataValueField = "ID_SubRubro"
        CboSubRubro.DataBind()

    End Sub

    Private Sub cargarMarcas()
        Dim oDs As New DataSet
        Dim oObjeto As New Marcas
        oDs = oObjeto.BuscarTodos
        CboMarca.DataSource = oDs.Tables(1)
        CboMarca.DataTextField = "Descripcion"
        CboMarca.DataValueField = "ID_Marca"
        CboMarca.DataBind()
    End Sub

    Private Sub CargarITem()
        Dim ID As Integer = Request.QueryString("ID")
        Dim oDs As New DataSet
        Dim oObjeto As New Items

        oDs = oObjeto.BuscarPorID(ID)



        If oDs.Tables(0).Rows.Count > 0 Then
            ImgItem.Visible = True
            lblTitulo.InnerText = "EDITAR PRODUCTO"
            HfID_Item.Value = oDs.Tables(0).Rows(0).Item("ID_Item")
            TxtDescripcion.Text = oDs.Tables(0).Rows(0).Item("Descripcion")
            txtDetalle.Text = oDs.Tables(0).Rows(0).Item("Detalle")

            TxtStock.Text = oDs.Tables(0).Rows(0).Item("StockActual")
            CboMarca.SelectedValue = oDs.Tables(0).Rows(0).Item("ID_Marca")
            chkActivo.Checked = oDs.Tables(0).Rows(0).Item("Activo")
            TipoItemRadioButon.SelectedValue = oDs.Tables(0).Rows(0).Item("ID_TipoItem")
            TxtObservaciones.Text = oDs.Tables(0).Rows(0).Item("Extendida")


            ImgItem.Src = oDs.Tables(0).Rows(0).Item("Imagen").ToString()
           
            Dim oDs2 As New DataSet
            Dim oObjeto2 As New ItemsPrecios

            oDs2 = oObjeto2.BuscarPorID_Item(HfID_Item.Value)
            TxtPrecio.Text = oDs2.Tables(0).Rows(0).Item("Valor")

            Dim oDs3 As New DataSet
            Dim oObjeto3 As New ItemsRubros

            oDs3 = oObjeto3.ItemsRubros_BuscarPorID_Item(HfID_Item.Value)
            CboRubro.SelectedValue = oDs3.Tables(0).Rows(0).Item("ID_Rubro")
            CargarSubRubros(CboRubro.SelectedValue)
            CboSubRubro.SelectedValue = oDs3.Tables(0).Rows(0).Item("ID_SubRubro")
        Else
            lblTitulo.InnerText = "NUEVO PRODUCTO"
            chkActivo.Checked = True
        End If
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As System.EventArgs) Handles BtnAceptar.Click
        If HfID_Item.Value <> "" Then
            If btnSubirImg.HasFile = False Then
                ModificarItem()
                Response.Redirect("frmItemsABM.aspx")
            Else
                ModificarItemConImagen()
                Response.Redirect("frmItemsABM.aspx")
            End If

        Else
            Agregaritem()
            Response.Redirect("frmItemsABM.aspx")

        End If
    End Sub


    Private Sub Agregaritem()
        Dim tituloStatus As String



        If TxtDescripcion.Text <> "" And TxtDetalle.Text <> "" And TxtPrecio.Text <> "" And TxtStock.Text <> "" And btnSubirImg.HasFile = True Then


            AgregarItemTrue()

        ElseIf TxtDescripcion.Text = "" Then


            tituloStatus = "PASO 1: POR FAVOR ESCRIBA UN TÍTULO PARA EL PRODUCTO"
            Session.Add("status", 2)
            Session.Add("titulo", tituloStatus)
            Session.Add("imagen", "Imagenes/IncorrectoTickets.png")

            Session.Add("Rubro", CboRubro.SelectedValue)
            Session.Add("SubRubro", CboSubRubro.SelectedValue)
            Session.Add("Marca", CboMarca.SelectedValue)

            'Session.Add("Descripcion", TxtDescripcion.Text)
            Session.Add("Detalle", TxtDetalle.Text)
            Session.Add("Observaciones", TxtObservaciones.Text)
            Session.Add("Precio", TxtPrecio.Text)
            Session.Add("Stock", TxtStock.Text)


            Session.Add("EstadoItem", TipoItemRadioButon.SelectedValue.ToString())
            Session.Add("Activo", chkActivo.Checked)

        ElseIf TxtDetalle.Text = "" Then

            tituloStatus = "PASO 1: POR FAVOR ESCRIBA UN DETALLE PARA EL PRODUCTO"
            Session.Add("status", 2)
            Session.Add("titulo", tituloStatus)
            Session.Add("imagen", "Imagenes/IncorrectoTickets.png")


            Session.Add("Rubro", CboRubro.SelectedValue)
            Session.Add("SubRubro", CboSubRubro.SelectedValue)
            Session.Add("Marca", CboMarca.SelectedValue)

            Session.Add("Descripcion", TxtDescripcion.Text)
            'Session.Add("Detalle", TxtDetalle.Text)
            Session.Add("Observaciones", TxtObservaciones.Text)
            Session.Add("Precio", TxtPrecio.Text)
            Session.Add("Stock", TxtStock.Text)


            Session.Add("EstadoItem", TipoItemRadioButon.SelectedValue.ToString())
            Session.Add("Activo", chkActivo.Checked)

        ElseIf TxtPrecio.Text = "" Then

            tituloStatus = "PASO 2: POR FAVOR ESCRIBA UN PRECIO PARA EL PRODUCTO"
            Session.Add("status", 2)
            Session.Add("titulo", tituloStatus)
            Session.Add("imagen", "Imagenes/IncorrectoTickets.png")

            Session.Add("Rubro", CboRubro.SelectedValue)
            Session.Add("SubRubro", CboSubRubro.SelectedValue)
            Session.Add("Marca", CboMarca.SelectedValue)

            Session.Add("Descripcion", TxtDescripcion.Text)
            Session.Add("Detalle", TxtDetalle.Text)
            Session.Add("Observaciones", TxtObservaciones.Text)
            'Session.Add("Precio", TxtPrecio.Text)
            Session.Add("Stock", TxtStock.Text)


            Session.Add("EstadoItem", TipoItemRadioButon.SelectedValue.ToString())
            Session.Add("Activo", chkActivo.Checked)

        ElseIf TxtStock.Text = "" Then

            tituloStatus = "PASO 2: POR FAVOR ESCRIBA UN STOCK PARA EL PRODUCTO"
            Session.Add("status", 2)
            Session.Add("titulo", tituloStatus)
            Session.Add("imagen", "Imagenes/IncorrectoTickets.png")

            Session.Add("Rubro", CboRubro.SelectedValue)
            Session.Add("SubRubro", CboSubRubro.SelectedValue)
            Session.Add("Marca", CboMarca.SelectedValue)

            Session.Add("Descripcion", TxtDescripcion.Text)
            Session.Add("Detalle", TxtDetalle.Text)
            Session.Add("Observaciones", TxtObservaciones.Text)
            Session.Add("Precio", TxtPrecio.Text)
            'Session.Add("Stock", TxtStock.Text)


            Session.Add("EstadoItem", TipoItemRadioButon.SelectedValue.ToString())
            Session.Add("Activo", chkActivo.Checked)

        ElseIf btnSubirImg.HasFile = False Then
            tituloStatus = "PASO 3: POR FAVOR SELECCIONE UNA FOTO PARA SUBIR"

            Session.Add("status", 2)

            Session.Add("Rubro", CboRubro.SelectedValue)
            Session.Add("SubRubro", CboSubRubro.SelectedValue)
            Session.Add("Marca", CboMarca.SelectedValue)

            Session.Add("Descripcion", TxtDescripcion.Text)
            Session.Add("Detalle", TxtDetalle.Text)
            Session.Add("Observaciones", TxtObservaciones.Text)
            Session.Add("Precio", TxtPrecio.Text)
            Session.Add("Stock", TxtStock.Text)


            Session.Add("EstadoItem", TipoItemRadioButon.SelectedValue.ToString())
            Session.Add("Activo", chkActivo.Checked)

            Session.Add("titulo", tituloStatus)
            Session.Add("imagen", "Imagenes/IncorrectoTickets.png")

        End If




    End Sub

    Private Sub AgregarItemTrue()
        Dim oDs As New DataSet
        Dim oObjeto As New Items
        Dim Stock As Integer = 0

        TipoItem = TipoItemRadioButon.SelectedValue.ToString()
        resultado = oObjeto.Agregar(TxtDescripcion.Text, TxtDetalle.Text, TxtObservaciones.Text, "NoImagen", "frmDetalleProducto.aspx", TxtStock.Text, "1", CboMarca.SelectedValue, chkActivo.Checked, "0", TipoItem)
        id_item = resultado


        Dim urlImagen As String
        urlImagen = "https://cerveceriagualicho.com/Admin/Imagenes/Items/"

        btnSubirImg.SaveAs(HttpContext.Current.Server.MapPath("./Imagenes/Items/") & id_item & ".png")


        urlImagen = urlImagen & id_item & ".png"

        oDs = oObjeto.ModificarImagen(id_item, urlImagen)








        Dim precio As Double = 0

        Dim oDs1 As New DataSet
        Dim oObjeto1 As New ItemsPrecios
        Dim resultado1 As Integer

        If TxtPrecio.Text = "" Then
            TxtPrecio.Text = " "
        End If

        Dim preciofinal As String
        preciofinal = TxtPrecio.Text
        resultado1 = oObjeto1.Agregar(resultado, 3, preciofinal)

        Dim oDs2 As New DataSet
        Dim oObjeto2 As New ItemsRubros
        Dim resultado2 As Integer
        resultado2 = oObjeto2.Agregar(resultado, CboRubro.SelectedValue, CboSubRubro.SelectedValue)






        Dim tituloStatus As String
        tituloStatus = "PRODUCTO AGREGADO EXITOSAMENTE"

        Session.Add("status", 1)

        Session.Add("titulo", tituloStatus)
        Session.Add("imagen", "Imagenes/OkTickets.png")
    End Sub

    Private Sub ModificarItem()
        Dim oDs As New DataSet
        Dim oObjeto As New Items
        Dim estado As Integer = 0
        If chkActivo.Checked = True Then
            estado = 1
        Else
            estado = 2
        End If
        Dim Stock As Integer = 0

        TipoItem = TipoItemRadioButon.SelectedValue.ToString()
        oDs = oObjeto.ModificarBEWeb(HfID_Item.Value, TxtDescripcion.Text, TxtDetalle.Text, TxtObservaciones.Text, "frmDetalleProducto.aspx", TxtStock.Text, estado, CboMarca.SelectedValue, chkActivo.Checked, "0", TipoItem)
        Dim precio As Double = 0

        Dim oDs1 As New DataSet
        Dim oObjeto1 As New ItemsPrecios

        Dim preciofinal As String
        preciofinal = TxtPrecio.Text
        oDs1 = oObjeto1.Modificar(HfID_Item.Value, 3, preciofinal)

        Dim oDs2 As New DataSet
        Dim oObjeto2 As New ItemsRubros
        oDs2 = oObjeto2.Modificar(HfID_Item.Value, CboRubro.SelectedValue, CboSubRubro.SelectedValue)



        Dim tituloStatus As String
        tituloStatus = "PRODUCTO MODIFICADO EXITOSAMENTE"

        Session.Add("status", 1)

        Session.Add("titulo", tituloStatus)
        Session.Add("imagen", "Imagenes/OkTickets.png")
    End Sub

    Private Sub ModificarItemConImagen()
        Dim oDs As New DataSet
        Dim oObjeto As New Items
        Dim estado As Integer = 0
        If chkActivo.Checked = True Then
            estado = 1
        Else
            estado = 2
        End If
        Dim Stock As Integer = 0

        TipoItem = TipoItemRadioButon.SelectedValue.ToString()
        oDs = oObjeto.ModificarBEWeb(HfID_Item.Value, TxtDescripcion.Text, TxtDetalle.Text, TxtObservaciones.Text, "frmDetalleProducto.aspx", TxtStock.Text, estado, CboMarca.SelectedValue, chkActivo.Checked, "0", TipoItem)
        Dim precio As Double = 0

        Dim oDs1 As New DataSet
        Dim oObjeto1 As New ItemsPrecios

        Dim preciofinal As String
        preciofinal = TxtPrecio.Text
        oDs1 = oObjeto1.Modificar(HfID_Item.Value, 3, preciofinal)

        Dim oDs2 As New DataSet
        Dim oObjeto2 As New ItemsRubros
        oDs2 = oObjeto2.Modificar(HfID_Item.Value, CboRubro.SelectedValue, CboSubRubro.SelectedValue)



        Dim urlImagen As String
        urlImagen = "https://cerveceriagualicho.com/Admin/Imagenes/Items/"

        btnSubirImg.SaveAs(HttpContext.Current.Server.MapPath("./Imagenes/Items/") & HfID_Item.Value & ".png")


        urlImagen = urlImagen & HfID_Item.Value & ".png"

        oDs = oObjeto.ModificarImagen(HfID_Item.Value, urlImagen)

        Dim tituloStatus As String
        tituloStatus = "PRODUCTO MODIFICADO EXITOSAMENTE"

        Session.Add("status", 1)

        Session.Add("titulo", tituloStatus)
        Session.Add("imagen", "Imagenes/OkTickets.png")


    End Sub


    Private Sub TipoItemRadioButon_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles TipoItemRadioButon.SelectedIndexChanged

        TipoItem = TipoItemRadioButon.SelectedValue.ToString()

    End Sub

    Private Sub CboRubro_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles CboRubro.SelectedIndexChanged
        CargarSubRubros(CboRubro.SelectedValue)
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


            DivStatus.Visible = True
            PanelControles.Visible = False
            PanelVolver.Visible = True
            lblTitulo.Visible = False

        End If

        If status = 2 Then

            TituloStatusSpan.InnerText = titulo
            ImagenStatus.Src = imagen


            DivStatus.Visible = True
           


            Dim Rubro As String = Session("Rubro")
            Dim SubRubro As String = Session("SubRubro")
            Dim Marca As String = Session("Marca")
            Dim descripcion As String = Session("Descripcion")
            Dim Detalle As String = Session("Detalle")
            Dim Observaciones As String = Session("Observaciones")
            Dim Precio As String = Session("Precio")
            Dim Stock As String = Session("Stock")
            Dim EstadoItem As String = Session("EstadoItem")
            Dim Activo As String = Session("Activo")

            Session("Rubro") = Nothing
            Session("SubRubro") = Nothing
            Session("Marca") = Nothing
            Session("Descripcion") = Nothing
            Session("Detalle") = Nothing
            Session("Observaciones") = Nothing
            Session("Precio") = Nothing
            Session("Stock") = Nothing
            Session("EstadoItem") = Nothing
            Session("Activo") = Nothing


            If Rubro <> "" Then
                CboRubro.SelectedValue = Rubro
            End If

            If SubRubro <> "" Then
                CboSubRubro.SelectedValue = SubRubro
            End If

            If Marca <> "" Then
                CboMarca.SelectedValue = Marca
            End If

            If descripcion <> "" Then
                TxtDescripcion.Text = descripcion
            End If

            If Detalle <> "" Then
                TxtDetalle.Text = Detalle
            End If


            If Observaciones <> "" Then
                TxtObservaciones.Text = Observaciones
            End If

            If Precio <> "" Then
                TxtPrecio.Text = Precio
            End If

            If Stock <> "" Then
                TxtStock.Text = Stock
            End If

            If EstadoItem <> "" Then
                TipoItemRadioButon.SelectedValue = EstadoItem
            End If

            If Activo <> "" Then
                chkActivo.Checked = Activo
            End If






        End If



    End Sub

    Private Sub btnVolver_ServerClick(sender As Object, e As System.EventArgs) Handles btnVolver.ServerClick
        Response.Redirect("frmItems.aspx")
    End Sub
#End Region

   
End Class
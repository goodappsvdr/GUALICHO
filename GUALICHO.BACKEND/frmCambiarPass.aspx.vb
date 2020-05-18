Public Class frmCambiarPass
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Page.IsPostBack = False Then
            CargarMenuRoles()

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

        If status = 2 Then

            TituloStatusSpan.InnerText = titulo
            ImagenStatus.Src = imagen


            DivStatus.Visible = True


        End If



    End Sub

    Private Sub btnVolver_ServerClick(sender As Object, e As System.EventArgs) Handles btnVolver.ServerClick
        Response.Redirect("frmInicio.aspx")
    End Sub
#End Region


    Public Sub CambiarPass()
        lblError.Text = ""
        Dim tituloStatus As String

        If TxtNuevoPass.Text = TxtConfirmarNuevoPass.Text Then

            If TxtPassActual.Text <> "" And TxtNuevoPass.Text <> "" And TxtPassActual.Text <> "" Then


                Try

                    Dim user As String = HttpContext.Current.User.Identity.Name

                    Dim u As MembershipUser = Membership.GetUser(user)

                    If u.ChangePassword(TxtPassActual.Text, TxtNuevoPass.Text) Then


                        tituloStatus = "CONTRASEÑA CAMBIADA EXITOSAMENTE"

                        Session.Add("status", 1)

                        Session.Add("titulo", tituloStatus)
                        Session.Add("imagen", "Imagenes/OkTickets.png")


                    Else
                        lblError.Text = "ERROR, VUELVA A INGRESAR LOS VALORES"

                        tituloStatus = "ERROR, VUELVA A INGRESAR LOS VALORES"
                        Session.Add("status", 2)
                        Session.Add("titulo", tituloStatus)
                        Session.Add("imagen", "Imagenes/IncorrectoTickets.png")


                    End If

                Catch e As Exception
                    lblError.Text = "ERROR, INTENTE NUEVAMENTE MAS TARDE"


                    tituloStatus = "ERROR, INTENTE NUEVAMENTE MAS TARDE"
                    Session.Add("status", 2)
                    Session.Add("titulo", tituloStatus)
                    Session.Add("imagen", "Imagenes/IncorrectoTickets.png")


                End Try


            ElseIf TxtPassActual.Text = "" Then
                lblError.Text = "INGRESE LA CONTRASEÑA ACTUAL"
                tituloStatus = "ERROR, INGRESE LA CONTRASEÑA ACTUAL"
                Session.Add("status", 2)
                Session.Add("titulo", tituloStatus)
                Session.Add("imagen", "Imagenes/IncorrectoTickets.png")
            ElseIf TxtNuevoPass.Text = "" Then
                lblError.Text = "INGRESE LA NUEVA CONTRASEÑA"
                tituloStatus = "ERROR, INGRESE LA NUEVA CONTRASEÑA"
                Session.Add("status", 2)
                Session.Add("titulo", tituloStatus)
                Session.Add("imagen", "Imagenes/IncorrectoTickets.png")
            ElseIf TxtConfirmarNuevoPass.Text = "" Then
                lblError.Text = "INGRESE LA CONFIRMACIÓN DE LA NUEVA CONTRASEÑA"
                tituloStatus = "ERROR, INGRESE LA CONFIRMACIÓN DE LA NUEVA CONTRASEÑA"
                Session.Add("status", 2)
                Session.Add("titulo", tituloStatus)
                Session.Add("imagen", "Imagenes/IncorrectoTickets.png")
            End If
        Else
            lblError.Text = "LAS CONTRASEÑAS NO COINCIDEN"
            tituloStatus = "ERROR, LAS CONTRASEÑAS NO COINCIDEN"
            Session.Add("status", 2)
            Session.Add("titulo", tituloStatus)
            Session.Add("imagen", "Imagenes/IncorrectoTickets.png")

        End If


    End Sub

    Private Sub cmdAceptar_ServerClick(sender As Object, e As EventArgs) Handles cmdAceptar.ServerClick
        CambiarPass()

        If lblError.Text = "" Then



            Response.Redirect("frmCambiarPass.aspx")

        Else
            Response.Redirect("frmCambiarPass.aspx")

        End If

    End Sub
End Class
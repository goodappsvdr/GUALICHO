Imports System.Web.Script.Serialization
Imports System.Web.Script.Services
Imports System.Web.Services
Imports System.Net
Imports System.IO
Imports GUALICHO.AD
Imports MercadoPago
Imports MercadoPago.Resources
Imports System.Web
Imports System.Collections.Generic
Imports Newtonsoft.Json.Linq
Public Class FrmNotificacionMP
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Page.IsPostBack = False Then

            Main()
            StatusMP()

        End If
    End Sub
    Private Function StatusMP()



        Try
            IniciaTransaccion()

            If MercadoPago.SDK.ClientId Is Nothing Then
                'MercadoPago.SDK.ClientId = "6712721325584376"
                'MercadoPago.SDK.ClientSecret = "enI0eJPHYwqFIUkRjneDU4AHeSYcJemy"
                'MercadoPago.SDK.AccessToken = "APP_USR-6712721325584376-121908-36b3e1ace9f81bbb49c3e66f18bc47d5-341866614"

                MercadoPago.SDK.ClientId = "6192370592363131"
                MercadoPago.SDK.ClientSecret = "enI0eJPHYwqFIUkRjneDU4AHeSYcJemy"
                MercadoPago.SDK.AccessToken = "APP_USR-6192370592363131-060416-248e249880906bb9d8a75036b49ae2a4-578779446"
            End If

            Dim id_payment As String = Request.QueryString("id")


            If id_payment <> "" Then



                Dim payment1 As New MercadoPago.Resources.Payment

                payment1 = MercadoPago.Resources.Payment.FindById(id_payment)



                'OBTENER ID MERCADO PAGO
                Dim Id_mercadoPago As String = payment1.Id
                'FIN ID MERCADO PAGO




                'OBTENER STATUS
                Dim status As String = payment1.Status.Value
                status = payment1.Status.ToString

                If status = "approved" Then
                    status = "approved"
                ElseIf status = "in_process" Then
                    status = "in_process"
                ElseIf status = "pending" Then
                    status = "pending"
                ElseIf status = "rejected" Then
                    status = "rejected"
                End If
                'FIN  STATUS



                'OBTENER DESCRIPTION
                Dim Description As String
                Description = payment1.Description
                'FIN  DESCRIPTION


                'OBTENER VALOR DEL PAGO
                Dim transaction_amount As String
                transaction_amount = payment1.TransactionAmount
                'FIN  VALOR DEL PAGO





                'DATE CREATED'
                Dim FechaCreacion As Date
                FechaCreacion = payment1.DateCreated
                'FIN DATE CREATED'




                'OBTENER METODO DE PAGO
                Dim metodoPago As String
                metodoPago = payment1.PaymentMethodId

                'FIN  METODO DE PAGO




                'OBTENER CURRENCY
                Dim CurrencyId As String
                CurrencyId = payment1.CurrencyId.ToString
                'FIN  CURRENCY



                'OBTENER STATUSDETAIL
                Dim status_detail As String
                status_detail = payment1.StatusDetail
                'FIN  STATUSDETAIL






                'OBTENER DATOS TARJETA

                Dim primeros6 As String
                Dim ultimos4 As String
                Dim AnioExpiracion As String
                Dim TitularTarjeta As String
                If status = "pending" Then
                    primeros6 = "pending"
                    ultimos4 = "pending"
                    AnioExpiracion = "pending"
                    TitularTarjeta = "pending"
                Else
                    If payment1.Card.Value.CardHolder IsNot Nothing Then
                        primeros6 = payment1.Card.Value.FirstSixDigits
                        ultimos4 = payment1.Card.Value.LastFourDigits
                        AnioExpiracion = payment1.Card.Value.ExpirationYear

                        TitularTarjeta = payment1.Card.Value.CardHolder.Value.Name.ToString

                        Dim NumeroTipo As String = payment1.Card.Value.CardHolder.Value.Identification.Value.Number.ToString
                        Dim Tipo As String = payment1.Card.Value.CardHolder.Value.Identification.Value.Type.ToString
                    End If
                End If

                'FIN  DATOS TARJETA




                Dim First_name As String
                Dim email As String


                'PAYER'
                First_name = payment1.Payer.FirstName
                email = payment1.Payer.Email
                'FIN PAYER'



                'INICIO OBTENER ID PEDIDO

                Dim ID_Pedido As String
                ID_Pedido = payment1.ExternalReference

                Dim ods As New DataSet
                Dim oObjeto As New PedidosMP



                If status = "approved" Then

                    ods = oObjeto.ModificarEstado(transaccion, ID_Pedido, 2)


                    Dim ods1 As New DataSet
                    Dim ods2 As New DataSet
                    Dim oObjeo1 As New PedidosDetalleMP

                    ods1 = oObjeo1.BuscarID_PedidoMP(ID_Pedido)



                    ods2 = oObjeo1.BuscarPorID_PedidoMP(ods1.Tables(0).Rows(0).Item("id_pedido"))
                    Dim ods6 As New DataSet
                    Dim oObjeto6 As New Items

                    For i = 0 To ods1.Tables(0).Rows.Count - 1
                        'ACTUALIZAR STOCK


                        ods6 = oObjeto6.Items_ActualizarStock(ods2.Tables(0).Rows(i).Item("ID_Item"), ods2.Tables(0).Rows(i).Item("Cantidad"))

                    Next


                ElseIf status = "in_process" Then

                    ods = oObjeto.ModificarEstado(transaccion, ID_Pedido, 4)
                ElseIf status = "pending" Then

                    ods = oObjeto.ModificarEstado(transaccion, ID_Pedido, 1)
                ElseIf status = "rejected" Then

                    ods = oObjeto.ModificarEstado(transaccion, ID_Pedido, 5)
                End If


                FinalizaTransaccion()

                'FIN OBTENER ID PEDIDO

            Else

                CancelaTransaccion()




                Return New HttpResponseMessage(HttpStatusCode.OK)



            End If


        Catch ex As Exception
            CancelaTransaccion()
            Return New HttpResponseMessage(HttpStatusCode.OK)

        End Try


    End Function
End Class
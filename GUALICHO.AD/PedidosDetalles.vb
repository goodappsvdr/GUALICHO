Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class PedidosDetalles
    Dim oDatabase As Database

    Public Sub New()

        oDatabase = DatabaseFactory.CreateDatabase("Conn")

    End Sub
    Public Sub New(ByVal str As String)
    End Sub
    Public Function Agregar(tran As SqlTransaction, ID_Pedido As Integer, ID_Item As Integer, Telefono As String, mensaje As String, Cantidad As Integer, PrecioUnitario As Double, Total As Double) As Double
        Try
            Return oDatabase.ExecuteScalar(tran, "PedidosDetalle_Agregar", ID_Pedido, ID_Item, Telefono, mensaje, Cantidad, PrecioUnitario, Total)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function BuscarPorID_Pedido(ID_Pedido As Integer) As DataSet
        Try

            Return oDatabase.ExecuteDataSet("PedidosDetalles_BuscarPorID_Pedido", ID_Pedido)

        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
End Class

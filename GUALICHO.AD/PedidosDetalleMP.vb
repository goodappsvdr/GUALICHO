Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class PedidosDetalleMP
    Dim oDatabase As Database

    Public Sub New()

        oDatabase = DatabaseFactory.CreateDatabase("Conn")

    End Sub
    Public Sub New(ByVal str As String)
    End Sub

    Public Function Agregar(tran As SqlTransaction, ID_PedidoMP As String, ID_Item As Integer, Telefono As String, Mensaje As String, Cantidad As Integer, PU As Double, Total As Double) As Double
        Try
            Return oDatabase.ExecuteScalar(tran, "PedidosDetalleMP_Agregar", ID_PedidoMP, ID_Item, Telefono, Mensaje, Cantidad, PU, Total)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function


    Public Function BuscarID_PedidoMP(ByVal ID_Item As Integer) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("PedidosDetalleMP_BuscarID_PedidoMP", ID_Item)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function

End Class

Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class PedidosDetallesCaracteristicas
    Dim oDatabase As Database

    Public Sub New()

        oDatabase = DatabaseFactory.CreateDatabase("Conn")

    End Sub
    Public Sub New(ByVal str As String)
    End Sub
    Public Function Agregar(tran As SqlTransaction, ID_PedidoDetalle As Integer, ID_Item As Integer, ID_Caracteristica As Integer, ID_CaracteristicaDetalle As Integer) As Double
        Try
            Return oDatabase.ExecuteScalar(tran, "PedidosDetallesCaracteristicas_Agregar", ID_PedidoDetalle, ID_Item, ID_Caracteristica, ID_CaracteristicaDetalle)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

End Class

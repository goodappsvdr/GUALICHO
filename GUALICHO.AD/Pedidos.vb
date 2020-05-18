Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class Pedidos

    Dim oDatabase As Database

    Public Sub New()

        oDatabase = DatabaseFactory.CreateDatabase("Conn")

    End Sub
    Public Sub New(ByVal str As String)
    End Sub
    Public Function Agregar(tran As SqlTransaction, Fecha As Date, Usuario As String, Total As Double, Estado As Integer, Notificado As Integer, RazonSocial As String) As Double
        Try
            Return oDatabase.ExecuteScalar(tran, "Pedidos_Agregar", Fecha, Usuario, Total, Estado, Notificado, RazonSocial)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function Pedidos_BuscarPorUsuario(ByVal Usuario As String)
        Try

            Return oDatabase.ExecuteDataSet("Pedidos_BuscarPorUsuario", Usuario)

        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function Pedidos_BuscarNotificado()
        Try

            Return oDatabase.ExecuteDataSet("Pedidos_BuscarNotificado")

        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function ModificarEstado(ByVal ID_Pedido As Integer, ByVal Estado As Integer) As DataSet
        Try

            Return oDatabase.ExecuteDataSet("Pedidos_ModificarEstado", ID_Pedido, Estado)

        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function Pedidos_Eliminar(ByVal ID_Pedido As Integer, ByVal ID_PedidoDetalle As Integer) As DataSet
        Try

            Return oDatabase.ExecuteDataSet("Pedidos_Eliminar", ID_Pedido, ID_PedidoDetalle)

        Catch ex As System.Exception
            Throw ex
        End Try
    End Function


    Public Function Pedidos_ActualizarNotificaciones(ByVal ID_Pedido As Integer, ByVal Notificado As Integer) As DataSet
        Try

            Return oDatabase.ExecuteDataSet("Pedidos_ActualizarNotificaciones", ID_Pedido, Notificado)

        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function BuscarTodos() As DataSet
        Try

            Return oDatabase.ExecuteDataSet("Pedidos_BuscarTodos")

        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function Pedidos_BuscarNotificaciones() As DataSet
        Try

            Return oDatabase.ExecuteDataSet("Pedidos_BuscarNotificaciones")

        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function BuscarTodosEntregados() As DataSet
        Try

            Return oDatabase.ExecuteDataSet("Pedidos_BuscarTodosEntregados")

        Catch ex As System.Exception
            Throw ex
        End Try
    End Function


    Public Function Pedidos_BuscarTodosAdmin() As DataSet
        Try

            Return oDatabase.ExecuteDataSet("Pedidos_BuscarTodosAdmin")

        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function Pedidos_BuscarPorID_Estado(ID_Estado As Integer) As DataSet
        Try

            Return oDatabase.ExecuteDataSet("Pedidos_BuscarPorID_Estado", ID_Estado)

        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

End Class

Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class PedidosMP
    Dim oDatabase As Database

    Public Sub New()

        oDatabase = DatabaseFactory.CreateDatabase("Conn")

    End Sub
    Public Sub New(ByVal str As String)
    End Sub

    Public Function Agregar(tran As SqlTransaction, Fecha As Date, Usuario As Guid, Total As Double, Estado As Integer, Notificado As Integer, RazonSocial As String, Email As String, Direccion As String, Geolatitud As String, Geolongitud As String, EntreCalles As String, UrlMP As String) As Double
        Try
            Return oDatabase.ExecuteScalar(tran, "PedidosMP_Agregar", Fecha, Usuario, Total, Estado, Notificado, RazonSocial, Email, Direccion, Geolatitud, Geolongitud, EntreCalles, UrlMP)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function AgregarUrlMP(tran As SqlTransaction, ID_PedidoMP As String, UrlMP As String) As DataSet
        Try
            Return oDatabase.ExecuteDataSet(tran, "PedidosMP_AgregarUrlMP", ID_PedidoMP, UrlMP)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function


    Public Function ModificarEstado(tran As SqlTransaction, ID_PedidoMP As String, Estado As String) As DataSet
        Try
            Return oDatabase.ExecuteDataSet(tran, "PedidosMP_ModificarEstado", ID_PedidoMP, Estado)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function


    Public Function BuscarPorUserId(ByVal userId As Guid) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("PedidosMP_BuscarPorUserId", userId)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function


    Public Function BuscarTodos() As DataSet

        Try

            Return oDatabase.ExecuteDataSet("PedidosMP_BuscarTodos")

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function

    Public Function BuscarPorID_PedidoMP(id_pedidoMP As Integer) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("PedidosMP_BuscarPorID_PedidoMP", id_pedidoMP)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function


End Class

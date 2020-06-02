Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class Carrito

    Dim oDatabase As Database

    Public Sub New()

        oDatabase = DatabaseFactory.CreateDatabase("Conn")

    End Sub
    Public Sub New(ByVal str As String)
    End Sub

    Public Function BuscarPorUserId(ByVal UserId As Guid) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Carrito_BuscarPorUserId", UserId)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function


    Public Function EliminarTodoPorUsuario(ByVal UserId As Guid) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Carrito_EliminarTodoPorUsuario", UserId)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function


    Public Function EliminarPorID_Carrito(ByVal ID_Carrito As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Carrito_EliminarPorID_Carrito", ID_Carrito)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function



    Public Function Agregar(ByVal UserId As Guid, ByVal id_item As Integer, ByVal imagen As String, ByVal Cantidad As Integer, ByVal Precio As Double, ByVal Total As Double) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Carrito_Agregar", UserId, id_item, imagen, Cantidad, Precio, Total)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function ModificarItemPorUserId(ByVal UserId As Guid, ByVal id_item As Integer, ByVal Cantidad As Integer, ByVal Precio As Double, ByVal Total As Double) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Carrito_ModificarItemPorUserId", UserId, id_item, Cantidad, Precio, Total)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function



    Public Function BuscarItemPorUserId(ByVal UserId As Guid, ByVal id_item As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Carrito_BuscarItemPorUserId", UserId, id_item)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function


End Class

Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.IO
Public Class Transportes
    Dim oDatabase As Database

    Public Sub New()
        oDatabase = DatabaseFactory.CreateDatabase("Conn2")
    End Sub


    'constructor base con parametros
    Public Sub New(ByVal str As String)
    End Sub

    Public Function BuscarTodos() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Transportes_Autorizados_BuscarTodos")
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function BuscarTodosAutorizados() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Transportes_Autorizados_BuscarTodosAutorizados")
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function BuscarPorID(ID_Transporte As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Transportes_Autorizados_BuscarPorID", ID_Transporte)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function Agregar(ID_Transporte As Integer, RazonSocial As String, NroCuit As String, Activo As Boolean) As Double
        Try
            Return oDatabase.ExecuteScalar("Transportes_Autorizados_Agregar", ID_Transporte, RazonSocial, NroCuit, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function Modificar(ID_TransporteAutorizado As Integer, ID_Transporte As Integer, RazonSocial As String, NroCuit As String, Activo As Boolean) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Transportes_Autorizados_Modificar", ID_TransporteAutorizado, ID_Transporte, RazonSocial, NroCuit, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function BuscarPorIDAutorizado(ID_TransporteAutorizado As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Transportes_Autorizados_BuscarPorID_Autorizado", ID_TransporteAutorizado)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
End Class

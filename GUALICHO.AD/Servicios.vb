Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class Servicios
    Dim oDatabase As Database

    Public Sub New()

        oDatabase = DatabaseFactory.CreateDatabase("Conn")

    End Sub
    Public Sub New(ByVal str As String)
    End Sub
    Public Function BuscarTodos() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Servicios_BuscarTodos")
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function BuscarPorID(ID_Servicio As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Servicios_BuscarPorID", ID_Servicio)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function Agregar(Nombre As String, descripcion As String, Activo As Boolean) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Servicios_Agregar", Nombre, descripcion, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function Modificar(ID_Servicio As Integer, Nombre As String, descripcion As String, Activo As Boolean) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Servicios_Modificar", ID_Servicio, Nombre, descripcion, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function


End Class

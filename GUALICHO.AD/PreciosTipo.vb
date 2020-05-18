Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class PreciosTipo

    Dim oDatabase As Database

    Public Sub New()

        oDatabase = DatabaseFactory.CreateDatabase("Conn")

    End Sub
    Public Sub New(ByVal str As String)
    End Sub
    Public Function BuscarTodos() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("PreciosTipo_BuscarTodos")
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function BuscarPorID(ID_PrecioTipo As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("PreciosTipo_BuscarPorID", ID_PrecioTipo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function Agregar(Descripcion As String, Activo As Boolean) As Double
        Try
            Return oDatabase.ExecuteScalar("PreciosTipo_Agregar", Descripcion, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function Modificar(ID_PrecioTipo As Integer, Descripcion As String, Activo As Boolean) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("PreciosTipo_Modificar", ID_PrecioTipo, Descripcion, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
End Class

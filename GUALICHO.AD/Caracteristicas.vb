Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class Caracteristicas
    Dim oDatabase As Database

    Public Sub New()

        oDatabase = DatabaseFactory.CreateDatabase("Conn")

    End Sub
    Public Sub New(ByVal str As String)
    End Sub
    Public Function BuscarTodos() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Caracteristicas_BuscarTodos")
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function BuscarPorID(ID_Caracteristica As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Caracteristicas_BuscarPorID", ID_Caracteristica)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function Agregar(Descripcion As String, Estado As Integer) As Double
        Try
            Return oDatabase.ExecuteScalar("Caracteristicas_Agregar", Descripcion, Estado)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function Modificar(ID_Caracteristica As Integer, Descripcion As String, Estado As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Caracteristicas_Modificar", ID_Caracteristica, Descripcion, Estado)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
End Class

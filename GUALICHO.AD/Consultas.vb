Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class Consultas
    Dim oDatabase As Database

    Public Sub New()

        oDatabase = DatabaseFactory.CreateDatabase("Conn")

    End Sub
    Public Sub New(ByVal str As String)
    End Sub

    Public Function BuscarTodos() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Consultas_BuscarTodos")
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function BuscarPorID(ID_Consulta As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Consultas_BuscarPorID", ID_Consulta)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function Agregar(Nombre As String, Email As String, Asunto As String, Mensaje As String) As Double
        Try
            Return oDatabase.ExecuteScalar("Consultas_Agregar", Nombre, Email, Asunto, Mensaje)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function ModificarEstado(ID_Consulta As Integer, Estado As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Consultas_ModificarEstado", ID_Consulta, Estado)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class


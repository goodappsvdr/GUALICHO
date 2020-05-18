Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class Contacto
    Dim oDatabase As Database

    Public Sub New()

        oDatabase = DatabaseFactory.CreateDatabase("Conn")

    End Sub
    Public Sub New(ByVal str As String)
    End Sub

    Public Function BuscarTodos() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("contacto_buscarTodos")
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function Modificar(Direccion As String, Email As String, Telefono As String, Mapa As String) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Contacto_Modificar", Direccion, Email, Telefono, Mapa)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
End Class

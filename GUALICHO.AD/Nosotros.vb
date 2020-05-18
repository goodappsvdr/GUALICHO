Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class Nosotros
    Dim oDatabase As Database
    Public Sub New()

        oDatabase = DatabaseFactory.CreateDatabase("Conn")

    End Sub
    Public Sub New(ByVal str As String)
    End Sub

    Public Function BuscarTodos() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Nosotros_BuscarTodo")
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function Modificar(Titulo As String, DescripcionPrincipal As String, DescripcionSecundaria As String) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Nosotros_Modificar", Titulo, DescripcionPrincipal, DescripcionSecundaria)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function ModificarImagen(Imagen As String) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Nosotros_ModificarImagen", Imagen)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function







End Class

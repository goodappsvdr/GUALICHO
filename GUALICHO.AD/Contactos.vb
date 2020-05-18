Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class Contactos
    Dim oDatabase As Database

    Public Sub New()

        oDatabase = DatabaseFactory.CreateDatabase("Conn")

    End Sub
    Public Sub New(ByVal str As String)
    End Sub

    Public Function BuscarTodos() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("contactos_buscarTodos")
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function ModificarInstagram(ByVal instagram As String) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("contactos_ModificarInstagram", instagram)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function ModificarFacebook(ByVal Facebook As String) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("contactos_ModificarFacebook", Facebook)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
End Class

Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class QuienesSomos
    Dim oDatabase As Database

    Public Sub New()

        oDatabase = DatabaseFactory.CreateDatabase("Conn")

    End Sub
    Public Sub New(ByVal str As String)
    End Sub

    Public Function BuscarTodos() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("QuienesSomos_BuscarTodos")
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function ModificarBEWeb(Titulo As String, Subtitulo As String, Descripcion As String, Tooltip1 As String, Tooltip2 As String, Tooltip3 As String, Tooltip4 As String, Tooltip5 As String) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("QuienesSomos_ModificarBE", Titulo, Subtitulo, Descripcion, Tooltip1, Tooltip2, Tooltip3, Tooltip4, Tooltip5)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function ModificarImagen(Imagen As String) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("QuienesSomos_ModificarImagen", Imagen)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
End Class

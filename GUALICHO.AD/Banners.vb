Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class Banners
    Dim oDatabase As Database

    Public Sub New()

        oDatabase = DatabaseFactory.CreateDatabase("Conn")

    End Sub
    Public Sub New(ByVal str As String)
    End Sub

    Public Function BuscarTodos() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Banners_BuscarTodos")
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function Agregar(Descripcion As String, Imagen As String, FechaFin As String, Activo As Boolean) As Double
        Try
            Return oDatabase.ExecuteScalar("Banners_Agregar", Descripcion, Imagen, FechaFin, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function Modificar(ID_Banner As Integer, Descripcion As String, Imagen As String, FechaFin As String, Activo As Boolean) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Banners_Modificar", ID_Banner, Descripcion, Imagen, FechaFin, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function ModificarBEWeb(ID_Banner As Integer, Descripcion As String, FechaFin As String, Activo As Boolean) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Banners_ModificarBEWeb", ID_Banner, Descripcion, FechaFin, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function ModificarImagen(ID_Banner As Integer, Imagen As String) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Banners_ModificarImagen", ID_Banner, Imagen)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function BuscarPorID(ID_Banner As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Banners_BuscarPorID", ID_Banner)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function Eliminar(ID_Banner As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Banners_Eliminar", ID_Banner)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

End Class

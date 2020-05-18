Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.IO
Public Class Novedades
    Dim oDatabase As Database

    Public Sub New()
        oDatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub
    Public Function ModificarImagen(ID_Novedad As Integer, Imagen As String) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Novedades_ModificarImagen", ID_Novedad, Imagen)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function Agregar(Titulo As String, Contenido As String, Fecha As String, Imagen As String, Estado As Integer) As Double
        Try
            Return oDatabase.ExecuteScalar("Novedades_Agregar", Titulo, Contenido, Fecha, Imagen, Estado)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function Modificar(ID_Novedad As Integer, Titulo As String, Contenido As String, Fecha As String, Imagen As String, Estado As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Novedades_Modificar", ID_Novedad, Titulo, Contenido, Fecha, Imagen, Estado)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function Novedades_ModificarBEWeb(ID_Novedad As Integer, Titulo As String, Contenido As String, Fecha As String, Estado As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Novedades_ModificarBEWeb", ID_Novedad, Titulo, Contenido, Fecha, Estado)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function


    Public Function Novedades_BuscarTodosBEWeb() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Novedades_BuscarTodosBEWeb")
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function Novedades_BuscarPorID(ID_Novedad As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Novedades_BuscarPorID", ID_Novedad)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function Novedades_Eliminar(ID_Novedad As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Novedades_Eliminar", ID_Novedad)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function



    Public Function Novedades_BuscarTodos() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Novedades_BuscarTodos")
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function


End Class

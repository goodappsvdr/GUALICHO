Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class ImagenesServicios


    Dim oDatabase As Database
    Public Sub New()

        oDatabase = DatabaseFactory.CreateDatabase("Conn")

    End Sub
    Public Sub New(ByVal str As String)
    End Sub

    Public Function BuscarPorID_Servicio(id_servicio As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("ImagenesServicios_BuscarPorID_Servicio", id_servicio)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function


    Public Function BuscarPorID(id_imagenServicio As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("ImagenesServicios_BuscarPorID", id_imagenServicio)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function





    Public Function Agregar(id_servicio As Integer, Imagen As String, Activo As Boolean) As Double
        Try
            Return oDatabase.ExecuteScalar("ImagenesServicios_Agregar", id_servicio, Imagen, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function Modificar(id_imagenservicio As Integer, id_servicio As Integer, Activo As Boolean) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("ImagenesServicios_Modificar", id_imagenservicio, id_servicio, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function


    Public Function ModificarImagen(id_imagenservicio As Integer, Imagen As String) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("ImagenesServicios_ModificarImagen", id_imagenservicio, Imagen)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function


End Class

Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class ImagenesNosotros


    Dim oDatabase As Database
    Public Sub New()

        oDatabase = DatabaseFactory.CreateDatabase("Conn")

    End Sub
    Public Sub New(ByVal str As String)
    End Sub

    Public Function BuscarTodos() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("ImagenesNosotros_BuscarTodos")
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function Agregar(Imagen As String, Activo As Boolean) As Double
        Try
            Return oDatabase.ExecuteScalar("ImagenesNosotros_Agregar", Imagen, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function Modificar(id_imagennosotros As Integer, Activo As Boolean) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("ImagenesNosotros_Modificar", id_imagennosotros, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function


    Public Function ModificarImagen(id_imagennosotros As Integer, Imagen As String) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("ImagenesNosotros_ModificarImagen", id_imagennosotros, Imagen)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function



    Public Function BuscarPorID(id_imagennosotros As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("ImagenesNosotros_BuscarPorID", id_imagennosotros)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function









End Class

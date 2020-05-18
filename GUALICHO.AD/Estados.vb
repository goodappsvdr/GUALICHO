Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.IO

Public Class Estados

     Dim oDatabase As Database

    Public Sub New()
        oDatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub


    'constructor base con parametros
    Public Sub New(ByVal str As String)
    End Sub


    'BuscarPorID
    Public Function BuscarPorID(ByVal Id_estado As Double) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Estados_BuscarPorID", Id_estado)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function


    Public Function FechaHora() As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Servidor_FechaHora")

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function

    Public Function BuscarPorCategoria(ByVal Categoria As String) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Estados_BuscarPorCategoria", Categoria)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function



    Public Function BuscarPorCategoriaNombre(ByVal Categoria As String, ByVal Nombre As String) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Estados_BuscarPorCategoriaNombre", Categoria, Nombre)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function

    'BuscarTodos
    Public Function BuscarTodos() As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Estados_BuscarTodos")

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function

    '*********************BUSQUEDA POR LOS DIFERENTES CAMPOS DE LA TABLA****************


    'Insert
    Public Function Agregar(ByVal Categoria As String, ByVal Nombre As String, ByVal Descripcion As String, ByVal Imagen As String, ByVal Activo As Boolean) As Double

        Try

            Return oDatabase.ExecuteScalar("Estados_Agregar", Categoria, Nombre, Descripcion, Imagen, Activo)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function



    'Update

    Public Function Modificar(ByVal Id_estado As Double, ByVal Categoria As String, ByVal Nombre As String, ByVal Descripcion As String, ByVal Imagen As String, ByVal Activo As Boolean) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Estados_Modificar", Id_estado, Categoria, Nombre, Descripcion, Imagen, Activo)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function

End Class
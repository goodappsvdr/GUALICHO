Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.IO


Public Class Categorias

    Dim oDatabase As Database

    Public Sub New()
        oDatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub


    'constructor base con parametros
    Public Sub New(ByVal str As String)
    End Sub




    'BuscarPorID
    Public Function BuscarPorID(ByVal Id_categoria As Double) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Categorias_BuscarPorID", Id_categoria)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function


    'BuscarTodos
    Public Function BuscarTodos() As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Categorias_BuscarTodos")

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function

    '*********************BUSQUEDA POR LOS DIFERENTES CAMPOS DE LA TABLA****************

    Public Function BuscarPorCategoriatipo(ByVal Categoriatipo As String) As Dataset

        Try

            Return oDatabase.ExecuteDataSet("Categorias_BuscarporCategoriatipo", Categoriatipo)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function

    Public Function BuscarPorCategoriaTipoNombre(ByVal Categoriatipo As String, ByVal Nombre As String) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Categorias_BuscarporCategoriaTipoNombre", Categoriatipo, Nombre)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function


    'Insert
    Public Function Agregar(ByVal Nombre As String, ByVal Categoriatipo As String, ByVal Descripcion As String, ByVal Activo As Boolean, ByVal Orden As Integer) As Double

        Try

            Return oDatabase.ExecuteScalar("Categorias_Agregar", Nombre, Categoriatipo, Descripcion, Activo, Orden)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function



    'Update

    Public Function Modificar(ByVal Id_categoria As Double, ByVal Nombre As String, ByVal Categoriatipo As String, ByVal Descripcion As String, ByVal Activo As Boolean, ByVal Orden As Integer) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Categorias_Modificar", Id_categoria, Nombre, Categoriatipo, Descripcion, Activo, Orden)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function

End Class


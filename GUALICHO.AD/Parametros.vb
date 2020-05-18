Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.IO


Public Class Parametros

    Dim oDatabase As Database

    Public Sub New()
        oDatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub


    'constructor base con parametros
    Public Sub New(ByVal str As String)
    End Sub




    'BuscarPorID
    Public Function BuscarPorID(ByVal Id_parametro As Double) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Parametros_BuscarPorID", Id_parametro)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function
    '
    Public Function BuscarPorCategoriaNombreEmpresa(ByVal Categoria As String, ByVal Nombre As String, ByVal ID_Empresa As Integer) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Parametros_BuscarporCategoriaNombreEmpresa", Categoria, Nombre, ID_Empresa)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function

    'BuscarTodos
    Public Function BuscarTodos() As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Parametros_BuscarTodos")

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function

    '*********************BUSQUEDA POR LOS DIFERENTES CAMPOS DE LA TABLA****************

    Public Function BuscarPorCategoriaNombre(ByVal Categoria As String, ByVal Nombre As String) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Parametros_BuscarporCategoriaNombre", Categoria, Nombre)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function




    'Insert
    Public Function Agregar(ByVal Categoria As String, ByVal Nombre As String, ByVal Valor As String, ByVal Descripcion As String, ByVal Orden As Double, ByVal ID_Empresa As Integer, ByVal Activo As Boolean) As Double

        Try

            Return oDatabase.ExecuteScalar("Parametros_Agregar", Categoria, Nombre, Valor, Descripcion, Orden, ID_Empresa, Activo)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function



    'Update

    Public Function Modificar(ByVal Id_parametro As Double, ByVal Categoria As String, ByVal Nombre As String, ByVal Valor As String, ByVal Descripcion As String, ByVal Orden As Double, ByVal ID_Empresa As Integer, ByVal Activo As Boolean) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Parametros_Modificar", Id_parametro, Categoria, Nombre, Valor, Descripcion, Orden, ID_Empresa, Activo)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function

    Public Function ModificarValor(ByVal Id_parametro As Double, ByVal Valor As String) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Parametros_ModificarValor", Id_parametro, Valor)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function
    'BuscarPorID_Empresa
    Public Function BuscarPorID_Empresa(ByVal Id_Empresa As Double) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Parametros_BuscarPorID_Empresa", Id_Empresa)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function

    Public Function E_VariacionTarifasXEmpresa() As DataSet

        Try

            Return oDatabase.ExecuteDataSet("E_VariacionTarifasXEmpresa")

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function


End Class


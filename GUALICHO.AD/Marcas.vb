Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class Marcas

     Dim oDatabase As Database

    Public Sub New()

        oDatabase = DatabaseFactory.CreateDatabase("Conn")

    End Sub
    Public Sub New(ByVal str As String)
    End Sub
    Public Function BuscarTodos() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Marcas_BuscarTodos")
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function BuscarPorID(ID_Marca As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Marcas_BuscarPorID", ID_Marca)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function Agregar(Descripcion As String, Activo As Boolean) As Double
        Try
            Return oDatabase.ExecuteScalar("Marcas_Agregar", Descripcion, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function Modificar(ID_Marca As Integer, Descripcion As String, Activo As Boolean) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Marcas_Modificar", ID_Marca, Descripcion, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function Marcas_BuscarPorID_Rubro(ID_Rubro As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Marcas_BuscarPorID_Rubro", ID_Rubro)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function Marcas_BuscarPorID_SubRubro(ID_SubRubro As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Marcas_BuscarPorID_SubRubro", ID_SubRubro)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function BuscarPorID_SubRubro(ID_SubRubro As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Marcas_BuscarPorID_SubRubroBEWeb", ID_SubRubro)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function CargarPaginas_PorID_Marca(ID_Marca As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("CargarPaginas_PorID_Marca", ID_Marca)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

End Class

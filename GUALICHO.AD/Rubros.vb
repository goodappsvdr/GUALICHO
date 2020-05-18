Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class Rubros
    Dim oDatabase As Database

    Public Sub New()

        oDatabase = DatabaseFactory.CreateDatabase("Conn")

    End Sub
    Public Sub New(ByVal str As String)
    End Sub

    Public Function BuscarTodos() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Rubros_BuscarTodos")
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function Rubros_BuscarPorID(ID_Rubro As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Rubros_BuscarPorID", ID_Rubro)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function ModificarBEWeb(ID_Rubro As Integer, Descripcion As String, URL As String, Orden As String, Estado As Boolean) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Rubros_ModificarBEWeb", ID_Rubro, Descripcion, URL, Orden, Estado)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function ModificarImagen(ID_Rubro As Integer, Imagen As String) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Rubros_ModificarImagen", ID_Rubro, Imagen)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function Agregar(Descripcion As String, URL As String, Imagen As String, Orden As String, Estado As Boolean) As Double
        Try
            Return oDatabase.ExecuteScalar("Rubros_Agregar", Descripcion, URL, Imagen, Orden, Estado)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function BuscarOrdenSugerido() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Rubros_BuscarOrdenSugerido")
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

End Class

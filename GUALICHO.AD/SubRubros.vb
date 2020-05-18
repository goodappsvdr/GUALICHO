Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.IO
Public Class SubRubros

    Dim ODatabase As Database

    Public Sub New()
        ODatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub
    Public Function Subrubros_BuscarPorID_Rubro(ByVal ID_Rubro As Integer)
        Try

            Return ODatabase.ExecuteDataSet("Subrubros_BuscarPorID_Rubro", ID_Rubro)

        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function SubRubros_BuscarID_MenuPadrePorID_Rubro(ByVal ID_Rubro As Integer)
        Try

            Return ODatabase.ExecuteDataSet("SubRubros_BuscarID_MenuPadrePorID_Rubro", ID_Rubro)

        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function SubRubros_BuscarID_Rubro_PorID_SubRubro(ByVal ID_SubRubro As Integer)
        Try

            Return ODatabase.ExecuteDataSet("SubRubros_BuscarID_Rubro_PorID_SubRubro", ID_SubRubro)

        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function SubRubros_BuscarTodos(ByVal ID_Rubro As Integer)
        Try

            Return ODatabase.ExecuteDataSet("Subrubros_BuscarTodos")

        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function BuscarTodos()
        Try

            Return ODatabase.ExecuteDataSet("Subrubros_BuscarTodos")

        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function SubRubros_BuscarMarcasPorID_SubRubro(ByVal ID_SubRubro As Integer)
        Try

            Return ODatabase.ExecuteDataSet("SubRubros_BuscarMarcasPorID_SubRubro", ID_SubRubro)

        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function SubRubros_BuscarPorID(ByVal ID_SubRubro As Integer)
        Try

            Return ODatabase.ExecuteDataSet("SubRubros_BuscarPorID", ID_SubRubro)

        Catch ex As System.Exception
            Throw ex
        End Try


    End Function
   
    Public Function Agregar(ID_Rubro As Integer, Descripcion As String, URL As String, Imagen As String, Orden As String, Estado As Boolean) As Double
        Try
            Return ODatabase.ExecuteScalar("SubRubros_Agregar", ID_Rubro, Descripcion, URL, Imagen, Orden, Estado)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function Modificar(ID_SubRubro As Integer, ID_Rubro As Integer, Descripcion As String, URL As String, Imagen As String, Orden As String, Estado As Boolean) As DataSet
        Try
            Return ODatabase.ExecuteDataSet("SubRubros_Modificar", ID_SubRubro, ID_Rubro, Descripcion, URL, Imagen, Orden, Estado)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function BuscarOrdenSugeridoPorID_Rubro(id_rubro As Integer) As DataSet
        Try
            Return ODatabase.ExecuteDataSet("SubRubros_BuscarOrdenSugeridoPorID_Rubro", id_rubro)
        Catch ex As System.Exception
            Throw ex
        End Try

    End Function

End Class

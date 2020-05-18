Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data

'*************************************************************************************************
'Clase Generada por IDEAS SA
'*************************************************************************************************

Public Class UbicacionesWeb

    Dim oDatabase As Database

    Public Sub New()

        oDatabase = DatabaseFactory.CreateDatabase("Conn")

    End Sub

    Public Sub New(ByVal str As String)
    End Sub

    Public Function BuscarPorID(ByVal ID_Ubicacion As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("UbicacionesWeb_BuscarPorID", ID_Ubicacion)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function


    Public Function BuscarTodos() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("UbicacionesWeb_BuscarTodos")
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function Agregar(ByVal Descripcion As String, ByVal Reducida As String, ByVal GeoLatitud As String, ByVal GeoLongitud As String, ByVal Activo As Boolean) As Double
        Try
            Return oDatabase.ExecuteScalar("UbicacionesWeb_Agregar", Descripcion, Reducida, GeoLatitud, GeoLongitud, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function Modificar(ByVal ID_Ubicacion As Integer, ByVal Descripcion As String, ByVal Reducida As String, ByVal GeoLatitud As String, ByVal GeoLongitud As String, ByVal Activo As Boolean) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("UbicacionesWeb_Modificar", ID_Ubicacion, Descripcion, Reducida, GeoLatitud, GeoLongitud, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal ID_Ubicacion As Double) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("UbicacionesWeb_Eliminar", ID_Ubicacion)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function

End Class

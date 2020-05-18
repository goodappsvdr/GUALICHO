Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class Sponsors
    Dim oDatabase As Database

    Public Sub New()

        oDatabase = DatabaseFactory.CreateDatabase("Conn")

    End Sub
    Public Sub New(ByVal str As String)
    End Sub

    Public Function BuscarTodos() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Sponsors_BuscarTodos")
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function


    Public Function BuscarPorID(id_sponsor As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Sponsors_BuscarPorID", id_sponsor)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function


    Public Function Agregar(Descripcion As String, Imagen As String, Activo As Boolean) As Double
        Try
            Return oDatabase.ExecuteScalar("Sponsors_Agregar", Descripcion, Imagen, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function ModificarBEWeb(ID_Sponsor As Integer, Descripcion As String, Activo As Boolean) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Sponsors_ModificarBEWeb", ID_Sponsor, Descripcion, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function ModificarImagen(ID_Sponsor As Integer, Imagen As String) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Sponsors_ModificarImagen", ID_Sponsor, Imagen)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

End Class

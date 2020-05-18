Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class Notificaciones
    Dim oDatabase As Database

    Public Sub New()

        oDatabase = DatabaseFactory.CreateDatabase("Conn")

    End Sub
    Public Function BuscarTodos() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Notificaciones_BuscarTodos")
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function Agregar(ID_Item As Integer, Descripcion As String, Fecha As Date) As DataSet
        Try
            Return oDatabase.ExecuteScalar("Notificaciones_Agregar", ID_Item, Descripcion, Fecha)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
End Class

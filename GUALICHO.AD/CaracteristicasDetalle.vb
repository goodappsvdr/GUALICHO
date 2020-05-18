Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class CaracteristicasDetalle
    Dim oDatabase As Database

    Public Sub New()

        oDatabase = DatabaseFactory.CreateDatabase("Conn")

    End Sub
    Public Sub New(ByVal str As String)
    End Sub
    Public Function BuscarTodos() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("CaracteristicasDetalle_BuscarTodos")
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function BuscarPorID(ID_CaracteristicaDetalle As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("CaracteristicasDetalle_BuscarPorID", ID_CaracteristicaDetalle)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function Agregar(ID_Caracteristica As Integer, Descripcion As String, Estado As Integer) As Double
        Try
            Return oDatabase.ExecuteScalar("CaracteristicasDetalle_Agregar", ID_Caracteristica, Descripcion, Estado)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function Modificar(ID_CaracteristicaDetalle As Integer, ID_Caracteristica As Integer, Descripcion As String, Estado As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("CaracteristicasDetalle_Modificar", ID_CaracteristicaDetalle, ID_Caracteristica, Descripcion, Estado)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
End Class

Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class ItemsPrecios

    Dim oDatabase As Database

    Public Sub New()

        oDatabase = DatabaseFactory.CreateDatabase("Conn")

    End Sub
    Public Sub New(ByVal str As String)
    End Sub
    Public Function BuscarTodos() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("ItemsPrecios_BuscarTodos")
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function BuscarPorID(ID_ItemPrecio As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("ItemsPrecios_BuscarPorID", ID_ItemPrecio)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function BuscarPorID_Item(ID_Item As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("ItemsPrecios_BuscarPorID_Item", ID_Item)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function Agregar(ID_Item As Integer, ID_PrecioTipo As Integer, valor As String) As Double
        Try
            Return oDatabase.ExecuteScalar("ItemsPrecios_Agregar", ID_Item, ID_PrecioTipo, valor)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function Modificar(ID_Item As Integer, ID_PrecioTipo As Integer, valor As String) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("ItemsPrecios_Modificar", ID_Item, ID_PrecioTipo, valor)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
End Class


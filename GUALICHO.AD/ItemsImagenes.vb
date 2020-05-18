Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class ItemsImagenes
    Dim ODatabase As Database

    Public Sub New()
        ODatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub

    Public Sub New(ByVal str As String)
    End Sub
 
    Public Function ItemsImagenes_BuscarPorID_Item(ID_Item As Integer)
        Try

            Return ODatabase.ExecuteDataSet("ItemsImagenes_BuscarPorID_Item", ID_Item)

        Catch ex As System.Exception
            Throw ex
        End Try
    End Function



    Public Function BuscarTodos() As DataSet
        Try
            Return ODatabase.ExecuteDataSet("ItemsImagenes_BuscarTodos")
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function Agregar(ID_Item As Integer, Imagen As String, Activo As Boolean) As Double
        Try
            Return ODatabase.ExecuteScalar("ItemsImagenes_Agregar", ID_Item, Imagen, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function Modificar(ID_ItemImagen As Integer, ID_Item As Integer, Imagen As String, Activo As Boolean) As DataSet
        Try
            Return ODatabase.ExecuteDataSet("ItemsImagenes_Modificar", ID_ItemImagen, ID_Item, Imagen, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function ModificarBEWeb(ID_ItemImagen As Integer, ID_Item As Integer, Activo As Boolean) As DataSet
        Try
            Return ODatabase.ExecuteDataSet("ItemsImagenes_ModificarBEWeb", ID_ItemImagen, ID_Item, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function ModificarImagen(ID_ItemImagen As Integer, Imagen As String) As DataSet
        Try
            Return ODatabase.ExecuteDataSet("ItemsImagenes_ModificarImagen", ID_ItemImagen, Imagen)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function BuscarPorID(ID_ItemImagen As Integer) As DataSet
        Try
            Return ODatabase.ExecuteDataSet("ItemsImagenes_BuscarPorID", ID_ItemImagen)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function ItemsImagenes_Eliminar(ID_ItemImagen As Integer) As DataSet
        Try
            Return ODatabase.ExecuteDataSet("ItemsImagenes_Eliminar", ID_ItemImagen)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

End Class

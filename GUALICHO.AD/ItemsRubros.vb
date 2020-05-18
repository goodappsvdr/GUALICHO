Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class ItemsRubros
    Dim ODatabase As Database

    Public Sub New()
        ODatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub
    Public Function ItemsRubros_BuscarPorID_RubroMasVendidos(ByVal ID_Rubro As Integer)
        Try

            Return ODatabase.ExecuteDataSet("ItemsRubros_BuscarPorID_RubroMasVendidos", ID_Rubro)

        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function ItemsRubros_BuscarTodos_MasVendidos()
        Try

            Return ODatabase.ExecuteDataSet("ItemsRubros_BuscarTodos_MasVendidos")

        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function ItemsRubros_BuscarPorID_RubroMasVendidos2(ByVal ID_Rubro As Integer)
        Try

            Return ODatabase.ExecuteDataSet("ItemsRubros_BuscarPorID_RubroMasVendidos2", ID_Rubro)

        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function ItemsRubros_BuscarPorID_RubroMasVendidos3(ByVal ID_Rubro As Integer)
        Try

            Return ODatabase.ExecuteDataSet("ItemsRubros_BuscarPorID_RubroMasVendidos3", ID_Rubro)

        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function ItemsRubros_BuscarPorID_Item(ByVal ID_Item As Integer)
        Try

            Return ODatabase.ExecuteDataSet("ItemsRubros_BuscarPorID_Item", ID_Item)

        Catch ex As System.Exception
            Throw ex
        End Try



    End Function
    Public Function ItemsRubros_BuscarPorID_Rubro(ByVal ID_Rubro As Integer)
        Try

            Return ODatabase.ExecuteDataSet("ItemsRubros_BuscarPorID_Rubro", ID_Rubro)

        Catch ex As System.Exception
            Throw ex
        End Try



    End Function



    Public Function ItemsRubros_BuscarPorID_Rubro_Random(ByVal ID_Rubro As Integer)
        Try

            Return ODatabase.ExecuteDataSet("ItemsRubros_BuscarPorID_Rubro_Random", ID_Rubro)

        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function ItemsRubros_BuscarUltimosProductosSubidos()
        Try

            Return ODatabase.ExecuteDataSet("ItemsRubros_BuscarUltimosProductosSubidos")

        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function Agregar(ID_Item As Integer, ID_Rubro As Integer, ID_SubRubro As Integer) As Double
        Try
            Return ODatabase.ExecuteScalar("ItemsRubros_Agregar", ID_Item, ID_Rubro, ID_SubRubro)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function Modificar(ID_Item As Integer, ID_Rubro As Integer, ID_SubRubro As Integer) As DataSet
        Try
            Return ODatabase.ExecuteDataSet("ItemsRubros_Modificar", ID_Item, ID_Rubro, ID_SubRubro)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

End Class

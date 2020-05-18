Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.IO
Public Class Items
    Dim oDatabase As Database

    Public Sub New()
        oDatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub


    'constructor base con parametros
    Public Sub New(ByVal str As String)
    End Sub
    Public Function Items_BuscarporID_Item(ID_Item As Integer)
        Try

            Return ODatabase.ExecuteDataSet("Items_BuscarporID_Item", ID_Item)

        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function Eliminar(ID_Item As Integer)
        Try

            Return oDatabase.ExecuteDataSet("Items_Eliminar", ID_Item)

        Catch ex As System.Exception
            Throw ex
        End Try
    End Function


    Public Function BuscarTodos() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Items_BuscarTodos")
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function


    Public Function BuscarUltimos8() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Items_BuscarUltimos8")
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function BuscarTodosBEWeb() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Items_BuscarTodosBEWeb")
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function


    Public Function Items_BuscarPorID_MarcaYporID_Rubro(ID_Rubro As Integer, ID_Marca As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Items_BuscarPorID_MarcaYporID_Rubro", ID_Rubro, ID_Marca)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function




    Public Function Items_BuscarPorID_RubroYporID_SubRubro(ID_Rubro As Integer, ID_SubRubro As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Items_BuscarPorID_RubroYporID_SubRubro", ID_Rubro, ID_SubRubro)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function


    Public Function Items_BuscarPorID_SubRubroPorPagina(ID_Rubro As Integer, ID_SubRubro As Integer, Parametro1 As Integer, Parametro2 As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Items_BuscarPorID_SubRubroPorPagina", ID_Rubro, ID_SubRubro, Parametro1, Parametro2)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function Items_BuscarTodosUsados(Parametro1 As Integer, Parametro2 As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Items_BuscarTodosUsados", Parametro1, Parametro2)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function




    Public Function Items_BuscarPorID_SubRubroYporID_MarcaPorPagina(ID_SubRubro As Integer, ID_Marca As Integer, Parametro1 As Integer, Parametro2 As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Items_BuscarPorID_SubRubroYporID_MarcaPorPagina", ID_SubRubro, ID_Marca, Parametro1, Parametro2)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function Items_BuscarPorID_RubroYporID_MarcaPorPagina(ID_Rubro As Integer, ID_Marca As Integer, Parametro1 As Integer, Parametro2 As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Items_BuscarPorID_RubroYporID_MarcaPorPagina", ID_Rubro, ID_Marca, Parametro1, Parametro2)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function





    Public Function Items_BuscarPorID_SubRubroYporID_Marca(ID_SubRubro As Integer, ID_Marca As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Items_BuscarPorID_SubRubroYporID_Marca", ID_SubRubro, ID_Marca)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function Items_BuscarPorID_SubRubroYporID_MarcaBEWeb(ID_SubRubro As Integer, ID_Marca As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Items_BuscarPorID_SubRubroYporID_MarcaBEWeb", ID_SubRubro, ID_Marca)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function


    Public Function Items_BuscarPorID_Rubro(ID_Rubro As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Items_BuscarPorID_Rubro", ID_Rubro)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function Items_BuscarPorID_Rubro_N(ID_Rubro As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Items_BuscarPorID_Rubro_N", ID_Rubro)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function



    Public Function Items_BuscarPorID_RubroYID_SubRubro_N(ID_Rubro As Integer, ID_SubRubro As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Items_BuscarPorID_RubroYID_SubRubro_N", ID_Rubro, ID_SubRubro)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function


    Public Function Items_BuscarStockActual_PorID_Item(ID_Item As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Items_BuscarStockActual_PorID_Item", ID_Item)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function Items_BuscarPorID_RubroPorPagina(ID_Rubro As Integer, Parametro1 As Integer, Parametro2 As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Items_BuscarPorID_RubroPorPagina", ID_Rubro, Parametro1, Parametro2)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function Items_BusquedaGenerica(busqueda As String, Parametro1 As Integer, Parametro2 As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Items_BusquedaGenerica", busqueda, Parametro1, Parametro2)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function Items_BusquedaGenerica_HC(busqueda As String) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Items_BusquedaGenerica_HC", busqueda)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function


    Public Function Agregar(Descripcion As String, Detalle As String, Extendida As String, Imagen As String, Url As String, StockActual As String, Estado As Integer, ID_Marca As Integer, Activo As Boolean, EsServicio As Boolean, ID_TipoItem As Integer) As Double
        Try
            Return oDatabase.ExecuteScalar("Items_Agregar", Descripcion, Detalle, Extendida, Imagen, Url, StockActual, Estado, ID_Marca, Activo, EsServicio, ID_TipoItem)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function Items_ActualizarStock(ID_Item As Integer, CantidadItemsPedidos As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Items_ActualizarStock", ID_Item, CantidadItemsPedidos)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function Modificar(ID_Item As Integer, Descripcion As String, Detalle As String, Extendida As String, Imagen As String, Url As String, StockActual As String, Estado As Integer, ID_Marca As Integer, Activo As Boolean, EsServicio As Boolean, ID_TipoItem As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Items_Modificar", ID_Item, Descripcion, Detalle, Extendida, Imagen, Url, StockActual, Estado, ID_Marca, Activo, EsServicio, ID_TipoItem)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function ModificarBEWeb(ID_Item As Integer, Descripcion As String, Detalle As String, Extendida As String, Url As String, StockActual As String, Estado As Integer, ID_Marca As Integer, Activo As Boolean, EsServicio As Boolean, ID_TipoItem As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Items_ModificarBEWeb", ID_Item, Descripcion, Detalle, Extendida, Url, StockActual, Estado, ID_Marca, Activo, EsServicio, ID_TipoItem)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function ModificarImagen(ID_Item As Integer, Imagen As String) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Items_ModificarImagen", ID_Item, Imagen)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function BuscarPorID(ID_Item As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Items_BuscarPorID", ID_Item)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function Items_BusquedaGenericaCantidadPaginas(Busqueda As String) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Items_BusquedaGenericaCantidadPaginas", Busqueda)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function


    Public Function CargarPaginas_PorID_Rubro(ID_Rubro) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("CargarPaginas_PorID_Rubro", ID_Rubro)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function CargarPaginas_PorID_SubRubro(ID_SubRubro) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("CargarPaginas_PorID_SubRubro", ID_SubRubro)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function TiposItems_BuscarTodos() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("TiposItems_BuscarTodos")
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function





End Class

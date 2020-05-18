Imports HIERCONS.AD
Imports System.Globalization
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Imports System.Security.Cryptography


Module ModuloPrincipal

    Public conexion As SqlConnection
    Public transaccion As SqlTransaction

    Public Sub Main()


        conexion = New SqlConnection(ConfigurationManager.ConnectionStrings("Conn").ConnectionString)

        Try
            conexion.Open()
        Catch ex As Exception

            'MsgBox(ex.Message)

        End Try

    End Sub

    Public Sub IniciaTransaccion()
        transaccion = conexion.BeginTransaction
    End Sub

    Public Sub FinalizaTransaccion()
        transaccion.Commit()
    End Sub

    Public Sub CancelaTransaccion()
        On Error Resume Next
        transaccion.Rollback()
    End Sub


    Public Function FechaHoraServidor() As Date

        Dim oObjeto As New Sistema
        Dim oDs As New DataSet

        oDs = oObjeto.FechaHoraServidor

        Return oDs.Tables(0).Rows(0).Item("FechaHora")

        oDs = Nothing
        oObjeto = Nothing

    End Function

  


    Public Function SingletonParametro(ByVal Categoria As String, ByVal Nombre As String) As String

        Dim oObjeto As New Parametros
        Dim oDs As New DataSet

        oDs = oObjeto.BuscarPorCategoriaNombre(Categoria, Nombre)

        If oDs.Tables(0).Rows.Count > 0 Then

            Return oDs.Tables(0).Rows(0).Item("Valor")

        Else
            Return ""

        End If

    End Function

    Public Function SingletonCategoria(ByVal Categoria As String, ByVal Nombre As String) As String

        Dim oObjeto As New Categorias
        Dim oDs As New DataSet

        oDs = oObjeto.BuscarPorCategoriaTipoNombre(Categoria, Nombre)

        If oDs.Tables(0).Rows.Count > 0 Then

            Return oDs.Tables(0).Rows(0).Item("Id_Categoria")

        Else
            Return ""

        End If

    End Function

    Public Function SingletonEstado(ByVal Categoria As String, ByVal Nombre As String) As String

        Dim oObjeto As New Estados
        Dim oDs As New DataSet

        oDs = oObjeto.BuscarPorCategoriaNombre(Categoria, Nombre)

        If oDs.Tables(0).Rows.Count > 0 Then

            Return oDs.Tables(0).Rows(0).Item("ID_Estado")

        Else
            Return ""

        End If

    End Function

  



End Module

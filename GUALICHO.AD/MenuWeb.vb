Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class MenuWeb
    Dim ODatabase As Database

    Public Sub New()
        ODatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub

    Public Sub New(ByVal str As String)
    End Sub

    'Public Function BuscarTodosPadre()
    '    Try

    '        Return ODatabase.ExecuteDataSet("MenuWeb_BuscarTodosPadre")

    '    Catch ex As System.Exception
    '        Throw ex
    '    End Try
    'End Function
    Public Function BuscarTodos()
        Try
            Return ODatabase.ExecuteDataSet("MenuWeb_BuscarTodos")
        Catch ex As Exception

        End Try
    End Function

    Public Function BuscarTodosHijos()
        Try

            Return ODatabase.ExecuteDataSet("MenuWeb_BuscarTodosHijos")

        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function BuscarTodosPadre(ByVal ID_MenuPadre As Integer)
        Try

            Return ODatabase.ExecuteDataSet("MenuWEB_BuscarPorID_MenuPadre", ID_MenuPadre)

        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function BuscarHijos(ByVal ID_MenuPadre As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("MenuWEB_BuscarHijos", ID_MenuPadre)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function BuscarPorID(ByVal ID_MenuWeb As Integer)
        Try

            Return ODatabase.ExecuteDataSet("MenuWeb_BuscarPorID", ID_MenuWeb)

        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function Agregar(ByVal Descripcion As String, ByVal Reducida As String, ByVal Detalle As String, ByVal URL As String, ByVal ID_MenuPadre As Integer, ByVal Orden As Integer, ByVal Activo As Boolean, ByVal ID_Rubro As Integer, ByVal ID_SubRubro As Integer) As Double
        Try
            Return ODatabase.ExecuteScalar("MenuWEB_Agregar", Descripcion, Reducida, Detalle, URL, ID_MenuPadre, Orden, Activo, ID_Rubro, ID_SubRubro)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function Modificar(ByVal ID_Menu As Integer, ByVal Descripcion As String, ByVal Reducida As String, ByVal Detalle As String, ByVal URL As String, ByVal ID_MenuPadre As Integer, ByVal Orden As Integer, ByVal Activo As Boolean, ByVal ID_Rubro As Integer, ByVal ID_SubRubro As Integer) As DataSet
        Try
            Return ODatabase.ExecuteDataSet("MenuWEB_Modificar", ID_Menu, Descripcion, Reducida, Detalle, URL, ID_MenuPadre, Orden, Activo, ID_Rubro, ID_SubRubro)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
End Class

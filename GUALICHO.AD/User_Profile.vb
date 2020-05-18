Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class User_Profile
    Dim oDatabase As Database

    Public Sub New()

        oDatabase = DatabaseFactory.CreateDatabase("Conn")

    End Sub

    Public Sub New(ByVal str As String)
    End Sub

    Public Function BuscarTodos() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("User_Profile_BuscarTodos")
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function CambiarPass_Recuperar(email As String, pass As String) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Usuarios_CambiarPass_Recuperar", email, pass)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function BuscarPorLinkActivador(Link As String) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Usuarios_BuscarPorLinkActivador", Link)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function


    Public Function Agregar(ByVal UserID As Guid, ByVal Usuario As String, ByVal Nombre As String, ByVal Apellido As String, ByVal RazonSocial As String, ByVal Cuit As String, id_tipo As Integer)
        Try
            Return oDatabase.ExecuteScalar("User_Profile_Agregar", UserID, Usuario, Nombre, Apellido, RazonSocial, Cuit, id_tipo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function UsuariosSistema_ModificarEstado(ByVal UserId As Guid, ByVal Estado As Boolean) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("UsuariosSistema_ModificarEstado", UserId, Estado)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function BuscarPorUserId(UserID As Guid)
        Try
            Return oDatabase.ExecuteDataSet("User_Profile_BuscarPorUserId", UserID)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function BuscarTokenPorUsuario(Usuario As String)
        Try
            Return oDatabase.ExecuteDataSet("User_Profile_BuscarTokenPorUsuario", Usuario)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function User_Profile_ActualizarToken(UserID As Guid, token As String)
        Try
            Return oDatabase.ExecuteDataSet("User_Profile_ActualizarToken", UserID, token)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function Usuarios_ModificarEstado(ByVal UserId As Guid, ByVal link As String) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Usuarios_ModificarEstado", UserId, link)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

End Class

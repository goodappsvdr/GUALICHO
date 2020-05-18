Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data

'*************************************************************************************************
'Clase Generada por IDEAS SA
'*************************************************************************************************

Public Class Sistema

    Dim oDatabase As Database

    Public Sub New()

        oDatabase = DatabaseFactory.CreateDatabase("Conn")

    End Sub

    Public Sub New(ByVal str As String)
    End Sub

    Public Function FechaHoraServidor() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Servidor_FechaHora")
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function


End Class

Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Configuration
Public Class ConnectionManagement

    Public Shared Function GetConnection() As SqlConnection
        ' Dim constr As String = "Data Source=localhost\sql2008r2;Initial Catalog=SMFGS_DB;Persist Security Info=True;User ID=sa;Password=123456" ' System.Configuration.ConfigurationManager.ConnectionStrings("TICERConnectionString").ConnectionString

        Dim constr As String = ConfigurationManager.ConnectionStrings("DBConnectionString").ConnectionString

        ' Dim constr As String = "Data Source=newrpserver\sqlexpress;Initial Catalog=GMSDB;Persist Security Info=True;User ID=sa;Password=123456" ' System.Configuration.ConfigurationManager.ConnectionStrings("TICERConnectionString").ConnectionString

        Dim conn As New SqlConnection(constr)
        Return conn
    End Function

End Class

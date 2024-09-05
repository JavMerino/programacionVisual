Imports System.Data.SqlClient

Public Class Conexion
    ' Cadena de conexión
    Private connectionString As String = "Server=LAPTOP-18GHK3E1\SQLEXPRESS;Database=prestamoLibro;Trusted_Connection=True;"
    Private connection As SqlConnection

    ' Constructor de la clase
    Public Sub New()
        connection = New SqlConnection(connectionString)
    End Sub

    ' Método para abrir la conexión
    Public Function AbrirConexion() As SqlConnection
        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
        Catch ex As Exception
            MessageBox.Show("Error al abrir la conexión: " & ex.Message)
        End Try
        Return connection
    End Function

    ' Método para cerrar la conexión
    Public Sub CerrarConexion()
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Error al cerrar la conexión: " & ex.Message)
        End Try
    End Sub
End Class

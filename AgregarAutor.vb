Imports System.Data.SqlClient

Public Class AgregarAutor
    Private conexion As New Conexion()
    Private Sub btnAnadir_Click(sender As Object, e As EventArgs) Handles btnAnadir.Click
        ' Abre la conexión a la base de datos
        Dim conn As SqlConnection = conexion.AbrirConexion()

        Try
            ' Crea la consulta SQL usando parámetros
            Dim query As String = "INSERT INTO Autor (Nombre, Apellido, Seudonimo, Nacionalidad) VALUES (@Nombre, @Apellido, @Seudonimo, @Nacionalidad)"

            ' Prepara el comando SQL
            Using cmd As New SqlCommand(query, conn)
                ' Agrega los parámetros con los valores de los TextBox
                cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text)
                cmd.Parameters.AddWithValue("@Apellido", txtApellido.Text)
                cmd.Parameters.AddWithValue("@Seudonimo", txtSeudo.Text)
                cmd.Parameters.AddWithValue("@Nacionalidad", txtNac.Text)

                ' Ejecuta el comando
                cmd.ExecuteNonQuery()

                ' Opcional: mostrar un mensaje indicando que el registro fue agregado correctamente
                MessageBox.Show("El autor ha sido agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            ' Maneja cualquier error que ocurra durante la ejecución
            MessageBox.Show("Ocurrió un error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Cierra la conexión a la base de datos
            conn.Close()
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Hide()
    End Sub
End Class
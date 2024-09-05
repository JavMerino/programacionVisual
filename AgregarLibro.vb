Imports System.Data.SqlClient
Imports System.Transactions

Public Class AgregarLibro
    ' Inicializar la variable objConect con una nueva instancia de Conexion
    Private conexion As New Conexion()

    Private Sub btnAgregarAutor_Click(sender As Object, e As EventArgs) Handles btnAgregarAutor.Click
        AgregarAutor.Show()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Hide()
    End Sub

    Private Sub AgregarLibro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbEstado.Items.Add(0)
        cbEstado.Items.Add(1)
        cargarCategorias()
        cargarEditoriales()
        cargarAutores()
    End Sub

    Public Sub cargarCategorias()
        Dim conn As SqlConnection = conexion.AbrirConexion()

        Try
            Dim query As String = "SELECT idCategoria, Nombre FROM Categoria"
            Using cmd As New SqlCommand(query, conn)
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                cbCategoria.Items.Clear()

                While reader.Read()
                    Dim item As New ComboBoxItem()
                    item.Text = reader("Nombre").ToString()
                    item.Value = reader("idCategoria").ToString()
                    cbCategoria.Items.Add(item)
                End While

                reader.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub cargarEditoriales()
        Dim conn As SqlConnection = conexion.AbrirConexion()

        Try
            Dim query As String = "SELECT idEditorial, Nombre FROM Editorial"
            Using cmd As New SqlCommand(query, conn)
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                cbEditorial.Items.Clear()

                While reader.Read()
                    Dim item As New ComboBoxItem()
                    item.Text = reader("Nombre").ToString()
                    item.Value = reader("idEditorial").ToString()
                    cbEditorial.Items.Add(item)
                End While

                reader.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub cargarAutores()
        Dim conn As SqlConnection = conexion.AbrirConexion()
        Try
            Dim query As String = "SELECT idAutor, Nombre, Apellido FROM Autor"
            Using cmd As New SqlCommand(query, conn)
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                cbAutor.Items.Clear()

                While reader.Read()
                    Dim item As New ComboBoxItem()
                    item.Text = reader("Nombre").ToString() & " " & reader("Apellido").ToString()
                    item.Value = reader("idAutor").ToString()
                    cbAutor.Items.Add(item)
                End While

                reader.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Class ComboBoxItem
        Public Property Text As String
        Public Property Value As String

        Public Overrides Function ToString() As String
            Return Text
        End Function
    End Class

    Private Function GetSelectedId(comboBox As ComboBox) As String
        Dim selectedItem As ComboBoxItem = CType(comboBox.SelectedItem, ComboBoxItem)
        Return If(selectedItem IsNot Nothing, selectedItem.Value, String.Empty)
    End Function

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        ' Verifica que todos los campos estén completos
        If String.IsNullOrWhiteSpace(txtTitulo.Text) OrElse
       nudCantidad.Value <= 0 OrElse
       String.IsNullOrWhiteSpace(GetSelectedId(cbCategoria)) OrElse
       String.IsNullOrWhiteSpace(GetSelectedId(cbEditorial)) OrElse
       cbAutor.SelectedItem Is Nothing Then
            MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Abre la conexión
        Dim conn As SqlConnection = conexion.AbrirConexion()
        Dim transaction As SqlTransaction = Nothing

        Try
            ' Comienza una transacción
            transaction = conn.BeginTransaction()

            ' Consulta para insertar el nuevo libro y obtener su ID
            Dim queryInsertLibro As String = "INSERT INTO Libro (Titulo, cantidad, Estado, idCategoria, idEditorial) OUTPUT INSERTED.idLibro VALUES (@Titulo, @Cantidad, @Estado, @CategoriaId, @EditorialId)"

            ' Crear el comando para insertar libro
            Dim idLibro As Integer
            Using cmd As New SqlCommand(queryInsertLibro, conn, transaction)
                ' Agregar los parámetros
                cmd.Parameters.AddWithValue("@Titulo", txtTitulo.Text)
                cmd.Parameters.AddWithValue("@Cantidad", nudCantidad.Value)
                cmd.Parameters.AddWithValue("@Estado", cbEstado.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@CategoriaId", GetSelectedId(cbCategoria))
                cmd.Parameters.AddWithValue("@EditorialId", GetSelectedId(cbEditorial))

                ' Ejecutar la consulta e insertar el libro
                idLibro = CInt(cmd.ExecuteScalar())
            End Using

            ' Verifica si el idLibro se obtuvo correctamente
            If idLibro <= 0 Then
                Throw New Exception("Error al insertar el libro y obtener el ID.")
            End If

            ' Consulta para insertar en la tabla AutorLibro
            Dim queryInsertAutorLibro As String = "INSERT INTO AutorLibro (idAutor, idLibro) VALUES (@idAutor, @idLibro)"

            ' Crear el comando para insertar en AutorLibro
            Using cmdAutorLibro As New SqlCommand(queryInsertAutorLibro, conn, transaction)
                ' Agregar los parámetros
                cmdAutorLibro.Parameters.AddWithValue("@idAutor", GetSelectedId(cbAutor))
                cmdAutorLibro.Parameters.AddWithValue("@idLibro", idLibro)

                ' Ejecutar la consulta para insertar en AutorLibro
                cmdAutorLibro.ExecuteNonQuery()
            End Using

            ' Confirmar la transacción
            transaction.Commit()

            MessageBox.Show("Libro agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            ' Manejar errores y revertir la transacción en caso de error
            MessageBox.Show("Ocurrió un error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If transaction IsNot Nothing Then
                Try
                    transaction.Rollback()
                Catch rollbackEx As Exception
                    MessageBox.Show("Error al revertir la transacción: " & rollbackEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Finally
            ' Cerrar la conexión
            conn.Close()
        End Try
    End Sub

End Class
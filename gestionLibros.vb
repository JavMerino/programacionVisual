Imports System.Data.SqlClient

Public Class gestionLibros
    Private conexion As New Conexion()
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregarLibro.Click
        AgregarLibro.Show()
    End Sub

    Private Sub gestionLibros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarLibrosEnDataGridView()
    End Sub
    Private Sub CargarLibrosEnDataGridView()
        ' Abre la conexión
        Dim conn As SqlConnection = Conexion.AbrirConexion()

        Try
            ' Consulta para obtener los datos de la tabla Libro
            Dim query As String = "SELECT * FROM Libro"

            ' Crear el adaptador de datos
            Dim dataAdapter As New SqlDataAdapter(query, conn)

            ' Crear el DataTable para almacenar los datos
            Dim dataTable As New DataTable()

            ' Llenar el DataTable con los datos obtenidos
            dataAdapter.Fill(dataTable)

            ' Asignar el DataTable como la fuente de datos del DataGridView
            dgvLibros.DataSource = dataTable
        Catch ex As Exception
            ' Manejar errores
            MessageBox.Show("Ocurrió un error al cargar los libros: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Cerrar la conexión
            conn.Close()
        End Try
    End Sub

End Class
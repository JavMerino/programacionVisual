Imports System.Data.SqlClient

Public Class prestamosVigentes
    ' Inicializar la variable objConect con una nueva instancia de Conexion
    Private conexion As New Conexion()

    Private Sub prestamosVigentes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim filtrandoPa As String = txtFiltro.Text
        CargarPrestamosVigentes(filtrandoPa)
    End Sub

    Private Sub CargarPrestamosVigentes(filtro As String)
        Dim conn As SqlConnection = conexion.AbrirConexion()
        Dim query As String

        ' Consulta SQL con filtro por título si se proporciona
        If filtro = "" Then
            query = "SELECT Libro.Titulo, Prestamo.FechaPrest, Prestamo.FechaLimit
                     FROM Prestamo 
                     INNER JOIN PrestamoEjemplar ON Prestamo.idPrestamo = PrestamoEjemplar.idPrestamo
                     INNER JOIN Ejemplar ON PrestamoEjemplar.idEjemplar = Ejemplar.idEjemplar
                     INNER JOIN Libro ON Ejemplar.idLibro = Libro.idLibro
                     WHERE Prestamo.Estado = 1;"
        Else
            query = $"SELECT Libro.Titulo, Prestamo.FechaPrest, Prestamo.FechaLimit
                     FROM Prestamo 
                     INNER JOIN PrestamoEjemplar ON Prestamo.idPrestamo = PrestamoEjemplar.idPrestamo
                     INNER JOIN Ejemplar ON PrestamoEjemplar.idEjemplar = Ejemplar.idEjemplar
                     INNER JOIN Libro ON Ejemplar.idLibro = Libro.idLibro
                     WHERE Prestamo.Estado = 0 AND Libro.Titulo LIKE '" + filtro + "%'"
        End If

        Dim command As New SqlCommand(query, conn)
        command.Parameters.AddWithValue("@filtro", filtro)

        Try
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)

            dgvPrestVigent.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos: " & ex.Message)
        Finally
            conexion.CerrarConexion()
        End Try
    End Sub

    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        CargarPrestamosVigentes(txtFiltro.Text())
    End Sub

    Private Sub dgvPrestVigent_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPrestVigent.CellContentClick

    End Sub
End Class

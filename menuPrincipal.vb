Public Class menuPrincipal
    Private Sub btnRegPrest_Click_1(sender As Object, e As EventArgs) Handles btnRegPrest.Click
        regPrestamo.Show()
        Me.Hide()
    End Sub
    Private Sub btnPrestVigent_Click_1(sender As Object, e As EventArgs) Handles btnPrestVigent.Click
        prestamosVigentes.Show()
        Me.Hide()
    End Sub

    Private Sub btnGestLibros_Click(sender As Object, e As EventArgs) Handles btnGestLibros.Click
        gestionLibros.Show()
        Me.Hide()
    End Sub

    Private Sub btnHistorial_Click(sender As Object, e As EventArgs) Handles btnHistorial.Click

    End Sub


End Class
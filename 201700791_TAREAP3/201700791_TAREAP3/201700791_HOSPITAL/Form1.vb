Public Class Form1
    Private Sub CalcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click

        If datosCorrectos() Then
            calcular()
        Else
            MessageBox.Show("No se han ingresado los datos de manera correcta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub MostrarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem1.Click
        mostrarDatos()
    End Sub

    Private Sub LimpiarMatrizToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LimpiarMatrizToolStripMenuItem1.Click
        limpiarMatriz()
    End Sub

    Private Sub LimpiarCamposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarCamposToolStripMenuItem.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim textoBuscar As String = TextBox5.Text
        consultarInfo(textoBuscar)
    End Sub

    Private Sub CalcularEstadisticasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularEstadisticasToolStripMenuItem.Click
        calculo()
        calculo2()
        calculo3()
    End Sub

    Private Sub LimpiarEstadisticasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEstadisticasToolStripMenuItem.Click
        Label8.Text = "0"
        Label10.Text = "Q 0.00"
        Label12.Text = "0"
    End Sub
End Class

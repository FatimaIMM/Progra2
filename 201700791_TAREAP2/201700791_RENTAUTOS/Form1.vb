Public Class Form1

    Dim alquilerHonda As Integer = 250
    Dim alquilerMercedes As Integer = 450
    Dim alquilerToyota As Integer = 325
    Dim alquilerMazda As Integer = 300

    Dim mensajeTotal As String = "Q "
    Dim nitCliente As Long = 0
    Dim placa As String = ""
    Dim diasAlquiler As Integer = 0
    Dim porcentajeEfectivo As Double = 0.0
    Dim porcentajeTarjeta As Double = 0.0
    Dim pagoParcial As Double = 0.0
    Dim descuento_recargo(30) As Double
    Dim arreglo_precio(30) As Double
    Dim total As Double = 0.0

    Dim contador As Integer = 1
    Dim contadorArray As Integer = 0

    Dim m1(10) As Double

    Private Sub CalcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click

        If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" Then

            nitCliente = CLng(TextBox1.Text)
            placa = TextBox2.Text
            diasAlquiler = CInt(TextBox3.Text)
            Dim alquiler As Integer = costoAlquiler()

            If alquiler > 0 Then

                pagoParcial = diasAlquiler * alquiler

                If pagoParcial > 0 Then

                    If ComboBox2.SelectedIndex = 0 Then

                        total = pagoParcial + pagoParcial * 0.025
                        insertarCargo(placa, ComboBox1.SelectedItem.ToString, diasAlquiler, pagoParcial, total)
                        Label13.Text = mensajeTotal + CStr(Math.Round(pagoParcial, 2))
                        Label15.Text = mensajeTotal + CStr(Math.Round(total, 2))

                    ElseIf ComboBox2.SelectedIndex = 1 Then

                        total = pagoParcial - pagoParcial * 0.05
                        insertarCargo(placa, ComboBox1.SelectedItem.ToString, diasAlquiler, pagoParcial, total)
                        Label13.Text = mensajeTotal + CStr(Math.Round(pagoParcial, 2))
                        Label15.Text = mensajeTotal + CStr(Math.Round(total, 2))

                    ElseIf ComboBox2.SelectedIndex = 2 Then

                        porcentajeEfectivo = CDbl(TextBox4.Text)
                        porcentajeTarjeta = CDbl(TextBox6.Text)
                        Dim totalPorcentaje As Double = porcentajeEfectivo + porcentajeTarjeta

                        If totalPorcentaje = 100 Then

                            insertarCargo(placa, ComboBox1.SelectedItem.ToString, diasAlquiler, pagoParcial, pagoParcial)
                            Label13.Text = mensajeTotal + CStr(Math.Round(pagoParcial, 2))
                            Label15.Text = mensajeTotal + CStr(Math.Round(pagoParcial, 2))

                        Else
                            MessageBox.Show("El total de porcentaje seleccionado no cumple con el 100% del pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If

                    Else
                        MessageBox.Show("No se ha seleccionado una opción válida para el tipo de pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                Else
                    MessageBox.Show("Debe ingresar una cantidad válida para el apartado Días alquilados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Else
                MessageBox.Show("No ha seleccionado un modelo válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Else

            MessageBox.Show("Se han dejado en blanco campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub

    Private Function costoAlquiler()

        If ComboBox1.SelectedIndex = 0 Then
            Return alquilerHonda
        ElseIf ComboBox1.SelectedIndex = 1 Then
            Return alquilerMercedes
        ElseIf ComboBox1.SelectedIndex = 2 Then
            Return alquilerToyota
        ElseIf ComboBox1.SelectedIndex = 3 Then
            Return alquilerMazda
        End If

        Return -1

    End Function

    Private Sub LimpiarEntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEntradasToolStripMenuItem.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox6.Text = ""
        Label13.Text = mensajeTotal + "0.0"
        Label15.Text = mensajeTotal + "0.0"
    End Sub

    Private Sub insertarCargo(placa As String, marca As String, diasAlquiler As Integer, pagoParcial As Double, pagoFinal As Double)
        ListBox1.Items.Add(CStr(contador) + ". " + placa)
        ListBox2.Items.Add(CStr(contador) + ". " + marca)
        ListBox3.Items.Add(CStr(contador) + ". " + CStr(diasAlquiler))
        ListBox4.Items.Add(CStr(contador) + ". Q " + CStr(Math.Round(pagoParcial, 2)))

        If contadorArray < 30 Then
            descuento_recargo(contadorArray) = pagoFinal - pagoParcial
            arreglo_precio(contadorArray) = pagoFinal
        End If

        contadorArray = contadorArray + 1
        contador = contador + 1
    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click

        Dim i As Integer = 0

        For i = 0 To 30 Step 1
            descuento_recargo(i) = -1
            arreglo_precio(i) = -1
        Next

        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        ListBox4.Items.Clear()

        contador = 1
        contadorArray = 0

    End Sub

End Class

Public Class Form1

    Dim clientes(0 To 20) As Cliente
    Dim mensajePago As String = "Q "
    Dim contadorClientes As Integer = 0
    Dim contadorListBox As Integer = 1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try

            Dim nombreCliente As String = TextBox1.Text
            Dim nit As Long = CLng(TextBox2.Text)
            Dim saldoAnterior As Decimal = Math.Round(CDec(TextBox3.Text), 2)
            Dim consumo As Integer = CInt(TextBox4.Text)
            Dim tipoServicio As String = ""
            Dim tarifa As String = ""

            If ComboBox1.SelectedIndex > -1 Then

                tipoServicio = ComboBox1.SelectedItem.ToString()

                If ComboBox2.SelectedIndex > -1 Then

                    tarifa = ComboBox2.SelectedItem.ToString()
                    Dim pagoInicial As Decimal = Math.Round(realizarCalculosPagoInicial(consumo, tipoServicio), 2)

                    If pagoInicial > 0 Then

                        Dim mensajePagoInicial As String = mensajePago + CStr(pagoInicial)
                        Label9.Text = mensajePagoInicial

                        Dim descuento As Decimal = Math.Round(realizarCalculoDescuento(pagoInicial, tarifa), 2)

                        Dim mora As Decimal = Math.Round(realizarCalculoMora(saldoAnterior), 2)
                        Dim totalPagar As Decimal = Math.Round(pagoInicial + mora - descuento)

                        Label7.Text = mensajePago + CStr(totalPagar)
                        insertarCliente(nombreCliente, nit, saldoAnterior, consumo, tipoServicio, tarifa, pagoInicial, descuento, mora, totalPagar)

                        If contadorClientes < 12 Then
                            llenarListBox(tipoServicio, tarifa, saldoAnterior, pagoInicial, mora, descuento, totalPagar)
                        End If

                    Else

                        MessageBox.Show("Se ha ingresado una cantidad de consumo inválida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    End If

                Else
                    MessageBox.Show("No se ha seleccionado una opción de tarifa válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Else
                MessageBox.Show("No se ha seleccionado una opción valida para el tipo de servicio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception

            MessageBox.Show("Se han ingresado información erronea o se ha dejado en blanco campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        contadorListBox = 1
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        ListBox4.Items.Clear()
        ListBox5.Items.Clear()
        ListBox6.Items.Clear()
        ListBox7.Items.Clear()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        contadorClientes = 0
        Array.Clear(clientes, 0, clientes.Length)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MessageBox.Show("Se han limpiado las listas con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Function realizarCalculosPagoInicial(consumo As Integer, tipoServicio As String) As Decimal

        Dim pagoInicial As Decimal = 0

        Select Case tipoServicio

            Case "Residencial"

                If consumo > 0 And consumo < 101 Then

                    Return consumo * 0.99

                ElseIf consumo > 100 And consumo < 301 Then

                    Return consumo * 1.2

                ElseIf consumo > 300 Then

                    Return consumo * 3

                End If

            Case "Industrial"

                If consumo > 0 And consumo < 101 Then

                    Return consumo * 1.99

                ElseIf consumo > 100 And consumo < 301 Then

                    Return consumo * 2.2

                ElseIf consumo > 300 Then

                    Return consumo * 4

                End If

        End Select

        Return pagoInicial

    End Function

    Private Function realizarCalculoDescuento(pagoInicial As Decimal, tipoTarifa As String)

        Dim descuentoTotal As Decimal = 0

        Select Case tipoTarifa

            Case "Social"

                descuentoTotal = pagoInicial * 0.2

            Case "No social"

                descuentoTotal = pagoInicial * 0.1

        End Select

        Return descuentoTotal

    End Function

    Private Function realizarCalculoMora(saldo As Decimal) As Decimal

        Dim totalMora As Decimal = 0

        If saldo > 0 Then
            totalMora = saldo * 0.02
        End If

        Return totalMora

    End Function

    Private Sub insertarCliente(nombreCliente As String, numNit As Long, saldoAnt As Decimal, consumo As Integer, tipoServicio As String, tipoTarifa As String, totalInicial As Decimal, totalDescuento As Decimal, totalMora As Decimal, pagoTotal As Decimal)

        If contadorClientes < 11 Then

            Dim clienteNuevo As New Cliente
            clienteNuevo.nombreCliente = nombreCliente
            clienteNuevo.nitCliente = numNit
            clienteNuevo.saldoAnteriorCliente = saldoAnt
            clienteNuevo.consumoCliente = consumo
            clienteNuevo.tipoServicio = tipoServicio
            clienteNuevo.tipoTarifa = tipoTarifa
            clienteNuevo.totalInicial = totalInicial
            clienteNuevo.totalDescuento = totalDescuento
            clienteNuevo.totalMora = totalMora
            clienteNuevo.pagoFinal = pagoTotal

            clientes(contadorClientes) = clienteNuevo
            contadorClientes = contadorClientes + 1

        Else
            MessageBox.Show("Se ha llegado al total de clientes soportados por el sistema.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If



    End Sub

    Private Sub llenarListBox(tipoServicio As String, tipoTarifa As String, saldoAnterior As Decimal, pagoInicial As Decimal, mora As Decimal, descuento As Decimal, pagoTotal As Decimal)

        ListBox1.Items.Add(CStr(contadorListBox) + ". " + tipoServicio)
        ListBox2.Items.Add(CStr(contadorListBox) + ". " + tipoTarifa)
        ListBox3.Items.Add(CStr(contadorListBox) + ". Q " + CStr(saldoAnterior))
        ListBox4.Items.Add(CStr(contadorListBox) + ". Q " + CStr(pagoInicial))
        ListBox5.Items.Add(CStr(contadorListBox) + ". Q " + CStr(mora))
        ListBox6.Items.Add(CStr(contadorListBox) + ". Q " + CStr(descuento))
        ListBox7.Items.Add(CStr(contadorListBox) + ". Q " + CStr(pagoTotal))

        contadorListBox = contadorListBox + 1

    End Sub

End Class

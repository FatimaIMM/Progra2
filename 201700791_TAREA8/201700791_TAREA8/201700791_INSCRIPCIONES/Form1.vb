Public Class Form1

    Dim nombre_estudiante As String = ""
    Dim carnet_estudiante As String = ""
    Dim nivel_estudio As String = ""
    Dim forma_pago As String = ""
    Dim carrera_diversificado As String = ""
    Dim cuota_mensual As Double = 0
    Dim cuota_inscripcion As Double = 0
    Dim pago_inicial As Double = 0
    Dim pago_final As Double = 0
    Dim contador As Integer = -1
    Dim matrix_data(7, 7) As Object

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        If ComboBox1.SelectedIndex = 1 Then
            Label4.Visible = True
            ComboBox2.Visible = True
        Else
            Label4.Visible = False
            ComboBox2.Visible = False
        End If

    End Sub

    Private Sub TotalGeneralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TotalGeneralToolStripMenuItem.Click

        nombre_estudiante = TextBox1.Text
        carnet_estudiante = TextBox2.Text
        nivel_estudio = ComboBox1.SelectedItem.ToString()
        forma_pago = ComboBox3.SelectedItem.ToString()

        If nivel_estudio = "Básico" Then

            cuota_mensual = 250.0
            cuota_inscripcion = 350.0
            pago_inicial = cuota_inscripcion + cuota_mensual

            If forma_pago = "Tarjeta de crédito" Then
                pago_final = pago_inicial + pago_inicial * 0.1
                insertarDato(nombre_estudiante, carnet_estudiante, nivel_estudio, "", forma_pago, pago_inicial, pago_final)
            Else
                insertarDato(nombre_estudiante, carnet_estudiante, nivel_estudio, "", forma_pago, pago_inicial, pago_inicial)
            End If

        Else

            cuota_mensual = 350.0
            cuota_inscripcion = 450.0
            pago_inicial = cuota_inscripcion + cuota_mensual

            carrera_diversificado = ComboBox2.SelectedItem.ToString()

            If forma_pago = "Tarjeta de crédito" Then
                pago_final = pago_inicial + pago_inicial * 0.1
                insertarDato(nombre_estudiante, carnet_estudiante, nivel_estudio, carrera_diversificado, forma_pago, pago_inicial, pago_final)
            Else
                insertarDato(nombre_estudiante, carnet_estudiante, nivel_estudio, carrera_diversificado, forma_pago, pago_inicial, pago_inicial)
            End If

        End If

    End Sub

    Private Sub insertarDato(nombre_estudiante As String, carnet_estudiante As String, nivel_estudio As String, carrera As String, forma_pago As String, subtotal As Double, total As Double)

        If contador = -1 Then
            DataGridView1.Rows.Clear()
            contador = 0
        End If

        Dim contadorRows As Integer = DataGridView1.Rows.Count - 1
        DataGridView1.Rows.Add()
        DataGridView1(0, contadorRows).Value = nombre_estudiante
        DataGridView1(1, contadorRows).Value = carnet_estudiante
        DataGridView1(2, contadorRows).Value = nivel_estudio
        DataGridView1(3, contadorRows).Value = carrera
        DataGridView1(4, contadorRows).Value = forma_pago
        DataGridView1(5, contadorRows).Value = "Q " + CStr(Math.Round(subtotal, 2))
        DataGridView1(6, contadorRows).Value = "Q " + CStr(Math.Round(total, 2))

        matrix_data(contador, 0) = nombre_estudiante
        matrix_data(contador, 1) = carnet_estudiante
        matrix_data(contador, 2) = nivel_estudio
        matrix_data(contador, 3) = carrera
        matrix_data(contador, 4) = forma_pago
        matrix_data(contador, 5) = subtotal
        matrix_data(contador, 6) = total
        contador = contador + 1

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub TotalGeneralToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TotalGeneralToolStripMenuItem1.Click

        Dim totalEncontrado As Double = 0

        For index0 = 0 To matrix_data.GetUpperBound(1)

            Try
                totalEncontrado = totalEncontrado + CDbl(matrix_data(index0, 5))
            Catch ex As Exception
                totalEncontrado = totalEncontrado + 0
            End Try

        Next

        Label7.Text = "Q " + CStr(Math.Round(totalEncontrado, 2))

    End Sub

    Private Sub TotalPorFormaDePagoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TotalPorFormaDePagoToolStripMenuItem.Click
        totalEfectivo()
        totalTarjetaCredito()
        totalTransferenciaACH()
        totalDepositoBancario()
    End Sub

    Private Sub totalEfectivo()

        Dim totalEncontrado As Double = 0

        For index0 = 0 To matrix_data.GetUpperBound(1)

            Try

                If CStr(matrix_data(index0, 4)) = "Efectivo" Then
                    totalEncontrado = totalEncontrado + CDbl(matrix_data(index0, 5))
                End If

            Catch ex As Exception
                totalEncontrado = totalEncontrado + 0
            End Try

        Next

        Label9.Text = "Q " + CStr(Math.Round(totalEncontrado, 2))

    End Sub

    Private Sub totalTarjetaCredito()

        Dim totalEncontrado As Double = 0

        For index0 = 0 To matrix_data.GetUpperBound(1)

            Try

                If CStr(matrix_data(index0, 4)) = "Tarjeta de crédito" Then
                    totalEncontrado = totalEncontrado + CDbl(matrix_data(index0, 5))
                End If

            Catch ex As Exception
                totalEncontrado = totalEncontrado + 0
            End Try

        Next

        Label11.Text = "Q " + CStr(Math.Round(totalEncontrado, 2))

    End Sub

    Private Sub totalTransferenciaACH()

        Dim totalEncontrado As Double = 0

        For index0 = 0 To matrix_data.GetUpperBound(1)

            Try

                If CStr(matrix_data(index0, 4)) = "Transferencia por ACH" Then
                    totalEncontrado = totalEncontrado + CDbl(matrix_data(index0, 5))
                End If

            Catch ex As Exception
                totalEncontrado = totalEncontrado + 0
            End Try

        Next

        Label13.Text = "Q " + CStr(Math.Round(totalEncontrado, 2))

    End Sub

    Private Sub totalDepositoBancario()

        Dim totalEncontrado As Double = 0

        For index0 = 0 To matrix_data.GetUpperBound(1)

            Try

                If CStr(matrix_data(index0, 4)) = "Depósito bancario" Then
                    totalEncontrado = totalEncontrado + CDbl(matrix_data(index0, 5))
                End If

            Catch ex As Exception
                totalEncontrado = totalEncontrado + 0
            End Try

        Next

        Label15.Text = "Q " + CStr(Math.Round(totalEncontrado, 2))

    End Sub

    Private Sub TotalPorNivelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TotalPorNivelToolStripMenuItem.Click
        totalBasico()
        totalDiversificado()
    End Sub

    Private Sub totalBasico()
        Dim totalEncontrado As Double = 0

        For index0 = 0 To matrix_data.GetUpperBound(1)

            Try

                If CStr(matrix_data(index0, 2)) = "Básico" Then
                    totalEncontrado = totalEncontrado + CDbl(matrix_data(index0, 5))
                End If

            Catch ex As Exception
                totalEncontrado = totalEncontrado + 0
            End Try

        Next

        Label17.Text = "Q " + CStr(Math.Round(totalEncontrado, 2))
    End Sub

    Private Sub totalDiversificado()
        Dim totalEncontrado As Double = 0

        For index0 = 0 To matrix_data.GetUpperBound(1)

            Try

                If CStr(matrix_data(index0, 2)) = "Diversificado" Then
                    totalEncontrado = totalEncontrado + CDbl(matrix_data(index0, 5))
                End If

            Catch ex As Exception
                totalEncontrado = totalEncontrado + 0
            End Try

        Next

        Label19.Text = "Q " + CStr(Math.Round(totalEncontrado, 2))
    End Sub

    Private Sub TotalInscritosPorCarreraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TotalInscritosPorCarreraToolStripMenuItem.Click
        totalPerito()
        totalBachillerato()
        totalElectronica()
        totalDiseño()
    End Sub

    Private Sub totalPerito()

        Dim totalEncontrado As Double = 0

        For index0 = 0 To matrix_data.GetUpperBound(1)

            Try

                If CStr(matrix_data(index0, 3)) = "Perito Contador" Then
                    totalEncontrado = totalEncontrado + 1
                End If

            Catch ex As Exception
                totalEncontrado = totalEncontrado + 0
            End Try

        Next

        Label21.Text = CStr(Math.Round(totalEncontrado, 2))

    End Sub

    Private Sub totalBachillerato()

        Dim totalEncontrado As Double = 0

        For index0 = 0 To matrix_data.GetUpperBound(1)

            Try

                If CStr(matrix_data(index0, 3)) = "Bachillerato" Then
                    totalEncontrado = totalEncontrado + 1
                End If

            Catch ex As Exception
                totalEncontrado = totalEncontrado + 0
            End Try

        Next

        Label23.Text = CStr(Math.Round(totalEncontrado, 2))

    End Sub

    Private Sub totalElectronica()

        Dim totalEncontrado As Double = 0

        For index0 = 0 To matrix_data.GetUpperBound(1)

            Try

                If CStr(matrix_data(index0, 3)) = "Electrónica" Then
                    totalEncontrado = totalEncontrado + 1
                End If

            Catch ex As Exception
                totalEncontrado = totalEncontrado + 0
            End Try

        Next

        Label25.Text = CStr(Math.Round(totalEncontrado, 2))

    End Sub

    Private Sub totalDiseño()

        Dim totalEncontrado As Double = 0

        For index0 = 0 To matrix_data.GetUpperBound(1)

            Try

                If CStr(matrix_data(index0, 3)) = "Diseño Gráfico" Then
                    totalEncontrado = totalEncontrado + 1
                End If

            Catch ex As Exception
                totalEncontrado = totalEncontrado + 0
            End Try

        Next

        Label27.Text = CStr(Math.Round(totalEncontrado, 2))

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Label7.Text = "Q "
        Label9.Text = "Q "
        Label11.Text = "Q "
        Label13.Text = "Q "
        Label15.Text = "Q "
        Label17.Text = "Q "
        Label19.Text = "Q "
        Label21.Text = "0"
        Label23.Text = "0"
        Label25.Text = "0"
        Label27.Text = "0"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        For index0 = 0 To matrix_data.GetUpperBound(0)

            For index1 = 0 To matrix_data.GetUpperBound(1)

                matrix_data(index0, index1) = ""

            Next

        Next

        MessageBox.Show("Matriz de datos limpiada con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

End Class

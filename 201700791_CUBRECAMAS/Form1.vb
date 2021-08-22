Imports System.Math

Public Class Form1

    Dim precioManoObra As Double = 0.0
    Dim mensajePrecioCosto As String = "Precio de costo:     Q "
    Dim mensajePrecioVenta As String = "Precio de venta:     Q "
    Dim mensajeTotal As String = "Total:     Q "
    Dim precioMaterialLino As Double = 15
    Dim precioMaterialAlgodon As Double = 23.99
    Dim precioMaterialSeda As Double = 30.99
    Dim precioMaterialHiloCrudo As Double = 39.99
    Dim opcionSeleccionada As Integer = 0
    Dim seleccionLino As Boolean
    Dim seleccionAlgodon As Boolean
    Dim seleccionSeda As Boolean
    Dim seleccionHiloCrudo As Boolean

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        precioManoObra = 65.5
        opcionSeleccionada = 1
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        precioManoObra = 85.99
        opcionSeleccionada = 2
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        precioManoObra = 99.99
        opcionSeleccionada = 3
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        precioManoObra = 105.99
        opcionSeleccionada = 4
    End Sub

    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked = True Then
            seleccionLino = True
        Else
            seleccionLino = False
        End If

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

        If CheckBox2.Checked = True Then
            seleccionAlgodon = True
        Else
            seleccionAlgodon = False
        End If

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged

        If CheckBox3.Checked = True Then
            seleccionSeda = True
        Else
            seleccionSeda = False
        End If

    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged

        If CheckBox4.Checked = True Then
            seleccionHiloCrudo = True
        Else
            seleccionHiloCrudo = False
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim errorRegistroYardas As Boolean = False
        Dim totalYardas As Single = 0
        Dim totalPrecioYardas As Single = 0
        Dim totalPrecioCosto As Single = 0

        If seleccionLino = True Then

            If TextBox1.Text = "" Then
                errorRegistroYardas = True
            Else
                Dim yardaActual = CType(TextBox1.Text, Single)
                Dim totalPrecioYardaLino = precioMaterialLino * yardaActual
                totalYardas += yardaActual
                totalPrecioYardas += totalPrecioYardaLino
                Label9.Text = mensajeTotal + CType(Round(totalPrecioYardaLino, 2), String)
            End If

        End If

        If seleccionAlgodon = True Then

            If TextBox2.Text = "" Then
                errorRegistroYardas = True
            Else
                Dim yardaActual = CType(TextBox2.Text, Single)
                Dim totalPrecioYardaAlgodon = precioMaterialAlgodon * yardaActual
                totalYardas += yardaActual
                totalPrecioYardas += totalPrecioYardaAlgodon
                Label8.Text = mensajeTotal + CType(Round(totalPrecioYardaAlgodon, 2), String)
            End If

        End If

        If seleccionSeda = True Then

            If TextBox3.Text = "" Then
                errorRegistroYardas = True
            Else
                Dim yardaActual = CType(TextBox3.Text, Single)
                Dim totalPrecioYardaSeda = precioMaterialSeda * yardaActual
                totalYardas += yardaActual
                totalPrecioYardas += totalPrecioYardaSeda
                Label7.Text = mensajeTotal + CType(Round(totalPrecioYardaSeda, 2), String)
            End If

        End If

        If seleccionHiloCrudo = True Then

            If TextBox4.Text = "" Then
                errorRegistroYardas = True
            Else
                Dim yardaActual = CType(TextBox4.Text, Single)
                Dim totalPrecioYardaHiloCrudo = precioMaterialHiloCrudo * yardaActual
                totalYardas += yardaActual
                totalPrecioYardas += totalPrecioYardaHiloCrudo
                Label10.Text = mensajeTotal + CType(Round(totalPrecioYardaHiloCrudo, 2), String)
            End If

        End If

        If opcionSeleccionada = 1 Then

            If totalYardas = 3 Then
                totalPrecioCosto = totalPrecioYardas + 65.5
                Label11.Text = mensajePrecioCosto + CType(Round(totalPrecioCosto, 2), String)
            Else
                Label11.Text = mensajePrecioCosto + "0.0"
                Label12.Text = mensajePrecioVenta + "0.0"
                Label9.Text = mensajeTotal + "0.0"
                Label8.Text = mensajeTotal + "0.0"
                Label7.Text = mensajeTotal + "0.0"
                Label10.Text = mensajeTotal + "0.0"
                MessageBox.Show("La cantidad de yardas ingresada es incorrecta.", "Registro de yardas", MessageBoxButtons.OK, MessageBoxIcon.Error)
                errorRegistroYardas = False
            End If

        ElseIf opcionSeleccionada = 2 Then

            If totalYardas = 5 Then
                totalPrecioCosto = totalPrecioYardas + 85.99
                Label11.Text = mensajePrecioCosto + CType(Round(totalPrecioCosto, 2), String)
            Else
                Label11.Text = mensajePrecioCosto + "0.0"
                Label12.Text = mensajePrecioVenta + "0.0"
                Label9.Text = mensajeTotal + "0.0"
                Label8.Text = mensajeTotal + "0.0"
                Label7.Text = mensajeTotal + "0.0"
                Label10.Text = mensajeTotal + "0.0"
                MessageBox.Show("La cantidad de yardas ingresada es incorrecta.", "Registro de yardas", MessageBoxButtons.OK, MessageBoxIcon.Error)
                errorRegistroYardas = False
            End If

        ElseIf opcionSeleccionada = 3 Then

            If totalYardas = 6 Then
                totalPrecioCosto = totalPrecioYardas + 99.99
                Label11.Text = mensajePrecioCosto + CType(Round(totalPrecioCosto, 2), String)
            Else
                Label11.Text = mensajePrecioCosto + "0.0"
                Label12.Text = mensajePrecioVenta + "0.0"
                Label9.Text = mensajeTotal + "0.0"
                Label8.Text = mensajeTotal + "0.0"
                Label7.Text = mensajeTotal + "0.0"
                Label10.Text = mensajeTotal + "0.0"
                MessageBox.Show("La cantidad de yardas ingresada es incorrecta.", "Registro de yardas", MessageBoxButtons.OK, MessageBoxIcon.Error)
                errorRegistroYardas = False
            End If

        ElseIf opcionSeleccionada = 4 Then

            If totalYardas = 7 Then
                totalPrecioCosto = totalPrecioYardas + 105.99
                Label11.Text = mensajePrecioCosto + CType(Round(totalPrecioCosto, 2), String)
            Else
                Label11.Text = mensajePrecioCosto + "0.0"
                Label12.Text = mensajePrecioVenta + "0.0"
                Label9.Text = mensajeTotal + "0.0"
                Label8.Text = mensajeTotal + "0.0"
                Label7.Text = mensajeTotal + "0.0"
                Label10.Text = mensajeTotal + "0.0"
                MessageBox.Show("La cantidad de yardas ingresada es incorrecta.", "Registro de yardas", MessageBoxButtons.OK, MessageBoxIcon.Error)
                errorRegistroYardas = False
            End If

        End If


        If errorRegistroYardas = True Then
            MessageBox.Show("No se ha ingresado el total de yardas para todos los productos seleccionados.", "Registro de Yardas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Dim precioVenta As Single = 0.65 * totalPrecioCosto
            Label12.Text = mensajePrecioVenta + CType(Round(precioVenta, 2), String)
            Label13.Text = mensajeTotal + CType(Round(totalPrecioCosto + precioVenta, 2), String)

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""

        Label9.Text = mensajeTotal + "0.0"
        Label8.Text = mensajeTotal + "0.0"
        Label7.Text = mensajeTotal + "0.0"
        Label10.Text = mensajeTotal + "0.0"

        Label11.Text = mensajePrecioCosto + "0.0"
        Label12.Text = mensajePrecioVenta + "0.0"
        Label13.Text = mensajeTotal + "0.0"

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (MsgBox("Desea salir del programa", vbQuestion + vbYesNo, "Salida") = vbYes) Then
            End
        Else
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox1.Focus()
            CheckBox1.Checked = False
            CheckBox2.Checked = False
            CheckBox3.Checked = False
            CheckBox4.Checked = False
            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton3.Checked = False
            RadioButton4.Checked = False
        End If

    End Sub
End Class

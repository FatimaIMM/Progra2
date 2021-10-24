Module Module1

    Public nombre_paciente As String = ""
    Public nit_paciente As String = ""
    Public dias As String = ""
    Public honorarios As String = ""
    Public subTotal_gastos As Double = 0
    Public descuento_gasto As Double = 0
    Public total_gastos As Double = 0
    Public pacientes(6, 9) As String
    Public contador As Integer = 0

    Public Function datosCorrectos() As Boolean

        nombre_paciente = Form1.TextBox1.Text
        nit_paciente = Form1.TextBox2.Text
        dias = Form1.TextBox3.Text
        honorarios = Form1.TextBox4.Text

        If nombre_paciente = "" Or nit_paciente = "" Or dias = "" Or honorarios = "" Or Form1.ComboBox1.SelectedIndex = -1 Or Form1.ComboBox2.SelectedIndex = -1 Then
            Return False
        End If

        Return True

    End Function

    Public Sub calcular()

        nombre_paciente = Form1.TextBox1.Text
        nit_paciente = Form1.TextBox2.Text
        dias = Form1.TextBox3.Text
        honorarios = Form1.TextBox4.Text
        Dim habitacion As String = Form1.ComboBox1.SelectedItem.ToString()
        Dim pago As String = Form1.ComboBox2.SelectedItem.ToString()

        If verificarNit(nit_paciente) Then
            subTotal_gastos = calcularGastos(habitacion) * CInt(dias)
            descuento_gasto = calcularDescuento(subTotal_gastos, pago)
            total_gastos = subTotal_gastos - descuento_gasto

            pacientes(contador, 0) = nombre_paciente
            pacientes(contador, 1) = nit_paciente
            pacientes(contador, 2) = dias
            pacientes(contador, 3) = honorarios
            pacientes(contador, 4) = habitacion
            pacientes(contador, 5) = pago
            pacientes(contador, 6) = CStr(Math.Round(subTotal_gastos, 2))
            pacientes(contador, 7) = CStr(Math.Round(descuento_gasto, 2))
            pacientes(contador, 8) = CStr(Math.Round(total_gastos, 2))

            contador = contador + 1

        Else
            MessageBox.Show("Nit ingresado ya existente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Public Function verificarNit(nit As String) As Boolean

        Dim index As Integer = 0

        Do While (index < 6)
            If nit_paciente = pacientes(index, 1) Then
                Return False
            End If
            index = index + 1
        Loop

        Return True

    End Function

    Public Function calcularGastos(habitacion As String) As Double

        Select Case habitacion

            Case "Privada"
                Return 350
            Case "Semiprivada"
                Return 250
            Case "Pública"
                Return 150
        End Select

        Return 0

    End Function

    Public Function calcularDescuento(subTotal As Double, formaPago As String) As Double

        Select Case formaPago
            Case "Efectivo"
                Return subTotal * 0.1
            Case "Transferencia ACH"
                Return subTotal * 0.08
            Case "Depósito bancario"
                Return subTotal * 0.1
            Case "Tarjeta de crédito"
                Return subTotal * 0.015 * -1
            Case "Seguro Médico"
                Return 0

        End Select

        Return 0


    End Function

    Public Sub mostrarDatos()

        Form1.DataGridView1.Rows.Clear()

        If contador > 6 Then

            Dim index As Integer = 0
            Do While (index < 6)

                Dim contadorRows As Integer = Form1.DataGridView1.Rows.Count - 1
                Form1.DataGridView1.Rows.Add()

                Form1.DataGridView1(0, contadorRows).Value = pacientes(index, 0)
                Form1.DataGridView1(1, contadorRows).Value = pacientes(index, 1)
                Form1.DataGridView1(2, contadorRows).Value = pacientes(index, 2)
                Form1.DataGridView1(3, contadorRows).Value = pacientes(index, 3)
                Form1.DataGridView1(4, contadorRows).Value = pacientes(index, 4)
                Form1.DataGridView1(5, contadorRows).Value = pacientes(index, 5)
                Form1.DataGridView1(6, contadorRows).Value = pacientes(index, 6)
                Form1.DataGridView1(7, contadorRows).Value = pacientes(index, 7)
                Form1.DataGridView1(8, contadorRows).Value = pacientes(index, 8)

                index = index + 1
            Loop

        Else

            Dim index As Integer = 0
            Do While (index < contador)

                Dim contadorRows As Integer = Form1.DataGridView1.Rows.Count - 1
                Form1.DataGridView1.Rows.Add()

                Form1.DataGridView1(0, contadorRows).Value = pacientes(index, 0)
                Form1.DataGridView1(1, contadorRows).Value = pacientes(index, 1)
                Form1.DataGridView1(2, contadorRows).Value = pacientes(index, 2)
                Form1.DataGridView1(3, contadorRows).Value = pacientes(index, 3)
                Form1.DataGridView1(4, contadorRows).Value = pacientes(index, 4)
                Form1.DataGridView1(5, contadorRows).Value = pacientes(index, 5)
                Form1.DataGridView1(6, contadorRows).Value = pacientes(index, 6)
                Form1.DataGridView1(7, contadorRows).Value = pacientes(index, 7)
                Form1.DataGridView1(8, contadorRows).Value = pacientes(index, 8)
                index = index + 1

            Loop

        End If

    End Sub

    Public Sub limpiarMatriz()

        Dim index As Integer = 0

        Do While (index < 6)
            pacientes(index, 0) = ""
            pacientes(index, 1) = ""
            pacientes(index, 2) = ""
            pacientes(index, 3) = ""
            pacientes(index, 4) = ""
            pacientes(index, 5) = ""
            pacientes(index, 6) = ""
            pacientes(index, 7) = ""
            pacientes(index, 8) = ""
        Loop

        Form1.DataGridView1.Rows.Clear()
        contador = 0

    End Sub

    Public Sub consultarInfo(nitBuscar As String)

        Form1.DataGridView1.Rows.Clear()
        Dim index As Integer = 0
        If contador > 6 Then

            Do While (index < 6)

                If pacientes(index, 1) = nitBuscar Then
                    Dim contadorRows As Integer = Form1.DataGridView1.Rows.Count - 1
                    Form1.DataGridView1.Rows.Add()

                    Form1.DataGridView1(0, contadorRows).Value = pacientes(index, 0)
                    Form1.DataGridView1(1, contadorRows).Value = pacientes(index, 1)
                    Form1.DataGridView1(2, contadorRows).Value = pacientes(index, 2)
                    Form1.DataGridView1(3, contadorRows).Value = pacientes(index, 3)
                    Form1.DataGridView1(4, contadorRows).Value = pacientes(index, 4)
                    Form1.DataGridView1(5, contadorRows).Value = pacientes(index, 5)
                    Form1.DataGridView1(6, contadorRows).Value = pacientes(index, 6)
                    Form1.DataGridView1(7, contadorRows).Value = pacientes(index, 7)
                    Form1.DataGridView1(8, contadorRows).Value = pacientes(index, 8)
                    Return
                End If

                index = index + 1

            Loop

        Else

            Do While (index < contador)
                If pacientes(index, 1) = nitBuscar Then
                    Dim contadorRows As Integer = Form1.DataGridView1.Rows.Count - 1
                    Form1.DataGridView1.Rows.Add()

                    Form1.DataGridView1(0, contadorRows).Value = pacientes(index, 0)
                    Form1.DataGridView1(1, contadorRows).Value = pacientes(index, 1)
                    Form1.DataGridView1(2, contadorRows).Value = pacientes(index, 2)
                    Form1.DataGridView1(3, contadorRows).Value = pacientes(index, 3)
                    Form1.DataGridView1(4, contadorRows).Value = pacientes(index, 4)
                    Form1.DataGridView1(5, contadorRows).Value = pacientes(index, 5)
                    Form1.DataGridView1(6, contadorRows).Value = pacientes(index, 6)
                    Form1.DataGridView1(7, contadorRows).Value = pacientes(index, 7)
                    Form1.DataGridView1(8, contadorRows).Value = pacientes(index, 8)
                    Return
                End If
                index = index + 1
            Loop

        End If

        MessageBox.Show("No se ha encontrado el usuario con nit " + nitBuscar + ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

    End Sub

    Public Sub calculo()

        Dim Index As Integer = 0
        Dim total As Integer = 0

        Do While (Index < 6)
            If pacientes(Index, 4) = "Privada" Then
                total = total + 1
            End If
            Index = Index + 1
        Loop

        Form1.Label8.Text = total

    End Sub

    Public Sub calculo2()

        Dim Index As Integer = 0
        Dim total As Double = 0

        Do While (Index < 6)
            If pacientes(Index, 5) = "Transferencia ACH" Then
                total = total + CDbl(pacientes(Index, 8))
            End If
            Index = Index + 1
        Loop

        Form1.Label10.Text = "Q " + CStr(Math.Round(total, 2))

    End Sub

    Public Sub calculo3()
        Dim Index As Integer = 0
        Dim total As Integer = 0

        Do While (Index < 6)
            If pacientes(Index, 4) = "Privada" Then
                total = total + CInt(pacientes(Index, 2))
            End If
            Index = Index + 1
        Loop

        Form1.Label12.Text = total

    End Sub

End Module

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TotalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TotalGeneralToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TotalPorFormaDePagoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TotalPorNivelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TotalInscritosPorCarreraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Carnet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nivel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Carrera = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalGeneralToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre Alumno"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(194, 38)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(548, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Carnet"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(109, 77)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(120, 20)
        Me.TextBox2.TabIndex = 3
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Básico", "Diversificado"})
        Me.ComboBox1.Location = New System.Drawing.Point(375, 76)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(251, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nivel Estudio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(523, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 24)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Carrera"
        Me.Label4.Visible = False
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Perito Contador", "Bachillerato", "Electrónica", "Diseño Gráfico"})
        Me.ComboBox2.Location = New System.Drawing.Point(614, 75)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(128, 21)
        Me.ComboBox2.TabIndex = 7
        Me.ComboBox2.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TotalesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(779, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TotalesToolStripMenuItem
        '
        Me.TotalesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TotalGeneralToolStripMenuItem, Me.TotalPorFormaDePagoToolStripMenuItem, Me.TotalPorNivelToolStripMenuItem, Me.TotalInscritosPorCarreraToolStripMenuItem, Me.TotalGeneralToolStripMenuItem1})
        Me.TotalesToolStripMenuItem.Name = "TotalesToolStripMenuItem"
        Me.TotalesToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.TotalesToolStripMenuItem.Text = "Totales"
        '
        'TotalGeneralToolStripMenuItem
        '
        Me.TotalGeneralToolStripMenuItem.Name = "TotalGeneralToolStripMenuItem"
        Me.TotalGeneralToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.TotalGeneralToolStripMenuItem.Text = "Agregar"
        '
        'TotalPorFormaDePagoToolStripMenuItem
        '
        Me.TotalPorFormaDePagoToolStripMenuItem.Name = "TotalPorFormaDePagoToolStripMenuItem"
        Me.TotalPorFormaDePagoToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.TotalPorFormaDePagoToolStripMenuItem.Text = "Total por forma de pago"
        '
        'TotalPorNivelToolStripMenuItem
        '
        Me.TotalPorNivelToolStripMenuItem.Name = "TotalPorNivelToolStripMenuItem"
        Me.TotalPorNivelToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.TotalPorNivelToolStripMenuItem.Text = "Total por nivel"
        '
        'TotalInscritosPorCarreraToolStripMenuItem
        '
        Me.TotalInscritosPorCarreraToolStripMenuItem.Name = "TotalInscritosPorCarreraToolStripMenuItem"
        Me.TotalInscritosPorCarreraToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.TotalInscritosPorCarreraToolStripMenuItem.Text = "Total inscritos por carrera"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(38, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 24)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Pago"
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"Efectivo", "Tarjeta de crédito", "Transferencia por ACH", "Depósito bancario"})
        Me.ComboBox3.Location = New System.Drawing.Point(109, 116)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(150, 21)
        Me.ComboBox3.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(149, 168)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Limpiar Matriz"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(263, 168)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(109, 23)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Limpiar Entradas"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(381, 169)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(108, 23)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Limpiar Totales"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.Carnet, Me.Nivel, Me.Carrera, Me.Pago, Me.Subtotal, Me.Total})
        Me.DataGridView1.Location = New System.Drawing.Point(16, 439)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(743, 150)
        Me.DataGridView1.TabIndex = 14
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(495, 169)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(108, 23)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "Limpiar Datos"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Nombre
        '
        Me.Nombre.Frozen = True
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Carnet
        '
        Me.Carnet.Frozen = True
        Me.Carnet.HeaderText = "Carnet"
        Me.Carnet.Name = "Carnet"
        Me.Carnet.ReadOnly = True
        '
        'Nivel
        '
        Me.Nivel.Frozen = True
        Me.Nivel.HeaderText = "Nivel estudio"
        Me.Nivel.Name = "Nivel"
        Me.Nivel.ReadOnly = True
        '
        'Carrera
        '
        Me.Carrera.Frozen = True
        Me.Carrera.HeaderText = "Carrera"
        Me.Carrera.Name = "Carrera"
        Me.Carrera.ReadOnly = True
        '
        'Pago
        '
        Me.Pago.Frozen = True
        Me.Pago.HeaderText = "Forma Pago"
        Me.Pago.Name = "Pago"
        Me.Pago.ReadOnly = True
        '
        'Subtotal
        '
        Me.Subtotal.Frozen = True
        Me.Subtotal.HeaderText = "Sub Total"
        Me.Subtotal.Name = "Subtotal"
        Me.Subtotal.ReadOnly = True
        '
        'Total
        '
        Me.Total.Frozen = True
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        '
        'TotalGeneralToolStripMenuItem1
        '
        Me.TotalGeneralToolStripMenuItem1.Name = "TotalGeneralToolStripMenuItem1"
        Me.TotalGeneralToolStripMenuItem1.Size = New System.Drawing.Size(206, 22)
        Me.TotalGeneralToolStripMenuItem1.Text = "Total General"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(38, 214)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 24)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Total General"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(167, 214)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 24)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Q "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(286, 214)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 24)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Total Efectivo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(410, 214)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 24)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Q "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(523, 214)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(113, 24)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Total Tarjeta"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(649, 214)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 24)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Q "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(38, 251)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 24)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Total ACH"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(167, 251)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(30, 24)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Q "
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(286, 251)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(130, 24)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "Total Deposito"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(410, 251)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(30, 24)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "Q "
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(523, 251)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(112, 24)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "Total Básico"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(649, 251)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(30, 24)
        Me.Label17.TabIndex = 27
        Me.Label17.Text = "Q "
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(38, 287)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(162, 24)
        Me.Label18.TabIndex = 28
        Me.Label18.Text = "Total Diversificado"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(206, 287)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(30, 24)
        Me.Label19.TabIndex = 29
        Me.Label19.Text = "Q "
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(48, 343)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(259, 24)
        Me.Label20.TabIndex = 30
        Me.Label20.Text = "Total Inscritos Perito Contador"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(313, 343)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(20, 24)
        Me.Label21.TabIndex = 31
        Me.Label21.Text = "0"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(420, 343)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(226, 24)
        Me.Label22.TabIndex = 32
        Me.Label22.Text = "Total Inscritos Bachillerato"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(659, 343)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(20, 24)
        Me.Label23.TabIndex = 33
        Me.Label23.Text = "0"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(48, 387)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(223, 24)
        Me.Label24.TabIndex = 34
        Me.Label24.Text = "Total Inscritos Electrónica"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(313, 387)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(20, 24)
        Me.Label25.TabIndex = 35
        Me.Label25.Text = "0"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(420, 387)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(179, 24)
        Me.Label26.TabIndex = 36
        Me.Label26.Text = "Total Diseño Gráfico"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(659, 387)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(20, 24)
        Me.Label27.TabIndex = 37
        Me.Label27.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 609)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TotalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TotalGeneralToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TotalPorFormaDePagoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TotalPorNivelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TotalInscritosPorCarreraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button4 As Button
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Carnet As DataGridViewTextBoxColumn
    Friend WithEvents Nivel As DataGridViewTextBoxColumn
    Friend WithEvents Carrera As DataGridViewTextBoxColumn
    Friend WithEvents Pago As DataGridViewTextBoxColumn
    Friend WithEvents Subtotal As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents TotalGeneralToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
End Class

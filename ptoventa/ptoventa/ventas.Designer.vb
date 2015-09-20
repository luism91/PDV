<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class ventas
    Inherits System.Windows.Forms.Form

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer
    Private mainMenu1 As System.Windows.Forms.MainMenu

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar con el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.mainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.modifcant = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.txtbusqueda = New System.Windows.Forms.TextBox
        Me.txtcantidad = New System.Windows.Forms.TextBox
        Me.btnagregar = New System.Windows.Forms.Button
        Me.lstdescripcion2 = New System.Windows.Forms.ListBox
        Me.lstprecio2 = New System.Windows.Forms.ListBox
        Me.lstcantidad = New System.Windows.Forms.ListBox
        Me.lstdescripcion = New System.Windows.Forms.ListBox
        Me.lstprecio = New System.Windows.Forms.ListBox
        Me.lstimporte = New System.Windows.Forms.ListBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.lbimporte = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lstcodigo = New System.Windows.Forms.ListBox
        Me.lstcodigo2 = New System.Windows.Forms.ListBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Button1 = New System.Windows.Forms.Button
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.lstimp4 = New System.Windows.Forms.ListBox
        Me.lstprecio3 = New System.Windows.Forms.ListBox
        Me.lstdescripcion3 = New System.Windows.Forms.ListBox
        Me.lstcantidad3 = New System.Windows.Forms.ListBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.SP = New System.IO.Ports.SerialPort(Me.components)
        Me.lblcantidad = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.Add(Me.MenuItem1)
        Me.mainMenu1.MenuItems.Add(Me.MenuItem2)
        '
        'MenuItem1
        '
        Me.MenuItem1.MenuItems.Add(Me.modifcant)
        Me.MenuItem1.MenuItems.Add(Me.MenuItem3)
        Me.MenuItem1.Text = "Modif. Prod."
        '
        'modifcant
        '
        Me.modifcant.Text = "Modif. Cant."
        '
        'MenuItem3
        '
        Me.MenuItem3.Text = "Quitar Prod."
        '
        'MenuItem2
        '
        Me.MenuItem2.MenuItems.Add(Me.MenuItem6)
        Me.MenuItem2.MenuItems.Add(Me.MenuItem5)
        Me.MenuItem2.MenuItems.Add(Me.MenuItem7)
        Me.MenuItem2.MenuItems.Add(Me.MenuItem4)
        Me.MenuItem2.Text = "Opciones"
        '
        'MenuItem6
        '
        Me.MenuItem6.Text = "Cargar Nota"
        '
        'MenuItem5
        '
        Me.MenuItem5.Text = "Imprimir pedido"
        '
        'MenuItem7
        '
        Me.MenuItem7.Text = "Cerrar venta"
        '
        'MenuItem4
        '
        Me.MenuItem4.Text = "Ir a Menu Prin."
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(4, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 20)
        Me.Label2.Text = "Buscar"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(4, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 20)
        Me.Label3.Text = "Cant."
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.ComboBox1.Location = New System.Drawing.Point(57, 3)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(163, 19)
        Me.ComboBox1.TabIndex = 5
        Me.ComboBox1.TabStop = False
        '
        'txtbusqueda
        '
        Me.txtbusqueda.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.txtbusqueda.Location = New System.Drawing.Point(53, 33)
        Me.txtbusqueda.Name = "txtbusqueda"
        Me.txtbusqueda.Size = New System.Drawing.Size(83, 19)
        Me.txtbusqueda.TabIndex = 6
        Me.txtbusqueda.TabStop = False
        '
        'txtcantidad
        '
        Me.txtcantidad.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.txtcantidad.Location = New System.Drawing.Point(42, 101)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(35, 19)
        Me.txtcantidad.TabIndex = 7
        Me.txtcantidad.TabStop = False
        '
        'btnagregar
        '
        Me.btnagregar.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnagregar.Location = New System.Drawing.Point(84, 100)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(59, 20)
        Me.btnagregar.TabIndex = 8
        Me.btnagregar.TabStop = False
        Me.btnagregar.Text = "&Agregar"
        '
        'lstdescripcion2
        '
        Me.lstdescripcion2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.lstdescripcion2.Location = New System.Drawing.Point(4, 66)
        Me.lstdescripcion2.Name = "lstdescripcion2"
        Me.lstdescripcion2.Size = New System.Drawing.Size(158, 28)
        Me.lstdescripcion2.TabIndex = 9
        Me.lstdescripcion2.TabStop = False
        '
        'lstprecio2
        '
        Me.lstprecio2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.lstprecio2.Location = New System.Drawing.Point(174, 66)
        Me.lstprecio2.Name = "lstprecio2"
        Me.lstprecio2.Size = New System.Drawing.Size(45, 28)
        Me.lstprecio2.TabIndex = 10
        Me.lstprecio2.TabStop = False
        '
        'lstcantidad
        '
        Me.lstcantidad.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lstcantidad.Location = New System.Drawing.Point(0, 208)
        Me.lstcantidad.Name = "lstcantidad"
        Me.lstcantidad.Size = New System.Drawing.Size(24, 387)
        Me.lstcantidad.TabIndex = 11
        Me.lstcantidad.TabStop = False
        '
        'lstdescripcion
        '
        Me.lstdescripcion.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lstdescripcion.Location = New System.Drawing.Point(25, 208)
        Me.lstdescripcion.Name = "lstdescripcion"
        Me.lstdescripcion.Size = New System.Drawing.Size(127, 387)
        Me.lstdescripcion.TabIndex = 12
        Me.lstdescripcion.TabStop = False
        '
        'lstprecio
        '
        Me.lstprecio.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lstprecio.Location = New System.Drawing.Point(153, 208)
        Me.lstprecio.Name = "lstprecio"
        Me.lstprecio.Size = New System.Drawing.Size(40, 387)
        Me.lstprecio.TabIndex = 13
        Me.lstprecio.TabStop = False
        '
        'lstimporte
        '
        Me.lstimporte.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lstimporte.Location = New System.Drawing.Point(194, 208)
        Me.lstimporte.Name = "lstimporte"
        Me.lstimporte.Size = New System.Drawing.Size(40, 387)
        Me.lstimporte.TabIndex = 14
        Me.lstimporte.TabStop = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(69, 612)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 20)
        Me.Label4.Text = "Importe Total"
        '
        'lbimporte
        '
        Me.lbimporte.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lbimporte.Location = New System.Drawing.Point(159, 612)
        Me.lbimporte.Name = "lbimporte"
        Me.lbimporte.Size = New System.Drawing.Size(58, 20)
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label5.Location = New System.Drawing.Point(154, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 20)
        Me.Label5.Text = "Label5"
        '
        'lstcodigo
        '
        Me.lstcodigo.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.lstcodigo.Location = New System.Drawing.Point(7, 638)
        Me.lstcodigo.Name = "lstcodigo"
        Me.lstcodigo.Size = New System.Drawing.Size(88, 41)
        Me.lstcodigo.TabIndex = 27
        Me.lstcodigo.TabStop = False
        Me.lstcodigo.Visible = False
        '
        'lstcodigo2
        '
        Me.lstcodigo2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.lstcodigo2.Location = New System.Drawing.Point(97, 641)
        Me.lstcodigo2.Name = "lstcodigo2"
        Me.lstcodigo2.Size = New System.Drawing.Size(45, 41)
        Me.lstcodigo2.TabIndex = 28
        Me.lstcodigo2.TabStop = False
        Me.lstcodigo2.Visible = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(0, 195)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 10)
        Me.Label6.Text = "Cant."
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(26, 195)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 10)
        Me.Label7.Text = "Descripcion"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(154, 195)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 10)
        Me.Label8.Text = "Prec."
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(195, 195)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 10)
        Me.Label9.Text = "Imp."
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(-4, 186)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(240, 5)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.ComboBox2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.txtbusqueda)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(231, 58)
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(151, 33)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(69, 22)
        Me.Button1.TabIndex = 60
        Me.Button1.Text = "Nva.venta"
        '
        'ComboBox2
        '
        Me.ComboBox2.Enabled = False
        Me.ComboBox2.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.ComboBox2.Location = New System.Drawing.Point(4, 3)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(46, 19)
        Me.ComboBox2.TabIndex = 8
        Me.ComboBox2.ValueMember = "codigocliente"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(-6, 125)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(240, 5)
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(194, 144)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(35, 10)
        Me.Label12.Text = "Imp."
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(153, 144)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 10)
        Me.Label13.Text = "Prec."
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.Location = New System.Drawing.Point(25, 144)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(60, 10)
        Me.Label14.Text = "Descripcion"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.Label15.Location = New System.Drawing.Point(-1, 144)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(35, 10)
        Me.Label15.Text = "Cant."
        '
        'lstimp4
        '
        Me.lstimp4.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lstimp4.Location = New System.Drawing.Point(194, 157)
        Me.lstimp4.Name = "lstimp4"
        Me.lstimp4.Size = New System.Drawing.Size(38, 24)
        Me.lstimp4.TabIndex = 45
        Me.lstimp4.TabStop = False
        '
        'lstprecio3
        '
        Me.lstprecio3.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lstprecio3.Location = New System.Drawing.Point(153, 157)
        Me.lstprecio3.Name = "lstprecio3"
        Me.lstprecio3.Size = New System.Drawing.Size(38, 24)
        Me.lstprecio3.TabIndex = 44
        Me.lstprecio3.TabStop = False
        '
        'lstdescripcion3
        '
        Me.lstdescripcion3.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lstdescripcion3.Location = New System.Drawing.Point(25, 157)
        Me.lstdescripcion3.Name = "lstdescripcion3"
        Me.lstdescripcion3.Size = New System.Drawing.Size(125, 24)
        Me.lstdescripcion3.TabIndex = 43
        Me.lstdescripcion3.TabStop = False
        '
        'lstcantidad3
        '
        Me.lstcantidad3.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lstcantidad3.Location = New System.Drawing.Point(0, 157)
        Me.lstcantidad3.Name = "lstcantidad3"
        Me.lstcantidad3.Size = New System.Drawing.Size(22, 24)
        Me.lstcantidad3.TabIndex = 42
        Me.lstcantidad3.TabStop = False
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(3, 132)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(154, 12)
        Me.Label16.Text = "Ultimos Productos agregados"
        '
        'SP
        '
        Me.SP.BaudRate = 57600
        Me.SP.PortName = "COM4"
        '
        'lblcantidad
        '
        Me.lblcantidad.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblcantidad.ForeColor = System.Drawing.Color.Red
        Me.lblcantidad.Location = New System.Drawing.Point(174, 131)
        Me.lblcantidad.Name = "lblcantidad"
        Me.lblcantidad.Size = New System.Drawing.Size(45, 13)
        '
        'ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.Controls.Add(Me.lblcantidad)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.lstimp4)
        Me.Controls.Add(Me.lstprecio3)
        Me.Controls.Add(Me.lstdescripcion3)
        Me.Controls.Add(Me.lstcantidad3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lstcodigo2)
        Me.Controls.Add(Me.lstcodigo)
        Me.Controls.Add(Me.lbimporte)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lstimporte)
        Me.Controls.Add(Me.lstprecio)
        Me.Controls.Add(Me.lstdescripcion)
        Me.Controls.Add(Me.lstcantidad)
        Me.Controls.Add(Me.lstprecio2)
        Me.Controls.Add(Me.lstdescripcion2)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.txtcantidad)
        Me.Controls.Add(Me.Label3)
        Me.KeyPreview = True
        Me.Menu = Me.mainMenu1
        Me.Name = "ventas"
        Me.Text = "Pedidos/Ventas"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents txtbusqueda As System.Windows.Forms.TextBox
    Friend WithEvents txtcantidad As System.Windows.Forms.TextBox
    Friend WithEvents btnagregar As System.Windows.Forms.Button
    Friend WithEvents lstdescripcion2 As System.Windows.Forms.ListBox
    Friend WithEvents lstprecio2 As System.Windows.Forms.ListBox
    Friend WithEvents lstcantidad As System.Windows.Forms.ListBox
    Friend WithEvents lstdescripcion As System.Windows.Forms.ListBox
    Friend WithEvents lstprecio As System.Windows.Forms.ListBox
    Friend WithEvents lstimporte As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbimporte As System.Windows.Forms.Label
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents modifcant As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents lstcodigo As System.Windows.Forms.ListBox
    Friend WithEvents lstcodigo2 As System.Windows.Forms.ListBox
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lstimp4 As System.Windows.Forms.ListBox
    Friend WithEvents lstprecio3 As System.Windows.Forms.ListBox
    Friend WithEvents lstdescripcion3 As System.Windows.Forms.ListBox
    Friend WithEvents lstcantidad3 As System.Windows.Forms.ListBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents SP As System.IO.Ports.SerialPort


    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents lblcantidad As System.Windows.Forms.Label
End Class

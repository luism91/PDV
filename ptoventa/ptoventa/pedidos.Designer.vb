<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class pedidos
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
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.modifcant = New System.Windows.Forms.MenuItem
        Me.removeit = New System.Windows.Forms.MenuItem
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.Label2 = New System.Windows.Forms.Label
        Me.clientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PtoventaDataSet = New ptoventa.ptoventaDataSet
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.txtbusqueda = New System.Windows.Forms.TextBox
        Me.lstdescripcion2 = New System.Windows.Forms.ListBox
        Me.lstprecio2 = New System.Windows.Forms.ListBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtcantidad = New System.Windows.Forms.TextBox
        Me.btnagregar = New System.Windows.Forms.Button
        Me.lstdescripcion = New System.Windows.Forms.ListBox
        Me.lstcantidad = New System.Windows.Forms.ListBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.lstcodigo2 = New System.Windows.Forms.ListBox
        Me.lstcodigo = New System.Windows.Forms.ListBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lstprecio = New System.Windows.Forms.ListBox
        Me.lstimporte = New System.Windows.Forms.ListBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.lstimp4 = New System.Windows.Forms.ListBox
        Me.lstprecio3 = New System.Windows.Forms.ListBox
        Me.lstcantidad3 = New System.Windows.Forms.ListBox
        Me.lstdescripcion3 = New System.Windows.Forms.ListBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.ClientesTableAdapter1 = New ptoventa.ptoventaDataSetTableAdapters.clientesTableAdapter
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.SP = New System.IO.Ports.SerialPort(Me.components)
        CType(Me.clientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PtoventaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.Add(Me.MenuItem2)
        Me.mainMenu1.MenuItems.Add(Me.MenuItem1)
        '
        'MenuItem2
        '
        Me.MenuItem2.MenuItems.Add(Me.modifcant)
        Me.MenuItem2.MenuItems.Add(Me.removeit)
        Me.MenuItem2.Text = "Modif. Prod."
        '
        'modifcant
        '
        Me.modifcant.Text = "Modif. Cant."
        '
        'removeit
        '
        Me.removeit.Text = "Quitar Prod."
        '
        'MenuItem1
        '
        Me.MenuItem1.MenuItems.Add(Me.MenuItem3)
        Me.MenuItem1.MenuItems.Add(Me.MenuItem4)
        Me.MenuItem1.MenuItems.Add(Me.MenuItem5)
        Me.MenuItem1.Text = "Opciones"
        '
        'MenuItem3
        '
        Me.MenuItem3.Text = "Imprimir Pedido"
        '
        'MenuItem4
        '
        Me.MenuItem4.Text = "Cargar Nota"
        '
        'MenuItem5
        '
        Me.MenuItem5.Text = "Ir a Menu Prin."
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(1, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 20)
        Me.Label2.Text = "Buscar"
        '
        'clientesBindingSource
        '
        Me.clientesBindingSource.DataMember = "clientes"
        Me.clientesBindingSource.DataSource = Me.PtoventaDataSet
        '
        'PtoventaDataSet
        '
        Me.PtoventaDataSet.DataSetName = "ptoventaDataSet"
        Me.PtoventaDataSet.Prefix = ""
        Me.PtoventaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.clientesBindingSource
        Me.ComboBox1.DisplayMember = "nombrecliente"
        Me.ComboBox1.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.ComboBox1.Location = New System.Drawing.Point(54, 3)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(168, 19)
        Me.ComboBox1.TabIndex = 3
        Me.ComboBox1.TabStop = False
        '
        'txtbusqueda
        '
        Me.txtbusqueda.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.txtbusqueda.Location = New System.Drawing.Point(46, 27)
        Me.txtbusqueda.Name = "txtbusqueda"
        Me.txtbusqueda.Size = New System.Drawing.Size(100, 19)
        Me.txtbusqueda.TabIndex = 4
        Me.txtbusqueda.TabStop = False
        '
        'lstdescripcion2
        '
        Me.lstdescripcion2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.lstdescripcion2.Location = New System.Drawing.Point(2, 50)
        Me.lstdescripcion2.Name = "lstdescripcion2"
        Me.lstdescripcion2.Size = New System.Drawing.Size(158, 28)
        Me.lstdescripcion2.TabIndex = 5
        Me.lstdescripcion2.TabStop = False
        '
        'lstprecio2
        '
        Me.lstprecio2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.lstprecio2.Location = New System.Drawing.Point(166, 50)
        Me.lstprecio2.Name = "lstprecio2"
        Me.lstprecio2.Size = New System.Drawing.Size(40, 28)
        Me.lstprecio2.TabIndex = 6
        Me.lstprecio2.TabStop = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(2, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 20)
        Me.Label3.Text = "Cant."
        '
        'txtcantidad
        '
        Me.txtcantidad.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.txtcantidad.Location = New System.Drawing.Point(37, 83)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(56, 19)
        Me.txtcantidad.TabIndex = 9
        Me.txtcantidad.TabStop = False
        '
        'btnagregar
        '
        Me.btnagregar.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnagregar.Location = New System.Drawing.Point(98, 83)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(72, 20)
        Me.btnagregar.TabIndex = 10
        Me.btnagregar.TabStop = False
        Me.btnagregar.Text = "&Agregar"
        '
        'lstdescripcion
        '
        Me.lstdescripcion.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lstdescripcion.Location = New System.Drawing.Point(30, 182)
        Me.lstdescripcion.Name = "lstdescripcion"
        Me.lstdescripcion.Size = New System.Drawing.Size(127, 387)
        Me.lstdescripcion.TabIndex = 11
        Me.lstdescripcion.TabStop = False
        '
        'lstcantidad
        '
        Me.lstcantidad.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lstcantidad.Location = New System.Drawing.Point(1, 182)
        Me.lstcantidad.Name = "lstcantidad"
        Me.lstcantidad.Size = New System.Drawing.Size(26, 387)
        Me.lstcantidad.TabIndex = 12
        Me.lstcantidad.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(150, 26)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 20)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "&Nueva nota"
        '
        'lstcodigo2
        '
        Me.lstcodigo2.Location = New System.Drawing.Point(210, 50)
        Me.lstcodigo2.Name = "lstcodigo2"
        Me.lstcodigo2.Size = New System.Drawing.Size(10, 30)
        Me.lstcodigo2.TabIndex = 20
        Me.lstcodigo2.Visible = False
        '
        'lstcodigo
        '
        Me.lstcodigo.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.lstcodigo.Location = New System.Drawing.Point(64, 581)
        Me.lstcodigo.Name = "lstcodigo"
        Me.lstcodigo.Size = New System.Drawing.Size(101, 41)
        Me.lstcodigo.TabIndex = 24
        Me.lstcodigo.TabStop = False
        Me.lstcodigo.Visible = False
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(33, 169)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 10)
        Me.Label7.Text = "Descripcion"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(2, 169)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 10)
        Me.Label6.Text = "Cant."
        '
        'lstprecio
        '
        Me.lstprecio.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lstprecio.Location = New System.Drawing.Point(158, 182)
        Me.lstprecio.Name = "lstprecio"
        Me.lstprecio.Size = New System.Drawing.Size(35, 387)
        Me.lstprecio.TabIndex = 28
        '
        'lstimporte
        '
        Me.lstimporte.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lstimporte.Location = New System.Drawing.Point(195, 182)
        Me.lstimporte.Name = "lstimporte"
        Me.lstimporte.Size = New System.Drawing.Size(40, 387)
        Me.lstimporte.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(194, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 10)
        Me.Label4.Text = "Imp."
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(157, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 10)
        Me.Label5.Text = "Prec."
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(1, 105)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(240, 5)
        Me.Label8.Text = "Label8"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(-7, 165)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(240, 5)
        Me.Label9.Text = "Label9"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(153, 125)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 10)
        Me.Label10.Text = "Prec."
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(194, 123)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 10)
        Me.Label11.Text = "Imp."
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(28, 125)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 10)
        Me.Label12.Text = "Descripcion"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(-3, 125)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 10)
        Me.Label13.Text = "Cant."
        '
        'lstimp4
        '
        Me.lstimp4.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lstimp4.Location = New System.Drawing.Point(195, 136)
        Me.lstimp4.Name = "lstimp4"
        Me.lstimp4.Size = New System.Drawing.Size(38, 24)
        Me.lstimp4.TabIndex = 49
        '
        'lstprecio3
        '
        Me.lstprecio3.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lstprecio3.Location = New System.Drawing.Point(154, 136)
        Me.lstprecio3.Name = "lstprecio3"
        Me.lstprecio3.Size = New System.Drawing.Size(38, 24)
        Me.lstprecio3.TabIndex = 48
        '
        'lstcantidad3
        '
        Me.lstcantidad3.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lstcantidad3.Location = New System.Drawing.Point(0, 136)
        Me.lstcantidad3.Name = "lstcantidad3"
        Me.lstcantidad3.Size = New System.Drawing.Size(22, 24)
        Me.lstcantidad3.TabIndex = 47
        Me.lstcantidad3.TabStop = False
        '
        'lstdescripcion3
        '
        Me.lstdescripcion3.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lstdescripcion3.Location = New System.Drawing.Point(26, 136)
        Me.lstdescripcion3.Name = "lstdescripcion3"
        Me.lstdescripcion3.Size = New System.Drawing.Size(125, 24)
        Me.lstdescripcion3.TabIndex = 46
        Me.lstdescripcion3.TabStop = False
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(37, 110)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(151, 15)
        Me.Label14.Text = "Ultimos productos agregados"
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.clientesBindingSource
        Me.ComboBox2.DisplayMember = "codigocliente"
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.ComboBox2.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.ComboBox2.Location = New System.Drawing.Point(4, -137)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(46, 19)
        Me.ComboBox2.TabIndex = 62
        Me.ComboBox2.ValueMember = "codigocliente"
        '
        'ClientesTableAdapter1
        '
        Me.ClientesTableAdapter1.ClearBeforeFill = True
        '
        'ComboBox3
        '
        Me.ComboBox3.DataSource = Me.clientesBindingSource
        Me.ComboBox3.DisplayMember = "codigocliente"
        Me.ComboBox3.Enabled = False
        Me.ComboBox3.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.ComboBox3.Location = New System.Drawing.Point(3, 3)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(45, 19)
        Me.ComboBox3.TabIndex = 90
        Me.ComboBox3.TabStop = False
        Me.ComboBox3.ValueMember = "codigocliente"
        '
        'SP
        '
        Me.SP.BaudRate = 57600
        Me.SP.PortName = "COM4"
        '
        'pedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lstimp4)
        Me.Controls.Add(Me.lstprecio3)
        Me.Controls.Add(Me.lstcantidad3)
        Me.Controls.Add(Me.lstdescripcion3)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lstimporte)
        Me.Controls.Add(Me.lstprecio)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lstcodigo)
        Me.Controls.Add(Me.lstcodigo2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lstcantidad)
        Me.Controls.Add(Me.lstdescripcion)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.txtcantidad)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lstprecio2)
        Me.Controls.Add(Me.lstdescripcion2)
        Me.Controls.Add(Me.txtbusqueda)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.KeyPreview = True
        Me.Menu = Me.mainMenu1
        Me.Name = "pedidos"
        Me.Text = "Pedidos"
        CType(Me.clientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PtoventaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents txtbusqueda As System.Windows.Forms.TextBox
    Friend WithEvents lstdescripcion2 As System.Windows.Forms.ListBox
    Friend WithEvents lstprecio2 As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtcantidad As System.Windows.Forms.TextBox
    Friend WithEvents btnagregar As System.Windows.Forms.Button
    Friend WithEvents lstdescripcion As System.Windows.Forms.ListBox
    Friend WithEvents lstcantidad As System.Windows.Forms.ListBox
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents modifcant As System.Windows.Forms.MenuItem
    Friend WithEvents removeit As System.Windows.Forms.MenuItem
    Friend WithEvents lstcodigo2 As System.Windows.Forms.ListBox
    Friend WithEvents lstcodigo As System.Windows.Forms.ListBox
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lstprecio As System.Windows.Forms.ListBox
    Friend WithEvents lstimporte As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lstimp4 As System.Windows.Forms.ListBox
    Friend WithEvents lstprecio3 As System.Windows.Forms.ListBox
    Friend WithEvents lstcantidad3 As System.Windows.Forms.ListBox
    Friend WithEvents lstdescripcion3 As System.Windows.Forms.ListBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents clientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PtoventaDataSet As ptoventa.ptoventaDataSet
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ClientesTableAdapter1 As ptoventa.ptoventaDataSetTableAdapters.clientesTableAdapter
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents SP As System.IO.Ports.SerialPort
End Class

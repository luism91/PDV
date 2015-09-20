<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class modifproductos
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
        Me.mainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtbusqueda = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lstcodigo = New System.Windows.Forms.ListBox
        Me.lstdescripcion = New System.Windows.Forms.ListBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtcodigo = New System.Windows.Forms.TextBox
        Me.txtdescripcion = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtprecio = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.lstprecio = New System.Windows.Forms.ListBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.lblmovimientos = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.Add(Me.MenuItem1)
        Me.mainMenu1.MenuItems.Add(Me.MenuItem4)
        '
        'MenuItem1
        '
        Me.MenuItem1.MenuItems.Add(Me.MenuItem5)
        Me.MenuItem1.MenuItems.Add(Me.MenuItem2)
        Me.MenuItem1.MenuItems.Add(Me.MenuItem3)
        Me.MenuItem1.Text = "Opciones"
        '
        'MenuItem5
        '
        Me.MenuItem5.Text = "Eliminar Prod."
        '
        'MenuItem2
        '
        Me.MenuItem2.MenuItems.Add(Me.MenuItem6)
        Me.MenuItem2.MenuItems.Add(Me.MenuItem7)
        Me.MenuItem2.Text = "Nuevo Prod."
        '
        'MenuItem6
        '
        Me.MenuItem6.Text = "1 - Agregar"
        '
        'MenuItem7
        '
        Me.MenuItem7.Text = "2 - Guardar"
        '
        'MenuItem3
        '
        Me.MenuItem3.Checked = True
        Me.MenuItem3.Text = "Movimientos recientes"
        '
        'MenuItem4
        '
        Me.MenuItem4.Text = "Menú Principal"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(4, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 15)
        Me.Label1.Text = "Buscar"
        '
        'txtbusqueda
        '
        Me.txtbusqueda.Location = New System.Drawing.Point(51, 1)
        Me.txtbusqueda.Name = "txtbusqueda"
        Me.txtbusqueda.Size = New System.Drawing.Size(87, 21)
        Me.txtbusqueda.TabIndex = 1
        Me.txtbusqueda.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(0, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 10)
        Me.Label2.Text = "Codigo"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(66, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 10)
        Me.Label3.Text = "Descripcion"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(0, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(240, 5)
        Me.Label5.Text = "Label5"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Black
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(0, 153)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(240, 5)
        Me.Label6.Text = "Label6"
        '
        'lstcodigo
        '
        Me.lstcodigo.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lstcodigo.Location = New System.Drawing.Point(0, 56)
        Me.lstcodigo.Name = "lstcodigo"
        Me.lstcodigo.Size = New System.Drawing.Size(63, 90)
        Me.lstcodigo.TabIndex = 12
        Me.lstcodigo.TabStop = False
        '
        'lstdescripcion
        '
        Me.lstdescripcion.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lstdescripcion.Location = New System.Drawing.Point(66, 56)
        Me.lstdescripcion.Name = "lstdescripcion"
        Me.lstdescripcion.Size = New System.Drawing.Size(127, 90)
        Me.lstdescripcion.TabIndex = 13
        Me.lstdescripcion.TabStop = False
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(0, 199)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.Text = "Descripcion"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(3, 180)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.Text = "Codigo"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(41, 158)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(144, 20)
        Me.Label10.Text = "Producto a Modificar"
        '
        'txtcodigo
        '
        Me.txtcodigo.Enabled = False
        Me.txtcodigo.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.txtcodigo.Location = New System.Drawing.Point(64, 178)
        Me.txtcodigo.MaxLength = 12
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(68, 18)
        Me.txtcodigo.TabIndex = 22
        Me.txtcodigo.TabStop = False
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.txtdescripcion.Location = New System.Drawing.Point(64, 199)
        Me.txtdescripcion.MaxLength = 30
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(173, 18)
        Me.txtdescripcion.TabIndex = 23
        Me.txtdescripcion.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(15, 241)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 20)
        Me.Button1.TabIndex = 25
        Me.Button1.TabStop = False
        Me.Button1.Text = "&Editar Producto"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.Location = New System.Drawing.Point(116, 241)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(105, 20)
        Me.Button2.TabIndex = 26
        Me.Button2.TabStop = False
        Me.Button2.Text = "&Guardar Cambios"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(3, 219)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.Text = "Precio"
        '
        'txtprecio
        '
        Me.txtprecio.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.txtprecio.Location = New System.Drawing.Point(64, 219)
        Me.txtprecio.MaxLength = 10
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(68, 18)
        Me.txtprecio.TabIndex = 24
        Me.txtprecio.TabStop = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(198, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 10)
        Me.Label4.Text = "Precio"
        '
        'lstprecio
        '
        Me.lstprecio.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lstprecio.Location = New System.Drawing.Point(197, 56)
        Me.lstprecio.Name = "lstprecio"
        Me.lstprecio.Size = New System.Drawing.Size(40, 90)
        Me.lstprecio.TabIndex = 14
        Me.lstprecio.TabStop = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(161, 1)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(72, 20)
        Me.Button3.TabIndex = 37
        Me.Button3.Text = "Actualizar"
        '
        'lblmovimientos
        '
        Me.lblmovimientos.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.lblmovimientos.ForeColor = System.Drawing.Color.Red
        Me.lblmovimientos.Location = New System.Drawing.Point(4, 23)
        Me.lblmovimientos.Name = "lblmovimientos"
        Me.lblmovimientos.Size = New System.Drawing.Size(136, 15)
        '
        'modifproductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.Controls.Add(Me.lblmovimientos)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtprecio)
        Me.Controls.Add(Me.txtdescripcion)
        Me.Controls.Add(Me.txtcodigo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lstprecio)
        Me.Controls.Add(Me.lstdescripcion)
        Me.Controls.Add(Me.lstcodigo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtbusqueda)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 6.0!, System.Drawing.FontStyle.Regular)
        Me.Menu = Me.mainMenu1
        Me.Name = "modifproductos"
        Me.Text = "Modificar Productos"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtbusqueda As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lstcodigo As System.Windows.Forms.ListBox
    Friend WithEvents lstdescripcion As System.Windows.Forms.ListBox
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtprecio As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lstprecio As System.Windows.Forms.ListBox
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents lblmovimientos As System.Windows.Forms.Label
End Class

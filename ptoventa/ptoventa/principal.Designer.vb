<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class principal
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
        Me.btnventas = New System.Windows.Forms.Button
        Me.btncorte = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnpedidos = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.btncompras = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.Add(Me.MenuItem1)
        '
        'MenuItem1
        '
        Me.MenuItem1.Text = "&Salir"
        '
        'btnventas
        '
        Me.btnventas.Location = New System.Drawing.Point(25, 174)
        Me.btnventas.Name = "btnventas"
        Me.btnventas.Size = New System.Drawing.Size(190, 27)
        Me.btnventas.TabIndex = 0
        Me.btnventas.TabStop = False
        Me.btnventas.Text = "&Ventas"
        '
        'btncorte
        '
        Me.btncorte.Location = New System.Drawing.Point(25, 211)
        Me.btncorte.Name = "btncorte"
        Me.btncorte.Size = New System.Drawing.Size(190, 27)
        Me.btncorte.TabIndex = 1
        Me.btncorte.TabStop = False
        Me.btncorte.Text = "&Corte"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(25, 139)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(190, 27)
        Me.Button1.TabIndex = 2
        Me.Button1.TabStop = False
        Me.Button1.Text = "&Agregar/Modificar producto"
        '
        'btnpedidos
        '
        Me.btnpedidos.Location = New System.Drawing.Point(25, 69)
        Me.btnpedidos.Name = "btnpedidos"
        Me.btnpedidos.Size = New System.Drawing.Size(190, 27)
        Me.btnpedidos.TabIndex = 3
        Me.btnpedidos.TabStop = False
        Me.btnpedidos.Text = "&Pedidos"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(25, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 25)
        Me.Label1.Text = "Label1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btncompras
        '
        Me.btncompras.Location = New System.Drawing.Point(25, 104)
        Me.btncompras.Name = "btncompras"
        Me.btncompras.Size = New System.Drawing.Size(190, 27)
        Me.btncompras.TabIndex = 4
        Me.btncompras.TabStop = False
        Me.btncompras.Text = "&Compras Cueros"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(25, 36)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(190, 27)
        Me.Button2.TabIndex = 6
        Me.Button2.TabStop = False
        Me.Button2.Text = "&Clientes"
        '
        'principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btncompras)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnpedidos)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btncorte)
        Me.Controls.Add(Me.btnventas)
        Me.Menu = Me.mainMenu1
        Me.Name = "principal"
        Me.Text = "Menú Principal"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents btnventas As System.Windows.Forms.Button
    Friend WithEvents btncorte As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnpedidos As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btncompras As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class

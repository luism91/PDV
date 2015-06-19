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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
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
        Me.btnventas.Location = New System.Drawing.Point(25, 117)
        Me.btnventas.Name = "btnventas"
        Me.btnventas.Size = New System.Drawing.Size(190, 27)
        Me.btnventas.TabIndex = 0
        Me.btnventas.TabStop = False
        Me.btnventas.Text = "&Pedidos/Ventas"
        '
        'btncorte
        '
        Me.btncorte.Location = New System.Drawing.Point(25, 157)
        Me.btncorte.Name = "btncorte"
        Me.btncorte.Size = New System.Drawing.Size(190, 27)
        Me.btncorte.TabIndex = 1
        Me.btncorte.TabStop = False
        Me.btncorte.Text = "&Corte"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(25, 76)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(190, 27)
        Me.Button1.TabIndex = 2
        Me.Button1.TabStop = False
        Me.Button1.Text = "&Agregar/Modificar producto"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(25, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 17)
        Me.Label1.Text = "Label1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(25, 34)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(190, 27)
        Me.Button2.TabIndex = 6
        Me.Button2.TabStop = False
        Me.Button2.Text = "&Clientes"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(65, 239)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(117, 20)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Generar Respaldo"
        '
        'principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button

End Class

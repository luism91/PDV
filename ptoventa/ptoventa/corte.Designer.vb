<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class corte
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
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.lstnombrec = New System.Windows.Forms.ListBox
        Me.lstfecha = New System.Windows.Forms.ListBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lstimporte = New System.Windows.Forms.ListBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lbltotal = New System.Windows.Forms.Label
        Me.SP = New System.IO.Ports.SerialPort(Me.components)
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.Button1 = New System.Windows.Forms.Button
        Me.lstcodventa = New System.Windows.Forms.ListBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.Add(Me.MenuItem2)
        Me.mainMenu1.MenuItems.Add(Me.MenuItem1)
        '
        'MenuItem2
        '
        Me.MenuItem2.MenuItems.Add(Me.MenuItem3)
        Me.MenuItem2.Text = "Saldos"
        '
        'MenuItem3
        '
        Me.MenuItem3.Text = "Liquidar"
        '
        'MenuItem1
        '
        Me.MenuItem1.MenuItems.Add(Me.MenuItem5)
        Me.MenuItem1.MenuItems.Add(Me.MenuItem4)
        Me.MenuItem1.Text = "Opciones"
        '
        'MenuItem5
        '
        Me.MenuItem5.Text = "Imprimir corte"
        '
        'MenuItem4
        '
        Me.MenuItem4.Text = "Ir a Menu principal"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.DateTimePicker1.CustomFormat = "DD/MM/YYYY"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(31, 18)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(94, 19)
        Me.DateTimePicker1.TabIndex = 0
        '
        'RadioButton1
        '
        Me.RadioButton1.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.RadioButton1.Location = New System.Drawing.Point(6, -2)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(119, 20)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.Text = "Por rango de fechas"
        '
        'lstnombrec
        '
        Me.lstnombrec.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lstnombrec.Location = New System.Drawing.Point(30, 77)
        Me.lstnombrec.Name = "lstnombrec"
        Me.lstnombrec.Size = New System.Drawing.Size(109, 167)
        Me.lstnombrec.TabIndex = 6
        '
        'lstfecha
        '
        Me.lstfecha.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lstfecha.Location = New System.Drawing.Point(143, 77)
        Me.lstfecha.Name = "lstfecha"
        Me.lstfecha.Size = New System.Drawing.Size(45, 167)
        Me.lstfecha.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(136, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 10)
        Me.Label3.Text = "Fecha"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(17, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 10)
        Me.Label4.Text = "Nombre Cliente"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lstimporte
        '
        Me.lstimporte.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lstimporte.Location = New System.Drawing.Point(190, 77)
        Me.lstimporte.Name = "lstimporte"
        Me.lstimporte.Size = New System.Drawing.Size(49, 167)
        Me.lstimporte.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(183, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 10)
        Me.Label5.Text = "Importe"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(57, 250)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 16)
        Me.Label2.Text = "Total"
        '
        'lbltotal
        '
        Me.lbltotal.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbltotal.Location = New System.Drawing.Point(108, 248)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(89, 17)
        '
        'SP
        '
        Me.SP.BaudRate = 57600
        Me.SP.PortName = "COM4"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CalendarFont = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.DateTimePicker2.CustomFormat = "DD/MM/YYYY"
        Me.DateTimePicker2.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(131, 18)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(94, 19)
        Me.DateTimePicker2.TabIndex = 24
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(64, 43)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 22)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Filtrar resultados"
        '
        'lstcodventa
        '
        Me.lstcodventa.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lstcodventa.Location = New System.Drawing.Point(1, 77)
        Me.lstcodventa.Name = "lstcodventa"
        Me.lstcodventa.Size = New System.Drawing.Size(26, 167)
        Me.lstcodventa.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(2, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 10)
        Me.Label1.Text = "Cod."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'corte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstcodventa)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lstimporte)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lstfecha)
        Me.Controls.Add(Me.lstnombrec)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Menu = Me.mainMenu1
        Me.Name = "corte"
        Me.Text = "Corte"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents lstnombrec As System.Windows.Forms.ListBox
    Friend WithEvents lstfecha As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents lstimporte As System.Windows.Forms.ListBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents SP As System.IO.Ports.SerialPort
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lstcodventa As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
End Class

Imports System.Data
Public Class pedidos
    Dim rowview As Integer
    Dim pedrow As DataRow
    Dim row As DataRowView
    Private Sub pedidos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.ProductosTableAdapter1.Fill(Me.PtoventaDataSet.productos)
        Me.ClientesTableAdapter1.Fill(Me.PtoventaDataSet.clientes)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        poblartablas(0)

        lstdescripcion2.DataSource = tablaquery
        lstdescripcion2.DisplayMember = "descripcion"
        lstprecio2.DataSource = tablaquery
        lstprecio2.DisplayMember = "precio"
        lstcodigo2.DataSource = tablaquery
        lstcodigo2.DisplayMember = "codigo"
        generarnota = 0
    End Sub
    Public Function cargarnota(ByVal codigocliente As Integer) As Integer

        ComboBox1.Enabled = False
        lstcantidad.Items.Clear()
        lstdescripcion.Items.Clear()
        lstcodigo.Items.Clear()
        poblartablas(0)
        'Filtrar por codigo de cliente y si la nota esta abierta.
        tablacargas.RowFilter = "codigocliente ='" & ComboBox2.SelectedValue & "' AND venta_finalizada =0"
        If tablacargas.Count = 0 Then
            MsgBox("No hay notas pendientes", MsgBoxStyle.OkOnly, "Notas")
        Else
            codventa = tablacargas(0)("codigoventa")
            cvCargarNota = codventa
            poblartablas(2)
            For Me.rowview = 0 To dsdetalleNota.Tables("informacionticket").Rows.Count - 1
                Dim cantidad As Double
                cantidad = (CDec(dsdetalleNota.Tables("informacionticket").Rows(rowview)("cantidad").ToString()))
                lstcantidad.Items.Add(cantidad)
                lstdescripcion.Items.Add(dsdetalleNota.Tables("informacionticket").Rows(rowview)("descripcion").ToString())
                lstcodigo.Items.Add(dsdetalleNota.Tables("informacionticket").Rows(rowview)("codigo").ToString())
                precio = (CDec(dsdetalleNota.Tables("informacionticket").Rows(rowview)("precio").ToString()))
                importe = precio * (cantidad)
                lstprecio.Items.Add(Format(CDec(precio), ".00"))
                lstimporte.Items.Add(Format(CDec(importe), ".00"))
            Next Me.rowview

            txtbusqueda.Text = ""
            txtcantidad.Text = ""
            cantidad = 0
            precio = 0
            importe = 0
            txtbusqueda.Focus()
        End If


    End Function
    Private Sub txtbusqueda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtbusqueda.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtcantidad.Focus()
        End If

    End Sub

    Private Sub txtbusqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbusqueda.TextChanged
        tablaquery.RowFilter = ("codigo LIKE '" & txtbusqueda.Text & "%'")
    End Sub

    Private Sub btnagregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnagregar.Click


        If ComboBox1.Enabled = True Then
            generarnota = 1
            ComboBox1.Enabled = False
        End If



        If lstdescripcion.Items.Count = 34 Then
            MsgBox("No puedes agregar mas productos", MsgBoxStyle.OkOnly, "Limite de productos")
            txtcantidad.Text = ""
            txtbusqueda.Text = ""
            txtbusqueda.Focus()

        Else
            If ComboBox2.SelectedIndex >= 1 And generarnota = 1 Then

                poblartablas(0)
                tablacargas.RowFilter = "codigocliente ='" & ComboBox2.SelectedValue & "' AND venta_finalizada =0"

                If tablacargas.Count = 0 Then
                    Try
                        ComboBox1.Enabled = False
                        cmd.Connection = conn
                        cmd.CommandText = "INSERT INTO ventas(codigocliente,dia,mes,anio,venta_finalizada) VALUES('" & ComboBox2.SelectedValue & "','" & Date.Now.Day & "','" & Date.Now.Month & "','" & Date.Now.Year & "','0')"
                        cmd.ExecuteNonQuery()
                        generarnota = 0
                        poblartablas(0)
                        tablacargas.RowFilter = "codigocliente ='" & ComboBox2.SelectedValue & "' AND venta_finalizada =0"
                        codventa = tablacargas(0)("codigoventa")
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
                    End Try
                Else
                    MsgBox("Ya hay una nota abierta con este cliente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                    generarnota = 0
                    cargarnota(ComboBox2.SelectedValue)
                    Exit Sub
                End If
            End If

            If generarnota = 0 Then

                'Query para instertar productos a la nota

                Try
                    If txtcantidad.Text = Nothing Then
                        cantidad = 0
                        txtcantidad.Text = 0
                    End If
                    desc = lstdescripcion2.Text
                    precio = Val(lstprecio2.Text)
                    codigo = lstcodigo2.Text
                    importe = Val(lstprecio2.Text) * Val(txtcantidad.Text)
                    cantidad = Val(txtcantidad.Text)
                    cmd.Connection = conn
                    cmd.CommandText = "INSERT INTO detalle_ventas(codigoventa,codigo,cantidad) VALUES('" & codventa & "','" & codigo & "','" & cantidad & "')"
                    cmd.ExecuteNonQuery()

                    lstcodigo.Items.Add(codigo)
                    lstdescripcion.Items.Add(desc)
                    lstprecio.Items.Add(Format(CDec(precio), ".00"))
                    lstimporte.Items.Add(Format(CDec(importe), ".00"))
                    lstcantidad.Items.Add(cantidad)

                    If lstdescripcion3.Items.Count = 2 Then
                        lstcantidad3.Items.Clear()
                        lstdescripcion3.Items.Clear()
                        lstprecio3.Items.Clear()
                        lstimp4.Items.Clear()

                        lstdescripcion3.Items.Add(desc)
                        lstprecio3.Items.Add(Format(CDec(precio), ".00"))
                        lstimp4.Items.Add(Format(CDec(importe), ".00"))
                        lstcantidad3.Items.Add(cantidad)
                    Else
                        lstdescripcion3.Items.Add(desc)
                        lstprecio3.Items.Add(Format(CDec(precio), ".00"))
                        lstimp4.Items.Add(Format(CDec(importe), ".00"))
                        lstcantidad3.Items.Add(cantidad)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
                End Try

            End If

            desc = ""
            precio = 0
            importe = 0
            cantidad = 0
            txtcantidad.Text = ""
            txtbusqueda.Text = ""
            txtbusqueda.Focus()
            End If
    End Sub

    Private Sub txtcantidad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcantidad.KeyDown
        Dim numero As Short = CShort(Asc(e.KeyCode))
        If InStr("1234567890.", Chr(numero)) = 0 Then
            e.Handled = True
        Else
            e.Handled = False
        End If

        If e.Handled = False Then
            If lstdescripcion.Items.Count <= 29 Then
                If e.KeyCode = Keys.Enter Then
                    btnagregar_Click(Nothing, Nothing)
                    txtcantidad.Text = ""
                    txtbusqueda.Text = ""
                End If
            Else
                MsgBox("No puedes agregar mas productos", MsgBoxStyle.OkOnly, "Limite de productos")
                txtcantidad.Text = ""
                txtbusqueda.Text = ""
            End If
        ElseIf e.Handled = True Then
            txtcantidad.Text = ""
            txtcantidad.Focus()
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click



        'Limpiar para poder agregar una nueva nota
        txtbusqueda.Text = ""
        txtcantidad.Text = ""
        lstcantidad.Items.Clear()
        lstdescripcion.Items.Clear()
        lstcodigo.Items.Clear()
        lstprecio.Items.Clear()
        lstimporte.Items.Clear()
        txtbusqueda.Focus()
        lstcantidad3.Items.Clear()
        lstdescripcion3.Items.Clear()
        lstprecio3.Items.Clear()
        lstimp4.Items.Clear()
        ComboBox1.Enabled = True
        ComboBox1.SelectedIndex = 0
        ComboBox1.Focus()


    End Sub

    Private Sub pedidos_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.Down Then
            If lstdescripcion2.SelectedIndex >= 0 And lstdescripcion2.SelectedIndex <= lstdescripcion2.Items.Count - 2 Then
                mover = lstdescripcion2.SelectedIndex
                mover = mover + 1
                lstdescripcion2.SelectedIndex = mover
            End If
        ElseIf e.KeyCode = Keys.Up Then
            If lstdescripcion2.SelectedIndex >= 1 And lstdescripcion2.SelectedIndex <= lstdescripcion2.Items.Count - 1 Then
                mover = lstdescripcion2.SelectedIndex
                mover = mover - 1
                lstdescripcion2.SelectedIndex = mover
            End If
        End If

        If (e.KeyCode = System.Windows.Forms.Keys.Up) Then
            'Up
        End If
        If (e.KeyCode = System.Windows.Forms.Keys.Down) Then
            'Down
        End If
        If (e.KeyCode = System.Windows.Forms.Keys.Left) Then
            'Left
        End If
        If (e.KeyCode = System.Windows.Forms.Keys.Right) Then
            'Right
        End If
        If (e.KeyCode = System.Windows.Forms.Keys.Enter) Then
            'Enter
        End If

    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles removeit.Click

        Try
            cmd.Connection = conn
            cmd.CommandText = "DELETE FROM detalle_ventas WHERE codigoventa = '" & codventa & "' AND codigo = '" & lstcodigo.Text & "'"
            cmd.ExecuteNonQuery()
            Dim itseleccionado As Integer
            itseleccionado = lstcantidad.SelectedIndex
            lstcantidad.Items.RemoveAt(itseleccionado)
            lstdescripcion.Items.RemoveAt(itseleccionado)
            lstcodigo.Items.RemoveAt(itseleccionado)
            lstprecio.Items.RemoveAt(itseleccionado)
            lstimporte.Items.RemoveAt(itseleccionado)
            itseleccionado = 0
            txtbusqueda.Focus()
            poblartablas(2)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
        End Try



    End Sub

    Private Sub modifcant_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles modifcant.Click

        cantinput = InputBox("Introduce la cantidad deseada de " & vbCrLf & "[ " & lstdescripcion.Text & " ]", "Modificar Cantidad")
        Try
            cmd.Connection = conn
            cmd.CommandText = "UPDATE detalle_ventas SET cantidad = '" & cantinput & "' WHERE codigoventa ='" & codventa & "' AND codigo ='" & lstcodigo.Text & "'"
            cmd.ExecuteNonQuery()
            lstcantidad.Items.Item(lstcantidad.SelectedIndex) = cantinput
            cantinput = 0
            preimporte = Val(lstprecio.Text) * Val(lstcantidad.Text)
            lstimporte.Items.Item(lstcantidad.SelectedIndex) = (Format(CDec(preimporte), ".00"))
            poblartablas(2)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
        End Try



    End Sub

    Private Sub lstcantidad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstcantidad.SelectedIndexChanged
        lstdescripcion.SelectedIndex = lstcantidad.SelectedIndex
        lstcodigo.SelectedIndex = lstcantidad.SelectedIndex
        lstprecio.SelectedIndex = lstcantidad.SelectedIndex
        lstimporte.SelectedIndex = lstcantidad.SelectedIndex

    End Sub

    Private Sub lstdescripcion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstdescripcion.SelectedIndexChanged
        lstcantidad.SelectedIndex = lstdescripcion.SelectedIndex
        lstcodigo.SelectedIndex = lstdescripcion.SelectedIndex
        lstprecio.SelectedIndex = lstdescripcion.SelectedIndex
        lstimporte.SelectedIndex = lstdescripcion.SelectedIndex


    End Sub
    Private Sub MenuItem4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click

        cargarnota(ComboBox2.SelectedValue)

    End Sub

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        Dim principal As New principal
        principal.ShowDialog()
        Me.Close()
    End Sub
    Private Sub txtcantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcantidad.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click

    End Sub
End Class
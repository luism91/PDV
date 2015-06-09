Imports System.Data.SqlClient
Imports System.Data.SqlServerCe
Imports System
Imports System.Data
Imports System.Text
Imports System.IO.Ports
Imports System.Threading

Public Class ventas
    Dim precio, cantidad, importe, total, preimporte, cantinput As Decimal
    Dim i, fila, elementos, rowview, mover As Integer
    Dim desc, codigo, errorimp As String
    Dim cmd As New SqlCeCommand
    Dim conn As New SqlCeConnection("Data Source=\Program Files\ptoventa\ptoventa.sdf")
    Dim dataprod As New SqlCeDataAdapter("SELECT * FROM productos ORDER BY codigo ASC", conn)
    Dim datapedi As New SqlCeDataAdapter("SELECT * FROM ventas", conn)
    Dim tprod As New DataTable
    Dim tped As New DataTable
    Dim tablaquery As New DataView
    Dim tablacargas As New DataView
    Dim dsprod As New DataSet
    Dim dsped As New DataSet
    Dim currentDate As DateTime = DateTime.Now
    Dim dateString As String = "dd-MM-yyyy"
    Dim DataString As StringBuilder


    Private Sub ventas_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Dim currentDate As DateTime = DateTime.Now
        Dim dateString As String = "dd-MM-yyyy"
        Label5.Text = currentDate.ToString(dateString)

    End Sub
    Public Function cargarnota(ByVal codigocliente As Integer) As Integer

        lstcantidad.Items.Clear()
        lstdescripcion.Items.Clear()
        lstcodigo.Items.Clear()
        lstprecio.Items.Clear()
        lstimporte.Items.Clear()
        dsped.Clear()
        datapedi.Fill(dsped, "ventas")

        tablacargas.RowFilter = "codigocliente ='" & codigocliente & "'"

        If tablacargas.Count = 0 Then
            MsgBox("No hay notas pendientes", MsgBoxStyle.OkOnly, "Notas")
        Else

            For Me.rowview = 0 To tablacargas.Count - 1
                tablaquery.RowFilter = "codigo = '" & tablacargas.Item(rowview).Row(1).ToString & "'"
                lstcantidad.Items.Add(tablacargas.Item(rowview).Row(2))
                lstdescripcion.Items.Add(lstdescripcion2.Text)
                precio = Val(lstprecio2.Text)
                importe = Val(lstprecio2.Text) * Val(tablacargas.Item(rowview).Row(2))
                lstprecio.Items.Add(Format(CDec(precio), ".00"))
                lstimporte.Items.Add(Format(CDec(importe), ".00"))
                precio = 0
                importe = 0
                lstcodigo.Items.Add(lstcodigo2.Text)
                tablaquery.RowFilter = Nothing

            Next Me.rowview
            End If

            tablacargas.RowFilter = Nothing
            txtbusqueda.Text = ""
            txtcantidad.Text = ""

    End Function

    Private Function imprimirecibo(ByVal tiporecibo As String) As Integer

        DataString = New StringBuilder()

        Try
            If SP.IsOpen = False Then
                SP.Open()
            End If

            DataString.Append("! U1 SETLP 4 0 27" & vbCrLf)
            DataString.Append("! U1 XY 10 0" & vbCrLf)
            DataString.Append(ComboBox1.Text & vbCrLf)
            DataString.Append("! U1 XY 10 40" & vbCrLf)
            DataString.Append(Date.Today & vbCrLf)
            DataString.Append("! U1 XY 10 80" & vbCrLf)
            DataString.Append(tiporecibo & vbCrLf)

            DataString.Append("! U1 SETLP 5 0 20" & vbCrLf)
            DataString.Append("! U1 XY 10 130" & vbCrLf)
            DataString.Append("Cant." & vbCrLf)
            DataString.Append("! U1 XY 80 130" & vbCrLf)
            DataString.Append("Descripcion" & vbCrLf)
            DataString.Append("! U1 XY 390 130" & vbCrLf)
            DataString.Append("Prec." & vbCrLf)
            DataString.Append("! U1 XY 490 130" & vbCrLf)
            DataString.Append("Imp." & vbCrLf)

            fila = 160

            For Me.elementos = 0 To (lstdescripcion.Items.Count - 1)
                lstprecio.SelectedIndex = elementos
                lstdescripcion.SelectedIndex = elementos
                lstcantidad.SelectedIndex = elementos
                lstimporte.SelectedIndex = elementos

                DataString.Append("! U1 XY 10 " & fila & "" & vbCrLf)
                DataString.Append("" & lstcantidad.Text & "" & vbCrLf)
                DataString.Append("! U1 XY 80 " & fila & "" & vbCrLf)
                DataString.Append("" & lstdescripcion.Text & "" & vbCrLf)
                DataString.Append("! U1 XY 390 " & fila & "" & vbCrLf)
                DataString.Append("" & lstprecio.Text & "" & vbCrLf)
                DataString.Append("! U1 XY 490 " & fila & "" & vbCrLf)
                DataString.Append("" & lstimporte.Text & "" & vbCrLf)

                fila = fila + 27
            Next Me.elementos


            DataString.Append("! U1 SETLP 4 0 27" & vbCrLf)
            DataString.Append("! U1 XY 55 1090" & vbCrLf)
            DataString.Append("Importe Total: " & "$" & (Format(CDec(total), ".00")) & "" & vbCrLf)

            DataString.Append("! U1 SETLP 5 0 20" & vbCrLf)
            DataString.Append("! U1 XY 10 1190" & vbCrLf)
            DataString.Append("-------------------" & vbCrLf)
            DataString.Append("! U1 XY 10 1210" & vbCrLf)
            DataString.Append("RECIBI" & vbCrLf)

            SP.WriteLine(DataString.ToString())
            System.Threading.Thread.Sleep(2500)
            SP.Close()

        Catch ex As Exception
            MsgBox("Por favor encienda la impresora o acerquese", MsgBoxStyle.OkOnly)
        End Try




    End Function


    Private Sub ventas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

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

        If e.KeyCode = Keys.Tab Then

            If MsgBox("Deseas Realizar la venta?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                total = 0
                For Me.i = 0 To (lstimporte.Items.Count - 1)
                    lstimporte.SelectedIndex = Me.i
                    total = (total) + (Val(lstimporte.Text))
                Next Me.i

                lbimporte.Text = Nothing
                lbimporte.Text = (Format(CDec(total), ".00"))

                imprimirecibo("*--ORIGINAL--*")

                If MsgBox("Oprime YES para imprimir la COPIA", MsgBoxStyle.YesNo, "Impresion") = MsgBoxResult.Yes Then
                    imprimirecibo("*--COPIA--*")
                End If

                tablacargas.RowFilter = "codigocliente ='" & ComboBox1.SelectedIndex + 1 & "'"
                If tablacargas.Count > 29 Then
                    For Me.i = 0 To 29
                        tablacargas.Delete(i)
                    Next
                Else
                    tablacargas.RowFilter = Nothing
                    cmd.Connection = conn
                    cmd.CommandText = "DELETE FROM pedidos WHERE codigocliente = '" & ComboBox1.SelectedIndex + 1 & "'"
                    cmd.ExecuteNonQuery()
                End If



            End If


        End If

    End Sub
    Private Sub ventas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.ClientesTableAdapter1.Fill(Me.PtoventaDataSet.clientes)
        conn.Open()

        dataprod.Fill(dsprod, "productos")
        datapedi.Fill(dsped, "ventas")

        tprod = dsprod.Tables("productos")
        tped = dsped.Tables("ventas")

        tablaquery = tprod.DefaultView
        tablacargas = tped.DefaultView

        lstdescripcion2.DataSource = dsprod.Tables("productos")
        lstdescripcion2.DisplayMember = "descripcion"
        lstprecio2.DataSource = dsprod.Tables("productos")
        lstprecio2.DisplayMember = "precio"
        lstcodigo2.DataSource = dsprod.Tables("productos")
        lstcodigo2.DisplayMember = "codigo"


    End Sub
    Private Sub txtbusqueda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtbusqueda.KeyDown

        If txtbusqueda.Text <> "" Then
            If e.KeyCode = Keys.Enter Then
                txtcantidad.Focus()
            End If

        End If

    End Sub

    Private Sub txtbusqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbusqueda.TextChanged
        tablaquery.RowFilter = ("codigo LIKE '" & txtbusqueda.Text & "%'")
    End Sub

    Private Sub btnagregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnagregar.Click

        If lstdescripcion.Items.Count = 34 Then
            MsgBox("No puedes agregar mas productos", MsgBoxStyle.OkOnly, "Limite de productos")
            txtcantidad.Text = ""
            txtbusqueda.Text = ""
            txtbusqueda.Focus()
        Else

            cmd.Connection = conn
            cmd.CommandText = "INSERT INTO pedidos(codigocliente,codigoproducto,cantidad) VALUES('" & ComboBox1.SelectedIndex + 1 & "','" & lstcodigo2.Text & "','" & txtcantidad.Text & "')"
            cmd.ExecuteNonQuery()


            desc = lstdescripcion2.Text
            precio = Val(lstprecio2.Text)
            codigo = lstcodigo2.Text
            If txtcantidad.Text = "" Then
                cantidad = 0
                txtcantidad.Text = 0
            End If
            importe = Val(lstprecio2.Text) * Val(txtcantidad.Text)
            cantidad = Val(txtcantidad.Text)
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
        If e.KeyCode = Keys.Enter Then
            btnagregar_Click(Nothing, Nothing)
            txtcantidad.Text = ""
            txtbusqueda.Text = ""
        End If
        End Sub

    Private Sub lstcantidad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstcantidad.SelectedIndexChanged
        lstdescripcion.SelectedIndex = lstcantidad.SelectedIndex
        lstprecio.SelectedIndex = lstcantidad.SelectedIndex
        lstcodigo.SelectedIndex = lstcantidad.SelectedIndex
        lstimporte.SelectedIndex = lstcantidad.SelectedIndex
    End Sub

    Private Sub lstdescripcion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstdescripcion.SelectedIndexChanged
        lstcantidad.SelectedIndex = lstdescripcion.SelectedIndex
        lstprecio.SelectedIndex = lstdescripcion.SelectedIndex
        lstcodigo.SelectedIndex = lstdescripcion.SelectedIndex
        lstimporte.SelectedIndex = lstdescripcion.SelectedIndex
    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Dim principal As New principal
        principal.ShowDialog()
        Me.Close()
    End Sub

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles modifcant.Click

        cantinput = InputBox("Introduce la cantidad deseada de " & vbCrLf & "[ " & lstdescripcion.Text & " ]", "Modificar Cantidad")
        cmd.Connection = conn
        cmd.CommandText = "UPDATE pedidos SET cantidad = '" & cantinput & "' WHERE codigocliente ='" & ComboBox1.SelectedIndex + 1 & "' AND codigoproducto ='" & lstcodigo.Text & "'"
        cmd.ExecuteNonQuery()
        lstcantidad.Items.Item(lstcantidad.SelectedIndex) = cantinput
        cantinput = 0
        preimporte = Val(lstprecio.Text) * Val(lstcantidad.Text)
        lstimporte.Items.Item(lstcantidad.SelectedIndex) = (Format(CDec(preimporte), ".00"))
        dsped.Clear()
        datapedi.Fill(dsped, "ventas")
        preimporte = 0

    End Sub

    Private Sub MenuItem3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        cmd.Connection = conn
        cmd.CommandText = "DELETE FROM pedidos WHERE codigocliente = '" & ComboBox1.SelectedIndex + 1 & "' AND codigoproducto = '" & lstcodigo.Text & "' "
        cmd.ExecuteNonQuery()
        Dim itseleccionado As Integer
        itseleccionado = lstcantidad.SelectedIndex
        lstprecio.Items.RemoveAt(itseleccionado)
        lstimporte.Items.RemoveAt(itseleccionado)
        lstcantidad.Items.RemoveAt(itseleccionado)
        lstdescripcion.Items.RemoveAt(itseleccionado)
        lstcodigo.Items.RemoveAt(itseleccionado)
        itseleccionado = 0
        dsped.Clear()
        datapedi.Fill(dsped, "ventas")
    End Sub

    Private Sub MenuItem5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        total = 0
        For Me.i = 0 To (lstimporte.Items.Count - 1)
            lstimporte.SelectedIndex = Me.i
            total = (total) + (Val(lstimporte.Text))
        Next Me.i
        lbimporte.Text = (Format(CDec(total), ".00"))
        imprimirecibo("*--DUPLICADO--*")

    End Sub

    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        cargarnota(ComboBox1.SelectedIndex + 1)
       
    End Sub

    Private Sub lstprecio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstprecio.SelectedIndexChanged
        lstcantidad.SelectedIndex = lstprecio.SelectedIndex
        lstdescripcion.SelectedIndex = lstprecio.SelectedIndex
        lstcodigo.SelectedIndex = lstprecio.SelectedIndex
        lstimporte.SelectedIndex = lstprecio.SelectedIndex
    End Sub

    Private Sub lstimporte_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstimporte.SelectedIndexChanged
        lstcantidad.SelectedIndex = lstimporte.SelectedIndex
        lstdescripcion.SelectedIndex = lstimporte.SelectedIndex
        lstcodigo.SelectedIndex = lstimporte.SelectedIndex
        lstprecio.SelectedIndex = lstimporte.SelectedIndex
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

    Private Sub txtcantidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcantidad.TextChanged

    End Sub

    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click

        cmd.Connection = conn
        cmd.CommandText = "INSERT INTO ventas(codigocliente,fechaventa,importetotal,nombrecliente) VALUES('" & ComboBox1.SelectedIndex + 1 & "','" & Date.Today.ToShortDateString & "','" & (Format(CDec(total), ".00")) & "','" & ComboBox1.Text & "')"
        cmd.ExecuteNonQuery()

        lstprecio.Items.Clear()
        lstdescripcion.Items.Clear()
        lstimporte.Items.Clear()
        lstcantidad.Items.Clear()
        lstcodigo.Items.Clear()

        lstcantidad3.Items.Clear()
        lstdescripcion3.Items.Clear()
        lstprecio3.Items.Clear()
        lstimp4.Items.Clear()

        total = 0
        lbimporte.Text = Nothing
        txtbusqueda.Focus()
        ComboBox1.Focus()
    End Sub

    Private Sub lstdescripcion2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lstdescripcion2.KeyDown

        If e.KeyCode = Keys.Enter Then
            txtcantidad.Focus()
        End If
     
    End Sub

    Private Sub lstdescripcion2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstdescripcion2.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim a As Integer

        For a = 0 To 33
            txtbusqueda.Text = "pek"
            txtcantidad.Text = "5.2"
            btnagregar_Click(Nothing, Nothing)
        Next
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim i As Integer


        For i = 0 To 34
            txtbusqueda.Text = "crp"
            txtcantidad.Text = 2
            btnagregar_Click(Nothing, Nothing)
        Next


    End Sub
End Class
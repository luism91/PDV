Imports System.Data.SqlClient
Imports System.Data.SqlServerCe
Imports System
Imports System.Data
Public Class modifproductos
    Dim tablaquery As New DataView
    Dim tprod As New DataTable
    Private Sub modifproductos_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Me.Hide()
        e.Cancel = True
    End Sub
    Private Sub modifproductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        poblartablas(3, 0)
        tablaquery.Table = dsprod.Tables("productos2")
        lstdescripcion.DataSource = tablaquery
        lstdescripcion.DisplayMember = "descripcion"
        lstprecio.DataSource = tablaquery
        lstprecio.DisplayMember = "precio"
        lstcodigo.DataSource = tablaquery
        lstcodigo.DisplayMember = "codigo"

    End Sub

    Private Sub txtbusqueda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtbusqueda.KeyDown

        If e.KeyCode = Keys.Enter Then
            tablaquery.RowFilter = ("codigo LIKE '" & txtbusqueda.Text & "%'")
        End If

    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbusqueda.TextChanged
        'tablaquery.RowFilter = ("codigo LIKE '" & txtbusqueda.Text & "%'")
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Dim principal As New principal
        principal.ShowDialog()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txtcodigo.Text = lstcodigo.Text
        txtdescripcion.Text = lstdescripcion.Text
        txtprecio.Text = lstprecio.Text
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Try
            cmd.Connection = conn
            cmd.CommandText = "UPDATE productos SET descripcion = '" & UCase(txtdescripcion.Text) & "', precio='" & Val(txtprecio.Text) & "' WHERE codigo ='" & txtcodigo.Text & "'"
            cmd.ExecuteNonQuery()
            MsgBox("Producto modificado con exito", MsgBoxStyle.OkOnly, "Modificar Productos")
            lblmovimientos.Text = "Cambios en productos: " & conteo
            ReDim Preserve log(0 To UBound(log) + 1)
            log(mov) = "CAMBIOS en: ->" & UCase(txtdescripcion.Text) & "// $-> " & Val(txtprecio.Text) & ""
            mov = mov + 1
            conteo = conteo + 1
        Catch ex As SqlCeException
            MsgBox(ex.ToString, MsgBoxStyle.OkOnly, "Error")
        End Try


        txtcodigo.Text = ""
        txtdescripcion.Text = ""
        txtprecio.Text = ""
        txtbusqueda.Focus()
        txtbusqueda.Text = ""


       
    End Sub

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click

        If MsgBox("Deseas eliminar el producto seleccionado?", MsgBoxStyle.OkCancel, "Modificacion") = MsgBoxResult.Ok Then
            Try
                cmd.Connection = conn
                cmd.CommandText = "DELETE FROM productos WHERE codigo = '" & lstcodigo.Text & "' "
                cmd.ExecuteNonQuery()
                'poblartablas(3, 0)
                ReDim Preserve log(0 To UBound(log) + 1)
                lblmovimientos.Text = "Cambios en productos: " & mov
                log(mov) = "BAJA ->" & UCase(lstdescripcion.Text) & ""
                mov = mov + 1
                conteo = conteo + 1
                txtbusqueda.Focus()
                txtbusqueda.Text = ""
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
            End Try

        End If

 

    End Sub
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        If MsgBox("Deseas agregar el producto?", MsgBoxStyle.OkCancel, "Productos") = MsgBoxResult.Ok Then

            Try
                cmd.Connection = conn
                cmd.CommandText = "INSERT INTO productos(codigo,descripcion,precio) VALUES('" & txtcodigo.Text & "','" & UCase(txtdescripcion.Text) & "','" & Val(txtprecio.Text) & "')"
                cmd.ExecuteNonQuery()
                MsgBox("Producto agregado con exito", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Modificar Productos")
                lblmovimientos.Text = "Cambios en productos: " & mov
                ReDim Preserve log(0 To UBound(log) + 1)
                log(mov) = "ALTA ->" & UCase(txtdescripcion.Text) & ""
                conteo = conteo + 1
                mov = mov + 1
                txtcodigo.Text = ""
                txtcodigo.Enabled = False
                txtdescripcion.Text = ""
                txtprecio.Text = ""
                txtbusqueda.Text = ""
                txtbusqueda.Focus()
            Catch excep As SqlCeException
                MsgBox(excep.Message, MsgBoxStyle.OkOnly, "Error")
            End Try
        End If

    End Sub

    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        txtcodigo.Enabled = True
        txtcodigo.Focus()
    End Sub

    Private Sub txtcodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcodigo.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtdescripcion.Focus()
        End If
    End Sub

    Private Sub txtcodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcodigo.TextChanged

    End Sub

    Private Sub txtdescripcion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdescripcion.KeyDown, txtdescripcion.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtprecio.Focus()
        End If
    End Sub

    Private Sub txtprecio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtprecio.KeyPress
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
        Dim logcambios As New logcambios
        logcambios.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        mov = 0
        conteo = 1
        lblmovimientos.Text = Nothing
        poblartablas(3, 0)
        txtbusqueda.Text = ""
        tablaquery.RowFilter = ("codigo LIKE '" & txtbusqueda.Text & "%'")
    End Sub

    
End Class
Imports System.Data.SqlClient
Imports System.Data.SqlServerCe
Imports System
Imports System.Data

Public Class modifproductos
    Dim cmd As New SqlCeCommand
    Dim conn As New SqlCeConnection("Data Source=\Program Files\ptoventa\ptoventa.sdf")
    Dim dataprod As New SqlCeDataAdapter("SELECT * FROM productos", conn)
    Dim dsprod As New DataSet
    Dim tprod As New DataTable
    Dim tablaquery As New DataView


    Private Sub modifproductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        conn.Open()
        poblartablas(0, 0)

        tprod = dsprod.Tables("productos2")
        tablaquery = tprod.DefaultView

        lstcodigo.DataSource = dsprod.Tables("productos")
        lstcodigo.DisplayMember = "codigo"
        lstdescripcion.DataSource = dsprod.Tables("productos")
        lstdescripcion.DisplayMember = "descripcion"
        lstprecio.DataSource = dsprod.Tables("productos")
        lstprecio.DisplayMember = "precio"

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbusqueda.TextChanged
        tablaquery.RowFilter = ("codigo LIKE '" & txtbusqueda.Text & "%'")
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
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
            End Try

        End If

        poblartablas(0, 0)
        txtbusqueda.Focus()
        txtbusqueda.Text = ""

    End Sub

    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click

        If MsgBox("Deseas agregar el producto?", MsgBoxStyle.OkCancel, "Productos") = MsgBoxResult.Ok Then

            Try
                cmd.Connection = conn
                cmd.CommandText = "INSERT INTO productos(codigo,descripcion,precio) VALUES('" & txtcodigo.Text & "','" & UCase(txtdescripcion.Text) & "','" & Val(txtprecio.Text) & "')"
                cmd.ExecuteNonQuery()
                MsgBox("Producto agregado con exito", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Modificar Productos")
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

        poblartablas(0, 0)


     

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

    Private Sub txtdescripcion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdescripcion.KeyDown
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
End Class
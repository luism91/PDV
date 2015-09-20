Imports System.Data
Imports System.Data.SqlServerCe
Public Class clientes

    Private Sub clientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        poblartablas(4, 0)
        lstnombre.DataSource = tablaclientes
        lstnombre.DisplayMember = "nombrecliente"
        lstcodigo.DataSource = tablaclientes
        lstcodigo.DisplayMember = "codigocliente"

    End Sub

    Private Sub txtbusqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbusqueda.TextChanged
        tablaclientes.RowFilter = ("nombrecliente LIKE '" & txtbusqueda.Text & "%'")
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        txtcodigo.Text = lstcodigo.Text
        txtnombre.Text = lstnombre.Text

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            cmd.Connection = conn
            cmd.CommandText = "UPDATE clientes SET nombrecliente= '" & UCase(txtnombre.Text) & "' WHERE codigocliente ='" & txtcodigo.Text & "'"
            cmd.ExecuteNonQuery()
            MsgBox("Cliente modificado con exito!", MsgBoxStyle.OkOnly, "Modificar Clientes")
            poblartablas(4, 0)
            txtcodigo.Text = ""
            txtnombre.Text = ""
            txtbusqueda.Focus()
            txtbusqueda.Text = ""
        Catch ex As SqlCeException
            MsgBox(ex.ToString, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click

        If MsgBox("Deseas eliminar el CLIENTE: '" & lstnombre.Text & "'?", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Modificacion") = MsgBoxResult.Ok Then
            Try
                cmd.Connection = conn
                cmd.CommandText = "DELETE FROM clientes WHERE codigocliente = '" & lstcodigo.Text & "'"
                cmd.ExecuteNonQuery()
                poblartablas(4, 0)
                txtbusqueda.Focus()
                txtbusqueda.Text = ""
                txtnombre.Text = ""
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
            End Try
        End If

    End Sub

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        txtnombre.Text = ""
        txtnombre.Focus()
    End Sub

    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        If MsgBox("Deseas agregar el CLIENTE?", MsgBoxStyle.OkCancel, "Clientes") = MsgBoxResult.Ok Then
            Try
                cmd.Connection = conn
                cmd.CommandText = "INSERT INTO clientes(nombrecliente) VALUES('" & UCase(txtnombre.Text) & "')"
                cmd.ExecuteNonQuery()
                MsgBox("CLIENTE agregado con exito", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Modificar Productos")
                txtcodigo.Text = ""
                txtnombre.Text = ""
                txtbusqueda.Text = ""
                txtbusqueda.Focus()
                poblartablas(4, 0)
            Catch excep As SqlCeException
                MsgBox(excep.Message, MsgBoxStyle.OkOnly, "Error")
            End Try
        End If
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Dim principal As New principal
        principal.ShowDialog()
        Me.Close()
    End Sub
End Class
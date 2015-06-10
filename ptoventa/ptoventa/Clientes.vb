Imports System.Data.SqlClient
Imports System.Data.SqlServerCe
Imports System
Imports System.Data

Public Class Clientes
    Dim cmd As New SqlCeCommand
    Dim conn As New SqlCeConnection("Data Source=\Program Files\ptoventa\ptoventa.sdf")
    Dim dataprod As New SqlCeDataAdapter("SELECT * FROM clientes", conn)
    Dim dsclientes As New DataSet
    Dim tablaquery As New DataView
    Dim clientes As New DataTable
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        Dim principal As New principal
        principal.ShowDialog()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If RadioButton1.Checked = True Then

            cmd.Connection = conn
            cmd.CommandText = "INSERT INTO clientes(nombrecliente) VALUES('" & UCase(TextBox1.Text) & "')"
            cmd.ExecuteNonQuery()
            MsgBox("Cliente agregado correctamete", MsgBoxStyle.OkOnly, "Alta Clientes")

        ElseIf RadioButton2.Checked = True Then
            cmd.Connection = conn
            cmd.CommandText = "INSERT INTO clientes(nombrecliente) VALUES('" & UCase(TextBox1.Text) & "')"
            cmd.ExecuteNonQuery()
            MsgBox("Vendedor cueros agregado correctamente", MsgBoxStyle.OkOnly, "Alta Vend. Cueros")
        End If

        TextBox1.Text = ""

        dsclientes.Clear()
        dataprod.Fill(dsclientes, "clientes")

    End Sub

    Private Sub Clientes_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        RadioButton1.Checked = True

        lstcodigo.DataSource = dsclientes.Tables("clientes")
        lstcodigo.DisplayMember = "codigocliente"
        lstnombre.DataSource = dsclientes.Tables("clientes")
        lstnombre.DisplayMember = "nombrecliente"
    End Sub

    Private Sub Clientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conn.Open()
        dataprod.Fill(dsclientes, "clientes")

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        dataprod = New SqlCeDataAdapter("SELECT * FROM clientes", conn)
        dsclientes.Clear()
        dataprod.Fill(dsclientes, "clientes")
        TextBox1.Focus()
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        'dataprod = New SqlCeDataAdapter("SELECT * FROM clientes WHERE vend=1", conn)
        'dsclientes.Clear()
        'dataprod.Fill(dsclientes, "clientes")
        'TextBox1.Focus()
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
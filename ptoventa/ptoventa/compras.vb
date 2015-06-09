Imports System.Data.SqlClient
Imports System.Data.SqlServerCe
Imports System
Imports System.Text
Imports System.Threading
Imports System.Data
Imports System.IO.Ports


Public Class compras
    Dim DataString As New StringBuilder
    Dim cmd As New SqlCeCommand
    Dim cantinput, peso As Decimal
    Dim elementos, piezas, i As Integer
    Dim fila As Integer
    Dim conn As New SqlCeConnection("Data Source=\Program Files\ptoventa\ptoventa.sdf")
    Dim dataped As New SqlCeDataAdapter("SELECT * FROM cueros", conn)
    Dim dataclientes As New SqlCeDataAdapter("SELECT * FROM clientes WHERE vend=1", conn)

    Dim tcueros As New DataTable
    Dim tclientes As New DataTable

    Dim dscueros As New DataSet
    Dim dsclientes As New DataSet

    Dim tablaquery As New DataView
    Dim tablacclientes As New DataView

    Private Sub compras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        conn.Open()

        dataped.Fill(dscueros, "cueros")
        dataclientes.Fill(dsclientes, "clientes")
        tcueros = dscueros.Tables("cueros")
        tablaquery = tcueros.DefaultView

        tclientes = dsclientes.Tables("clientes")

        tablacclientes.Table = dsclientes.Tables("clientes")

        lstvend.DataSource = dscueros.Tables("cueros")
        lstvend.DisplayMember = "nombre"
        lstpzas.DataSource = dscueros.Tables("cueros")
        lstpzas.DisplayMember = "piezas"
        lstpeso.DataSource = dscueros.Tables("cueros")
        lstpeso.DisplayMember = "peso"
        lstfecha.DataSource = dscueros.Tables("cueros")
        lstfecha.DisplayMember = "fecha"

        tablaquery.Sort = "fecha ASC"

        ComboBox1.DataSource = tablacclientes
        ComboBox1.DisplayMember = "nombrecliente"

    End Sub

  

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        Dim principal As New principal
        principal.ShowDialog()
        Me.Close()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        TextBox1.Text = ComboBox1.Text
        TextBox3.Focus()
    End Sub

    Private Sub TextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown

        If e.KeyCode = Keys.Enter Then
            cmd.Connection = conn
            cmd.CommandText = "INSERT INTO cueros(nombre,piezas,peso,fecha) VALUES('" & TextBox1.Text & "','" & TextBox3.Text & "','" & TextBox2.Text & "','" & Date.Today & "')"
            cmd.ExecuteNonQuery()

            dscueros.Clear()
            dataped.Fill(dscueros, "cueros")
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox3.Focus()
        End If

      
    End Sub

    

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        DataString = New StringBuilder

        piezas = 0
        peso = 0

        For Me.i = 0 To (lstvend.Items.Count - 1)
            lstvend.SelectedIndex = Me.i
            piezas = piezas + Val(lstpzas.Text)
            peso = peso + Val(lstpeso.Text)
        Next Me.i

        Try
            If SP.IsOpen = False Then
                SP.Open()
            End If

            DataString.Append("! U1 SETLP 4 0 27" & vbCrLf)
            DataString.Append("! U1 XY 10 0" & vbCrLf)
            DataString.Append("*--REPORTE CUEROS--*" & vbCrLf)
            DataString.Append("! U1 XY 10 40" & vbCrLf)
            DataString.Append("" & Date.Today & "" & vbCrLf)

            DataString.Append("! U1 SETLP 5 0 20" & vbCrLf)
            DataString.Append("! U1 XY 10 100" & vbCrLf)
            DataString.Append("Nombre" & vbCrLf)
            DataString.Append("! U1 XY 240 100" & vbCrLf)
            DataString.Append("Piezas" & vbCrLf)
            DataString.Append("! U1 XY 340 100" & vbCrLf)
            DataString.Append("Peso" & vbCrLf)
            DataString.Append("! U1 XY 450 100" & vbCrLf)
            DataString.Append("Fecha" & vbCrLf)

            fila = 130

            For Me.elementos = 0 To (lstvend.Items.Count - 1)
                lstvend.SelectedIndex = elementos

                DataString.Append("! U1 XY 10 " & fila & "" & vbCrLf)
                DataString.Append("" & lstvend.Text & "" & vbCrLf)
                DataString.Append("! U1 XY 240 " & fila & "" & vbCrLf)
                DataString.Append("" & lstpzas.Text & "" & vbCrLf)
                DataString.Append("! U1 XY 340 " & fila & "" & vbCrLf)
                DataString.Append("" & lstpeso.Text & "" & vbCrLf)
                DataString.Append("! U1 XY 450 " & fila & "" & vbCrLf)
                DataString.Append("" & lstfecha.Text & "" & vbCrLf)
                fila = fila + 28
            Next Me.elementos

            fila = fila + 40

            DataString.Append("! U1 SETLP 4 0 27" & vbCrLf)
            DataString.Append("! U1 XY 10 " & fila & "" & vbCrLf)
            DataString.Append("Piezas: " & piezas & "   " & "Peso: " & peso & "" & " Kg." & vbCrLf)
            DataString.Append("! U1 SETLP 5 0 20" & vbCrLf)

            fila = fila + 70
            DataString.Append("! U1 XY 10 " & fila & "" & vbCrLf)
            DataString.Append("*--FIN REPORTE CUEROS--*")
            fila = fila + 20
            DataString.Append("! U1 XY 10 " & fila & "" & vbCrLf)
            DataString.Append(" ")

            SP.WriteLine(DataString.ToString())
            System.Threading.Thread.Sleep(2500)
            SP.Close()


        Catch ex As Exception
            MsgBox("Por favor encienda la impresora o acerquese", MsgBoxStyle.OkOnly, "Error")
        End Try

        piezas = 0
        peso = 0

    End Sub

    Private Sub TextBox3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox3.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox2.Focus()
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        piezas = 0
        peso = 0

        tablaquery.RowFilter = "fecha='" & DateTimePicker1.Value.ToShortDateString & "'"

        For Me.elementos = 0 To lstvend.Items.Count - 1
            lstvend.SelectedIndex = elementos
            piezas = piezas + Val(lstpzas.Text)
            peso = peso + Val(lstpeso.Text)
        Next Me.elementos
        lblpeso.Text = peso & " Kg."
        lblpiezas.Text = piezas

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        piezas = 0
        peso = 0
        tablaquery.RowFilter = Nothing

        For Me.elementos = 0 To lstvend.Items.Count - 1
            lstvend.SelectedIndex = elementos
            piezas = piezas + Val(lstpzas.Text)
            peso = peso + Val(lstpeso.Text)
        Next Me.elementos
        lblpeso.Text = peso & " Kg."
        lblpiezas.Text = piezas

    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MenuItem3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click

        If MsgBox("Deseas elimnar la venta seleccionada del vendedor '" & lstvend.Text & "' Y dia '" & lstfecha.Text & "' ?", MsgBoxStyle.OkCancel, "Modificacion") = MsgBoxResult.Ok Then
            cmd.Connection = conn
            cmd.CommandText = "DELETE FROM cueros WHERE nombre = '" & lstvend.Text & "' AND fecha = '" & lstfecha.Text & "'"
            cmd.ExecuteNonQuery()

            dscueros.Clear()
            dataped.Fill(dscueros, "cueros")
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox3.Focus()
        End If

    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click

        If MsgBox("Deseas elimnar la venta seleccionada del dia '" & DateTimePicker1.Value.ToShortDateString & "' ?", MsgBoxStyle.OkCancel, "Modificacion") = MsgBoxResult.Ok Then
            cmd.Connection = conn
            cmd.CommandText = "DELETE FROM cueros WHERE fecha = '" & DateTimePicker1.Value.ToShortDateString & "'"
            cmd.ExecuteNonQuery()

            dscueros.Clear()
            dataped.Fill(dscueros, "cueros")
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox3.Focus()
        End If
    End Sub

    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        If MsgBox("Deseas elimnar todas las ventas ?", MsgBoxStyle.OkCancel, "Modificacion") = MsgBoxResult.Ok Then
            cmd.Connection = conn
            cmd.CommandText = "DELETE FROM cueros"
            cmd.ExecuteNonQuery()

            dscueros.Clear()
            dataped.Fill(dscueros, "cueros")
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox3.Focus()
        End If
    End Sub
End Class
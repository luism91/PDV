Imports System.Data.SqlClient
Imports System.Data.SqlServerCe
Imports System
Imports System.Net.Sockets
Imports System.Data
Imports System.Text
Imports System.IO.Ports

Public Class corte
    Dim cmd As New SqlCeCommand
    Dim conn As New SqlCeConnection("Data Source=\Program Files\ptoventa\ptoventa.sdf")
    Dim dataprod As New SqlCeDataAdapter("SELECT * FROM ventas", conn)
    Dim dscorte As New DataSet
    Dim tventas As New DataTable
    Dim tablaquery As New DataView
    Dim fila, i As Integer
    Dim total As Decimal
    Dim currentDate As DateTime = DateTime.Now
    Dim dateString As String = "dd-MM-yyyy"
    Dim DataString As StringBuilder

 

    Private Sub corte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ClientesTableAdapter1.Fill(Me.PtoventaDataSet.clientes)
        conn.Open()
        dataprod.Fill(dscorte, "ventas")
        tventas = dscorte.Tables("ventas")
        tablaquery = tventas.DefaultView

        lstfecha.DataSource = dscorte.Tables("ventas")
        lstfecha.DisplayMember = "fechaventa"
        lstnombrec.DataSource = dscorte.Tables("ventas")
        lstnombrec.DisplayMember = "nombrecliente"
        lstimporte.DataSource = dscorte.Tables("ventas")
        lstimporte.DisplayMember = "importetotal"

    End Sub
    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        total = 0
        lbltotal.Text = Nothing

        If RadioButton1.Checked = True Then
            tablaquery.RowFilter = "fechaventa='" & DateTimePicker1.Value.ToShortDateString & "'"
        ElseIf RadioButton2.Checked = True Then
            tablaquery.RowFilter = "codigocliente = '" & ComboBox1.SelectedIndex + 1 & "'"
        ElseIf RadioButton3.Checked = True Then
            tablaquery.RowFilter = "codigocliente = '" & ComboBox1.SelectedIndex + 1 & "'  AND fechaventa='" & DateTimePicker1.Value.ToShortDateString & "'"
        End If

        For Me.i = 0 To (lstimporte.Items.Count - 1)
            lstimporte.SelectedIndex = Me.i
            total = (total) + (Val(lstimporte.Text))
        Next Me.i

        lbltotal.Text = "$" & total


    End Sub

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        DataString = New StringBuilder

        total = 0
        For Me.i = 0 To (lstimporte.Items.Count - 1)
            lstimporte.SelectedIndex = Me.i
            total = (total) + (Val(lstimporte.Text))
        Next Me.i

        Try
            If SP.IsOpen = False Then
                SP.Open()
            End If

            DataString.Append("! U1 SETLP 4 0 27" & vbCrLf)
            DataString.Append("! U1 XY 10 0" & vbCrLf)
            DataString.Append("*--REPORTE DE VENTAS--*" & vbCrLf)
            DataString.Append("! U1 XY 10 40" & vbCrLf)
            DataString.Append("" & Date.Today & "" & vbCrLf)

            DataString.Append("! U1 SETLP 5 0 20" & vbCrLf)
            DataString.Append("! U1 XY 10 100" & vbCrLf)
            DataString.Append("Nombre" & vbCrLf)
            DataString.Append("! U1 XY 260 100" & vbCrLf)
            DataString.Append("Importe" & vbCrLf)
            DataString.Append("! U1 XY 380 100" & vbCrLf)
            DataString.Append("Fecha" & vbCrLf)

            fila = 130

            For elementos = 0 To (lstnombrec.Items.Count - 1)
                lstnombrec.SelectedIndex = elementos
                lstimporte.SelectedIndex = elementos
                lstfecha.SelectedIndex = elementos

                DataString.Append("! U1 XY 10 " & fila & "" & vbCrLf)
                DataString.Append("" & lstnombrec.Text & "" & vbCrLf)
                DataString.Append("! U1 XY 260 " & fila & "" & vbCrLf)
                DataString.Append("" & lstimporte.Text & "" & vbCrLf)
                DataString.Append("! U1 XY 380 " & fila & "" & vbCrLf)
                DataString.Append("" & lstfecha.Text & "" & vbCrLf)

                fila = fila + 28
            Next elementos

            fila = fila + 40


            DataString.Append("! U1 SETLP 4 0 27" & vbCrLf)
            DataString.Append("! U1 XY 10 " & fila & "" & vbCrLf)
            DataString.Append(" Total: " & "$" & (Format(CDec(total), ".00")) & "" & vbCrLf)
            DataString.Append("! U1 SETLP 5 0 20" & vbCrLf)
            fila = fila + 70
            DataString.Append("! U1 XY 10 " & fila & "" & vbCrLf)
            DataString.Append("*--FIN REPORTE DE VENTAS--*")
            fila = fila + 20
            DataString.Append("! U1 XY 10 " & fila & "" & vbCrLf)
            DataString.Append(" ")

            SP.WriteLine(DataString.ToString())
            System.Threading.Thread.Sleep(2500)
            SP.Close()


        Catch ex As Exception
            MsgBox("Por favor encienda la impresora o acerquese", MsgBoxStyle.OkOnly, "Error")
        End Try


        total = 0

    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Dim principal As New principal
        principal.ShowDialog()
        Me.Close()
    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click

        If MsgBox("Deseas liquidar la venta seleccionada del cliente '" & ComboBox1.Text & "' Y dia '" & lstfecha.Text & "' ?", MsgBoxStyle.OkCancel, "Modificacion") = MsgBoxResult.Ok Then
            cmd.Connection = conn
            cmd.CommandText = "DELETE FROM ventas WHERE nombrecliente = '" & ComboBox1.Text & "' AND  fechaventa = '" & lstfecha.Text & "'"
            cmd.ExecuteNonQuery()
        End If
        dscorte.Clear()
        dataprod.Fill(dscorte, "ventas")
        lbltotal.Text = Nothing

    End Sub

    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        If MsgBox("Deseas liquidar la venta del dia '" & DateTimePicker1.Value.ToShortDateString & "' ?", MsgBoxStyle.OkCancel, "Modificacion") = MsgBoxResult.Ok Then
            cmd.Connection = conn
            cmd.CommandText = "DELETE FROM ventas WHERE fechaventa = '" & DateTimePicker1.Value.ToShortDateString & "'"
            cmd.ExecuteNonQuery()
        End If
        dscorte.Clear()
        dataprod.Fill(dscorte, "ventas")
        lbltotal.Text = Nothing
    End Sub


End Class
Imports System.Data.SqlClient
Imports System.Data.SqlServerCe
Imports System
Imports System.Net.Sockets
Imports System.Data
Imports System.Text
Imports System.IO.Ports
Public Class corte
    Dim fila, i, elementos, rowview, rowliq, dialista, meslista, aniolista As Integer
    Dim total As Decimal
    Dim currentDate As DateTime = DateTime.Now
    Dim dateString As String = "dd-MM-yyyy"
    Dim DataString As StringBuilder
    Private Sub corte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        total = 0
        lbltotal.Text = Nothing

        If RadioButton1.Checked = True Then

            dia = DateTimePicker1.Value.Day
            mes = DateTimePicker1.Value.Month
            anio = DateTimePicker1.Value.Year
            dia1 = DateTimePicker2.Value.Day
            mes1 = DateTimePicker2.Value.Month
            anio1 = DateTimePicker2.Value.Year

            lstnombrec.Items.Clear()
            lstfecha.Items.Clear()
            lstimporte.Items.Clear()
            lstcodventa.Items.Clear()
            poblartablas(1, 1)
            If dscorte.Tables("corte").Rows.Count = 0 Then
                MsgBox("No hay ventas cerradas con los parametros de fechas!", MsgBoxStyle.OkOnly, "Ventas")
            Else
                For Me.rowview = 0 To dscorte.Tables("corte").Rows.Count - 1
                    lstcodventa.Items.Add(dscorte.Tables("corte").Rows(rowview)("codigoventa").ToString)
                    lstnombrec.Items.Add(dscorte.Tables("corte").Rows(rowview)("nombrecliente").ToString)
                    dialista = dscorte.Tables("corte").Rows(rowview)("dia")
                    meslista = dscorte.Tables("corte").Rows(rowview)("mes")
                    aniolista = dscorte.Tables("corte").Rows(rowview)("anio")
                    Dim fechalista As String = dialista & "/" & meslista & "/" & aniolista
                    lstfecha.Items.Add(fechalista)
                    lstimporte.Items.Add(Format(CDec(dscorte.Tables("corte").Rows(rowview)("importe")), ".00"))
                Next Me.rowview
            End If
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

            DataString.Append("! U1 SETLP 7 3 27" & vbCrLf)
            DataString.Append("! U1 XY 10 0" & vbCrLf)
            DataString.Append("*--REPORTE DE VENTAS--*" & vbCrLf)
            DataString.Append("! U1 XY 10 40" & vbCrLf)
            DataString.Append("" & Date.Today & "" & vbCrLf)
            DataString.Append("! U1 SETLP 7 0 20" & vbCrLf)
            DataString.Append("! U1 XY 10 100" & vbCrLf)
            DataString.Append("Cod." & vbCrLf)
            DataString.Append("! U1 XY 70 100" & vbCrLf)
            DataString.Append("Nombre" & vbCrLf)
            DataString.Append("! U1 XY 340 100" & vbCrLf)
            DataString.Append("Importe" & vbCrLf)
            DataString.Append("! U1 XY 460 100" & vbCrLf)
            DataString.Append("Fecha" & vbCrLf)
            fila = 130

            For Me.elementos = 0 To (lstnombrec.Items.Count - 1)
                lstnombrec.SelectedIndex = elementos
                lstimporte.SelectedIndex = elementos
                lstfecha.SelectedIndex = elementos
                lstcodventa.SelectedIndex = elementos
                DataString.Append("! U1 XY 10 " & fila & "" & vbCrLf)
                DataString.Append("" & lstcodventa.Text & "" & vbCrLf)
                DataString.Append("! U1 XY 70 " & fila & "" & vbCrLf)
                DataString.Append("" & lstnombrec.Text & "" & vbCrLf)
                DataString.Append("! U1 XY 340 " & fila & "" & vbCrLf)
                DataString.Append("" & lstimporte.Text & "" & vbCrLf)
                DataString.Append("! U1 XY 460 " & fila & "" & vbCrLf)
                DataString.Append("" & lstfecha.Text & "" & vbCrLf)
                fila = fila + 28
            Next Me.elementos

            fila = fila + 40
            DataString.Append("! U1 SETLP 7 4 27" & vbCrLf)
            DataString.Append("! U1 XY 10 " & fila & "" & vbCrLf)
            DataString.Append(" Total: " & "$" & (Format(CDec(total), ".00")) & "" & vbCrLf)
            DataString.Append("! U1 SETLP 7 4 27" & vbCrLf)
            fila = fila + 100
            DataString.Append("! U1 XY 10 " & fila & "" & vbCrLf)
            DataString.Append("*--FIN REPORTE DE VENTAS--*")
            fila = fila + 50
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

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click

        If MsgBox("Deseas liquidar las ventas en la lista?", MsgBoxStyle.Information + MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            Try
                For Me.rowliq = 0 To (lstcodventa.Items.Count - 1)
                    lstcodventa.SelectedIndex = rowliq
                    cmd.Connection = conn
                    cmd.CommandText = "DELETE FROM ventas WHERE codigoventa= '" & lstcodventa.Text & "'"
                    cmd.ExecuteNonQuery()
                    lbltotal.Text = Nothing
                Next Me.rowliq
                lstnombrec.Items.Clear()
                lstfecha.Items.Clear()
                lstimporte.Items.Clear()
                lstcodventa.Items.Clear()
                poblartablas(1, 1)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
            End Try
        End If
        total = 0
    End Sub
    Private Sub lstcodventa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstcodventa.SelectedIndexChanged
        lstnombrec.SelectedIndex = lstcodventa.SelectedIndex
        lstfecha.SelectedIndex = lstcodventa.SelectedIndex
        lstimporte.SelectedIndex = lstcodventa.SelectedIndex
    End Sub
    Private Sub lstnombrec_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstnombrec.SelectedIndexChanged
        lstcodventa.SelectedIndex = lstnombrec.SelectedIndex
        lstfecha.SelectedIndex = lstnombrec.SelectedIndex
        lstimporte.SelectedIndex = lstnombrec.SelectedIndex
    End Sub
    Private Sub lstfecha_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstfecha.SelectedIndexChanged
        lstcodventa.SelectedIndex = lstfecha.SelectedIndex
        lstnombrec.SelectedIndex = lstfecha.SelectedIndex
        lstimporte.SelectedIndex = lstfecha.SelectedIndex
    End Sub
    Private Sub lstimporte_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstimporte.SelectedIndexChanged
        lstcodventa.SelectedIndex = lstimporte.SelectedIndex
        lstnombrec.SelectedIndex = lstimporte.SelectedIndex
        lstfecha.SelectedIndex = lstimporte.SelectedIndex
    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Dim principal As New principal
        principal.ShowDialog()
        Me.Close()
    End Sub
End Class
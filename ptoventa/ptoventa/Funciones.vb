Imports System.Data.SqlClient
Imports System.Data.SqlServerCe
Imports System
Imports System.Text
Imports System.IO.Ports
Imports System.Threading
Imports System.Data
Imports System.IO

Module Funciones
    
    Public fila, mover, generarnota, codventa, indice, cvCargarNota, i, elementos, optcorte, dia, mes, anio, dia1, mes1, anio1, ccliente As Integer
    Public desc, uni, codigo, fecharespaldo As String
    Public importe, precio, cantinput, cantcargar, preimporte, total As Decimal
    Public cantidad As Double
    Public tabladetallesnotas, tablaproductosnota, tablacargas, tablaquery, tablaclientes As New DataView
    Public cmd As New SqlCeCommand
    'Codigo para cargar productos y agregar notas nuevas
    Public conn As New SqlCeConnection("Data Source=\Program Files\ptoventa\ptoventa.sdf")
    Public dataprod As New SqlCeDataAdapter("SELECT * FROM productos ORDER BY codigo ASC", conn)
    Public datapedi As New SqlCeDataAdapter("SELECT * FROM ventas", conn)
    Public dataCargarClientes As New SqlCeDataAdapter("SELECT * FROM clientes ORDER BY codigocliente ASC", conn)
    Public dsped, dscorte, dsprod, dsclientes, dsdetalleNota As New DataSet
    Public mov As Integer = 0
    Public conteo As Integer = 1
    Public log(0) As String


    Public Sub poblartablas(ByVal opt As Integer, ByVal optcorte As Integer)
        If opt = 0 Then
            Try
                dsped.Clear()
                datapedi.Fill(dsped, "ventas")
                tablacargas.Table = dsped.Tables("ventas")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Error")
            End Try
        ElseIf opt = 1 Then
            'Codigo para cargar notas existentes
            If optcorte = 1 Then
                Dim dataCargarVentas As New SqlCeDataAdapter("SELECT c.[codigocliente],c.[nombrecliente],v.[codigoventa],v.[dia]" & _
                  ",v.[mes],v.[anio],v.[importe] FROM clientes AS c " & _
                 "INNER JOIN [ventas] AS v ON c.[codigocliente] = v.[codigocliente] " & _
                 "WHERE v.[dia]>= '" & dia & "' AND v.[dia]<='" & dia1 & "' " & _
                 "AND v.[mes]>= '" & mes & "' AND v.[mes]<='" & mes1 & "' " & _
                 "AND v.[anio]>= '" & anio & "' AND v.[anio]<='" & anio1 & "' " & _
                "AND v.[venta_finalizada]=  1" & _
                 "ORDER BY v.[codigoventa]", conn)
                dscorte.Clear()
                dataCargarVentas.Fill(dscorte, "corte")

            End If
        ElseIf opt = 2 Then
            Try
                Dim dataCargarDetalleNota As New SqlCeDataAdapter("SELECT p.[descripcion],p.[precio],d.[codigo],d.[codigoventa],d.[cantidad] FROM productos AS P " & _
               "INNER JOIN [detalle_ventas] AS d ON p.[codigo] = d.[codigo] " & _
               "WHERE d.[codigoventa]='" & cvCargarNota & "' ", conn)
                dsdetalleNota.Clear()
                dataCargarDetalleNota.Fill(dsdetalleNota, "informacionticket")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
            End Try
        ElseIf opt = 3 Then
            Try
                dsprod.Clear()
                dataprod.Fill(dsprod, "productos2")
                tablaquery.Table = dsprod.Tables("productos2")
                tablaquery.Sort = "codigo ASC"
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Error")
            End Try
        ElseIf opt = 4 Then
            Try
                dsclientes.Clear()
                dataCargarClientes.Fill(dsclientes, "clientes")
                tablaclientes.Table = dsclientes.Tables("clientes")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    Public Sub generarrespaldo()

        fecharespaldo = Date.Today.Day.ToString & Date.Today.Month.ToString & Date.Today.Year.ToString & Date.Today.Millisecond
        Try
            File.Copy("\Program Files\ptoventa\ptoventa.sdf", "\Storage Card\ptoventa-" & fecharespaldo & ".sdf", True)
            MsgBox("Respaldo de base de datos generado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Respaldos")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Respaldos")
        End Try

    End Sub

End Module

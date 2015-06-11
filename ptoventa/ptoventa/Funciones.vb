Imports System.Data.SqlClient
Imports System.Data.SqlServerCe
Imports System
Imports System.Text
Imports System.IO.Ports
Imports System.Threading
Imports System.Data


Module Funciones


    Public fila, mover, generarnota, codventa, indice, cvCargarNota, i, elementos As Integer
    Public desc, uni, codigo As String
    Public importe, precio, cantinput, cantcargar, preimporte, total As Decimal
    Public cantidad As Double
    Public tabladetallesnotas, tablaproductosnota, tablacargas, tablaquery As New DataView
    Public cmd As New SqlCeCommand
    'Codigo para cargar productos y agregar notas nuevas
    Public conn As New SqlCeConnection("Data Source=\Program Files\ptoventa\ptoventa.sdf")
    Public dataprod As New SqlCeDataAdapter("SELECT * FROM productos ORDER BY codigo ASC", conn)
    Public datapedi As New SqlCeDataAdapter("SELECT * FROM ventas", conn)
    Public dataCargarProductosNota As New SqlCeDataAdapter("SELECT * FROM productos", conn)

    Public dsprod As New DataSet
    Public dsped As New DataSet
    Public dsdetalleNota As New DataSet
    'Codigo para cargar notas existentes

    Public Sub poblartablas(ByVal opt As Integer)

        If opt = 0 Then
            dsprod.Clear()
            dsped.Clear()
            dataprod.Fill(dsprod, "productos2")
            datapedi.Fill(dsped, "ventas")
            tablaquery.Table = dsprod.Tables("productos2")
            tablacargas.Table = dsped.Tables("ventas")
        Else
            Try
                Dim dataCargarDetalleNota As New SqlCeDataAdapter("SELECT p.[descripcion],p.[precio],d.[codigo],d.[codigoventa],d.[cantidad] FROM productos AS P " & _
               "INNER JOIN [detalle_ventas] AS d ON p.[codigo] = d.[codigo] " & _
               "WHERE d.[codigoventa]='" & cvCargarNota & "' " & _
               "ORDER BY p.[codigo]", conn)
                dsdetalleNota.Clear()
                dataCargarDetalleNota.Fill(dsdetalleNota, "informacionticket")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
            End Try
        End If

    End Sub

  

End Module

Imports System.Data.SqlClient
Imports System.Data.SqlServerCe
Imports System
Imports System.Text
Imports System.IO.Ports
Imports System.Threading
Imports System.Data

Module Funciones
    Public fila, mover, generarnota, codventa, indice As Integer
    Public desc, uni, codigo As String
    Public importe, cantidad, precio, cantinput, cantcargar, preimporte As Decimal
    Public cmd As New SqlCeCommand
    Public conn As New SqlCeConnection("Data Source=\Program Files\ptoventa\ptoventa.sdf")
    Public dataprod As New SqlCeDataAdapter("SELECT * FROM productos ORDER BY codigo ASC", conn)
    Public datapedi As New SqlCeDataAdapter("SELECT * FROM ventas", conn)
    Public dsprod As New DataSet
    Public dsped As New DataSet

    Public Sub poblartablas()
        dataprod.Fill(dsprod, "productos")
        datapedi.Fill(dsped, "ventas")
    End Sub

End Module

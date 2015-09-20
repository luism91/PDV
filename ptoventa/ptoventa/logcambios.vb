Public Class logcambios
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click

        modifproductos.Show()
        Me.Close()
    End Sub

    Private Sub logcambios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        For i = 0 To log.GetUpperBound(0) - 1
            ListBox1.Items.Add(log(i))
        Next
    End Sub
End Class
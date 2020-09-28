Public Class FrmFacturasVentas

    Private Sub FrmFacturasVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = frmBase.Icon
        grd.ColumnCount = 4
        grd.Columns(0).HeaderText = "Orden"
        grd.Columns(1).HeaderText = "Cod. Artículo"
        grd.Columns(2).HeaderText = "Descripción"
        grd.Columns(3).HeaderText = "Cantidad"
        grd.AutoResizeColumns()
    End Sub

    Private Sub grd_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd.CellContentClick

    End Sub
End Class
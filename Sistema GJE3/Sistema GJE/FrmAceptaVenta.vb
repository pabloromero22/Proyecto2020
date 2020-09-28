Imports MySql.Data.MySqlClient

Public Class FrmAceptaVenta

    Private Sub FrmAceptaVenta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Icon = frmBase.Icon
        grd.ColumnCount = 4
        grd.Columns(0).HeaderText = "Orden"
        grd.Columns(1).HeaderText = "Cod. Artículo"
        grd.Columns(2).HeaderText = "Descripción"
        grd.Columns(3).HeaderText = "Cantidad"
        grd.AutoResizeColumns()
        Tomadata()
    End Sub

    Sub Tomadata()
        Dim id As Integer
        Dim cn As New MySqlConnection
        Dim cm As New MySqlCommand
        Dim dr As MySqlDataReader
        Dim mnull As DBNull = DBNull.Value
        cn.ConnectionString = (constConexion)
        cm.CommandType = CommandType.Text
        cm.CommandText = "SELECT MIN(id_orden) as min FROM Notapedidoenca"
        cm.Connection = cn
        cn.Open()
        dr = cm.ExecuteReader()
        dr.Read()
        If (mnull.Equals(dr("MIN"))) Then
            id = 0
        Else
            id = dr("MIN")
        End If
        id = id + 1
        'cn.Close()
        dr.Close()
        TextBox1.Text = id
        cn.Close()
        If grd.RowCount >= 1 Then
            For i As Integer = 0 To grd.RowCount - 2
                grd.Rows.Remove(grd.CurrentRow)
            Next
        End If
    End Sub
End Class
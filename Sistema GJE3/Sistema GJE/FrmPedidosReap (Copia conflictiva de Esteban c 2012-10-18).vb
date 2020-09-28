Imports MySql.Data.MySqlClient

Public Class FrmPedidosReap
    Private Sub FrmPedidosReap_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Tomadata()
        grd.ColumnCount = 3
        grd.Columns(0).HeaderText = "Cod. Articulo"
        grd.Columns(1).HeaderText = "Descripcion"
        grd.Columns(2).HeaderText = "Cantidad"
        grd.AutoResizeColumns()
    End Sub

    Sub Tomadata()
        Dim cn As New MySqlConnection
        Dim cm As New MySqlCommand
        Dim dr As MySqlDataReader
        cn.ConnectionString = (constConexion)
        cm.CommandType = CommandType.Text
        cm.CommandText = "SELECT descripcion FROM Articulos"
        cm.Connection = cn
        cn.Open()
        dr = cm.ExecuteReader()
        While dr.Read()
            cbo.Items.Add(dr("descripcion"))
        End While
        cn.Close()
    End Sub

    Private Sub cmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd.Click
        Dim id As Integer
        Dim cn As New MySqlConnection
        Dim cm As New MySqlCommand
        Dim dr As MySqlDataReader
        Dim mnull As DBNull = DBNull.Value
        cn.ConnectionString = (constConexion)
        cm.CommandType = CommandType.Text
        cm.CommandText = "SELECT MAX(id_pedido) as max FROM PedidoCotizacionEnca"
        cm.Connection = cn
        cn.Open()
        dr = cm.ExecuteReader()
        dr.Read()
        If (mnull.Equals(dr("max"))) Then
            id = 0
        Else
            id = dr("max")
        End If
        id = id + 1
        'cn.Close()
        dr.Close()
        lbl3.Text = "Num. de pedido: " & id
        cbo.Enabled = True
        txt.Enabled = True
        cn.Close()
        If grd.RowCount >= 1 Then
            For i As Integer = 0 To grd.RowCount - 2
                grd.Rows.Remove(grd.CurrentRow)
            Next
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd1.Click
        Dim id As Integer, i As Integer
        Dim cn As New MySqlConnection
        Dim cm As New MySqlCommand
        Dim dr As MySqlDataReader
        Dim mnull As DBNull = DBNull.Value
        cn.ConnectionString = (constConexion)
        cm.CommandType = CommandType.Text
        cm.CommandText = "SELECT id_arti FROM Articulos WHERE descripcion= '" & cbo.SelectedItem & "'"
        cm.Connection = cn
        cn.Open()
        dr = cm.ExecuteReader()
        dr.Read()
        id = dr("id_arti")
        For i = 0 To grd.Rows.Count - 1 ' si carga 2 veces el mismo arituculo no lo deja
            If id = grd.Item(0, i).Value Then
                MsgBox("El artículo ya se encuentra cargado", MsgBoxStyle.Information, "Imposible realizar")
                Exit Sub
            End If
        Next
        grd.Rows.Add(id, cbo.SelectedItem, txt.Text)
        grd.AutoResizeColumns()
    End Sub

    Private Sub cmd4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd4.Click
        If grd.SelectedCells.Count > 0 Then
            Me.grd.Rows.Remove(Me.grd.CurrentRow)
        End If
    End Sub
End Class
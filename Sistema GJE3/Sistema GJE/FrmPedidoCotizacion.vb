Imports MySql.Data.MySqlClient

Public Class FrmPedidoCotizacion

    Private Sub FrmPedidoCotizacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
        cn.ConnectionString = (constConexion)
        cm.CommandType = CommandType.Text
        cm.CommandText = "SELECT razonsocial FROM Proveedores"
        cm.Connection = cn
        cn.Open()
        dr = cm.ExecuteReader()
        While dr.Read()
            cbo1.Items.Add(dr("razonsocial"))
        End While
        cn.Close()
        Dim id As Integer
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
        TextBox1.Text = id
        cn.Close()
        If grd.RowCount >= 1 Then
            For i As Integer = 0 To grd.RowCount - 2
                grd.Rows.Remove(grd.CurrentRow)
            Next
        End If
    End Sub

    Private Sub cmd1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd1.Click
        Dim id As Integer, i As Integer
        Dim cn As New MySqlConnection
        Dim cm As New MySqlCommand
        Dim dr As MySqlDataReader
        Dim mnull As DBNull = DBNull.Value
        If txt2.Text = "" Then
            MsgBox("Ingrese una cantidad ", MsgBoxStyle.Information, "Imposible realizar")
            Exit Sub
        End If
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
        grd.Rows.Add(grd.Rows.Count, id, cbo.SelectedItem, txt2.Text)
        grd.AutoResizeColumns()
    End Sub

    Private Sub cmd4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd4.Click
        If grd.SelectedCells.Count > 0 Then
            Me.grd.Rows.Remove(Me.grd.CurrentRow)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub
End Class
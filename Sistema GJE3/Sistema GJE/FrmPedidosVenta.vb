Imports MySql.Data.MySqlClient
Imports System.Transactions.TransactionScope

Public Class FrmPedidosVenta
    Dim pedido As Integer

    Private Sub FrmPedidosReap_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        grd.ColumnCount = 4
        grd.Columns(0).HeaderText = "Cod. Articulo"
        grd.Columns(1).HeaderText = "Descripcion"
        grd.Columns(2).HeaderText = "Cantidad"
        grd.Columns(3).HeaderText = "Disponible"


        grd.AutoResizeColumns()
        Tomadata()
        Nuevo()
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
        cm.CommandText = "SELECT razonsocial FROM Clientes"
        cm.Connection = cn
        cn.Open()
        dr = cm.ExecuteReader()
        While dr.Read()
            cbo1.Items.Add(dr("razonsocial"))
        End While
        cn.Close()
        cbo2.Items.Add("EFECTIVO")
        cbo2.Items.Add("CHEQUE")
    End Sub

    Private Sub Nuevo()
        Dim id As Integer
        Dim cn As New MySqlConnection
        Dim cm As New MySqlCommand
        Dim dr As MySqlDataReader
        Dim mnull As DBNull = DBNull.Value
        cn.ConnectionString = (constConexion)
        cm.CommandType = CommandType.Text
        cm.CommandText = "SELECT MAX(id_pedido) as max FROM NotapedidoEnca"
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
        pedido = id
        dr.Close()
        lbl3.Text = "Num. de pedido: " & id
        cbo.Enabled = True
        CantidadTxt.Enabled = True
        cbo1.Enabled = True
        cbo2.Enabled = True
        cn.Close()
        If grd.RowCount >= 1 Then
            For i As Integer = 0 To grd.RowCount - 2
                grd.Rows.RemoveAt(0)
            Next
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd1.Click
        Dim id As Integer, i As Integer, st As Integer
        Dim cn As New MySqlConnection
        Dim cm As New MySqlCommand
        Dim dr As MySqlDataReader
        Dim mnull As DBNull = DBNull.Value
        If cbo1.SelectedItem = "" Then
            MessageBox.Show("Debe seleccionar un cliente", "Operación imposible")
            Exit Sub
        End If
        If cbo2.SelectedItem = "" Then
            MessageBox.Show("Debe seleccionar una forma de pago", "Operación imposible")
            Exit Sub
        End If
        If cbo.SelectedItem = "" Then
            MessageBox.Show("Debe seleccionar un articulo", "Operación imposible")
            Exit Sub
        End If
        If CantidadTxt.Text = "" Then
            MessageBox.Show("Debe seleccionar una cantidad", "Operación imposible")
            Exit Sub
        End If
        cbo2.Enabled = False
        cbo1.Enabled = False
        cn.ConnectionString = (constConexion)
        cm.CommandType = CommandType.Text
        cm.CommandText = "SELECT id_arti, descripcion,sum(stock-reservado) as total FROM Articulos WHERE descripcion= '" & cbo.SelectedItem & "'"
        cm.Connection = cn
        cn.Open()
        dr = cm.ExecuteReader()
        dr.Read()
        id = dr("id_arti")
        st = dr("total")
        If st < CantidadTxt.Text Then
            MessageBox.Show("El artículo seleccionado no posee stock suficiente, stock: " & st, "Imposible realizar")
            Exit Sub
        End If
        For i = 0 To grd.Rows.Count - 1 ' si carga 2 veces el mismo arituculo no lo deja
            If id = grd.Item(0, i).Value Then
                If grd.Item(2, i).Value + grd.Item(3, i).Value < CantidadTxt.Text Then
                    MessageBox.Show("El artículo seleccionado no posee stock suficiente, stock: " & st, "Imposible realizar")
                    Exit Sub
                End If
                grd.Item(3, i).Value = (grd.Item(2, i).Value + grd.Item(3, i).Value)
                grd.Item(2, i).Value = CDbl(CantidadTxt.Text)
                grd.Item(3, i).Value = grd.Item(3, i).Value - grd.Item(2, i).Value
                grd.AutoResizeColumns()
                Exit Sub
            End If
        Next
        st = st - CantidadTxt.Text
        grd.Rows.Add(id, cbo.SelectedItem, CantidadTxt.Text, st)
        grd.AutoResizeColumns()
    End Sub

    Private Sub cmd4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd4.Click
        If grd.SelectedCells.Count > 0 Then
            If Me.grd.CurrentRow.Index + 1 < grd.RowCount Then
                Me.grd.Rows.Remove(Me.grd.CurrentRow)
            End If
        End If
    End Sub

    Private Sub cmd3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd3.Click
        Dim tr As New Transactions.TransactionScope
        Dim id As Integer, idcliente As Integer
        Dim cn As New MySqlConnection
        Dim cm As New MySqlCommand
        Dim dr As MySqlDataReader
        Dim res As Integer
        Dim mNull As DBNull = DBNull.Value
        If cbo1.SelectedItem = "" Then
            MessageBox.Show("Debe seleccionar un cliente", "Operación imposible")
            Exit Sub
        End If
        Using tr
            Try
                cn.ConnectionString = (constConexion)
                cm.CommandType = CommandType.Text
                cm.CommandText = "SELECT id_cliente FROM Clientes where razonsocial='" & cbo1.SelectedItem & "'"
                cm.Connection = cn
                cn.Open()
                dr = cm.ExecuteReader()
                dr.Read()
                id = pedido
                idcliente = dr("ID_CLIENTE")
                dr.Close()
                cm.CommandType = CommandType.Text
                cm.CommandText = "INSERT INTO NotapedidoEnca values (" & id & ",'" & Now.ToString("yyyy/MM/dd") & "'," & idcliente & ",'" & cbo2.SelectedItem & "','INACTIVO')"
                cm.ExecuteNonQuery()
                For i = 0 To grd.RowCount - 2
                    cm.CommandText = "INSERT INTO NotapedidoItem values (" & id & "," & grd.Item(0, i).Value & "," & grd.Item(3, i).Value & ")"
                    cm.ExecuteNonQuery()
                    cm.CommandType = CommandType.Text
                    cm.CommandText = "SELECT sum(reservado) as total FROM Articulos WHERE id_arti= " & grd.Item(0, i).Value
                    cm.Connection = cn
                    dr = cm.ExecuteReader()
                    dr.Read()
                    res = dr("total")
                    dr.Close()
                    cm.CommandType = CommandType.Text
                    cm.CommandText = "UPDATE Articulos set reservado= " & res + grd.Item(2, i).Value & " WHERE id_Arti=" & grd.Item(0, i).Value
                    cm.ExecuteNonQuery()
                Next i
                tr.Complete()
                MessageBox.Show("Operación exitosa", "Mensaje del sistema")
            Catch
                MessageBox.Show("Ocurrio un error en la operación", "Mensaje del sistema")
                tr.Dispose()
                cn.Close()
            End Try
        End Using
        Nuevo()
    End Sub

    Private Sub CantidadTxt_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles CantidadTxt.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class
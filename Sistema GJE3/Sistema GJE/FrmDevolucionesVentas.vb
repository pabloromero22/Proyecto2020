Imports MySql.Data.MySqlClient
Public Class FrmDevolucionesVentas

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Tomadata() ' carga tabla
    End Sub
    Sub Tomadata()
        Dim cn As New MySqlConnection
        Dim cm As New MySqlCommand
        Dim dr As MySqlDataReader
        Dim dt As New DataTable
        Me.Icon = frmBase.Icon
        cn.ConnectionString = (constConexion)
        cm.CommandType = CommandType.Text
        cm.CommandText = "SELECT id_pedido,articulo, cantidad from DevolucionesVenta"
        cm.Connection = cn
        cn.Open()
        dr = cm.ExecuteReader()
        dt.Load(dr)
        cn.Close()
        dr.Close()
        grd.DataSource = dt
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim idPro As Integer
        Dim cn As New MySqlConnection
        Dim cm As New MySqlCommand
        idPro = grd.Item(0, grd.CurrentRow.Index()).Value.ToString
        cn.ConnectionString = (constConexion)
        cm.Connection = cn
        cn.Open()
        cm.CommandType = CommandType.Text
        cm.CommandText = "DELETE FROM Clientes WHERE id_cliente=" & idPro
        cm.ExecuteNonQuery()
        cn.Close()
        Tomadata()
    End Sub

End Class

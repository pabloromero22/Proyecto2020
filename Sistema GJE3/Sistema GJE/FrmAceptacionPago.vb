Imports MySql.Data.MySqlClient
Public Class FrmAceptacionPago

    Private Sub FrmAceptacionPago_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim cn As New MySqlConnection
        Dim cm As New MySqlCommand
        Dim dr As MySqlDataReader
        Me.Icon = frmBase.Icon
        cn.ConnectionString = (constConexion)
        cm.CommandType = CommandType.Text
        cm.CommandText = "SELECT razonsocial FROM Proveedores"
        cm.Connection = cn
        cn.Open()
        dr = cm.ExecuteReader()
        While dr.Read()
            '  cbo1.Items.Add(dr("razonsocial"))
        End While
        cn.Close()
        Dim id As Integer
        Dim mnull As DBNull = DBNull.Value
        cn.ConnectionString = (constConexion)
        cm.CommandType = CommandType.Text
        cm.CommandText = "SELECT MIN(id_ordenpago) as MIN FROM OrdenPago"
        cm.Connection = cn
        cn.Open()
        dr = cm.ExecuteReader()
        dr.Read()
        If (mnull.Equals(dr("min"))) Then
            id = 0
        Else
            id = dr("min")
        End If
        id = id + 1
        'cn.Close()
        dr.Close()
        'TextBox1.Text = id
        cn.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub
End Class
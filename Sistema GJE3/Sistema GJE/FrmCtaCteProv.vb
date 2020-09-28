Imports MySql.Data.MySqlClient
Public Class FrmCtaCteProv

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            cbo1.Items.Add(dr("razonsocial"))
        End While
        cn.Close()
    End Sub

    Sub Tomadata()
        Dim cn As New MySqlConnection
        Dim cm As New MySqlCommand
        Dim dr As MySqlDataReader
        Dim dt As New DataTable
        Dim sql As String
        cn.ConnectionString = (constConexion)
        cm.CommandType = CommandType.Text
        sql = "SELECT id_movimiento as Movimiento,b.descripcion as Tipo_Documento,Id_documento as Num_Documento,Monto, Fecha FROM CtaCteproveedor as a LEFT JOIN Tipodocumento as b ON a.id_tipo=b.id_tipo"
        sql = sql & " WHERE fecha >='" & dtp1.Value & "' AND fecha <= '" & dtp2.Value & "'"
        cm.CommandText = sql
        cm.Connection = cn
        cn.Open()
        dr = cm.ExecuteReader()
        dt.Load(dr)
        cn.Close()
        dr.Close()
        grd.DataSource = dt
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If cbo1.SelectedItem <> "" Then
            Tomadata()
        Else
            MessageBox.Show("Debe ingresar un Proveedor", "Imposible realizar", MessageBoxButtons.OK)
        End If
    End Sub

End Class

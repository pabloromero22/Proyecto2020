Imports MySql.Data.MySqlClient
Public Class FrmClientes
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
        cm.CommandText = "SELECT id_cliente as Codigo,razonsocial,direccion,telefono,cuit,iva,estado FROM Clientes"
        cm.Connection = cn
        cn.Open()
        dr = cm.ExecuteReader()
        dt.Load(dr)
        cn.Close()
        dr.Close()
        grd.DataSource = dt
        cbo1.Items.Add("HABILITADO")
        cbo1.Items.Add("INHABILITADO")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim id As Integer
        Dim cn As New MySqlConnection
        Dim cm As New MySqlCommand
        Dim dr As MySqlDataReader
        Dim mNull As DBNull = DBNull.Value
        cn.ConnectionString = (constConexion)
        cm.CommandType = CommandType.Text
        cm.CommandText = "SELECT MAX(id_cliente)as max FROM Clientes"
        cm.Connection = cn
        cn.Open()
        dr = cm.ExecuteReader()
        dr.Read()
        If (mNull.Equals(dr("max"))) Then
            id = 0
        Else
            id = dr("max")
        End If
        id = id + 1
        'cn.Close()
        dr.Close()
        If txt1.Text <> "" And txt2.Text <> "" And txt1.Text <> "" And txt3.Text <> "" And txt4.Text <> "" Then
            cm.CommandType = CommandType.Text
            cm.CommandText = "INSERT INTO Clientes values (" & id & ",'" & txt1.Text & "','" & txt2.Text & "','" & txt3.Text & "','" & txt4.Text & "','" & cbo1.SelectedItem & "'," & CInt(txt5.Text) & ")"
            cm.ExecuteNonQuery()
            cn.Close()
            Tomadata()
            txt1.Text = ""
            txt2.Text = ""
            txt3.Text = ""
            txt4.Text = ""
        Else
            MessageBox.Show("Datos incompletos", "Imposible realizar", MessageBoxButtons.OK)
        End If
        dr.Close()
        cn.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim idPro As Integer
        Dim cn As New MySqlConnection
        Dim cm As New MySqlCommand
        idPro = grd.Item(0, grd.CurrentRow.Index()).Value.ToString
        cn.ConnectionString = (constConexion)
        cm.Connection = cn
        cn.Open()
        cm.CommandType = CommandType.Text
        cm.CommandText = "UPDATE Clientes SET razonsocial= '" & txt1.Text & "',direccion= '" & txt2.Text & "',telefono= '" & txt3.Text & "',cuit= '" & txt4.Text & "',iva= " & txt5.Text & " ,estado= '" & cbo1.SelectedItem & "' WHERE id_cliente=" & idPro
        cm.ExecuteNonQuery()
        cn.Close()
        Tomadata()
    End Sub

    Private Sub grd_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd.CellClick
        txt1.Text = grd.Item(1, grd.CurrentRow.Index()).Value.ToString
        txt2.Text = grd.Item(2, grd.CurrentRow.Index()).Value.ToString
        txt3.Text = grd.Item(3, grd.CurrentRow.Index()).Value.ToString
        txt4.Text = grd.Item(4, grd.CurrentRow.Index()).Value.ToString
        txt5.Text = grd.Item(5, grd.CurrentRow.Index()).Value.ToString
        cbo1.SelectedItem = grd.Item(5, grd.CurrentRow.Index()).Value.ToString
    End Sub

    Private Sub txt1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt1.TextChanged
        Habilitar()
    End Sub

    Private Sub txt2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt2.TextChanged
        Habilitar()
    End Sub
    Private Sub txt3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt3.TextChanged
        Habilitar()
    End Sub

    Private Sub txt4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt4.TextChanged
        Habilitar()
    End Sub

    Private Sub Habilitar()
        If txt1.Text <> "" And txt2.Text <> "" And txt3.Text <> "" And txt3.Text <> "" Then
            Button3.Enabled = True
            Button2.Enabled = True
            Button1.Enabled = True
        Else
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
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

    Private Sub grd_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd.CellContentClick
        txt1.Text = ""
        txt2.Text = ""
        txt3.Text = ""
        txt4.Text = ""
        txt5.Text = ""
    End Sub

End Class

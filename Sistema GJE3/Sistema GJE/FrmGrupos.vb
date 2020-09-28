Imports MySql.Data.MySqlClient

Public Class FrmGrupos

    Private Sub FrmArticulos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Icon = frmBase.Icon
        Tomadata() ' carga tabla
    End Sub

    Sub Tomadata()
        Dim cn As New MySqlConnection
        Dim cm As New MySqlCommand
        Dim dr As MySqlDataReader
        Dim dt As New DataTable
        cn.ConnectionString = (constConexion)
        cm.CommandType = CommandType.Text
        cm.CommandText = "SELECT * FROM Grupos"
        cm.Connection = cn
        cn.Open()
        dr = cm.ExecuteReader()
        dt.Load(dr)
        cn.Close()
        dr.Close()
        grd.DataSource = dt
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd2.Click
        Dim id As Integer
        Dim cn As New MySqlConnection
        Dim cm As New MySqlCommand
        Dim dr As MySqlDataReader
        cn.ConnectionString = (constConexion)
        cm.CommandType = CommandType.Text
        cm.CommandText = "SELECT MAX(id_grupo) as max FROM Grupos"
        cm.Connection = cn
        cn.Open()
        dr = cm.ExecuteReader()
        dr.Read()
        id = dr("max")
        id = id + 1
        'cn.Close()
        dr.Close()
        If txt1.Text <> "" And txt1.Text <> "" Then
            cm.CommandType = CommandType.Text
            cm.CommandText = "INSERT INTO Grupos values (" & id & ",'" & txt1.Text & "')"
            cm.ExecuteNonQuery()
            cn.Close()
            Tomadata()
            txt1.Text = ""
        Else
            MessageBox.Show("Datos incompletos", "Imposible realizar", MessageBoxButtons.OK)
        End If
        dr.Close()
        cn.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd1.Click
        Dim idAc As Integer
        Dim cn As New MySqlConnection
        Dim cm As New MySqlCommand
        idAc = grd.Item(0, grd.CurrentRow.Index()).Value.ToString
        cn.ConnectionString = (constConexion)
        cm.Connection = cn
        cn.Open()
        cm.CommandType = CommandType.Text
        cm.CommandText = "UPDATE Grupos SET descripcion= '" & txt1.Text & "' WHERE id_grupos=" & idAc
        cm.ExecuteNonQuery()
        cn.Close()
        Tomadata()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd.Click
        Dim idAc As Integer
        Dim cn As New MySqlConnection
        Dim cm As New MySqlCommand
        idAc = grd.Item(0, grd.CurrentRow.Index()).Value.ToString
        cn.ConnectionString = (constConexion)
        cm.Connection = cn
        cn.Open()
        cm.CommandType = CommandType.Text
        cm.CommandText = "DELETE FROM Grupos WHERE id_grupos=" & idAc
        cm.ExecuteNonQuery()
        cn.Close()
        Tomadata()
    End Sub

    Private Sub grd_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd.CellClick
        txt1.Text = grd.Item(1, grd.CurrentRow.Index()).Value.ToString ' descripcion
    End Sub


    Private Sub txt1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt1.TextChanged
        Habilitar()
    End Sub

    Private Sub txt2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Habilitar()
    End Sub
    Private Sub Habilitar()
        If txt1.Text <> "" Then
            cmd.Enabled = True
            cmd1.Enabled = True
            cmd2.Enabled = True
        Else
            cmd.Enabled = False
            cmd1.Enabled = False
            cmd2.Enabled = False
        End If
    End Sub

End Class
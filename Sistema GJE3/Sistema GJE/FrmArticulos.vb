﻿Imports MySql.Data.MySqlClient

Public Class FrmArticulos

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
        cm.CommandText = "SELECT id_arti as Codigo,Descripcion,Precio FROM Articulos"
        cm.Connection = cn
        cn.Open()
        dr = cm.ExecuteReader()
        dt.Load(dr)
        cn.Close()
        dr.Close()
        grd.DataSource = dt
        grd.AutoResizeColumns()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd2.Click
        Dim id As Integer
        Dim cn As New MySqlConnection
        Dim cm As New MySqlCommand
        Dim dr As MySqlDataReader
        Dim mnull As DBNull = DBNull.Value
        cn.ConnectionString = (constConexion)
        cm.CommandType = CommandType.Text
        cm.CommandText = "SELECT MAX(id_arti)as max FROM Articulos"
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
        If txt1.Text <> "" And txt2.Text <> "" And txt1.Text <> "" Then
            cm.CommandType = CommandType.Text
            cm.CommandText = "INSERT INTO Articulos values (" & id & ",'" & txt1.Text & "'," & txt2.Text & ",0,0)"
            cm.ExecuteNonQuery()
            cn.Close()
            Tomadata()
            txt1.Text = ""
            txt2.Text = ""
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
        cm.CommandText = "UPDATE Articulos SET descripcion= '" & txt1.Text & "', precio=" & txt2.Text & " WHERE id_arti=" & idAc
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
        cm.CommandText = "DELETE FROM Articulos WHERE id_arti=" & idAc
        cm.ExecuteNonQuery()
        cn.Close()
        Tomadata()
    End Sub

    Private Sub grd_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd.CellClick
        txt1.Text = grd.Item(1, grd.CurrentRow.Index()).Value.ToString ' descripcion
        txt2.Text = grd.Item(2, grd.CurrentRow.Index()).Value.ToString 'precio
    End Sub

    Private Sub txt1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt1.TextChanged
        Habilitar()
    End Sub

    Private Sub txt2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt2.TextChanged
        Habilitar()
    End Sub

    Private Sub Habilitar()
        If txt1.Text <> "" And txt2.Text <> "" Then
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
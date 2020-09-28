Imports MySql.Data.MySqlClient

Public Class FrmCambiaclave

    Private Sub FrmCambiaclave_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Icon = frmBase.Icon
        Dim cn As New MySqlConnection
        Dim cm As New MySqlCommand
        Dim dr As MySqlDataReader
        cn.ConnectionString = (constConexion)
        cm.CommandType = CommandType.Text
        cm.CommandText = "SELECT clave FROM Usuarios WHERE id_usuario=" & constUser
        cm.Connection = cn
        cn.Open()
        dr = cm.ExecuteReader()
        While dr.Read()
            txt1.Text = (dr("clave"))
        End While
    End Sub

    Private Sub cmd1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd1.Click
        Dim cn As New MySqlConnection
        Dim cm As New MySqlCommand
        If txt1.Text <> "" And txt2.Text <> "" And Txt3.Text <> "" Then
            If txt2.Text = Txt3.Text Then
                cn.ConnectionString = (constConexion)
                cm.Connection = cn
                cn.Open()
                cm.CommandType = CommandType.Text
                cm.CommandText = "UPDATE Usuarios SET clave= '" & txt2.Text & "' WHERE id_usuario=" & constUser
                cn.Close()
                MessageBox.Show("Clave modificada con éxito", "Mensaje del sistema")
                txt1.Text = ""
                txt2.Text = ""
                Txt3.Text = ""
            Else
                MessageBox.Show("La clave y la confirmación son diferentes", "Imposible realizar", MessageBoxButtons.OK)
                cn.Close()
            End If
        Else
            MessageBox.Show("Datos incompletos", "Imposible realizar", MessageBoxButtons.OK)
            cn.Close()
        End If
    End Sub
End Class
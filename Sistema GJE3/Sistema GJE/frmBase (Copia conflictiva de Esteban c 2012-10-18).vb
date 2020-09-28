Public Class frmBase

    
    Private Sub frmBase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim login As New frmLogin
        'Dim result As DialogResult = login.ShowDialog()
        'If (result <> Windows.Forms.DialogResult.OK) Then
        '    Me.Close()
        'End If
    End Sub

    Private Sub ArticulosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArticulosToolStripMenuItem.Click
        FrmArticulos.Show()
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuariosToolStripMenuItem.Click
        FrmUsuarios.Show()
    End Sub

    Private Sub GruposToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GruposToolStripMenuItem.Click
        FrmGrupos.Show()
    End Sub

    Private Sub PedidosDeReaprovToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PedidosDeReaprovToolStripMenuItem.Click
        FrmPedidosReap.Show()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProveedoresToolStripMenuItem.Click
        FrmProveedores.Show()
    End Sub
End Class

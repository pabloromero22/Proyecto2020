

Module ModBase
    'Variables globales
    Public constUser As String  ' en esta constante se guarda el usuario logueado
    Public Const constConexion As String = "Server=localhost;Port=3606;Data Source=jose;Database=gje;User ID=root; Password=""; Allow Zero Datetime=True; CHARSET=latin1" ' cadena de conexion de MySQL

    Sub Main()
        Dim frmlogin As New frmLogin  ' abre nuevo formBase, funciona con el login
        If frmlogin.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            frmlogin.Close()
            Application.Run(New frmBase)
        End If
    End Sub

End Module

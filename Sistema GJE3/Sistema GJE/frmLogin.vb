Imports ADODB
Imports MySql.Data.MySqlClient
Imports MySql.Data

Public Class frmLogin

    ' TODO: inserte el código para realizar autenticación personalizada usando el nombre de usuario y la contraseña proporcionada 
    ' (Consulte http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuación: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementación de IPrincipal utilizada para realizar la autenticación. 
    ' Posteriormente, My.User devolverá la información de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.
    Dim veces As Integer = 0
    Const NumeroIntentos As Integer = 3

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        ' Variable para el recordset
        If txt1.Text <> "" And txt2.Text <> "" Then
            Dim sql As String, abrio As Integer
            'Dim dr As MySqlDataReader
            Dim cm As MySqlCommand
            Dim cn As MySqlConnection
            veces = veces + 1
            sql = "SELECT id_usuario, nombre, clave FROM Usuarios WHERE nombre = '" & txt1.Text & "' AND clave = '" & txt2.Text & "'"
            cn = New MySqlConnection(constConexion)
            Try
                cn.Open()
                cm = New MySqlCommand()
                cm.CommandText = sql
                cm.CommandType = CommandType.Text
                cm.Connection = cn
                abrio = CInt(cm.ExecuteScalar())
                cn.Close()

                Dim dr As MySqlDataReader
                cm.CommandText = "SELECT id_usuario FROM Usuarios WHERE nombre='" & txt1.Text & "'"
                cm.Connection = cn
                cn.Open()
                dr = cm.ExecuteReader()
                While dr.Read()
                    constUser = (dr("id_usuario"))
                End While
            Catch ex As Exception
                ' Cierra y descarga el Recordset  
                If Err.Number = 91 Then
                    MessageBox.Show("No se encontro registro ")
                Else
                    MessageBox.Show("error " & Err.Number.ToString & vbCrLf & ex.Message)
                End If
            Finally
                If (cn.State And ConnectionState.Open) <> 0 Then
                    cn.Close()
                End If
            End Try
            If abrio = 1 Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                If veces < NumeroIntentos Then
                    Lbl.Text = "Quedan " & (NumeroIntentos - veces) & " intentos"
                    If (cn.State And ConnectionState.Open) <> 0 Then
                        cn.Close()
                    End If
                    Exit Sub
                End If
                Me.DialogResult = Windows.Forms.DialogResult.No
            End If
            Hide()
        Else
            MessageBox.Show("Ingrese nombre de usuario y contraseña", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.DialogResult = Windows.Forms.DialogResult.No
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Hide()
    End Sub

End Class

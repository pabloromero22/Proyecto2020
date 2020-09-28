Imports MySql.Data.MySqlClient
Public Class FrmProveedores
    Public KeyAscii As Short
    Dim p As Integer = 0
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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
        cm.CommandText = "SELECT id_proveedor as Codigo,razonsocial As Razonsocial ,direccion AS 'Direccion   ' ,telefono AS 'Telefomo' ,cuit AS 'Cuit' FROM Proveedores"
        cm.Connection = cn
        cn.Open()
        dr = cm.ExecuteReader()
        dt.Load(dr)
        cn.Close()
        dr.Close()
        grd.DataSource = dt
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim id As Integer
        Dim tr As New Transactions.TransactionScope
        Dim cn As New MySqlConnection
        Dim cm As New MySqlCommand
        Dim dr As MySqlDataReader
        Dim mNull As DBNull = DBNull.Value
        cn.ConnectionString = (constConexion)
        cm.CommandType = CommandType.Text
        cm.CommandText = "SELECT MAX(id_proveedor)as max FROM proveedores"
        cm.Connection = cn
        cn.Open()
        dr = cm.ExecuteReader()
        dr.Read()
        Using tr
            Try
                If (mNull.Equals(dr("max"))) Then
                    id = 0
                Else
                    id = dr("max")
                End If
                id = id + 1
                dr.Close()
                If txt1.Text <> "" And txt2.Text <> "" And txt1.Text <> "" And txt3.Text <> "" And txt4.Text <> "" Then
                    cm.CommandType = CommandType.Text
                    cm.CommandText = "INSERT INTO Proveedores values (" & id & ",'" & txt1.Text & "','" & txt2.Text & "','" & txt3.Text & "','" & txt4.Text & "')"
                    cm.ExecuteNonQuery()
                    cn.Close()
                    Tomadata()
                    txt1.Text = ""
                    txt2.Text = ""
                    txt3.Text = ""
                    txt4.Text = ""
                    tr.Complete()
                Else
                    MessageBox.Show("Datos incompletos", "Imposible realizar", MessageBoxButtons.OK)
                    tr.Dispose()
                    cn.Close()
                End If
            Catch
                MessageBox.Show("Ocurrio un error en la operación", "Mensaje del sistema")
                tr.Dispose()
                cn.Close()
            End Try
        End Using
        dr.Close()
        cn.Close()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim idPro As Integer
        Dim cn As New MySqlConnection
        Dim cm As New MySqlCommand
        idPro = grd.Item(0, grd.CurrentRow.Index()).Value.ToString
        cn.ConnectionString = (constConexion)
        cm.Connection = cn
        cn.Open()
        cm.CommandType = CommandType.Text
        cm.CommandText = "UPDATE proveedores SET razonsocial= '" & txt1.Text & "',direccion= '" & txt2.Text & "',telefono= '" & txt3.Text & "',cuit= '" & txt4.Text & "' WHERE id_proveedor=" & idPro
        cm.ExecuteNonQuery()
        cn.Close()
        Tomadata()
    End Sub

    Private Sub grd_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd.CellClick
        txt1.Text = grd.Item(1, grd.CurrentRow.Index()).Value.ToString
        txt2.Text = grd.Item(2, grd.CurrentRow.Index()).Value.ToString
        txt3.Text = grd.Item(3, grd.CurrentRow.Index()).Value.ToString
        txt4.Text = grd.Item(4, grd.CurrentRow.Index()).Value.ToString
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

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim idPro As Integer
        Dim cn As New MySqlConnection
        Dim cm As New MySqlCommand
        idPro = grd.Item(0, grd.CurrentRow.Index()).Value.ToString
        cn.ConnectionString = (constConexion)
        cm.Connection = cn
        cn.Open()
        cm.CommandType = CommandType.Text
        cm.CommandText = "DELETE FROM proveedores WHERE id_proveedor=" & idPro
        cm.ExecuteNonQuery()
        cn.Close()
        Tomadata()
    End Sub

    Private Sub Txt3_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt3.KeyPress
         Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub Txt5_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt4.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Function SoloNumeros(ByVal Keyascii As Short) As Short
        If InStr("1234567890-", Chr(Keyascii)) = 0 Then
            SoloNumeros = 0
        Else
            SoloNumeros = Keyascii
        End If
        Select Case Keyascii
            Case 8
                SoloNumeros = Keyascii
            Case 13
                SoloNumeros = Keyascii
        End Select
    End Function

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Me.PrintDocument1.Print()
    End Sub
    Private Sub printDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ' Definimos la fuente que vamos a usar para imprimir
        ' en este caso Arial de 10
        Dim printFont As System.Drawing.Font = New Font("Arial", 10)
        Dim topMargin As Double = e.MarginBounds.Top
        Dim yPos As Double = 0
        Dim linesPerPage As Double = 0
        Dim count As Integer = 0
        Dim texto As String = ""
        Dim row As System.Windows.Forms.DataGridViewRow

        ' Calculamos el número de líneas que caben en cada página
        linesPerPage = e.MarginBounds.Height / printFont.GetHeight(e.Graphics)

        ' Imprimimos las cabeceras
        Dim header As DataGridViewHeaderCell
        For Each column As DataGridViewColumn In grd.Columns
            header = column.HeaderCell
            texto += vbTab + vbTab + header.FormattedValue.ToString()
        Next

        yPos = topMargin + (count * printFont.GetHeight(e.Graphics))
        e.Graphics.DrawString(texto, printFont, System.Drawing.Brushes.Black, 10, yPos)
        ' Dejamos una línea de separación
        count += 2

        ' Recorremos las filas del DataGridView hasta que llegemos
        ' a las líneas que nos caben en cada página o al final del grid.
        While count < linesPerPage AndAlso p < grd.Rows.Count
            row = grd.Rows(p)
            texto = ""
            For Each celda As System.Windows.Forms.DataGridViewCell In row.Cells
                'Comprobamos que la celda tenga algún valor, en caso de 
                'permitir añadir filas esto es muy importante
                If celda.Value IsNot Nothing Then
                    texto += vbTab + vbTab + celda.Value.ToString()
                End If
            Next

            ' Calculamos la posición en la que se escribe la línea
            yPos = topMargin + (count * printFont.GetHeight(e.Graphics))

            ' Escribimos la línea con el objeto Graphics
            e.Graphics.DrawString(texto, printFont, System.Drawing.Brushes.Black, 10, yPos)
            ' Incrementamos los contadores
            count += 1
            p += 1
        End While

        ' Una vez fuera del bucle comprobamos si nos quedan más filas
        ' por imprimir, si quedan saldrán en la siguente página
        If p < grd.Rows.Count Then
            e.HasMorePages = True
        Else
            ' si llegamos al final, se establece HasMorePages a
            ' false para que se acabe la impresión
            e.HasMorePages = False
            ' Es necesario poner el contador a 0 porque, por ejemplo si se hace
            ' una impresión desde PrintPreviewDialog, se vuelve disparar este
            ' evento como si fuese la primera vez, y si i está con el valor de la
            ' última fila del grid no se imprime nada
            p = 0
        End If
    End Sub
End Class

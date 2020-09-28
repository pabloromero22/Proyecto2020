<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPedidosVenta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmd3 = New System.Windows.Forms.Button()
        Me.cbo = New System.Windows.Forms.ComboBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.CantidadTxt = New System.Windows.Forms.TextBox()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.grd = New System.Windows.Forms.DataGridView()
        Me.groupbox = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbo2 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbo1 = New System.Windows.Forms.ComboBox()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.cmd1 = New System.Windows.Forms.Button()
        Me.cmd4 = New System.Windows.Forms.Button()
        CType(Me.grd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupbox.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmd3
        '
        Me.cmd3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd3.Location = New System.Drawing.Point(808, 64)
        Me.cmd3.Name = "cmd3"
        Me.cmd3.Size = New System.Drawing.Size(113, 22)
        Me.cmd3.TabIndex = 1
        Me.cmd3.Text = "Enviar"
        Me.cmd3.UseVisualStyleBackColor = True
        '
        'cbo
        '
        Me.cbo.Enabled = False
        Me.cbo.FormattingEnabled = True
        Me.cbo.Location = New System.Drawing.Point(51, 22)
        Me.cbo.Name = "cbo"
        Me.cbo.Size = New System.Drawing.Size(143, 21)
        Me.cbo.TabIndex = 2
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(3, 25)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(44, 13)
        Me.lbl1.TabIndex = 3
        Me.lbl1.Text = "Artículo"
        '
        'CantidadTxt
        '
        Me.CantidadTxt.Enabled = False
        Me.CantidadTxt.Location = New System.Drawing.Point(291, 22)
        Me.CantidadTxt.Name = "CantidadTxt"
        Me.CantidadTxt.Size = New System.Drawing.Size(62, 20)
        Me.CantidadTxt.TabIndex = 5
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(236, 25)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(49, 13)
        Me.lbl2.TabIndex = 6
        Me.lbl2.Text = "Cantidad"
        '
        'grd
        '
        Me.grd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd.Location = New System.Drawing.Point(6, 95)
        Me.grd.MultiSelect = False
        Me.grd.Name = "grd"
        Me.grd.ReadOnly = True
        Me.grd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grd.Size = New System.Drawing.Size(680, 245)
        Me.grd.TabIndex = 8
        '
        'groupbox
        '
        Me.groupbox.Controls.Add(Me.Label2)
        Me.groupbox.Controls.Add(Me.cbo2)
        Me.groupbox.Controls.Add(Me.Label1)
        Me.groupbox.Controls.Add(Me.cbo1)
        Me.groupbox.Controls.Add(Me.grd)
        Me.groupbox.Controls.Add(Me.lbl2)
        Me.groupbox.Controls.Add(Me.CantidadTxt)
        Me.groupbox.Controls.Add(Me.lbl1)
        Me.groupbox.Controls.Add(Me.cbo)
        Me.groupbox.Location = New System.Drawing.Point(12, 10)
        Me.groupbox.Name = "groupbox"
        Me.groupbox.Size = New System.Drawing.Size(776, 346)
        Me.groupbox.TabIndex = 9
        Me.groupbox.TabStop = False
        Me.groupbox.Text = "Parámetros"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(164, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Forma de pago"
        '
        'cbo2
        '
        Me.cbo2.Enabled = False
        Me.cbo2.FormattingEnabled = True
        Me.cbo2.Location = New System.Drawing.Point(248, 60)
        Me.cbo2.Name = "cbo2"
        Me.cbo2.Size = New System.Drawing.Size(123, 21)
        Me.cbo2.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(426, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Cliente"
        '
        'cbo1
        '
        Me.cbo1.Enabled = False
        Me.cbo1.FormattingEnabled = True
        Me.cbo1.Location = New System.Drawing.Point(471, 21)
        Me.cbo1.Name = "cbo1"
        Me.cbo1.Size = New System.Drawing.Size(123, 21)
        Me.cbo1.TabIndex = 9
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.Location = New System.Drawing.Point(819, 246)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(0, 15)
        Me.lbl3.TabIndex = 10
        '
        'cmd1
        '
        Me.cmd1.Location = New System.Drawing.Point(808, 6)
        Me.cmd1.Name = "cmd1"
        Me.cmd1.Size = New System.Drawing.Size(113, 23)
        Me.cmd1.TabIndex = 11
        Me.cmd1.Text = "Agregar-Modificar"
        Me.cmd1.UseVisualStyleBackColor = True
        '
        'cmd4
        '
        Me.cmd4.Location = New System.Drawing.Point(808, 35)
        Me.cmd4.Name = "cmd4"
        Me.cmd4.Size = New System.Drawing.Size(113, 23)
        Me.cmd4.TabIndex = 12
        Me.cmd4.Text = "Eliminar"
        Me.cmd4.UseVisualStyleBackColor = True
        '
        'FrmPedidosVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(974, 395)
        Me.Controls.Add(Me.cmd4)
        Me.Controls.Add(Me.cmd1)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.groupbox)
        Me.Controls.Add(Me.cmd3)
        Me.Name = "FrmPedidosVenta"
        Me.Text = "Pedidos de Venta"
        CType(Me.grd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupbox.ResumeLayout(False)
        Me.groupbox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmd3 As System.Windows.Forms.Button
    Friend WithEvents cbo As System.Windows.Forms.ComboBox
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents CantidadTxt As System.Windows.Forms.TextBox
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents grd As System.Windows.Forms.DataGridView
    Friend WithEvents groupbox As System.Windows.Forms.GroupBox
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents cmd1 As System.Windows.Forms.Button
    Friend WithEvents cmd4 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbo1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbo2 As System.Windows.Forms.ComboBox
End Class

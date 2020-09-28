<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPedidosReap
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
        Me.cmd = New System.Windows.Forms.Button()
        Me.txt = New System.Windows.Forms.TextBox()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.cmd2 = New System.Windows.Forms.Button()
        Me.grd = New System.Windows.Forms.DataGridView()
        Me.groupbox = New System.Windows.Forms.GroupBox()
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
        Me.cmd3.Location = New System.Drawing.Point(535, 298)
        Me.cmd3.Name = "cmd3"
        Me.cmd3.Size = New System.Drawing.Size(94, 23)
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
        Me.lbl1.Size = New System.Drawing.Size(42, 13)
        Me.lbl1.TabIndex = 3
        Me.lbl1.Text = "Articulo"
        '
        'cmd
        '
        Me.cmd.Location = New System.Drawing.Point(554, 10)
        Me.cmd.Name = "cmd"
        Me.cmd.Size = New System.Drawing.Size(75, 23)
        Me.cmd.TabIndex = 4
        Me.cmd.Text = "Nuevo"
        Me.cmd.UseVisualStyleBackColor = True
        '
        'txt
        '
        Me.txt.Enabled = False
        Me.txt.Location = New System.Drawing.Point(291, 22)
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(80, 20)
        Me.txt.TabIndex = 5
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
        'cmd2
        '
        Me.cmd2.Location = New System.Drawing.Point(554, 99)
        Me.cmd2.Name = "cmd2"
        Me.cmd2.Size = New System.Drawing.Size(75, 23)
        Me.cmd2.TabIndex = 7
        Me.cmd2.Text = "Modificar"
        Me.cmd2.UseVisualStyleBackColor = True
        '
        'grd
        '
        Me.grd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd.Location = New System.Drawing.Point(6, 60)
        Me.grd.MultiSelect = False
        Me.grd.Name = "grd"
        Me.grd.ReadOnly = True
        Me.grd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grd.Size = New System.Drawing.Size(466, 245)
        Me.grd.TabIndex = 8
        '
        'groupbox
        '
        Me.groupbox.Controls.Add(Me.grd)
        Me.groupbox.Controls.Add(Me.lbl2)
        Me.groupbox.Controls.Add(Me.txt)
        Me.groupbox.Controls.Add(Me.lbl1)
        Me.groupbox.Controls.Add(Me.cbo)
        Me.groupbox.Location = New System.Drawing.Point(12, 10)
        Me.groupbox.Name = "groupbox"
        Me.groupbox.Size = New System.Drawing.Size(489, 311)
        Me.groupbox.TabIndex = 9
        Me.groupbox.TabStop = False
        Me.groupbox.Text = "Parámetros"
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.Location = New System.Drawing.Point(507, 189)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(0, 15)
        Me.lbl3.TabIndex = 10
        '
        'cmd1
        '
        Me.cmd1.Location = New System.Drawing.Point(554, 70)
        Me.cmd1.Name = "cmd1"
        Me.cmd1.Size = New System.Drawing.Size(75, 23)
        Me.cmd1.TabIndex = 11
        Me.cmd1.Text = "Agregar"
        Me.cmd1.UseVisualStyleBackColor = True
        '
        'cmd4
        '
        Me.cmd4.Location = New System.Drawing.Point(554, 128)
        Me.cmd4.Name = "cmd4"
        Me.cmd4.Size = New System.Drawing.Size(75, 23)
        Me.cmd4.TabIndex = 12
        Me.cmd4.Text = "Eliminar"
        Me.cmd4.UseVisualStyleBackColor = True
        '
        'FrmPedidosReap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(641, 333)
        Me.Controls.Add(Me.cmd4)
        Me.Controls.Add(Me.cmd1)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.groupbox)
        Me.Controls.Add(Me.cmd2)
        Me.Controls.Add(Me.cmd)
        Me.Controls.Add(Me.cmd3)
        Me.Name = "FrmPedidosReap"
        Me.Text = "Solicitud de Pedido de Reaprovisionamiento"
        CType(Me.grd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupbox.ResumeLayout(False)
        Me.groupbox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmd3 As System.Windows.Forms.Button
    Friend WithEvents cbo As System.Windows.Forms.ComboBox
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents cmd As System.Windows.Forms.Button
    Friend WithEvents txt As System.Windows.Forms.TextBox
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents cmd2 As System.Windows.Forms.Button
    Friend WithEvents grd As System.Windows.Forms.DataGridView
    Friend WithEvents groupbox As System.Windows.Forms.GroupBox
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents cmd1 As System.Windows.Forms.Button
    Friend WithEvents cmd4 As System.Windows.Forms.Button
End Class

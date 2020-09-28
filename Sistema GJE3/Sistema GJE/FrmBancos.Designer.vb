<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBancos
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.cmd1 = New System.Windows.Forms.Button()
        Me.cmd = New System.Windows.Forms.Button()
        Me.cmd2 = New System.Windows.Forms.Button()
        Me.grd = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt2)
        Me.GroupBox1.Controls.Add(Me.lbl1)
        Me.GroupBox1.Controls.Add(Me.txt1)
        Me.GroupBox1.Controls.Add(Me.cmd1)
        Me.GroupBox1.Controls.Add(Me.cmd)
        Me.GroupBox1.Controls.Add(Me.cmd2)
        Me.GroupBox1.Controls.Add(Me.grd)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(447, 412)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Definición de Bancos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(169, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Sucursal"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(223, 69)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(80, 20)
        Me.TextBox1.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Contacto"
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(61, 69)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(80, 20)
        Me.txt2.TabIndex = 8
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(8, 35)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(63, 13)
        Me.lbl1.TabIndex = 7
        Me.lbl1.Text = "Descripción"
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(71, 28)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(175, 20)
        Me.txt1.TabIndex = 6
        '
        'cmd1
        '
        Me.cmd1.Enabled = False
        Me.cmd1.Location = New System.Drawing.Point(339, 41)
        Me.cmd1.Name = "cmd1"
        Me.cmd1.Size = New System.Drawing.Size(79, 22)
        Me.cmd1.TabIndex = 4
        Me.cmd1.Text = "Modificar"
        Me.cmd1.UseVisualStyleBackColor = True
        '
        'cmd
        '
        Me.cmd.Enabled = False
        Me.cmd.Location = New System.Drawing.Point(339, 69)
        Me.cmd.Name = "cmd"
        Me.cmd.Size = New System.Drawing.Size(79, 22)
        Me.cmd.TabIndex = 3
        Me.cmd.Text = "Eliminar"
        Me.cmd.UseVisualStyleBackColor = True
        '
        'cmd2
        '
        Me.cmd2.Enabled = False
        Me.cmd2.Location = New System.Drawing.Point(339, 14)
        Me.cmd2.Name = "cmd2"
        Me.cmd2.Size = New System.Drawing.Size(79, 21)
        Me.cmd2.TabIndex = 1
        Me.cmd2.Text = "Nuevo"
        Me.cmd2.UseVisualStyleBackColor = True
        '
        'grd
        '
        Me.grd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd.Location = New System.Drawing.Point(22, 97)
        Me.grd.MultiSelect = False
        Me.grd.Name = "grd"
        Me.grd.ReadOnly = True
        Me.grd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grd.Size = New System.Drawing.Size(396, 282)
        Me.grd.TabIndex = 0
        '
        'FrmBancos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 438)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmBancos"
        Me.Text = "Bancos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt2 As System.Windows.Forms.TextBox
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents txt1 As System.Windows.Forms.TextBox
    Friend WithEvents cmd1 As System.Windows.Forms.Button
    Friend WithEvents cmd As System.Windows.Forms.Button
    Friend WithEvents cmd2 As System.Windows.Forms.Button
    Friend WithEvents grd As System.Windows.Forms.DataGridView
End Class

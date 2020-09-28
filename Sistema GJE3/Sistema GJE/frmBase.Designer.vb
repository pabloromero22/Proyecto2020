<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBase))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArticulosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BancosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiarClaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GruposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlmacenesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PedidosDeReaprovToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DevolucionesDeVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DevolucionesDeComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CobrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturasImpagasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CobranzasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CuentaCorrienteProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SolicitudDeCompraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SolicitudDeCotizaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContaduríaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotaCreditoExternasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotaDebitoExternaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotaCreditoClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotaDébitoClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PagosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AceptaciónDePagoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdenDePagoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistraciónFacturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AceptaciónDeVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CuentaCorrienteClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PedidosDeVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComprasToolStripMenuItem, Me.AlmacenesToolStripMenuItem, Me.CobrosToolStripMenuItem, Me.VenToolStripMenuItem, Me.ContaduríaToolStripMenuItem, Me.PagosToolStripMenuItem, Me.VentasToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(956, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ComprasToolStripMenuItem
        '
        Me.ComprasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArticulosToolStripMenuItem, Me.BancosToolStripMenuItem, Me.CambiarClaveToolStripMenuItem, Me.GruposToolStripMenuItem, Me.UsuariosToolStripMenuItem})
        Me.ComprasToolStripMenuItem.Name = "ComprasToolStripMenuItem"
        Me.ComprasToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.ComprasToolStripMenuItem.Text = "Definiciones"
        '
        'ArticulosToolStripMenuItem
        '
        Me.ArticulosToolStripMenuItem.Name = "ArticulosToolStripMenuItem"
        Me.ArticulosToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.ArticulosToolStripMenuItem.Text = "Articulos"
        '
        'BancosToolStripMenuItem
        '
        Me.BancosToolStripMenuItem.Name = "BancosToolStripMenuItem"
        Me.BancosToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.BancosToolStripMenuItem.Text = "Bancos"
        '
        'CambiarClaveToolStripMenuItem
        '
        Me.CambiarClaveToolStripMenuItem.Name = "CambiarClaveToolStripMenuItem"
        Me.CambiarClaveToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.CambiarClaveToolStripMenuItem.Text = "Cambiar Clave"
        '
        'GruposToolStripMenuItem
        '
        Me.GruposToolStripMenuItem.Name = "GruposToolStripMenuItem"
        Me.GruposToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.GruposToolStripMenuItem.Text = "Grupos"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'AlmacenesToolStripMenuItem
        '
        Me.AlmacenesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PedidosDeReaprovToolStripMenuItem, Me.DevolucionesDeVentasToolStripMenuItem, Me.DevolucionesDeComprasToolStripMenuItem})
        Me.AlmacenesToolStripMenuItem.Name = "AlmacenesToolStripMenuItem"
        Me.AlmacenesToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.AlmacenesToolStripMenuItem.Text = "Almacenes"
        '
        'PedidosDeReaprovToolStripMenuItem
        '
        Me.PedidosDeReaprovToolStripMenuItem.Name = "PedidosDeReaprovToolStripMenuItem"
        Me.PedidosDeReaprovToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.PedidosDeReaprovToolStripMenuItem.Text = "Pedidos de Reaprovisionamiento"
        '
        'DevolucionesDeVentasToolStripMenuItem
        '
        Me.DevolucionesDeVentasToolStripMenuItem.Name = "DevolucionesDeVentasToolStripMenuItem"
        Me.DevolucionesDeVentasToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.DevolucionesDeVentasToolStripMenuItem.Text = "Devoluciones de Ventas"
        '
        'DevolucionesDeComprasToolStripMenuItem
        '
        Me.DevolucionesDeComprasToolStripMenuItem.Name = "DevolucionesDeComprasToolStripMenuItem"
        Me.DevolucionesDeComprasToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.DevolucionesDeComprasToolStripMenuItem.Text = "Devoluciones de Compras"
        '
        'CobrosToolStripMenuItem
        '
        Me.CobrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FacturasImpagasToolStripMenuItem, Me.CobranzasToolStripMenuItem})
        Me.CobrosToolStripMenuItem.Name = "CobrosToolStripMenuItem"
        Me.CobrosToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.CobrosToolStripMenuItem.Text = "Cobros"
        '
        'FacturasImpagasToolStripMenuItem
        '
        Me.FacturasImpagasToolStripMenuItem.Name = "FacturasImpagasToolStripMenuItem"
        Me.FacturasImpagasToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.FacturasImpagasToolStripMenuItem.Text = "Facturas impagas"
        '
        'CobranzasToolStripMenuItem
        '
        Me.CobranzasToolStripMenuItem.Name = "CobranzasToolStripMenuItem"
        Me.CobranzasToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.CobranzasToolStripMenuItem.Text = "Cobro de ventas"
        '
        'VenToolStripMenuItem
        '
        Me.VenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CuentaCorrienteProveedoresToolStripMenuItem, Me.SolicitudDeCompraToolStripMenuItem, Me.ProveedoresToolStripMenuItem, Me.SolicitudDeCotizaciónToolStripMenuItem})
        Me.VenToolStripMenuItem.Name = "VenToolStripMenuItem"
        Me.VenToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.VenToolStripMenuItem.Text = "Compras"
        '
        'CuentaCorrienteProveedoresToolStripMenuItem
        '
        Me.CuentaCorrienteProveedoresToolStripMenuItem.Name = "CuentaCorrienteProveedoresToolStripMenuItem"
        Me.CuentaCorrienteProveedoresToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.CuentaCorrienteProveedoresToolStripMenuItem.Text = "Cuenta Corriente Proveedores"
        '
        'SolicitudDeCompraToolStripMenuItem
        '
        Me.SolicitudDeCompraToolStripMenuItem.Name = "SolicitudDeCompraToolStripMenuItem"
        Me.SolicitudDeCompraToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.SolicitudDeCompraToolStripMenuItem.Text = "Orden de Compra"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'SolicitudDeCotizaciónToolStripMenuItem
        '
        Me.SolicitudDeCotizaciónToolStripMenuItem.Name = "SolicitudDeCotizaciónToolStripMenuItem"
        Me.SolicitudDeCotizaciónToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.SolicitudDeCotizaciónToolStripMenuItem.Text = "Pedido de Cotización"
        '
        'ContaduríaToolStripMenuItem
        '
        Me.ContaduríaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NotaCreditoExternasToolStripMenuItem, Me.NotaDebitoExternaToolStripMenuItem, Me.NotaCreditoClientesToolStripMenuItem, Me.NotaDébitoClienteToolStripMenuItem})
        Me.ContaduríaToolStripMenuItem.Name = "ContaduríaToolStripMenuItem"
        Me.ContaduríaToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.ContaduríaToolStripMenuItem.Text = "Contaduría"
        '
        'NotaCreditoExternasToolStripMenuItem
        '
        Me.NotaCreditoExternasToolStripMenuItem.Name = "NotaCreditoExternasToolStripMenuItem"
        Me.NotaCreditoExternasToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.NotaCreditoExternasToolStripMenuItem.Text = "Nota Crédito Proveedores"
        '
        'NotaDebitoExternaToolStripMenuItem
        '
        Me.NotaDebitoExternaToolStripMenuItem.Name = "NotaDebitoExternaToolStripMenuItem"
        Me.NotaDebitoExternaToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.NotaDebitoExternaToolStripMenuItem.Text = "Nota Débito Proveedores"
        '
        'NotaCreditoClientesToolStripMenuItem
        '
        Me.NotaCreditoClientesToolStripMenuItem.Name = "NotaCreditoClientesToolStripMenuItem"
        Me.NotaCreditoClientesToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.NotaCreditoClientesToolStripMenuItem.Text = "Nota Crédito Clientes"
        '
        'NotaDébitoClienteToolStripMenuItem
        '
        Me.NotaDébitoClienteToolStripMenuItem.Name = "NotaDébitoClienteToolStripMenuItem"
        Me.NotaDébitoClienteToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.NotaDébitoClienteToolStripMenuItem.Text = "Nota Débito Cliente"
        '
        'PagosToolStripMenuItem
        '
        Me.PagosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AceptaciónDePagoToolStripMenuItem, Me.OrdenDePagoToolStripMenuItem, Me.RegistraciónFacturasToolStripMenuItem})
        Me.PagosToolStripMenuItem.Name = "PagosToolStripMenuItem"
        Me.PagosToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.PagosToolStripMenuItem.Text = "Pagos"
        '
        'AceptaciónDePagoToolStripMenuItem
        '
        Me.AceptaciónDePagoToolStripMenuItem.Name = "AceptaciónDePagoToolStripMenuItem"
        Me.AceptaciónDePagoToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.AceptaciónDePagoToolStripMenuItem.Text = "Aceptación de Pago"
        '
        'OrdenDePagoToolStripMenuItem
        '
        Me.OrdenDePagoToolStripMenuItem.Name = "OrdenDePagoToolStripMenuItem"
        Me.OrdenDePagoToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.OrdenDePagoToolStripMenuItem.Text = "Orden de Pago"
        '
        'RegistraciónFacturasToolStripMenuItem
        '
        Me.RegistraciónFacturasToolStripMenuItem.Name = "RegistraciónFacturasToolStripMenuItem"
        Me.RegistraciónFacturasToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.RegistraciónFacturasToolStripMenuItem.Text = "Registración Facturas"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AceptaciónDeVentaToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.CuentaCorrienteClientesToolStripMenuItem, Me.PedidosDeVentaToolStripMenuItem, Me.ToolStripMenuItem2})
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        '
        'AceptaciónDeVentaToolStripMenuItem
        '
        Me.AceptaciónDeVentaToolStripMenuItem.Name = "AceptaciónDeVentaToolStripMenuItem"
        Me.AceptaciónDeVentaToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.AceptaciónDeVentaToolStripMenuItem.Text = "Aceptación de Venta"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'CuentaCorrienteClientesToolStripMenuItem
        '
        Me.CuentaCorrienteClientesToolStripMenuItem.Name = "CuentaCorrienteClientesToolStripMenuItem"
        Me.CuentaCorrienteClientesToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.CuentaCorrienteClientesToolStripMenuItem.Text = "Cuenta Corriente Clientes"
        '
        'PedidosDeVentaToolStripMenuItem
        '
        Me.PedidosDeVentaToolStripMenuItem.Name = "PedidosDeVentaToolStripMenuItem"
        Me.PedidosDeVentaToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.PedidosDeVentaToolStripMenuItem.Text = "Nota de pedido"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(209, 22)
        Me.ToolStripMenuItem2.Text = "Facturación"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = Global.WindowsApplication1.My.Resources.Resources.salir
        Me.ToolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(41, 20)
        Me.ToolStripMenuItem1.Text = "  "
        Me.ToolStripMenuItem1.ToolTipText = "Salir del sistema"
        '
        'frmBase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(956, 608)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmBase"
        Me.Text = "Sistema GJE"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ComprasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArticulosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CobrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PagosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SolicitudDeCompraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GruposToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlmacenesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PedidosDeReaprovToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SolicitudDeCotizaciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrdenDePagoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BancosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistraciónFacturasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContaduríaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotaCreditoExternasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotaDebitoExternaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PedidosDeVentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CuentaCorrienteProveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CuentaCorrienteClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CambiarClaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AceptaciónDeVentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AceptaciónDePagoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacturasImpagasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CobranzasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotaCreditoClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotaDébitoClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DevolucionesDeVentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DevolucionesDeComprasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class

Public Class frmBase

    Private Sub frmBase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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

    
    Private Sub SolicitudDeCompraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SolicitudDeCompraToolStripMenuItem.Click
        FrmOrdenCompra.Show()
    End Sub

    Private Sub SolicitudDeCotizaciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SolicitudDeCotizaciónToolStripMenuItem.Click
        FrmPedidoCotizacion.Show()
    End Sub

    Private Sub OrdenDePagoToolStripMenuItem_Cfrmlick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrdenDePagoToolStripMenuItem.Click
        FrmOrdenPago.Show()
    End Sub

    Private Sub BancosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BancosToolStripMenuItem.Click
        FrmBancos.Show()
    End Sub

    Private Sub RegistraciónFacturasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistraciónFacturasToolStripMenuItem.Click
        FrmFacturasCompras.Show()
    End Sub

    
    Private Sub NotaCreditoExternasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotaCreditoExternasToolStripMenuItem.Click
        FrmNotaCreditoExterna.Show()
    End Sub

    Private Sub NotaDebitoExternaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotaDebitoExternaToolStripMenuItem.Click
        FrmNotaDebitoExterna.Show()
    End Sub

    Private Sub PedidosDeVentaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PedidosDeVentaToolStripMenuItem.Click
        FrmPedidosVenta.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
        FrmClientes.Show()
    End Sub

    Private Sub CuentaCorrienteProveedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CuentaCorrienteProveedoresToolStripMenuItem.Click
        FrmCtaCteProv.Show()
    End Sub

    Private Sub CuentaCorrienteClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CuentaCorrienteClientesToolStripMenuItem.Click
        FrmFacturasImpagas.Show()
    End Sub
    Private Sub CambiarClaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambiarClaveToolStripMenuItem.Click
        FrmCambiaclave.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Application.Exit()
    End Sub

    Private Sub AceptaciónDeVentaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptaciónDeVentaToolStripMenuItem.Click
        FrmAceptaVenta.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        FrmFacturasVentas.Show()
    End Sub

    Private Sub AceptaciónDePagoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptaciónDePagoToolStripMenuItem.Click
        FrmAceptacionPago.Show()
    End Sub

    Private Sub CobranzasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CobranzasToolStripMenuItem.Click
        FrmCobro.Show()
    End Sub

    Private Sub FacturasImpagasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturasImpagasToolStripMenuItem.Click
        FrmFacturasImpagas.Show()
    End Sub

    Private Sub NotaCreditoClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotaCreditoClientesToolStripMenuItem.Click
        FrmNotaCreditoInterna.Show()
    End Sub

    Private Sub NotaDébitoClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotaDébitoClienteToolStripMenuItem.Click
        FrmNotaDebitoInterna.Show()
    End Sub

    Private Sub DevolucionesDeVentasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DevolucionesDeVentasToolStripMenuItem.Click
        FrmDevolucionesVentas.Show()
    End Sub

    Private Sub DevolucionesDeComprasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DevolucionesDeComprasToolStripMenuItem.Click
        FrmDevolucionesCompras.Show()
    End Sub
End Class

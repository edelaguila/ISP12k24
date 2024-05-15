using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Seguridad_Controlador;

namespace Vista_PrototipoMenu
{
    public partial class MenuPrototipo : Form
    {

        Controlador cn = new Controlador();

        //Método que guarda en un arreglo de tipo botón los botones que se tienen en el formulario. Se les da permiso a los diferentes botones de acuerdo a la función que realice este
        public MenuPrototipo()
        {
            InitializeComponent();
            //Control para habilitar opciones del menu
            Button[] apps = { btnaplicaciones };
            //Llamada metodo de libreria Controlador del modulo de Seguridad
            cn.deshabilitarApps(apps);
            //Llamada metodo de libreria Controlador del modulo de Seguridad
            cn.getAccesoApp(1002, apps[0]);
        }

        //Validaciones que si son visibles los panales los oculta
        private void hideSubMenu()
        {

            if (panelTranportes.Visible == true)
                panelTranportes.Visible = false;
            if (PanelAuditoria.Visible == true)
                PanelAuditoria.Visible = false;
            if (panelseguridad.Visible == true)
                panelseguridad.Visible = false;
            if (panelayuda.Visible == true)
                panelayuda.Visible = false;
        }
        //Método que valida si el submenu no es visible oculta el submenu
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        //Método que muestra el panel indicado
        private void btnmanteniminetos_Click(object sender, EventArgs e)
        {
            showSubMenu(panelTranportes);
        }
        //Método que muestra el panel indicado
        private void btnProcesos_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelAuditoria);
        }
        //Método que muestra el panel indicado
        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            showSubMenu(panelayuda);
        }
        //Método que muestra el panel indicado
        private void btnReportes_Click(object sender, EventArgs e)
        {
            showSubMenu(panelseguridad);
        }
        //Método que muestra el formulario indicado
        //Método que muestra el formulario indicado
        private void btnaplicaciones_Click(object sender, EventArgs e)
        {
            CapaVista_SisB.frmCliente form = new CapaVista_SisB.frmCliente();
            form.MdiParent = this;
            form.Show();
            hideSubMenu();
        }
        //Método que muestra el formulario indicado

        private void btninicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Método que oculta el formulario
        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Método que muestra el formulario indicado
        private void btnayuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Ayudas_Base/AyudaSistemaBancario.chm", "MDI_SistemaBancario.html");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CapaVista_SisB.frmHistorial form = new CapaVista_SisB.frmHistorial();
            form.MdiParent = this;
            form.Show();
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CapaVista_SisB.PagoServicios form = new CapaVista_SisB.PagoServicios();
            form.MdiParent = this;
            form.Show();
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            CapaVista_SisB.frmDeposito form = new CapaVista_SisB.frmDeposito();
            form.MdiParent = this;
            form.Show();
            hideSubMenu();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //CapaVista_SisB.frmEstado form = new CapaVista_SisB.frmEstado();
            //form.MdiParent = this;
            //form.Show();
            //();
        }

        private void man_boleta_Click(object sender, EventArgs e)
        {
            CapaVista_SisB.Cheques form = new CapaVista_SisB.Cheques();
            form.MdiParent = this;
            form.Show();
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            CapaVista_SisB.MovimientosBancarios form = new CapaVista_SisB.MovimientosBancarios();
            form.MdiParent = this;
            form.Show();
            hideSubMenu();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            CapaVista_SisB.MantenimientoTransaccion form = new CapaVista_SisB.MantenimientoTransaccion();
            form.MdiParent = this;
            form.Show();
            hideSubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CapaVista_SisB.frmRetiro form = new CapaVista_SisB.frmRetiro();
            form.MdiParent = this;
            form.Show();
            hideSubMenu();
        }

        private void btn_man_cuenta_Click(object sender, EventArgs e)
        {
            CapaVista_SisB.Mantenimiento_Cuenta form = new CapaVista_SisB.Mantenimiento_Cuenta();
            form.MdiParent = this;
            form.Show();
            hideSubMenu();
        }

        private void btn_mant_tipo_cuenta_Click(object sender, EventArgs e)
        {
            CapaVista_SisB.frmTipoCuenta form = new CapaVista_SisB.frmTipoCuenta();
            form.MdiParent = this;
            form.Show();
            hideSubMenu();
        }

        private void mant_moneda_Click(object sender, EventArgs e)
        {
            CapaVista_SisB.frmMoneda form = new CapaVista_SisB.frmMoneda();
            form.MdiParent = this;
            form.Show();
            hideSubMenu();
        }

        private void btn_mant_cliente_Click_2(object sender, EventArgs e)
        {
            CapaVista_SisB.frmCliente form = new CapaVista_SisB.frmCliente();
            form.MdiParent = this;
            form.Show();
            hideSubMenu();
        }

        private void btn_mant_estados_Click(object sender, EventArgs e)
        {
            CapaVista_SisB.Mantenimiento_Estado form = new CapaVista_SisB.Mantenimiento_Estado();
            form.MdiParent = this;
            form.Show();
            hideSubMenu();
        }

        private void btn_mant_tarjeta_Click(object sender, EventArgs e)
        {
            CapaVista_SisB.Mantenimiento_Tarjeta form = new CapaVista_SisB.Mantenimiento_Tarjeta();
            form.MdiParent = this;
            form.Show();
            hideSubMenu();
        }

        private void btn_mant_tipo_tarjeta_Click(object sender, EventArgs e)
        {
            CapaVista_SisB.Mantenimiento_Tipo_Tarjeta form = new CapaVista_SisB.Mantenimiento_Tipo_Tarjeta();
            form.MdiParent = this;
            form.Show();
            hideSubMenu();
        }

        private void btn_mant_transaccion_Click_2(object sender, EventArgs e)
        {
            CapaVista_SisB.MantenimientoTransaccion form = new CapaVista_SisB.MantenimientoTransaccion();
            form.MdiParent = this;
            form.Show();
            hideSubMenu();
        }

        private void btn_mant_tipo_trans_Click(object sender, EventArgs e)
        {
            CapaVista_SisB.Mantenimiento_Tipo_Transaccion form = new CapaVista_SisB.Mantenimiento_Tipo_Transaccion();
            form.MdiParent = this;
            form.Show();
            hideSubMenu();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            CapaVista_SisB.Mantenimientos.FrmCuentaAmiga form = new CapaVista_SisB.Mantenimientos.FrmCuentaAmiga();
            form.MdiParent = this;
            form.Show();
            hideSubMenu();
        }
    }
}

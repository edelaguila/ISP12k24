using CapaVistaERP.Mantenimientos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaERP
{
    public partial class MDIGeneral : Form
    {
        public MDIGeneral()
        {
            InitializeComponent();
            //Control para habilitar opciones del menu
            // Button[] apps = { btn_precios, btn_generarBoleta };
            //Llamada metodo de libreria Controlador del modulo de Seguridad
            //cns.deshabilitarApps(apps);
            //Llamada metodo de libreria Controlador del modulo de Seguridad
            //cns.getAccesoApp(2001, apps[1]);
            //cns.getAccesoApp(2002, apps[2]);
            //cns.getAccesoApp(2003, apps[3]);
            //cns.getAccesoApp(2004, apps[4]);
            //cns.getAccesoApp(2005, apps[5]);
            escondersubmenus();
        }

        private void escondersubmenus()
        {
            submenumantcompras.Visible = false;
            submenumantventas.Visible = false;
            submenumantlogistica.Visible = false;
            submenumantbancos.Visible = false;
            panelMantenimientos.Visible = false;
            submenuprocesoscompra.Visible = false;
            submenuprocesosventas.Visible = false;
            submenuprocesoslogistica.Visible = false;
            submenuprocesosbancos.Visible = false;
            PanelProcesos.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelMantenimientos.Visible == true)
                panelMantenimientos.Visible = false;
            if (PanelProcesos.Visible == true)
                PanelProcesos.Visible = false;
            if (panelReporte.Visible == true)
                panelReporte.Visible = false;
            if (panelSeguridad.Visible == true)
                panelSeguridad.Visible = false;

        }
        //Método que valida si el submenu no es visible oculta el submenu
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                //hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void showSubMenuMantenimientos(Panel subMenuMant)
        {
            if (subMenuMant.Visible == false)
            {
                hideSubMenu();
                subMenuMant.Visible = true;
            }
            else
                subMenuMant.Visible = false;
        }

        private void Abrir(object abrirform)
        {
            if (this.panelMDI.Controls.Count > 0)
                this.panelMDI.Controls.RemoveAt(0);

            Form fh = abrirform as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.None;
            this.panelMDI.Controls.Add(fh);
            this.panelMDI.Tag = fh;
            fh.Show();
        }

        private void btninicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnmanteniminetos_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMantenimientos);
        }

        private void btnProcesos_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelProcesos);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            showSubMenu(panelReporte);
        }

        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSeguridad);
        }

        private void btnayuda_Click(object sender, EventArgs e)
        {
            //Help.ShowHelp(this, "umg.chm");
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_mantenimiento1_Click(object sender, EventArgs e)
        {
            showSubMenu(submenumantcompras);
        }

        private void btn_proceso1_Click(object sender, EventArgs e)
        {
            showSubMenu(submenuprocesoscompra);
        }

        private void panel1_Click(object sender, PaintEventArgs e)
        {
            showSubMenu(PanelProcesos);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //frm_mant_clientes frm_Mant_Clientes = new frm_mant_clientes();
            //this.Parent = frm_Mant_Clientes;
            //hideSubMenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //frm_mant_clientes frm_Mant_Clientes = new frm_mant_clientes();
            //this.Parent = frm_Mant_Clientes;
            //hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showSubMenu(submenumantventas);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            showSubMenu(submenumantlogistica);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            showSubMenu(submenumantbancos);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            showSubMenu(submenuprocesosventas);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            showSubMenu(submenuprocesoslogistica);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            showSubMenu(submenuprocesosbancos);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Abrir(new Mantenimientos.frm_mant_clientes());
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Abrir(new Mantenimientos.frm_mant_vendedores());
            hideSubMenu();
        }

        private void button28_Click(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {
            Abrir(new Procesos.OrdenesdeCompra());
            hideSubMenu();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Abrir(new Procesos.Compras());
            hideSubMenu();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Abrir(new Procesos.FacturaporPagar());
            hideSubMenu();
        }
    }
}

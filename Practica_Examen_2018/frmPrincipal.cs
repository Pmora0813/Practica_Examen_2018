using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Examen_2018
{
    public partial class frmPrincipal : Form
    {

        CotizadorFacade Cotizador = null;


        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            llenarComboCombustible();
            llenarComboCategoria();
        }

        private void llenarComboCategoria()
        {
            cmbCategoria.DataSource = Enum.GetValues(typeof(Categoria));
            cmbCategoria.SelectedIndex = -1;
        }

        private void llenarComboCombustible()
        {
            cmbCombustible.DataSource = Enum.GetValues(typeof(Combustible));
            cmbCombustible.SelectedIndex = -1;

        }

        private void btnCotizar_Click(object sender, EventArgs e)
        {
            IAgencia agencia = null;
            agencia = AgenciaFatory.CrearAgencia(rbtnAutoStar.Checked, rbtnGrupoQ.Checked, RbtnPurdyMotor.Checked);

            Cotizador = new CotizadorFacade();
            Cotizador.Agencia = agencia;
            Cotizador.AgregarCliente(txtEmail.Text.Trim(), Convert.ToInt32(mskTelefono.Text));
            Cotizador.Meses = Convert.ToInt32(npdMeses.Value);

            if (chkCamara.Checked)
            {
                Extra extra = new CamaraRetroceso();
                Cotizador.AgregarExtras(extra);
            }

            if (chkAlarma.Checked)
            {
                Extra extra = new Alarma();
                Cotizador.AgregarExtras(extra);
            }
            if (chkHalogeno.Checked)
            {
                Extra extra = new Halogenos();
                Cotizador.AgregarExtras(extra);
            }
            Trasmision tras;

            if (rbtnManual.Checked)
            {
                tras = Trasmision.Manual;
            }
            else
            {
                tras = Trasmision.Automatico;
            }
            Cotizador.Vehiculo = VehiculoFactory.CrearVehiculo(Convert.ToInt32(npdPrecioBase.Value), (Combustible)cmbCombustible.SelectedItem, (Categoria)cmbCategoria.SelectedItem, tras);

            Cotizador.GuardarXML();

            txtTotal.Text = Cotizador.CalcularTotal().ToString("C3");
            MostrarCotizador();

            
        }

        private void MostrarCotizador()
        {
            string ruta = Cotizador.Ruta;

            ruta = Cotizador.TransformXMLToHTML(ruta);
            wbbMostrar.Url = new Uri(Application.StartupPath + "\\" + ruta);

            //MostrarOrden(Application.StartupPath + "\\" + ruta);
            //wbbMostrar.Url = new Uri(ruta);           
        }
    }
}

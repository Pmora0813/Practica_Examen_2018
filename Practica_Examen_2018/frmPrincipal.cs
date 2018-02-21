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
        Extra extra = null;


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
                extra = new CamaraRetroceso();
                Cotizador.AgregarExtras(extra);
            }

            if (chkAlarma.Checked)
            {
                extra = new Alarma();
                Cotizador.AgregarExtras(extra);
            }
            if (chkHalogeno.Checked)
            {
                extra = new Halogenos();
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
            // Creamos y asignamos a la vez un Vehiculo
            Cotizador.Vehiculo = VehiculoFactory.CrearVehiculo(Convert.ToInt32(npdPrecioBase.Value), (Combustible)cmbCombustible.SelectedItem, (Categoria)cmbCategoria.SelectedItem, tras);

            //Metodo para guardar el XML
            Cotizador.GuardarXML();

            //Llamamos al metodo para mostrar el monto mensual en el 
            //en el txt y le asignamos un formato para mostrarlo
            txtTotal.Text = Cotizador.CalcularTotal().ToString("C3");
            MostrarCotizador();


        }
        //Metodo para cargar el XML y mostrarlo en el webbroser
        private void MostrarCotizador()
        {
            //Obtenemos la ruta del archivo
            string ruta = Cotizador.Ruta;

            //Transformanos el archivo XML en HTML con el metodo
            ruta = Cotizador.TransformXMLToHTML(ruta);

            //Le asignamos el HTML al web broser
            wbbMostrar.Url = new Uri(Application.StartupPath + "\\" + ruta);

        }
    }
}

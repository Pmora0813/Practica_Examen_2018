using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Xsl;

namespace Practica_Examen_2018
{
    class CotizadorFacade
    {
        public string Ruta
        {
            get { return Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\VehiculoXml.xml"; }
        }

        public IAgencia Agencia { get; set; }
        public Cliente Cliente { get; set; }
        public List<Extra> Extras { get; set; }
        public int Meses { get; set; }
        public Vehiculo Vehiculo { get; set; }

        public CotizadorFacade()
        {
            Extras = new List<Extra>();
        }

        public void AgregarCliente(string email, int telefono)
        {
            Cliente cliente = new Cliente();
            {
                cliente.Email = email;
                cliente.Telefono = telefono;
            }
            this.Cliente = cliente;
        }


        public void AgregarExtras(Extra extra)
        {
            Extras.Add(extra);
        }


        public double CostoExtras()
        {
            double costo = 0;

            foreach (Extra item in Extras)
            {
                costo += item.ObtenerCosto();
            }
            costo += Vehiculo.PrecioBase;
            return costo;
        }


        public double CostoCombustible()
        {
            double costo = 0;

            costo = CostoExtras() + (Agencia.ObtenerCostoCategoria(Vehiculo.Categoria) +
                Agencia.ObtenerCostoTransmicison(Vehiculo.Trasmision));

            int porcentaje = (int)Vehiculo.Combustible;
            double porceCon = porcentaje / 100d;
            costo = (costo * porceCon) + costo;

            return costo;
        }

        public double CosotoInteres()
        {
            double costo = 0;

            costo = (CostoCombustible() * Agencia.ObtenerPorcentajeInteres()) + CostoCombustible();

            return costo;
        }


        public double CalcularTotal()
        {
            double total = 0;

            total =  CosotoInteres() / Meses;

            return total;
        }


        public void GuardarXML()
        {


            XmlDocument doc = new XmlDocument();

            //  Si el archivo no existe debe crearlo
            // con la estructura raiz
            if (File.Exists(Ruta) == false)
            {

                // LoadXml carga un string con formato xml
                doc.LoadXml("<VehiculosAgencias></VehiculosAgencias>");
            }
            else
            {
                File.Delete(Ruta);
                doc.LoadXml("<VehiculosAgencias></VehiculosAgencias>");
            }

            // DocumentElement = raiz (solo puede existir 1)
            XmlElement root = doc.DocumentElement;

            XmlElement NodoAgencia = doc.CreateElement("Agencia");
            NodoAgencia.SetAttribute("Nombre", Agencia.Nombre.ToString());
            root.AppendChild(NodoAgencia);

            XmlElement NodoCliente = doc.CreateElement("Cliente");

            XmlElement NodoEmail = doc.CreateElement("Email");
            NodoEmail.InnerText = Cliente.Email;

            XmlElement NodoTelefono = doc.CreateElement("Telefono");
            NodoTelefono.InnerText = Cliente.Telefono.ToString();

            NodoCliente.AppendChild(NodoEmail);
            NodoCliente.AppendChild(NodoTelefono);

            root.AppendChild(NodoCliente);

            XmlElement NodoVehiculo = doc.CreateElement("Vehiculo");
            NodoVehiculo.SetAttribute("Combustible", Vehiculo.Combustible.ToString());
            NodoVehiculo.SetAttribute("Transmision", Vehiculo.Trasmision.ToString());

            XmlElement NodoCategoria = doc.CreateElement("Categoria");
            NodoCategoria.InnerText = Vehiculo.Categoria.ToString();
            NodoVehiculo.AppendChild(NodoCategoria);

            XmlElement NodoPrecioBase = doc.CreateElement("PrecioBase");
            NodoPrecioBase.InnerText = Vehiculo.PrecioBase.ToString("C2");
            NodoVehiculo.AppendChild(NodoPrecioBase);

            XmlElement NodoExtras = doc.CreateElement("Extras");
            foreach (Extra item in Extras)
            {
                XmlElement NodoExtra = doc.CreateElement("Extra");
                NodoExtra.SetAttribute("Descripcion", item.Descripcion);
                NodoExtra.SetAttribute("Costo", item.ObtenerCosto().ToString());
                NodoExtras.AppendChild(NodoExtra);

            }
            NodoVehiculo.AppendChild(NodoExtras);

            root.AppendChild(NodoVehiculo);

            XmlElement NodoCotizacion = doc.CreateElement("Cotizacion");

            XmlElement NodoMeses = doc.CreateElement("Meses");
            NodoMeses.InnerText = Meses.ToString();
            NodoCotizacion.AppendChild(NodoMeses);

            XmlElement NodoCuotaMensual = doc.CreateElement("CuotaMensual");
            NodoCuotaMensual.InnerText = CalcularTotal().ToString("C3");
            NodoCotizacion.AppendChild(NodoCuotaMensual);

            root.AppendChild(NodoCotizacion);


            XmlElement NodoPagos = doc.CreateElement("Pagos");

            double monto = CalcularTotal();
            for (int i = 1; i <= Meses; i++)
            {
                XmlElement NodoPago = doc.CreateElement("Pago");
                NodoPago.SetAttribute("Mes", i.ToString());
                NodoPago.SetAttribute("Monto", monto.ToString("C3"));
                NodoPagos.AppendChild(NodoPago);
            }

            root.AppendChild(NodoPagos);

            // Salvar
            doc.Save(Ruta);
        }

        public string TransformXMLToHTML(string rutaXML)
        {
            // Transformación del XMl utilizando XSLT
            XslCompiledTransform myXslTrans = new XslCompiledTransform();
            // Carga en memoria la lectura xslt
            myXslTrans.Load("VehiculosAgencias.xslt");
            // Transforma el archivo xml aun archivo HTML
            myXslTrans.Transform(rutaXML, "Vehiculos_Agencias.html");

            return "Vehiculos_Agencias.html";
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Examen_2018
{
    class GrupoQ : IAgencia
    {
        public string Nombre
        {
            get
            {
                return "Grupo Q";
            }
        }

        public double ObtenerCostoCategoria(Categoria cate)
        {
            double costo = 0;
            switch (cate)
            {
                case Categoria.Sedan:
                    costo = 1000;
                    break;
                case Categoria.SUV:
                    costo = 2000;
                    break;
                case Categoria.HatchBack:
                    costo = 500;
                    break;
            }
            return costo;

        }

        public double ObtenerCostoTransmicison(Trasmision trans)
        {
            double costo = 0;
            switch (trans)
            {
                case Trasmision.Manual:
                    costo = 1000;
                    break;
                case Trasmision.Automatico:
                    costo = 2000;
                    break;
            }
            return costo;
        }

        public double ObtenerPorcentajeInteres()
        {
            return 0.10d;
        }
    }
}
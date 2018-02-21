using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Examen_2018
{
    class AutoStar : IAgencia
    {
        public string Nombre
        {
            get
            {
                return "Auto Star";
            }
        }

        public double ObtenerCostoCategoria(Categoria cate)
        {
            double costo = 0;
            switch (cate)
            {
                case Categoria.Sedan:
                    costo = 3000;
                    break;
                case Categoria.SUV:
                    costo = 5000;
                    break;
                case Categoria.HatchBack:
                    costo = 2000;
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
                    costo = 2000;
                    break;
                case Trasmision.Automatico:
                    costo = 4000;
                    break;
            }
            return costo;
        }

        public double ObtenerPorcentajeInteres()
        {
            return 0.12d;
        }
    }
}

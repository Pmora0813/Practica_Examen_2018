using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Examen_2018
{
    interface IAgencia
    {
        string Nombre { get; }
        double ObtenerCostoCategoria(Categoria cate);
        double ObtenerCostoTransmicison(Trasmision trans);
        double ObtenerPorcentajeInteres();


    }
}

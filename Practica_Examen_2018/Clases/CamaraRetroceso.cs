using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Examen_2018
{
    class CamaraRetroceso : Extra
    {
        public override string Descripcion
        {
            get
            {
                return "Cámara de Retroceso";
            }
        }

        public override double ObtenerCosto()
        {
            return 300;
        }
    }
}

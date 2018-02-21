using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Examen_2018
{
    class Alarma : Extra
    {
        public override string Descripcion
        {
            get
            {
                return "Alarma";
            }
        }

        public override double ObtenerCosto()
        {
            return 100;
        }
    }
}

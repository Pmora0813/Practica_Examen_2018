using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Examen_2018
{
    class AgenciaFatory
    {
        public static IAgencia CrearAgencia(bool autoStar, bool grupoQ, bool purdyMotor)
        {
            IAgencia agencia = null;

            if (autoStar)
            {
                agencia = new AutoStar();
            }

            if (grupoQ)
            {
                agencia = new GrupoQ();
            }

            if (purdyMotor)
            {
                agencia = new PurdyMotor();
            }


            return agencia;
        }
    }
}

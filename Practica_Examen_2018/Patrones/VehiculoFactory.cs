using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Examen_2018
{
    class VehiculoFactory
    {
        public static Vehiculo CrearVehiculo(double precio, Combustible comb, Categoria cat, Trasmision tras)
        {
            Vehiculo vehiculo = new Vehiculo(precio, comb, cat, tras);

            return vehiculo;
        }
    }
}

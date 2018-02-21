using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Examen_2018
{
    class Vehiculo
    {
        public Categoria Categoria { get; set; }
        public Combustible Combustible { get; set; }
        public double PrecioBase { get; set; }
        public Trasmision Trasmision { get; set; }

        public Vehiculo(double precio, Combustible comb, Categoria cat, Trasmision trans)
        {
            this.PrecioBase = precio;
            this.Combustible = comb;
            this.Categoria = cat;
            this.Trasmision = trans;
        }
    }
}

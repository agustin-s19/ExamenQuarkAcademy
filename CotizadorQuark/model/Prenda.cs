using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorQuark
{
    abstract class Prenda
    {
        private string calidad;
        private int cantidad;
        private double precioUnitario;

        public string Calidad { get => calidad; set => calidad = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public double PrecioUnitario { get => precioUnitario; set => precioUnitario = value; }

        protected Prenda(string calidad, int cantidad)
        {
            this.Calidad = calidad;
            this.Cantidad = cantidad;

        }


        
    }
   
}

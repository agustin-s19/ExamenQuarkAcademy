using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorQuark
{
    abstract class Prenda
    {
        protected string calidad;
        protected int precioUnitario;
        protected int cantidad;
        protected int precioTotal = 0;

        public Prenda(){
            
        }
        public Prenda(string calidad, int precioUnitario, int cantidad)
        {
            this.calidad = calidad;
            this.cantidad = cantidad;
            this.precioUnitario = precioUnitario;
            
        }

        public string Calidad { get => calidad; }
        public int PrecioUnitario { get => precioUnitario; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int PrecioTotal { get => precioTotal; set => precioTotal = value; }

        public virtual void CalcularPrecio()
        {
            precioTotal = PrecioUnitario * cantidad;

        }
       

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorQuark
{
    internal class Cotizacion
    {
        
        private int numeroId;
        private string fecha;
        private int codigoVendedor;
        private Prenda prendaCotizada;
        private int cantidadUnidadesCotizadas;
        private string precioTotal;




        public string Fecha { get => fecha; set => fecha = value; }
        public int CodigoVendedor { get => codigoVendedor; set => codigoVendedor = value; }
        public Prenda PrendaCotizada { get => prendaCotizada; set => prendaCotizada = value; }
        public int CantidadUnidadesCotizadas { get => cantidadUnidadesCotizadas; set => cantidadUnidadesCotizadas = value; }
       
        public string PrecioTotal { get => precioTotal; set => precioTotal = value; }
        public int NumeroId { get => numeroId; set => numeroId = value; }

        public Cotizacion(int codigoVendedor, Prenda prendaCotizada, int cantidadUnidadesCotizadas, string resultado)
        {
            Random a = new Random();
            this.NumeroId = Math.Abs(4552 * a.Next());
            this.Fecha = DateTime.Now.ToString();
            this.CodigoVendedor = codigoVendedor;
            this.PrendaCotizada = prendaCotizada;
            this.CantidadUnidadesCotizadas = cantidadUnidadesCotizadas;
            this.PrecioTotal = resultado;

        }

      
    }
}

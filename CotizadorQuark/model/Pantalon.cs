using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorQuark
{
    class Pantalon : Prenda
    {
        private string tipoPantalon;

        public Pantalon(string tipoPantalon)
        {
            this.tipoPantalon = tipoPantalon;
        }
        public string TipoPantalon { get => tipoPantalon;}

        public override void CalcularPrecio()
        {
            base.CalcularPrecio();
            if (calidad == "premium")
            {
                if (tipoPantalon == "chupin")
                {
                    PrecioTotal = Convert.ToInt32(PrecioTotal * 0.88);
                    precioTotal = Convert.ToInt32(precioTotal * 1.3);
                }
                else
                {
                    if (tipoPantalon == "chupin")
                    {
                        PrecioTotal = Convert.ToInt32(PrecioTotal * 0.88);

                    }
                }
            }
        }
    }
}

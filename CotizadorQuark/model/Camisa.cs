using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorQuark
{
    internal class Camisa : Prenda
    {
        protected string tipoManga;
        protected string tipoCuello;

        public override void CalcularPrecio()
        {
            base.CalcularPrecio();
            if (calidad == "premium")
            {
                if (tipoManga == "mangaCorta")
                {
                    PrecioTotal = Convert.ToInt32(PrecioTotal * 0.9);
                    PrecioTotal = Convert.ToInt32(PrecioTotal * 1.3);
                    if (tipoCuello == "cuelloMao")
                    {
                        PrecioTotal = Convert.ToInt32(PrecioTotal * 0.3 + PrecioTotal);
                        PrecioTotal = Convert.ToInt32(PrecioTotal * 1.3);
                    }
                }
            }
            else
            {
                if (tipoManga == "mangaCorta")
                {
                    PrecioTotal = Convert.ToInt32(PrecioTotal * 0.9);

                    if (tipoCuello == "cuelloMao")
                    {
                        PrecioTotal = Convert.ToInt32(PrecioTotal * 0.3 + PrecioTotal);

                    }
                }
            }

        }
    }
}

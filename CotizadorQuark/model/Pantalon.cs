using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorQuark
{
    class Pantalon : Prenda
    {
        private string pantalonTipo;

        public string PantalonTipo { get => pantalonTipo; set => pantalonTipo = value; }
        public Pantalon(string pantalonTipo, string calidad, int cantidad) : base(calidad,cantidad)
        {
           this.pantalonTipo = pantalonTipo;
        }

        
    }
    
}

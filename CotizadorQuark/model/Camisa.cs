using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorQuark
{
    class Camisa : Prenda
    {
        private string tipoManga;
        private string tipoCuello;
        public string TipoManga { get => tipoManga; set => tipoManga = value; }
        public string TipoCuello { get => tipoCuello; set => tipoCuello = value; }

        public Camisa(string tipoManga, string tipoCuello,string calidad, int cantidad) : base(calidad,cantidad)
        {
            this.tipoManga = tipoManga;
            this.tipoCuello = tipoCuello;  
        }

        
    }
    
}

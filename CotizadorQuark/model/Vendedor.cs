using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorQuark
{
    internal class Vendedor
    {
        private string nombre;
        private string apellido;
        private int codigoVendedor;

        public Vendedor(string nombre, string apellido, int codigoVendedor)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.codigoVendedor = codigoVendedor;
        }
    }
}

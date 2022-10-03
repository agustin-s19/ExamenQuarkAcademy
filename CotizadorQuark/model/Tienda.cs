using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorQuark
{
    internal class Tienda
    {
        private string nombre;
        private string direccion;
        private List<Prenda> listaPrendas;
        private List<Vendedor> vendedores;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }

        public List<Prenda> ListaPrendas { get => listaPrendas; set => listaPrendas = value; }
        public List<Vendedor> Vendedores { get => vendedores; set => vendedores = value; }


        public Tienda(string nombre, string direccion)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            listaPrendas = new List<Prenda>();
        }

        public void AgregarCamisas()
        {
            listaPrendas.Add(new Camisa("corta", "mao", "standard", 100));
            listaPrendas.Add(new Camisa("corta", "mao", "premium", 100));
            listaPrendas.Add(new Camisa("corta", "comun","standard", 150));
            listaPrendas.Add(new Camisa("corta", "comun", "premium", 150 ));

           
            listaPrendas.Add(new Camisa("larga", "mao", "standard", 75));
            listaPrendas.Add(new Camisa("larga", "mao", "premium", 75));
            listaPrendas.Add(new Camisa("larga", "comun", "standard", 175));
            listaPrendas.Add(new Camisa("larga", "comun", "premium", 175));
        }

        public void AgregarPantalones()
        {
            listaPrendas.Add(new Pantalon("chupin", "standard", 750));
            listaPrendas.Add(new Pantalon("chupin", "premium", 750));
            listaPrendas.Add(new Pantalon("normal", "standard", 250));
            listaPrendas.Add(new Pantalon("normal", "premium", 250));
        }
        public void AgregarVendedor(Vendedor vendedor)
        {
            this.vendedores.Add(vendedor);
        }
    }
}

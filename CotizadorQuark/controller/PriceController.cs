using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorQuark.controller
{
    class PriceController
    {
        private string cuelloCamisa;
        private string mangaCamisa;
        private string tipoPantalon;
        private string tipoPrenda;
        private string calidad;

       

        public string CuelloCamisa { get => cuelloCamisa; set => cuelloCamisa = value; }
        public string MangaCamisa { get => mangaCamisa; set => mangaCamisa = value; }
        public string TipoPantalon { get => tipoPantalon; set => tipoPantalon = value; }
        public string TipoPrenda { get => tipoPrenda; set => tipoPrenda = value; }
        public string Calidad { get => calidad; set => calidad = value; }






        //public void calculatePrice(Tipo tipo, Calidad calidad, Precio precio, Cantidad cantidad)
        //{

        //}

    }
}

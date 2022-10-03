using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CotizadorQuark.controller
{
    class PriceController 
    {
        private Tienda tienda;
        private Vendedor vendedor;
        private int stock = 0;
     
        List<Cotizacion> HistorialDeCotizaciones = new List<Cotizacion>();



        internal Tienda Tienda { get => tienda; set => tienda = value; }
        internal Vendedor Vendedor { get => vendedor; set => vendedor = value; }
        public int Stock { get => stock; set => stock = value; }

        // METODO PARA INICIAR TIENDA CON VENDEDOR Y STOCK DE ROPA
        public void IniciarTienda()
        {
            tienda = new Tienda("Tienda Quark", "Avenida SiempreViva");
            vendedor = new Vendedor("Miguel", "Gutierrez", 904);
            
            tienda.AgregarCamisas();
            tienda.AgregarPantalones();
        }

        public void Cotizar(Prenda prendaCotizar, ref TextBox cantidad_name, ref TextBox precioUnitario_name, ref Label label11)
        {
            try
            {
                if(prendaCotizar.Cantidad < int.Parse(cantidad_name.Text))
                {
                    MessageBox.Show("Cantidad de stock no disponible");
                }
                else
                {
                    int cantidad = int.Parse(cantidad_name.Text);
                    float precioUnitario = float.Parse(precioUnitario_name.Text);

                    if(prendaCotizar is Camisa)
                    {
                        Camisa camisuqui = (Camisa)prendaCotizar;
                        if(camisuqui.TipoManga == "corta") {
                            precioUnitario = precioUnitario * 0.90f;
                            if(camisuqui.TipoCuello == "mao")
                            {
                                precioUnitario = precioUnitario * 1.03f;
                            }
                        }else if(camisuqui.TipoCuello == "mao")
                        {
                            precioUnitario = precioUnitario * 1.03f;
                        }
                    } 
                    
                    if(prendaCotizar is Pantalon)
                    {
                        Pantalon pantaloncito = (Pantalon)prendaCotizar;
                        if(pantaloncito.PantalonTipo == "chupin")
                        {
                            precioUnitario = precioUnitario * 0.88f;
                        }

                    }
                    if(prendaCotizar.Calidad == "premium")
                    {
                        precioUnitario = precioUnitario * 1.3f;
                    }
                    string resultado = (cantidad* precioUnitario).ToString();
                    label11.Text = resultado;
                    HistorialDeCotizaciones.Add(new Cotizacion(vendedor.CodigoVendedor, prendaCotizar , cantidad, resultado));

                }
                
            }
            catch(Exception e)
            {
                MessageBox.Show("Debe ingresar cantidad y precio");
            }
        }
        public void SeleccionPrenda(RadioButton pantalon,CheckBox mangaCorta, CheckBox cuelloMao,CheckBox chupin,ref Label label6, RadioButton standard_name, ref TextBox precioUnitario_name, ref TextBox cantidad_name, ref Label label11 )
        {
            Prenda prendaCotizada;
            if(pantalon.Checked)
            {
                foreach(var i in tienda.ListaPrendas) {
                    if (i is Pantalon)
                    {
                        Pantalon pantaloncito = (Pantalon)i;
                        if (chupin.Checked)
                        {
                            if (pantaloncito.PantalonTipo == "chupin") // CHUPIN
                            {
                                if (standard_name.Checked)
                                {
                                    if (pantaloncito.Calidad == "standard") // STANDARD
                                    {
                                        stock = pantaloncito.Cantidad;
                                        prendaCotizada = pantaloncito;
                                        Cotizar(pantaloncito, ref cantidad_name, ref precioUnitario_name, ref label11);

                                    }
                                }
                                else if (!standard_name.Checked)
                                {
                                    if (pantaloncito.Calidad == "premium") // PREMIUM
                                    {
                                        stock = pantaloncito.Cantidad;
                                        prendaCotizada = pantaloncito;
                                        Cotizar(pantaloncito, ref cantidad_name, ref precioUnitario_name, ref label11);
                                    }
                                }
                              
                            }

                         
                        }
                        else
                        {
                            if (pantaloncito.PantalonTipo == "normal") // PANTALON NORMAL
                            {
                                if (standard_name.Checked)
                                {
                                    if (pantaloncito.Calidad == "standard") // STANDARD
                                    {
                                        stock = pantaloncito.Cantidad;
                                        prendaCotizada = pantaloncito;
                                        Cotizar(pantaloncito, ref cantidad_name, ref precioUnitario_name, ref label11);

                                    }
                                }
                                else if (!standard_name.Checked)
                                {
                                    if (pantaloncito.Calidad == "premium") //PREMIUM
                                    {
                                        stock = pantaloncito.Cantidad;
                                        prendaCotizada = pantaloncito;
                                        Cotizar(pantaloncito, ref cantidad_name, ref precioUnitario_name, ref label11);
                                    }
                                }
                            }
                        }
                    }    
                }
                label6.Text = stock.ToString();
            }
            else
            {
                foreach(var i in tienda.ListaPrendas)
                {
                    if(i is Camisa)
                    {
                        Camisa camisuqui = (Camisa)i;
                        if (mangaCorta.Checked && cuelloMao.Checked)
                        {
                            if(camisuqui.TipoManga == "corta" && camisuqui.TipoCuello == "mao") //CUELLO MAO Y MANGA CORTA
                            {
                                if (standard_name.Checked)
                                {
                                    if(camisuqui.Calidad == "standard") // STANDARD
                                    {
                                        stock = camisuqui.Cantidad;
                                        prendaCotizada = camisuqui;
                                        Cotizar(camisuqui, ref cantidad_name, ref precioUnitario_name, ref label11);
                                    }
                                }else if (!standard_name.Checked)
                                {
                                    if(camisuqui.Calidad == "premium") // PREMIUM
                                    {
                                        
                                        stock =camisuqui.Cantidad;
                                        prendaCotizada = camisuqui;
                                        Cotizar(camisuqui,ref cantidad_name, ref precioUnitario_name, ref label11);
                                       
                                    }
                                }
                            }
                            
                        }else if(mangaCorta.Checked && !cuelloMao.Checked) // MANGA CORTA Y CUELLO COMUN
                        {
                            if(camisuqui.TipoManga == "corta" && camisuqui.TipoCuello == "comun") 
                            {
                                if(standard_name.Checked)
                                {
                                    if (camisuqui.Calidad == "standard") // STANDARD
                                    {
                                        stock = camisuqui.Cantidad;
                                        prendaCotizada = camisuqui;
                                        Cotizar(camisuqui, ref cantidad_name, ref precioUnitario_name, ref label11);
                                    }
                                }else if (!standard_name.Checked)
                                {
                                    if (camisuqui.Calidad == "premium") // PREMIUM
                                    {
                                        stock = camisuqui.Cantidad;
                                        prendaCotizada = camisuqui;
                                        Cotizar(camisuqui, ref cantidad_name, ref precioUnitario_name, ref label11);
                                    }
                                }
                            }
                        }else if(!mangaCorta.Checked && cuelloMao.Checked) // MANGA LARGA Y CUELLO MAO
                        {
                            if(camisuqui.TipoManga == "larga" && camisuqui.TipoCuello == "mao")
                            {
                                if (standard_name.Checked)
                                {
                                    if (camisuqui.Calidad == "standard") // STANDARD
                                    {
                                        stock = camisuqui.Cantidad;
                                        prendaCotizada = camisuqui;
                                        Cotizar(camisuqui, ref cantidad_name, ref precioUnitario_name, ref label11);
                                    }
                                }
                                else if (!standard_name.Checked)
                                {
                                    if (camisuqui.Calidad == "premium") // PREMIUM
                                    {
                                        stock = camisuqui.Cantidad;
                                        prendaCotizada = camisuqui;
                                        Cotizar(camisuqui, ref cantidad_name, ref precioUnitario_name, ref label11);
                                    }
                                }
                            }
                        }else if(!mangaCorta.Checked && !cuelloMao.Checked) // MANGA LARGA Y CUELLO COMUN
                        {
                            if(camisuqui.TipoManga == "larga" && camisuqui.TipoCuello == "comun")
                            {
                                if (standard_name.Checked)
                                {
                                    if (camisuqui.Calidad == "standard") // STANDARD
                                    {
                                        stock = camisuqui.Cantidad;
                                        prendaCotizada = camisuqui;
                                        Cotizar(camisuqui, ref cantidad_name, ref precioUnitario_name, ref label11);
                                    }
                                }
                                else if (!standard_name.Checked)
                                {
                                    if (camisuqui.Calidad == "premium") // PREMIUM
                                    {
                                        stock = camisuqui.Cantidad;
                                        prendaCotizada = camisuqui;
                                        Cotizar(camisuqui, ref cantidad_name, ref precioUnitario_name, ref label11);
                                    }
                                }
                            }

                        }
                        label6.Text = stock.ToString();
                    }
                }
            }
          
        }
        public string MostrarHistorial(string historial)
        {

            foreach(Cotizacion i in HistorialDeCotizaciones)
            {
                historial += "\nId de Cotización:" + i.NumeroId + "\nFecha y Hora: " + i.Fecha + "\nID Vendedor: "+ i.CodigoVendedor + "\nNombre: " + vendedor.Nombre + "\nApellido: "+ vendedor.Apellido + "\nPrenda: " + (i.PrendaCotizada is Camisa ? "Camisa" : "Pantalon")+"\nCantidad de prendas: "+ i.CantidadUnidadesCotizadas + "\nMonto: " +i.PrecioTotal + "\n";
            }
            return historial;
        }






       

    }
}

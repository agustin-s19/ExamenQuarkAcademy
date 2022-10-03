using CotizadorQuark.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CotizadorQuark
{
    public partial class Vista : Form
    {
        PriceController priceController;
        public Vista()
        {
            InitializeComponent();
        }

        public void Vista_Load(object sender, EventArgs e)
        {
            priceController = new PriceController();
            priceController.IniciarTienda();
            label1.Text = priceController.Tienda.Nombre.ToString();
            label2.Text = priceController.Tienda.Direccion.ToString();
            label3.Text = priceController.Vendedor.Nombre.ToString() + " " + priceController.Vendedor.Apellido.ToString();
            label4.Text = "| " + priceController.Vendedor.CodigoVendedor.ToString();
            


        }

        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            chupin.Enabled = false;
            mangaCorta.Enabled = true;
            cuelloMao.Enabled = true;
            chupin.Checked = false;
            button1.Enabled = checkValidForm();
        }

        private void pantalon_CheckedChanged(object sender, EventArgs e)
        {
            chupin.Enabled = true;
            mangaCorta.Enabled = false;
            cuelloMao.Enabled = false;
            mangaCorta.Checked = false;
            cuelloMao.Checked = false;
            button1.Enabled = checkValidForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            priceController.SeleccionPrenda(pantalon,mangaCorta,cuelloMao,chupin,ref label6,standard_name,ref precioUnitario_name,ref cantidad_name, ref label11);
          
            
          
        }

        private bool checkValidForm()
        {
            if (standard_name.Checked || premium.Checked) {
                if (!cantidad_name.Text.Equals("") && !precioUnitario_name.Equals("") && camisa.Checked || !cantidad_name.Text.Equals("") && !precioUnitario_name.Equals("") && pantalon.Checked)
                {
                    return true;
                }
                else
                {
                    return false;

                }
            }
            else
            {
                return false;
            }
        }

        private void cantidad_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = checkValidForm();
        }

        private void precioUnitario_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = checkValidForm();

        }

        private void mangaCorta_CheckedChanged(object sender, EventArgs e)
        {
           
            
            button1.Enabled = checkValidForm();
            //priceControl.MangaCamisa = "corta";
            
            

        }

        private void cuelloMao_CheckedChanged(object sender, EventArgs e)
        {
          
            
            button1.Enabled = checkValidForm();
            //priceControl.CuelloCamisa = "cuelloMao";

        }

        private void chupin_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = checkValidForm();
            //priceControl.tipoPantalon = "chupin";
        }

        private void standart_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = checkValidForm();
            //priceControl.calidad = "standart";
          
        }

        private void premium_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = checkValidForm();
            //priceControl.calidad = "premium";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            string listado = @"
                 Historial de Ventas
-------------------------------------------------";
            MessageBox.Show(priceController.MostrarHistorial(listado));
        }
    }
}

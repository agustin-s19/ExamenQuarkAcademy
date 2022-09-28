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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            chupin.Enabled = false;
            mangaCorta.Enabled = true;
            cuelloMao.Enabled = true;
            chupin.Checked = false;
        }

        private void pantalon_CheckedChanged(object sender, EventArgs e)
        {
            chupin.Enabled = true;
            mangaCorta.Enabled = false;
            cuelloMao.Enabled = false;
            mangaCorta.Checked = false;
            cuelloMao.Checked = false;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            PriceController priceController = new PriceController();
            int resultado = priceController.calculatePrice(this);
            label11.Text = resultado.ToString();
        }

        private bool checkValidForm()
        {
            if (standard.Checked || premium.Checked) {
                if (!cantidad.Text.Equals("") && !precioUnitario.Equals("") && camisa.Checked && mangaCorta.Checked || !cantidad.Text.Equals("") && !precioUnitario.Equals("") && camisa.Checked && cuelloMao.Checked || !cantidad.Text.Equals("") && !precioUnitario.Equals("") && pantalon.Checked && chupin.Checked)
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
           
            cuelloMao.Checked = false;
            button1.Enabled = checkValidForm();

        }

        private void cuelloMao_CheckedChanged(object sender, EventArgs e)
        {
          
            mangaCorta.Checked = false;
            button1.Enabled = checkValidForm();

        }

        private void chupin_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = checkValidForm();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = checkValidForm();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = checkValidForm();
        }
    }
}

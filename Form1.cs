using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULO_IVA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
               
        private void BtnCalbular_Click(object sender, EventArgs e)
        {
            double precio = double.Parse(TxtPrecio.Text);
            double totalPagar, iva;
            iva = precio * 0.19;
            totalPagar= precio + iva;
            Lblva.Visible = true;
            Lblva.Text = Convert.ToString(iva);
            LblTotalPagar.Visible = true;
            LblTotalPagar.Text = Convert.ToString(totalPagar);

         
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtPrecio.Text = String.Empty;
            TxtPrecio.Focus();
            Lblva.Visible = false;
            LblTotalPagar.Visible = false;


           }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

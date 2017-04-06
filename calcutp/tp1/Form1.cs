using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp1
{
    public partial class Form1 : Form
    {
        public Form1()
            {
                InitializeComponent();
            }
        private void txtNumero1_TextChanged(object sender, EventArgs e)
            {
                Numero numero1 = new Numero(txtNumero1.Text);
            }
        private void txtNumero2_TextChanged(object sender, EventArgs e)
            {
                Numero numero2 = new Numero(txtNumero2.Text);
            }
        private void btnOperar_Click(object sender, EventArgs e)
            {
                double resultado;
                Numero numeroA = new Numero(txtNumero1.Text);
                Numero numeroB = new Numero(txtNumero2.Text);

                resultado = Calculadora.operar(numeroA, numeroB, cmbOperar.Text);
                lblResultado.Text = resultado.ToString();            
            }

        private void btnLimpiar_Click(object sender, EventArgs e)
            {
                this.txtNumero1.Text = "";
                this.txtNumero2.Text = "";
                this.cmbOperar.Text = "";
                this.lblResultado.Text = "0";
            }

    }
}

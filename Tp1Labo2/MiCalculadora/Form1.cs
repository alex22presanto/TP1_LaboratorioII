using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void BtnOperar_Click(object sender, EventArgs e)
        {
            double resultado = 0;
            resultado =Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text);
            
            lblResultado.Text =Convert.ToString(resultado);
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private static double Operar(string numero1, string numero2, string operador)
        {
            Numero num1 = new Numero(numero1);
            Numero num2 = new Numero(numero2);
            return Calculadora.Operar(num1, num2, operador);

        }

        private void Limpiar()
        {
            this.txtNumero1.Text = "";
            this.txtNumero2.Text = "";
            this.cmbOperador.Text = "";
            this.lblResultado.Text = "";
        }

        private void BtnConvertirABinario_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = Numero.DecimalBinario(txtNumero1.Text);
        }

        private void BtnConvertirADecimal_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = Numero.BinarioDecimal(txtNumero1.Text);
        }
    }
}

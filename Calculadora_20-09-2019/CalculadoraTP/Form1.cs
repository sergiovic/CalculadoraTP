using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraTP
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            int N1;
            int N2;
            int soma;
            string rsoma;
            try
            {
                N1 = Convert.ToInt16(txtN1.Text);
                N2 = Convert.ToInt16(txtN2.Text);
                soma = N1 + N2;
                rsoma = Convert.ToString(soma);
                txtResultado.Text = rsoma;
            }
            catch(FormatException)
            {
                MessageBox.Show("Formatação Errada.");
            }

        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            int N1;
            int N2;
            int subtrai;
            string rsubtrai;
            try
            {
                N1 = Convert.ToInt16(txtN1.Text);
                N2 = Convert.ToInt16(txtN2.Text);
                subtrai = N1 - N2;
                rsubtrai = Convert.ToString(subtrai);
                txtResultado.Text = rsubtrai;
            }
            catch (FormatException)
            {
                MessageBox.Show("Formatação Errada.");
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            int N1;
            int N2;
            int multiplica;
            string rmultiplica;
            try
            {
                N1 = Convert.ToInt16(txtN1.Text);
                N2 = Convert.ToInt16(txtN2.Text);
                multiplica = N1 * N2;
                rmultiplica = Convert.ToString(multiplica);
                txtResultado.Text = rmultiplica;
            }
            catch (FormatException)
            {
                MessageBox.Show("Formatação Errada.");
            }
        }

        private void btnDividit_Click(object sender, EventArgs e)
        {
            double N1;
            double N2;
            double divide;
            string rdivide;
            try
            {
                N1 = Convert.ToDouble(txtN1.Text);
                N2 = Convert.ToDouble(txtN2.Text);
                divide = N1 / N2;
                rdivide = Convert.ToString(divide);
                txtResultado.Text = rdivide;
            }
            catch(DivideByZeroException)
            {
                MessageBox.Show("Não é possível dividir por Zero");
            }
            catch(FormatException)
            {
                MessageBox.Show("Formatação Errada.");
            }
}

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtN1.Text = "";
            txtN2.Text = "";
            txtResultado.Text = "";
        }

        private void btnConcatenar_Click(object sender, EventArgs e)
        {
            string N1;
            string N2;
            string concatena;
            N1 = Convert.ToString(txtN1.Text);
            N2 = Convert.ToString(txtN2.Text);
            concatena = N1 + N2;
            txtResultado.Text = concatena;
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            double N1;
            double N2;
            double raiz;
            string rraiz;
            try
            {
                N1 = Convert.ToDouble(txtN1.Text);
                raiz = Math.Sqrt(N1);
                rraiz = Convert.ToString(raiz);
                txtResultado.Text = rraiz;
            }
            catch (FormatException)
            {
                MessageBox.Show("Formatação Errada.");
            }
        }

        private void btnEleva_Click(object sender, EventArgs e)
        {
            double N1;
            double N2;
            double eleva;
            string releva;
            try
            {
                N1 = Convert.ToDouble(txtN1.Text);
                N2 = Convert.ToDouble(txtN2.Text);
                eleva = Math.Pow(N1, N2);
                releva = Convert.ToString(eleva);
                txtResultado.Text = releva;
            }
            catch (FormatException)
            {
                MessageBox.Show("Formatação Errada.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrianguloUC12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // Declaração das variáveis 
            double b = 0;
            double h = 0;
            double resultado = 0;

            // Se ambos os campos forem diferentes de " " as variaveis receberão o texto
            if (txtBase.Text != "" && txtAltura.Text != "")
            {
                b = double.Parse(txtBase.Text);
                h = double.Parse(txtAltura.Text);
            }
            // a operação para descobrir a área do triângulo
            resultado = ((b * h)/2);

            // O resultado da operação sendo trocada de double para string para que haja sua apresentação
            lblresultado.Text = resultado.ToString();


        }
    }
}

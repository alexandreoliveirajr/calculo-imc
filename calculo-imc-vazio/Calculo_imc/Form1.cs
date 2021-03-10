using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_imc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            /*Declaração de variáveis
             * variável recebe conteúdo do textbox*/
            double peso, altura, imc;
            peso = Convert.ToDouble(txtPeso.Text);
            altura = Convert.ToDouble(txtAltura.Text);
            imc = peso / (altura * altura);
            txtImc.Text = imc.ToString("0.00");
            if (imc < 19.49)
                MessageBox.Show("SITUAÇÃO: Você está abaixo do Peso", "Cálculo de IMC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (imc < 24.99)
                MessageBox.Show("SITUAÇÃO: Você está com Peso dentro da Normalidade", "Cálculo de IMC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (imc < 29.99)
                MessageBox.Show("SITUAÇÃO: Você está acima do Peso", "Cálculo de IMC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (imc < 34.99)
                MessageBox.Show("ATENÇÃO! Você está com Obesidade Grau I", "Cálculo de IMC", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else if (imc < 39.99)
                MessageBox.Show("ATENÇÃO! Você está com Obesidade Grau II (severa)", "Cálculo de IMC", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else
                MessageBox.Show("ATENÇAÕ! Você está com Obesidade Grau III (mórbida)", "Cálculo de IMC", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPeso.Text = "";
            txtAltura.Text = "";
            txtImc.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

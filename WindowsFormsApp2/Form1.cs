using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class frmSoma : Form
    {
        public frmSoma()
        {
            InitializeComponent();
        }

        private void btnInteiros_Click(object sender, EventArgs e)
        {

            //Declaração de variaveis

            int a, b, soma;

            //entrada de dados

            a = Int32.Parse(txtA.Text);
            b = Int32.Parse(txtB.Text);

            //processamento

            soma = a + b;

            //saida de resultados

            txtResultado.Text = soma.ToString();
        }

        private void btnReais_Click(object sender, EventArgs e)
        {
            // declaração de variaveis
            double a, b, soma
            =
            //entrada de dados
            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);

            //processamento 
            soma = a + b;

            //saida de dados
            txtResultado.Text = soma.ToString();

        }

    }

}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matriz2
{
    public partial class frmMatriz : Form
    {

        double[,] matriz = new double[3, 3];
        int i = 0;
        int j = 0;

        public frmMatriz()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                matriz[i, j] = Double.Parse(txtNumerosInseridos.Text);
                j++;
                if (j == 3)
                {
                    i++;
                    j = 0;
                }
                txtNumerosInseridos.Text = "";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (i = 0; i <= 2; i++)
            {
                for (j = 0; j <= 2; j++)
                {
                    txtNumerosDaMatriz.Text += matriz[i, j].ToString() + " ";
                }
                txtNumerosDaMatriz.Text += Environment.NewLine;
            }
        }

        private void btnMaiorValor_Click(object sender, EventArgs e)
        {
            double maiorValor = int.MinValue;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j] > maiorValor)
                    {
                        maiorValor = matriz[i, j];
                    }
                }
            }
            MessageBox.Show("O maior valor na matriz é: " + maiorValor, "Maior Valor");
        }
    }
}

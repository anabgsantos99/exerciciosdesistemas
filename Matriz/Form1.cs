using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matriz
{
    public partial class frmMatriz : Form
    {
        double[,] matriz = new double[3, 3];
        int i = 0;
        int j =0;

        public frmMatriz()
        {
            InitializeComponent();
        }

        private void btnGerarMatriz_Click(object sender, EventArgs e)
        {
            for (i = 0; i<= 2; i++)
            {
                for(j=0; j<=2; j++)
                {
                    txtMatriz.Text += matriz[i, j].ToString() + " ";
                }
                txtMatriz.Text += Environment.NewLine;
            }
        }


        private void btnMaiorNumero_Click(object sender, EventArgs e)
        {

        }

        private void txtNumerosInseridos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
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
    }
}

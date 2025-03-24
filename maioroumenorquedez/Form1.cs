using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maioroumenorquedez
{
    public partial class frmMaiorOuMenorQueDez : Form
    {
        public frmMaiorOuMenorQueDez()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valor = int.Parse(txtValor.Text);

            if(valor > 10)
            {
                MessageBox.Show("O número: " + valor + " é maior que 10", "Maior ou menor?",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("O número: " + valor + " é menor que 10", "Maior ou menor?", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}

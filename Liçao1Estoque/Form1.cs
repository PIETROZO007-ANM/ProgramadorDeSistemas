using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Liçao1Estoque
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
                      

        private void btnVerificar_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(txtValorEstoque.Text, out int valor))
            {
                MessageBox.Show("Insira apenas números!");
                txtValorEstoque.Focus();
                txtValorEstoque.SelectAll();
                return;
            }

            if (valor >= 5)
            {
                MessageBox.Show("Estoque suficiente.");
            }
            else
            {
                MessageBox.Show("Alerta: Baixo estoque. Por favor, reabasteça este produto.");
            }

        }
    }
}

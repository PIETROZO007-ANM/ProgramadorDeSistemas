using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tabuadacomloop
{
    public partial class frmTabuadaLoop : Form
    {
        public frmTabuadaLoop()
        {
            InitializeComponent();
        }

        private void btnExecultarTabuada_Click(object sender, EventArgs e)
        {
            int numeroInserido = Convert.ToInt32(txtNúmero.Text);

            //adicionar a tabuada para número inserido
            for (int i = 1; i < 11; i++)
            {
                lstTabuada.Items.Add(numeroInserido + "x" + i + " = " + (numeroInserido * i));
            }

        }
    }
}

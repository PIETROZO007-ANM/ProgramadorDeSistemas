using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TelaLogin
{
    public partial class FrmLogin : Form
    {
        string userCorreto = "Pietrozo007@gmail.com";
        string passwordCorreto = "admin";
        int tentativas = 0;
        int maxTentativas = 3;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            string user = txtLogin.Text;
            string password = txtSenha.Text;

            

            while (tentativas < maxTentativas)
            {
                if (user == userCorreto && password == passwordCorreto)
                {
                    MessageBox.Show("Login bem-sucedido!");
                    break;
                }
                else
                {
                    tentativas++;
                    MessageBox.Show("Senha incorreta. Tentativas restantes: " + (maxTentativas - tentativas));
                    break;
                }
            }

            if (tentativas == maxTentativas)
            {
                MessageBox.Show("Conta bloqueada por excesso de tentativas.");
                btnLogar.Enabled = false;
            }
            if (txtLogin.Text == userCorreto & txtSenha.Text == passwordCorreto)
            {
                Form form2 = new Form2();
                form2.Show();
                this.Hide();
            }
        }
    }
}


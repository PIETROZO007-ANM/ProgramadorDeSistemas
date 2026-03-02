using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoDiaDaSemana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
         

        private void btnConverter_Click_1(object sender, EventArgs e)
        {
            try
            {
                int diaDigitado = Convert.ToInt32(txtNumeroInserido.Text);
                lblResultado.Text = GetDiaSem(diaDigitado);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Por favor Digite um número valido. erro" + ex.Message);
            }

        }
        private string GetDiaSem(int dia)
        {
            string diaDigitado = "";

            switch (dia)
            {
                case 1:
                    diaDigitado = "Domingo!";
                    break;
                case 2:
                    diaDigitado = "Segunda-Feira!";
                    break;
                case 3:
                    diaDigitado = "Terça-Feira";
                    break;
                case 4:
                    diaDigitado = "Quarta-Feira";
                    break;
                case 5:
                    diaDigitado = "Quinta-Feira";
                    break;
                case 6:
                    diaDigitado = "Sexta-Feira";
                    break;
                case 7:
                    diaDigitado = "Sábado";
                    break;
                default:
                    diaDigitado = "Dia Invalido(use 1 a 7)";
                    break;
            }
            return diaDigitado;
        }
    }   
}
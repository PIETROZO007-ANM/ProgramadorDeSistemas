using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace CalculadoraMatrizes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Fazendo uma matriz de 2x2
        //declarando a matriz
        int[,] matriz;
        private void btnCarregar_Click(object sender, EventArgs e)
        {
            matriz = new int[2, 2];

            //criando dois for para o contador da fila e colunas

            dtgMatriz.ColumnCount = 2;
            dtgMatriz.RowCount = 2;
            dtgResposta.RowCount = 2;
            dtgResposta.ColumnCount = 2;

            for (int fila = 0; fila < 2; fila++)
            {
                for (int coluna = 0; coluna < 2; coluna++)
                {
                    matriz[fila, coluna] = int.Parse(Interaction.InputBox("Ingressando dados"));
                }
            }
            for (int  fila = 0; fila < 2; fila++)
            {
                for(int coluna = 0; coluna < 2; coluna++)
                {
                    dtgMatriz.Rows[fila].Cells[coluna].Value = matriz[fila, coluna];
                }
            }
        }

        private void btnResposta_Click(object sender, EventArgs e)
        {
            
                
            for (int fila = 0; fila < 2; fila++)
            {
                for (int coluna = 0; coluna < 2; coluna++)
                {
                    dtgResposta.Rows[fila].Cells[coluna].Value = matriz[coluna, fila];

                }
            }
        }
    }
}

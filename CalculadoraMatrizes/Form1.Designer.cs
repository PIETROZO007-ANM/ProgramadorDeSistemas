namespace CalculadoraMatrizes
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCarregar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnResposta = new System.Windows.Forms.Button();
            this.dtgMatriz = new System.Windows.Forms.DataGridView();
            this.dtgResposta = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMatriz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgResposta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCarregar
            // 
            this.btnCarregar.BackColor = System.Drawing.Color.Plum;
            this.btnCarregar.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregar.Location = new System.Drawing.Point(12, 89);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(141, 74);
            this.btnCarregar.TabIndex = 0;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = false;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(396, 221);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnResposta
            // 
            this.btnResposta.BackColor = System.Drawing.Color.Plum;
            this.btnResposta.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResposta.Location = new System.Drawing.Point(12, 185);
            this.btnResposta.Name = "btnResposta";
            this.btnResposta.Size = new System.Drawing.Size(141, 74);
            this.btnResposta.TabIndex = 2;
            this.btnResposta.Text = "Resposta";
            this.btnResposta.UseVisualStyleBackColor = false;
            this.btnResposta.Click += new System.EventHandler(this.btnResposta_Click);
            // 
            // dtgMatriz
            // 
            this.dtgMatriz.BackgroundColor = System.Drawing.Color.Ivory;
            this.dtgMatriz.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMatriz.Location = new System.Drawing.Point(170, 89);
            this.dtgMatriz.Name = "dtgMatriz";
            this.dtgMatriz.Size = new System.Drawing.Size(300, 170);
            this.dtgMatriz.TabIndex = 3;
            // 
            // dtgResposta
            // 
            this.dtgResposta.BackgroundColor = System.Drawing.Color.Ivory;
            this.dtgResposta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgResposta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgResposta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgResposta.Location = new System.Drawing.Point(476, 89);
            this.dtgResposta.Name = "dtgResposta";
            this.dtgResposta.Size = new System.Drawing.Size(300, 170);
            this.dtgResposta.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(868, 378);
            this.Controls.Add(this.dtgResposta);
            this.Controls.Add(this.dtgMatriz);
            this.Controls.Add(this.btnResposta);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCarregar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtgMatriz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgResposta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnResposta;
        private System.Windows.Forms.DataGridView dtgMatriz;
        private System.Windows.Forms.DataGridView dtgResposta;
    }
}


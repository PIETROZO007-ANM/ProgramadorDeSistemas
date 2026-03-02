namespace Liçao1Estoque
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblQuantEstoque = new System.Windows.Forms.Label();
            this.txtValorEstoque = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(11, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(333, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Gerenciamento de Estoque";
            // 
            // lblQuantEstoque
            // 
            this.lblQuantEstoque.AutoSize = true;
            this.lblQuantEstoque.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantEstoque.Location = new System.Drawing.Point(12, 159);
            this.lblQuantEstoque.Name = "lblQuantEstoque";
            this.lblQuantEstoque.Size = new System.Drawing.Size(244, 23);
            this.lblQuantEstoque.TabIndex = 1;
            this.lblQuantEstoque.Text = "Quantidade em Estoque:";
            // 
            // txtValorEstoque
            // 
            this.txtValorEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorEstoque.Location = new System.Drawing.Point(255, 159);
            this.txtValorEstoque.Name = "txtValorEstoque";
            this.txtValorEstoque.Size = new System.Drawing.Size(89, 29);
            this.txtValorEstoque.TabIndex = 2;
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnVerificar.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificar.Location = new System.Drawing.Point(133, 292);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(87, 56);
            this.btnVerificar.TabIndex = 3;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = false;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(352, 394);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txtValorEstoque);
            this.Controls.Add(this.lblQuantEstoque);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblQuantEstoque;
        private System.Windows.Forms.TextBox txtValorEstoque;
        private System.Windows.Forms.Button btnVerificar;
    }
}


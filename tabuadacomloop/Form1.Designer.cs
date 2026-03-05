namespace tabuadacomloop
{
    partial class frmTabuadaLoop
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
            this.panelFundo = new System.Windows.Forms.Panel();
            this.panelEsquerda = new System.Windows.Forms.Panel();
            this.panelDireita = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNúmero = new System.Windows.Forms.TextBox();
            this.btnExecultarTabuada = new System.Windows.Forms.Button();
            this.lstTabuada = new System.Windows.Forms.ListBox();
            this.panelFundo.SuspendLayout();
            this.panelEsquerda.SuspendLayout();
            this.panelDireita.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFundo
            // 
            this.panelFundo.BackColor = System.Drawing.Color.Cyan;
            this.panelFundo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelFundo.Controls.Add(this.panelDireita);
            this.panelFundo.Controls.Add(this.panelEsquerda);
            this.panelFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFundo.Location = new System.Drawing.Point(0, 0);
            this.panelFundo.Name = "panelFundo";
            this.panelFundo.Size = new System.Drawing.Size(801, 449);
            this.panelFundo.TabIndex = 0;
            // 
            // panelEsquerda
            // 
            this.panelEsquerda.BackColor = System.Drawing.Color.LightPink;
            this.panelEsquerda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelEsquerda.Controls.Add(this.lstTabuada);
            this.panelEsquerda.Location = new System.Drawing.Point(39, 37);
            this.panelEsquerda.Name = "panelEsquerda";
            this.panelEsquerda.Size = new System.Drawing.Size(323, 379);
            this.panelEsquerda.TabIndex = 0;
            // 
            // panelDireita
            // 
            this.panelDireita.BackColor = System.Drawing.Color.LightPink;
            this.panelDireita.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelDireita.Controls.Add(this.btnExecultarTabuada);
            this.panelDireita.Controls.Add(this.txtNúmero);
            this.panelDireita.Controls.Add(this.label1);
            this.panelDireita.Location = new System.Drawing.Point(434, 37);
            this.panelDireita.Name = "panelDireita";
            this.panelDireita.Size = new System.Drawing.Size(323, 378);
            this.panelDireita.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insira um Número";
            // 
            // txtNúmero
            // 
            this.txtNúmero.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNúmero.Location = new System.Drawing.Point(37, 66);
            this.txtNúmero.Name = "txtNúmero";
            this.txtNúmero.Size = new System.Drawing.Size(248, 62);
            this.txtNúmero.TabIndex = 1;
            this.txtNúmero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnExecultarTabuada
            // 
            this.btnExecultarTabuada.BackColor = System.Drawing.Color.Cyan;
            this.btnExecultarTabuada.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnExecultarTabuada.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecultarTabuada.ForeColor = System.Drawing.Color.Black;
            this.btnExecultarTabuada.Location = new System.Drawing.Point(37, 208);
            this.btnExecultarTabuada.Name = "btnExecultarTabuada";
            this.btnExecultarTabuada.Size = new System.Drawing.Size(247, 134);
            this.btnExecultarTabuada.TabIndex = 2;
            this.btnExecultarTabuada.Text = "Execultar Tabuada";
            this.btnExecultarTabuada.UseVisualStyleBackColor = false;
            this.btnExecultarTabuada.Click += new System.EventHandler(this.btnExecultarTabuada_Click);
            // 
            // lstTabuada
            // 
            this.lstTabuada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTabuada.FormattingEnabled = true;
            this.lstTabuada.ItemHeight = 24;
            this.lstTabuada.Location = new System.Drawing.Point(15, 16);
            this.lstTabuada.Name = "lstTabuada";
            this.lstTabuada.Size = new System.Drawing.Size(290, 340);
            this.lstTabuada.TabIndex = 0;
            // 
            // frmTabuadaLoop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 449);
            this.Controls.Add(this.panelFundo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmTabuadaLoop";
            this.Text = "Tabuada com Loop";
            this.panelFundo.ResumeLayout(false);
            this.panelEsquerda.ResumeLayout(false);
            this.panelDireita.ResumeLayout(false);
            this.panelDireita.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFundo;
        private System.Windows.Forms.Panel panelDireita;
        private System.Windows.Forms.Panel panelEsquerda;
        private System.Windows.Forms.Button btnExecultarTabuada;
        private System.Windows.Forms.TextBox txtNúmero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstTabuada;
    }
}


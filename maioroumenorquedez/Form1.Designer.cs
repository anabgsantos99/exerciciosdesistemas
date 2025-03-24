
namespace maioroumenorquedez
{
    partial class frmMaiorOuMenorQueDez
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
            this.pnlTítulo = new System.Windows.Forms.Panel();
            this.lblTítulo = new System.Windows.Forms.Label();
            this.lblDigiteValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.pnlTítulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTítulo
            // 
            this.pnlTítulo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlTítulo.Controls.Add(this.lblTítulo);
            this.pnlTítulo.Location = new System.Drawing.Point(1, 1);
            this.pnlTítulo.Name = "pnlTítulo";
            this.pnlTítulo.Size = new System.Drawing.Size(525, 101);
            this.pnlTítulo.TabIndex = 0;
            // 
            // lblTítulo
            // 
            this.lblTítulo.AutoSize = true;
            this.lblTítulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTítulo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTítulo.Location = new System.Drawing.Point(118, 32);
            this.lblTítulo.Name = "lblTítulo";
            this.lblTítulo.Size = new System.Drawing.Size(307, 37);
            this.lblTítulo.TabIndex = 0;
            this.lblTítulo.Text = "É maior ou menor?";
            // 
            // lblDigiteValor
            // 
            this.lblDigiteValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigiteValor.Location = new System.Drawing.Point(191, 128);
            this.lblDigiteValor.Name = "lblDigiteValor";
            this.lblDigiteValor.Size = new System.Drawing.Size(126, 23);
            this.lblDigiteValor.TabIndex = 0;
            this.lblDigiteValor.Text = "Digite um valor:";
            this.lblDigiteValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtValor.Location = new System.Drawing.Point(195, 154);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(122, 26);
            this.txtValor.TabIndex = 1;
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVerificar.FlatAppearance.BorderSize = 0;
            this.btnVerificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVerificar.Location = new System.Drawing.Point(195, 180);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(122, 31);
            this.btnVerificar.TabIndex = 2;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = false;
            this.btnVerificar.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMaiorOuMenorQueDez
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(526, 265);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblDigiteValor);
            this.Controls.Add(this.pnlTítulo);
            this.Name = "frmMaiorOuMenorQueDez";
            this.Text = "É maior ou menor?";
            this.pnlTítulo.ResumeLayout(false);
            this.pnlTítulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTítulo;
        private System.Windows.Forms.Label lblTítulo;
        private System.Windows.Forms.Label lblDigiteValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnVerificar;
    }
}


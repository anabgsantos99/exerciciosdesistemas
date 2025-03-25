
namespace Matriz
{
    partial class frmMatriz
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
            this.panelTopo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtNumerosInseridos = new System.Windows.Forms.TextBox();
            this.lblInserirNumeros = new System.Windows.Forms.Label();
            this.txtMatriz = new System.Windows.Forms.TextBox();
            this.txtMaiorNumero = new System.Windows.Forms.TextBox();
            this.btnMaiorNumero = new System.Windows.Forms.Button();
            this.btnGerarMatriz = new System.Windows.Forms.Button();
            this.panelTopo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopo
            // 
            this.panelTopo.BackColor = System.Drawing.Color.Red;
            this.panelTopo.Controls.Add(this.lblTitulo);
            this.panelTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopo.Location = new System.Drawing.Point(0, 0);
            this.panelTopo.Name = "panelTopo";
            this.panelTopo.Size = new System.Drawing.Size(416, 100);
            this.panelTopo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(109, 42);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(202, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Matriz Bidimensional";
            // 
            // txtNumerosInseridos
            // 
            this.txtNumerosInseridos.BackColor = System.Drawing.Color.MistyRose;
            this.txtNumerosInseridos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumerosInseridos.ForeColor = System.Drawing.Color.Black;
            this.txtNumerosInseridos.Location = new System.Drawing.Point(111, 160);
            this.txtNumerosInseridos.Name = "txtNumerosInseridos";
            this.txtNumerosInseridos.Size = new System.Drawing.Size(100, 26);
            this.txtNumerosInseridos.TabIndex = 1;
            this.txtNumerosInseridos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumerosInseridos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumerosInseridos_KeyPress);
            // 
            // lblInserirNumeros
            // 
            this.lblInserirNumeros.AutoSize = true;
            this.lblInserirNumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInserirNumeros.Location = new System.Drawing.Point(107, 127);
            this.lblInserirNumeros.Name = "lblInserirNumeros";
            this.lblInserirNumeros.Size = new System.Drawing.Size(208, 20);
            this.lblInserirNumeros.TabIndex = 3;
            this.lblInserirNumeros.Text = "Insira os números da matriz:";
            // 
            // txtMatriz
            // 
            this.txtMatriz.BackColor = System.Drawing.Color.White;
            this.txtMatriz.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatriz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatriz.Location = new System.Drawing.Point(133, 208);
            this.txtMatriz.Multiline = true;
            this.txtMatriz.Name = "txtMatriz";
            this.txtMatriz.Size = new System.Drawing.Size(156, 135);
            this.txtMatriz.TabIndex = 0;
            this.txtMatriz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMaiorNumero
            // 
            this.txtMaiorNumero.BackColor = System.Drawing.Color.White;
            this.txtMaiorNumero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaiorNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaiorNumero.ForeColor = System.Drawing.Color.Red;
            this.txtMaiorNumero.Location = new System.Drawing.Point(160, 401);
            this.txtMaiorNumero.Name = "txtMaiorNumero";
            this.txtMaiorNumero.Size = new System.Drawing.Size(100, 19);
            this.txtMaiorNumero.TabIndex = 4;
            this.txtMaiorNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnMaiorNumero
            // 
            this.btnMaiorNumero.BackColor = System.Drawing.Color.Red;
            this.btnMaiorNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaiorNumero.Location = new System.Drawing.Point(111, 349);
            this.btnMaiorNumero.Name = "btnMaiorNumero";
            this.btnMaiorNumero.Size = new System.Drawing.Size(200, 32);
            this.btnMaiorNumero.TabIndex = 5;
            this.btnMaiorNumero.Text = "Verificar maior número?";
            this.btnMaiorNumero.UseVisualStyleBackColor = false;
            this.btnMaiorNumero.Click += new System.EventHandler(this.btnMaiorNumero_Click);
            // 
            // btnGerarMatriz
            // 
            this.btnGerarMatriz.BackColor = System.Drawing.Color.Red;
            this.btnGerarMatriz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarMatriz.ForeColor = System.Drawing.Color.Black;
            this.btnGerarMatriz.Location = new System.Drawing.Point(217, 160);
            this.btnGerarMatriz.Name = "btnGerarMatriz";
            this.btnGerarMatriz.Size = new System.Drawing.Size(108, 26);
            this.btnGerarMatriz.TabIndex = 6;
            this.btnGerarMatriz.Text = "Gerar Matriz";
            this.btnGerarMatriz.UseVisualStyleBackColor = false;
            this.btnGerarMatriz.Click += new System.EventHandler(this.btnGerarMatriz_Click);
            // 
            // frmMatriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(416, 450);
            this.Controls.Add(this.btnGerarMatriz);
            this.Controls.Add(this.btnMaiorNumero);
            this.Controls.Add(this.txtMaiorNumero);
            this.Controls.Add(this.txtMatriz);
            this.Controls.Add(this.lblInserirNumeros);
            this.Controls.Add(this.txtNumerosInseridos);
            this.Controls.Add(this.panelTopo);
            this.Name = "frmMatriz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matriz";
            this.panelTopo.ResumeLayout(false);
            this.panelTopo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTopo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtNumerosInseridos;
        private System.Windows.Forms.Label lblInserirNumeros;
        private System.Windows.Forms.TextBox txtMatriz;
        private System.Windows.Forms.TextBox txtMaiorNumero;
        private System.Windows.Forms.Button btnMaiorNumero;
        private System.Windows.Forms.Button btnGerarMatriz;
    }
}


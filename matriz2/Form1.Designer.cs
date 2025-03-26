
namespace matriz2
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
            this.txtNumerosInseridos = new System.Windows.Forms.TextBox();
            this.txtNumerosDaMatriz = new System.Windows.Forms.TextBox();
            this.btnMostrarMatriz = new System.Windows.Forms.Button();
            this.btnMaiorValor = new System.Windows.Forms.Button();
            this.panelTopo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblInsirirValores = new System.Windows.Forms.Label();
            this.panelTopo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNumerosInseridos
            // 
            this.txtNumerosInseridos.BackColor = System.Drawing.Color.MintCream;
            this.txtNumerosInseridos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumerosInseridos.ForeColor = System.Drawing.Color.Black;
            this.txtNumerosInseridos.Location = new System.Drawing.Point(137, 185);
            this.txtNumerosInseridos.Name = "txtNumerosInseridos";
            this.txtNumerosInseridos.Size = new System.Drawing.Size(106, 29);
            this.txtNumerosInseridos.TabIndex = 0;
            this.txtNumerosInseridos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumerosInseridos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // txtNumerosDaMatriz
            // 
            this.txtNumerosDaMatriz.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumerosDaMatriz.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtNumerosDaMatriz.Location = new System.Drawing.Point(106, 273);
            this.txtNumerosDaMatriz.Multiline = true;
            this.txtNumerosDaMatriz.Name = "txtNumerosDaMatriz";
            this.txtNumerosDaMatriz.Size = new System.Drawing.Size(167, 118);
            this.txtNumerosDaMatriz.TabIndex = 1;
            this.txtNumerosDaMatriz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnMostrarMatriz
            // 
            this.btnMostrarMatriz.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnMostrarMatriz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarMatriz.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnMostrarMatriz.Location = new System.Drawing.Point(137, 229);
            this.btnMostrarMatriz.Name = "btnMostrarMatriz";
            this.btnMostrarMatriz.Size = new System.Drawing.Size(106, 29);
            this.btnMostrarMatriz.TabIndex = 2;
            this.btnMostrarMatriz.Text = "Mostrar";
            this.btnMostrarMatriz.UseVisualStyleBackColor = false;
            this.btnMostrarMatriz.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMaiorValor
            // 
            this.btnMaiorValor.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnMaiorValor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaiorValor.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnMaiorValor.Location = new System.Drawing.Point(106, 406);
            this.btnMaiorValor.Name = "btnMaiorValor";
            this.btnMaiorValor.Size = new System.Drawing.Size(167, 32);
            this.btnMaiorValor.TabIndex = 3;
            this.btnMaiorValor.Text = "Maior Valor";
            this.btnMaiorValor.UseVisualStyleBackColor = false;
            this.btnMaiorValor.Click += new System.EventHandler(this.btnMaiorValor_Click);
            // 
            // panelTopo
            // 
            this.panelTopo.BackColor = System.Drawing.Color.Aquamarine;
            this.panelTopo.Controls.Add(this.lblTitulo);
            this.panelTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopo.Location = new System.Drawing.Point(0, 0);
            this.panelTopo.Name = "panelTopo";
            this.panelTopo.Size = new System.Drawing.Size(386, 100);
            this.panelTopo.TabIndex = 4;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitulo.Location = new System.Drawing.Point(88, 34);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(213, 30);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Matriz Bidimensional";
            // 
            // lblInsirirValores
            // 
            this.lblInsirirValores.AutoSize = true;
            this.lblInsirirValores.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsirirValores.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblInsirirValores.Location = new System.Drawing.Point(89, 131);
            this.lblInsirirValores.Name = "lblInsirirValores";
            this.lblInsirirValores.Size = new System.Drawing.Size(194, 21);
            this.lblInsirirValores.TabIndex = 5;
            this.lblInsirirValores.Text = "Insira os valores da matriz:";
            // 
            // frmMatriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(386, 450);
            this.Controls.Add(this.lblInsirirValores);
            this.Controls.Add(this.panelTopo);
            this.Controls.Add(this.btnMaiorValor);
            this.Controls.Add(this.btnMostrarMatriz);
            this.Controls.Add(this.txtNumerosDaMatriz);
            this.Controls.Add(this.txtNumerosInseridos);
            this.Name = "frmMatriz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matriz";
            this.panelTopo.ResumeLayout(false);
            this.panelTopo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumerosInseridos;
        private System.Windows.Forms.TextBox txtNumerosDaMatriz;
        private System.Windows.Forms.Button btnMostrarMatriz;
        private System.Windows.Forms.Button btnMaiorValor;
        private System.Windows.Forms.Panel panelTopo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblInsirirValores;
    }
}



namespace sistemacalculodedesconto
{
    partial class frmSistemaCalculoDesconto
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.txtValorCompra = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblTituloResultado = new System.Windows.Forms.Label();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.lblValorCompra = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 410);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMensagem);
            this.groupBox1.Controls.Add(this.btnCalcular);
            this.groupBox1.Controls.Add(this.txtDesconto);
            this.groupBox1.Controls.Add(this.txtValorCompra);
            this.groupBox1.Controls.Add(this.lblResultado);
            this.groupBox1.Controls.Add(this.lblTituloResultado);
            this.groupBox1.Controls.Add(this.lblDesconto);
            this.groupBox1.Controls.Add(this.lblValorCompra);
            this.groupBox1.Controls.Add(this.lblTitulo);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 386);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.ForeColor = System.Drawing.Color.White;
            this.lblMensagem.Location = new System.Drawing.Point(3, 360);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(0, 23);
            this.lblMensagem.TabIndex = 8;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Turquoise;
            this.btnCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.Black;
            this.btnCalcular.Location = new System.Drawing.Point(291, 318);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(175, 33);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtDesconto
            // 
            this.txtDesconto.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesconto.ForeColor = System.Drawing.Color.Black;
            this.txtDesconto.Location = new System.Drawing.Point(447, 189);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(100, 28);
            this.txtDesconto.TabIndex = 6;
            this.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDesconto.TextChanged += new System.EventHandler(this.txtDesconto_TextChanged);
            // 
            // txtValorCompra
            // 
            this.txtValorCompra.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorCompra.ForeColor = System.Drawing.Color.Black;
            this.txtValorCompra.Location = new System.Drawing.Point(262, 126);
            this.txtValorCompra.Name = "txtValorCompra";
            this.txtValorCompra.Size = new System.Drawing.Size(100, 28);
            this.txtValorCompra.TabIndex = 5;
            this.txtValorCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValorCompra.TextChanged += new System.EventHandler(this.txtValorCompra_TextChanged);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.White;
            this.lblResultado.Location = new System.Drawing.Point(369, 253);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 23);
            this.lblResultado.TabIndex = 4;
            // 
            // lblTituloResultado
            // 
            this.lblTituloResultado.AutoSize = true;
            this.lblTituloResultado.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloResultado.ForeColor = System.Drawing.Color.White;
            this.lblTituloResultado.Location = new System.Drawing.Point(75, 253);
            this.lblTituloResultado.Name = "lblTituloResultado";
            this.lblTituloResultado.Size = new System.Drawing.Size(288, 21);
            this.lblTituloResultado.TabIndex = 3;
            this.lblTituloResultado.Text = "Resultado da compra com desconto:  R$";
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesconto.ForeColor = System.Drawing.Color.White;
            this.lblDesconto.Location = new System.Drawing.Point(75, 195);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(366, 21);
            this.lblDesconto.TabIndex = 2;
            this.lblDesconto.Text = "Insira o desconto (considerar que 10 significa 10%):";
            // 
            // lblValorCompra
            // 
            this.lblValorCompra.AutoSize = true;
            this.lblValorCompra.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorCompra.ForeColor = System.Drawing.Color.White;
            this.lblValorCompra.Location = new System.Drawing.Point(75, 133);
            this.lblValorCompra.Name = "lblValorCompra";
            this.lblValorCompra.Size = new System.Drawing.Size(181, 21);
            this.lblValorCompra.TabIndex = 1;
            this.lblValorCompra.Text = "Insira o valor da compra:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Turquoise;
            this.lblTitulo.Location = new System.Drawing.Point(165, 47);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(425, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Sistema de Cálculo de Desconto";
            // 
            // frmSistemaCalculoDesconto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 410);
            this.Controls.Add(this.panel1);
            this.Name = "frmSistemaCalculoDesconto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Cálculo de Desconto";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblTituloResultado;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.Label lblValorCompra;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.TextBox txtValorCompra;
        private System.Windows.Forms.Label lblMensagem;
    }
}


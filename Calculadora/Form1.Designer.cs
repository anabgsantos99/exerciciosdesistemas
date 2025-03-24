
namespace Calculadora
{
    partial class frmCalculadora
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblOperação = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.btnMultiplicacao = new System.Windows.Forms.Button();
            this.btnSubtracao = new System.Windows.Forms.Button();
            this.btnAdicao = new System.Windows.Forms.Button();
            this.btnNumero9 = new System.Windows.Forms.Button();
            this.btnNumero8 = new System.Windows.Forms.Button();
            this.btnNumero7 = new System.Windows.Forms.Button();
            this.btnNumero6 = new System.Windows.Forms.Button();
            this.btnNumero5 = new System.Windows.Forms.Button();
            this.btnNumero4 = new System.Windows.Forms.Button();
            this.btnNumero3 = new System.Windows.Forms.Button();
            this.btnNumero2 = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnVirgula = new System.Windows.Forms.Button();
            this.btnNumero1 = new System.Windows.Forms.Button();
            this.btnNumero0 = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblOperação);
            this.groupBox1.Controls.Add(this.btnLimpar);
            this.groupBox1.Controls.Add(this.btnDivisao);
            this.groupBox1.Controls.Add(this.btnMultiplicacao);
            this.groupBox1.Controls.Add(this.btnSubtracao);
            this.groupBox1.Controls.Add(this.btnAdicao);
            this.groupBox1.Controls.Add(this.btnNumero9);
            this.groupBox1.Controls.Add(this.btnNumero8);
            this.groupBox1.Controls.Add(this.btnNumero7);
            this.groupBox1.Controls.Add(this.btnNumero6);
            this.groupBox1.Controls.Add(this.btnNumero5);
            this.groupBox1.Controls.Add(this.btnNumero4);
            this.groupBox1.Controls.Add(this.btnNumero3);
            this.groupBox1.Controls.Add(this.btnNumero2);
            this.groupBox1.Controls.Add(this.btnIgual);
            this.groupBox1.Controls.Add(this.btnVirgula);
            this.groupBox1.Controls.Add(this.btnNumero1);
            this.groupBox1.Controls.Add(this.btnNumero0);
            this.groupBox1.Controls.Add(this.txtResultado);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 314);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lblOperação
            // 
            this.lblOperação.AutoSize = true;
            this.lblOperação.BackColor = System.Drawing.Color.Lavender;
            this.lblOperação.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperação.Location = new System.Drawing.Point(23, 30);
            this.lblOperação.Name = "lblOperação";
            this.lblOperação.Size = new System.Drawing.Size(0, 18);
            this.lblOperação.TabIndex = 18;
            this.lblOperação.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Lavender;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnLimpar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.Navy;
            this.btnLimpar.Location = new System.Drawing.Point(185, 59);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(50, 25);
            this.btnLimpar.TabIndex = 17;
            this.btnLimpar.Text = "C";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnDivisao
            // 
            this.btnDivisao.BackColor = System.Drawing.Color.Lavender;
            this.btnDivisao.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnDivisao.FlatAppearance.BorderSize = 0;
            this.btnDivisao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnDivisao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnDivisao.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivisao.ForeColor = System.Drawing.Color.Navy;
            this.btnDivisao.Location = new System.Drawing.Point(185, 90);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(50, 50);
            this.btnDivisao.TabIndex = 16;
            this.btnDivisao.Text = "/";
            this.btnDivisao.UseVisualStyleBackColor = false;
            this.btnDivisao.Click += new System.EventHandler(this.btnDivisao_Click);
            // 
            // btnMultiplicacao
            // 
            this.btnMultiplicacao.BackColor = System.Drawing.Color.Lavender;
            this.btnMultiplicacao.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnMultiplicacao.FlatAppearance.BorderSize = 0;
            this.btnMultiplicacao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnMultiplicacao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnMultiplicacao.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicacao.ForeColor = System.Drawing.Color.Navy;
            this.btnMultiplicacao.Location = new System.Drawing.Point(185, 146);
            this.btnMultiplicacao.Name = "btnMultiplicacao";
            this.btnMultiplicacao.Size = new System.Drawing.Size(50, 50);
            this.btnMultiplicacao.TabIndex = 15;
            this.btnMultiplicacao.Text = "x";
            this.btnMultiplicacao.UseVisualStyleBackColor = false;
            this.btnMultiplicacao.Click += new System.EventHandler(this.btnMultiplicacao_Click);
            // 
            // btnSubtracao
            // 
            this.btnSubtracao.BackColor = System.Drawing.Color.Lavender;
            this.btnSubtracao.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnSubtracao.FlatAppearance.BorderSize = 0;
            this.btnSubtracao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSubtracao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnSubtracao.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtracao.ForeColor = System.Drawing.Color.Navy;
            this.btnSubtracao.Location = new System.Drawing.Point(185, 202);
            this.btnSubtracao.Name = "btnSubtracao";
            this.btnSubtracao.Size = new System.Drawing.Size(50, 50);
            this.btnSubtracao.TabIndex = 14;
            this.btnSubtracao.Text = "-";
            this.btnSubtracao.UseVisualStyleBackColor = false;
            this.btnSubtracao.Click += new System.EventHandler(this.btnSubtracao_Click);
            // 
            // btnAdicao
            // 
            this.btnAdicao.BackColor = System.Drawing.Color.Lavender;
            this.btnAdicao.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnAdicao.FlatAppearance.BorderSize = 0;
            this.btnAdicao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAdicao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnAdicao.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicao.ForeColor = System.Drawing.Color.Navy;
            this.btnAdicao.Location = new System.Drawing.Point(185, 258);
            this.btnAdicao.Name = "btnAdicao";
            this.btnAdicao.Size = new System.Drawing.Size(50, 50);
            this.btnAdicao.TabIndex = 13;
            this.btnAdicao.Text = "+";
            this.btnAdicao.UseVisualStyleBackColor = false;
            this.btnAdicao.Click += new System.EventHandler(this.btnAdicao_Click);
            // 
            // btnNumero9
            // 
            this.btnNumero9.BackColor = System.Drawing.Color.Lavender;
            this.btnNumero9.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnNumero9.FlatAppearance.BorderSize = 0;
            this.btnNumero9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnNumero9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnNumero9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumero9.ForeColor = System.Drawing.Color.Navy;
            this.btnNumero9.Location = new System.Drawing.Point(129, 90);
            this.btnNumero9.Name = "btnNumero9";
            this.btnNumero9.Size = new System.Drawing.Size(50, 50);
            this.btnNumero9.TabIndex = 12;
            this.btnNumero9.Text = "9";
            this.btnNumero9.UseVisualStyleBackColor = false;
            this.btnNumero9.Click += new System.EventHandler(this.btnNumero9_Click);
            // 
            // btnNumero8
            // 
            this.btnNumero8.BackColor = System.Drawing.Color.Lavender;
            this.btnNumero8.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnNumero8.FlatAppearance.BorderSize = 0;
            this.btnNumero8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnNumero8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnNumero8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumero8.ForeColor = System.Drawing.Color.Navy;
            this.btnNumero8.Location = new System.Drawing.Point(73, 90);
            this.btnNumero8.Name = "btnNumero8";
            this.btnNumero8.Size = new System.Drawing.Size(50, 50);
            this.btnNumero8.TabIndex = 11;
            this.btnNumero8.Text = "8";
            this.btnNumero8.UseVisualStyleBackColor = false;
            this.btnNumero8.Click += new System.EventHandler(this.btnNumero8_Click);
            // 
            // btnNumero7
            // 
            this.btnNumero7.BackColor = System.Drawing.Color.Lavender;
            this.btnNumero7.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnNumero7.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnNumero7.FlatAppearance.BorderSize = 0;
            this.btnNumero7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnNumero7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnNumero7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumero7.ForeColor = System.Drawing.Color.Navy;
            this.btnNumero7.Location = new System.Drawing.Point(17, 90);
            this.btnNumero7.Name = "btnNumero7";
            this.btnNumero7.Size = new System.Drawing.Size(50, 50);
            this.btnNumero7.TabIndex = 10;
            this.btnNumero7.Text = "7";
            this.btnNumero7.UseVisualStyleBackColor = false;
            this.btnNumero7.Click += new System.EventHandler(this.btnNumero7_Click);
            // 
            // btnNumero6
            // 
            this.btnNumero6.BackColor = System.Drawing.Color.Lavender;
            this.btnNumero6.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnNumero6.FlatAppearance.BorderSize = 0;
            this.btnNumero6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnNumero6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnNumero6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumero6.ForeColor = System.Drawing.Color.Navy;
            this.btnNumero6.Location = new System.Drawing.Point(129, 146);
            this.btnNumero6.Name = "btnNumero6";
            this.btnNumero6.Size = new System.Drawing.Size(50, 50);
            this.btnNumero6.TabIndex = 9;
            this.btnNumero6.Text = "6";
            this.btnNumero6.UseVisualStyleBackColor = false;
            this.btnNumero6.Click += new System.EventHandler(this.btnNumero6_Click);
            // 
            // btnNumero5
            // 
            this.btnNumero5.BackColor = System.Drawing.Color.Lavender;
            this.btnNumero5.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnNumero5.FlatAppearance.BorderSize = 0;
            this.btnNumero5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnNumero5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnNumero5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumero5.ForeColor = System.Drawing.Color.Navy;
            this.btnNumero5.Location = new System.Drawing.Point(73, 146);
            this.btnNumero5.Name = "btnNumero5";
            this.btnNumero5.Size = new System.Drawing.Size(50, 50);
            this.btnNumero5.TabIndex = 8;
            this.btnNumero5.Text = "5";
            this.btnNumero5.UseVisualStyleBackColor = false;
            this.btnNumero5.Click += new System.EventHandler(this.btnNumero5_Click);
            // 
            // btnNumero4
            // 
            this.btnNumero4.BackColor = System.Drawing.Color.Lavender;
            this.btnNumero4.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnNumero4.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnNumero4.FlatAppearance.BorderSize = 0;
            this.btnNumero4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnNumero4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnNumero4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumero4.ForeColor = System.Drawing.Color.Navy;
            this.btnNumero4.Location = new System.Drawing.Point(17, 146);
            this.btnNumero4.Name = "btnNumero4";
            this.btnNumero4.Size = new System.Drawing.Size(50, 50);
            this.btnNumero4.TabIndex = 7;
            this.btnNumero4.Text = "4";
            this.btnNumero4.UseVisualStyleBackColor = false;
            this.btnNumero4.Click += new System.EventHandler(this.btnNumero4_Click);
            // 
            // btnNumero3
            // 
            this.btnNumero3.BackColor = System.Drawing.Color.Lavender;
            this.btnNumero3.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnNumero3.FlatAppearance.BorderSize = 0;
            this.btnNumero3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnNumero3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnNumero3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumero3.ForeColor = System.Drawing.Color.Navy;
            this.btnNumero3.Location = new System.Drawing.Point(129, 202);
            this.btnNumero3.Name = "btnNumero3";
            this.btnNumero3.Size = new System.Drawing.Size(50, 50);
            this.btnNumero3.TabIndex = 6;
            this.btnNumero3.Text = "3";
            this.btnNumero3.UseVisualStyleBackColor = false;
            this.btnNumero3.Click += new System.EventHandler(this.btnNumero3_Click);
            // 
            // btnNumero2
            // 
            this.btnNumero2.BackColor = System.Drawing.Color.Lavender;
            this.btnNumero2.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnNumero2.FlatAppearance.BorderSize = 0;
            this.btnNumero2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnNumero2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnNumero2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumero2.ForeColor = System.Drawing.Color.Navy;
            this.btnNumero2.Location = new System.Drawing.Point(73, 202);
            this.btnNumero2.Name = "btnNumero2";
            this.btnNumero2.Size = new System.Drawing.Size(50, 50);
            this.btnNumero2.TabIndex = 5;
            this.btnNumero2.Text = "2";
            this.btnNumero2.UseVisualStyleBackColor = false;
            this.btnNumero2.Click += new System.EventHandler(this.btnNumero2_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.BackColor = System.Drawing.Color.Lavender;
            this.btnIgual.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnIgual.FlatAppearance.BorderSize = 0;
            this.btnIgual.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnIgual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnIgual.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgual.ForeColor = System.Drawing.Color.Navy;
            this.btnIgual.Location = new System.Drawing.Point(129, 258);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(50, 50);
            this.btnIgual.TabIndex = 4;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = false;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnVirgula
            // 
            this.btnVirgula.BackColor = System.Drawing.Color.Lavender;
            this.btnVirgula.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnVirgula.FlatAppearance.BorderSize = 0;
            this.btnVirgula.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnVirgula.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnVirgula.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVirgula.ForeColor = System.Drawing.Color.Navy;
            this.btnVirgula.Location = new System.Drawing.Point(17, 258);
            this.btnVirgula.Name = "btnVirgula";
            this.btnVirgula.Size = new System.Drawing.Size(50, 50);
            this.btnVirgula.TabIndex = 3;
            this.btnVirgula.Text = ",";
            this.btnVirgula.UseVisualStyleBackColor = false;
            this.btnVirgula.Click += new System.EventHandler(this.btnVirgula_Click);
            // 
            // btnNumero1
            // 
            this.btnNumero1.BackColor = System.Drawing.Color.Lavender;
            this.btnNumero1.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnNumero1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnNumero1.FlatAppearance.BorderSize = 0;
            this.btnNumero1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnNumero1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnNumero1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumero1.ForeColor = System.Drawing.Color.Navy;
            this.btnNumero1.Location = new System.Drawing.Point(17, 202);
            this.btnNumero1.Name = "btnNumero1";
            this.btnNumero1.Size = new System.Drawing.Size(50, 50);
            this.btnNumero1.TabIndex = 2;
            this.btnNumero1.Text = "1";
            this.btnNumero1.UseVisualStyleBackColor = false;
            this.btnNumero1.Click += new System.EventHandler(this.btnNumero1_Click);
            // 
            // btnNumero0
            // 
            this.btnNumero0.BackColor = System.Drawing.Color.Lavender;
            this.btnNumero0.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNumero0.FlatAppearance.BorderSize = 0;
            this.btnNumero0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnNumero0.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumero0.ForeColor = System.Drawing.Color.Navy;
            this.btnNumero0.Location = new System.Drawing.Point(73, 258);
            this.btnNumero0.Name = "btnNumero0";
            this.btnNumero0.Size = new System.Drawing.Size(50, 50);
            this.btnNumero0.TabIndex = 1;
            this.btnNumero0.Text = "0";
            this.btnNumero0.UseVisualStyleBackColor = false;
            this.btnNumero0.Click += new System.EventHandler(this.btnNumero0_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.Color.Lavender;
            this.txtResultado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(17, 27);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(218, 26);
            this.txtResultado.TabIndex = 0;
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(276, 338);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNumero0;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnNumero3;
        private System.Windows.Forms.Button btnNumero2;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnVirgula;
        private System.Windows.Forms.Button btnNumero1;
        private System.Windows.Forms.Button btnNumero6;
        private System.Windows.Forms.Button btnNumero5;
        private System.Windows.Forms.Button btnNumero4;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.Button btnMultiplicacao;
        private System.Windows.Forms.Button btnSubtracao;
        private System.Windows.Forms.Button btnAdicao;
        private System.Windows.Forms.Button btnNumero9;
        private System.Windows.Forms.Button btnNumero8;
        private System.Windows.Forms.Button btnNumero7;
        private System.Windows.Forms.Label lblOperação;
    }
}


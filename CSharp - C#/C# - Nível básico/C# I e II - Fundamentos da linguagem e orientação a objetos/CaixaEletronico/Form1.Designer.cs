﻿namespace benner.CaixaEletronico
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
            this.textoTitular = new System.Windows.Forms.TextBox();
            this.textoSaldo = new System.Windows.Forms.TextBox();
            this.textoNumero = new System.Windows.Forms.TextBox();
            this.Titular = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textoValor = new System.Windows.Forms.TextBox();
            this.botaoDepositar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sacarValor = new System.Windows.Forms.Button();
            this.comboContas = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.botaoTransferir = new System.Windows.Forms.Button();
            this.comboDestinoDaTransferencia = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textoTitular
            // 
            this.textoTitular.Location = new System.Drawing.Point(175, 270);
            this.textoTitular.Margin = new System.Windows.Forms.Padding(4);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.Size = new System.Drawing.Size(473, 22);
            this.textoTitular.TabIndex = 0;
            this.textoTitular.TextChanged += new System.EventHandler(this.textoTitular_TextChanged);
            // 
            // textoSaldo
            // 
            this.textoSaldo.Location = new System.Drawing.Point(175, 326);
            this.textoSaldo.Margin = new System.Windows.Forms.Padding(4);
            this.textoSaldo.Name = "textoSaldo";
            this.textoSaldo.Size = new System.Drawing.Size(473, 22);
            this.textoSaldo.TabIndex = 1;
            this.textoSaldo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textoNumero
            // 
            this.textoNumero.Location = new System.Drawing.Point(175, 384);
            this.textoNumero.Margin = new System.Windows.Forms.Padding(4);
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.Size = new System.Drawing.Size(473, 22);
            this.textoNumero.TabIndex = 2;
            // 
            // Titular
            // 
            this.Titular.AutoSize = true;
            this.Titular.Location = new System.Drawing.Point(175, 246);
            this.Titular.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Titular.Name = "Titular";
            this.Titular.Size = new System.Drawing.Size(109, 17);
            this.Titular.TabIndex = 3;
            this.Titular.Text = "Titular da Conta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 306);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Saldo da Conta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 364);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Número";
            // 
            // textoValor
            // 
            this.textoValor.Location = new System.Drawing.Point(175, 439);
            this.textoValor.Margin = new System.Windows.Forms.Padding(4);
            this.textoValor.Name = "textoValor";
            this.textoValor.Size = new System.Drawing.Size(257, 22);
            this.textoValor.TabIndex = 6;
            this.textoValor.TextChanged += new System.EventHandler(this.textoValor_TextChanged);
            // 
            // botaoDepositar
            // 
            this.botaoDepositar.Location = new System.Drawing.Point(441, 436);
            this.botaoDepositar.Margin = new System.Windows.Forms.Padding(4);
            this.botaoDepositar.Name = "botaoDepositar";
            this.botaoDepositar.Size = new System.Drawing.Size(100, 28);
            this.botaoDepositar.TabIndex = 7;
            this.botaoDepositar.Text = "Depositar";
            this.botaoDepositar.UseVisualStyleBackColor = true;
            this.botaoDepositar.Click += new System.EventHandler(this.botaoDepositar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 420);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Valor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // sacarValor
            // 
            this.sacarValor.Location = new System.Drawing.Point(549, 437);
            this.sacarValor.Margin = new System.Windows.Forms.Padding(4);
            this.sacarValor.Name = "sacarValor";
            this.sacarValor.Size = new System.Drawing.Size(100, 28);
            this.sacarValor.TabIndex = 9;
            this.sacarValor.Text = "Sacar";
            this.sacarValor.UseVisualStyleBackColor = true;
            this.sacarValor.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // comboContas
            // 
            this.comboContas.FormattingEnabled = true;
            this.comboContas.Location = new System.Drawing.Point(175, 203);
            this.comboContas.Margin = new System.Windows.Forms.Padding(4);
            this.comboContas.Name = "comboContas";
            this.comboContas.Size = new System.Drawing.Size(473, 24);
            this.comboContas.TabIndex = 10;
            this.comboContas.SelectedIndexChanged += new System.EventHandler(this.comboContas_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 183);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cliente";
            // 
            // botaoTransferir
            // 
            this.botaoTransferir.Location = new System.Drawing.Point(549, 482);
            this.botaoTransferir.Margin = new System.Windows.Forms.Padding(4);
            this.botaoTransferir.Name = "botaoTransferir";
            this.botaoTransferir.Size = new System.Drawing.Size(100, 28);
            this.botaoTransferir.TabIndex = 12;
            this.botaoTransferir.Text = "Transferir";
            this.botaoTransferir.UseVisualStyleBackColor = true;
            this.botaoTransferir.Click += new System.EventHandler(this.botaoTransferir_Click);
            // 
            // comboDestinoDaTransferencia
            // 
            this.comboDestinoDaTransferencia.FormattingEnabled = true;
            this.comboDestinoDaTransferencia.Location = new System.Drawing.Point(175, 482);
            this.comboDestinoDaTransferencia.Margin = new System.Windows.Forms.Padding(4);
            this.comboDestinoDaTransferencia.Name = "comboDestinoDaTransferencia";
            this.comboDestinoDaTransferencia.Size = new System.Drawing.Size(367, 24);
            this.comboDestinoDaTransferencia.TabIndex = 13;
            this.comboDestinoDaTransferencia.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(274, 97);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(268, 44);
            this.button2.TabIndex = 15;
            this.button2.Text = "Cadastrar Nova Conta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(656, 200);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 29);
            this.button1.TabIndex = 16;
            this.button1.Text = "Remover Conta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 730);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboDestinoDaTransferencia);
            this.Controls.Add(this.botaoTransferir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboContas);
            this.Controls.Add(this.sacarValor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botaoDepositar);
            this.Controls.Add(this.textoValor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Titular);
            this.Controls.Add(this.textoNumero);
            this.Controls.Add(this.textoSaldo);
            this.Controls.Add(this.textoTitular);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Caixa Eletrônico";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textoTitular;
        private System.Windows.Forms.TextBox textoSaldo;
        private System.Windows.Forms.TextBox textoNumero;
        private System.Windows.Forms.Label Titular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textoValor;
        private System.Windows.Forms.Button botaoDepositar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sacarValor;
        private System.Windows.Forms.ComboBox comboContas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button botaoTransferir;
        private System.Windows.Forms.ComboBox comboDestinoDaTransferencia;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}


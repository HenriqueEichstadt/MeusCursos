namespace CaixaEletronico
{
    partial class CadastroDeContas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titularConta = new System.Windows.Forms.TextBox();
            this.numeroConta = new System.Windows.Forms.TextBox();
            this.idadeTitularConta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.agenciaConta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cpfTitularConta = new System.Windows.Forms.TextBox();
            this.rgTitularConta = new System.Windows.Forms.TextBox();
            this.enderecoTitularConta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tipoDeConta = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titularConta
            // 
            this.titularConta.Location = new System.Drawing.Point(243, 203);
            this.titularConta.Margin = new System.Windows.Forms.Padding(4);
            this.titularConta.Name = "titularConta";
            this.titularConta.Size = new System.Drawing.Size(583, 22);
            this.titularConta.TabIndex = 0;
            this.titularConta.TextChanged += new System.EventHandler(this.titularConta_TextChanged);
            // 
            // numeroConta
            // 
            this.numeroConta.Location = new System.Drawing.Point(304, 336);
            this.numeroConta.Margin = new System.Windows.Forms.Padding(4);
            this.numeroConta.Name = "numeroConta";
            this.numeroConta.Size = new System.Drawing.Size(184, 22);
            this.numeroConta.TabIndex = 1;
            this.numeroConta.TextChanged += new System.EventHandler(this.numeroConta_TextChanged);
            // 
            // idadeTitularConta
            // 
            this.idadeTitularConta.Location = new System.Drawing.Point(679, 292);
            this.idadeTitularConta.Margin = new System.Windows.Forms.Padding(4);
            this.idadeTitularConta.Name = "idadeTitularConta";
            this.idadeTitularConta.Size = new System.Drawing.Size(147, 22);
            this.idadeTitularConta.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 207);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome Do Titular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 340);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Número da Conta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(625, 294);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Idade";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(353, 415);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 60);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cadastrar Cliente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(516, 340);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Agência";
            // 
            // agenciaConta
            // 
            this.agenciaConta.Location = new System.Drawing.Point(597, 336);
            this.agenciaConta.Margin = new System.Windows.Forms.Padding(4);
            this.agenciaConta.Name = "agenciaConta";
            this.agenciaConta.Size = new System.Drawing.Size(184, 22);
            this.agenciaConta.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 249);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "CPF";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(497, 249);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "RG";
            // 
            // cpfTitularConta
            // 
            this.cpfTitularConta.Location = new System.Drawing.Point(167, 245);
            this.cpfTitularConta.Margin = new System.Windows.Forms.Padding(4);
            this.cpfTitularConta.Name = "cpfTitularConta";
            this.cpfTitularConta.Size = new System.Drawing.Size(315, 22);
            this.cpfTitularConta.TabIndex = 11;
            // 
            // rgTitularConta
            // 
            this.rgTitularConta.Location = new System.Drawing.Point(536, 245);
            this.rgTitularConta.Margin = new System.Windows.Forms.Padding(4);
            this.rgTitularConta.Name = "rgTitularConta";
            this.rgTitularConta.Size = new System.Drawing.Size(289, 22);
            this.rgTitularConta.TabIndex = 12;
            // 
            // enderecoTitularConta
            // 
            this.enderecoTitularConta.Location = new System.Drawing.Point(201, 290);
            this.enderecoTitularConta.Margin = new System.Windows.Forms.Padding(4);
            this.enderecoTitularConta.Name = "enderecoTitularConta";
            this.enderecoTitularConta.Size = new System.Drawing.Size(415, 22);
            this.enderecoTitularConta.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(123, 295);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Endereço";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(165, 57);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(616, 52);
            this.label8.TabIndex = 15;
            this.label8.Text = "CADASTRAR NOVA CONTA";
            // 
            // tipoDeConta
            // 
            this.tipoDeConta.FormattingEnabled = true;
            this.tipoDeConta.Location = new System.Drawing.Point(243, 142);
            this.tipoDeConta.Name = "tipoDeConta";
            this.tipoDeConta.Size = new System.Drawing.Size(292, 24);
            this.tipoDeConta.TabIndex = 16;
            this.tipoDeConta.SelectedIndexChanged += new System.EventHandler(this.tipoDeConta_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(123, 145);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Tipo De Conta";
            // 
            // CadastroDeContas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 562);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tipoDeConta);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.enderecoTitularConta);
            this.Controls.Add(this.rgTitularConta);
            this.Controls.Add(this.cpfTitularConta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.agenciaConta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idadeTitularConta);
            this.Controls.Add(this.numeroConta);
            this.Controls.Add(this.titularConta);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CadastroDeContas";
            this.Text = "CadastroDeContas";
            this.Load += new System.EventHandler(this.CadastroDeContas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titularConta;
        private System.Windows.Forms.TextBox numeroConta;
        private System.Windows.Forms.TextBox idadeTitularConta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox agenciaConta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cpfTitularConta;
        private System.Windows.Forms.TextBox rgTitularConta;
        private System.Windows.Forms.TextBox enderecoTitularConta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox tipoDeConta;
        private System.Windows.Forms.Label label9;
    }
}
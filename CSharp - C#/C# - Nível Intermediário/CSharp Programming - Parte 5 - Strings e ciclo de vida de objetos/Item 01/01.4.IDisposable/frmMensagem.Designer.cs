using System;
using System.Windows;
using System.Windows.Interop;

namespace _01._4.IDisposable_Finalizador
{
    partial class FrmMensagem
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
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.btnMensagem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMensagem
            // 
            this.txtMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtMensagem.Location = new System.Drawing.Point(32, 80);
            this.txtMensagem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(347, 36);
            this.txtMensagem.TabIndex = 0;
            // 
            // btnMensagem
            // 
            this.btnMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnMensagem.Location = new System.Drawing.Point(101, 133);
            this.btnMensagem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMensagem.Name = "btnMensagem";
            this.btnMensagem.Size = new System.Drawing.Size(281, 59);
            this.btnMensagem.TabIndex = 1;
            this.btnMensagem.Text = "Enviar para Notepad";
            this.btnMensagem.UseVisualStyleBackColor = true;
            this.btnMensagem.Click += new System.EventHandler(this.btnMensagem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(28, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mensagem:";
            // 
            // FrmMensagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 206);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMensagem);
            this.Controls.Add(this.txtMensagem);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMensagem";
            this.Text = "Mensageiro Notepad";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnMensagem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMensagem;

        #endregion
    }
}


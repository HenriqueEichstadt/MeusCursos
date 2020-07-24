﻿using System;
using System.Windows.Forms;

namespace _01._4.IDisposable_Finalizador
{
    public partial class FrmMensagem : Form
    {
        public FrmMensagem()
        {
            InitializeComponent();

        }

        private void btnMensagem_Click(object sender, EventArgs e)
        {
             using (var mensageiro = new MensageiroNotepad())
            {
                mensageiro.EnviarMensagem(txtMensagem.Text);
            }
        }
    }
}

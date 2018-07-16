using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaEletronico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta contaHenrique = new Conta();
            contaHenrique.numero = 1;
            contaHenrique.saldo = 5000.0;

            Cliente clienteHenrique = new Cliente();
            clienteHenrique.nome = "Henrique";
            clienteHenrique.idade = 18;

            contaHenrique.titular = clienteHenrique;

            bool sacou = contaHenrique.Sacar(500.0);

            if (sacou)
            {
                MessageBox.Show("O saldo do Henrique apos saque de R$500,00: " + contaHenrique.saldo);
            }
            else
            {
                MessageBox.Show("Não foi possível sacar");
            }
        }
    }
}

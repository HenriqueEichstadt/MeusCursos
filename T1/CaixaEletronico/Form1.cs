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
            Conta umaConta = new Conta();
            umaConta.numero = 1;
            umaConta.titular = "Joaquim José";
            umaConta.saldo = 2000.0;
            umaConta.CPF = 12345678912;
            umaConta.agencia = 085;

            Conta outraConta = new Conta();
            outraConta.numero = 2;
            outraConta.titular = "Silva Xavier";
            outraConta.saldo = 1500.0;
            outraConta.CPF = 98765432198;
            outraConta.agencia = 010;

            MessageBox.Show(" O titular da conta: " + umaConta.titular + "\n O número da conta: " + umaConta.numero + "\n O Saldo: " + umaConta.saldo + "\n O CPF: " + umaConta.CPF + "\n A Agência: " + umaConta.agencia);
            MessageBox.Show(" O titular da conta: " + outraConta.titular + "\n O número da conta: " + outraConta.numero + "\n O Saldo: " + outraConta.saldo + "\n O CPF: " + outraConta.CPF + "\n A Agência: " + outraConta.agencia);
        }
    }
}
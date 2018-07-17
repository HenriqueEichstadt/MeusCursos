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
            Conta conta = new Conta();
            Cliente cliente = new Cliente("Jãozinho") { Rg = "12346578", Endereco = "R. Itajaí, 2975 - Vorstadt, Blumenau - SC", Cpf = 123456789 - 01, Idade = 18 };

            MessageBox.Show(" -> Cliente : " + cliente.Nome + "\n -> RG:   " + cliente.Rg + "\n -> CPF : " + cliente.Cpf + "\n -> End: " + cliente.Endereco + "\n -> Saldo atual : " + conta.Saldo);
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            Conta conta = new Conta();
            Cliente cliente = new Cliente();
            conta.Titular = cliente;
            conta.Titular.Nome = "Henrique Eichstädt";
            conta.Deposita(123456);
            conta.Numero = 987654321;


            textoTitular.Text = conta.Titular.Nome;
            textoSaldo.Text = Convert.ToString(conta.Saldo);
            textoNumero.Text = Convert.ToString(conta.Numero);

        }

        private void textoTitular_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


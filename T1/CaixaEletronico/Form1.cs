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
        private Conta conta;

        // Método para exibir dados da conta
        private void MostrarConta()
        {
            textoTitular.Text = this.conta.Titular.Nome;
            textoSaldo.Text = Convert.ToString(this.conta.Saldo);
            textoNumero.Text = Convert.ToString(this.conta.Numero);
        }
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
            // criando nova conta
            this.conta = new Conta();
            Cliente cliente = new Cliente();
            this.conta.Titular = cliente;
            this.conta.Titular.Nome = "Henrique Eichstädt";
            this.conta.Deposita(10000);
            this.conta.Numero = 987654321;
            this.conta.Titular.Idade = 18;
            // método para exibir os dados da conta
            this.MostrarConta();



        }

        private void textoTitular_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void botaoDepositar_Click(object sender, EventArgs e)
        {
            // converte string para double 
            string textoDoValorDoDeposito = textoValor.Text;
            double valorDeposito = Convert.ToDouble(textoDoValorDoDeposito);
            this.conta.Deposita(valorDeposito);

            // Inicia o método que mostra as informações da conta
            this.MostrarConta();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string textoDoValorSacado = textoValor.Text;
            double valorSacado = Convert.ToDouble(textoDoValorSacado);
            this.conta.Sacar(valorSacado);

            // Inicia o método que mostra as informações da conta
            this.MostrarConta();
        }

        private void textoValor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


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
        Conta[] contas;
        //private Conta conta;

        // Método para exibir dados da conta
        private void MostrarConta()
        {
            int indiceSelecionado = comboContas.SelectedIndex;
            textoTitular.Text = this.contas[indiceSelecionado].Titular.Nome;
            textoSaldo.Text = Convert.ToString(this.contas[indiceSelecionado].Saldo);
            textoNumero.Text = Convert.ToString(this.contas[indiceSelecionado].Numero);
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // criando nova conta
            contas = new Conta[2];
            Cliente c0 = new Cliente();

            contas[0] = new Conta();
            contas[0].Titular = c0;
            contas[0].Titular.Nome = "Henrique Eichstädt";
            contas[0].Saldo = 1500.00;
            contas[0].Numero = 1;

            Cliente c1 = new Cliente();
            contas[1] = new Conta();
            contas[1].Titular = c1;
            contas[1].Titular.Nome = "João da Silva";
            contas[1].Saldo = 10000.00;
            contas[1].Numero = 2;

            foreach (Conta conta in contas)
            {
                comboContas.Items.Add(conta.Titular.Nome + "  -  " + conta.Numero);
            }
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
            int indiceSelecionado = comboContas.SelectedIndex;
            this.contas[indiceSelecionado].Deposita(valorDeposito);

            // Inicia o método que mostra as informações da conta
            this.MostrarConta();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string textoDoValorSacado = textoValor.Text;
            double valorSacado = Convert.ToDouble(textoDoValorSacado);
            int indiceSelecionado = comboContas.SelectedIndex;
            this.contas[indiceSelecionado].Sacar(valorSacado);

            // Inicia o método que mostra as informações da conta
            this.MostrarConta();
        }

        private void textoValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceSelecionado = comboContas.SelectedIndex;
            Conta contaSelecionada = contas[indiceSelecionado];
            textoTitular.Text = contaSelecionada.Titular.Nome;
            textoSaldo.Text = Convert.ToString(contaSelecionada.Saldo);
            textoNumero.Text = Convert.ToString(contaSelecionada.Numero);
        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using benner.CaixaEletronico.Modelo.Contas;
using benner.CaixaEletronico.Usuarios;
using benner.CaixaEletronico.Modelo;
using benner.CaixaEletronico.Gerenciadores;
using benner.CaixaEletronico;
using CaixaEletronico;

namespace benner.CaixaEletronico
{
    public partial class Form1 : Form
    {

        Conta[] contas;
        //private Conta conta;
        private int quantidadeDeContas;
        // Método para adicionar conta
        public void AdicionaConta(Conta c)
        {
            if (this.quantidadeDeContas == this.contas.Length)
            {
                Conta[] novo = new Conta[this.contas.Length * 2];
                for (int i = 0; i < this.quantidadeDeContas; i++)
                {
                    novo[i] = this.contas[i];
                }
                this.contas = novo;
            }
            this.contas[this.quantidadeDeContas] = c;
            this.quantidadeDeContas++;
            comboContas.Items.Add(c.Titular.Nome);
        }
        // Metodo para remover conta
        public void RemoveConta(Conta c)
        {
            comboContas.Items.Remove(c.Titular.Nome);
            int i;
            for (i = 0; i < this.quantidadeDeContas; i++)
            {
                if (this.contas[i] == c)
                {
                    break;
                }
            }
            while (i + 1 < this.quantidadeDeContas)
            {
                this.contas[i] = this.contas[i + 1];
                i++;
            }
        }

        // Método para exibir dados da conta
        private void MostrarConta(Conta conta)
        {
            textoTitular.Text = conta.Titular.Nome;
            textoSaldo.Text = Convert.ToString(conta.Saldo);
            textoNumero.Text = Convert.ToString(conta.Numero);

        }


        private Conta BuscaContaSelecionada()
        {
            int indiceSelecionado = comboContas.SelectedIndex;
            return this.contas[indiceSelecionado];
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
            contas = new Conta[20];

            Cliente c0 = new Cliente();
            contas[0] = new ContaPoupanca();
            contas[0].Titular = c0;
            contas[0].Titular.Nome = "Henrique Eichstädt";
            contas[0].Deposita(20000.00);
            contas[0].Numero = 0001;
            contas[0].Titular.Idade = 17;

            Cliente c1 = new Cliente();
            contas[1] = new ContaPoupanca();
            contas[1].Titular = c1;
            contas[1].Titular.Nome = "João da Silva";
            contas[1].Deposita(10000.00);
            contas[1].Numero = 0002;
            contas[1].Titular.Idade = 18;

            Cliente c2 = new Cliente();
            contas[2] = new ContaPoupanca();
            contas[2].Titular = c2;
            contas[2].Titular.Nome = "Bernanrdo ";
            contas[2].Deposita(15000.00);
            contas[2].Numero = 0003;
            contas[2].Titular.Idade = 18;

            this.quantidadeDeContas = 3;

            foreach (Conta conta in this.contas)
            {
                if (conta != null)
                {
                    comboContas.Items.Add(conta.Titular.Nome);
                    comboDestinoDaTransferencia.Items.Add(conta.Titular.Nome);
                }

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
            // Depositar
            int indiceSelecionado = comboContas.SelectedIndex;


            // Inicia o método que mostra as informações da conta
            Conta contaSelecionada = this.contas[indiceSelecionado];
            this.MostrarConta(contaSelecionada);

            try
            {
                this.contas[indiceSelecionado].Deposita(valorDeposito);
                MessageBox.Show("Depósito Efetuado Com Sucesso !");

            }
            catch (ArgumentException)
            {
                MessageBox.Show("Valor Nulo Para Dépósito, Insira outro valor !");
            }
            this.MostrarConta(contaSelecionada);
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            string textoDoValorSacado = textoValor.Text;
            double valorSacado = Convert.ToDouble(textoDoValorSacado);
            // Sacar
            int indiceSelecionado = comboContas.SelectedIndex;


            // Inicia o método que mostra as informações da conta
            Conta contaSelecionada = this.contas[indiceSelecionado];
            this.MostrarConta(contaSelecionada);

            // Exceções
            try
            {
                contaSelecionada.Sacar(valorSacado);
                MessageBox.Show("Saque Efetuado com Sucesso !");
            }
            catch (SaldoInsuficienteException)
            {
                MessageBox.Show("Saldo Insuficiente para saque !");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Valor de Saque Inválido !");
            }
            catch (MenorDeIdadeException)
            {
                MessageBox.Show("Saque restrito a R$: 200,00 para Titular menor de idade !");
            }
            this.MostrarConta(contaSelecionada);
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

            /*string titularSelecionado = comboContas.Text;
            Conta contaSelecionada = this.BuscaContaSelecionada();
            this.MostrarConta(contaSelecionada);*/
        }

        private void botaoTransferir_Click(object sender, EventArgs e)
        {
            Conta contaSelecionada = this.BuscaContaSelecionada();

            int indiceDaContaDestino = comboDestinoDaTransferencia.SelectedIndex;

            Conta contaDestino = this.contas[indiceDaContaDestino];

            string textoValorTransfere = textoValor.Text;
            double valorTransferencia = Convert.ToDouble(textoValorTransfere);

            contaSelecionada.TransferirParaAlguem(contaDestino, valorTransferencia);

            this.MostrarConta(contaSelecionada);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            GerenciadorDeImposto gerenciador = new GerenciadorDeImposto();
            ContaPoupanca contaP = new ContaPoupanca();
            SeguroDeVida seguroV = new SeguroDeVida();
            ContaInvestimento contaInv = new ContaInvestimento();
            gerenciador.Adiciona(contaP);
            gerenciador.Adiciona(seguroV);
            gerenciador.Adiciona(contaInv);
            MessageBox.Show("Total: " + gerenciador.Total);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CadastroDeContas formularioDeCadastro = new CadastroDeContas(this);
            formularioDeCadastro.ShowDialog();

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            Conta conta = BuscaContaSelecionada();
            this.RemoveConta(conta);
        }

    
    }
}


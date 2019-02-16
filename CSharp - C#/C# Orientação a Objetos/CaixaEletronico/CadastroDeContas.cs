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
using benner.CaixaEletronico;

namespace CaixaEletronico
{
    public partial class CadastroDeContas : Form
    {
        private Form1 aplicacaoPrincipal;

        public CadastroDeContas(Form1 aplicacaoPrincipal) : this()
        {
            this.aplicacaoPrincipal = aplicacaoPrincipal;
        }

        public CadastroDeContas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta c;
            if (tipoDeConta.Text.Equals("Conta Poupança"))
            {
                c = new ContaPoupanca();
            }
            else if (tipoDeConta.Text.Equals("Conta Corrente"))
            {
                c = new ContaCorrente();
            }
            else
            {
                c = new ContaInvestimento();
            }

            c.Numero = Convert.ToInt32(numeroConta.Text);
            c.Titular = new Cliente();
            c.Titular.Nome = titularConta.Text;
            c.Titular.Cpf = cpfTitularConta.Text;
            c.Titular.Rg = rgTitularConta.Text;
            c.Titular.Endereco = enderecoTitularConta.Text;
            c.Titular.Idade = Convert.ToInt32(agenciaConta.Text);
            c.Agencia = Convert.ToInt32(agenciaConta.Text);
            this.aplicacaoPrincipal.AdicionaConta(c);
            this.Close();
        }


        private void CadastroDeContas_Load(object sender, EventArgs e)
        {
            this.tipoDeConta.Items.Add("Conta Corrente");
            this.tipoDeConta.Items.Add("Conta Poupança");
            this.tipoDeConta.Items.Add("Conta Investimento");
        }

        private void tipoDeConta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numeroConta_TextChanged(object sender, EventArgs e)
        {

        }

        private void titularConta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

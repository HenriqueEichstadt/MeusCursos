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
        public CadastroDeContas(Form1 aplicacaoPrincipal)
        {
            this.aplicacaoPrincipal = aplicacaoPrincipal;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // lendo os campos do formulario

            string cpfTitular = cpfTitularConta.Text;
            string rgTitular = rgTitularConta.Text;
            string enderecoTitular = enderecoTitularConta.Text;
            int numero = Convert.ToInt32(numeroConta.Text);
            int idade = Convert.ToInt32(idadeTitularConta.Text);
            int agencia = Convert.ToInt32(agenciaConta.Text);

            Cliente titular = new Cliente(titularConta.Text)
            {
                Cpf = cpfTitular,
                Rg = rgTitular,
                Endereco = enderecoTitular,
                Idade = idade
            };

            Conta conta = new ContaCorrente()
            {
                Numero = numero,
                Titular = titular,
                Agencia = agencia
            };

            this.aplicacaoPrincipal.AdicionaConta(conta);
            this.Close();
        }

        private void CadastroDeContas_Load(object sender, EventArgs e)
        {

        }
    }
}

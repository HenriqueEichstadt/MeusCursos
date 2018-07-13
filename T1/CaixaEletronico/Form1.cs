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
            Cliente cliente = new Cliente();
            conta.cliente = cliente;
            conta.titular = cliente;
            cliente.nome = "Fulano de Souza";
            /*Outras duas formas de fazer
            conta.titular = "Victor";
            conta.cliente.nome = "Victor";
            */
            conta.cliente.rg = "12345678-9";
            /*Outra forma de fazer
            cliente.rg = "12345678-9";
             */
            MessageBox.Show("Nome do Cliente: " + conta.titular.nome);
        }
    }
}


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
            Conta henrique = new Conta();
            henrique.deposita(2000.0);

            Conta maria = new Conta();
            maria.deposita(1000.0);

            henrique.Transfere(200.0, maria);
            henrique.deposita(150.0);
            maria.saca(50.0);

            MessageBox.Show("guilherme = " + henrique.saldo);
            MessageBox.Show("mauricio = " + maria.saldo);
        }
    }
}


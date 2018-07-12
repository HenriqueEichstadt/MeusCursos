using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotarEleicoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idade = 16;
            bool brasileira = true;

            if (idade >= 16 && brasileira == true)
            {
                MessageBox.Show("Você está apto a votar nas eleições");
            }
            else
            {
                MessageBox.Show("Você não pode votar");
            }
        }
    }
}

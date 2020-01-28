using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomaNumeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int somaNumeros = 0;
            for (int valor=1; valor<=1000; valor++)
            {
                somaNumeros += valor;
            }
            MessageBox.Show("A soma é de: " + somaNumeros);
        }
    }
}

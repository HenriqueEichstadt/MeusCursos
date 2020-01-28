using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumeroFibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string numeroFibonacci = "";
            int num1 = 0;
            int num2 = 1;

            while ( num2 <= 100)
            {
                numeroFibonacci += num2 + " ";
                int proximo = num1 + num2;
                num1 = num2;
                num2 = proximo;
            }
            MessageBox.Show("Os numeros Fibonacci até cem são: " + numeroFibonacci);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioSomaDeUmACem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int somaNum = 0;
            for (int i = 1; i <= 100; i++)
            {
               
                if ( i % 3 != 0)
                {
                    somaNum += i;
                }
            }
            MessageBox.Show("Os Numeros de 1 a 100 que não são multiplos de três: " + somaNum);
        }
    }
}

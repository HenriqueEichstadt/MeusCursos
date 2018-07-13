using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioOperadores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int numero = 1; numero < 30; numero++)
            {
                if (numero % 3 == 0 || numero % 4 == 0)
                {
                    MessageBox.Show(" O Números divisiveis por três e quatro são: " + numero);
                }
            }
        }
    }
}

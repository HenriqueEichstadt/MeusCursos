using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace EditorDeTexto
{
    public partial class EditorDeTexto : Form
    {
        public EditorDeTexto()
        {
            InitializeComponent();
        }

        private void textoEditorDeTexto_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("texto.txt"))
                if (File.Exists("texto.txt"))
                {
                    using (TextReader leitor = Console.In)
                    {
                        string conteudo = leitor.ReadToEnd();
                        textoEditorDeTexto.Text = conteudo;
                    }
                }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Stream saidaDeTexto = File.OpenWrite("texto.txt"))
            using (StreamWriter escritor = new StreamWriter(saidaDeTexto))
            {
                escritor.Write(textoEditorDeTexto.Text);
            }
        }
    }
}

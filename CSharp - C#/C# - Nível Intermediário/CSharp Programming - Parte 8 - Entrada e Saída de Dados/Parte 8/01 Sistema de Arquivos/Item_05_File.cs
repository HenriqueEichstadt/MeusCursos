using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Listings
{
    class Item_05_File 
    {
        static void XMain(string[] args)
        {
            //TAREFAS: GRAVAR E LER DADOS DE UM ARQUIVO USANDO A CLASSE File

            string conteudoInicial = "Conteúdo Inicial do arquivo";
            string conteudoAdicionalAoArquio = "\nConteúdo Adicional ao Arquivo";
            
            
            // Sobrescreve se arquivo já existir
            File.WriteAllText("Arquivo.txt", conteudoInicial);

            // Adicionando ao final do arquivo
            File.AppendAllText("Arquivo.txt", conteudoAdicionalAoArquio);

            if (File.Exists("Arquivo.txt"))
            {
                Console.WriteLine("O Arquivo já existe");
            }

            // Efetuando a leitura de do texto do arquivo
            var conteudo = File.ReadAllText("Arquivo.txt");
            Console.WriteLine("Conteúdo do arquivo:\n {0}", conteudo);

            // Copiando conteúdo de um arquivo para outro
            File.Copy("Arquivo.txt", "CopiaArquivo.txt", true);

            using (var leitor = File.OpenText("CopiaArquivo.txt"))
            {
                var texto = leitor.ReadToEnd();
                Console.WriteLine("Texto copiado: {0}", texto);
            }
            
            Console.ReadKey();

        }
    }
}

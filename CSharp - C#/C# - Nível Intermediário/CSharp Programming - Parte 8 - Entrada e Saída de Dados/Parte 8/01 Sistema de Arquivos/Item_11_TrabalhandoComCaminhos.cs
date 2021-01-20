using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Listings
{
    class Item_11_TrabalhandoComCaminhos
    {
        static void XMain(string[] args)
        {
            //TAREFAS:
            //Descobrir o caminho da pasta "Meus Documentos"
            //Combinar caminho da pasta "Meus Documentos" com arquivo "alura.txt"
            //Obter somente o nome do diretório do arquivo
            //Obter somente o nome do arquivo
            //Obter a extensão do arquivo
            //Modificar a extensão do arquivo

            var meusDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            Console.WriteLine("Meus documentos: {0}", meusDocumentos);

            string caminhoCompleto = Path.Combine(meusDocumentos, "alura.txt");
            Console.WriteLine("Caminho completo: {0}", caminhoCompleto);

            var somenteNomeDiretorio = Path.GetDirectoryName(caminhoCompleto);
            Console.WriteLine("Somente nome do diretório: {0}", somenteNomeDiretorio);
            
            var somenteNomeArquivo = Path.GetFileName(caminhoCompleto);
            Console.WriteLine("Somente nome do arquivo: {0}", somenteNomeArquivo);

            var extensaoArquivo = Path.GetExtension(caminhoCompleto);
            Console.WriteLine("Extensão do arquivo: {0}", extensaoArquivo);

            caminhoCompleto = Path.ChangeExtension(caminhoCompleto, "xyz");
            Console.WriteLine("Nova extensão do arquivo: {0}", caminhoCompleto);
            
            Console.ReadKey();
        }
    }
}

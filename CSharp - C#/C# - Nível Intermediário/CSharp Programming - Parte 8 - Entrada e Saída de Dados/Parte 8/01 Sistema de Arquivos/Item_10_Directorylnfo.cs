using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Listings
{
    class Item_10_Directorylnfo
    {
        private const string NomeDiretorio = "NovoDiretorio";
        
        static void XMain(string[] args)
        {
            //TAREFA:
            //Criar um novo diretório
            //Verificar se ele foi criado
            //Exibir os atributos do diretório
            //Exibir último acesso
            //Apagar o diretório que foi criado

            DirectoryInfo localDir = new DirectoryInfo(NomeDiretorio);
            localDir.Create();
            
            if(localDir.Exists)
                Console.WriteLine("O diretório foi criado com sucesso");

            Console.WriteLine("Atributos: {0}", localDir.Attributes);
            Console.WriteLine("Último acesso: {0}", localDir.LastAccessTime);
            
            localDir.Delete();
            Console.WriteLine("O diretório foi removido com sucesso");

            Console.ReadKey();
        }
    }
}

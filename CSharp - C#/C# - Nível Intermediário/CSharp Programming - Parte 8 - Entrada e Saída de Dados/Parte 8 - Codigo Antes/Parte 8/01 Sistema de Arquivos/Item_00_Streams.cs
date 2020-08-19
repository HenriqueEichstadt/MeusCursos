using System;
using System.IO;

namespace Listings
{
    class Item_00_Streams
    {
        static void XMain(string[] args)
        {
            //TAREFAS:
            //1. ABRIR O ARQUIVO Diretores.txt
            //2. LER 10 BYTES DO ARQUIVO
            //3. IMPRIMIR ESSES BYTES NO CONSOLE

            var fluxoDeArquivo = new FileStream("Diretores.txt", FileMode.Open, FileAccess.Read);
            
            byte[] array = new byte[10];
            int posicao = 0;
            int tamanho = 10;
            
            // PRIMEIRA LEITURA
            fluxoDeArquivo.Read(array, posicao, tamanho);
            
            foreach (var caractere in array)
            {
                Console.Write((char)caractere);
            }

            // SEGUNDA LEITURA
            // Salto relativo = relativo à posição atual
            // Salto absoluto = relativo à posição inicial do arquivo
            fluxoDeArquivo.Seek(5, SeekOrigin.Begin);

            // outra forma de fazer é definir a posição do arquivo
            fluxoDeArquivo.Position = 5;
                
            fluxoDeArquivo.Read(array, posicao, tamanho);
            
            foreach (var caractere in array)
            {
                Console.Write((char)caractere);
            }
            
            fluxoDeArquivo.Dispose();
            
            Console.ReadKey();
        }
    }
}
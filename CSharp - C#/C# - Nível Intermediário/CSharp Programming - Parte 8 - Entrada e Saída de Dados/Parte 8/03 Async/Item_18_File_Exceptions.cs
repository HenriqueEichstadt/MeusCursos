using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Listings
{
    class Item_18_File_Exceptions
    {
        static async Task XMain(string[] args)
        {
            //TAREFA: CAPTURAR A EXCEÇÃO 
            //GERADA POR UM MÉTODO ASSÍNCRONO

            byte[] dados = new byte[100];
            try
            {
                // nome do arquivo com caractere inválido ">"
                await GravarBytesAsync("destino>.dat", dados);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("escrita falhou");
            }
            Console.Read();
        }

        // Retornar sempre uma Task em métodos assincronos
        // Retornar uma Task permite que o código que chama o método
        // assíncrono consiga tratar o resultado e qualquer eventual exceção.
        static async Task GravarBytesAsync(string nomeArquivo, byte[] items)
        {
            using (FileStream fluxoSaida = new FileStream(nomeArquivo, FileMode.OpenOrCreate, FileAccess.Write))
            {
                await fluxoSaida.WriteAsync(items, 0, items.Length);
            }
        }
    }
}

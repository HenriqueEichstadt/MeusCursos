using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Listings
{
    class Item_06_Stream_Exceptions
    {
        static void XMain(string[] args)
        {
            try
            {

                string conteudo = File.ReadAllText("Arquivo.txt");

                Console.WriteLine($"O conteúdo é: {conteudo}");

            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("O arquivo não foi encontrado");
                Console.WriteLine(ex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Listings
{
    class Item_03_StreamWriter_And_StreamReader
    {
        static void XMain(string[] args)
        {
            //TAREFA: Usar FileStream dá muito trabalho...
            //        Não podemos usar algo mais simples??


            using (StreamWriter gravadorFluxo = new StreamWriter("ArquivoSaida.txt"))
            {
                gravadorFluxo.Write("Olá, Alura! (Gravado com StreamWriter)");
            }

            using (StreamReader leitorFluxo = new StreamReader("ArquivoSaida.txt"))
            {
                var text = leitorFluxo.ReadToEnd();
                Console.WriteLine("Texto lido: {0}", text);
            }
            
        }
    }
}

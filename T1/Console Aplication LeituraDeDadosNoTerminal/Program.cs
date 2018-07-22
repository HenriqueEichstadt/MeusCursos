using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Console_Aplication_LeituraDeDadosNoTerminal
{
    class Program
    {
        static void Main(string[] args)
        {
            TextReader leitorDeDados = Console.In;
            string linha = leitorDeDados.ReadLine();
            while (linha != null)
            {
                Console.WriteLine(linha);
                linha = leitorDeDados.ReadLine();
            }
        }
    }
}

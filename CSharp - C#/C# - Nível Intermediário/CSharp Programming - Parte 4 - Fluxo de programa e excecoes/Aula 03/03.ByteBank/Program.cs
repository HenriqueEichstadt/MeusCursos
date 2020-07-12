using System;
using System.Text.RegularExpressions;

namespace _03.ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GetFatorial(5);
            GetFatorial(4);
            GetFatorial(3);
            GetFatorial(2);
            GetFatorial(1);
            GetFatorial(0);
            
            RelatorioClientes.ImprimirListagemClientes();
            
            MenuCaixaEletronico menu = new MenuCaixaEletronico();
            menu.Executar();
        }

        private static int GetFatorial(int numero)
        {
            int fatorial = 1;
            int fator = numero;

            while (fator >= 1)
            {
                fatorial *= fator;
                fator--;
            }

            System.Console.WriteLine($"fatorial de {numero} é {fatorial}");

            return fatorial;
        }
    }
}
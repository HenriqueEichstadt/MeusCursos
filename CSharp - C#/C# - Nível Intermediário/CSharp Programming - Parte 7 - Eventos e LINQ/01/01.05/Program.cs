using System;
using System.Threading;
using System.Threading.Tasks;

namespace _01_05
{
    class Program
    {
        delegate int Operacao(int a, int b);

        static void Main(string[] args)
        {
            Operacao operacao = (a, b) => a + b;

            
            // Func é um delegado nativo que retorna valor
            // o último tipo de um delegado de função é seu retorno
            // int - parâmetro
            // int - parâmetro
            // int - retorno
            Func<int, int, int> somar = (x, y) => x + y;
            Console.WriteLine(somar(3, 2));

            // Delegado de ação
            // não retorna valor
            Action<string> imprimirMensagem
                = (mensagem) =>
                {
                    Console.WriteLine(mensagem);
                };

            imprimirMensagem("Olá, Alura!");


            var numeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Predicate é um delegado especializado em retornar booleanos
            Predicate<int> divisivelPor3 = (numero) => numero % 3 == 0;

            var divisiveis = Array.FindAll(numeros, divisivelPor3);
            
            foreach (var numero in divisiveis)
            {
                Console.WriteLine(numero);
            }
            
            Console.WriteLine(operacao(3, 2));
        }
    }
}
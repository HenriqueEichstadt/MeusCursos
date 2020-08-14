using System;

namespace _01_03
{
    class Program
    {
        delegate int Operacao(int a, int b);
        
        static void Main(string[] args)
        {
            int a = 3;
            int b = 2;
             
            //var operacao = new Operacao(Somar); // outra forma de criar 
            Operacao operacao = Somar;
            
            Console.WriteLine($"{operacao(a, b)}");
            
            operacao = Subtrair; 
            
            Console.WriteLine($"{operacao(a, b)}");
            
            Console.ReadKey();
        }

        public static int Somar(int a, int b)
        {
            Console.WriteLine($"A operação Somar foi chamada com a = {a} e b = {b}");
            return a + b;
        }

        public static int Subtrair(int a, int b)
        {
            Console.WriteLine($"A operação Subtrair foi chamada com a = {a} e b = {b}");
            return a - b;
        }
    }
}
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Metodo();
            Console.ReadLine();
        }
        //Teste com a cadeia de chamada:
        //Metodo -> TestaDivisao -> Dividir
        private static void Metodo()
        {
            TestaDivisao(2);
        }

        private static void TestaDivisao(int divisor)
        {
            try
            {
                int resultado = Dividir(10, divisor);
                Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Não é possível fazer uma divisão por zero!");
            }
            
        }

        private static int Dividir(int numero, int divisor)
        {
            return numero / divisor;
        }
    }
}
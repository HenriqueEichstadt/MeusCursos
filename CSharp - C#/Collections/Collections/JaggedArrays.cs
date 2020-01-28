using System;

namespace Collections
{
    public class JaggedArrays
    {
        public void Examples()
        {
            // familia 1: Família Flintstones
            // familia 2: Família Simpsons
            // familia 3: Família Dona Florinda

            // Jagged Arrays || Array de arrays || Array denteado || Array Serrilhado
            
            // Caso: Pessoas com números diferentes de integrantes na família
            string[][] familias = new string[3][];

            familias[0] = new string[] {"Fred", "Wilma", "Pedrita" };
            familias[1] = new string[] { "Homer", "Marge", "Lisa", "Bart", "Maggie" };
            familias[2] = new string[] { "Florinda", "Kiko" };

            foreach (var familia in familias)
            {
                Console.WriteLine(string.Join(",", familia));
            }
        }
    }
}
using System;

namespace Collections
{
    public  class ArrayMultidimencional
    {
        public  void Examples()
        {
            
            // Array Multidimencional

            string[,] resultados = new string[3, 3];
            resultados[0,0] = "Alemanha";
            resultados[1,0] = "Espanha";
            resultados[2,0] = "Itália";
            
            resultados[3,0] = "Argentina";
            resultados[4,0] = "Holanda";
            resultados[5,0] = "França";
            
            resultados[6,0] = "Holanda";
            resultados[7,0] = "Alemanha";
            resultados[8,0] = "Alemanha"; 
            
            string[,] resultado = new string[3, 3]
            {
                { "Alemanha", "Espanha", "Itália" },

                { "Argentina", "Holanda", "França" },

                { "Holanda", "Alemanha", "Alemanha" }
            };

            for (var copa = 0; copa < 3; copa++)
            {
                int ano = 2014 - copa * 4;
                Console.WriteLine(ano.ToString().PadRight(12));
            }
            Console.WriteLine();

            for (int posicao = 0; posicao < 3; posicao++)
            {
                for (int copa = 0; copa < 3; copa++)
                {
                    Console.Write(resultados[posicao, copa]);
                }
                Console.WriteLine();    
            }
        }
    }
}
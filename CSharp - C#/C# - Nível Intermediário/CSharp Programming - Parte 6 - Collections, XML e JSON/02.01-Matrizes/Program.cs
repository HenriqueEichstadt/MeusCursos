using System;
using System.Linq;

namespace _02._01
{
    class Program
    {
        static void Main(string[] args)
        {
            string alura = "Alura";
            string caelum = "Caelum";
            string casaDoCodigo = "Casa do Código";

            Console.WriteLine(alura);
            Console.WriteLine(caelum);
            Console.WriteLine(casaDoCodigo);
            
            // MATRIZ = ARRAY

            string[] empresas = new string[3];
            empresas[0] = alura;
            empresas[1] = caelum;
            empresas[2] = casaDoCodigo;

            string[] empresas2 =
            {
                alura, caelum, casaDoCodigo
            };

            var empresa3 = new[]
            {
                alura, caelum, casaDoCodigo
            };

            Imprimir(empresas);

            empresas[1] = "Caelum Ensino e Inovação";
            
            Imprimir(empresas);

            Console.WriteLine($"Primeiro elemento: {empresas[0]}");
            Console.WriteLine($"Último elemento: {empresas[empresas.Length-1]}");
            
            // Busca ocorrência no Array
            
            // Localizando o  índice da primeira ocorrência no array
            // Array.IndexOf() busca o índice da primeira ocorrência dentro de um array
            int indice = Array.IndexOf(empresas, "Casa do Código");
            Console.WriteLine($"O índice de 'Casa do código' é: {indice}");
            
            // Localizando o índice da última ocorrência dentro do array
            // Array.LastIndexOf() busca o índice da última ocorrência no array
            indice = Array.LastIndexOf(empresas, "Casa do Código");
            Console.WriteLine($"O último índice da ocorrência 'Casa do código' é: {indice}");

            Imprimir(empresas);
            // Revertendo a sequência do Array
            Array.Reverse(empresas);
            Imprimir(empresas);
            
            // Redimencionando o array (Truncanco a última posição do array)
            Array.Resize(ref empresas, 2);
            Imprimir(empresas);
            
            // Redimencionando o array (deixando a última posição vazia)
            Array.Resize(ref empresas, 3);
            empresas[empresas.Length - 1] = "Casa do Código";
            
            // Ordenando o Array pela ordem natural dos elementos (Alfanumérica/Ordem alfabética)
            Array.Sort(empresas);
            Imprimir(empresas);
            
            // Copiando um Array em outro
            string[] copia = new string[2];
            
            Array.Copy(empresas, 1, copia, 0, 2);
            Imprimir(copia);
            
            // Clonando um Array em um novo Array (noe o cast As String)
            string[] clone = empresas.Clone() as string[]; 
            Imprimir(clone);
            
            // Limpando alguns índices do Array
            Array.Clear(clone, 1, clone.Length-1);
            Imprimir(clone);
            
            
            
            Console.ReadKey();
        }

        private static void Imprimir(string[] empresas)
        {
            /*for (int i = 0; i < empresas.Length; i++)
            {
                string empresa = empresas[i];
                Console.WriteLine(empresa);
            }*/

            foreach (var empresa in empresas)
            {
                Console.WriteLine(empresa);
            }
        }

        public static void Alterar(string[] empresas)
        {
            empresas[0] = "Aluraadsasd";
            empresas[1] = "Caelumasdsad";
            empresas[2] = "Casa do Códigodsdasd";
        }
    }
}

using System;
using System.Collections.Generic;

namespace _02._04
{
    class Program
    {
        static void Main(string[] args)
        {
            var esperanca = new Filme("Episódio IV -Uma nova esperança", 1977);
            var imperio = new Filme("Episódio V -O Império Contra-Ataca", 1980);
            var retorno = new Filme("Episódio VI -O Retorno de Jedi", 1983);
            var ameaca = new Filme("Episódio I: A Ameaça Fantasma", 1999);
            
            // SETS = CONJUNTOS
            ISet<Filme> filmes = new HashSet<Filme>();

            // Adicionando: esperanca, imperio, retorno
            filmes.Add(esperanca);
            filmes.Add(imperio);
            filmes.Add(retorno);
            
            Imprimir(filmes);
            
            // Características do Set (conjunto)
            
            //1. Não permite duplicidade.
            filmes.Add(retorno);
            Imprimir(filmes);
            
            //2. Os elementos não são mantidos em ordem específica.
            filmes.Remove(imperio);
            Imprimir(filmes);
            filmes.Add(ameaca);
            
            //3. não permite acesso pelo índice
            //filmes[0];
            
            //Qual a vantagem do set sobre a lista? O tempo de pesquisa!
            //https://stackoverflow.com/a/10762995
            
            //desvantagem: consumo de memória.
            
            // É possível ordenar um conjunto? Não
            //filmes.Sort();
            
            // copiando para uma lista
            List<Filme> listaFilmes = new List<Filme>(filmes);
            // ordenando copia
            listaFilmes.Sort();
            // Imprimindo cópia
            Imprimir(listaFilmes);
            
            // verificando se objeto existe
            Console.WriteLine("O Filme Uma nova Esperança existe?: " + filmes.Contains(esperanca));
            
            // verificando se objeto com mesmos dados existe
            var novaEsperanca = new Filme("Episódio IV -Uma nova esperança", 1977);
            Console.WriteLine("O Filme Uma nova Esperança existe?: " + filmes.Contains(novaEsperanca));
        }
        
        private static void Imprimir(IEnumerable<Filme> lista)
        {
            foreach (var filme in lista)
            {
                Console.WriteLine(filme);
            }
        }
    }
}
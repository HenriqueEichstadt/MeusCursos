using System;
using System.Collections.Generic;

namespace _02._03
{
    class Program
    {
        static void Main(string[] args)
        {
            var esperanca = new Filme("Episódio IV -Uma nova esperança", 1977);
            var imperio = new Filme("Episódio V -O Império Contra-Ataca", 1980);
            var retorno = new Filme("Episódio VI -O Retorno de Jedi", 1983);
            var ameaca = new Filme("Episódio I: A Ameaça Fantasma", 1999);

            //DICIONÁRIO
            IDictionary<int, Filme> filmes = new Dictionary<int, Filme>();

            //adicionando: 34672-esperanca, 5617-imperio, 17646-retorno
            filmes.Add(34672, esperanca);
            filmes.Add(5617, imperio);
            filmes.Add(17646, retorno);

            // Imprimindo os filmes cadastrados
            Imprimir(filmes);
            
            //Um dicionário permite associar uma chave (ID do filme) a um valor (o filme)
            
            // Qual é o filme com ID 34672?
            Console.WriteLine("Qual é o filme com ID 34672?" + filmes[34672]);
            
            //E se tentarmos adicionar outro filme cmo a mesma chave 34672?
            //filmes.Add(34672, ameaca);
            
            // E se quisermos trocar o filme que tem a mesma chave?
            filmes[34672] = ameaca;
            
            //Pergunta: "Quem é o filme 34672 agora?"
            Console.WriteLine("Quem é o filme 34672 agora?" + filmes[34672]);
            
            // Buscando por uma chave inexistente
            Console.WriteLine("Buscando por uma chave inexistente: 34673" + filmes.ContainsKey(34673));
            
            // Buscando uma chave 34673 de forma segura
            filmes.TryGetValue(34673, out Filme filme34673);
            
            if(filme34673 != null)
                Console.WriteLine(filme34673);

        }

        private static void Imprimir(IDictionary<int, Filme> filmes)
        {
            foreach (var filme in filmes)
            {
                Console.WriteLine(filme);
            }
            Console.WriteLine();
        }
    }

    public class Filme : IComparable
    {
        public Filme(string titulo, int ano)
        {
            Titulo = titulo;
            Ano = ano;
        }

        public string Titulo { get; set; }
        public int Ano { get; set; }

        public int CompareTo(object obj)
        {
            Filme esta = this;
            Filme outra = obj as Filme;

            if (outra == null)
            {
                return 1;
            }

            return esta.Titulo.CompareTo(outra.Titulo);
        }

        public override string ToString()
        {
            return $"{Titulo} - {Ano}";
        }
    }
}

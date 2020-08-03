using System;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace _02._02._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var loja = new LojaDeFilmes();

            foreach (var filme in loja.Filmes)
            {
                Console.WriteLine(filme.Titulo);
            }

            Console.WriteLine();
            
            //loja.Filmes[0].Titulo = "EVITAR";
            
            foreach (var filme in loja.Filmes)
            {
                Console.WriteLine(filme.Titulo);
            }

            //loja.Filmes = new List<Filme>();

            // IReadOnlyCollection não permite alterar a lista
            //loja.Filmes.RemoveAt(0);
            //loja.Filmes.Add(new Filme(new Diretor("Zé Ninguém", 3), "Um Filme qualquer", "2019"));
            //loja.Filmes.RemoveAll();
            
        }

        

    }
}

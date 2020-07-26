using System;
using System.Collections.Generic;

namespace _02._02._1
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        private static LojaDeFilmes GetLoja()
        {
            return new LojaDeFilmes
            {
                Diretores = new List<Diretor>
                {
                    new Diretor("James Cameron",  5),
                    new Diretor("Francis Lawrence",  3),
                    new Diretor("Zack Snyder",  6),
                    new Diretor("Joss Whedon",  7),
                    new Diretor("Martin Scorsese",  4),
                    new Diretor("Christopher Nolan",  8),
                    new Diretor("Scott Derrickson",  4),
                    new Diretor("Gareth Edwards",  3),
                    new Diretor("Justin Kurzel",  6)
                },
                Filmes = new List<Filme> {
                    new Filme (
                        new Diretor ( "James Cameron", 5 ),
                        "Avatar",
                        "2009"
                    ),
                    new Filme (
                        new Diretor ( "Francis Lawrence", 3 ),
                        "I Am Legend",
                        "2007"
                    ),
                    new Filme (
                        new Diretor ( "Zack Snyder", 6 ),
                        "300",
                        "2006"
                    ),
                    new Filme (
                        new Diretor ( "Joss Whedon", 7 ),
                        "The Avengers",
                        "2012"
                    ),
                    new Filme (
                        new Diretor ( "Martin Scorsese", 4 ),
                        "The Wolf of Wall Street",
                        "2013"
                    ),
                    new Filme (
                        new Diretor ( "Christopher Nolan", 8 ),
                        "Interstellar",
                        "2014"
                    ),
                    new Filme (
                        new Diretor ( "Jeremy Podeswa", 3 ),
                        "Game of Thrones",
                        "2011–"
                    ),
                    new Filme (
                        new Diretor ( "Michael Hirst", 4 ),
                        "Vikings",
                        "2013–"
                    ),
                    new Filme (
                        new Diretor ( "Danny Cannon", 1 ),
                        "Gotham",
                        "2014–"
                    ),
                    new Filme (
                        new Diretor ( "Courtney Kemp", 1 ),
                        "Power",
                        "2014–"
                    ),
                    new Filme (
                        new Diretor ( "Jose Padilha", 4 ),
                        "Narcos",
                        "2015–"
                    ),
                    new Filme (
                        new Diretor ( "Vince Gilligan", 2 ),
                        "Breaking Bad",
                        "2008–2013"
                    ),
                    new Filme (
                        new Diretor ( "Scott Derrickson", 4 ),
                        "Doctor Strange",
                        "2016"
                    ),
                    new Filme (
                        new Diretor ( "Gareth Edwards", 3 ),
                        "Rogue One: A Star Wars Story",
                        "2016"
                    ),
                    new Filme (
                        new Diretor ( "Justin Kurzel", 6 ),
                        "Assassin's Creed",
                        "2016"
                    ),
                    new Filme (
                        new Diretor ( "Charles Murray", 1 ),
                        "Luke Cage",
                        "2016–"
                    )
                }
            };
        }

    }
}

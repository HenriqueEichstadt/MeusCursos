using System;
using System.Collections.Generic;

namespace _02._04
{
    public class Filme : IComparable
    {
        public Filme(string titulo, int ano)
        {
            Titulo = titulo;
            Ano = ano;
        }

        public string Titulo { get; set; }
        public int Ano { get; set; }

        public override string ToString()
        {
            return $"{Titulo} - {Ano}";
        }

        public int CompareTo(object obj)
        {
            Filme outra = obj as Filme;
            if (outra == null)
                return 1;

            return Titulo.CompareTo(outra.Titulo);
        }

        public override bool Equals(object obj)
        {
            Filme outro = obj as Filme;
            if (outro == null) 
                return false;

            return outro.Titulo.Equals(Titulo) && outro.Ano.Equals(Ano);
        }

        public override int GetHashCode()
        {
            var hashCode = -131496797;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode();
            hashCode = hashCode * -1521134295 + Ano.GetHashCode();
            return hashCode;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace Collections
{
    public class ConsultandoCollections
    {
        // Problema: Obter os nomes dos meses do ano
        // que tem 31 dias, em maiúsculo e em ordem alfabética;

        public void Examples()
        {
            List<Mes> meses = new List<Mes>
            {
                new Mes("Janeiro", 31),
                new Mes("Fevereiro", 28),
                new Mes("Março", 31),
                new Mes("Abril", 30),
                new Mes("Maio", 31),
                new Mes("Junho", 30),
                new Mes("Julho", 31),
                new Mes("Agosto", 31),
                new Mes("Setembro", 30),
                new Mes("Outubro", 31),
                new Mes("Novembro", 30),
                new Mes("Dezembro", 31)
            };
            
            // LINQ = Consulta integrada a linguagem
            IEnumerable<string> consulta = meses
                .Where(m => m.Dias == 31)
                .OrderBy(m => m.Nome)
                .Select(m => m.Nome.ToUpper());

            foreach (var item in consulta)
            {
                Console.WriteLine(item);
            }
        }
    }


    class Mes
    {
        public string Nome { get; private set; }
        public int Dias { get; private set; }

        public Mes(string nome, int dias)
        {
            Nome = nome;
            Dias = dias;
        }

        public override string ToString()
        {
        return $"{Nome} - {Dias}";
        }
    }
}
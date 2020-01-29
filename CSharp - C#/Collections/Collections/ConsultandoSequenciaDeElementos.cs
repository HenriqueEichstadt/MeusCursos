using System.Collections.Generic;
using System.Linq;

namespace Collections
{
    public class ConsultandoSequenciaDeElementos
    {
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

            // Pegar primeiros 3 itens da lista
            var consulta = meses.Take(3);
            
            // Pular os 3 primeiros itens da lista
            var consulta2 = meses.Skip(3);

            // Pegar os meses do 3º trimeste
            var consulta3 = meses.Skip(6).Take(3);
            
            // Pegar os meses até que o mês comece com a letra 'S'
            var consulta4 = meses.TakeWhile(a => !a.Nome.StartsWith("S"));
            
            // Pular os meses até que o mês comece com a letra 'S'
            var consulta5 = meses.SkipWhile(a => !a.Nome.StartsWith("S"));
            
            foreach (var item in consulta)
            {
                
            }
        }
    }
}
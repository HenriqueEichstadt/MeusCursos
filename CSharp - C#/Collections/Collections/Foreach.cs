using System;
using System.Collections.Generic;

namespace Collections
{
    public class Foreach
    {
        public void Examples()
        {
            IList<string> listaMeses = new List<string>
            {
                "Janeiro",  "Fevereiro",  "Março",  "Abril",
                "Maio",  "Junho",  "Julho",  "Agosto",
                "Setembro",  "Outubro",  "Novembro", "Dezembro"
            };

            foreach (var meses in listaMeses)
            {
                Console.WriteLine(meses);
            }
        }
    }
}
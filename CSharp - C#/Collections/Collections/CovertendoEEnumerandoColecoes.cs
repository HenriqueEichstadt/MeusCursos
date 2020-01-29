using System;
using System.Collections.Generic;

namespace Collections
{
    public class CovertendoEEnumerandoColecoes
    {
        public void Examples()
        {
            // Convertendo IList<string> para IList<object>
            
            IList<string> listaMeses = new List<string>
            {
                "Janeiro",  "Fevereiro",  "Março",  "Abril",
                "Maio",  "Junho",  "Julho",  "Agosto",
                "Setembro",  "Outubro",  "Novembro", "Dezembro"
            };

            //IList<object> listaObj = listaMeses;
            
            // Convertendo string[] para object[]?
            
            string[] arrayMeses = new string[]
            {
                "Janeiro",  "Fevereiro",  "Março",  "Abril",
                "Maio",  "Junho",  "Julho",  "Agosto",
                "Setembro",  "Outubro",  "Novembro", "Dezembro"
            };

            object[] arrayObj = arrayMeses; //Covariância de array
            Console.WriteLine();

            arrayObj[0] = "PRIMEIRO MÊS";
            Console.WriteLine(arrayObj[0]);
            Console.WriteLine();
            
            
            arrayObj[0] = 12345;
            Console.WriteLine(arrayObj[0]);
            Console.WriteLine();
            
            // Transformar List<string> para IEnumerable<object>

            IEnumerable<object> enumObj = listaMeses; // Covariância
            
        }
    }
}
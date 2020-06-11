using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class UsandoDynamic : IAulaItem
    {
        public void Executar()
        {
            // Tipo é definido em tempo de compilação
            string s = "Certificação C#";
            
            // Tipo é definido em tempo de compilação
            // O compilador infere automaticamente o tipo de acordo com valor que está sendo atribuido na inicialização. (por inferência).
            var v = "Certificação C#";
            
            // Tipo é definido em tempo de compilação
            object o = "Certificação C#";

            Console.WriteLine($"s: {s}");
            Console.WriteLine($"v: {v}");
            Console.WriteLine($"o: {o}");

            s = s.ToUpper();
            v = v.ToUpper();
            o = ((string)o).ToUpper();

            Console.WriteLine($"s: {s}");
            Console.WriteLine($"v: {v}");
            Console.WriteLine($"o: {o}");

            //s = 123;
            //v = 123;
            o = 123;

            o = (int)o + 4;

            Console.WriteLine($"o: {o}");

            /*
             * Apesar od dynamic se comportar como um objeto,
             * não deixamos para o compilador decidir qual o tipo da variável.
             * O tipo será definido em tempo de execução
             */
            dynamic d = "Certificação C#";
            Console.WriteLine($"d: {d}");
            d = d.ToUpper();
            Console.WriteLine($"d: {d}");
            d = 123;
            Console.WriteLine($"d: {d}");
            d = d + 4;
            Console.WriteLine($"d: {d}");
        }
    }
}

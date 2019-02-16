using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            var conta = new ContaCorrente(654354, 54654);
            Console.WriteLine(ContaCorrente.TaxaOperacao);

            Console.ReadLine();
        }
    }
}

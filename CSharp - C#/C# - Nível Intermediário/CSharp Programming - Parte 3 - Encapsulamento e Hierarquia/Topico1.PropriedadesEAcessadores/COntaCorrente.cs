using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topico1.PropriedadesEAcessadores
{
    class ContaCorrente: Conta
    {
        public ContaCorrente()
        {
            this.Saldo = 1000;
            Console.WriteLine($"Saldo: {Saldo}");
        }
    }
}

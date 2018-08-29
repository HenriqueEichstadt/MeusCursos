using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class Faturaa
    {
        public double ValorMensal { get; set; }
        public string Cliente { get; private set; }

        public Faturaa(double valorMensal, string cliente)
        {
            this.ValorMensal = valorMensal;
            this.Cliente = cliente;
        }
    }
}

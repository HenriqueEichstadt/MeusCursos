using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class Fatura
    {
        public double ValorMensal { get; set; }
        public string Cliente { get; private set; }

        public Fatura(double valorMensal, string cliente)
        {
            this.ValorMensal = valorMensal;
            this.Cliente = cliente;
        }
    }
}

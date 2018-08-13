using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Muitos_Descontos_e_o_Chain_of_Responsability
{
    public class SemDesconto : IDesconto
    {
        public IDesconto Proximo { get; set; }
        

        public double Desconta(Orcamento orcamento)
        {
            return 0;
        }
    }
}

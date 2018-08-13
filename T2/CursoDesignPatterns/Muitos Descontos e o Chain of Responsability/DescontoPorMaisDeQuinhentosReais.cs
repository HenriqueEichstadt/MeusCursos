using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Muitos_Descontos_e_o_Chain_of_Responsability
{
    public class DescontoPorMaisDeQuinhentosReais : IDesconto
    {
        public IDesconto Proximo { get; set; }
        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.Valor > 500.0)
            {
                return orcamento.Valor * 0.07;
            }
            return Proximo.Desconta(orcamento);
        }
    }
}

using CursoDesignPatterns.Muitos_Descontos_e_o_Chain_of_Responsability;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Strategy
{
    public class CalculadorDeDescontos
    {
        public double Calcula(Orcamento orcamento)
        {
            IDesconto d1 = new DescontoPorCincoItens();
            IDesconto d2 = new DescontoPorMaisDeQuinhentosReais();
            IDesconto d3 = new SemDesconto();

            d1.Proximo = d2;
            d2.Proximo = d3;


            return d1.Desconta(orcamento);
        }
    }
}

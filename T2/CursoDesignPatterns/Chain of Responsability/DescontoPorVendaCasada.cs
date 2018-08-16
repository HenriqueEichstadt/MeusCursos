using CursoDesignPatterns.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Muitos_Descontos_e_o_Chain_of_Responsability
{
    class DescontoPorVendaCasada : IDesconto
    {
        public IDesconto Proximo { get; set; }
        public double Desconta(Orcamento orcamento)
        {
            if(VendaCasada(orcamento))
            {
                return orcamento.Valor * 0.05;
            } else
            {
                return Proximo.Desconta(orcamento);
            }
        }

        private bool Existe(String nomeDoItem, Orcamento orcamento)
        {
            foreach (Item item in orcamento.Itens)
            {
                if (item.Nome.Equals(nomeDoItem))
                {
                    return true;
                }
            }
            return false;
        }
        private bool VendaCasada(Orcamento orcamento)
        {
            return Existe("CANETA", orcamento) && Existe("LAPIS", orcamento);
        }
    }
}

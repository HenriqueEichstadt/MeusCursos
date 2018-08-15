using CursoDesignPatterns.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Template_Method
{
    public class IKCV : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            if (orcamento.Valor > 500 && temItemMaiorQueCemReaisNo(orcamento))
            {
                return orcamento.Valor * 0.01;
            }
            return orcamento.Valor * 0.06;
        }
        private bool temItemMaiorQueCemReaisNo (Orcamento orcamento)
        {
            foreach (Item item in orcamento.Itens)
            {
                if (item.Valor > 100) return true;
            }
            return false;
        }
    }
}

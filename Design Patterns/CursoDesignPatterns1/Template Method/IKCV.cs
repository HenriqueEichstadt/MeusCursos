using CursoDesignPatterns.Decorator;
using CursoDesignPatterns.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Template_Method
{
    public class IKCV : TemplateDeImpostoCondicional
    {
        public IKCV() : base() { }
        public IKCV(Imposto novoImposto) : base (novoImposto) { }

        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            IList<String> ItensNomeIgual = new List<String>();

            foreach (Item item in orcamento.Itens)
            {
                if (ItensNomeIgual.Contains(item.Nome))
                    return true;
                else
                    ItensNomeIgual.Add(item.Nome);
            }
            return false;
        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.13 + 100;
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * (0.01 * orcamento.Itens.Count);
        }
        private bool temItemMaiorQueCemReaisNo(Orcamento orcamento)
        {
            foreach (Item item in orcamento.Itens)
            {
                if (item.Valor > 100) return true;
            }
            return false;
        }
    }
}

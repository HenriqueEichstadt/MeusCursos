using CursoDesignPatterns.Muitos_Descontos_e_o_Chain_of_Responsability.Exercicio_Servidor_Conta_Bancária;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Decorator
{
    public class FiltroMaiorQueQuinhentosMilReais : Filtro
    {
        public FiltroMaiorQueQuinhentosMilReais(Filtro novoFiltro) : base(novoFiltro) { }

        public FiltroMaiorQueQuinhentosMilReais() : base() { }

        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            IList<Conta> filtrada = new List<Conta>();
            foreach (Conta c in contas)
            {
                if (c.Valor > 500000) filtrada.Add(c);
            }
            foreach (Conta c in Proximo(contas))
            {
                filtrada.Add(c);
            }
            return filtrada;
        }
    }
}

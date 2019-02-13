using CursoDesignPatterns.Muitos_Descontos_e_o_Chain_of_Responsability.Exercicio_Servidor_Conta_Bancária;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Decorator
{
    public abstract class Filtro
    {
        public abstract IList<Conta> Filtra(IList<Conta> contas);

        protected Filtro OutroFiltro { get; set; }

        public Filtro(Filtro novoFiltro)
        {
            this.OutroFiltro = novoFiltro;
        }

        public Filtro() { }

        protected IList<Conta> Proximo(IList<Conta> contas)
        {
            if (OutroFiltro != null) return OutroFiltro.Filtra(contas);
            else return new List<Conta>();
        }
    }
}

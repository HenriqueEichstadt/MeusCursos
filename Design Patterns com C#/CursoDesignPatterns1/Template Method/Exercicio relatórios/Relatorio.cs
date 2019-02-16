using CursoDesignPatterns.Muitos_Descontos_e_o_Chain_of_Responsability.Exercicio_Servidor_Conta_Bancária;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Template_Method.Exercicio_relatórios
{
    abstract class Relatorio
    {
        protected abstract void Cabecalho();
        protected abstract void Rodape();
        protected abstract void Corpo(IList<Conta> contas);

        public void ImprimeRelatorio(IList<Conta> contas)
        {
            Cabecalho();
            Corpo(contas);
            Rodape();
        }
    }
}

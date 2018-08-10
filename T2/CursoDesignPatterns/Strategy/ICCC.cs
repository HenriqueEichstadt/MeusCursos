using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class ICCC : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            if (orcamento.Valor < 1000)
            {
                return 0.05 * orcamento.Valor;
            }
            else if (orcamento.Valor >= 1000 && orcamento.Valor <= 3000)
            {
                return 0.07 * orcamento.Valor;
            }
            else
            {
                return 0.08 * orcamento.Valor + 30.0;
            }
        }
    }
}

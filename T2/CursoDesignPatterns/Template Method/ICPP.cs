using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Template_Method
{
    public class ICPP : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            if (orcamento.Valor >= 500)
            {
                return orcamento.Valor * 0.07;
            }
            return orcamento.Valor * 0.05;
        }
    }
}

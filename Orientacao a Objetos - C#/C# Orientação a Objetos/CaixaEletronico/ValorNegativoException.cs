using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class ValorNegativoException : Exception
    {
        public ValorNegativoException()
            : base("Valor Negativo Não Permitido ")
        {
        }
    }
}

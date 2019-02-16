using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns2.Capitulo6___Bridges
{
    public interface IMensagem
    {
        IEnviador Enviador { get; set; }

        void Envia();
        string Formata();

    }
}

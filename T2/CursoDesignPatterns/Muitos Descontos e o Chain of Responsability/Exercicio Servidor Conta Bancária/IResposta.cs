using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Muitos_Descontos_e_o_Chain_of_Responsability.Exercicio_Servidor_Conta_Bancária
{
    public interface IResposta
    {
        void Responde(Requisicao req, Conta conta);
        IResposta OutraResposta { get; set; }
    }
}

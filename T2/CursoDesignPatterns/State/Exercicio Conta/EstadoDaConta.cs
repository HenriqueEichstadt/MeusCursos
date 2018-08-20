using CursoDesignPatterns.Muitos_Descontos_e_o_Chain_of_Responsability.Exercicio_Servidor_Conta_Bancária;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.State.Exercicio_Conta
{
    public interface EstadoDaConta
    {
        void Saca(Conta conta, double valor);
        void Deposita(Conta conta, double valor);
    }
}

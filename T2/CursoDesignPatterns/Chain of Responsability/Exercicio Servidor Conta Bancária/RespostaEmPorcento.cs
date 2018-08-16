using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Muitos_Descontos_e_o_Chain_of_Responsability.Exercicio_Servidor_Conta_Bancária
{
    public class RespostaEmPorcento
    {
        private IResposta OutraResposta { get; set; }

        public RespostaEmPorcento(IResposta novaResposta)
        {
            this.OutraResposta = novaResposta;
        }
        public RespostaEmPorcento()
        {
            this.OutraResposta = null;
        }


        public void Responde(Requisicao requisicao, Conta conta)
        {
            if (requisicao.Formato == Formato.PORCENTO)
            {
                Console.WriteLine(conta.Titular + '%' + conta.Saldo);
            }
            else if (OutraResposta != null)
            {
                OutraResposta.Responde(requisicao, conta);
            }
            else
            {
                throw new Exception("Formato de resposta não encontrado");
            }
        }
    }
}

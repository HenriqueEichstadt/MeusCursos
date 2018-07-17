using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class ContaPoupanca : Conta
    {
        //Método para depositar valor
        public override void Deposita(double valorDepositado)
        {
            double taxaDeDeposito = 0.1;
            if (valorDepositado > 0)
            {
                this.Saldo += valorDepositado - taxaDeDeposito;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    public class ContaInvestimento : Conta, ITributavel
    {
        //Método para calcular Tributos
        public double CalculaTributos()
        {
            return this.Saldo * 0.02;
        }


        // Métodos da Classe Conta

        //Método para depositar valor
        public override void Deposita(double valorDepositado)
        {
            if (valorDepositado > 0)
            {
                this.Saldo += valorDepositado;
            }
        }

        // Método para Sacar valor
        public override bool Sacar(double valorSacado)
        {
            if (valorSacado > this.Saldo || valorSacado < 0)
            {
                return false;
            }
            else
            {
                if (this.Titular.maiorDeIdade())
                {
                    this.Saldo -= valorSacado;
                    return true;
                }
                else
                {
                    if (valorSacado <= 200)
                    {
                        this.Saldo -= valorSacado;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        //Método para Transferir valor para outra conta    
        public override void TransferirParaAlguem(Conta destino, double valor)
        {
            this.Sacar(valor);
            destino.Deposita(valor);
        }
    }
}



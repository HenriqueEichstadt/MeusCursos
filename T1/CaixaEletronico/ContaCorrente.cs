using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bennerCaixaEletronicoModeloContas;
using bennerCaixaEletronicoModelo;

namespace bennerCaixaEletronicoModeloContas
{
    class ContaCorrente : Conta
    {
        //Método para depositar valor
        public override void Deposita(double valorDepositado)
        {
            if (valorDepositado > 0)
            {
                this.Saldo += valorDepositado;
            }
        }

        // Método para Sacar valor
        public override void Sacar(double valorSacado)
        {

            if (valorSacado > this.Saldo || valorSacado < 0)
            {
                throw new SaldoInsuficienteException("Valor do saque maior que o saldo ou valor negativo");
                
            }
            else
            {
                if (this.Titular.maiorDeIdade())
                {
                    this.Saldo -= valorSacado;
                    
                }
                else
                {
                    if (valorSacado <= 200)
                    {
                        this.Saldo -= valorSacado;
                        
                    }
                    else
                    {
                        throw new ArgumentException();
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

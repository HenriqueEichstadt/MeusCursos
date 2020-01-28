using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using benner.CaixaEletronico.Modelo.Contas;
using benner.CaixaEletronico.Modelo;

namespace benner.CaixaEletronico.Modelo.Contas
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
            else
            {
                throw new ArgumentException();
            }
        }

        // Método para Sacar valor
        public override void Sacar(double valorSacado)
        {
            if (valorSacado < 0)
            {
                throw new ArgumentException();
            }
            if (valorSacado > this.Saldo)
            {
                throw new SaldoInsuficienteException();
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
                        throw new MenorDeIdadeException();
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

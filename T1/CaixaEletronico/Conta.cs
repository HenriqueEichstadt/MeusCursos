using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class Conta
    {
        public int numero;

        public string titular;

        public double saldo;

        public long CPF;

        public int agencia;

        public void deposita (double valorDepositado)
        {
            if (valorDepositado > 0)
            {
                this.saldo += valorDepositado;
            }
        }
        public void saca (double valorSacado)
        {
            if (this.saldo >= valorSacado && valorSacado > 0)
            {
                this.saldo -= valorSacado;
            }
        }
        public void Transfere(double valor, Conta destino)
        {
            this.saca(valor);
            destino.deposita(valor);
        }
    }
}

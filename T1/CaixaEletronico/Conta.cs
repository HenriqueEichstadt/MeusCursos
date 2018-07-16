using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class Conta
    {
        public Cliente cliente;

        public int numero;

        public Cliente titular;

        public double saldo;

        public int agencia;

        public void deposita (double valorDepositado)
        {
            if (valorDepositado > 0)
            {
                this.saldo += valorDepositado;
            }
        }
        public bool Sacar (double valorSacado)
        {
            if (valorSacado > this.saldo || valorSacado < 0)
            {
                return false;
            }
            else
            {
                if (this.titular.maiorDeIdade())
                {
                    this.saldo -= valorSacado;
                    return true;
                }
                else
                {
                    if (valorSacado <= 200)
                    {
                        this.saldo -= valorSacado;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public void Transfere(double valor, Conta destino)
        {
            this.Sacar(valor);
            destino.deposita(valor);
        }
    }
}

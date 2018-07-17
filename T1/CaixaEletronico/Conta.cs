using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class Conta
    {
        //Propriedades da Classe Conta

        public Cliente Cliente { get; set; }

        public Cliente Titular { get; set; }

        public int Numero { get; set; }

        public double Saldo { get; set; }

        public int Agencia { get; set; }

        // Métodos da Classe Conta

        //Método para depositar valor
        public void Deposita(double valorDepositado)
        {
            if (valorDepositado > 0)
            {
                this.Saldo += valorDepositado;
            }
        }
        public bool Sacar (double valorSacado)
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

        public void Transfere(double valor, Conta destino)
        {
            this.Sacar(valor);
            destino.Deposita(valor);
        }
    }
}

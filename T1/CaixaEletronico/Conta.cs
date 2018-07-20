using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using benner.CaixaEletronico.Usuarios;
namespace benner.CaixaEletronico.Modelo.Contas
{
    public abstract class Conta
    {
        //Propriedades da Classe Conta

        //public Cliente Cliente { get; set; }

        public Cliente Titular { get; set; }

        public int Numero { get; set; }

        public double Saldo { get; protected set; }

        public int Agencia { get; set; }

        // Métodos da Classe Conta

        //Método para depositar valor
        public abstract void Deposita(double valorDepositado);

        // Método Abstrato Sacar
        public abstract void Sacar(double valorSacado);
        
        //public void Transfere(double valor, Conta destino)
        public abstract void TransferirParaAlguem(Conta destino, double valor);

    }
}


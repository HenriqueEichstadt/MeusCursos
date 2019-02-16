using CursoDesignPatterns.State.Exercicio_Conta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Muitos_Descontos_e_o_Chain_of_Responsability.Exercicio_Servidor_Conta_Bancária
{
    public class Conta
    {
        public String Titular { get; set; }
        public double Saldo { get; set; }
        public string Nome { get; set; }
        public string Numero { get; internal set; }
        public string Agencia { get; internal set; }

        public double Valor { get; set;}
        public DateTime DataAbertura { get; internal set; }
        public Negativo Estado { get; internal set; }
        public Positivo Estado2 { get; internal set; }

        public Conta(String titular, double saldo)
        {
            this.Titular = titular;
            this.Saldo = saldo;
        }

         public void Deposita(double valor)
        {
            this.Saldo += valor;
        }
    }
}

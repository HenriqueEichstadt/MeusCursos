using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Strategy
{
    public class Conta
    {
        public double Saldo { get; set; }
        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }

    }
}

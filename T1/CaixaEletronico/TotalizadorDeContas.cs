using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using benner.CaixaEletronico.Modelo.Contas;
using benner.CaixaEletronico.Usuarios;

namespace benner.CaixaEletronico
{
    class TotalizadorDeContas
    {
        public double SaldoTotal { get; private set; }
        public void Adiciona(Conta conta)
        {
            this.SaldoTotal += conta.Saldo;
        }
    }
}

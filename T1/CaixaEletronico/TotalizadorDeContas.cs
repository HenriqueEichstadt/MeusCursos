using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bennerCaixaEletronicoModeloContas;
using bennerCaixaEletronicoUsuarios;

namespace bennerCaixaEletronico
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

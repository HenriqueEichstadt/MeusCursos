using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bennerCaixaEletronicoModeloContas;
using bennerCaixaEletronicoUsuarios;

namespace bennerCaixaEletronicoBancos
{
    class Banco
    {
        private Conta[] contas = new Conta[10];
        private int quantidadeDeContas;

        public void Adiciona(Conta conta)
        {
            this.contas[this.quantidadeDeContas] = conta;
            this.quantidadeDeContas++;
        }
    }
}

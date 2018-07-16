using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class Cliente
    {
        public string nome;

        public string rg;

        public string endereco;

        public long cpf;

        public int idade;

        public bool maiorDeIdade()
        {
            return this.idade >= 18;
        }
    }


}

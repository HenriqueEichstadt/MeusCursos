using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class Cliente
    {
        //Propriedades da Classe Conta
        public string Nome { get; set; }

        public string Rg { get; set; }

        public string Endereco { get; set; }

        public long Cpf { get; set; }

        public int Idade { get; set; }

        public bool maiorDeIdade()
        {
            return this.Idade >= 18;
        }

        // Construtores
        //Pede para adicionar o nome do cliente
        public Cliente(string nome)
        {
            this.Nome = nome;
        }
        //Tornando o parametro nome opcional
        public Cliente() { }
    }


}

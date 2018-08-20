using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Builder
{
    public class ItemDaNotaBuilder
    {
        public String Descricao { get; private set; }
        public double Valor { get; private set; }

        public ItemDaNotaBuilder ComDescricao(String descricao)
        {
            this.Descricao = descricao;
            return this;
        }

        public ItemDaNotaBuilder ComValor(double valor)
        {
            this.Valor = valor;
            return this;
        }

        public ItemDaNota Constroi()
        {
            return new ItemDaNota(Descricao, Valor);
        }
    }
}

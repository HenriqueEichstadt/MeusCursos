using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns2.Capitulo7___Command
{
    public class PagaPedido : IComando
    {
        private Pedido pedido;
        public PagaPedido(Pedido pedido)
        {
            this.pedido = pedido;
        }
       
        public void Executa()
        {
            Console.WriteLine("Pagando o Pedido do cliente {0}", pedido.Cliente);
            pedido.Paga();
        }
    }
}

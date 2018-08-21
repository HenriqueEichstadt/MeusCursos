using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns2.Capitulo4___Interpreter
{
    public class Numero : IExpressao
    {
        private int numero;

        public Numero(int numero)
        {
            this.numero = numero;
        }
        public int Avalia()
        {
            return this.numero;
        }
    }
}

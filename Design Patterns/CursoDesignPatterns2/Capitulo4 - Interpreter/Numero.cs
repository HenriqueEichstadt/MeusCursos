using CursoDesignPatterns2.Capitulo5___Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns2.Capitulo4___Interpreter
{
    public class Numero : IExpressao
    {
        public int Valor { get; set; }

        public Numero(int numero)
        {
            this.Valor = numero;
        }
        public int Avalia()
        {
            return this.Valor;
        }
        public void Aceita(IVisitor impressora)
        {
            impressora.ImprimeNumero(this);
        }
    }
}

using CursoDesignPatterns2.Capitulo5___Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns2.Capitulo4___Interpreter
{
    public class RaizQuadrada : IExpressao
    {
        private IExpressao expressao;

        public RaizQuadrada(IExpressao express)
        {
            this.expressao = express;
        }

        public int Avalia()
        {
            return (int)Math.Sqrt(expressao.Avalia());
        }
        public void Aceita(ImpressoraVisitor impressora)
        {
            impressora.ImprimeRaizQuadrada(this);
        }

        public void Aceita(IVisitor impressora)
        {
            throw new NotImplementedException();
        }
    }
}

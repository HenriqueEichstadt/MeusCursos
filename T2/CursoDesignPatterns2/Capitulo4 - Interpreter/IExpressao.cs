using CursoDesignPatterns2.Capitulo5___Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns2.Capitulo4___Interpreter
{
    public interface IExpressao
    {
        int Avalia();

        void Aceita(IVisitor impressora);
    }
}

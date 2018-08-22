using CursoDesignPatterns2.Capitulo4___Interpreter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns2.Capitulo5___Visitor
{
    public interface IVisitor
    {
        void ImprimeSoma(Soma soma);

        void ImprimeSubtracao(Subtracao subtracao);

        void ImprimeDivisao(Divisao divisao);

        void ImprimeRaizQuadrada(RaizQuadrada raizQuadrada);

        void ImprimeNumero(Numero numero);
    }
}

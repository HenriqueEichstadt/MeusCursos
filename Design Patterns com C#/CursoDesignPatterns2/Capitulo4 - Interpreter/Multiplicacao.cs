﻿using CursoDesignPatterns2.Capitulo5___Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns2.Capitulo4___Interpreter
{
    public class Multiplicacao : IExpressao
    {
        public IExpressao Esquerda { get; set; }
        public IExpressao Direita { get; set; }

        public Multiplicacao(IExpressao esquerda, IExpressao direita)
        {
            this.Esquerda = esquerda;
            this.Direita = direita;
        }
        public int Avalia()
        {
            int valorEsquerda = Esquerda.Avalia();
            int valorDireita = Direita.Avalia();
            return valorEsquerda * valorDireita;
        }
        public void Aceita(IVisitor impressora)
        {
            impressora.ImprimeMultiplicacao(this);
        }
    }
}
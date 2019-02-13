using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using benner.CaixaEletronico.Modelo;

namespace benner.CaixaEletronico
{
    class SeguroDeVida : ITributavel
    {
        public double CalculaTributos()
        {
            return 42.0;
        }
    }
}


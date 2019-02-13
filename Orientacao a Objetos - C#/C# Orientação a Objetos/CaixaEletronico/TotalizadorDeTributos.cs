using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using benner.CaixaEletronico.Modelo;

namespace benner.CaixaEletronico
{
    class TotalizadorDeTributos
    {
        public double Total { get; private set; }

        public void Acumula (ITributavel contas)
        {
            this.Total += contas.CalculaTributos();

        }
    }
}

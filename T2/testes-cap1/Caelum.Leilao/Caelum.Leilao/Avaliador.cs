using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caelum.Leilao
{
    public class Avaliador
    {
        private double maiorDeTodos = Double.MinValue;
        private double menorDeTodos = Double.MaxValue;
        private double media;

        public void Avalia(Leilao leilao)
        {
            double total = 0;
            foreach (Lance lance in leilao.Lances)
            {
                if(lance.Valor > maiorDeTodos)
                {
                    maiorDeTodos = lance.Valor;
                }
                if(lance.Valor < menorDeTodos)
                {
                    menorDeTodos = lance.Valor;
                }
                total += lance.Valor;
            }
            media = total / leilao.Lances.Count;
        }

        public double MaiorLance
        {
            get { return maiorDeTodos; }
        }
        public double MenorLance
        {
            get { return menorDeTodos; }
        }
        public double Media
        {
            get { return media; }
        }
    }
}

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
        private List<Lance> maiores;

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
            PegaOsMaioresNo(leilao);
        }

        private void PegaOsMaioresNo(Leilao leilao)
        {
            var filtro = leilao.Lances.OrderByDescending(p => p.Valor).Take(3);
            maiores = new List<Lance>(filtro);

        }
        public List<Lance> TresMaiores
        {
            get { return this.maiores; }
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

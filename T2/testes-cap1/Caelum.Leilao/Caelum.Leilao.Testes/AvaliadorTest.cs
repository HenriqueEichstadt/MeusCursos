using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caelum.Leilao.Testes
{
    [TestFixture]
    public class AvaliadorTest
    {
        [Test]
        public void DeveEntenderlancesEmOrdemCrescente()
        {
            Usuario henrique = new Usuario("Henrique");
            Usuario davi = new Usuario("Davi");
            Usuario guilherme = new Usuario("Guilherme");

            Leilao leilao = new Leilao("PS3");

            leilao.Propoe(new Lance(henrique, 400));
            leilao.Propoe(new Lance(guilherme, 250));
            leilao.Propoe(new Lance(guilherme, 300));

            Avaliador leioeiro = new Avaliador();
            leioeiro.Avalia(leilao);


            double maiorEsperado = 400;
            double menorEsperado = 250;

            Assert.AreEqual(maiorEsperado, leioeiro.MaiorLance, 0.00001);
            Assert.AreEqual(menorEsperado, leioeiro.MenorLance);

        }

        [Test]
        public void DeveCalcularAMedia()
        {
            Usuario dylan = new Usuario("Dylan");
            Usuario walter = new Usuario("Walter");
            Usuario maria = new Usuario("Maria");

            Leilao leilao = new Leilao("PS3 novo");

            leilao.Propoe(new Lance(dylan, 1500));
            leilao.Propoe(new Lance(walter , 1000));
            leilao.Propoe(new Lance(maria, 500));

            Avaliador leiloeiro = new Avaliador();
            leiloeiro.Avalia(leilao);

            Assert.AreEqual(1000, leiloeiro.Media);
        }
    }
}

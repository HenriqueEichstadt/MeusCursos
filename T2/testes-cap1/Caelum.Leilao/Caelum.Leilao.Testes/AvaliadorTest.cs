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
        public void DeveEntenderLancesEmOrdemCrescente()
        {
            Usuario henrique = new Usuario("Henrique");
            Usuario davi = new Usuario("Davi");
            Usuario guilherme = new Usuario("Guilherme");

            Leilao leilao = new Leilao("PS3");

            leilao.Propoe(new Lance(henrique, 1000));
            leilao.Propoe(new Lance(guilherme, 2000));
            leilao.Propoe(new Lance(guilherme, 3000));

            Avaliador leioeiro = new Avaliador();
            leioeiro.Avalia(leilao);

            Assert.AreEqual(3000, leioeiro.MaiorLance, 0.00001);
            Assert.AreEqual(1000, leioeiro.MenorLance, 0.00001);

        }

        [Test]
        public void DeveENtenderLancesEmOrdemDecrescente()
        {
            Usuario henrique = new Usuario("Henrique");
            Usuario davi = new Usuario("Davi");
            Usuario guilherme = new Usuario("Guilherme");

            Leilao leilao = new Leilao("PS3");

            leilao.Propoe(new Lance(henrique, 3000));
            leilao.Propoe(new Lance(guilherme, 2000));
            leilao.Propoe(new Lance(guilherme, 1000));

            Avaliador leioeiro = new Avaliador();
            leioeiro.Avalia(leilao);

            Assert.AreEqual(3000, leioeiro.MaiorLance, 0.00001);
            Assert.AreEqual(1000, leioeiro.MenorLance, 0.00001);

        }

        [Test]
        public void DeveEntenderLeilaoComApenasUmLance()
        {
            Usuario henrique = new Usuario("Henrique");
            Leilao leilao = new Leilao("PS4");

            leilao.Propoe(new Lance(henrique, 1000));
            Avaliador leioeiro = new Avaliador();
            leioeiro.Avalia(leilao);

            Assert.AreEqual(1000, leioeiro.MaiorLance, 0.0001);
            Assert.AreEqual(1000, leioeiro.MenorLance, 0.0001);
        }   

        [Test]
        public void DeveEntenderLeilaoComLancesAleatorios()
        {
            Usuario henrique = new Usuario("Henrique");
            Usuario davi = new Usuario("Davi");
            Usuario guilherme = new Usuario("Guilherme");

            Leilao leilao = new Leilao("PS3");

            leilao.Propoe(new Lance(henrique, 355));
            leilao.Propoe(new Lance(guilherme, 199));
            leilao.Propoe(new Lance(davi, 245));
            leilao.Propoe(new Lance(henrique, 2999));
            leilao.Propoe(new Lance(guilherme, 533));
            leilao.Propoe(new Lance(davi, 1536));

            Avaliador leioeiro = new Avaliador();
            leioeiro.Avalia(leilao);

            Assert.AreEqual(2999, leioeiro.MaiorLance, 0.00001);
            Assert.AreEqual(199, leioeiro.MenorLance, 0.00001);
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
        [Test]
        public void DeveEncontrarOsTresMaioresLances()
        {
            Usuario henrique = new Usuario("Henrique");
            Usuario maria = new Usuario("Maria");
            Leilao leilao = new Leilao("PS4");

            leilao.Propoe(new Lance(henrique, 100.0));
            leilao.Propoe(new Lance(maria, 200.0));
            leilao.Propoe(new Lance(henrique, 300.0));
            leilao.Propoe(new Lance(maria, 400.0));

            Avaliador leiloeiro = new Avaliador();
            leiloeiro.Avalia(leilao);

            var maiores = leiloeiro.TresMaiores;

            Assert.AreEqual(3, maiores.Count);
            Assert.AreEqual(400, maiores[0].Valor, 0.0001);
            Assert.AreEqual(300, maiores[1].Valor, 0.0001);
            Assert.AreEqual(200, maiores[2].Valor, 0.0001);
        }
    }
}

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
        private Avaliador leiloeiro;
        private Usuario henrique;
        private Usuario joao;
        private Usuario jose;

        [SetUp]
        public void CriaAvaliador()
        {
            this.leiloeiro = new Avaliador();
            Console.WriteLine("inicializando teste!");
            this.henrique = new Usuario("Henrique");
            this.joao = new Usuario("João");
            this.jose = new Usuario("José");
        }
        [TearDown]
        public void Finaliza()
        {
            Console.WriteLine("fim");
        }

        [Test]
        public void DeveEntenderLeilaoComApenasUmLance()
        {
            Leilao leilao = new CriadorDeLeilao().Para("TV Samsung 4K")
               .Lance(joao, 1000)
               .Constroi();


            leiloeiro.Avalia(leilao);

            Assert.AreEqual(1000, leiloeiro.MaiorLance, 0.0001);
            Assert.AreEqual(1000, leiloeiro.MenorLance, 0.0001);
            Finaliza();
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


            leiloeiro.Avalia(leilao);

            Assert.AreEqual(2999, leiloeiro.MaiorLance, 0.00001);
            Assert.AreEqual(199, leiloeiro.MenorLance, 0.00001);
        }

        [Test]
        public void DeveCalcularAMedia()
        {
            Usuario dylan = new Usuario("Dylan");
            Usuario walter = new Usuario("Walter");
            Usuario maria = new Usuario("Maria");

            Leilao leilao = new Leilao("PS3 novo");

            leilao.Propoe(new Lance(dylan, 1500));
            leilao.Propoe(new Lance(walter, 1000));
            leilao.Propoe(new Lance(maria, 500));


            leiloeiro.Avalia(leilao);

            Assert.AreEqual(1000, leiloeiro.Media);
        }
        [Test]
        public void DeveEncontrarOsTresMaioresLances()
        {
            Leilao leilao = new CriadorDeLeilao().Para("TV Samsung 4K")
                .Lance(joao, 100)
                .Lance(jose, 200)
                .Lance(henrique, 300)
                .Lance(joao, 400)
                .Constroi();

            leiloeiro.Avalia(leilao);

            var maiores = leiloeiro.TresMaiores;

            Assert.AreEqual(3, maiores.Count);
            Assert.AreEqual(400, maiores[0].Valor, 0.0001);
            Assert.AreEqual(300, maiores[1].Valor, 0.0001);
            Assert.AreEqual(200, maiores[2].Valor, 0.0001);
        }

        [Test]
        [ExpectedException(typeof(Exception))]
        public void NaoDeveAvaliarLeiloesSemNenhumLanceDado()
        {
            Leilao leilao = new CriadorDeLeilao().Para("PC Gamer").Constroi();
            leiloeiro.Avalia(leilao);


        }
    }
}

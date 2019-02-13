using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Compatibility;
using NUnit.Framework;

namespace Caelum.Leilao.Testes
{
    [TestFixture]
    public class LeilaoTest
    {
        [Test]
        public void DeveReceberUmLance()
        {
            Leilao leilao = new Leilao("Notebook AVELL");
            Assert.AreEqual(0, leilao.Lances.Count);

            var usuario = new Usuario("Henrique");
            leilao.Propoe(new Lance(usuario, 5000));

            Assert.AreEqual(1, leilao.Lances.Count);
            Assert.AreEqual(5000, leilao.Lances[0].Valor, 0.0001);
        }

        [Test]
        public void DeveReceberVariosLances()
        {
            Leilao leilao = new Leilao("Notebook AVELL");
            Assert.AreEqual(0, leilao.Lances.Count);

            leilao.Propoe(new Lance(new Usuario("Steve Jobs"), 2000));
            leilao.Propoe(new Lance(new Usuario("Steve Wosniak"), 3000));

            Assert.AreEqual(2, leilao.Lances.Count, 0.00001);
            Assert.AreEqual(2000, leilao.Lances[0].Valor, 0.00001);
            Assert.AreEqual(3000, leilao.Lances[1].Valor, 0.00001);
        }
        [Test]
        public void NaoDeveTerDoisLancesSeguidosDoMesmoUsuario()
        {
            Leilao leilao = new Leilao("Notebook AVELL");
            var henrique = new Usuario("Henrique");

            leilao.Propoe(new Lance(henrique, 2000));
            leilao.Propoe(new Lance(henrique, 3000));

            Assert.AreEqual(1, leilao.Lances.Count);
            Assert.AreEqual(2000, leilao.Lances[0].Valor, 0.0001);
        }


        [Test]
        public void NaoDeveAceitarMaisDoQue5Lances()
        {
            Leilao leilao = new Leilao("Notebook AVELL");
            Usuario henrique = new Usuario("Henrique");
            Usuario aline = new Usuario("Aline");

            leilao.Propoe(new Lance(henrique, 2000));
            leilao.Propoe(new Lance(aline, 3000));

            leilao.Propoe(new Lance(henrique, 4000));
            leilao.Propoe(new Lance(aline, 5000));

            leilao.Propoe(new Lance(henrique, 6000));
            leilao.Propoe(new Lance(aline, 7000));

            leilao.Propoe(new Lance(henrique, 8000));
            leilao.Propoe(new Lance(aline, 9000));

            leilao.Propoe(new Lance(henrique, 10000));
            leilao.Propoe(new Lance(aline, 11000));

            //deve ser ignorado
            leilao.Propoe(new Lance(henrique, 12000));

            Assert.AreEqual(10, leilao.Lances.Count);
            var ultimo = leilao.Lances.Count - 1;
            Lance ultimoLance = leilao.Lances[ultimo];

            Assert.AreEqual(11000, ultimoLance.Valor, 0.00001);
        }
        [Test]
        public void DeveDobrarOUltimoLanceDado()
        {
            Leilao leilao = new Leilao("Macbook Pro 15");
            Usuario steveJobs = new Usuario("Steve Jobs");
            Usuario billGates = new Usuario("Bill Gates");

            leilao.Propoe(new Lance(steveJobs, 2000));
            leilao.Propoe(new Lance(billGates, 3000));
            leilao.DobraLance(steveJobs);

            Assert.AreEqual(4000, leilao.Lances[2].Valor, 0.00001);
        }

        [Test]
        public void NaoDeveDobrarCasoNaoHajaLanceAnterior()
        {
            Leilao leilao = new Leilao("Macbook Pro 15");
            Usuario steveJobs = new Usuario("Steve Jobs");

            leilao.DobraLance(steveJobs);

            Assert.AreEqual(0, leilao.Lances.Count);
        }
    }
}


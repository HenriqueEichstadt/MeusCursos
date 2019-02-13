using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caelum.Leilao;

namespace Caelum.Leilao.Testes
{
    [TestFixture]
    class MatematicaMalucaTest
    {
        [Test]
        public void TesteParaMultiplicarNumerosMaioresQue30()
        {
            MatematicaMaluca matematica = new MatematicaMaluca();
            Assert.AreEqual(50 * 4, matematica.ContaMaluca(50));
        }

        [Test]
        public void TestePParaMultiplicarNumerosMaioresQue10EMenoresQue30()
        {
            MatematicaMaluca matematica = new MatematicaMaluca();
            Assert.AreEqual(20 * 3, matematica.ContaMaluca(20));
        }

        [Test]
        public void TesteParaMultiplicarNumerosMenoresQue10()
        {
            MatematicaMaluca matematica = new MatematicaMaluca();
            Assert.AreEqual(5 * 2, matematica.ContaMaluca(5));
        }
    }
}

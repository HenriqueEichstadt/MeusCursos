using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caelum.Leilao.Testes
{
    [TestFixture]
    public class PalindromoTest
    {
        [Test]
        public void TestarSeONomeEstaCerto()
        {
            Palindromo p = new Palindromo();

            bool frase = p.EhPalindromo(
                "Socorram-me subi no onibus em Marrocos");

            Assert.IsTrue(frase);
        }

        [Test]
        public void TesteParaIdentificarPalindromo()
        {
            Palindromo frase = new Palindromo();

            bool resultado = frase.EhPalindromo(
                "Anotaram a data da maratona");
            Assert.IsTrue(resultado);
        }

        [Test]
        public void TesteParaIdentificarSeNaoEhPalindromo()
        {
            Palindromo frase = new Palindromo();

            bool resultado = frase.EhPalindromo(
                "E preciso amar as pessoas como se nao houvesse amanha");
            Assert.IsFalse(resultado);
        }
    }
}

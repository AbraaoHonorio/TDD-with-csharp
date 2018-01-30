using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AprendendoTdd.Palindromo
{
    [TestFixture]
    class PalindromoTest
    {
		
		[Test]
		public void DeveIdentificarPalindromoEFiltrarCaracteresInvalidos()
		{
        Palindromo palidromo = new Palindromo();

        bool resultado = palidromo.EhPalindromo(
            "Socorram-me subi no onibus em Marrocos");
        Assert.IsTrue(resultado);
		}
		
        [Test]
		public void DeveIdentificarSeNaoEhPalindromo()
		{
			Palindromo palidromo = new Palindromo();

			bool resultado = palidromo.EhPalindromo(
				"Amarás o teu próximo como a ti mesmo. Marcos 12:31");
				
			Assert.IsFalse(resultado);
		}

        [Test]
        public void DeveIdentificarSePalidromo()
        {
            // Parte 1: Cenário
            Palindromo palidromo = new Palindromo();
            // Parte 2: Ação
            bool resultado = palidromo.EhPalindromo("arara");
            // Parte 3: Validação

            Assert.AreEqual(true, t);


        }
    }
}

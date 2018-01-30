using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Caelum.Leilao
{
    [TestFixture]
    class TesteDeAvaliador
    {
        [Test]
        public void DeveEntenderLancesEmOrdemCrescente()
        {
            // Parte 1: Cenário
            Usuario joao = new Usuario("Joao");
            Usuario jose = new Usuario("Jose");
            Usuario maria = new Usuario("Maria");

            Leilao leilao = new Leilao("Playstation 3");

            // resultado perfeito  
            /*  leilao.Propoe(new Lance(joao, 300.0));
          leilao.Propoe(new Lance(jose, 400.0));
          leilao.Propoe(new Lance(maria, 250.0));
           */

            leilao.Propoe(new Lance(joao, 250.0));
            leilao.Propoe(new Lance(jose, 300.0));
            leilao.Propoe(new Lance(maria, 400.0));
         

            // Parte 2: Ação
            Avaliador leiloeiro = new Avaliador();
            leiloeiro.Avalia(leilao);


            // Parte 3: Validação
            double maiorEsperado = 400;
            double menorEsperado = 250;

            Assert.AreEqual(maiorEsperado,leiloeiro.MaiorLance);
            Assert.AreEqual(menorEsperado,leiloeiro.MenorLance);

        }

        [Test]
        public void DeveEntenderMediaDosLances()
        {
            // Parte 1: Cenário
            Usuario joao = new Usuario("Joao");
            Usuario jose = new Usuario("Jose");
            Usuario maria = new Usuario("Maria");

            Leilao leilao = new Leilao("Playstation 3");


            leilao.Propoe(new Lance(maria, 300.0));
            leilao.Propoe(new Lance(joao, 400.0));
            leilao.Propoe(new Lance(jose, 500.0));


            // Parte 2: Ação
            Avaliador leiloeiro = new Avaliador();
            leiloeiro.CalcularValorMedio(leilao);
            // Parte 3: Validação

            Assert.AreEqual(400, leiloeiro.ValorMedio, 0.0001);


        }

        [Test]
        public void DeveEntenderSePalidromo()
        {
            // Parte 1: Cenário
            Palindromo palidromo = new Palindromo();
            // Parte 2: Ação
            bool t = palidromo.EhPalindromo("arara");
            // Parte 3: Validação

            Assert.AreEqual(true, t);


        }
    }
}

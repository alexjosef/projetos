using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caelum.Leilao;
using NUnit.Framework;

namespace Caelum.Leilao
{
    [TestFixture]
    class AvaliadorTest
    {
        [Test]
        public void TestandoOAvaliador()
        {
            //1a parte: cenario
            Usuario alex = new Usuario("Alex");
            Usuario lucas = new Usuario("Lucas");
            Usuario maria = new Usuario("Maria");

            Leilao leilao = new Leilao("GeForce GTX 1080Ti");

            leilao.Propoe(new Lance(alex, 3000.0));
            leilao.Propoe(new Lance(maria, 1500.0));
            leilao.Propoe(new Lance(lucas, 1500.0));

            //2a parte: ação
            Avaliador leiloeiro = new Avaliador();
            leiloeiro.Avalia(leilao);

            //3a parte: validação
            double menorEsperado = 1500.0;
            double maiorEsperado = 3000.0;
            double mediaEsperado = 2000.0;

            Assert.AreEqual(menorEsperado, leiloeiro.menorLance, 0.00001);
            Assert.AreEqual(maiorEsperado, leiloeiro.maiorLance, 0.00001);
            Assert.AreEqual(mediaEsperado, leiloeiro.Media, 0.00001);
        }
    }
}

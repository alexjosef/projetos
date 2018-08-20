using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

namespace Caelum.Leilao
{
    [TestFixture]
    class AvaliadorTest
    {
        [Test]
        public void TestandoOAvaliador()
        {
            Usuario alex = new Usuario("Alex");
            Usuario lucas = new Usuario("Lucas");
            Usuario maria = new Usuario("Maria");

            Leilao leilao = new Leilao("GeForce GTX 1080Ti");

            leilao.Propoe(new Lance(alex, 2000.0));
            leilao.Propoe(new Lance(maria, 1300.0));
            leilao.Propoe(new Lance(lucas, 1750.0));

            Avaliador leiloeiro = new Avaliador();
            leiloeiro.Avalia(leilao);

            double menorEsperado = 1300.0;
            double maiorEsperado = 2000.0;

            Assert.AreEqual(menorEsperado, leiloeiro.menorLance);
            Assert.AreEqual(maiorEsperado, leiloeiro.maiorLance);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Caelum.Leilao.Test
{
    [TestFixture]
    class LeilaoTest
    {
        private Avaliador leiloeiro;
        private Usuario alex;
        private Usuario joao;
        private Usuario stevejobs;
        private Usuario billgates;

        [SetUp]

        public void CriaAvaliador()
        {
            this.leiloeiro = new Avaliador();

            this.alex = new Usuario("Alex");
            this.joao = new Usuario("João");
            this.stevejobs = new Usuario("Steve Jobs");
            this.billgates = new Usuario("Bill Gates");
        }

        [Test]
        public void TesteRecebeUmLance()
        {
            Leilao leilao = new CriadorDeLeilao().Para("Macbook Pro TouchBar")
                .Lance(stevejobs, 9000.0)
                .Constroi();

            Assert.AreEqual(1, leilao.Lances.Count);
        }

        [Test]
        public void TesteRecebeVariosLances()
        {
            Leilao leilao = new CriadorDeLeilao().Para("Macbook Pro TouchBar 15")
                .Lance(stevejobs, 9000.0)
                .Lance(billgates, 13000.0)
                .Constroi();

            Assert.AreEqual(2, leilao.Lances.Count);
            Assert.AreEqual(9000, leilao.Lances[0].Valor);
            Assert.AreEqual(13000, leilao.Lances[1].Valor);
        }

        [Test]
        public void NaoDeveAceitarDoisLancesSeguidosDoMesmoUsuario()
        {
            Leilao leilao = new CriadorDeLeilao().Para("Macbook Pro TouchBar")
                .Lance(stevejobs, 14000.0)
                .Lance(stevejobs, 9000.0)
                .Constroi();

            Assert.AreEqual(1, leilao.Lances.Count);
            Assert.AreEqual(14000, leilao.Lances[0].Valor);
        }

        [Test]
        public void NaoDeveAceitarMaisQue5LancesDoMesmoUsuario()
        {
            Leilao leilao = new CriadorDeLeilao().Para("iMac 4k")
                .Lance(stevejobs, 2000.0)
                .Lance(billgates, 3000.0)

                .Lance(stevejobs, 4000.0)
                .Lance(billgates, 5000.0)

                .Lance(stevejobs, 6000.0)
                .Lance(billgates, 7000.0)

                .Lance(stevejobs, 8000.0)
                .Lance(billgates, 9000.0)

                .Lance(stevejobs, 10000.0)
                .Lance(billgates, 11000.0)

                //Deve ser ignorado
                .Lance(stevejobs, 12000.0)
                .Constroi();

            Assert.AreEqual(10, leilao.Lances.Count);

            var ultimo = leilao.Lances.Count - 1;
            Lance ultimoLance = leilao.Lances[ultimo];

            Assert.AreEqual(11000, ultimoLance.Valor, 0.00001);
        }

        [Test]
        public void TesteDobrarLance()
        {
            Usuario alex = new Usuario("Alex");
            Usuario joao = new Usuario("João");

            Leilao leilao = new CriadorDeLeilao().Para("PS4 Novo")
                .Lance(alex, 1000.0)
                .Lance(joao, 1500.0)
                .Constroi();

            leilao.DobraLance(alex);

            Assert.AreEqual(2000, leilao.Lances[2].Valor);
        }

        [Test]
        public void TesteNaoDobrarSeNaoHouverUltimoLance()
        {
            Leilao leilao = new CriadorDeLeilao().Para("PS4 Usado")
                .Constroi();

            Assert.AreEqual(0, leilao.Lances.Count);
        }

        [TestFixtureSetUp]
        public void TestandoBeforeClass()
        {
            Console.WriteLine("test fixture setup");
        }

        [TestFixtureTearDown]
        public void TestandoAfterClass()
        {
            Console.WriteLine("test fixture tear down");
        }
    }
}

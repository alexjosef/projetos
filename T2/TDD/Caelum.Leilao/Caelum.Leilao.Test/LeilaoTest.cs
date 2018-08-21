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
        [Test]
        public void TesteRecebeUmLance()
        {
            Leilao leilao = new Leilao("Macbook Pro TouchBar");
            leilao.Propoe(new Lance(new Usuario("Steve Jobs"), 9000));

            Assert.AreEqual(1, leilao.Lances.Count);
        }

        [Test]
        public void TesteRecebeVariosLances()
        {
            Leilao leilao = new Leilao("Macbook Pro TouchBar 15");
            leilao.Propoe(new Lance(new Usuario("Steve Jobs"), 9000));
            leilao.Propoe(new Lance(new Usuario("Alex"), 13000));

            Assert.AreEqual(2, leilao.Lances.Count);
            Assert.AreEqual(9000, leilao.Lances[0].Valor);
            Assert.AreEqual(13000, leilao.Lances[1].Valor);
        }

        [Test]
        public void NaoDeveAceitarDoisLancesSeguidosDoMesmoUsuario()
        {
            Leilao leilao = new Leilao("Macbook Pro TouchBar");
            Usuario stevejobs = new Usuario("Steve Jobs");

            leilao.Propoe(new Lance(stevejobs, 14000));
            leilao.Propoe(new Lance(stevejobs, 9000));

            Assert.AreEqual(1, leilao.Lances.Count);
            Assert.AreEqual(14000, leilao.Lances[0].Valor);
        }

        [Test]
        public void NaoDeveAceitarMaisQue5LancesDoMesmoUsuario()
        {
            Leilao leilao = new Leilao("iMac 4k");
            Usuario stevejobs = new Usuario("Steve Jobs");
            Usuario billgates = new Usuario("Bill Gates");

            leilao.Propoe(new Lance(stevejobs, 2000));
            leilao.Propoe(new Lance(billgates, 3000));

            leilao.Propoe(new Lance(stevejobs, 4000));
            leilao.Propoe(new Lance(billgates, 5000));

            leilao.Propoe(new Lance(stevejobs, 6000));
            leilao.Propoe(new Lance(billgates, 7000));

            leilao.Propoe(new Lance(stevejobs, 8000));
            leilao.Propoe(new Lance(billgates, 9000));

            leilao.Propoe(new Lance(stevejobs, 10000));
            leilao.Propoe(new Lance(billgates, 11000));

            //Deve ser ignorado
            leilao.Propoe(new Lance(stevejobs, 14000));

            Assert.AreEqual(10, leilao.Lances.Count);

            var ultimo = leilao.Lances.Count - 1;
            Lance ultimoLance = leilao.Lances[ultimo];

            Assert.AreEqual(11000, ultimoLance.Valor, 0.00001);
        }
    }
}

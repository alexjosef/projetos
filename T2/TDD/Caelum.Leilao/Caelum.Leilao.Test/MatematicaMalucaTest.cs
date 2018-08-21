using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Caelum.Leilao.Test
{
    [TestFixture]
    class MatematicaMalucaTest
    {
        [Test]
        public void TesteNumeroMaiorQue30()
        {
            MatematicaMaluca matematica = new MatematicaMaluca();
            Assert.AreEqual(50 * 4, matematica.ContaMaluca(50));
        }

        [Test]
        public void TesteNumeroMenorQue30MaiorQue10()
        {
            MatematicaMaluca matematica = new MatematicaMaluca();
            Assert.AreEqual(20 * 3, matematica.ContaMaluca(20));
        }

        [Test]
        public void TesteNumeroMenorQue10()
        {
            MatematicaMaluca matematica = new MatematicaMaluca();
            Assert.AreEqual(4 * 2, matematica.ContaMaluca(4));
        }
    }
}

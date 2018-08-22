using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace Caelum.Leilao.Test
{
    public class LanceTest
    {
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void TesteRecusaLanceDeValorZero()
        {
            new Lance(new Usuario("Alex"), 0);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void TesteRecusaLancesComValorNegativo()
        {
            new Lance(new Usuario("Alex"), -10);
        }
    }
}

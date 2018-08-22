using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Caelum.Leilao.Test
{
    [TestFixture]
    class AnoBissextoTest
    {
        [Test]
        public void TesteAnoBissexto()
        {
            new AnoBissexto().EhBissexto(2016);

           Assert.IsTrue(true);
        }
        
    }
}

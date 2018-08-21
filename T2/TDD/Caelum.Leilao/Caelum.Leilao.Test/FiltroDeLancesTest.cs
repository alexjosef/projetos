using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Caelum.Leilao.Test
{
    [TestFixture]
    public class FiltroDeLancesTest
    {
        [Test]
        public void DeveSelecionarLancesEntre1000E3000()
        {
            Usuario joao = new Usuario("Joao");

            FiltroDeLances filtro = new FiltroDeLances();
            IList<Lance> resultado = filtro.Filtra(new List<Lance>() {
            new Lance(joao,2000),
            new Lance(joao,1000),
            new Lance(joao,3000),
            new Lance(joao, 800)});

            Assert.AreEqual(1, resultado.Count);
            Assert.AreEqual(2000, resultado[0].Valor, 0.00001);
        }

        [Test]
        public void DeveSelecionarLancesEntre500E700()
        {
            Usuario joao = new Usuario("Joao");

            FiltroDeLances filtro = new FiltroDeLances();
            IList<Lance> resultado = filtro.Filtra(new List<Lance>() {
            new Lance(joao,600),
            new Lance(joao,500),
            new Lance(joao,700),
            new Lance(joao, 800)});

            Assert.AreEqual(1, resultado.Count);
            Assert.AreEqual(600, resultado[0].Valor, 0.00001);
        }

        [Test]
        public void TesteLancesMaioresQue5000()
        {
            Usuario alex = new Usuario("Alex");

            FiltroDeLances filtro = new FiltroDeLances();
            IList<Lance> resultado = filtro.Filtra(new List<Lance>()
            {
                new Lance(alex, 5000),
                new Lance(alex, 4900),
                new Lance(alex, 5500),
                new Lance(alex, 6000)
            });

            Assert.AreEqual(2, resultado.Count);
            Assert.AreEqual(5500, resultado[0].Valor);
            Assert.AreEqual(6000, resultado[1].Valor);
        }

        [Test]
        public void TesteEliminarEntre3000e5000()
        {
            Usuario alex = new Usuario("Alex");

            FiltroDeLances filtro = new FiltroDeLances();
            IList<Lance> resultado = filtro.Filtra(new List<Lance>()
            {
                new Lance(alex, 3000),
                new Lance(alex, 5000),
                new Lance(alex, 4000)
            });

            Assert.AreEqual(0, resultado.Count);
        }
    }
}

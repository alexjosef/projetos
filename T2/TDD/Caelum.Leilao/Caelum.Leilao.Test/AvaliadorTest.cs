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

            Assert.AreEqual(1500, leiloeiro.menorLance, 0.00001);
            Assert.AreEqual(3000, leiloeiro.maiorLance, 0.00001);
            Assert.AreEqual(2000, leiloeiro.Media, 0.00001);
        }

        [Test]
        public void TesteComApenasUmLance()
        {
            Usuario joao = new Usuario("João");

            Leilao leilao = new Leilao("PS4");

            leilao.Propoe(new Lance(joao, 1500.0));

            Avaliador leiloeiro = new Avaliador();

            leiloeiro.Avalia(leilao);

            Assert.AreEqual(1500, leiloeiro.maiorLance, 0.00001);
            Assert.AreEqual(1500, leiloeiro.menorLance, 0.00001);
        }

        [Test]
        public void TestePegaTresMaiores()
        {
            Usuario alex = new Usuario("Alex");
            Usuario maria = new Usuario("Maria");

            Leilao leilao = new Leilao("Monitor 24p");

            leilao.Propoe(new Lance(alex, 450.0));
            leilao.Propoe(new Lance(maria, 480.0));
            leilao.Propoe(new Lance(alex, 500.0));
            leilao.Propoe(new Lance(maria, 600.0));

            Avaliador leiloeiro = new Avaliador();
            leiloeiro.Avalia(leilao);

            var maiores = leiloeiro.TresMaiores;

            Assert.AreEqual(3, maiores.Count);
            Assert.AreEqual(600, maiores[0].Valor, 0.00001);
            Assert.AreEqual(500, maiores[1].Valor, 0.00001);
            Assert.AreEqual(480, maiores[2].Valor, 0.00001);
        }

        [Test]
        public void TesteNumerosRandomicos()
        {
            Usuario alex = new Usuario("Alex");
            Usuario maria = new Usuario("Maria");

            Leilao leilao = new Leilao("Jogo PS4");
            leilao.Propoe(new Lance(alex, 200));  
            leilao.Propoe(new Lance(maria, 450));
            leilao.Propoe(new Lance(alex, 120));
            leilao.Propoe(new Lance(maria, 700));
            leilao.Propoe(new Lance(alex, 630));
            leilao.Propoe(new Lance(maria, 230));

            Avaliador leiloeiro = new Avaliador();
            leiloeiro.Avalia(leilao);

            Assert.AreEqual(700, leiloeiro.maiorLance, 0.00001);
            Assert.AreEqual(120, leiloeiro.menorLance, 0.00001);
        }

        [Test]
        public void TesteOrdemDecrescente()
        {
            Usuario alex = new Usuario("Alex");
            Usuario maria = new Usuario("Maria");

            Leilao leilao = new Leilao("Espelho");
            leilao.Propoe(new Lance(alex, 400));
            leilao.Propoe(new Lance(maria, 300));
            leilao.Propoe(new Lance(alex, 200));
            leilao.Propoe(new Lance(maria, 100));

            Avaliador leiloeiro = new Avaliador();
            leiloeiro.Avalia(leilao);

            Assert.AreEqual(400, leiloeiro.maiorLance, 0.00001);
            Assert.AreEqual(100, leiloeiro.menorLance, 0.00001);
        }

        [Test]
        public void TestePegaDoisUnicosLances()
        {
            Usuario alex = new Usuario("Alex");
            Usuario maria = new Usuario("Maria");

            Leilao leilao = new Leilao("Monitor 24p");

            leilao.Propoe(new Lance(alex, 450.0));
            leilao.Propoe(new Lance(maria, 480.0));

            Avaliador leiloeiro = new Avaliador();
            leiloeiro.Avalia(leilao);

            var maiores = leiloeiro.TresMaiores;

            Assert.AreEqual(2, maiores.Count);
            Assert.AreEqual(480, maiores[0].Valor, 0.00001);
            Assert.AreEqual(450, maiores[1].Valor, 0.00001);
        }

        [Test]
        public void TesteListaDeLancesVazia()
        {
            Usuario alex = new Usuario("Alex");
            Usuario maria = new Usuario("Maria");

            Leilao leilao = new Leilao("Monitor 24p");

            Avaliador leiloeiro = new Avaliador();
            leiloeiro.Avalia(leilao);

            var maiores = leiloeiro.TresMaiores;

            Assert.AreEqual(0, maiores.Count);
        }
    }
}

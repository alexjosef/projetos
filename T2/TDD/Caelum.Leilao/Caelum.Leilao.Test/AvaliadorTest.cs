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
        private Avaliador leiloeiro;
        private Usuario alex;
        private Usuario lucas;
        private Usuario maria;
        private Usuario joao;

        [SetUp]
        public void CriaAvaliador()
        {
            this.leiloeiro = new Avaliador();

            this.alex = new Usuario("Alex");
            this.lucas = new Usuario("Lucas");
            this.maria = new Usuario("Maria");
            this.joao = new Usuario("João");
        }

        [Test]
        public void TestandoOAvaliador()
        {
            //1a parte: cenario   
            Leilao leilao = new CriadorDeLeilao().Para("GeForce GTX 1080Ti")
                .Lance(alex, 3000.0)
                .Lance(maria, 1500.0)
                .Lance(lucas, 1500.0)
                .Constroi();

            //2a parte: ação
            leiloeiro.Avalia(leilao);

            //3a parte: validação

            Assert.AreEqual(1500, leiloeiro.menorLance, 0.00001);
            Assert.AreEqual(3000, leiloeiro.maiorLance, 0.00001);
            Assert.AreEqual(2000, leiloeiro.Media, 0.00001);
        }

        [Test]
        public void TesteComApenasUmLance()
        {
            Leilao leilao = new CriadorDeLeilao().Para("PS4")
                .Lance(joao, 1500.0)
                .Constroi();

            leiloeiro.Avalia(leilao);

            Assert.AreEqual(1500, leiloeiro.maiorLance, 0.00001);
            Assert.AreEqual(1500, leiloeiro.menorLance, 0.00001);
        }

        [Test]
        public void TestePegaTresMaiores()
        {
            Leilao leilao = new CriadorDeLeilao().Para("Monitor 24p")
                .Lance(alex, 450.0)
                .Lance(maria, 480.0)
                .Lance(alex, 500.0)
                .Lance(maria, 600.0)
                .Constroi();

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
            Leilao leilao = new CriadorDeLeilao().Para("Jogo PS4")
                .Lance(alex, 200.0)
                .Lance(maria, 450.0)
                .Lance(alex, 120.0)
                .Lance(maria, 700.0)
                .Lance(alex, 630.0)
                .Lance(maria, 230.0)
                .Constroi();
            
            leiloeiro.Avalia(leilao);

            Assert.AreEqual(700, leiloeiro.maiorLance, 0.00001);
            Assert.AreEqual(120, leiloeiro.menorLance, 0.00001);
        }

        [Test]
        public void TesteOrdemDecrescente()
        {
            Leilao leilao = new CriadorDeLeilao().Para("Espelho")
                .Lance(alex, 400.0)
                .Lance(maria, 300.0)
                .Lance(alex, 200.0)
                .Lance(maria, 100.0)
                .Constroi();
            
            leiloeiro.Avalia(leilao);

            Assert.AreEqual(400, leiloeiro.maiorLance, 0.00001);
            Assert.AreEqual(100, leiloeiro.menorLance, 0.00001);
        }

        [Test]
        public void TestePegaDoisUnicosLances()
        {
            Leilao leilao = new CriadorDeLeilao().Para("Monitor 24p")
                .Lance(alex, 450.0)
                .Lance(maria, 480.0)
                .Constroi();
            
            leiloeiro.Avalia(leilao);

            var maiores = leiloeiro.TresMaiores;

            Assert.AreEqual(2, maiores.Count);
            Assert.AreEqual(480, maiores[0].Valor, 0.00001);
            Assert.AreEqual(450, maiores[1].Valor, 0.00001);
        }

        [Test]
        [ExpectedException(typeof(Exception))]
        public void TesteListaDeLancesVazia()
        {
            Leilao leilao = new CriadorDeLeilao().Para("Monitor 24p")
                .Constroi();
            
            leiloeiro.Avalia(leilao);

            var maiores = leiloeiro.TresMaiores;

            Assert.AreEqual(0, maiores.Count);
        }

        [TearDown]
        public void Finaliza()
        {
            Console.WriteLine("fim");
        }

        [Test]
        [ExpectedException(typeof(Exception))]
        public void TesteNãoDeveAvaliarSemLance()
        {
            Leilao leilao = new CriadorDeLeilao().Para("Playstation 2").Constroi();

            leiloeiro.Avalia(leilao);

            //Assert.???
        }
    }
}

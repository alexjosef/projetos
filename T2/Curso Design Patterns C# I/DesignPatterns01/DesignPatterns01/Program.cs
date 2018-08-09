using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Imposto ICMS = new ICMS();
            //Imposto ISS = new ISS();
            //Orcamento orcamento = new Orcamento(500.0);
            //CalculadorDeImpostos calculador = new CalculadorDeImpostos();

            //calculador.RealizarCalculo(orcamento, ICMS);

            //calculador.RealizarCalculo(orcamento, ISS);

            //Imposto ICCC = new ICCC();
            //Orcamento reforma = new Orcamento(5000.0);
            //CalculadorDeImpostos calculador = new CalculadorDeImpostos();

            //calculador.RealizarCalculo(reforma, ICCC);

            //Desconto d1 = new DescontoPorCincoItens();
            //Desconto d2 = new DescontoPorMaisDeQuinhentosReais();
            //Desconto d3 = new DescontoPorVendaCasada();
            //Desconto d4 = new SemDesconto();

            //d1.Proximo = d2;
            //d2.Proximo = d3;
            //d3.Proximo = d4;

            //Orcamento orcamento = new Orcamento(500.0);
            //orcamento.AdicionaItem(new Item("CANETA", 250));
            //orcamento.AdicionaItem(new Item("LAPIS", 250));
            //orcamento.AdicionaItem(new Item("CANETA", 250));


            //double desconto = d1.Desconta(orcamento);
            //Console.WriteLine(desconto);

            //Imposto ISS = new ImpostoMuitoAlto(new ICPP());

            //Orcamento orcamento = new Orcamento(500);
            //double valor = ISS.Calcula(orcamento);
            //Console.WriteLine(valor);

            Orcamento reforma = new Orcamento(500);

            Console.WriteLine(reforma.Valor);

            reforma.AplicaDescontoExtra();
            Console.WriteLine(reforma.Valor);
            reforma.Aprova();

            reforma.AplicaDescontoExtra();
            Console.WriteLine(reforma.Valor);
            reforma.Finaliza();

        }
    }
}

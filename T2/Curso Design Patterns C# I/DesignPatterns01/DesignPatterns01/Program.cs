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

            Imposto ICCC = new ICCC();
            Orcamento reforma = new Orcamento(5000.0);
            CalculadorDeImpostos calculador = new CalculadorDeImpostos();

            calculador.RealizarCalculo(reforma, ICCC);
        }
    }
}

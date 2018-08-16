using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaoNaMassaOCP
{
    class Program
    {
        static void Main(string[] args)
        {
            Compra compra = new Compra(500, "SAO PAULO");
            CalculadoraDePrecos calculadora = new CalculadoraDePrecos(new TabelaDePrecoPadrao(), new Frete());

            double resultado = calculadora.Calcula(compra);

            Console.WriteLine("O preço da compra é: {0} ", resultado);
            Console.ReadKey();
        }
    }
}

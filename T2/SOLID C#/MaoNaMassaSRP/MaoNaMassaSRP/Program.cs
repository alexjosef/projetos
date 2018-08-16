using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaoNaMassaSRP
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadoraDeSalario cs = new CalculadoraDeSalario();
            Funcionario funcionario = new Funcionario(new Desenvolvedor(new dezOuVintePorcento()), 2000.0);
            double resultado;

            resultado = cs.Calcula(funcionario);

            Console.WriteLine("O salário de um {0} que ganha {1} é: {2}", funcionario.Cargo, funcionario.SalarioBase, resultado);
        }
    }
}

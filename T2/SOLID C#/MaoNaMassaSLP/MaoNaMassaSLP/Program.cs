using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaoNaMassaSLP
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<ContaComum> contas = ContasDoBanco();

            foreach (ContaComum conta in contas)
            {
                conta.SomaInvestimento();

                Console.WriteLine("Novo saldo: " + conta.Saldo);
            }

            Console.ReadLine();
        }

        private static IList<ContaComum> ContasDoBanco()
        {
            List<ContaComum> contas = new List<ContaComum>();
            contas.Add(umaContaComum(100));
            contas.Add(umaContaComum(150));
            contas.Add(umaContaEstudante(100));
            return contas;
        }

        private static ContaDeEstudante umaContaEstudante(double saldo)
        {
            ContaDeEstudante conta = new ContaDeEstudante();
            conta.Deposita(saldo);
            return conta;
        }

        private static ContaComum umaContaComum(double saldo)
        {
            ContaComum conta = new ContaComum();
            conta.Deposita(saldo);
            return conta;
        }

    }
}

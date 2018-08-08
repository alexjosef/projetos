using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns01
{
    public class RelatorioComplexo : Relatorio
    {
        protected override void Cabecalho()
        {
            Console.WriteLine("Banco XPTO");
            Console.WriteLine("Avenida Alameda, 1234");
            Console.WriteLine("(47) 1234-5678");
        }

        protected override void Rodape()
        {
            Console.WriteLine("banco@xpto.com.br");
            Console.WriteLine(DateTime.Now);
        }

        protected override void Corpo(IList<Conta> contas)
        {
            foreach (Conta c in contas)
            {
                Console.WriteLine(c.Titular + " - " + c.Numero + " - " + c.Agencia + " - " + c.Saldo);
            }
        }
    }
}

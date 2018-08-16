using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaoNaMassaAcoplamento
{
    class Program
    {
        static void Main(string[] args)
        {
            EnviadorDeEmail enviadorEmail = new EnviadorDeEmail();
            NotaFiscalDao nfDao = new NotaFiscalDao();
            IList<IAcaoAposGerarNota> acoes = new List<IAcaoAposGerarNota>();
            acoes.Add(enviadorEmail);
            acoes.Add(nfDao);

            GeradorDeNotaFiscal gnf = new GeradorDeNotaFiscal(acoes);
            Fatura fatura = new Fatura(200, "Alex");
            gnf.Gera(fatura);

            Console.ReadKey();

        }
    }
}

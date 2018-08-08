using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns01
{
    public class FiltroMenorQue100Reais : Filtro
    {
        public FiltroMenorQue100Reais(Filtro outroFiltro) : base(outroFiltro) { }
        public FiltroMenorQue100Reais() : base() { }

        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            IList<Conta> Filtrada = new List<Conta>();
            foreach(Conta c in contas)
            {
                if (c.Saldo < 100) Filtrada.Add(c);
            }
            foreach(Conta c in Proximo(contas))
            {
                Filtrada.Add(c);
            }
            return Filtrada;
        }
    }
}

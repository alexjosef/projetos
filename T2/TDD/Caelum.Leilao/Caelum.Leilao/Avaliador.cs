using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caelum.Leilao
{
    public class Avaliador
    {
        private double maiorValor = double.MinValue;
        private double menorValor = double.MaxValue;
        private double media = 0;
        private List<Lance> maiores;

        public void Avalia(Leilao leilao)
        {
            double total = 0;
            foreach(var lance in leilao.Lances)
            {
                if (lance.Valor > maiorValor)
                    maiorValor = lance.Valor;

                if (lance.Valor < menorValor)
                    menorValor = lance.Valor;

                total += lance.Valor;         
            }
            media = total / leilao.Lances.Count;

            pegaOsMaioresNo(leilao);
        }

        private void pegaOsMaioresNo(Leilao leilao)
        {
            var filtro = leilao.Lances.OrderByDescending(p => p.Valor).Take(3);
            maiores = new List<Lance>(filtro);
        }

        public List<Lance> TresMaiores
        {
            get { return this.maiores; }
        }

        public double maiorLance
        {
            get { return maiorValor; }
        }

        public double menorLance
        {
            get { return menorValor; }
        }

        public double Media
        {
            get { return media; }
        }
    }
}

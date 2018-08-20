using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caelum.Leilao
{
    class Avaliador
    {
        private double maiorValor = double.MinValue;
        private double menorValor = double.MaxValue;

        public void Avalia(Leilao leilao)
        {
            foreach(var lance in leilao.Lances)
            {
                if (lance.Valor > maiorValor)
                {
                    maiorValor = lance.Valor;
                }

                if (lance.Valor < menorValor)
                {
                    menorValor = lance.Valor;
                }
            }
        }

        public double maiorLance
        {
            get { return maiorValor; }
        }

        public double menorLance
        {
            get { return menorValor; }
        }
    }
}

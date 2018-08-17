using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaoNaMassaSLP
{
    public class ContaComum
    {
        public double Saldo { get; private set; }

        private ManipuladorDeSaldo manipulador;
        public ContaComum()
        {
            this.manipulador = new ManipuladorDeSaldo();
        }

        public void Saca(double valor)
        {
            manipulador.Saca(valor - 100);
        }

        public void Deposita(double valor)
        {
            manipulador.Deposita(valor);
        }

        public void SomaInvestimento()
        {
            this.manipulador.SomaInvestimento(1.1);
        }
    }
}

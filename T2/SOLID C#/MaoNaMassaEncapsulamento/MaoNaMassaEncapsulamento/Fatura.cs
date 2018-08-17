using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaoNaMassaEncapsulamento
{
    public class Fatura
    {
        public string Cliente { get; private set; }
        public double Valor { get; set; }
        public List<Pagamento> Pagamentos { get; private set; }
        public bool Pago { get; private set; }

        public Fatura(string cliente, double valor)
        {
            this.Cliente = cliente;
            this.Valor = valor;
            this.Pagamentos = new List<Pagamento>();
            this.Pago = false;
        }
        public void AdicionaPagamento(Pagamento pagamento)
        {
            this.Pagamentos.Add(pagamento);

            if(valorTotalDosPagamentos() >= Valor)
            {
                this.Pago = true;
            }
        }
        private double valorTotalDosPagamentos()
        {
            double total = 0;

            foreach(Pagamento pag in Pagamentos)
            {
                total += pag.Valor;
            }

            return total;
        }
    }
}

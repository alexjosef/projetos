using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class TotalizadorDeContas
    {
        public double saldoTotal { get; private set; }

        public void Adiciona(Conta conta)
        {
            saldoTotal += conta.Saldo;
        }
    }
}

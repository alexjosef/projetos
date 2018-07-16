using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; private set; }
        public Cliente Titular { get; set; }

        public void Sacar (double valor)
        {
            this.Saldo -= valor + 0.1;
        }
        public void Depositar (double valor)
        {
            this.Saldo += valor;
        }
        public void transferir (double valor, Conta destino)
        {
            this.Sacar(valor);
            destino.Depositar(valor);
        }
    }
}

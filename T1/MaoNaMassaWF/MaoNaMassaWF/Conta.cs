using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaoNaMassaWF
{
    class Conta
    {
        public Cliente Titular { get; set; }
        public int Numero { get; set; }
        public double Saldo { get; set; }

        public void Sacar(double valor)
        {
            this.Saldo -= valor;
        }
        public void Depositar(double valor)
        {
            this.Saldo = valor;
        }
        public void Transferir(double valor, Conta destino)
        {
            this.Sacar(valor);
            destino.Depositar(valor);
        }
    }
}
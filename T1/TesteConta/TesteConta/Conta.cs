using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteConta
{
    class Conta
    {
        public int numero;
        public string titular;
        public double saldo;
        public int agencia;
        public string CPF;

        public void Saca(double valor)
        {
            this.saldo -= valor;
        }

        public void Deposita(double valor)
        {
            this.saldo += valor;
        }

        public void Transfere(double valor, Conta destino)
        {
            this.Saca(valor);
            destino.Deposita(valor);

        }
    }
}

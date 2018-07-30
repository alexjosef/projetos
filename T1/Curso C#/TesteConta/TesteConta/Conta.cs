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
        public Cliente titular;
        public double saldo;
        public int agencia;
        public Cliente cliente;

        public void Saca(double ValorASacar)
        {
            if (ValorASacar > 0 && ValorASacar <= this.saldo)
            this.saldo -= ValorASacar;
        }

        public void Deposita(double ValorADepositar)
        {
            if (ValorADepositar > 0)
            this.saldo += ValorADepositar;
        }

        public void Transfere(double valor, Conta destino)
        {
            this.Saca(valor);
            destino.Deposita(valor);

        }
    }
}

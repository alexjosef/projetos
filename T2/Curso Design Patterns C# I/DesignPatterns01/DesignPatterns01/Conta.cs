using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns01
{
    public class Conta
    {
        public string Titular { get; set; }
        public double Saldo { get; set; }
        public int Numero { get; set; }
        public int Agencia { get; set; }

        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }
        public Conta(String titular, double saldo)
        {
            this.Titular = titular;
            this.Saldo = saldo;
        }
    }
}

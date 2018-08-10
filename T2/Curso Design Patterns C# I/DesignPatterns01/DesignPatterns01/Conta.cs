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
        public DateTime DataAbertura { get; set; }
        public IEstadoDaConta Estado;

        public void Saca(double valor)
        {
            Estado.Saca(this, valor);
        }
        public void Deposita(double valor)
        {
            Estado.Deposita(this, valor);
        }

        public Conta(String titular, double saldo)
        {
            this.Titular = titular;
            this.Saldo = saldo;
        }
    }
}

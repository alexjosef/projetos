using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaoNaMassaOCP
{
    public class Compra
    {
        public string Cidade { get; set; }
        public double Valor { get; set; }

        public Compra(double valor, string cidade)
        {
            this.Cidade = cidade;
            this.Valor = valor;
        }
    }
}

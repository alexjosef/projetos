using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns01
{
    public class ISS
    {
        public double CalculaISS(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }
    }
}

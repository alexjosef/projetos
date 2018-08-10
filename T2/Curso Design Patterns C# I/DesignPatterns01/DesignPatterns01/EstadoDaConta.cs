using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns01
{
    public interface IEstadoDaConta
    {
        void Saca(Conta conta, double valor);
        void Deposita(Conta conta, double valor);
    }
}

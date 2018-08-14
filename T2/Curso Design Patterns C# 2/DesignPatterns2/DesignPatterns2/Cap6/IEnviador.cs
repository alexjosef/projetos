using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Cap6
{
    interface IEnviador
    {
        void Envia(IMensagem mensagem);
    }
}

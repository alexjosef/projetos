using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns01
{
    class RespostaEmXml : Resposta
    {
        public Resposta OutraResposta { get; private set; }

        public RespostaEmXml(Resposta outraReposta)
        {
            this.OutraResposta = outraReposta;
        }

        public void Responde(Requisicao req, Conta conta)
        {
            if (req.Formato == Formato.XML)
            {
                Console.WriteLine("<conta><titular>" + conta.Titular + "</titular><saldo>" + conta.Saldo + "</saldo></conta>");
            }
            else
            {
                OutraResposta.Responde(req, conta);
            }
        }
    }
}

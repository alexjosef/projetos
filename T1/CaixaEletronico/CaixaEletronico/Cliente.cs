using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class Cliente
    {
        public string Nome { get; set; }

            public Cliente(string Nome)
        {
            this.Nome = Nome;
        }

        public int idade;
        public string cpf;
        public string rg;
        public string endereco;
        public string titular;
    }
}

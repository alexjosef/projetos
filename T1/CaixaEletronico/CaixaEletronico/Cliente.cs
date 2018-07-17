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
        public int idade;
        public string cpf;
        public string Rg { get; set; }
        public string endereco;
        public string titular;

        public Cliente (string nome, string rg)
        {
            this.Nome = nome;
            this.Rg = rg;
        }
        public Cliente() { }
             
    }
}

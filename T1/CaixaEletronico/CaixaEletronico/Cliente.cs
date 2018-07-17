namespace CaixaEletronico
{
    class Cliente
    {
        public string Nome { get; set; }
        public string rg;
        public string cpf;
        public string endereco;
        public int idade;

        public Cliente(string nome)
        {
            this.Nome = nome;
        }

        public Cliente() { }

        public bool EhMaiorDeIdade()
        {
            return this.idade >= 18;
        }
    }
}
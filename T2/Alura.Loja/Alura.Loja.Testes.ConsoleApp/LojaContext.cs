using Microsoft.EntityFrameworkCore;
using System;

namespace Alura.Loja.Testes.ConsoleApp
{
    public class LojaContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Promocao> Promocoes { get; set; }
        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder //Indicou que a classe PromocaoProduto possuia a Key da classe Promocao e classe Produto
                .Entity<PromocaoProduto>()
                .HasKey(pp => new { pp.PromocaoId, pp.ProdutoId });
            base.OnModelCreating(modelBuilder);

            modelBuilder //Mudou o nome da tabela para Enerecos
                .Entity<Endereco>()
                .ToTable("Enderecos");

            modelBuilder //Indicou que a classe Endereco vem da classe Cliente
                .Entity<Endereco>()
                .Property<int>("ClienteId");

            modelBuilder //Indicou que a classe Endereco possuia a Key da classe Cliente
                .Entity<Endereco>()
                .HasKey("ClienteId");
        } 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsbuilder)
        {
            optionsbuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LojaDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}
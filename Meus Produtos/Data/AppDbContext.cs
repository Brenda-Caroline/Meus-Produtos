using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Meus_Produtos.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Produto>()
                .Property(p => p.Preco)
                    .HasPrecision(10, 2);


            modelBuilder.Entity<Produto>()
                .HasData(
                    new Produto { Id = 1, Nome = "Caderno", Preco = 7.95M, Status = "Ativo" },
                    new Produto { Id = 2, Nome = "Perfume", Preco = 125.00M, Status = "Inativo" },
                    new Produto { Id = 3, Nome = "Camiseta", Preco = 24.99M, Status = "Ativo" },
                    new Produto { Id = 4, Nome = "Cadeira", Preco = 45.99M, Status = "Inativo" }
                );


            modelBuilder.Entity<Usuarios>()
                .HasData(
                    new Usuarios { Id = 1, Nome = "Brenda", Email = "brenda@gmail.com", Senha = "123456abc" },
                    new Usuarios { Id = 2, Nome = "José", Email = "jose@gmail.com", Senha = "986324lsk" },
                    new Usuarios { Id = 3, Nome = "Marcos", Email = "marcos@gmail.com", Senha = "147852pod" },
                    new Usuarios { Id = 4, Nome = "Fabiana", Email = "fabiana@gmail.com", Senha = "369825lei" }
                );
        }

    }
}
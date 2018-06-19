using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using Project.Model;

namespace Project.DAO 
{
    class ProjectRegister : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pedido>().ToTable("Pedidos");
            modelBuilder.Entity<Produto>().ToTable("Produtos");
            modelBuilder.Entity<Funcionario>().ToTable("Funcionários");
            modelBuilder.Entity<Cliente>().ToTable("Clientes");

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Pedido> Pedidos {set; get;}
        public DbSet<Produto> Produtos { set; get; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
    }
}

using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using SCEEV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCEEV
{
    public class ApplicationContext : DbContext
    {
        //public DbSet<ClienteJuridico> ClienteJuridico { get; set; }
        //public DbSet<ClienteFisico> ClienteFisico { get; set; }
        //public DbSet<Usuario> Usuario { get; set; }
        //public DbSet<Endereco> Endereco { get; set; }
        //public DbSet<Telefone> Telefone { get; set; }
        //public DbSet<Mercadoria> Mercadoria { get; set; }
        //public DbSet<Orcamento> Orcamento { get; set; }
        //public DbSet<MercadoriaOrcamento> MercadoriaOrcamento { get; set; }
        //public DbSet<Venda> Venda { get; set; }
        //public DbSet<Pagamento> Pagamento { get; set; }

        public ApplicationContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Usuario>().HasKey(t => t.Id);
            //modelBuilder.Entity<Usuario>().HasMany(t => t.Orcamentos).WithOne(t => t.Responsavel).;
            //modelBuilder.Entity<Usuario>().HasMany(t => t.Vendas).WithOne(t => t.Responsavel);

            modelBuilder.Entity<ClienteFisico>().HasKey(t => t.Id);
            //modelBuilder.Entity<Cliente>().HasMany(t => t.Compras).WithOne(t => t.Cliente);

            modelBuilder.Entity<Endereco>().HasKey(t => t.Id);

            modelBuilder.Entity<Mercadoria>().HasKey(t => t.Id);

            modelBuilder.Entity<Orcamento>().HasKey(t => t.Id);
            modelBuilder.Entity<Orcamento>().HasOne(t => t.Responsavel).WithMany(t => t.Orcamentos);
            modelBuilder.Entity<Orcamento>().HasOne(t => t.Cliente).WithMany(t => t.Orcamentos);
            //modelBuilder.Entity<Orcamento>().HasMany(t => t.Mercadorias);

            modelBuilder.Entity<Venda>().HasKey(t => t.Id);
            modelBuilder.Entity<Venda>().HasOne(t => t.Orcamento);
            modelBuilder.Entity<Venda>().HasOne(t => t.Pagamento).WithOne(t => t.Venda);
            modelBuilder.Entity<Venda>().HasOne(t => t.Responsavel).WithMany(t => t.Vendas);
            modelBuilder.Entity<Venda>().HasOne(t => t.Cliente).WithMany(t => t.Compras);

            modelBuilder.Entity<Pagamento>().HasKey(t => t.Id);
            //modelBuilder.Entity<Pagamento>().HasOne(t => t.Venda).WithOne(t => t.Pagamento);
        }
    }
}

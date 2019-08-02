using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using SCEEV.Configuration;
using SCEEV.Map;
using SCEEV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCEEV
{
    public class ApplicationContext : DbContext
    {
        public DbSet<ClienteJuridico> ClienteJuridico { get; set; }
        public DbSet<ClienteFisico> ClienteFisico { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Telefone> Telefone { get; set; }
        public DbSet<Mercadoria> Mercadoria { get; set; }
        public DbSet<Orcamento> Orcamento { get; set; }
        public DbSet<MercadoriaOrcamento> MercadoriaOrcamento { get; set; }
        public DbSet<Venda> Venda { get; set; }
        public DbSet<Pagamento> Pagamento { get; set; }

        public ApplicationContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new MercadoriaOrcamentoConfiguration());
            //modelBuilder.ApplyConfiguration(new VendaConfiguration());
        }
    }
}

using Microsoft.EntityFrameworkCore;
using SCEEV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCEEV.Configuration
{
    public class VendaConfiguration : IEntityTypeConfiguration<Venda>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Venda> builder)
        {
            builder.HasKey(t => t.Id);
            builder.HasOne(t => t.Orcamento);
            builder.HasOne(t => t.Responsavel).WithMany(t => t.Vendas).OnDelete(DeleteBehavior.SetNull);
            builder.HasOne(t => t.Cliente).WithMany(t => t.Compras);
        }
    }
}

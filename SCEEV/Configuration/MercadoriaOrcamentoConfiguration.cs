using Microsoft.EntityFrameworkCore;
using SCEEV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCEEV.Configuration
{
    public class MercadoriaOrcamentoConfiguration : IEntityTypeConfiguration<MercadoriaOrcamento>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<MercadoriaOrcamento> builder)
        {
            builder.HasKey(t => new { t.MercadoriaId, t.OrcamentoId });
        }
    }
}

using SCEEV.Models;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SCEEV.Map
{
    public class ClienteFisicoConfiguration : IEntityTypeConfiguration<ClienteFisico>
    {
        public void Configure(EntityTypeBuilder<ClienteFisico> builder)
        {
            builder.HasKey(t => t.Id);
        }
    }
}

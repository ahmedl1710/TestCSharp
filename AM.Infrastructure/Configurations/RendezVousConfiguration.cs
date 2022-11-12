using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AM.Application.Core.Domain;

namespace AM.Infrastructure.Configurations
{
    public class RendezVousConfiguration : IEntityTypeConfiguration<RendezVous>
    {
        public void Configure(EntityTypeBuilder<RendezVous> builder)
        {
            builder.HasKey(pk => new { pk.vaccinId, pk.citoyenId, pk.dateVaccination });

            builder.HasOne(r => r.vaccin).WithMany(v => v.rendezvous);
            builder.HasOne(r => r.citoyen).WithMany(c => c.rendezvous);
        }
    }
}

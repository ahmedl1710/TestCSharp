using AM.Application.Core.Domain;
using AM.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure
{
    public class AMContext : DbContext
    {
        public DbSet<Citoyen> citoyen { get; set; }
        public DbSet<CnetreVaccination> centredevaccination { get; set; }
        public DbSet<RendezVous> rendezvous { get; set; }
        public DbSet<Vaccin> vaccin { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
               Initial Catalog=GestionVaccinationDb;
                Integrated Security=true");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.ApplyConfiguration(new RendezVousConfiguration());

            modelbuilder.Entity<Citoyen>().OwnsOne(c => c.adresse, myadresse =>
                                                            {
                                                                myadresse.Property(a => a.codePostal);
                                                                myadresse.Property(a => a.rue);
                                                                myadresse.Property(a => a.ville);
                                                            });
        }



    }
}

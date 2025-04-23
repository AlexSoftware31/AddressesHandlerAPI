using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Domain.Entities;

namespace WebApi.Infrastructure.Context
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Country> Countries { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<Municipality> Municipalities { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Sector> Sectors { get; set; }
        public DbSet<Neighborhood> Neighborhoods { get; set; }
        public DbSet<Address> Addresses { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Address>()
                .HasOne(a => a.Country)
                .WithMany()
                .HasForeignKey(a => a.IdCountry)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Address>()
                .HasOne(a => a.Province)
                .WithMany()
                .HasForeignKey(a => a.IdProvince)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Address>()
                .HasOne(a => a.Municipality)
                .WithMany()
                .HasForeignKey(a => a.IdMunicipality)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Address>()
                .HasOne(a => a.District)
                .WithMany()
                .HasForeignKey(a => a.IdDistrict)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Address>()
                .HasOne(a => a.Sector)
                .WithMany()
                .HasForeignKey(a => a.IdSector)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Address>()
                .HasOne(a => a.Neighborhood)
                .WithMany(n => n.Addresses)
                .HasForeignKey(a => a.IdNeighborhood)
                .OnDelete(DeleteBehavior.Restrict);
        }

    }
}

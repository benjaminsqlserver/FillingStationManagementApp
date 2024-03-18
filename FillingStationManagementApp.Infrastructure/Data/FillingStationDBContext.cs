using FillingStationManagementApp.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillingStationManagementApp.Infrastructure.Data
{
    public partial class FillingStationDBContext : DbContext
    {
        public FillingStationDBContext()
        {
        }

        public FillingStationDBContext(DbContextOptions<FillingStationDBContext> options) : base(options)
        {
        }

        partial void OnModelBuilding(ModelBuilder builder);

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Employee>()
              .HasOne(i => i.FillingStation)
              .WithMany(i => i.Employees)
              .HasForeignKey(i => i.FillingStationID)
              .HasPrincipalKey(i => i.Id);

            builder.Entity<FillingStation>()
              .HasOne(i => i.Employee)
              .WithMany(i => i.FillingStations)
              .HasForeignKey(i => i.ManagerID)
              .HasPrincipalKey(i => i.Id);

            builder.Entity<FuelPrice>()
              .HasOne(i => i.FillingStation)
              .WithMany(i => i.FuelPrices)
              .HasForeignKey(i => i.FillingStationID)
              .HasPrincipalKey(i => i.Id);

            builder.Entity<FuelPrice>()
              .HasOne(i => i.FuelType)
              .WithMany(i => i.FuelPrices)
              .HasForeignKey(i => i.FuelTypeID)
              .HasPrincipalKey(i => i.Id);

            builder.Entity<Transaction>()
              .HasOne(i => i.Employee)
              .WithMany(i => i.Transactions)
              .HasForeignKey(i => i.EmployeeID)
              .HasPrincipalKey(i => i.Id);

            builder.Entity<Transaction>()
              .HasOne(i => i.FuelType)
              .WithMany(i => i.Transactions)
              .HasForeignKey(i => i.FuelTypeID)
              .HasPrincipalKey(i => i.Id);

            builder.Entity<Transaction>()
              .HasOne(i => i.FillingStation)
              .WithMany(i => i.Transactions)
              .HasForeignKey(i => i.StationID)
              .HasPrincipalKey(i => i.Id);

            builder.Entity<Transaction>()
              .Property(p => p.TransactionDate)
              .HasColumnType("datetime");
            this.OnModelBuilding(builder);
        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<FillingStation> FillingStations { get; set; }

        public DbSet<FuelPrice> FuelPrices { get; set; }

        public DbSet<FuelType> FuelTypes { get; set; }

        public DbSet<Transaction> Transactions { get; set; }

        

    }
}

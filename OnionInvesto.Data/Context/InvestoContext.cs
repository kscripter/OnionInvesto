using System;
using Microsoft.EntityFrameworkCore;
using OnionInvesto.Core.Models.Entities;

namespace OnionInvesto.Data.Context
{
    public class InvestoContext : DbContext
    {
        public InvestoContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<User> Users { get; set; }

        public DbSet<Investor> Investors { get; set; }

        public DbSet<Investment> Investments { get; set; }

        public DbSet<Manager> Managers { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<BankDetail> BankDetails { get; set; }





        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<BankDetail>().HasOne(b => b.Investor).WithOne(i => i.BankDetail);

            modelBuilder.Entity<BankDetail>().HasKey(b => b.InvestorId);

            modelBuilder.Entity<Investor>().HasMany(inv => inv.Investments).WithOne(inv => inv.Investor);

            modelBuilder.Entity<BankDetail>().Property(b => b.AccountNumber)
                .IsRequired()
                .HasMaxLength(10);

            modelBuilder.Entity<BankDetail>().HasIndex(b => b.AccountNumber).IsUnique();


            base.OnModelCreating(modelBuilder);
        }
    }
}

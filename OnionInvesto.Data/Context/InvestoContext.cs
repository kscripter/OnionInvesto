using System;
using Microsoft.EntityFrameworkCore;
using OnionInvesto.Core.Entities;

namespace OnionInvesto.Data.Context
{
    public class InvestoContext : DbContext
    {
        public InvestoContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bank>(b =>
            {
                b.ToTable("banks");
                b.HasKey(p => p.Id);
                b.Property(p => p.Name).HasColumnType("varchar(50)")
                    .IsRequired();
                b.HasIndex(p => p.Name).IsUnique();
                b.Property(p => p.Code).HasColumnType("varchar(50)")
                    .IsRequired();
                b.HasMany(p => p.InvestorBanks)
                    .WithOne(p => p.Bank)
                    .HasForeignKey(p => p.BankId);
            });



            modelBuilder.Entity<Investor>(i =>
            {
                i.ToTable("investors");
                i.HasKey(p => p.Id);
                i.Property(p => p.FirstName).HasColumnType("varchar(50)")
                    .IsRequired();
                i.Property(p => p.LastName).HasColumnType("varchar(50)")
                    .IsRequired();
                i.Property(p => p.MiddleName).HasColumnType("varchar(50)");
                i.Property(p => p.Email).HasColumnType("varchar(50)")
                    .IsRequired();
                i.HasIndex(p => p.Email).IsUnique();
                i.Property(p => p.PasswordHash).HasColumnType("varchar(850)")
                    .IsRequired();
                i.Property(p => p.PhoneNumber).HasColumnType("varchar(50)")
                    .IsRequired();
                i.Property(p => p.Address).HasColumnType("varchar(250)")
                    .IsRequired();
               
                i.HasMany(p => p.InvestorBanks)
                    .WithOne(p => p.Investor)
                    .HasForeignKey(p => p.InvestorId);

                i.HasMany(p => p.Investments)
                    .WithOne(p => p.Investor)
                    .HasForeignKey(p => p.InvestorId);
            });


            modelBuilder.Entity<Investment>(i =>
            {
                i.ToTable("investments");
                i.HasKey(p => p.Id);
                i.Property(p => p.Title).HasColumnType("varchar(70)")
                    .IsRequired();
                i.Property(p => p.AmountInvested).HasColumnType("decimal(18,6)");

                i.HasOne(p => p.InvestmentType)
                    .WithMany(p => p.Investments)
                    .HasForeignKey(p => p.InvestmentTypeId).OnDelete(DeleteBehavior.Restrict);

                i.HasOne(p => p.Investor)
                    .WithMany(p => p.Investments)
                    .HasForeignKey(p => p.InvestorId).OnDelete(DeleteBehavior.Restrict);
            });


            base.OnModelCreating(modelBuilder);
        }


        public DbSet<User> Users { get; set; }

        public DbSet<Investor> Investors { get; set; }

        public DbSet<InvestmentType> InvestmentTypes { get; set; }

        public DbSet<Bank> Banks { get; set; }

        public DbSet<InvestorBank> InvestorBanks { get; set; }

        public DbSet<Investment> Investments { get; set; }

        public DbSet<Role> Roles { get; set; }
    }
}

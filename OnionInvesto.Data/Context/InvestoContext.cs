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

        public DbSet<User> Users { get; set; }

        public DbSet<Investor> Investors { get; set; }

        public DbSet<InvestmentType> InvestmentTypes { get; set; }

        public DbSet<Bank> Banks { get; set; }

        public DbSet<InvestorBank> InvestorBanks { get; set; }

        public DbSet<Investment> Investments { get; set; }

        public DbSet<Manager> Managers { get; set; }

        public DbSet<Role> Roles { get; set; }
    }
}

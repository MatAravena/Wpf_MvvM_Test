using BackTest.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestEDM
{
    public class TestDBContext : DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Stock> Stock { get; set; }
        public DbSet<AssetTransaction> AssetTransactions { get; set; }
        public TestDBContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AssetTransaction>().OwnsOne(a => a.stock);
            base.OnModelCreating(modelBuilder);
        }
    }
}

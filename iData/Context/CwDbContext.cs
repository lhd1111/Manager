using iData.cw;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace iData.Context
{
    public class CwDbContext:DbContext
    {
        public CwDbContext(DbContextOptions<CwDbContext> options) : base(options) {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            //modelBuilder.Entity<InventoryClass>(builder =>
            //{
            //    builder.ToTable("InventoryClass").HasKey(e => e.cInvCCode);
            //    builder.Property(e => e.cInvCCode).HasMaxLength(12).IsRequired();
            //    builder.Property(e => e.cInvCName).HasMaxLength(100).IsRequired(false);
            //    builder.Property(e => e.iInvCGrades).IsRequired();
            //    builder.Property(e => e.cEcoCode).HasMaxLength(2).IsRequired(false);
            //    builder.Property(e => e.cBarCode).HasMaxLength(30).IsRequired(false);
            //});
            //modelBuilder.Entity<InventoryClass>().HasKey(e => e.cInvCCode);

        }
        //public DbSet<Inventory> inventories { get; set; }
        public DbSet<hr_Hi_Person> inventoryClasses { get; set; }
    }
}

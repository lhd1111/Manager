using iData.cw;
using iData.rs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace iData.Context
{
    public class TestDbContext : DbContext
    {
        public TestDbContext(DbContextOptions<TestDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Department>()
                        .HasMany(t => t.Children)
                        .WithOne(t => t.Parent)
                        .HasForeignKey(t => t.ParentId);

        }
        public DbSet<Department> Departments { get;set;}

    }
}

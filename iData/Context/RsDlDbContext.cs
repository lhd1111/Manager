using iData.rs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace iData.Context
{
    public class RsDlDbContext : DbContext
    {
        public RsDlDbContext(DbContextOptions<RsDlDbContext> options) : base(options) { }
        public DbSet<hr_hi_person> hr_hi_persons { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<hr_hi_person>().ToTable("hr_hi_person");
        }
    }
}

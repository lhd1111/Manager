using iData.cg;
using iData.cw;
using iData.mj;
using iData.Mobile;
using iData.rs;
using iData.System;
using iData.tech;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace iData.Context
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Rd_Pool>().ToTable("Rd_Pool").HasNoKey();
            modelBuilder.Entity<Rd_Month_Pool>().ToTable("Rd_Month_Pool").HasNoKey();
            modelBuilder.Entity<bom>().HasMany(t => t.Children)
                        .WithOne(t => t.Parent)
                        .HasForeignKey(t => t.ParentId);

            modelBuilder.Entity<Menu>().HasMany(t => t.Children)
            .WithOne(t => t.Parent)
            .HasForeignKey(t => t.ParentId);

            modelBuilder.Entity<Department>()
            .HasMany(t => t.Children)
            .WithOne(t => t.Parent)
            .HasForeignKey(t => t.ParentId);

            modelBuilder.Entity<Project>().HasMany(t => t.Boms).WithOne(t => t.Project).HasForeignKey(t => t.ProjectId);



            modelBuilder.Entity<AccountRole>()
            .HasKey(t => new { t.AccountId, t.RoleId });

            modelBuilder.Entity<AccountRole>()
                .HasOne(pt => pt.Account)
                .WithMany(p => p.Roles)
                .HasForeignKey(pt => pt.AccountId);

            modelBuilder.Entity<AccountRole>()
                .HasOne(pt => pt.Role)
                .WithMany(t => t.Accounts)
                .HasForeignKey(pt => pt.RoleId);
        }
        //人事
        public DbSet<Rd_Pool> rd_Pools { get; set; }
        public DbSet<Rd_Month_Pool> rd_Month_Pools { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<TwoEnum> TwoEnums { get; set; }
        public DbSet<EducationExp> EducationExps { get; set; }
        public DbSet<WorkExp> WorkExps { get; set; }
        public DbSet<TrainExp> TrainExps { get; set; }
        public DbSet<SalaryExp> Salaries { get; set; }
        public DbSet<ColToCol> ColToCols { get; set; }
        [Display(Name ="微信意见")]
        public DbSet<LeadIdea> LeadIdeas { get; set; }
        [Display(Name = "人工成本")]
        public DbSet<LaborCost> LaborCosts { get; set; }
        //技术中心
        public DbSet<bom> Boms { get; set; }
        public DbSet<Project> Projects { get; set; }

        //系统
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Menu> Menus { get; set; }

        //采购
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<SupplierCertificate> SupplierCertificates { get; set; }
        public DbSet<SinglePrice> SinglePrices { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public DbSet<MaterialSplitCost> MaterialSplitCosts { get; set; }
        public DbSet<PU_AppVouch> PU_AppVouchs { get; set; }

        //财务
        public DbSet<SalesReport> SalesReports { get; set; }
        public DbSet<ModelSplitCost> ModelSplitCosts { get; set; }
        public DbSet<ProductSale> ProductSales { get; set; }
        public DbSet<SalesFreight> SalesFreights { get; set; }


        //模具
        public DbSet<MouldState> MouldStates{get;set;}


        //移动账号
        public DbSet<WeChatUser> WeChatUsers { get; set; }
    }
}

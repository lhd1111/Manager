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

            modelBuilder.Entity<Token>().HasNoKey();
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
        [Display(Name = "离职成本")]
        public DbSet<LeaveCost> LeaveCosts { get; set; }
        [Display(Name = "考勤班次")]
        public DbSet<Frequency> Frequency { get; set; }
        [Display(Name = "班次日期")]
        public DbSet<CalendarKq> CalendarKq { get; set; }
        [Display(Name = "计件工时")]
        public DbSet<PersonPiece> PersonPieces { get; set; }
        [Display(Name = "审核标准")]
        public DbSet<SystemCheck> SystemChecks { get; set; }
        [Display(Name = "标准检查结果")]
        public DbSet<SystemCheckResult> SystemCheckResults { get; set; }
        [Display(Name = "标准检查结果")]
        public DbSet<Attendance> Attendances { get; set; }
        [Display(Name = "外部审核")]
        public DbSet<ExternalCheck> ExternalChecks { get; set; }
        [Display(Name = "审核结果")]
        public DbSet<ExternalCheckResult> ExternalCheckResults { get; set; }
        [Display(Name = "考勤汇总")]
        public DbSet<SalaryAttendance> SalaryAttendances { get; set; }
        [Display(Name = "新冠调查")]
        public DbSet<Covid_19> Covid_19s { get; set; }
        [Display(Name = "水电气")]
        public DbSet<LivingCost> LivingCost { get; set; }
        [Display(Name = "国家税务")]
        public DbSet<PersonTax> PersonTaxes { get; set; }
        [Display(Name = "租赁合同")]
        public DbSet<AccommodationContract> AccommodationContracts { get; set; }
        [Display(Name = "入住明细")]
        public DbSet<Accommodation> Accommodations { get; set; }
        [Display(Name = "软件著作")]
        public DbSet<SoftCopyright> SoftCopyrights { get; set; }
        [Display(Name = "班车统计")]
        public DbSet<BusSummary> BusSummaries { get; set; }
        //2021-12-27日以后，跟考试系统合并
        //public DbSet<PostModel> PostModels { get; set; }
        //public DbSet<PostQuestion> PostQuestions { get; set; }
        public DbSet<PostResult> PostResults { get; set; }
        public DbSet<TestModel> TestModels { get; set; }
        public DbSet<TestAnswer> TestAnswers { get; set; }
        public DbSet<TestPaper> TestPapers { get; set; }
        public DbSet<TestQuestion> TestQuestions { get; set; }
        public DbSet<PersonAnswer> PersonAnswers { get; set; }
        public DbSet<PersonTest> PersonTests { get; set; }
        [Display(Name = "薪资吻合度")]
        public DbSet<SalarySummary> SalarySummaries { get; set; }
        //固定资产管理
        [Display(Name = "固定资产")]
        public DbSet<FixedAsset> FixedAssets { get; set; }
        [Display(Name = "固定资产明细")]
        public DbSet<FixedAssetDetail> FixedAssetDetails { get; set; }
        [Display(Name = "固定资产领用明细表")]
        public DbSet<FixedAssetApply> FixedAssetApplies { get; set; }

        //技术中心
        public DbSet<bom> Boms { get; set; }
        public DbSet<Project> Projects { get; set; }

        //系统
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<UpLoadFile> UpLoadFiles { get; set; }
        public DbSet<Canlendar> Canlendars { get; set; }
        [Display(Name = "统一上传")]
        public DbSet<ContractUpLoadFile> ContractUpLoadFiles { get; set; }
        public DbSet<ApproveRequest> ApproveRequests { get; set; }
        public DbSet<Token> Tokens { get; set; }

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
        public DbSet<FreightSplit> FreightSplits { get; set; }
        public DbSet<CompanyBank> CompanyBanks { get; set; }
        //研发成本
        public DbSet<Expenditure> Expenditures { get; set; }


        //模具
        public DbSet<MouldState> MouldStates{get;set;}


        //移动账号
        public DbSet<WeChatUser> WeChatUsers { get; set; }
        public DbSet<TravelReport> TravelReport { get; set; }

        //项目管理部
        public DbSet<ProjectList> ProjectLists { get; set; }
        public DbSet<ProjectTask> ProjectTasks { get; set; }
        public DbSet<ProjectProblem> ProjectProblems { get; set; }

        //工艺部
        //机器列表
        public DbSet<Machine> Machines { get; set; }
        //模具-项目列表
        public DbSet<ModelList> ModelLists { get; set; }
        //模具巡检明细
        public DbSet<ModelDetail> ModelDetails { get; set; }
        //模具巡检明细记录
        public DbSet<CheckDetail> CheckDetails { get; set; }
        //标准更替表
        public DbSet<StandardHistory> StandardHistories { get; set; }

    }
}

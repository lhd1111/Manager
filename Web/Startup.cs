using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using iData.Context;
using iInterface.cw;
using iInterface.rs;
using iServices;
using iServices.zjb;
using iServices.rs;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using iData.rs;
using Microsoft.AspNetCore.Identity;

namespace Web
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            var myStr = _configuration.GetConnectionString("MyConnect");
            services.AddDbContext<MyDbContext>(options => { options.UseSqlServer(myStr, b => b.MigrationsAssembly("Web")); });
            var cwStr = _configuration.GetConnectionString("CwU8Connect");
            services.AddDbContext<CwDbContext>(options => { options.UseSqlServer(cwStr, b => b.MigrationsAssembly("iInterface")); });
            var rsStr = _configuration.GetConnectionString("RsU8Connect");
            services.AddDbContext<RsDbContext>(options => { options.UseSqlServer(rsStr, b => b.MigrationsAssembly("iInterface")); });
            var cqStr = _configuration.GetConnectionString("RsCqU8Connect");
            services.AddDbContext<RsCqDbContext>(options => { options.UseSqlServer(cqStr, b => b.MigrationsAssembly("iInterface")); });
            var tjStr = _configuration.GetConnectionString("RsTjU8Connect");
            services.AddDbContext<RsTjDbContext>(options => { options.UseSqlServer(tjStr, b => b.MigrationsAssembly("iInterface")); });
            var dlStr = _configuration.GetConnectionString("RsDlU8Connect");
            services.AddDbContext<RsDlDbContext>(options => { options.UseSqlServer(dlStr, b => b.MigrationsAssembly("iInterface")); });
            var tsStr = _configuration.GetConnectionString("TestConnect");
            services.AddDbContext<TestDbContext>(options => { options.UseSqlServer(tsStr, b => b.MigrationsAssembly("Web")); });
            //services.AddDbContext<TestDbContext>(options =>
            //{
            //    options.UseSqlServer(tsStr);
            //});

            services.AddCors(options => {
                options.AddPolicy("AllowAll",
                builder => {
                    builder.WithOrigins("http://locaolhost:4200/")
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        .AllowCredentials();
                });
            });
            services.AddDefaultIdentity<User>().AddEntityFrameworkStores<TestDbContext>();
            services.Configure<IdentityOptions>(options => {
                options.Password.RequireDigit = false;//需要数值
                options.Password.RequireLowercase = false;//需要小写
                options.Password.RequireNonAlphanumeric = false;//需要字符和数字组合类型
                options.Password.RequireUppercase = false;//需要大写
                options.Password.RequiredLength = 1;
                options.Password.RequiredUniqueChars = 1;

                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.AllowedForNewUsers = true;

                options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

                options.User.RequireUniqueEmail = false;//是否需要邮件
            });
            services.AddControllers();

            services.AddScoped<ihr_hi_personInterface, ihr_hi_personService>();
            services.AddScoped<iDepartmentInterface, iDepartmentService>();

            services.AddScoped<iRd_PoolInterface, iRd_PoolService>();
            services.AddScoped<iRd_Month_PoolInterface, iRd_Month_PoolService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //app.UseCors(options => {
            //    options.WithOrigins("http://*:4200");
            //    options.AllowAnyHeader();
            //    options.AllowCredentials();
            //    options.AllowAnyMethod();
            //});
            //app.UseCors(MyAllowSpecificOrigins);
            app.UseCors("AllowAll");
            app.UseStaticFiles();
            
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                
                endpoints.MapControllerRoute("default", "{Controller=Home}/{Action=Index}/{id?}");
                endpoints.MapAreaControllerRoute("area", "area", "{area:exists}/{Controller=Home}/{Action=Index}/{id?}");

            });
        }
    }
}

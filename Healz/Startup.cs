using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Healz.DatabaseConnection;
using Healz.Entities;
using Healz.Repository.Implimentation;
using Healz.Repository.Interfaces;
using Heaz.Repository.Implimentation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Healz
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContextPool<AppDbContext>(
           options => options.UseSqlServer(Configuration.GetConnectionString("DBConnection")));

           
            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequiredLength = 8;
                options.Password.RequiredUniqueChars = 3;
                options.Password.RequireNonAlphanumeric = false;
            });

            //services.AddIdentity<ApplicationUser, IdentityRole>()
            //.AddEntityFrameworkStores<AppDbContext>();


            //custom
            services.AddIdentity<ApplicationUser, ApplicationRole>()
               //options => options.Stores.MaxLengthForKeys = 128)
               .AddEntityFrameworkStores<AppDbContext>();
               //.AddDefaultUI()
               //.AddDefaultTokenProviders();




            services.AddMvc(config =>
            {
                var policy = new AuthorizationPolicyBuilder()
                                .RequireAuthenticatedUser()
                                .Build();
                config.Filters.Add(new AuthorizeFilter(policy));
            });

            services.ConfigureApplicationCookie(options =>
            {
                options.AccessDeniedPath = new PathString("/Home/E_404");//part 97
            });


            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IPateintInfoRepository, PatientRepository>();


            services.AddAuthorization(options =>
            {
                options.AddPolicy("EditRolePolicy", policy => policy
                     .RequireRole("Admin")
                     //.RequireClaim("Edit Role", "true")                          //   video 99
                     //.RequireRole("Admin")
                 ); 
                options.AddPolicy("DeleteRolePolicy",
                    policy => policy.RequireClaim("Delete Role").RequireClaim("Create Role"));

                //options.AddPolicy("EditRolePolicy", policy => policy.RequireClaim("Edit Role", "true"));//part 96

                options.AddPolicy("AdminRolePolicy", policy => policy.RequireRole("Admin")); //part 95
                options.AddPolicy("DoctorRolePolicy", policy => policy.RequireRole("Doctor")); //part 95
                options.AddPolicy("UserRolePolicy", policy => policy.RequireRole("User")); //part 95
            });
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env,
            AppDbContext context,
            RoleManager<ApplicationRole> roleManager,
            UserManager<ApplicationUser> userManager)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
            DummyData.Initialize(context, userManager, roleManager).Wait();
        }
    }
}

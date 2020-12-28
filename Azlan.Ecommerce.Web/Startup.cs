using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Azlan.Ecommerce.Business.Containers.MicrosoftIoC;
using Azlan.Ecommerce.DataAccess.Concrete.EfCore.Context;
using Azlan.Ecommerce.Entities;
using Azlan.Ecommerce.Web.Seeds;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Azlan.Ecommerce.Web
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
            // ICategoryDal gordugun yerde EfCoreCategoryDal i al gibi seyleri business katmaninda yazdik;
            services.AddDependencies();

            services.AddDbContext<ApplicationDbContext>();
            services.AddIdentity<AppUser, IdentityRole>().AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();

            services.Configure<IdentityOptions>(options =>
            {
                // for password;
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 6;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireDigit = false;

                // kullaniciyi sifresini kac defa yanlis girdiginde kac dakika blocklansin, yeni kayit olmus kullanici icin blocklama gecerli olsun mu;
                //options.Lockout.MaxFailedAccessAttempts = 5;
                //options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                //options.Lockout.AllowedForNewUsers = true;

                // username icinde sadece belli karakterlerin kullanilmasini istiyorsak;
                //options.User.AllowedUserNameCharacters = "";

                // email adresi unique olsun. bir email adresi bir kere register olabilsin;
                options.User.RequireUniqueEmail = true;

                // sadece email i confirmed olmus kullaniciya login izni vermek icin;
                //options.SignIn.RequireConfirmedEmail = true;
                //options.SignIn.RequireConfirmedPhoneNumber = false;
            });

            services.ConfigureApplicationCookie(opt =>
            {
                opt.Cookie.Name = "HQuiOjHKslKEcqQ";
                opt.Cookie.SameSite = Microsoft.AspNetCore.Http.SameSiteMode.Strict;
                opt.Cookie.HttpOnly = true;
                opt.ExpireTimeSpan = TimeSpan.FromDays(30);
                opt.Cookie.SecurePolicy = Microsoft.AspNetCore.Http.CookieSecurePolicy.SameAsRequest;
                // Login sayfamiz nerdeyse onu belirtiyoruz ki kullanici giris yapmamissa oraya yonlensin;
                opt.LoginPath = "/account/login";
                opt.LogoutPath = "/account/logout";
                // Access Denied(kullanici yetkisi olmadigi biryere gitmeye calistiginda yonlendirecegimiz controller ve action);
                opt.AccessDeniedPath = "/account/accessdenied";
            });

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "product",
                    pattern: "product/{id?}/{slug?}",
                    defaults: new { controller = "Shop", action = "ProductDetail" }
                    );

                endpoints.MapControllerRoute(
                    name: "products",
                    pattern: "products/{category?}",
                    defaults: new { controller = "Shop", action = "List" }
                    );

                endpoints.MapControllerRoute(
                    name: "cart",
                    pattern: "cart",
                    defaults: new { controller = "Cart", action = "Index" }
                    );

                endpoints.MapControllerRoute(
                    name: "areas",
                    pattern: "{area}/{controller=Dashboard}/{action=Index}/{id?}"
                    );

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            // User Seed Islemi;
            IdentitySeed.SeedIdentity(userManager, roleManager).Wait();
        }
    }
}

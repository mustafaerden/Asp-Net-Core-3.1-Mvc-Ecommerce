using Azlan.Ecommerce.DataAccess.Concrete.EfCore.TableConfig;
using Azlan.Ecommerce.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Azlan.Ecommerce.DataAccess.Concrete.EfCore.Context
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB; database=MvcEcommerce; integrated security=true;");

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new CategoryConfig());
            builder.ApplyConfiguration(new ProductConfig());
            builder.ApplyConfiguration(new ProductCategoryConfig());
            builder.ApplyConfiguration(new ProductImageConfig());
            builder.ApplyConfiguration(new AppUserConfig());

            base.OnModelCreating(builder);
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Cart> Carts { get; set; }
        // NOTE:: CartItem tablosunu buraya eklemedik. Cunku CartItem tablosu ile direk bir islem yapmiycaz, business ve data access katmanlarinda da CartItem ile islem olmayacak. CartItem ile ilgili olan isleri direk Cart tablosu uzerinden yapiyor olucaz. Cart tablosu hasMany CartItem tablosu iliskisi uzerinden.
        public DbSet<Order> Orders { get; set; }
    }
}

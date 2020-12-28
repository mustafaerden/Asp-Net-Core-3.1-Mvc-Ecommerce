using Azlan.Ecommerce.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Azlan.Ecommerce.DataAccess.Concrete.EfCore.TableConfig
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(I => I.Name).HasMaxLength(155).IsRequired();
            builder.Property(I => I.Slug).HasMaxLength(165).IsRequired();
            builder.Property(I => I.StockCount).HasMaxLength(5).HasDefaultValue(0).IsRequired();
            builder.Property(I => I.Description).HasColumnType("ntext");
            //builder.Property(p => p.Price).HasColumnType("decimal(18,2)");

            builder.HasMany(I => I.ProductCategories).WithOne(I => I.Product).HasForeignKey(I => I.ProductId);
            builder.HasMany(I => I.ProductImages).WithOne(I => I.Product).HasForeignKey(I => I.ProductId);
        }
    }
}

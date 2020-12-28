using Azlan.Ecommerce.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Azlan.Ecommerce.DataAccess.Concrete.EfCore.TableConfig
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(I => I.Name).HasMaxLength(55).IsRequired();
            builder.Property(I => I.Slug).HasMaxLength(65).IsRequired();

            builder.HasOne(I => I.ParentCategory).WithMany(I => I.SubCategories).HasForeignKey(I => I.ParentCategoryId);

            builder.HasMany(I => I.ProductCategories).WithOne(I => I.Category).HasForeignKey(I => I.CategoryId);
        }
    }
}

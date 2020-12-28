using Azlan.Ecommerce.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Azlan.Ecommerce.DataAccess.Concrete.EfCore.TableConfig
{
    public class ProductCategoryConfig : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.HasIndex(I => new { I.ProductId, I.CategoryId }).IsUnique();
        }
    }
}

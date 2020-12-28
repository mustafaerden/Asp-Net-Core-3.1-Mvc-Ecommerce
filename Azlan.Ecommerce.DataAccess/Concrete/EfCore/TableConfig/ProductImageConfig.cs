using Azlan.Ecommerce.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Azlan.Ecommerce.DataAccess.Concrete.EfCore.TableConfig
{
    public class ProductImageConfig : IEntityTypeConfiguration<ProductImage>
    {
        public void Configure(EntityTypeBuilder<ProductImage> builder)
        {
            builder.Property(I => I.Url).HasMaxLength(155).IsRequired();
        }
    }
}

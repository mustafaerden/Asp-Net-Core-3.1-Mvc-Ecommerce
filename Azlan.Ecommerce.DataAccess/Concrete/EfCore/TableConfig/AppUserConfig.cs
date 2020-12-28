using Azlan.Ecommerce.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Azlan.Ecommerce.DataAccess.Concrete.EfCore.TableConfig
{
    public class AppUserConfig : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.Property(I => I.FirstName).HasMaxLength(55).IsRequired();
            builder.Property(I => I.MiddleName).HasMaxLength(55);
            builder.Property(I => I.LastName).HasMaxLength(55).IsRequired();
            builder.Property(I => I.Address).HasMaxLength(255);
            builder.Property(I => I.City).HasMaxLength(100);
        }
    }
}

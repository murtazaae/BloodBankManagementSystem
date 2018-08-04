using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BBMS.Data
{
   public class BloodGroupMap
    {
        public BloodGroupMap(EntityTypeBuilder<BloodGroup> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(e => e.Id);
            entityTypeBuilder.Property(e => e.AddedDate);
            entityTypeBuilder.Property(e => e.BloodGroupName).IsRequired();
            entityTypeBuilder.Property(e => e.IPAddress);
            entityTypeBuilder.Property(e => e.IsActive);
            entityTypeBuilder.Property(e => e.IsDeleted);
            entityTypeBuilder.Property(e => e.ModifiedDate);
            
        }
    }
}

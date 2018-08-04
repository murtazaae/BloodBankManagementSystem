using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BBMS.Data
{
    public class BloodMap
    {
        public BloodMap(EntityTypeBuilder<Blood> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(e => e.Id);
            entityTypeBuilder.Property(e => e.AddedDate);
            entityTypeBuilder.HasOne(e => e.BloodGroup).WithOne(u => u.Blood).HasForeignKey<BloodGroup>(x => x.Id).OnDelete(DeleteBehavior.Restrict);
            entityTypeBuilder.Property(e => e.BloodGroupID);
            entityTypeBuilder.Property(e => e.DateOfCollection);

            entityTypeBuilder.HasOne(e => e.Donor).WithOne(u => u.Blood).HasForeignKey<Donor>(x => x.Id).OnDelete(DeleteBehavior.Restrict);
            entityTypeBuilder.Property(e => e.DonorID).IsRequired();
            entityTypeBuilder.Property(e => e.EventID).IsRequired();
            entityTypeBuilder.HasOne(e => e.Events).WithOne(u => u.Blood).HasForeignKey<Events>(x => x.Id).OnDelete(DeleteBehavior.Restrict);
            entityTypeBuilder.Property(e => e.ExpiryDate);
            entityTypeBuilder.Property(e => e.IPAddress);
            entityTypeBuilder.Property(e => e.ModifiedDate);

        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BBMS.Data
{
    public class DonorMap
    {
        public DonorMap(EntityTypeBuilder<Donor> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(e => e.Id);
            entityTypeBuilder.Property(e => e.AddedDate);
            entityTypeBuilder.Property(e => e.Address);
            entityTypeBuilder.Property(e => e.BloodGroupID);
            entityTypeBuilder.HasOne(e => e.BloodGroup).WithOne(u => u.Donor).HasForeignKey<BloodGroup>(x => x.Id).OnDelete(DeleteBehavior.Restrict);
            entityTypeBuilder.Property(e => e.ContactNumber);
            entityTypeBuilder.Property(e => e.DateofBirth);
            entityTypeBuilder.Property(e => e.Diseases);
            entityTypeBuilder.Property(e => e.Gender);
            entityTypeBuilder.Property(e => e.IPAddress);
            entityTypeBuilder.Property(e => e.IsActive);
            entityTypeBuilder.Property(e => e.IsDeleted);
            entityTypeBuilder.Property(e => e.ModifiedDate);
            entityTypeBuilder.Property(e => e.NameAr);
            entityTypeBuilder.Property(e => e.NameEn).IsRequired();
            
        }
    }
}

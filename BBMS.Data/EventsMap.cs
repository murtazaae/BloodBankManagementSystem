using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BBMS.Data
{
    public class EventsMap
    {
        public EventsMap(EntityTypeBuilder<Events> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(e => e.Id);
            entityTypeBuilder.Property(e => e.AddedDate);
            entityTypeBuilder.Property(e => e.DateofDonation);
            entityTypeBuilder.Property(e => e.IPAddress);
            entityTypeBuilder.Property(e => e.IsActive);
            entityTypeBuilder.Property(e => e.IsDeleted);
            entityTypeBuilder.Property(e => e.ModifiedDate);
            entityTypeBuilder.Property(e => e.NameAr);
            entityTypeBuilder.Property(e => e.NameEn).IsRequired();
            entityTypeBuilder.Property(e => e.TotalBloodCollected);
            entityTypeBuilder.Property(e => e.Venue);
            entityTypeBuilder.Property(e => e.Volunteers);
            
        }
    }
}

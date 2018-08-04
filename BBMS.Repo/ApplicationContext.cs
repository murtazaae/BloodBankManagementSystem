using BBMS.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BBMS.Repo
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
           
            new BloodMap(modelBuilder.Entity<Blood>());
            new BloodGroupMap(modelBuilder.Entity<BloodGroup>());
            new DonorMap(modelBuilder.Entity<Donor>());
            new EventsMap(modelBuilder.Entity<Events>());

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BBMS.Data
{
    public class Events : BaseEntity
    {

        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public DateTime DateofDonation { get; set; }
        public string Venue { get; set; }
        public string Volunteers { get; set; }
        public int? TotalBloodCollected { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

        public virtual  Blood Blood { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BBMS.Data
{
    public class Donor : BaseEntity
    {

        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public DateTime DateofBirth { get; set; }
        public string Gender { get; set; }

        public virtual BloodGroup BloodGroup { get; set; }
        public int BloodGroupID { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string Diseases { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Blood Blood { get; set; }

    }
}

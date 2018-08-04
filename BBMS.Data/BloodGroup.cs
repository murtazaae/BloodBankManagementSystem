using System;
using System.Collections.Generic;
using System.Text;

namespace BBMS.Data
{
    public class BloodGroup: BaseEntity
    {
        public string BloodGroupName { get; set; }
        public bool IsActive{ get; set; }
        public bool IsDeleted{ get; set; }
        public virtual Blood Blood{ get; set; }
        public virtual Donor Donor{ get; set; }
    }
}

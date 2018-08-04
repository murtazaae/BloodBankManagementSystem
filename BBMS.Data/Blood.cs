using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BBMS.Data
{
    public class Blood : BaseEntity
    {
        [Column("BloodGroupID", Order = 2)]
        [ForeignKey("BloodGroup")]
        public int BloodGroupID { get; set; }
        [ForeignKey("BloodGroupID")]
        public virtual BloodGroup BloodGroup { get; set; }


        [Column("DonorID", Order = 3)]
        [ForeignKey("Donor")]
        public int DonorID { get; set; }
        [ForeignKey("DonorID")]
        public virtual Donor Donor { get; set; }


        [Column("EventID", Order = 4)]
        [ForeignKey("Events")]
        public int EventID { get; set; }
        [ForeignKey("EventID")]
        public virtual Events Events { get; set; }


        [Column("DateOfCollection", Order = 5)]
        public DateTime DateOfCollection { get; set; }

        [Column("ExpiryDate", Order = 6)]
        public DateTime ExpiryDate { get; set; }
    }
}

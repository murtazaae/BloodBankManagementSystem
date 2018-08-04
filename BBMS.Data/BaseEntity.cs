using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BBMS.Data
{
    public class BaseEntity
    {
        [Column("Id", Order = 0)]
        public int Id { get; set; }

        [Column("AddedDate", Order = 7)]
        public DateTime AddedDate { get; set; }
        [Column("ModifiedDate", Order = 8)]
        public DateTime ModifiedDate { get; set; }

        [Column("IPAddress", Order = 9)]
        public string IPAddress { get; set; }
    }
}

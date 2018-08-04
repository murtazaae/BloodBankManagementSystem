using BBMS.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace BBMS.Service
{
    public interface IBloodGroupGroupService
    {
        IEnumerable<BloodGroup> GetBloodGroups();
        BloodGroup GetBloodGroup(long id);
        void InsertBloodGroup(BloodGroup bloodGroup);
        void UpdateBloodGroup(BloodGroup bloodGroup);
        void DeleteBloodGroup(long id);

    }
}

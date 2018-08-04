using BBMS.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace BBMS.Service
{
   public interface IDonorService
    {
        IEnumerable<Donor> GetDonors();
        Donor GetDonor(long id);
        void InsertDonor(Donor donor);
        void UpdateDonor(Donor donor);
        void DeleteDonor(long id);
    }
}

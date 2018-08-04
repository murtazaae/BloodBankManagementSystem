using BBMS.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace BBMS.Service
{
    public interface IBloodService
    {
        IEnumerable<Blood> GetBloods();
        Blood GetBlood(long id);
        void InsertBlood(Blood blood);
        void UpdateBlood(Blood blood);
        void DeleteBlood(long id);
    }
}

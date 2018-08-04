using BBMS.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace BBMS.Service
{
    interface IEventService
    {
        IEnumerable<Events> GetEvents();
        Events GetEvent(long id);
        void InsertEvent(Events events);
        void UpdateEvent(Events events);
        void DeleteEvent(long id);
    }
}

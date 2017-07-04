using GeoEvents.Repository.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeoEvents.Common;

namespace GeoEvents.Repository
{
    public class EventRepository : IEventRepository
    {
        public bool CreateEvent(IEventEntity evt)
        {
            
        }

        public List<IEventEntity> GetEvents(IFilter filter)
        {
            throw new NotImplementedException();
        }

        public List<IImageEntity> GetImages(Guid eventID)
        {
            throw new NotImplementedException();
        }
    }
}

using GeoEvents.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoEvents.Repository.Common
{
    public interface IEventRepository
    {


        bool CreateEvent(IEventEntity evt);


        List<IEventEntity> GetEvents(IFilter filter);


        List<IImageEntity> GetImages(Guid eventID);

        bool CreateImages(IImageEntity img,Guid eventId);

    }
}

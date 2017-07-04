using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoEvents.Service
{
    public class EventService : IEventService
    {
        #region Properties

        protected IEventRepository Repository { get; set; }

        #endregion Properties



        #region Constructors

        public EventService(IEventRepository repository)
        {
            this.Repository = repository;
        }


        #endregion Constructors



        #region Methods

        bool CreateEvent(IEvent evt) 
        {
            return Repository.CreateEvent(evt);
        }

        public List<IEvent> GetEvents(IFilter filter)
        {
            return Repository.GetEvents(filter);
        }

        public List<IImage> GetImages(Guid eventId)
        {
            return Repository.GetImages(eventId);
        }

        #endregion Methods

    }
}

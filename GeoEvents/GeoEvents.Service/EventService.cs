using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeoEvents.Service.Common;
using GeoEvents.Model.Common;
using GeoEvents.Common;
using GeoEvents.Repository.Common;

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

        public bool CreateEvent(IEvent evt) 
        {
            evt.Category = 0;
            for(int i = 0; i < evt.Categories.Count;  i++)
            {
                evt.Category += evt.Categories[i];
            }
            return Repository.CreateEvent(evt);
        }

        public List<IEvent> GetEvents(IFilter filter)
        {
            List<IEvent> events = Repository.GetEvents(filter);
            foreach(IEvent evt in events)
            {
                int mult = 1;
                evt.Categories = new List<int>();
                int cat = evt.Category;
                while(cat > 0)
                {
                    int mod = cat % 2;
                    if(mod == 1)
                    {
                        evt.Categories.Add(mult);
                    }
                    mult *= 2;
                    cat = cat >> 1;
                }
            }
            return events;
        }

        public List<IImage> GetImages(Guid eventId)
        {
            return Repository.GetImages(eventId);
        }

        #endregion Methods

    }
}

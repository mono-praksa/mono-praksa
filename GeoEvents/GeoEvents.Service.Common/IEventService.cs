using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeoEvents.Model.Common;
using GeoEvents.Common;

namespace GeoEvents.Service.Common
{
    public interface IEventService
    {
        #region Methods
        /// <summary>
        /// Gets events that satisfy the filter.
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <returns></returns>
        List<IEvent> GetEvents(IFilter filter);

        /// <summary>
        /// Gets images attached to an event.
        /// </summary>
        /// <param name="eventId">The event's id.</param>
        /// <returns></returns>
        List<IImage> GetImages(Guid eventId);

        /// <summary>
        /// Creates event.
        /// </summary>
        /// <returns></returns>
        bool CreateEvents(IEvent evt);

        #endregion Methods
    }
}

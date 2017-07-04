using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeoEvents.Model.Common;
using GeoEvents.Common;

namespace GeoEvents.Model
{
    public class Event : IEvent
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public decimal Lat { get; set; }
        public decimal Long { get; set; }
        public int Category { get; set; }
        public DateTime EndTime { get; set; }
        public List<int> Categories { get; set; }
    }
}

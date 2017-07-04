using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeoEvents.Model.Common;

namespace GeoEvents.Model
{
    public class Event : IEvent
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Lat { get; set; }
        public decimal Long { get; set; }
        public List<int> Categories { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public Event(Guid id, string name, string description, decimal longitude, decimal latitude, List<int> categories, DateTime startTime, DateTime endTime) {
            Id = id;
            Name = name;
            Description = description;
            Long = longitude;
            Lat = latitude;
            Categories = categories;
            StartTime = startTime;
            EndTime = endTime;
        }
    }
}

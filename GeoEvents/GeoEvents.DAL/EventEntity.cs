using GeoEvents.Repository.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoEvents.DAL
{
    public class EventEntity : IEventEntity
    {
        public Guid  Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public Decimal Lat { get; set; }
        public Decimal Long { get; set; }
        public string Name { get; set; }
        public string Description  { get; set; }
        public int Category { get; set; }
    }
}


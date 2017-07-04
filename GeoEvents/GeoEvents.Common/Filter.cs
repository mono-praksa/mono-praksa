using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoEvents.Common
{
    public class Filter
    {
        #region Properties
        public decimal ULat { get; set; }
        public decimal ULong { get; set; }
        public decimal Radius { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        #endregion Properties
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoEvents.Common
{
    public interface IFilter
    {
        #region Properties
        decimal ULat { get; set; }
        decimal ULong { get; set; }
        decimal Radius { get; set; }
        DateTime StartTime { get; set; }
        DateTime EndTime { get; set; }
        int Category { get; set; }
        #endregion Properties
    }
}

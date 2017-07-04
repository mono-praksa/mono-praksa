using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeoEvents.Model;

namespace GeoEvents.WebAPI
{
    public static class AutoMapperConfig
    {
        public static void Initialize()
        {
            GeoEvents.Model.Mapping.AutoMapperMaps.Initialize();
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeoEvents.Model.Common;
using GeoEvents.Repository.Common;

namespace GeoEvents.Service
{
    public class AutoMapperInitializer
    {
        public static void AutomapperMappings()
        {
            AutoMapper.Mapper.Initialize(config => {
                config.CreateMap<IEventsEntity, IEvent>();
            });
        }


    }
}

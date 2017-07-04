using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoEvents.WebAPI
{
    class ImagesModel
    {
        public Guid Id { get; set; }
        public Guid EventId { get; set; }
        public byte[] Content { get; set; }
    }
}

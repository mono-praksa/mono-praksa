using GeoEvents.Service.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GeoEvents.WebAPI.Controllers
{
    [RoutePrefix("api/")]
    public class Controller : ApiController
    {
        [HttpPost]
        [Route("createEvent")]
        public void CreateEvent() {
            
        }
    }
}

using GeoEvents.Repository.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeoEvents.Common;
using GeoEvents.DAL;
using Npgsql;
using System.Data;

namespace GeoEvents.Repository
{
    public class EventRepository : IEventRepository
    {
        PostgressConnection PostgresConn;

        public EventRepository()
        {
            PostgresConn = new PostgressConnection();
        }

        public bool CreateEvent(IEventEntity evt)
        {
            PostgresConn.OpenConnection();


            IDbCommand command = PostgresConn.NpgConn();
            string query = "INSERT into \"Events\" VALUES(uuid_generate_v4(),'2003-2-1'::timestamp,'2003-6-1'::timestamp,2.3,2.5,'nekievent','diesrefgh')";
            command.CommandText = query;
            command.ExecuteNonQuery();

            return true;
        }

        public List<IEventEntity> GetEvents(IFilter filter)
        {
            throw new NotImplementedException();
        }

        public List<IImageEntity> GetImages(Guid eventID)
        {
            throw new NotImplementedException();
        }
    }
}

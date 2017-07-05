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
            bool Flag=false;


            NpgsqlCommand command = PostgresConn.NpgComm();
            command = new NpgsqlCommand
                ("insert into \"Events\" values(@Id, @StartTime, @EndTime, @Lat, @Long, @Name, @Description, @Category)",
                PostgresConn.NpgConn());

            command.Parameters.AddWithValue("@Id", evt.Id);
            command.Parameters.AddWithValue("@Category", evt.Category);
            command.Parameters.AddWithValue("@Description", evt.Description);
            command.Parameters.AddWithValue("@StartTime", evt.StartTime);
            command.Parameters.AddWithValue("@EndTime", evt.EndTime);
            command.Parameters.AddWithValue("@Lat", evt.Lat);
            command.Parameters.AddWithValue("@Long", evt.Long);
            command.Parameters.AddWithValue("@Name", evt.Name);

            if (command.ExecuteNonQuery() == 1)
            {
                Flag = true;
            }

            PostgresConn.CloseConnection();

            return Flag;
        }

        public bool CreateImages(IImageEntity img, Guid eventId)
        {
            throw new NotImplementedException();
        }

        public List<IEventEntity> GetEvents(IFilter filter)
        {
            PostgresConn.OpenConnection();

            NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM \"Events\" WHERE ", PostgresConn.NpgConn());

            NpgsqlDataReader dr = command.ExecuteReader();

            EventEntity tmp;
            List<IEventEntity> SelectEvents= new List<IEventEntity>();

            while (dr.Read())
            {
                tmp = new EventEntity { Name = dr[1].ToString(), StartTime = Convert.ToDateTime(dr[0]) };
               SelectEvents.Add(tmp);
            }

            return SelectEvents;
        }

        public List<IImageEntity> GetImages(Guid eventID)
        {
            throw new NotImplementedException();
        }
    }
}
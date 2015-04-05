using iTrack.Web.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace iTrack.Web.Api.Controllers
{
    [Authorize]
    [RoutePrefix("api/tracks")]
    public class TracksController : ApiController
    {
        private Entities.iTrackContext db;

        public TracksController()
        {
            db = new Entities.iTrackContext();
        }

        [HttpGet]
        [Route("")]
        public dynamic Get()
        {
            string companies = Utils.WebAuth.GetCompanies(User);
            string vehicles = Utils.WebAuth.GetVehicles(User);

            var tr = from c in this.db.GPSreceives
                     join o in this.db.Tracking_Objects on c.Receive_ID equals o.Last_Track_ID
                     select new Track
                     {
                         ID = c.Receive_ID,
                         Title = o.Name,
                         CompanyID = o.Customer_ID.Value,
                         VehicleID = o.Trackin_Object_ID,
                         datetime = c.DateTime,
                         Longitude = c.Longitude,
                         Latitude = c.Latitude,
                         Speed = c.Speed,
                         Heading = c.Heading,
                         Altitude = c.Altitude,
                         GSMsingal = c.GSMsignal,
                         Satelites = c.Satelites,
                         Alarm = c.Alarm,
                         AlarmType = c.TypeOfAlarm,
                         isSelected = true,
                         EngineOn = o.Engine_start.Value,
                         gpsOn = o.Object_GPS_Valid.Value,
                         gprsOff = o.Object_Lost.Value,
                         alarmOff = o.Object_Alarm.Value
                     };

            if (companies != "*")
            {
                long[] arrayIDs = Utils.Converter.StringToLongArray(companies);
                tr = tr.Where(t => arrayIDs.Contains(t.CompanyID));
            }

            if (vehicles != "*")
            {
                long[] arrayIDs = Utils.Converter.StringToLongArray(vehicles);
                tr = tr.Where(t => arrayIDs.Contains(t.VehicleID));
            }

            var obj = new { type = "FeatureCollection", features = new List<dynamic>() };
            
            foreach(Track item in tr)
            {
                obj.features.Add(new 
                {
                    type = "Feature",
                    id = item.ID,
                    properties = new 
                    { 
                        NAME = item.Title, 
                        TIME = item.datetime, 
                        SPEED = item.Speed,
                        HEADING = item.Heading,
                        ALT = item.Altitude,
                        SAT = item.Satelites,
                        GSM = item.GSMsingal,
                        COLOR = item.Color,
                        Alarm = item.Alarm,
                        AlarmType = item.AlarmType,
                        AlarmOff = item.alarmOff,
                        EngineOn = item.EngineOn,
                        GprsOff = item.gprsOff,
                        GpsOn = item.gpsOn
                    },
                    geometry = new { type = "Point", coordinates = item.Coordinates}
                });
            }

            return obj;
        }

        [HttpGet]
        [Route("{lastHour}/{id}/{vehicles}/{apo}/{eos}")]
        public IEnumerable<Track> Get(bool lastHour, long id, long[] vehicles, DateTime apo, DateTime eos)
        {
            if (id == 0)
            {
                var tr = from c in this.db.GPSreceives
                         join o in this.db.Tracking_Objects on c.Receive_ID equals o.Last_Track_ID
                         where vehicles.Contains(o.Trackin_Object_ID)
                         select new Track
                         {
                             ID = c.Receive_ID,
                             Title = o.Name,
                             VehicleID = o.Trackin_Object_ID,
                             datetime = c.DateTime,
                             Longitude = c.Longitude,
                             Latitude = c.Latitude,
                             Speed = c.Speed,
                             Heading = c.Heading,
                             Altitude = c.Altitude,
                             GSMsingal = c.GSMsignal,
                             Satelites = c.Satelites,
                             Alarm = c.Alarm,
                             AlarmType = c.TypeOfAlarm,
                             isSelected = true,
                             EngineOn = o.Engine_start.Value,
                             gpsOn = o.Object_GPS_Valid.Value,
                             gprsOff = o.Object_Lost.Value,
                             alarmOff = o.Object_Alarm.Value
                         };
                return tr;
            }
            else
            {
                if (lastHour == true)
                {
                    var lastdate = (from c in this.db.GPSreceives
                                    where c.Trackin_Object_ID == id
                                    select c.DateTime).Max();
                    if (lastdate == null) lastdate = DateTime.Now;
                    lastdate = lastdate.Value.AddHours(-3);

                    var tr = (from c in this.db.GPSreceives
                              join o in this.db.Tracking_Objects on c.Trackin_Object_ID equals o.Trackin_Object_ID
                              where c.Trackin_Object_ID == id
                              && c.DateTime >= lastdate
                              orderby c.DateTime descending
                              select new Track
                              {
                                  ID = c.Receive_ID,
                                  Title = o.Name,
                                  VehicleID = o.Trackin_Object_ID,
                                  datetime = c.DateTime,
                                  Longitude = c.Longitude,
                                  Latitude = c.Latitude,
                                  Speed = c.Speed,
                                  Heading = c.Heading,
                                  Altitude = c.Altitude,
                                  GSMsingal = c.GSMsignal,
                                  Satelites = c.Satelites,
                                  Alarm = c.Alarm,
                                  AlarmType = c.TypeOfAlarm,
                                  isSelected = true,
                                  EngineOn = c.EngineStart.Value
                              });
                    return tr;
                }
                else
                {
                    apo = apo.ToUniversalTime();
                    eos = eos.ToUniversalTime();
                    var tr = (from c in this.db.GPSreceives
                              join o in this.db.Tracking_Objects on c.Trackin_Object_ID equals o.Trackin_Object_ID
                              where c.Trackin_Object_ID == id
                              && c.DateTime >= apo
                              && c.DateTime <= eos
                              orderby c.DateTime descending
                              select new Track
                              {
                                  ID = c.Receive_ID,
                                  Title = o.Name,
                                  VehicleID = o.Trackin_Object_ID,
                                  datetime = c.DateTime,
                                  Longitude = c.Longitude,
                                  Latitude = c.Latitude,
                                  Speed = c.Speed,
                                  Heading = c.Heading,
                                  Altitude = c.Altitude,
                                  GSMsingal = c.GSMsignal,
                                  Satelites = c.Satelites,
                                  Alarm = c.Alarm,
                                  AlarmType = c.TypeOfAlarm,
                                  isSelected = true,
                                  EngineOn = c.EngineStart.Value
                              });
                    return tr;
                }
            }
        }

        [HttpGet]
        [Route("{trID}/{recIDstart}/{recIDend}")]
        public IQueryable<Track> Get(long trID, long recIDstart, long recIDend)
        {
            var tr = (from c in this.db.GPSreceives
                      join o in this.db.Tracking_Objects on c.Trackin_Object_ID equals o.Trackin_Object_ID
                      where c.Trackin_Object_ID == trID && c.Receive_ID >= recIDstart && c.Receive_ID <= recIDend
                      orderby c.DateTime descending
                      select new Track
                      {
                          ID = c.Receive_ID,
                          Title = o.Name,
                          VehicleID = o.Trackin_Object_ID,
                          datetime = c.DateTime,
                          Longitude = c.Longitude,
                          Latitude = c.Latitude,
                          Speed = c.Speed,
                          Heading = c.Heading,
                          Altitude = c.Altitude,
                          GSMsingal = c.GSMsignal,
                          Satelites = c.Satelites,
                          Alarm = c.Alarm,
                          AlarmType = c.TypeOfAlarm,
                          isSelected = true,
                          EngineOn = c.EngineStart.Value
                      });
            return tr;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                db.Dispose();

            base.Dispose(disposing);
        }
    }
}

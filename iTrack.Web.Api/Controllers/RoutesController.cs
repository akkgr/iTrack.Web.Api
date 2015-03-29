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
    [RoutePrefix("api/routes")]
    public class RoutesController : ApiController
    {
        private Entities.iTrackContext db;

        public RoutesController()
        {
            db = new Entities.iTrackContext();
        }

        [HttpGet]
        [Route("{id}/{apo}/{eos}")]
        public IEnumerable<Route> Get(long id, DateTime apo, DateTime eos)
        {
            var routes = from r in this.db.Tracking_Object_Routes
                         where r.Trackin_Object_ID == id
                         && r.Start_Date_Time >= apo
                         && r.Start_Date_Time <= eos
                         select new Route
                         {
                             ID = r.Routes_ID,
                             VechicleID = r.Trackin_Object_ID.Value,
                             dateFrom = r.Start_Date_Time,
                             LatFrom = r.Start_Latitude,
                             LonFrom = r.Start_Longitude,
                             ReceiveIdFrom = r.Start_Receive_ID,
                             dateTo = r.Stop_Date_Time,
                             LatTo = r.Stop_Latitude,
                             LonTo = r.Stop_Longitude,
                             ReceiveIdTo = r.Stop_Receive_ID,
                             Distance = r.Distance,
                             DriveTime = r.Drive_time,
                             RestTime = r.Rest_Time
                         };
            return routes;
        }

        [HttpGet]
        [Route("{id}")]
        public IEnumerable<Route> Get(long id)
        {
            var routes = (from r in this.db.Tracking_Object_Routes
                          where r.Trackin_Object_ID == id
                          orderby r.Start_Date_Time descending
                          select new Route
                          {
                              ID = r.Routes_ID,
                              VechicleID = r.Trackin_Object_ID.Value,
                              dateFrom = r.Start_Date_Time,
                              LatFrom = r.Start_Latitude,
                              LonFrom = r.Start_Longitude,
                              ReceiveIdFrom = r.Start_Receive_ID,
                              dateTo = r.Stop_Date_Time,
                              LatTo = r.Stop_Latitude,
                              LonTo = r.Stop_Longitude,
                              ReceiveIdTo = r.Stop_Receive_ID,
                              Distance = r.Distance,
                              DriveTime = r.Drive_time,
                              RestTime = r.Rest_Time
                          }).Take(1);
            
            return routes;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                db.Dispose();
            
            base.Dispose(disposing);
        }
    }
}

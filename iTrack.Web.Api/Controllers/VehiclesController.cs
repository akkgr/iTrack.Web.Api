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
    [RoutePrefix("api/vehicles")]
    public class VehiclesController : ApiController
    {
        private Entities.iTrackContext db;

        public VehiclesController()
        {
            db = new Entities.iTrackContext();
        }

        [HttpGet]
        [Route("")]
        public IEnumerable<Vehicle> Get()
        {
            string companies = Utils.WebAuth.GetCompanies(User);
            string vehicles = Utils.WebAuth.GetVehicles(User);

            if (companies == "0")
            {
                if (vehicles == "0")
                {
                    var vh = from c in this.db.Tracking_Objects
                             select new Vehicle
                             {
                                 ID = c.Trackin_Object_ID,
                                 Title = c.Name,
                                 CompanyID = c.Customer_ID,
                                 LastTrackID = c.Last_Track_ID,
                                 isSelected = true
                             };
                    return vh;
                }
                else
                {
                    long[] arrayIDs = Utils.Converter.StringToLongArray(vehicles);

                    var vh = from c in this.db.Tracking_Objects
                             where arrayIDs.Contains(c.Trackin_Object_ID)
                             select new Vehicle
                             {
                                 ID = c.Trackin_Object_ID,
                                 Title = c.Name,
                                 CompanyID = c.Customer_ID,
                                 LastTrackID = c.Last_Track_ID,
                                 isSelected = true
                             };
                    return vh;
                }
            }
            else
            {
                if (vehicles == "0")
                {
                    long[] arrayIDs = Utils.Converter.StringToLongArray(companies);

                    var vh = from c in this.db.Tracking_Objects
                             where arrayIDs.Contains(c.Customer_ID.Value)
                             select new Vehicle
                             {
                                 ID = c.Trackin_Object_ID,
                                 Title = c.Name,
                                 CompanyID = c.Customer_ID,
                                 LastTrackID = c.Last_Track_ID,
                                 isSelected = true
                             };
                    return vh;
                }
                else
                {
                    long[] arrayIDsC = Utils.Converter.StringToLongArray(companies);
                    long[] arrayIDsV = Utils.Converter.StringToLongArray(vehicles);
                    var vh = from c in this.db.Tracking_Objects
                             where arrayIDsC.Contains(c.Customer_ID.Value)
                             && arrayIDsV.Contains(c.Trackin_Object_ID)
                             select new Vehicle
                             {
                                 ID = c.Trackin_Object_ID,
                                 Title = c.Name,
                                 CompanyID = c.Customer_ID,
                                 LastTrackID = c.Last_Track_ID,
                                 isSelected = true
                             };
                    return vh;
                }
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                db.Dispose();

            base.Dispose(disposing);
        }
    }
}

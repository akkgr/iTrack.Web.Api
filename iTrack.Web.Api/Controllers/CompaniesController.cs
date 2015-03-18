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
    [RoutePrefix("api/companies")]
    public class CompaniesController : ApiController
    {
        private Entities.iTrackContext db;

        public CompaniesController()
        {
            db = new Entities.iTrackContext();
        }

        [HttpGet]
        [Route("{companies}")]
        public IEnumerable<Company> Get(string companies)
        {
            if (companies == "0")
            {
                var cmp = from c in this.db.Customers
                          select new Company
                          {
                              ID = c.Customer_ID,
                              Title = c.Company_Name
                          };
                return cmp;
            }
            else
            {
                long[] arrayIDs = Utils.Converter.StringToLongArray(companies);

                var cmp = from c in this.db.Customers
                          where arrayIDs.Contains(c.Customer_ID)
                          select new Company
                          {
                              ID = c.Customer_ID,
                              Title = c.Company_Name
                          };
                return cmp;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Web;

namespace iTrack.Web.Api.Utils
{
    public static class WebAuth
    {
        public static string GetCompanies(IPrincipal User)
        {
            var claim = User.Identity as ClaimsIdentity;
            var value = claim.Claims.Where(c => c.Type == ClaimTypes.Country)
                        .Select(c => c.Value).SingleOrDefault();
            
            return value;
        }

        public static string GetVehicles(IPrincipal User)
        {
            var claim = User.Identity as ClaimsIdentity;
            var value = claim.Claims.Where(c => c.Type == ClaimTypes.StateOrProvince)
                        .Select(c => c.Value).SingleOrDefault();
           
            return value;
        }
    }
}
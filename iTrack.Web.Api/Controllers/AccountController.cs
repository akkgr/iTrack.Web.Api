using Microsoft.Owin.Security.Cookies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace iTrack.Web.Api.Controllers
{
    [Authorize]
    public class AccountController : ApiController
    {
        public string GetCurrentUserName()
        {
            return Request.GetOwinContext().Authentication.User.Identity.Name;
        }

        public IHttpActionResult Logout()
        {
            Request.GetOwinContext().Authentication.SignOut(CookieAuthenticationDefaults.AuthenticationType);
            return Ok();
        }
    }
}

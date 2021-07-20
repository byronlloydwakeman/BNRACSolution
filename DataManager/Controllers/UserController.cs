using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNet.Identity;

namespace DataManager.Controllers
{
    public class UserController : ApiController
    {
        [HttpGet]
        [Authorize]
        public string GetUserId()
        {
            string userId = RequestContext.Principal.Identity.GetUserId();

            return userId;
        }
    }
}

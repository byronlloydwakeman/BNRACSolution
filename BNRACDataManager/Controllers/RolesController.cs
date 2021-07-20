using BNRACDataManager.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BNRACDataManager.Controllers
{
    [Authorize(Roles = "God,Admin")]
    public class RolesController : ApiController
    {
        [HttpPost]
        [Route("api/Roles/AddRole")]
        public void AddRole(UserRoleBEModel userRoleBEModel)
        {
            using (var context = new ApplicationDbContext())
            {
                var userStore = new UserStore<ApplicationUser>(context);
                var userManager = new UserManager<ApplicationUser>(userStore);

                userManager.AddToRole(userRoleBEModel.UserID, userRoleBEModel.RoleName);
            }
        }

        [HttpPost]
        [Route("api/Roles/RemoveRole")]
        public void RemoveRole(UserRoleBEModel userRoleBEModel)
        {
            using (var context = new ApplicationDbContext())
            {
                var userStore = new UserStore<ApplicationUser>(context);
                var userManager = new UserManager<ApplicationUser>(userStore);

                userManager.RemoveFromRole(userRoleBEModel.UserID, userRoleBEModel.RoleName);
            }
        }

    }
}

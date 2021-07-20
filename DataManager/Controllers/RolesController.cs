using DataManager.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using UI.Library.Models;

namespace DataManager.Controllers
{
    [Authorize(Roles = "God,Admin")]
    public class RolesController : ApiController
    {
        [HttpPost]
        public void AddARole(UserRoleUIModel userRoleBEModel)
        {
            using (var context = new ApplicationDbContext())
            {
                var userStore = new UserStore<ApplicationUser>(context);
                var userManager = new UserManager<ApplicationUser>(userStore);

                userManager.AddToRole(userRoleBEModel.UserID, userRoleBEModel.RoleName);
            }
        }

        [HttpPost]
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
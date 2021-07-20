using Autofac;
using DataManager.Library.AutoFac;
using DataManager.Library.Data;
using DataManager.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BNRACDataManager.Controllers
{
    public class AutoClickController : ApiController
    {
        //[Route("api/[Controller]")]
        private readonly IAutoClickFormattedData _data;
        public AutoClickController()
        {
            using (ILifetimeScope scope = ContainerConfig.Configure().BeginLifetimeScope())
            {
                _data = scope.Resolve<IAutoClickFormattedData>();
            }
        }

        //[Authorize(Roles = "Member,Admin,God")]
        [HttpGet]
        public List<AutoClickModel> GetModelsWithGivenRequirements(int Strength, int Stamina, int Durability, string EnumItems, EnumQuirk Quirk)
        {
            return _data.GetModelsWithGivenRequirements(Strength, Stamina, Durability, EnumItems, Quirk);
        }

        //[Authorize(Roles = "Admin,God")]
        [HttpPost]
        public void InsertAutoClickModel(AutoClickModel model)
        {
            _data.InsertAutoClickModel(model);
        }
    }
}

using DataManager.Library.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataManager.Library.Models;
using Autofac;
using UI.Library.AutoFac;
using DataManager.Library.Data;
using UI.Library.API.Endpoints;
using UI.Library.API;
using UI.Library.Models;
using System.Windows.Forms;

namespace ConsoleForTesting
{
    public class Program                                                 
    {
        static async Task Main(string[] args)
        {

            //using (ILifetimeScope scope = ContainerConfig.Configure().BeginLifetimeScope())
            //{
            //    var b = scope.Resolve<IAPIHelper>();
            //    await b.Login("byzstorm1103@gmail.com", "Password123");

            //    var a = scope.Resolve<IAutoClickEndpoint>();
            //    var list = await a.GetModelsWithGivenRequirements(100, 100, 100, ";ChristmasArmor;", EnumQuirk.Electric);

            //    foreach (var item in list)
            //    {
            //        Console.WriteLine(item);
            //    }

            //    //var roleEndpoint = scope.Resolve<IRolesEndpoint>();
            //    //var userEndpoint = scope.Resolve<IUserEndpoint>();

            //    //string userId = await userEndpoint.GetUserId();
                                                                                                    
            //    //await roleEndpoint.AddRole(new UserRoleUIModel() { RoleName = "Member", UserID = userId });



            //    Console.ReadKey();
            //}
             
            while (true)
            {
                SendKeys.SendWait(" ");
            }

        }
    }
}

using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Library.API;
using UI.Library.API.Endpoints;

namespace UI.Library.AutoFac
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<AutoClickEndpoint>().As<IAutoClickEndpoint>();
            builder.RegisterType<APIHelper>().As<IAPIHelper>().SingleInstance();
            builder.RegisterType<RolesEndpoint>().As<IRolesEndpoint>();
            builder.RegisterType<UserEndpoint>().As<IUserEndpoint>();

            return builder.Build();
        }
    }
}

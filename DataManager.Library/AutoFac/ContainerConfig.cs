using Autofac;
using DataManager.Library.Conversion;
using DataManager.Library.Data;
using DataManager.Library.DataAccess;
using DataManager.Library.DataFormatting;
using DataManager.Library.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager.Library.AutoFac
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<FormatData>().As<IFormatData>();
            builder.RegisterType<DeformatData>().As<IDeformatData>();
            builder.RegisterType<SqlDataAccess>().As<ISqlDataAccess>();
            builder.RegisterType<ValidateAutoClickDBModels>().As<IValidateAutoClickDBModels>();
            builder.RegisterType<ConvertEnum>().As<IConvertEnum>();
            builder.RegisterType<ConvertModels>().As<IConvertModels>();
            builder.RegisterType<AutoClickFormattedData>().As<IAutoClickFormattedData>();
            builder.RegisterType<AutoClickData>().As<IAutoClickData>();

            return builder.Build();
        }
    }
}

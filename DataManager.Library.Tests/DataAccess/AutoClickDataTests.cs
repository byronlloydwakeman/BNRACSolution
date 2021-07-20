using Autofac;
using DataManager.Library.AutoFac;
using DataManager.Library.DataAccess;
using DataManager.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataManager.Library.Tests.DataAccess
{
    public class AutoClickDataTests
    {
        private IAutoClickData _autoClickData;
        public AutoClickDataTests()
        {
            using (ILifetimeScope scope = ContainerConfig.Configure().BeginLifetimeScope())
            {
                _autoClickData = scope.Resolve<IAutoClickData>();
            }
        }

        [Theory]
        [InlineData(100, 100, 100, EnumQuirk.Electric)]
        public void GetDBModelsWithGivenRequirementsShouldWork(int str, int dur, int stam, EnumQuirk quirk)
        {
            List<AutoClickDBModel> models = _autoClickData.GetDBModelsWithGivenRequirements(str, stam, dur, quirk.ToString());

            bool actual = true;

            //Check model stats
            foreach (var model in models)
            {
                if(!(model.Quirk == quirk.ToString()))
                {
                    actual = false;
                }
                if (model.MinimumDurability > dur || model.MinimumStamina > stam || model.MinimumStrength > stam)
                {
                    actual = false;
                }
            }

            Assert.True(actual);
        }
    }
}
